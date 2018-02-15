namespace Tmds.Gir
{
    public class ListType : GLibType
    {
        public ListTypeKind Kind { get; set; }
        internal TypeName ItemTypeName { get; set; }
        public GLibType ItemType => ItemTypeName.Type;
        public int? ArrayLength { get; set; }
    }
}