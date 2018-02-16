using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;

namespace Tmds.Gir
{
    class Generator
    {
        private readonly AdhocWorkspace _workspace;
        private readonly SyntaxGenerator _generator;

        public Generator()
        {
            _workspace = new AdhocWorkspace();
            _generator = SyntaxGenerator.GetGenerator(_workspace, LanguageNames.CSharp);
        }

        public string Generate(Namespace ns)
        {
            var importDeclarations = new[] {
                _generator.NamespaceImportDeclaration("System"),
                _generator.NamespaceImportDeclaration(_generator.DottedName("System.Runtime.InteropServices"))
            };
            var interopClass = GenerateInteropClass(ns);
            var namespaceDeclaration = _generator.NamespaceDeclaration(ns.Name, interopClass);
            var declarations = importDeclarations
                               .Concat(new[] { namespaceDeclaration });
            var compilationUnit = _generator.CompilationUnit(declarations);
            return compilationUnit.NormalizeWhitespace().ToFullString();
        }

        private SyntaxNode GenerateInteropClass(Namespace ns)
        {
            string className = $"{ns.Name}Interop";
            var members = new List<SyntaxNode>();
            AddFunctionMethods(ns, ns.Functions, members);
            foreach (var type in ns.Types)
            {
                var functions = GetFunctions(type);
                AddFunctionMethods(ns, functions, members);
            }
            return _generator.ClassDeclaration(className, null, Accessibility.Public, DeclarationModifiers.Static, null, null, members);
        }

        private static void AddFunctionMethods(Namespace ns, List<Function> functions, List<SyntaxNode> members)
        {
            if (functions == null)
            {
                return;
            }
            foreach (var function in functions)
            {
                string functionName = function.CIdentifier;
                string returnType = MarshallAsType(function.Return);
                if (returnType == null)
                {
                    continue;
                }
                bool unknownType = false;
                ParameterSyntax[] parameters = function.Parameters.Count == 0 ? null : new ParameterSyntax[function.Parameters.Count];
                for (int i = 0; i < function.Parameters.Count; i++)
                {
                    Parameter p = function.Parameters[i];
                    var parameterType = MarshallAsType(p);
                    if (parameterType == null)
                    {
                        unknownType = true;
                        break;
                    }
                    parameters[i] = SyntaxFactory.Parameter(
                        attributeLists: default(SyntaxList<AttributeListSyntax>),
                        modifiers: default(SyntaxTokenList),
                        type: SyntaxFactory.IdentifierName(parameterType),
                        identifier: SyntaxFactory.Identifier(EscapeIdentifier(p.Name)),
                        @default: null);
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
                var method = SyntaxFactory.MethodDeclaration(
                    attributeLists: new SyntaxList<AttributeListSyntax>(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("DllImport"), SyntaxFactory.AttributeArgumentList(
                            SyntaxFactory.SeparatedList<AttributeArgumentSyntax>(new[] { SyntaxFactory.AttributeArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(libraryName)))})
                        ))))),
                    modifiers: SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword), SyntaxFactory.Token(SyntaxKind.ExternKeyword)),
                    returnType: SyntaxFactory.IdentifierName(returnType),
                    explicitInterfaceSpecifier: default(ExplicitInterfaceSpecifierSyntax),
                    identifier: SyntaxFactory.Identifier(functionName),
                    typeParameterList: null,
                    parameterList: SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList<ParameterSyntax>(parameters)),
                    constraintClauses: default(SyntaxList<TypeParameterConstraintClauseSyntax>),
                    body: null,
                    expressionBody: null,
                    semicolonToken: SyntaxFactory.Token(SyntaxKind.SemicolonToken));
                members.Add(method);
            }
        }

        private static string EscapeIdentifier(string identifier)
        {
            var needsEscaping = SyntaxFacts.GetKeywordKind(identifier) != SyntaxKind.None;
            return needsEscaping ? "@" + identifier : identifier;
        }

        private static string MarshallAsType(Parameter p)
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
                Console.WriteLine(gen.Generate(ns));
            }
        }
    }
}
