namespace Tmds.Gir
{
    public class AliasType : GLibType
    {
        public string CIdentifier { get; set; }
        public string TargetCType { get; set; }
        public string Doc { get; set; }
        internal TypeName AliasedTypeName { get; set; }
        public GLibType AliasedType => TypeName.Type;
    }
}