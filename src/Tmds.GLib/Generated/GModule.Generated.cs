using System;
using System.Runtime.InteropServices;
namespace GModule {
	public ref struct Module
	{
		private IntPtr _pointer;
		public Module(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Module(IntPtr pointer) => new Module(pointer, checkType: true);
		public static explicit operator IntPtr(Module value) => value._pointer;
	}
	[Flags]
	public enum ModuleFlags
	{
		lazy = 1,
		local = 2,
		mask = 3,
	}
	public static class GModuleInterop {
		[DllImport("libgmodule-2.0.so.0")]
		public static extern bool g_module_close(GModule.Module module);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern void g_module_make_resident(GModule.Module module);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern string g_module_name(GModule.Module module);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern bool g_module_symbol(GModule.Module module, string symbol_name, System.IntPtr symbol);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern string g_module_build_path(string directory, string module_name);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern string g_module_error();
		[DllImport("libgmodule-2.0.so.0")]
		public static extern GModule.Module g_module_open(string file_name, GModule.ModuleFlags flags);
		[DllImport("libgmodule-2.0.so.0")]
		public static extern bool g_module_supported();
	}
}
