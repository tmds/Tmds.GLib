using System;
using System.Collections.Generic;

namespace Tmds.Gir
{
    public class Signal
    {
        public string Name { get; set; }
        public List<Parameter> Parameters { get; set; }
        public Parameter Return { get; set; }
        public bool IsAction { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        public string DocDeprecated { get; set; }
    }
}