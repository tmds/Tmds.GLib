using System;

namespace GLib
{
    public struct GType
    {
        private IntPtr _value;

        public static void ThrowInvalidCast(string instanceTypeName, string typeName)
        {
            throw new InvalidCastException();
        }

        public override string ToString() => _value.ToString();
    }
}