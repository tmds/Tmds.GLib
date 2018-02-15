using System;

namespace Tmds.Gir
{
    public class Property
    {
        public string Name { get; set; }
        public bool Readable { get; set; }
        public bool Writable { get; set; }
        public bool Construct { get; set; }
        public bool ConstructOnly { get; set; }
        public Transfer Transfer { get; set; }
        public TypeName TypeName { get; set; }
        public string CType { get; set; }
        public Version Version { get; set; }
        public Version DeprecatedVersion { get; set; }
        public string Doc { get; set; }
        public string DocDeprecated { get; set; }
    }
}