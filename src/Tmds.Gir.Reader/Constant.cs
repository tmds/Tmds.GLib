using System;

namespace Tmds.Gir
{
    public class Constant
    {
        public string Name { get; set; }
        public string CIdentifier { get; set; }
        internal TypeName TypeName { get; set; }
        public GLibType Type => TypeName.Type;
        public string CType { get; set; }
        public string Value { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        public string DocDeprecated { get; set; }
    }
}