using System;
using System.Collections.Generic;

namespace Tmds.Gir
{
    public class Function
    {
        public string Name { get; set; }
        public string CIdentifier { get; set; }
        public string Kind { get; set; }
        public List<Parameter> Parameters { get; set; }
        public Parameter Return { get; set; }
        public bool Throws { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        public string DocDeprecated { get; set; }
    }
}