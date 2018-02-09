using System.Collections.Generic;

namespace Tmds.Gir
{
    public class UnionType : GLibType
    {
        public string Name { get; set; }
        public string CType { get; set; }
        public List<Field> Fields { get; set; }
        public string Doc { get; set; }
        public string GLibGetType { get; set; }
        public List<Function> Functions { get; set; }
    }
}