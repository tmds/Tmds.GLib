namespace Tmds.Gir
{
    class TypeAnalysis
    {
        public int[] StarCount { get; } = new int[4];
        public TypeAnalysis(GLibType type)
        {
            Type = type;
        }

        private int MinStars
        {
            get
            {
                for (int i = 0; i < StarCount.Length; i++)
                {
                    if (StarCount[i] != 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        public bool IsRefType => !IsValueType;
        public bool IsValueType => MinStars == 0;

        public (string modifier, string typeName) DetermineInteropType(Parameter p)
        {
            GLibType type = p.Type;
            string cType = p.CType;

            (cType, type) = Generator.ResolveType(cType, type);

            int starCount = 0;
            while (cType.Length > 0 && cType[cType.Length - 1 - starCount] == '*') { starCount++; };
            if (p.Direction == ParameterDirection.Out || p.Direction == ParameterDirection.InOut)
            {
                starCount--;
            }
            starCount -= MinStars;

            bool unsupported = starCount > 1;
            if (unsupported)
            {
                return (null, null);
            }

            bool valueType = IsValueType;
            bool byRef = starCount == 1;
            string typeName = null;
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
                    case Fundamental.Utf8: typeName = "string"; break; // TODO ...
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
            else if (type is CallbackType)
            {
                typeName = "System.IntPtr";
            }
            else if (type is ListType || type is HashTableType)
            {
                typeName = "System.IntPtr"; // TODO
            }
            else if (type is UnionType)
            {
                typeName = null; // TODO
            }
            else
            {
                if (type is RecordType && valueType) // TODO
                {
                    return (null, null);
                }
                typeName = type.FullName;
            }
            string modifier = string.Empty;
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
            if (p.CallerAllocates && modifier == "out ")
            {
                modifier = "ref ";
            }
            return (modifier, typeName);
        }

        public GLibType Type { get; private set; }
    }
}