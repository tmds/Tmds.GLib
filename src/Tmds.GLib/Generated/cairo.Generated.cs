using System;
using System.Runtime.InteropServices;

namespace cairo
{
    public static class cairoInterop
    {
        [DllImport("libcairo-gobject.so.2")]
        public static extern void cairo_image_surface_create();
    }
}