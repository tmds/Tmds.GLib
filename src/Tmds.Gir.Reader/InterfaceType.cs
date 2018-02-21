using System;
using System.Collections.Generic;
using System.Linq;

namespace Tmds.Gir
{
    public class InterfaceType : GLibType
    {
        public string CType { get; set; }
        public string TypeStruct { get; set; }
        public string GLibGetType { get; set; }
        public List<Function> Functions { get; set; }
        public List<Signal> Signals { get; set; }
        public List<Property> Properties { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        internal List<TypeName> PrerequisitesNames { get; set; }
        public IEnumerable<GLibType> Prerequisites => PrerequisitesNames.Select(name => name.Type);
    }
}