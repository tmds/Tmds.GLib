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
            AddInteropClass(ns);
            _sb.Append("}\n");
            return _sb.ToString();
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
                string returnType = MarshallAsType(function.Return, function);
                if (returnType == null)
                {
                    continue;
                }
                bool unknownType = false;
                ParameterInfo[] parameters = function.Parameters.Count == 0 ? null : new ParameterInfo[function.Parameters.Count];
                for (int i = 0; i < function.Parameters.Count; i++)
                {
                    Parameter p = function.Parameters[i];
                    var parameterType = MarshallAsType(p, function);
                    if (parameterType == null)
                    {
                        unknownType = true;
                        break;
                    }
                    parameters[i] = new ParameterInfo
                    {
                        Type = parameterType,
                        Name = EscapeIdentifier(p.Name)
                    };
                }
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
                _sb.AppendFormat("\t\tpublic static extern {0} {1}(", returnType, functionName);
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        _sb.AppendFormat("{0} {1}", parameters[i].Type, parameters[i].Name);
                        if (i != parameters.Length - 1)
                        {
                            _sb.Append(", ");
                        }
                    }
                }
                _sb.Append(");\n");
            }
        }

        private static readonly string[] s_keywords = new[]
        {
            "bool", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "double", "float", "decimal", "string", "char", "void", "object", "typeof", "sizeof", "null", "true", "false", "if", "else", "while", "for", "foreach", "do", "switch", "case", "default", "lock", "try", "throw", "catch", "finally", "goto", "break", "continue", "return", "public", "private", "internal", "protected", "static", "readonly", "sealed", "const", "fixed", "stackalloc", "volatile", "new", "override", "abstract", "virtual", "event", "extern", "ref", "out", "in", "is", "as", "params", "__arglist", "__makeref", "__reftype", "__refvalue", "this", "base", "namespace", "using", "class", "struct", "interface", "enum", "delegate", "checked", "unchecked", "unsafe", "operator", "implicit", "explicit"
        };

        private static string EscapeIdentifier(string identifier)
        {
            if (s_keywords.Contains(identifier))
            {
                return "@" + identifier;
            }
            return identifier;
        }

        private static string MarshallAsType(Parameter p, Function function)
        {
            GLibType type = p.Type;
            string cType = p.CType;
            (cType, type) = ResolveType(cType, type);
            bool isPointer = cType.EndsWith("*") || cType == "gpointer" || cType == "gconstpointer";
            bool isUtf8String = (type is FundamentalType fund && fund.Fundamental == Fundamental.Utf8);
            if (isPointer && !isUtf8String)
            {
                return "System.IntPtr";
            }
            if (type is ListType || type is HashTableType || type is CallbackType || type is ClassType || type is InterfaceType)
            {
                return "System.IntPtr";
            }
            if (type is BitfieldType || type is EnumerationType)
            {
                return "int";
            }
            if (type is FundamentalType f)
            {
                switch (f.Fundamental)
                {
                    case Fundamental.None: return "void";
                    case Fundamental.Boolean: return "int";
                    case Fundamental.Int8: return "sbyte";
                    case Fundamental.UInt8: return "byte";
                    case Fundamental.Int16: return "short";
                    case Fundamental.UInt16: return "ushort";
                    case Fundamental.Int32: return "int";
                    case Fundamental.UInt32: return "uint";
                    case Fundamental.Int64: return "long";
                    case Fundamental.UInt64: return "ulong";
                    case Fundamental.Pointer: return "System.IntPtr";
                    case Fundamental.Float: return "float";
                    case Fundamental.Double: return "double";
                    case Fundamental.Char: return "sbyte";
                    case Fundamental.UChar: return "byte";
                    case Fundamental.Short: return "short";
                    case Fundamental.UShort: return "ushort";
                    case Fundamental.Int: return "int";
                    case Fundamental.UInt: return "uint";
                    case Fundamental.IntPtr: return "System.IntPtr";
                    case Fundamental.UIntPtr: return "System.UIntPtr";
                    case Fundamental.UniChar: return "uint";
                    case Fundamental.Utf8: return "string";
                    case Fundamental.Filename: return "System.IntPtr";

                    // Note: this is 32-bit on Windows:
                    case Fundamental.Long: return "long";
                    case Fundamental.ULong: return "ulong";

                    // Note: this is 32-bit on a 32-bit system
                    case Fundamental.Type:
                    case Fundamental.Size: return "ulong";
                    case Fundamental.SSize: return "long";

                    // unsupported:
                    case Fundamental.VarArgs:
                    case Fundamental.LongDouble:
                    case Fundamental.VaList:
                        return null;
                }
            }
            return null;
        }

        private static (string cType, GLibType type) ResolveType(string cType, GLibType type)
        {
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
