namespace Tmds.Gir
{
    public struct TypeName
    {
        public Namespace Namespace { get; }
        internal int       Index { get; }

        public GLibType Type => Namespace?.GetType(Index);
        public string FullName => Namespace?.GetTypeName(Index);

        public TypeName(Namespace ns, int index) : this()
        {
            Namespace = ns;
            Index = index;
        }

        public override string ToString() => FullName;
    }
}