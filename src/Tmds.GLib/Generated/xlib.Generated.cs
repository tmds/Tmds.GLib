using System;
using System.Runtime.InteropServices;
namespace xlib {
	public ref struct Display
	{
		private IntPtr _pointer;
		public static explicit operator Display(IntPtr pointer) => new Display { _pointer = pointer };
		public static explicit operator IntPtr(Display value) => value._pointer
;	}
	public ref struct Screen
	{
		private IntPtr _pointer;
		public static explicit operator Screen(IntPtr pointer) => new Screen { _pointer = pointer };
		public static explicit operator IntPtr(Screen value) => value._pointer
;	}
	public ref struct Visual
	{
		private IntPtr _pointer;
		public static explicit operator Visual(IntPtr pointer) => new Visual { _pointer = pointer };
		public static explicit operator IntPtr(Visual value) => value._pointer
;	}
	public ref struct XConfigureEvent
	{
		private IntPtr _pointer;
		public static explicit operator XConfigureEvent(IntPtr pointer) => new XConfigureEvent { _pointer = pointer };
		public static explicit operator IntPtr(XConfigureEvent value) => value._pointer
;	}
	public ref struct XImage
	{
		private IntPtr _pointer;
		public static explicit operator XImage(IntPtr pointer) => new XImage { _pointer = pointer };
		public static explicit operator IntPtr(XImage value) => value._pointer
;	}
	public ref struct XFontStruct
	{
		private IntPtr _pointer;
		public static explicit operator XFontStruct(IntPtr pointer) => new XFontStruct { _pointer = pointer };
		public static explicit operator IntPtr(XFontStruct value) => value._pointer
;	}
	public ref struct XTrapezoid
	{
		private IntPtr _pointer;
		public static explicit operator XTrapezoid(IntPtr pointer) => new XTrapezoid { _pointer = pointer };
		public static explicit operator IntPtr(XTrapezoid value) => value._pointer
;	}
	public ref struct XVisualInfo
	{
		private IntPtr _pointer;
		public static explicit operator XVisualInfo(IntPtr pointer) => new XVisualInfo { _pointer = pointer };
		public static explicit operator IntPtr(XVisualInfo value) => value._pointer
;	}
	public ref struct XWindowAttributes
	{
		private IntPtr _pointer;
		public static explicit operator XWindowAttributes(IntPtr pointer) => new XWindowAttributes { _pointer = pointer };
		public static explicit operator IntPtr(XWindowAttributes value) => value._pointer
;	}
	public static class xlibInterop {
	}
}
