using System;
using System.Collections.Generic;

namespace Tmds.Gir
{
    public class InterfaceType : GLibType
    {
        public string Name { get; set; }
        public string CType { get; set; }
        public string TypeStruct { get; set; }
        public string CClassType { get; set; }
        public string GLibGetType { get; set; }
        public List<Function> Functions { get; set; }
        public List<Signal> Signals { get; set; }
        public List<Property> Properties { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        public List<TypeName> Prerequisites { get; set; }
    }
}