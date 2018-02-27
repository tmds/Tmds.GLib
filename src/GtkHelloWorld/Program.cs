
using System;
using System.Runtime.InteropServices;
using Gtk;
using static GObject.GObjectInterop;

namespace GtkHelloWorld
{
    class Program
    {
        private delegate void ActivateDelegate(Application app, IntPtr user_data);
        private static ActivateDelegate activateDelegate = new ActivateDelegate(activate);

        private static void activate(Application app, IntPtr user_data)
        {
            var window = (Window)ApplicationWindow.@new(app);
            window.set_title("Window");
            window.set_default_size(200, 200);
            window.show_all();
        }

        static void Main(string[] args)
        {
            var app = Application.@new("org.gtk.example", Gio.ApplicationFlags.flags_none);
            g_signal_connect_data (app, "activate", Marshal.GetFunctionPointerForDelegate(activateDelegate), IntPtr.Zero, IntPtr.Zero, 0);
            app.run(0, IntPtr.Zero);
            app.unref();
        }
    }
}
