using System;
using System.Collections.Generic;

namespace Tmds.Gir
{
    public class RecordType : GLibType
    {
        public string CType { get; set; }
        public string GLibGetType { get; set; }
        public string GTypeStructFor { get; set; }
        public List<Field> Fields { get; set; }
        public List<Function> Functions { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        public string DocDeprecated { get; set; }
    }
}