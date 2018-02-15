using System;
using System.Collections.Generic;

namespace Tmds.Gir
{
    public class BitfieldType : GLibType
    {
        public string CType { get; set; }
        public List<Function> Functions { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        public string DocDeprecated { get; set; }
        public string GLibGetType { get; set; }
        public List<Member> Members { get; set; }
    }
}