using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Tmds.Gir
{
    class Generator
    {
        private readonly StringBuilder _sb = new StringBuilder();

        public Generator()
        {
        }

        public string Generate(Namespace ns)
        {
            _sb.Clear();
            foreach (var usingNamespace in new[] { "System",
                                                   "System.Runtime.InteropServices"})
            {
                _sb.AppendFormat("using {0};\n", usingNamespace);
            }
            _sb.AppendFormat("namespace {0} {{\n", ns.Name);
            AddTypes(ns);
            AddInteropClass(ns);
            _sb.Append("}\n");
            return _sb.ToString();
        }

        private void AddTypes(Namespace ns)
        {
            foreach (var type in ns.Types)
            {
                switch (type)
                {
                    case RecordType rec:
                    case ClassType cls:
                    case InterfaceType interf:
                        AddRefStruct(type);
                        break;
                    case EnumerationType en:
                        AddEnum(type, en.Members, flags: false);
                        break;
                    case BitfieldType bit:
                        AddEnum(type, bit.Members, flags: true);
                        break;
                }
            }
        }

        private void AddEnum(GLibType type, List<Member> members, bool flags)
        {
            if (flags)
            {
                _sb.Append("\t[Flags]\n");
            }
            _sb.AppendFormat("\tpublic enum {0}\n", type.Name);
            _sb.Append("\t{\n");
            foreach (var member in members)
            {
                string value = member.Value;
                if (!int.TryParse(value, out int res))
                {
                    if (uint.TryParse(value, out uint uintvalue))
                    {
                        value = $"unchecked((int){value}U)";
                    }
                    else
                    {
                        // skip
                        continue;
                    }
                }
                // TODO: prettify name
                _sb.AppendFormat("\t\t{0} = {1},\n", EscapeIdentifier(member.Name), value);
            }
            _sb.Append("\t}\n");
        }

        private bool InheritsGObject(GLibType type)
        {
            if (type == null)
            {
                return false;
            }
            if (type.FullName == "GObject.Object")
            {
                return true;
            }
            else if (type is ClassType cls)
            {
                return InheritsGObject(cls.Parent);
            }
            else
            {
                return false;
            }
        }

        private void AddRefStruct(GLibType type)
        {
            string getGLibType = null;
            switch(type)
            {
                case ClassType cls:
                    getGLibType = cls.GLibGetType;
                    break;
                case RecordType rec:
                    getGLibType = rec.GLibGetType;
                    break;
                case InterfaceType interf:
                    getGLibType = interf.GLibGetType;
                    break;
            }
            _sb.AppendFormat("\tpublic ref struct {0}\n", type.Name);
            _sb.Append("\t{\n");
            _sb.Append("\t\tprivate IntPtr _pointer;\n");
            _sb.AppendFormat("\t\tpublic {0}(IntPtr pointer, bool checkType = false)\n", type.Name);
            _sb.Append("\t\t{\n");
            if (getGLibType != null && InheritsGObject(type))
            {
                // g_type_check_instance_is_a
                _sb.Append("\t\t\tif (checkType)\n");
                _sb.Append("\t\t\t{\n");
                _sb.Append("\t\t\t\tGObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());\n");
                _sb.Append("\t\t\t}\n");
            }
            _sb.Append("\t\t\t_pointer = pointer;\n");
            _sb.Append("\t\t}\n");
            _sb.AppendFormat("\t\tpublic static explicit operator {0}(IntPtr pointer) => new {0}(pointer, checkType: true);\n", type.Name);
            _sb.AppendFormat("\t\tpublic static explicit operator IntPtr({0} value) => value._pointer;\n", type.Name);
            if (type is ClassType clsType)
            {
                ClassType parent = clsType.Parent as ClassType;
                while (parent != null)
                {
                    _sb.AppendFormat("\t\tpublic static implicit operator {0}({1} value) => new {0}((IntPtr)value, checkType: false);\n", parent.FullName, type.Name);
                    _sb.AppendFormat("\t\tpublic static explicit operator {0}({1} value) => new {0}((IntPtr)value, checkType: true);\n", type.Name, parent.FullName);
                    parent = parent.Parent as ClassType;
                }
            }
            GLibType functionType = type;
            HashSet<string> functionNames = new HashSet<string>();
            do
            {
                var functions = GetFunctions(functionType); // TODO: skip deprecated
                if (functions != null)
                {
                    foreach (Function function in functions)
                    {
                        (bool unknownType, ParameterInfo returnParameter, ParameterInfo[] argumentParameters) = InspectParameters(function);
                        if (unknownType)
                        {
                            continue;
                        }
                        if (functionNames.Contains(function.Name))
                        {
                            continue;
                        }
                        functionNames.Add(function.Name);
                        switch (function.Kind)
                        {
                            case FunctionKind.Constructor:
                            case FunctionKind.Function:
                            if (functionType == type)
                            {
                                _sb.AppendFormat("\t\tpublic static {0} {1}", returnParameter.Type, EscapeIdentifier(function.Name)); // TODO: prettify
                                AddArgumentList(param => $"{param.Modifier}{param.Type} {param.Name}", argumentParameters);
                                _sb.AppendFormat(" => {0}Interop.{1}", type.Namespace.Name, function.CIdentifier);
                                AddArgumentList(param => $"{param.Modifier}{param.Name}", argumentParameters);
                                _sb.Append(";\n");
                            }
                                break;
                            case FunctionKind.Method:
                                _sb.AppendFormat("\t\tpublic {0} {1}", returnParameter.Type, EscapeIdentifier(function.Name)); // TODO: prettify
                                AddArgumentList(param => $"{param.Modifier}{param.Type} {param.Name}", argumentParameters.Skip(1).ToList());
                                _sb.AppendFormat(" => {0}.{0}Interop.{1}", functionType.Namespace.Name, function.CIdentifier);
                                argumentParameters[0].Name = "this";
                                AddArgumentList(param => $"{param.Modifier}{param.Name}", argumentParameters);
                                _sb.Append(";\n");
                                break;
                        }
                    }
                }
                functionType = (functionType as ClassType)?.Parent;
            } while (functionType != null);
            if (getGLibType != null)
            {
                string libraryName = type.Namespace.SharedLibraries[0];
                _sb.AppendFormat("\t\t[DllImport(\"{0}\", EntryPoint = \"{1}\")]\n", libraryName, getGLibType);
                _sb.AppendFormat("\t\tpublic static extern GLib.GType TypeOf();\n");
            }
            _sb.Append("\t}\n");
        }

        private void AddInteropClass(Namespace ns)
        {
            _sb.AppendFormat("\tpublic static class {0}Interop {{\n", ns.Name);
            AddFunctionMethods(ns, ns.Functions);
            foreach (var type in ns.Types)
            {
                var functions = GetFunctions(type);
                AddFunctionMethods(ns, functions);
            }
            _sb.Append("\t}\n");
        }

        private struct ParameterInfo
        {
            public string Type;
            public string Name;
            public string Modifier;
        }

        private void AddFunctionMethods(Namespace ns, List<Function> functions)
        {
            if (functions == null)
            {
                return;
            }
            foreach (var function in functions)
            {
                string functionName = function.CIdentifier;
                (bool unknownType, ParameterInfo returnParameter, ParameterInfo[] argumentParameters) = InspectParameters(function);
                if (unknownType)
                {
                    continue;
                }
                if (ns.SharedLibraries.Count == 0)
                {
                    continue;
                }
                string libraryName = ns.SharedLibraries[0];
                _sb.AppendFormat("\t\t[DllImport(\"{0}\")]\n", libraryName);
                _sb.AppendFormat("\t\tpublic static extern {0} {1}", returnParameter.Type, functionName);
                AddArgumentList(param => $"{param.Modifier}{param.Type} {param.Name}", argumentParameters);
                _sb.Append(";\n");
            }
        }

        private void AddArgumentList<T>(Func<T, string> formatter, IList<T> arguments)
        {
            _sb.Append("(");
            if (arguments != null)
            {
                for (int i = 0; i < arguments.Count; i++)
                {
                    _sb.Append(formatter(arguments[i]));
                    if (i != arguments.Count - 1)
                    {
                        _sb.Append(", ");
                    }
                }
            }
            _sb.Append(")");
        }

        private (bool unknownType, ParameterInfo returnParameter, ParameterInfo[] argumentParameters) InspectParameters(Function function)
        {
            (_, string returnType) = MarshallAsType(function.Return, function);
            if (returnType == null)
            {
                return (true, default(ParameterInfo), null);
            }
            bool unknownType = false;
            ParameterInfo[] parameters = function.Parameters.Count == 0 ? null : new ParameterInfo[function.Parameters.Count];
            for (int i = 0; i < function.Parameters.Count; i++)
            {
                Parameter p = function.Parameters[i];
                (var modifier, var parameterType) = MarshallAsType(p, function);
                if (parameterType == null)
                {
                    unknownType = true;
                    break;
                }
                parameters[i] = new ParameterInfo
                {
                    Type = parameterType,
                    Name = EscapeIdentifier(p.Name),
                    Modifier = modifier
                };
            }
            if (unknownType)
            {
                return (true, default(ParameterInfo), null);
            }
            return (false, new ParameterInfo { Type = returnType }, parameters);
        }

        private static readonly string[] s_keywords = new[]
        {
            "bool", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "double", "float", "decimal", "string", "char", "void", "object", "typeof", "sizeof", "null", "true", "false", "if", "else", "while", "for", "foreach", "do", "switch", "case", "default", "lock", "try", "throw", "catch", "finally", "goto", "break", "continue", "return", "public", "private", "internal", "protected", "static", "readonly", "sealed", "const", "fixed", "stackalloc", "volatile", "new", "override", "abstract", "virtual", "event", "extern", "ref", "out", "in", "is", "as", "params", "__arglist", "__makeref", "__reftype", "__refvalue", "this", "base", "namespace", "using", "class", "struct", "interface", "enum", "delegate", "checked", "unchecked", "unsafe", "operator", "implicit", "explicit"
        };

        private static string EscapeIdentifier(string identifier)
        {
            if (char.IsDigit(identifier[0]))
            {
                identifier = "_" + identifier;
            }
            if (s_keywords.Contains(identifier))
            {
                return "@" + identifier;
            }
            return identifier;
        }

        private static (string modifier, string typeName) MarshallAsType(Parameter p, Function function)
        {
            GLibType type = p.Type;
            string cType = p.CType;

            (cType, type) = ResolveType(cType, type);

            int starCount = 0;
            while (cType.Length > 0 && cType[cType.Length - 1 - starCount] == '*') { starCount++; };

            bool enumType = type is BitfieldType || type is EnumerationType;
            bool byRefType = type is RecordType || type is ClassType || type is InterfaceType;
            if (byRefType)
            {
                if (starCount == 0)
                {
                    return (null, null);
                }
                starCount--;
                cType = cType.Substring(0, cType.Length - 1);
            }
            string typeName = null;
            string modifier = string.Empty;
            if (enumType || byRefType)
            {
                typeName = type.FullName;
                switch (p.Direction)
                {
                    case ParameterDirection.In:
                    case ParameterDirection.Return:
                        break;
                    case ParameterDirection.InOut:
                        modifier = "ref ";
                        break;
                    case ParameterDirection.Out:
                        modifier = "out ";
                        break;
                }
                if (string.IsNullOrEmpty(modifier))
                {
                    if (starCount != 0)
                    {
                        return (null, null);
                    }
                    return (modifier, typeName);
                }
                else
                {
                    if (starCount != 1)
                    {
                        return (null, null);
                    }
                    return (modifier, typeName);
                }
            }
            bool isPointer = cType.EndsWith("*") || (type is RecordType rec && rec.Disguised);
            bool isUtf8String = (type is FundamentalType fund && fund.Fundamental == Fundamental.Utf8);
            if (isPointer && !isUtf8String)
            {
                typeName = "System.IntPtr";
                return (modifier, typeName);
            }
            if (type is ListType || type is HashTableType || type is CallbackType || type is ClassType || type is InterfaceType)
            {
                typeName = "System.IntPtr";
                return (modifier, typeName);
            }
            if (type is FundamentalType f)
            {
                switch (f.Fundamental)
                {
                    case Fundamental.None: typeName = "void"; break;
                    case Fundamental.Boolean: typeName = "bool"; break;
                    case Fundamental.Int8: typeName = "sbyte"; break;
                    case Fundamental.UInt8: typeName = "byte"; break;
                    case Fundamental.Int16: typeName = "short"; break;
                    case Fundamental.UInt16: typeName = "ushort"; break;
                    case Fundamental.Int32: typeName = "int"; break;
                    case Fundamental.UInt32: typeName = "uint"; break;
                    case Fundamental.Int64: typeName = "long"; break;
                    case Fundamental.UInt64: typeName = "ulong"; break;
                    case Fundamental.Pointer: typeName = "System.IntPtr"; break;
                    case Fundamental.Float: typeName = "float"; break;
                    case Fundamental.Double: typeName = "double"; break;
                    case Fundamental.Char: typeName = "sbyte"; break;
                    case Fundamental.UChar: typeName = "byte"; break;
                    case Fundamental.Short: typeName = "short"; break;
                    case Fundamental.UShort: typeName = "ushort"; break;
                    case Fundamental.Int: typeName = "int"; break;
                    case Fundamental.UInt: typeName = "uint"; break;
                    case Fundamental.IntPtr: typeName = "System.IntPtr"; break;
                    case Fundamental.UIntPtr: typeName = "System.UIntPtr"; break;
                    case Fundamental.UniChar: typeName = "uint"; break;
                    case Fundamental.Utf8: typeName = "string"; break;
                    case Fundamental.Filename: typeName = "System.IntPtr"; break;

                    // Note: this is 32-bit on Windows:
                    case Fundamental.Long: typeName = "long"; break;
                    case Fundamental.ULong: typeName = "ulong"; break;

                    // Note: this is 32-bit on a 32-bit system
                    case Fundamental.Type: typeName = "GLib.GType";  break;// manually defined
                    case Fundamental.Size: typeName = "ulong"; break;
                    case Fundamental.SSize: typeName = "long"; break;

                    // unsupported:
                    case Fundamental.VarArgs:
                    case Fundamental.LongDouble:
                    case Fundamental.VaList:
                        typeName = null; break;
                }
            }
            return (modifier, typeName);
        }

        private static (string cType, GLibType type) ResolveType(string cType, GLibType type)
        {
            cType = cType.Replace("gpointer", "void*");
            cType = cType.Replace("gconstpointer", "void*");
            if (type is AliasType a)
            {
                cType = cType.Replace(a.CIdentifier, a.TargetCType);
                return ResolveType(cType, a.AliasedType); 
            }
            else
            {
                return (cType, type);
            }
        }

        private static List<Function> GetFunctions(GLibType type)
        {
            switch (type)
            {
                case BitfieldType b: return b.Functions;
                case ClassType c: return c.Functions;
                case InterfaceType i: return i.Functions;
                case EnumerationType e: return e.Functions;
                case RecordType r: return r.Functions;
                case UnionType u: return u.Functions;
                default: return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceCollection lib = GirParser.Parse("../../gir-files", "Gtk-3.0");
            foreach (var ns in lib.Namespaces)
            {
                Generator gen = new Generator();
                string code = gen.Generate(ns);
                File.WriteAllText($"../Tmds.GLib/Generated/{ns.Name}.Generated.cs", code);
                //Console.WriteLine(gen.Generate(ns));
            }
        }
    }
}
