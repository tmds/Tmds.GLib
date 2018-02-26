
using System;
using System.Runtime.InteropServices;
using static Gtk.GtkInterop;
using static GObject.GObjectInterop;
using static Gio.GioInterop;

namespace GtkHelloWorld
{
    class Program
    {
        private delegate void ActivateDelegate(IntPtr app, IntPtr user_data);
        private static ActivateDelegate activateDelegate = new ActivateDelegate(activate);

        private static void activate(IntPtr app, IntPtr user_data)
        {
            IntPtr window = gtk_application_window_new (app);
            gtk_window_set_title (window, "Window");
            gtk_window_set_default_size (window, 200, 200);
            gtk_widget_show_all (window);
        }

        static void Main(string[] args)
        {
            IntPtr app = gtk_application_new ("org.gtk.example", Gio.ApplicationFlags.flags_none);
            g_signal_connect_data (app, "activate", Marshal.GetFunctionPointerForDelegate(activateDelegate), IntPtr.Zero, IntPtr.Zero, 0);
            int status = g_application_run (app, 0, IntPtr.Zero);
            g_object_unref (app);
        }
    }
}
