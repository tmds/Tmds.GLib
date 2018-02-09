using System;

namespace Tmds.Gir
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceCollection lib = GirParser.Parse("../../gir-files", "Gtk-3.0");
            foreach (var ns in lib.Namespaces.Values)
            {
                System.Console.WriteLine($"Namespace: {ns.Name}");
                foreach (var typ in ns.Types)
                {
                    System.Console.WriteLine($" - name: {ns.Name}.{typ.Key} type: {typ.Value?.ToString() ?? "<null>"}");
                }
            }
        }
    }
}
