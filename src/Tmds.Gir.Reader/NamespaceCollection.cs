using System.Collections.Generic;

namespace Tmds.Gir
{
    public class NamespaceCollection
    {
        private Dictionary<string, Namespace> _namespaces { get; } = new Dictionary<string, Namespace>();
        internal Namespace InternalNamespace { get; }

        public IEnumerable<Namespace> Namespaces => _namespaces.Values;

        public NamespaceCollection()
        {
            InternalNamespace = new Namespace(this, string.Empty);
            var fundamentalTypes = new (string name, Fundamental fundamental)[]
            {
                ("none", Fundamental.None),
                ("gboolean", Fundamental.Boolean),
                ("gint8", Fundamental.Int8),
                ("guint8", Fundamental.UInt8),
                ("gint16", Fundamental.Int16),
                ("guint16", Fundamental.UInt16),
                ("gint32", Fundamental.Int32),
                ("guint32", Fundamental.UInt32),
                ("gint64", Fundamental.Int64),
                ("guint64", Fundamental.UInt64),
                ("gchar", Fundamental.Char),
                ("guchar", Fundamental.UChar),
                ("gshort", Fundamental.Short),
                ("gushort", Fundamental.UShort),
                ("gint", Fundamental.Int),
                ("guint", Fundamental.UInt),
                ("glong", Fundamental.Long),
                ("gulong", Fundamental.ULong),
                ("gsize", Fundamental.Size),
                ("gssize", Fundamental.SSize),
                ("gfloat", Fundamental.Float),
                ("gdouble", Fundamental.Double),
                ("long double", Fundamental.LongDouble),
                ("gunichar", Fundamental.UniChar),
                ("gconstpointer", Fundamental.Pointer),
                ("gpointer", Fundamental.Pointer),
                ("va_list", Fundamental.VaList),
                ("varargs", Fundamental.VarArgs),
                ("utf8", Fundamental.Utf8),
                ("filename", Fundamental.Filename),
                ("GType", Fundamental.Type),
                ("gintptr", Fundamental.IntPtr),
                ("guintptr", Fundamental.UIntPtr),
            };
            foreach (var type in fundamentalTypes)
            {
                InternalNamespace.AddType(type.name, new FundamentalType { Fundamental = type.fundamental });
            }
        }

        internal Namespace ResolveNamespace(string name)
        {
            Namespace ns;
            if (!_namespaces.TryGetValue(name, out ns))
            {
                ns = new Namespace(this, name);
                _namespaces.Add(name, ns);
            }
            return ns;
        }
    }
}