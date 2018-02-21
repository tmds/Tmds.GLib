using System;
using System.Collections.Generic;
using System.Linq;

namespace Tmds.Gir
{
    public class ClassType : GLibType
    {
        public string CType { get; set; }
        public string TypeStruct { get; set; }
        public string GLibGetType { get; set; }
        public List<Field> Fields { get; set; }
        public List<Function> Functions { get; set; }
        public List<Signal> Signals { get; set; }
        public List<Property> Properties { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        internal TypeName? ParentTypeName { get; set; }
        public GLibType Parent => ParentTypeName.HasValue ? ParentTypeName.Value.Type : null;
        internal List<TypeName> ImplementsNames { get; set; }
        public IEnumerable<GLibType> Implements => ImplementsNames.Select(name => name.Type);
    }
}