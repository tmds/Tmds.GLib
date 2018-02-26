using System;
using System.Runtime.InteropServices;
namespace xlib {
	public ref struct Display
	{
		private IntPtr _pointer;
		public Display(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Display(IntPtr pointer) => new Display(pointer, checkType: true);
		public static explicit operator IntPtr(Display value) => value._pointer;
	}
	public ref struct Screen
	{
		private IntPtr _pointer;
		public Screen(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Screen(IntPtr pointer) => new Screen(pointer, checkType: true);
		public static explicit operator IntPtr(Screen value) => value._pointer;
	}
	public ref struct Visual
	{
		private IntPtr _pointer;
		public Visual(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Visual(IntPtr pointer) => new Visual(pointer, checkType: true);
		public static explicit operator IntPtr(Visual value) => value._pointer;
	}
	public ref struct XConfigureEvent
	{
		private IntPtr _pointer;
		public XConfigureEvent(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator XConfigureEvent(IntPtr pointer) => new XConfigureEvent(pointer, checkType: true);
		public static explicit operator IntPtr(XConfigureEvent value) => value._pointer;
	}
	public ref struct XImage
	{
		private IntPtr _pointer;
		public XImage(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator XImage(IntPtr pointer) => new XImage(pointer, checkType: true);
		public static explicit operator IntPtr(XImage value) => value._pointer;
	}
	public ref struct XFontStruct
	{
		private IntPtr _pointer;
		public XFontStruct(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator XFontStruct(IntPtr pointer) => new XFontStruct(pointer, checkType: true);
		public static explicit operator IntPtr(XFontStruct value) => value._pointer;
	}
	public ref struct XTrapezoid
	{
		private IntPtr _pointer;
		public XTrapezoid(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator XTrapezoid(IntPtr pointer) => new XTrapezoid(pointer, checkType: true);
		public static explicit operator IntPtr(XTrapezoid value) => value._pointer;
	}
	public ref struct XVisualInfo
	{
		private IntPtr _pointer;
		public XVisualInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator XVisualInfo(IntPtr pointer) => new XVisualInfo(pointer, checkType: true);
		public static explicit operator IntPtr(XVisualInfo value) => value._pointer;
	}
	public ref struct XWindowAttributes
	{
		private IntPtr _pointer;
		public XWindowAttributes(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator XWindowAttributes(IntPtr pointer) => new XWindowAttributes(pointer, checkType: true);
		public static explicit operator IntPtr(XWindowAttributes value) => value._pointer;
	}
	public static class xlibInterop {
	}
}
