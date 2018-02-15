using System;

namespace Tmds.Gir
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceCollection lib = GirParser.Parse("../../gir-files", "Gtk-3.0");
            foreach (var ns in lib.Namespaces)
            {
                System.Console.WriteLine($"Namespace: {ns.Name}");
                foreach (var typ in ns.Types)
                {
                    System.Console.WriteLine($" - name: {typ.FullName} type: {typ.ToString() ?? "<null>"}");
                }
            }
        }
    }
}
