namespace Tmds.Gir
{
    public class ListType : GLibType
    {
        public ListTypeKind Kind { get; set; }
        public TypeName TypeName { get; set; }
        public int? ArrayLength { get; set; }
    }
}