using System;
using System.Collections.Generic;
using System.Linq;

namespace Tmds.Gir
{
    public class Namespace
    {
        private static readonly char[] s_dot = new [] { '.' };
        private Dictionary<string, int> _typeIndex = new Dictionary<string, int>();
        private List<GLibType> _types = new List<GLibType>();
        private List<string> _names = new List<string>();

        public string Name { get; }
        public NamespaceCollection NamespaceCollection { get; }
        public string PackageName { get; set; }
        public List<string> SharedLibraries { get; } = new List<string>();
        public List<string> IdentifierPrefixes { get; } = new List<string>();
        public List<string> SymbolPrefixes { get; } = new List<string>();
        public HashSet<Version> Versions { get; } = new HashSet<Version>();
        public List<Function> Functions { get; } = new List<Function>();
        public List<Constant> Constants { get; } = new List<Constant>();

        public IEnumerable<KeyValuePair<string, GLibType>> Types
        {
            get
            {
                return _types.Select((type, idx) => new KeyValuePair<string, GLibType>(_names[idx], type)).Where(kv => kv.Key != null);
            }
        }

        public Namespace(NamespaceCollection nsc, string name)
        {
            NamespaceCollection = nsc;
            Name = name;
        }

        public TypeName ResolveTypeName(string typeName)
        {
            Namespace ns = this;
            var (typeNs, name) = SplitNamespaceName(typeName);

            // GLib.GType is a fundamental type
            if (name == "GType")
            {
                typeNs = null;
            }

            if (typeNs != null)
            {
                ns = ns.NamespaceCollection.GetNamespace(typeNs);
            }
            else
            {
                TypeName? type = ns.NamespaceCollection.InternalNamespace.FindTypeName(name);
                if (type.HasValue)
                {
                    return type.Value;
                }
            }
            TypeName? id = ns.FindTypeName(name);
            if (id.HasValue)
            {
                return id.Value;
            }
            return ns.CreateNewTypeName(name);
        }

        public TypeName AddType(string name, GLibType type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            TypeName? id = null;
            if (name != null)
            {
                id = FindTypeName(name);
            }
            if (!id.HasValue)
            {
                id = CreateNewTypeName(name);
            }
            TypeName typeName = id.Value;
            if (typeName.Type != null)
            {
                throw new InvalidOperationException($"Type '{name}' already defined in '{Name}'.");
            }
            if (_types[typeName.Index] == null)
            {
                _types[typeName.Index] = type;
            }
            return typeName;
        }

        private static (string ns, string name) SplitNamespaceName(string typeName)
        {
            if (!typeName.Contains('.'))
            {
                return (null, typeName);
            }
            string[] split = typeName.Split(s_dot, 2);
            return (split[0], split[1]);
        }

        private TypeName CreateNewTypeName(string name)
        {
            _types.Add(null);
            _names.Add(name);
            int index = _types.Count - 1;
            if (name != null)
            {
                _typeIndex[name] = index;
            }
            return new TypeName(this, index);
        }

        private TypeName? FindTypeName(string name)
        {
            if (_typeIndex.TryGetValue(name, out int index))
            {
                return new TypeName(this, index);
            }
            else
            {
                return null;
            }
        }

        internal GLibType GetType(int index) => _types[index];

        internal string GetTypeName(int index)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return $"{_names[index]}";
            }
            else
            {
                return $"{Name}.{_names[index]}";
            }
        }
    }
}