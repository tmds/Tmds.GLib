namespace Tmds.Gir
{
    public class AliasType : GLibType
    {
        public string Name { get; set; }
        public string CIdentifier { get; set; }
        public string TargetCType { get; set; }
        public string Doc { get; set; }
        public TypeName TypeName { get; set; }
    }
}