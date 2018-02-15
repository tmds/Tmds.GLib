namespace Tmds.Gir
{
    public class Parameter
    {
        public string Name { get; set; }
        public TypeName TypeName { get; set; }
        public string CType { get; set; }
        public bool InstanceParameter { get; set; }
        public ParameterDirection Direction { get; set; }
        public Transfer Transfer { get; set; }
        public bool CallerAllocates { get; set; }
        public bool Nullable { get; set; }
        public int? ArrayLength { get; set; }
        public bool AllowNone { get; set; }
        public bool IsError { get; set; }
        public string Doc { get; set; }
        public bool Async { get; set; }
    }
}