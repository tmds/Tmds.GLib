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
        private readonly NamespaceCollection _namespaces;
        private bool _analyzed;
        private Dictionary<GLibType, TypeAnalysis> _typeAnalyses = new Dictionary<GLibType, TypeAnalysis>();
        public Generator(NamespaceCollection namespaces)
        {
            _namespaces = namespaces;
        }

        private void Analyze()
        {
            if (_analyzed)
            {
                return;
            }
            foreach (var ns in _namespaces.Namespaces)
            {
                AnalyzeFunctions(ns.Functions);
                foreach (var type in ns.Types)
                {
                    var functions = GetFunctions(type);
                    if (functions != null)
                    {
                        AnalyzeFunctions(functions);
                    }
                }
            }
            _analyzed = true;
        }

        private void AnalyzeFunctions(List<Function> functions)
        {
            foreach (var function in functions)
            {
                AnalyzeParameter(function.Return, function);
                foreach (var parameter in function.Parameters)
                {
                    AnalyzeParameter(parameter, function);
                }
            }
        }

        private void AnalyzeParameter(Parameter param, Function function)
        {
            (string cType, GLibType type) = ResolveType(param.CType, param.Type);

            int starCount = 0;
            while (cType.Length > 0 && cType[cType.Length - 1 - starCount] == '*') { starCount++; };
            if (param.Direction == ParameterDirection.Out || param.Direction == ParameterDirection.InOut)
            {
                starCount--;
                if (type is ListType listType && param.CallerAllocates)
                {
                    if (listType.ItemType != null)
                    {
                        // g_io_channel_read_chars -> guint8
                        // g_main_context_query    -> GLib.PollFD
                        GetTypeInfo(listType.ItemType).StarCount[0]++;
                    }
                    starCount++;
                }    
            }

            if (type is FundamentalType fun && (fun.Fundamental == Fundamental.Utf8) && starCount == 0)
            {
                // g_unichar_to_utf8
                return;
            }

            if (type is ListType && starCount == 0)
            {
                // g_base64_decode_inplace -> gchar*
                // g_base64_decode_step -> guchar*
                // g_base64_encode_close -> gchar*
                // g_base64_encode_step -> gchar*
                // g_key_file_set_boolean_list -> gboolean
                // g_key_file_set_double_list -> gdouble
                // g_key_file_set_integer_list -> gint
                // g_object_new_with_properties -> GValue
                // g_object_getv -> GValue
                // g_object_setv -> GValue
                starCount++;
            }

            GetTypeInfo(type).StarCount[starCount]++;
        }

        private TypeAnalysis GetTypeInfo(GLibType type)
        {
            TypeAnalysis info;
            if (!_typeAnalyses.TryGetValue(type, out info))
            {
                info = new TypeAnalysis(type);
                _typeAnalyses.Add(type, info);
            }
            return info;
        }

        public string Generate(string name)
        {
            Namespace ns =_namespaces.Namespaces.Where(_ => _.Name == name).First();

            Analyze();

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
                        {
                            bool isRefType = !_typeAnalyses.ContainsKey(rec) || _typeAnalyses[rec].IsRefType;
                            if (isRefType)
                            {
                                AddRefStruct(rec);
                            }
                            else
                            {
                                AddValueStruct(rec);
                            }
                        }
                        break;
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

        private void AddValueStruct(GLibType type)
        {
            // System.Console.WriteLine($"Adding value struct {type.FullName}");
            // _sb.AppendFormat("\tpublic struct {0}\n", type.Name);
            // _sb.Append("\t{\n");
            // _sb.Append("\t}\n");
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

        private class ParameterInfo
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

        private (string modifier, string typeName) MarshallAsType(Parameter p, Function function)
        {
            GLibType type = p.Type;
            string cType = p.CType;

            (cType, type) = ResolveType(cType, type);

            TypeAnalysis info;
            if (_typeAnalyses.TryGetValue(type, out info))
            {
                return info.DetermineInteropType(p);
            }
            else if (cType.EndsWith("*"))
            {
                return (string.Empty, "System.IntPtr");
            }
            else
            {
                return (null, null);
            }
        }

        internal static (string cType, GLibType type) ResolveType(string cType, GLibType type)
        {
            cType = cType.Replace("gpointer", "void*");
            cType = cType.Replace("gconstpointer", "void*");
            if (type is RecordType rec && rec.Disguised)
            {
                cType += "*";
            }
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
            Generator gen = new Generator(lib);
            foreach (var ns in lib.Namespaces)
            {
                string code = gen.Generate(ns.Name);
                File.WriteAllText($"../Tmds.GLib/Generated/{ns.Name}.Generated.cs", code);
                //Console.WriteLine(gen.Generate(ns));
            }
        }
    }
}
