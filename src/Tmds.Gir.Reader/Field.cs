namespace Tmds.Gir
{
    public class Field
    {
        public string Name { get; set; }
        public string Doc { get; set; }
        public string CType { get; set; }
        public int? ArrayLength { get; set; }
        public int? Bits { get; set; }
        public bool Private { get; set; }
        internal TypeName TypeName { get; set; }
        public GLibType Type => TypeName.Type;
    }
}