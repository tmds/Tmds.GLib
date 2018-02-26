using System;
using System.Runtime.InteropServices;
namespace GModule {
	[Flags]
	public enum ModuleFlags
	{
		lazy = 1,
		local = 2,
		mask = 3,
	}
	public static class GModuleInterop {
		[DllImport("libgmodule-2.0.so.0")]
		public static extern int g_module_close(System.IntPtr module);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern void g_module_make_resident(System.IntPtr module);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern string g_module_name(System.IntPtr module);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern int g_module_symbol(System.IntPtr module, string symbol_name, System.IntPtr symbol);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern string g_module_build_path(string directory, string module_name);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern string g_module_error();
		[DllImport("libgmodule-2.0.so.0")]
		public static extern System.IntPtr g_module_open(string file_name, GModule.ModuleFlags flags);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern int g_module_supported();
	}
}
