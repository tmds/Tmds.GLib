using System;
using GLib;

namespace GObject
{
    public static class ObjectType
    {
        public static void CheckInstanceIsA(IntPtr pointer, GLib.GType type)
        {
            if (!GObjectInterop.g_type_check_instance_is_a(new TypeInstance(pointer, checkType: false), type))
            {
                GType.ThrowInvalidCast(null, null);
            }
        }
    }
}