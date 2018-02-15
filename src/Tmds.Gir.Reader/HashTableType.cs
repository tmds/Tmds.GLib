namespace Tmds.Gir
{
    public class HashTableType : GLibType
    {
        internal TypeName KeyTypeName { get; set; }
        public GLibType KeyType => KeyTypeName.Type;
        internal TypeName ValueTypeName { get; set; }
        public GLibType ValueType => ValueTypeName.Type;
    }
}