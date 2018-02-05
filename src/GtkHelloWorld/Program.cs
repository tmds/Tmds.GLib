using System;
using System.Runtime.InteropServices;
using static GtkHelloWorld.Interop;

// #include <gtk/gtk.h>

// static void
// activate (GtkApplication* app,
//           gpointer        user_data)
// {
//   GtkWidget *window;

//   window = gtk_application_window_new (app);
//   gtk_window_set_title (GTK_WINDOW (window), "Window");
//   gtk_window_set_default_size (GTK_WINDOW (window), 200, 200);
//   gtk_widget_show_all (window);
// }

// int
// main (int    argc,
//       char **argv)
// {
//   GtkApplication *app;
//   int status;

//   app = gtk_application_new ("org.gtk.example", G_APPLICATION_FLAGS_NONE);
//   g_signal_connect (app, "activate", G_CALLBACK (activate), NULL);
//   status = g_application_run (G_APPLICATION (app), argc, argv);
//   g_object_unref (app);

//   return status;
// }

using gulong = System.UIntPtr;
using gint = System.Int32;
namespace GtkHelloWorld
{
    unsafe delegate void ActivateDelegate(GtkApplication* app, IntPtr user_data);

    unsafe class Program
    {
        static ActivateDelegate activateDelegate = new ActivateDelegate(activate);

        private static void activate(GtkApplication* app, IntPtr user_data)
        {
            GtkWidget *window;

            window = gtk_application_window_new (app);
            gtk_window_set_title ((GtkWindow*)window, "Window");
            gtk_window_set_default_size ((GtkWindow*)window, 200, 200);
            gtk_widget_show_all (window);
        }

        static void Main(string[] args)
        {
            GtkApplication *app;
            int status;

            app = gtk_application_new ("org.gtk.example", GApplicationFlags.G_APPLICATION_FLAGS_NONE);
            g_signal_connect (app, "activate", Marshal.GetFunctionPointerForDelegate(activateDelegate).ToPointer(), IntPtr.Zero);
            status = g_application_run (app, 0, (char**)0);
            g_object_unref (app);
        }
    }

    struct GtkApplication {}
    struct GtkWidget {}
    struct GtkWindow {}

    enum GApplicationFlags {
        G_APPLICATION_FLAGS_NONE = 0
    }

    enum GConnectFlags { }

    static unsafe class Interop
    {

        [DllImport("libgtk-3.so.0")]
        public static extern GtkApplication* gtk_application_new(string application_id, GApplicationFlags flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_run(GtkApplication* application, int argc, char** argv);
        [DllImport("libgobject-2.0.so.0")]
        public static extern void g_object_unref (void* o);
        [DllImport("libgobject-2.0.so.0")]
        public static extern gulong g_signal_connect_data(void* instance, string detailed_signal, void* c_handler, IntPtr data, IntPtr destroy_data, GConnectFlags connect_flags);
        public static void g_signal_connect(void* instance, string signal, void* c_handler, IntPtr data)
            => g_signal_connect_data(instance, signal, c_handler, data, IntPtr.Zero, (GConnectFlags)0);
        [DllImport("libgtk-3.so.0")]
        public static extern GtkWidget * gtk_application_window_new (GtkApplication *application);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_title (GtkWindow *window, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_default_size (GtkWindow *window, gint width, gint height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_show_all (GtkWidget *widget);
    }
}
