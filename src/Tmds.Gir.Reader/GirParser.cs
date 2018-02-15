using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Tmds.Gir
{
    public class GirParser
    {
        public const string EmptyCType = "/*EMPTY*/";

        public static NamespaceCollection Parse(string dir, string lib)
        {
            NamespaceCollection nsc = new NamespaceCollection();
            ReadFile(nsc, dir, lib, filenames: new HashSet<string>());
            return nsc;
        }

        static class CNames
        {
            public static readonly XNamespace CNs = "http://www.gtk.org/introspection/c/1.0";

            public static readonly XName Type = CNs + "type";
            public static readonly XName Identifier = CNs + "identifier";
            public static readonly XName IdentifierPrefixes = CNs + "identifier-prefixes";
            public static readonly XName SymbolPrefixes = CNs + "symbol-prefixes";
        }

        static class GLibNames
        {
            public static readonly XNamespace GLibNs = "http://www.gtk.org/introspection/glib/1.0";

            public static readonly XName TypeName = GLibNs + "type-name";
            public static readonly XName TypeStruct = GLibNs + "type-struct";
            public static readonly new XName GetType = GLibNs + "get-type";
            public static readonly XName IsGTypeStructFor = GLibNs + "is-gtype-struct-for";
            public static readonly XName ErrorDomain = GLibNs + "error-domain";
        }

        static class CoreNames
        {
            public static readonly XNamespace CoreNs = "http://www.gtk.org/introspection/core/1.0";

            public static readonly XName Repository = CoreNs + "repository";
            public static readonly XName Version = CoreNs + "version";
            public static readonly XName DeprecatedVersion = CoreNs + "deprecated-version";
            public static readonly XName Include = CoreNs + "include";
            public static readonly XName Package = CoreNs + "package";
            public static readonly XName Namespace = CoreNs + "namespace";
            public static readonly XName Class = CoreNs + "class";
            public static readonly XName Enumeration = CoreNs + "enumeration";
            public static readonly XName Bitfield = CoreNs + "bitfield";
            public static readonly XName Interface = CoreNs + "interface";
            public static readonly XName Record = CoreNs + "record";
            public static readonly XName Union = CoreNs + "union";
            public static readonly XName Callback = CoreNs + "callback";
            public static readonly XName Function = CoreNs + "function";
            public static readonly XName Property = CoreNs + "property";
            public static readonly XName Implements = CoreNs + "implements";
            public static readonly XName Signal = CoreNs + "signal";
            public static readonly XName Field = CoreNs + "field";
            public static readonly XName Prerequisite = CoreNs + "prerequisite";
            public static readonly XName VirtualMethod = CoreNs + "virtual-method";
            public static readonly XName Alias = CoreNs + "alias";
            public static readonly XName Constant = CoreNs + "constant";
            public static readonly XName Constructor = CoreNs + "constructor";
            public static readonly XName Member = CoreNs + "member";
            public static readonly XName Doc = CoreNs + "doc";
            public static readonly XName DocDeprecated = CoreNs + "doc-deprecated";
            public static readonly XName Parameters = CoreNs + "parameters";
            public static readonly XName Parameter = CoreNs + "parameter";
            public static readonly XName InstanceParameter = CoreNs + "instance-parameter";
            public static readonly XName Method = CoreNs + "method";
            public static readonly XName ReturnValue = CoreNs + "return-value";
            public static readonly XName Varargs = CoreNs + "varargs";
            public static readonly XName Array = CoreNs + "array";
            public static readonly XName Type = CoreNs + "type";
        }

        private static void ReadFile(NamespaceCollection nsc, string dir, string lib, HashSet<string> filenames)
        {
            string filename = Path.Combine(dir, lib);
            filename += ".gir";
            try
            {
                if (filenames.Contains(filename))
                {
                    return;
                }
                filenames.Add(filename);

                XDocument doc = XDocument.Load(filename, LoadOptions.SetLineInfo | LoadOptions.SetBaseUri);
                if (doc.Root.Name == CoreNames.Repository)
                {
                    ReadRepository(nsc, dir, doc.Root, filenames);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Exception {e.Message}");
                throw;
            }
        }

        private static void ReadRepository(NamespaceCollection nsc, string dir, XElement repositoryElement, HashSet<string> filenames)
        {
            string package = null;
            foreach (var element in repositoryElement.Elements())
            {
                if (element.Name == CoreNames.Include)
                {
                    var lib = (string)element.Attribute("name");
                    var ver = (string)element.Attribute("version");
                    lib = $"{lib}-{ver}";
                    ReadFile(nsc, dir, lib, filenames);
                }
                else if (element.Name == CoreNames.Package)
                {
                    if (package == null)
                    {
                        package = (string)element.Attribute("name");
                    }
                }
                else if (element.Name == CoreNames.Namespace)
                {
                    ReadNamespace(nsc, element, package);
                }
            }
        }

        private static void ReadNamespace(NamespaceCollection nsc, XElement namespaceElement, string package)
        {
            var name = (string)namespaceElement.Attribute("name");
            var ns = nsc.ResolveNamespace(name);
            ns.PackageName = package;
            foreach (var prefix in ((string)namespaceElement.Attribute("shared-library"))?.Split(',') ?? Array.Empty<string>())
            {
                ns.SharedLibraries.Add(prefix);
            }
            foreach (var prefix in ((string)namespaceElement.Attribute(CNames.IdentifierPrefixes)).Split(','))
            {
                ns.IdentifierPrefixes.Add(prefix);
            }
            foreach (var prefix in ((string)namespaceElement.Attribute(CNames.SymbolPrefixes)).Split(','))
            {
                ns.SymbolPrefixes.Add(prefix);
            }
            foreach (var element in namespaceElement.Elements())
            {
                if (element.Name == CoreNames.Class)
                {
                    ReadClass(element, ns);
                }
                else if (element.Name == CoreNames.Record)
                {
                    (string recordName, RecordType record) = ReadRecord(element, ns);
                    ns.AddType(recordName, record);
                }
                else if (element.Name == CoreNames.Union)
                {
                    ReadNamedUnion(element, ns);
                }
                else if (element.Name == CoreNames.Interface)
                {
                    ReadInterface(element, ns);
                }
                else if (element.Name == CoreNames.Callback)
                {
                    ReadNamedCallback(element, ns);
                }
                else if (element.Name == CoreNames.Bitfield)
                {
                    ReadBitfield(element, ns);
                }
                else if (element.Name == CoreNames.Enumeration)
                {
                    ReadEnumeration(element, ns);
                }
                else if (element.Name == CoreNames.Function)
                {
                    ReadGlobalFunction(element, ns);
                }
                else if (element.Name == CoreNames.Constant)
                {
                    ReadConstant(element, ns);
                }
                else if (element.Name == CoreNames.Alias)
                {
                    ReadAlias(element, ns);
                }
            }
        }

        private static void ReadAlias(XElement aliasElement, Namespace ns)
        {
            var aliasName = (string)aliasElement.Attribute("name");
            var cIdentifier = (string)aliasElement.Attribute(CNames.Type);
            TypeName? typeId = null;
            string cType = null;
            int? arrayLength = null;
            string doc = null;
            foreach (var element in aliasElement.Elements())
            {
                if (element.Name == CoreNames.Type
                 || element.Name == CoreNames.Array)
                {
                    if (typeId.HasValue)
                    {
                        throw NewInvalidDataException("Too many <type> elements", aliasElement);
                    }
                    (typeId, cType, arrayLength) = ReadType(ns, element);
                    if (cType == null)
                    {
                        throw NewInvalidDataException("Missing alias target's c:type", aliasElement);
                    }
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
            }
            if (!typeId.HasValue)
            {
                throw NewInvalidDataException("Missing <type> element", aliasElement);
            }
            var alias = new AliasType
            {
                CIdentifier = cIdentifier,
                AliasedTypeName = typeId.Value,
                TargetCType = cType,
                Doc = doc
            };
            ns.AddType(aliasName, alias);
        }

        private static void ReadConstant(XElement constantElement, Namespace ns)
        {
            var constName = (string)constantElement.Attribute("name");
            var cIdentifier = (string)constantElement.Attribute(CNames.Type);
            var value = (string)constantElement.Attribute("value");
            var version = ParseVersion(ns, (string)constantElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)constantElement.Attribute(CoreNames.DeprecatedVersion));
            TypeName? typeId = null;
            string cType = null;
            int? arrayLength = null;
            string doc = null;
            string docDeprecated = null;
            foreach (var element in constantElement.Elements())
            {
                if (element.Name == CoreNames.Type
                 || element.Name == CoreNames.Array)
                {
                    if (typeId.HasValue)
                    {
                        throw NewInvalidDataException("Too many <type> elements", constantElement);
                    }
                    (typeId, cType, arrayLength) = ReadType(ns, element);
                    if (cType == null)
                    {
                        throw NewInvalidDataException("Missing constant's c:type", constantElement);
                    }
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.DocDeprecated)
                {
                    docDeprecated = element.Value;
                }
            }
            if (!typeId.HasValue)
            {
                throw NewInvalidDataException("Missing <type> element", constantElement);
            }
            ns.Constants.Add(new Constant
            {
                Name = constName,
                CIdentifier = cIdentifier,
                TypeName = typeId.Value,
                CType = cType,
                Value = value,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc,
                DocDeprecated = docDeprecated
            });
        }

        private static void ReadGlobalFunction(XElement element, Namespace ns)
        {
            var function = ReadFunctionIfNotMoved(ns, "global", element);
            if (function != null)
            {
                if (function.CIdentifier == null)
                {
                    throw NewInvalidDataException("Missing c:identifier attribute", element);
                }
                ns.Functions.Add(function);
            }
        }

        private static void ReadEnumeration(XElement enumerationElement, Namespace ns)
        {
            var enumerationName = (string)enumerationElement.Attribute("name");
            var cType = (string)enumerationElement.Attribute(CNames.Type);
            var getType = (string)enumerationElement.Attribute(GLibNames.GetType);
            var version = ParseVersion(ns, (string)enumerationElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)enumerationElement.Attribute(CoreNames.DeprecatedVersion));
            string errorDomain = (string)enumerationElement.Attribute(GLibNames.ErrorDomain);
            var members = new List<Member>();
            var functions = new List<Function>();
            string doc = null;
            string docDeprecated = null;
            foreach (var element in enumerationElement.Elements())
            {
                if (element.Name == CoreNames.Constructor
                 || element.Name == CoreNames.Function
                 || element.Name == CoreNames.Method)
                {
                    ReadFunctionAndAddTo(ns, element, functions);
                }
                else if (element.Name == CoreNames.Member)
                {
                    members.Add(ReadMember(element));
                }
                else if (element.Name == CoreNames.VirtualMethod)
                {
                    // ignore
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.DocDeprecated)
                {
                    docDeprecated = element.Value;
                }
            }
            var enumeration = new EnumerationType
            {
                CType = cType,
                Members = members,
                Functions = functions,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc,
                DocDeprecated = docDeprecated,
                GLibGetType = getType,
                ErrorDomain = errorDomain
            };
            ns.AddType(enumerationName, enumeration);
        }

        private static void ReadBitfield(XElement bitfieldElement, Namespace ns)
        {
            var bitfieldName = (string)bitfieldElement.Attribute("name");
            var cType = (string)bitfieldElement.Attribute(CNames.Type);
            var getType = (string)bitfieldElement.Attribute(GLibNames.GetType);
            var version = ParseVersion(ns, (string)bitfieldElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)bitfieldElement.Attribute(CoreNames.DeprecatedVersion));
            var members = new List<Member>();
            var functions = new List<Function>();
            string doc = null;
            string docDeprecated = null;
            foreach (var element in bitfieldElement.Elements())
            {
                if (element.Name == CoreNames.Constructor
                 || element.Name == CoreNames.Function
                 || element.Name == CoreNames.Method)
                {
                    ReadFunctionAndAddTo(ns, element, functions);
                }
                else if (element.Name == CoreNames.Member)
                {
                    members.Add(ReadMember(element));
                }
                else if (element.Name == CoreNames.VirtualMethod)
                {
                    // ignore
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.DocDeprecated)
                {
                    docDeprecated = element.Value;
                }
            }
            var bitfield = new BitfieldType
            {
                CType = cType,
                Members = members,
                Functions = functions,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc,
                DocDeprecated = docDeprecated,
                GLibGetType = getType
            };
            ns.AddType(bitfieldName, bitfield);
        }

        private static Member ReadMember(XElement memberElement)
        {
            var memberName = (string)memberElement.Attribute("name");
            var value = (string)memberElement.Attribute("value");
            var cIdentifier = (string)memberElement.Attribute(CNames.Identifier);
            string doc = null;
            foreach (var element in memberElement.Elements())
            {
                if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
            }
            return new Member
            {
                Name = memberName,
                Value = value,
                Doc = doc,
                CIdentifier = cIdentifier ?? memberName
            };
        }

        private static void ReadNamedCallback(XElement element, Namespace ns)
        {
            Function function = ReadFunctionIfNotMoved(ns, element.Name.LocalName, element);
            if (function != null)
            {
                ns.AddType(function.Name, new CallbackType { Function = function });
            }
        }

        private static void ReadInterface(XElement interfaceElement, Namespace ns)
        {
            var interfaceName = (string)interfaceElement.Attribute("name");
            var cType = (string)interfaceElement.Attribute(CNames.Type);
            var typeStruct = (string)interfaceElement.Attribute(GLibNames.TypeStruct);
            var getType = (string)interfaceElement.Attribute(GLibNames.GetType);
            var version = ParseVersion(ns, (string)interfaceElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)interfaceElement.Attribute(CoreNames.DeprecatedVersion));
            var functions = new List<Function>();
            var signals = new List<Signal>();
            var properties = new List<Property>();
            var prerequisites = new List<TypeName>();
            string doc = null;
            foreach (var element in interfaceElement.Elements())
            {
                if (element.Name == CoreNames.Constructor
                 || element.Name == CoreNames.Function
                 || element.Name == CoreNames.Method)
                {
                    ReadFunctionAndAddTo(ns, element, functions);
                }
                else if (element.Name == CoreNames.Prerequisite)
                {
                    prerequisites.Add(ReadType(ns, element).type);
                }
                else if (element.Name == CoreNames.Signal)
                {
                    ReadSignalAndAddTo(ns, element, signals);
                }
                else if (element.Name == CoreNames.Property)
                {
                    ReadPropertyAndAddTo(ns, element, properties);
                }
                else if (element.Name == CoreNames.VirtualMethod)
                {
                    // ignore
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
            }
            var interf = new InterfaceType
            {
                CType = cType,
                TypeStruct = typeStruct,
                CClassType = null, // this will be resolved during postprocessing
                GLibGetType = getType,
                Functions = functions,
                Signals = signals,
                Properties = properties,
                PrerequisitesNames = prerequisites,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc
            };
            ns.AddType(interfaceName, interf);
        }

        private static void ReadNamedUnion(XElement element, Namespace ns)
        {
            (string unionName, UnionType union) = ReadUnion(ns, element);
            // union named '_Value__data__union' is missing a c:type
            if (unionName == "_Value__data__union")
            {
                union.CType = "GValue_data";
            }
            if (union.CType == null)
            {
                throw NewInvalidDataException("Missing union c:type", element);
            }
            ns.AddType(unionName, union);
        }

        private static Exception NewInvalidDataException(string reason, XElement element)
        {
            var lineInfo = (IXmlLineInfo)element;
            string message = $"Error while parsing {element.BaseUri}:{lineInfo.LineNumber}: {reason}\n{element}";
            return new InvalidDataException(message);
        }

        private static (string name, RecordType Type) ReadRecord(XElement recordElement, Namespace ns)
        {
            var recordName = (string)recordElement.Attribute("name");
            var cType = (string)recordElement.Attribute(CNames.Type);
            var getType = (string)recordElement.Attribute(GLibNames.GetType);
            var gtypeStructFor = (string)recordElement.Attribute(GLibNames.IsGTypeStructFor);
            var version = ParseVersion(ns, (string)recordElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)recordElement.Attribute(CoreNames.DeprecatedVersion));
            var functions = new List<Function>();
            var fields = new List<Field>();
            string doc = null;
            string docDeprecated = null;
            foreach (var element in recordElement.Elements())
            {
                if (element.Name == CoreNames.Constructor
                 || element.Name == CoreNames.Function
                 || element.Name == CoreNames.Method)
                {
                    ReadFunctionAndAddTo(ns, element, functions);
                }
                else if (element.Name == CoreNames.Field)
                {
                    var field = ReadField(ns, element);
                    fields.Add(field);
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.DocDeprecated)
                {
                    docDeprecated = element.Value;
                }
                else if (element.Name == CoreNames.Union)
                {
                    (string fieldName, UnionType union) = ReadUnion(ns, element);
                    var typeId = ns.AddType(null, union);
                    fields.Add(new Field
                    {
                        Name = fieldName,
                        TypeName = typeId,
                        Doc = union.Doc,
                        CType = union.CType
                    });
                }
            }
            // the gir definitions don't reflect the following correctly
            // typedef struct _GdkAtom *GdkAtom;
            if (recordName == "Atom" && ns.Name == "Gdk")
            {
                recordName = "Atom_";
                cType = "GdkAtom_";
                var typeId = ns.ResolveTypeName("Gdk.Atom_");
                ns.AddType("Atom", new AliasType
                {
                    CIdentifier = "GdkAtom",
                    AliasedTypeName = typeId,
                    TargetCType = "GdkAtom_*",
                    Doc = null
                });
            }

            return (recordName, new RecordType
            {
                CType = cType,
                GLibGetType = getType,
                GTypeStructFor = gtypeStructFor,
                Fields = fields,
                Functions = functions,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc,
                DocDeprecated = docDeprecated
            });
        }

        private static void ReadClass(XElement classElement, Namespace ns)
        {
            var className = (string)classElement.Attribute("name");
            var cType = (string)classElement.Attribute(CNames.Type) ?? (string)classElement.Attribute(GLibNames.TypeName);
            var typeStruct = (string)classElement.Attribute(GLibNames.TypeStruct);
            var getType = (string)classElement.Attribute(GLibNames.GetType);
            var version = ParseVersion(ns, (string)classElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)classElement.Attribute(CoreNames.DeprecatedVersion));
            var functions = new List<Function>();
            var implements = new List<TypeName>();
            var signals = new List<Signal>();
            var properties = new List<Property>();
            var fields = new List<Field>();
            string doc = null;
            foreach (var element in classElement.Elements())
            {
                if (element.Name == CoreNames.Constructor
                 || element.Name == CoreNames.Function
                 || element.Name == CoreNames.Method)
                {
                    ReadFunctionAndAddTo(ns, element, functions);
                }
                else if (element.Name == CoreNames.Implements)
                {
                    implements.Add(ReadType(ns, element).type);
                }
                else if (element.Name == CoreNames.Signal)
                {
                    ReadSignalAndAddTo(ns, element, signals);
                }
                else if (element.Name == CoreNames.Property)
                {
                    ReadPropertyAndAddTo(ns, element, properties);
                }
                else if (element.Name == CoreNames.Field)
                {
                    fields.Add(ReadField(ns, element));
                }
                else if (element.Name == CoreNames.VirtualMethod)
                {
                    // ignore
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.Union)
                {
                    (string fieldName, UnionType union) = ReadUnion(ns, element);
                    var typeId = ns.AddType(null, union);
                    fields.Add(new Field
                    {
                        Name = fieldName,
                        TypeName = typeId,
                        Doc = union.Doc,
                        CType = union.CType
                    });
                }
            }
            var parentName = (string)classElement.Attribute("parent");
            TypeName? parent = null;
            if (parentName != null)
            {
                parent = ns.ResolveTypeName(parentName);
            }
            var cls = new ClassType
            {
                CType = cType,
                TypeStruct = typeStruct,
                CClassType = null, // this will be resolved during postprocessing
                GLibGetType = getType,
                Fields = fields,
                Functions = functions,
                Signals = signals,
                Properties = properties,
                ParentTypeName = parent,
                ImplementsNames = implements,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc
            };
            ns.AddType(className, cls);
        }

        private static (string name, UnionType type) ReadUnion(Namespace ns, XElement unionElement)
        {
            var unionName = (string)unionElement.Attribute("name");
            var cType = (string)unionElement.Attribute(CNames.Type);
            var getType = (string)unionElement.Attribute(GLibNames.GetType);
            var functions = new List<Function>();
            var fields = new List<Field>();
            string doc = null;
            foreach (var element in unionElement.Elements())
            {
                if (element.Name == CoreNames.Constructor
                 || element.Name == CoreNames.Function
                 || element.Name == CoreNames.Method)
                {
                    ReadFunctionAndAddTo(ns, element, functions);
                }
                else if (element.Name == CoreNames.Field)
                {
                    fields.Add(ReadField(ns, element));
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.Record)
                {
                    (string fieldName, RecordType record) = ReadRecord(element, ns);
                    var typeId = ns.AddType(null, record);
                    fields.Add(new Field
                    {
                        Name = fieldName,
                        TypeName = typeId,
                        Doc = record.Doc,
                        CType = record.CType
                    });
                }
            }
            return (unionName, new UnionType
            {
                CType = cType,
                GLibGetType = getType,
                Fields = fields,
                Functions = functions,
                Doc = doc
            });
        }

        private static Field ReadField(Namespace ns, XElement fieldElement)
        {
            var fieldName = (string)fieldElement.Attribute("name");
            bool priv = (string)fieldElement.Attribute("private") == "1";
            int? bits = (int?)fieldElement.Attribute("bits");
            TypeName? typeId = null;
            string cType = null;
            int? arrayLength = null;
            string doc = null;
            foreach (var element in fieldElement.Elements())
            {
                if (element.Name == CoreNames.Type
                 || element.Name == CoreNames.Array)
                {
                    if (typeId.HasValue)
                    {
                        throw NewInvalidDataException("Too many <type> elements", fieldElement);
                    }
                    (typeId, cType, arrayLength) = ReadType(ns, element);
                }
                else if (element.Name == CoreNames.Callback)
                {
                    if (typeId.HasValue)
                    {
                        throw NewInvalidDataException("Too many <type> elements", fieldElement);
                    }
                    var function = ReadFunction(ns, element.Name.LocalName, element);
                    var callback = new CallbackType { Function = function };
                    typeId = ns.AddType(null, callback);
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
            }
            if (!typeId.HasValue)
            {
                throw NewInvalidDataException("Missing <type> element", fieldElement);
            }
            return new Field
            {
                Name = fieldName,
                TypeName = typeId.Value,
                CType = cType,
                Private = priv,
                Bits = bits,
                ArrayLength = arrayLength,
                Doc = doc
            };
        }

        private static void ReadPropertyAndAddTo(Namespace ns, XElement element, List<Property> properties)
        {
            Property property = ReadProperty(ns, element);
            if (property != null)
            {
                properties.Add(property);
            }
        }

        private static Property ReadProperty(Namespace ns, XElement propertyElement)
        {
            string propertyName = (string)propertyElement.Attribute("name");
            bool readable = (string)propertyElement.Attribute("readable") != "0";
            bool writable = (string)propertyElement.Attribute("writable") == "1";
            bool construct = (string)propertyElement.Attribute("construct") == "1";
            bool constructOnly = (string)propertyElement.Attribute("construct-only") == "1";
            Transfer transfer = ParseTransfer((string)propertyElement.Attribute("transfer-ownership"));
            var version = ParseVersion(ns, (string)propertyElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)propertyElement.Attribute(CoreNames.DeprecatedVersion));
            bool hasEmptyTypeTag = false;
            TypeName? typeId = null;
            string cType = null;
            int? arrayLength = null;
            string doc = null;
            string docDeprecated = null;
            foreach (var element in propertyElement.Elements())
            {
                if (element.Name == CoreNames.Type
                 || element.Name == CoreNames.Array)
                {
                    if (typeId.HasValue)
                    {
                        throw NewInvalidDataException("Too many <type> elements", propertyElement);
                    }
                    // defend from <type/>
                    if (element.Name == CoreNames.Type && !element.HasAttributes)
                    {
                        hasEmptyTypeTag = true;
                        continue;
                    }
                    (typeId, cType, arrayLength) = ReadType(ns, element);
                    if (cType == null)
                    {
                        cType = EmptyCType;
                    }
                }
                else if (element.Name == CoreNames.DocDeprecated)
                {
                    docDeprecated = element.Value;
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
            }
            if (hasEmptyTypeTag)
            {
                return null;
            }
            if (!typeId.HasValue)
            {
                throw NewInvalidDataException("Missing <type> element", propertyElement);
            }
            return new Property
            {
                Name = propertyName,
                Readable = readable,
                Writable = writable,
                Construct = construct,
                ConstructOnly = constructOnly,
                Transfer = transfer,
                TypeName = typeId.Value,
                CType = cType,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc,
                DocDeprecated = docDeprecated
            };
        }

        private static void ReadSignalAndAddTo(Namespace ns, XElement element, List<Signal> signals)
        {
            Signal signal = ReadSignal(ns, element);
            if (signal != null)
            {
                signals.Add(signal);
            }
        }

        private static Signal ReadSignal(Namespace ns, XElement signalElement)
        {
            var signalName = (string)signalElement.Attribute("name");
            var isAction = (string)signalElement.Attribute("action") == "1";
            var version = ParseVersion(ns, (string)signalElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)signalElement.Attribute(CoreNames.DeprecatedVersion));
            var parameters = new List<Parameter>();
            Parameter ret = null;
            string doc = null;
            string docDeprecated = null;
            foreach (var element in signalElement.Elements())
            {
                if (element.Name == CoreNames.Parameters)
                {
                    ReadParametersAndAddTo(ns, element, parameters, allowEmptyCType: true, forMethod: false);
                }
                else if (element.Name == CoreNames.ReturnValue)
                {
                    if (ret != null)
                    {
                        throw NewInvalidDataException("Too many <return-value> elements", signalElement);
                    }
                    ret = ReadParameter(ns, element, allowEmptyCType: true, forMethod: false);
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.DocDeprecated)
                {
                    docDeprecated = element.Value;
                }
            }
            if (ret == null)
            {
                throw NewInvalidDataException("Missing <return-value> element", signalElement);
            }
            return new Signal
            {
                Name = signalName,
                Parameters = parameters,
                Return = ret,
                IsAction = isAction,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc,
                DocDeprecated = docDeprecated
            };
        }

        private static void ReadFunctionAndAddTo(Namespace ns, XElement element, List<Function> functions)
        {
            Function function = ReadFunctionIfNotMoved(ns, element.Name.LocalName, element);
            if (function != null)
            {
                functions.Add(function);
            }
        }

        private static Function ReadFunctionIfNotMoved(Namespace ns, string kind, XElement functionElement)
        {
            bool movedTo = functionElement.Attribute("moved-to") != null;
            if (movedTo)
            {
                return null;
            }
            Function function = ReadFunction(ns, kind, functionElement);
            if (function.CIdentifier == null)
            {
                throw NewInvalidDataException("Missing c:identifier attribute", functionElement);
            }
            return function;
        }

        private static Function ReadFunction(Namespace ns, string kind, XElement functionElement)
        {
            var functionName = (string)functionElement.Attribute("name");
            var cIdentifier = (string)functionElement.Attribute(CNames.Identifier) ?? (string)functionElement.Attribute(CNames.Type);
            var functionKind = ParseFunctionKind(functionElement.Name.LocalName);
            bool isMethod = functionKind == FunctionKind.Method;
            var version = ParseVersion(ns, (string)functionElement.Attribute(CoreNames.Version));
            var deprecatedVersion = ParseVersion(ns, (string)functionElement.Attribute(CoreNames.DeprecatedVersion));
            var parameters = new List<Parameter>();
            Parameter ret = null;
            string doc = null;
            string docDeprecated = null;
            foreach (var element in functionElement.Elements())
            {
                if (element.Name == CoreNames.Parameters)
                {
                    ReadParametersAndAddTo(ns, element, parameters, allowEmptyCType: false, forMethod: isMethod);
                }
                else if (element.Name == CoreNames.ReturnValue)
                {
                    if (ret != null)
                    {
                        throw NewInvalidDataException("Too many <return-value> elements", functionElement);
                    }
                    ret = ReadParameter(ns, element, allowEmptyCType: false, forMethod: isMethod);
                }
                else if (element.Name == CoreNames.Doc)
                {
                    doc = element.Value;
                }
                else if (element.Name == CoreNames.DocDeprecated)
                {
                    docDeprecated = element.Value;
                }
            }
            bool throws = (string)functionElement.Attribute("throws") == "1";
            if (throws)
            {
                parameters.Add(new Parameter
                {
                    Name = "error",
                    TypeName = ns.ResolveTypeName("GLib.Error"),
                    CType = "GError**",
                    InstanceParameter = false,
                    Direction = ParameterDirection.Out,
                    Transfer = Transfer.Full,
                    CallerAllocates = false,
                    Nullable = true,
                    ArrayLength = null,
                    AllowNone = true,
                    IsError = true,
                    Doc = null,
                    Async = false
                });
            }
            if (ret == null)
            {
                throw NewInvalidDataException("Missing <return-value> element", functionElement);
            }
            return new Function
            {
                Name = functionName,
                CIdentifier = cIdentifier,
                Kind = kind,
                Parameters = parameters,
                Return = ret,
                Throws = throws,
                Version = version,
                DeprecatedVersion = deprecatedVersion,
                Doc = doc,
                DocDeprecated = docDeprecated
            };
        }

        private static Parameter ReadParameter(Namespace ns, XElement parameterElement, bool allowEmptyCType, bool forMethod)
        {
            var parameterName = (string)parameterElement.Attribute("name") ?? string.Empty;
            bool instanceParameter = parameterElement.Name == CoreNames.InstanceParameter;
            Transfer transfer = ParseTransfer((string)parameterElement.Attribute("transfer-ownership"));
            bool nullable = (string)parameterElement.Attribute("nullable") == "1";
            bool allowNone = (string)parameterElement.Attribute("allow-none") == "1";
            bool async = (string)parameterElement.Attribute("scope") == "async";
            bool callerAllocates = (string)parameterElement.Attribute("caller-allocates") == "1";
            bool varargs = false;
            string doc = null;
            ParameterDirection direction;
            TypeName? typeId = null;
            string ctype = null;
            int? arrayLength = null;
            if (parameterElement.Name == CoreNames.ReturnValue)
            {
                direction = ParameterDirection.Return;
            }
            else
            {
                direction = ParseDirection((string)parameterElement.Attribute("direction"));
            }
            foreach (var element in parameterElement.Elements())
            {
                if (element.Name == CoreNames.Type
                 || element.Name == CoreNames.Array)
                {
                    if (typeId.HasValue)
                    {
                        throw NewInvalidDataException("Too many <type> elements", parameterElement);
                    }
                    (typeId, ctype, arrayLength) = ReadType(ns, element);
                    if (ctype == null && allowEmptyCType)
                    {
                        ctype = EmptyCType;
                    }
                    if (ctype == null)
                    {
                        throw NewInvalidDataException("Missing c:type attribute", parameterElement);
                    }
                }
                else if (element.Name == CoreNames.Varargs)
                {
                    varargs = true;
                }
            }
            if (typeId.HasValue)
            {
                if (forMethod && arrayLength.HasValue)
                {
                    arrayLength = arrayLength.Value + 1;
                }
                return new Parameter
                {
                    Name = parameterName,
                    TypeName = typeId.Value,
                    CType = ctype,
                    InstanceParameter = instanceParameter,
                    Direction = direction,
                    Transfer = transfer,
                    CallerAllocates = callerAllocates,
                    Nullable = nullable,
                    AllowNone = allowNone,
                    ArrayLength = arrayLength,
                    IsError = false,
                    Doc = doc,
                    Async = async
                };
            }
            else if (varargs)
            {
                return new Parameter
                {
                    Name = "",
                    TypeName = ns.NamespaceCollection.InternalNamespace.ResolveTypeName("varargs"),
                    CType = "",
                    InstanceParameter = instanceParameter,
                    Direction = ParameterDirection.In,
                    Transfer = Transfer.None,
                    CallerAllocates = false,
                    Nullable = false,
                    AllowNone = allowNone,
                    ArrayLength = null,
                    IsError = false,
                    Doc = doc,
                    Async = async
                };
            }
            else
            {
                throw NewInvalidDataException("Missing <type> element", parameterElement);
            }
        }

        private static (TypeName type, string cType, int? arrayLength) ReadType(Namespace ns, XElement typeElement)
        {
            var typeName = (string)typeElement.Attribute("name") ??
                           (typeElement.Name == CoreNames.Array ? "array" :
                           throw NewInvalidDataException("Missing type name", typeElement));
            var cType = (string)typeElement.Attribute(CNames.Type);
            int? arrayLength = (int?)typeElement.Attribute("length");
            List<TypeName> innerTypes = null;
            foreach (var element in typeElement.Elements())
            {
                if (element.Name == CoreNames.Type
                    || element.Name == CoreNames.Array)
                {
                    if (innerTypes == null)
                    {
                        innerTypes = new List<TypeName>();
                    }
                    innerTypes.Add(ReadType(ns, element).type);
                }
            }
            if (innerTypes == null || typeName == "GLib.ByteArray")
            {
                if (typeName == "array")
                {
                    throw NewInvalidDataException("Missing element type", typeElement);
                }
                else
                {
                    return (ns.ResolveTypeName(typeName), cType, arrayLength);
                }
            }
            else if (typeName == "GLib.HashTable")
            {
                GLibType type = new HashTableType { KeyTypeName = innerTypes[0], ValueTypeName = innerTypes[1]};
                TypeName tid = ns.AddType(null, type);
                return (tid, cType, arrayLength);
            }
            else
            {
                ListTypeKind kind ;
                switch (typeName)
                {
                    case "array":
                        if (arrayLength.HasValue)
                        {
                            kind = ListTypeKind.FixedArray;
                        }
                        else
                        {
                            kind = ListTypeKind.CArray;
                        }
                        break;
                    case "GLib.Array":
                        kind = ListTypeKind.Array;
                        break;
                    case "GLib.PtrArray":
                        kind = ListTypeKind.PtrArray;
                        break;
                    case "GLib.List":
                        kind = ListTypeKind.List;
                        break;
                    case "GLib.SList":
                        kind = ListTypeKind.SList;
                        break;
                    default:
                        throw NewInvalidDataException("Unknown container type", typeElement);
                }
                GLibType type = new ListType
                {
                    Kind = kind,
                    ArrayLength = arrayLength
                };
                TypeName tid = ns.AddType(null, type);
                return (tid, cType, arrayLength);
            }
        }

        private static ParameterDirection ParseDirection(string v)
        {
            if (v == null)
            {
                return ParameterDirection.In;
            }
            switch (v)
            {
                case "in": return ParameterDirection.In;
                case "out": return ParameterDirection.Out;
                case "inout": return ParameterDirection.InOut;
            }
            throw new ArgumentException($"Unknown direction: '{v}'");
        }

        private static Transfer ParseTransfer(string v)
        {
            if (v == null)
            {
                return Transfer.None;
            }
            switch (v)
            {
                case "none": return Transfer.None;
                case "container": return Transfer.Container;
                case "full": return Transfer.Full;
            }
            throw new ArgumentException($"Unknown transfer: '{v}'");
        }

        private static void ReadParametersAndAddTo(Namespace ns, XElement parametersElement, List<Parameter> parameters, bool allowEmptyCType, bool forMethod)
        {
            foreach (var element in parametersElement.Elements())
            {
                if (element.Name == CoreNames.Parameter
                 || element.Name == CoreNames.InstanceParameter)
                {
                    Parameter parameter = ReadParameter(ns, element, allowEmptyCType, forMethod);
                    parameters.Add(parameter);
                }
            }
        }

        private static FunctionKind ParseFunctionKind(string v)
        {
            switch (v)
            {
                case "constructor": return FunctionKind.Constructor;
                case "function": return FunctionKind.Function;
                case "method": return FunctionKind.Method;
                case "callback": return FunctionKind.Function;
                case "global": return FunctionKind.Global;
            }
            throw new ArgumentException($"Unknown function kind: '{v}'");
        }

        private static Version ParseVersion(Namespace ns, string v)
        {
            if (v == null)
            {
                return null;
            }
            Version version = null;
            int[] parts = v.Split('.').Select(int.Parse).ToArray();
            if (parts.Length >= 3)
            {
                version = new Version(parts[0], parts[1], parts[2]);
            }
            else if (parts.Length >= 2)
            {
                version = new Version(parts[0], parts[1]);
            }
            else if (parts.Length >= 1)
            {
                version = new Version(parts[0], 0);
            }
            if (version != null)
            {
                ns.Versions.Add(version);
            }
            return version;
        }
    }
}