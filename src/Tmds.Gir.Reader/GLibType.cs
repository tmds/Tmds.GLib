namespace Tmds.Gir
{
    public class GLibType
    {
        internal TypeName TypeName { get; set; }
        public string FullName => TypeName.FullName;
        public string Name => TypeName.Name;
        public Namespace Namespace => TypeName.Namespace;
    }
}