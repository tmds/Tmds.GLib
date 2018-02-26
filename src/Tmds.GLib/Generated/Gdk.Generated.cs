using System;
using System.Runtime.InteropServices;
namespace Gdk {
	[Flags]
	public enum AnchorHints
	{
		flip_x = 1,
		flip_y = 2,
		slide_x = 4,
		slide_y = 8,
		resize_x = 16,
		resize_y = 32,
		flip = 3,
		slide = 12,
		resize = 48,
	}
	public ref struct AppLaunchContext
	{
		private IntPtr _pointer;
		public AppLaunchContext(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator AppLaunchContext(IntPtr pointer) => new AppLaunchContext(pointer, checkType: true);
		public static explicit operator IntPtr(AppLaunchContext value) => value._pointer;
		public static implicit operator Gio.AppLaunchContext(AppLaunchContext value) => new Gio.AppLaunchContext((IntPtr)value, checkType: false);
		public static explicit operator AppLaunchContext(Gio.AppLaunchContext value) => new AppLaunchContext((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(AppLaunchContext value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator AppLaunchContext(GObject.Object value) => new AppLaunchContext((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_app_launch_context_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Display
	{
		private IntPtr _pointer;
		public Display(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Display(IntPtr pointer) => new Display(pointer, checkType: true);
		public static explicit operator IntPtr(Display value) => value._pointer;
		public static implicit operator GObject.Object(Display value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Display(GObject.Object value) => new Display((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_display_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Screen
	{
		private IntPtr _pointer;
		public Screen(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Screen(IntPtr pointer) => new Screen(pointer, checkType: true);
		public static explicit operator IntPtr(Screen value) => value._pointer;
		public static implicit operator GObject.Object(Screen value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Screen(GObject.Object value) => new Screen((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_screen_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Atom
	{
		private IntPtr _pointer;
		public Atom(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Atom(IntPtr pointer) => new Atom(pointer, checkType: true);
		public static explicit operator IntPtr(Atom value) => value._pointer;
	}
	[Flags]
	public enum AxisFlags
	{
		x = 2,
		y = 4,
		pressure = 8,
		xtilt = 16,
		ytilt = 32,
		wheel = 64,
		distance = 128,
		rotation = 256,
		slider = 512,
	}
	public enum AxisUse
	{
		ignore = 0,
		x = 1,
		y = 2,
		pressure = 3,
		xtilt = 4,
		ytilt = 5,
		wheel = 6,
		distance = 7,
		rotation = 8,
		slider = 9,
		last = 10,
	}
	public enum ByteOrder
	{
		lsb_first = 0,
		msb_first = 1,
	}
	public ref struct Color
	{
		private IntPtr _pointer;
		public Color(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Color(IntPtr pointer) => new Color(pointer, checkType: true);
		public static explicit operator IntPtr(Color value) => value._pointer;
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_color_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum CrossingMode
	{
		normal = 0,
		grab = 1,
		ungrab = 2,
		gtk_grab = 3,
		gtk_ungrab = 4,
		state_changed = 5,
		touch_begin = 6,
		touch_end = 7,
		device_switch = 8,
	}
	public ref struct Cursor
	{
		private IntPtr _pointer;
		public Cursor(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Cursor(IntPtr pointer) => new Cursor(pointer, checkType: true);
		public static explicit operator IntPtr(Cursor value) => value._pointer;
		public static implicit operator GObject.Object(Cursor value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Cursor(GObject.Object value) => new Cursor((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_cursor_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum CursorType
	{
		x_cursor = 0,
		arrow = 2,
		based_arrow_down = 4,
		based_arrow_up = 6,
		boat = 8,
		bogosity = 10,
		bottom_left_corner = 12,
		bottom_right_corner = 14,
		bottom_side = 16,
		bottom_tee = 18,
		box_spiral = 20,
		center_ptr = 22,
		circle = 24,
		clock = 26,
		coffee_mug = 28,
		cross = 30,
		cross_reverse = 32,
		crosshair = 34,
		diamond_cross = 36,
		dot = 38,
		dotbox = 40,
		double_arrow = 42,
		draft_large = 44,
		draft_small = 46,
		draped_box = 48,
		exchange = 50,
		fleur = 52,
		gobbler = 54,
		gumby = 56,
		hand1 = 58,
		hand2 = 60,
		heart = 62,
		icon = 64,
		iron_cross = 66,
		left_ptr = 68,
		left_side = 70,
		left_tee = 72,
		leftbutton = 74,
		ll_angle = 76,
		lr_angle = 78,
		man = 80,
		middlebutton = 82,
		mouse = 84,
		pencil = 86,
		pirate = 88,
		plus = 90,
		question_arrow = 92,
		right_ptr = 94,
		right_side = 96,
		right_tee = 98,
		rightbutton = 100,
		rtl_logo = 102,
		sailboat = 104,
		sb_down_arrow = 106,
		sb_h_double_arrow = 108,
		sb_left_arrow = 110,
		sb_right_arrow = 112,
		sb_up_arrow = 114,
		sb_v_double_arrow = 116,
		shuttle = 118,
		sizing = 120,
		spider = 122,
		spraycan = 124,
		star = 126,
		target = 128,
		tcross = 130,
		top_left_arrow = 132,
		top_left_corner = 134,
		top_right_corner = 136,
		top_side = 138,
		top_tee = 140,
		trek = 142,
		ul_angle = 144,
		umbrella = 146,
		ur_angle = 148,
		watch = 150,
		xterm = 152,
		last_cursor = 153,
		blank_cursor = -2,
		cursor_is_pixmap = -1,
	}
	public ref struct TimeCoord
	{
		private IntPtr _pointer;
		public TimeCoord(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TimeCoord(IntPtr pointer) => new TimeCoord(pointer, checkType: true);
		public static explicit operator IntPtr(TimeCoord value) => value._pointer;
	}
	public ref struct Device
	{
		private IntPtr _pointer;
		public Device(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Device(IntPtr pointer) => new Device(pointer, checkType: true);
		public static explicit operator IntPtr(Device value) => value._pointer;
		public static implicit operator GObject.Object(Device value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Device(GObject.Object value) => new Device((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_device_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Window
	{
		private IntPtr _pointer;
		public Window(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Window(IntPtr pointer) => new Window(pointer, checkType: true);
		public static explicit operator IntPtr(Window value) => value._pointer;
		public static implicit operator GObject.Object(Window value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Window(GObject.Object value) => new Window((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_window_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum DeviceType
	{
		master = 0,
		slave = 1,
		floating = 2,
	}
	[Flags]
	public enum ModifierType
	{
		shift_mask = 1,
		lock_mask = 2,
		control_mask = 4,
		mod1_mask = 8,
		mod2_mask = 16,
		mod3_mask = 32,
		mod4_mask = 64,
		mod5_mask = 128,
		button1_mask = 256,
		button2_mask = 512,
		button3_mask = 1024,
		button4_mask = 2048,
		button5_mask = 4096,
		modifier_reserved_13_mask = 8192,
		modifier_reserved_14_mask = 16384,
		modifier_reserved_15_mask = 32768,
		modifier_reserved_16_mask = 65536,
		modifier_reserved_17_mask = 131072,
		modifier_reserved_18_mask = 262144,
		modifier_reserved_19_mask = 524288,
		modifier_reserved_20_mask = 1048576,
		modifier_reserved_21_mask = 2097152,
		modifier_reserved_22_mask = 4194304,
		modifier_reserved_23_mask = 8388608,
		modifier_reserved_24_mask = 16777216,
		modifier_reserved_25_mask = 33554432,
		super_mask = 67108864,
		hyper_mask = 134217728,
		meta_mask = 268435456,
		modifier_reserved_29_mask = 536870912,
		release_mask = 1073741824,
		modifier_mask = 1543512063,
	}
	public enum InputMode
	{
		disabled = 0,
		screen = 1,
		window = 2,
	}
	public ref struct Seat
	{
		private IntPtr _pointer;
		public Seat(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Seat(IntPtr pointer) => new Seat(pointer, checkType: true);
		public static explicit operator IntPtr(Seat value) => value._pointer;
		public static implicit operator GObject.Object(Seat value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Seat(GObject.Object value) => new Seat((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_seat_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum InputSource
	{
		mouse = 0,
		pen = 1,
		eraser = 2,
		cursor = 3,
		keyboard = 4,
		touchscreen = 5,
		touchpad = 6,
		trackpoint = 7,
		tablet_pad = 8,
	}
	public enum GrabStatus
	{
		success = 0,
		already_grabbed = 1,
		invalid_time = 2,
		not_viewable = 3,
		frozen = 4,
		failed = 5,
	}
	public enum GrabOwnership
	{
		none = 0,
		window = 1,
		application = 2,
	}
	[Flags]
	public enum EventMask
	{
		exposure_mask = 2,
		pointer_motion_mask = 4,
		pointer_motion_hint_mask = 8,
		button_motion_mask = 16,
		button1_motion_mask = 32,
		button2_motion_mask = 64,
		button3_motion_mask = 128,
		button_press_mask = 256,
		button_release_mask = 512,
		key_press_mask = 1024,
		key_release_mask = 2048,
		enter_notify_mask = 4096,
		leave_notify_mask = 8192,
		focus_change_mask = 16384,
		structure_mask = 32768,
		property_change_mask = 65536,
		visibility_notify_mask = 131072,
		proximity_in_mask = 262144,
		proximity_out_mask = 524288,
		substructure_mask = 1048576,
		scroll_mask = 2097152,
		touch_mask = 4194304,
		smooth_scroll_mask = 8388608,
		touchpad_gesture_mask = 16777216,
		tablet_pad_mask = 33554432,
		all_events_mask = 16777214,
	}
	public ref struct DeviceManager
	{
		private IntPtr _pointer;
		public DeviceManager(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator DeviceManager(IntPtr pointer) => new DeviceManager(pointer, checkType: true);
		public static explicit operator IntPtr(DeviceManager value) => value._pointer;
		public static implicit operator GObject.Object(DeviceManager value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator DeviceManager(GObject.Object value) => new DeviceManager((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_device_manager_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct DeviceTool
	{
		private IntPtr _pointer;
		public DeviceTool(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator DeviceTool(IntPtr pointer) => new DeviceTool(pointer, checkType: true);
		public static explicit operator IntPtr(DeviceTool value) => value._pointer;
		public static implicit operator GObject.Object(DeviceTool value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator DeviceTool(GObject.Object value) => new DeviceTool((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_device_tool_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct DevicePad
	{
		private IntPtr _pointer;
		public DevicePad(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator DevicePad(IntPtr pointer) => new DevicePad(pointer, checkType: true);
		public static explicit operator IntPtr(DevicePad value) => value._pointer;
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_device_pad_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum DevicePadFeature
	{
		button = 0,
		ring = 1,
		strip = 2,
	}
	public ref struct DevicePadInterface
	{
		private IntPtr _pointer;
		public DevicePadInterface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator DevicePadInterface(IntPtr pointer) => new DevicePadInterface(pointer, checkType: true);
		public static explicit operator IntPtr(DevicePadInterface value) => value._pointer;
	}
	public enum DeviceToolType
	{
		unknown = 0,
		pen = 1,
		eraser = 2,
		brush = 3,
		pencil = 4,
		airbrush = 5,
		mouse = 6,
		lens = 7,
	}
	public ref struct Monitor
	{
		private IntPtr _pointer;
		public Monitor(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Monitor(IntPtr pointer) => new Monitor(pointer, checkType: true);
		public static explicit operator IntPtr(Monitor value) => value._pointer;
		public static implicit operator GObject.Object(Monitor value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Monitor(GObject.Object value) => new Monitor((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_monitor_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct DisplayManager
	{
		private IntPtr _pointer;
		public DisplayManager(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator DisplayManager(IntPtr pointer) => new DisplayManager(pointer, checkType: true);
		public static explicit operator IntPtr(DisplayManager value) => value._pointer;
		public static implicit operator GObject.Object(DisplayManager value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator DisplayManager(GObject.Object value) => new DisplayManager((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_display_manager_get_type")]
		public static extern GLib.GType TypeOf();
	}
	[Flags]
	public enum DragAction
	{
		@default = 1,
		copy = 2,
		move = 4,
		link = 8,
		@private = 16,
		ask = 32,
	}
	public enum DragCancelReason
	{
		no_target = 0,
		user_cancelled = 1,
		error = 2,
	}
	public ref struct DragContext
	{
		private IntPtr _pointer;
		public DragContext(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator DragContext(IntPtr pointer) => new DragContext(pointer, checkType: true);
		public static explicit operator IntPtr(DragContext value) => value._pointer;
		public static implicit operator GObject.Object(DragContext value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator DragContext(GObject.Object value) => new DragContext((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_drag_context_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum DragProtocol
	{
		none = 0,
		motif = 1,
		xdnd = 2,
		rootwin = 3,
		win32_dropfiles = 4,
		ole2 = 5,
		local = 6,
		wayland = 7,
	}
	public ref struct DrawingContext
	{
		private IntPtr _pointer;
		public DrawingContext(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator DrawingContext(IntPtr pointer) => new DrawingContext(pointer, checkType: true);
		public static explicit operator IntPtr(DrawingContext value) => value._pointer;
		public static implicit operator GObject.Object(DrawingContext value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator DrawingContext(GObject.Object value) => new DrawingContext((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_drawing_context_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct DrawingContextClass
	{
		private IntPtr _pointer;
		public DrawingContextClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator DrawingContextClass(IntPtr pointer) => new DrawingContextClass(pointer, checkType: true);
		public static explicit operator IntPtr(DrawingContextClass value) => value._pointer;
	}
	public enum EventType
	{
		nothing = -1,
		delete = 0,
		destroy = 1,
		expose = 2,
		motion_notify = 3,
		button_press = 4,
		_2button_press = 5,
		double_button_press = 5,
		_3button_press = 6,
		triple_button_press = 6,
		button_release = 7,
		key_press = 8,
		key_release = 9,
		enter_notify = 10,
		leave_notify = 11,
		focus_change = 12,
		configure = 13,
		map = 14,
		unmap = 15,
		property_notify = 16,
		selection_clear = 17,
		selection_request = 18,
		selection_notify = 19,
		proximity_in = 20,
		proximity_out = 21,
		drag_enter = 22,
		drag_leave = 23,
		drag_motion = 24,
		drag_status = 25,
		drop_start = 26,
		drop_finished = 27,
		client_event = 28,
		visibility_notify = 29,
		scroll = 31,
		window_state = 32,
		setting = 33,
		owner_change = 34,
		grab_broken = 35,
		damage = 36,
		touch_begin = 37,
		touch_update = 38,
		touch_end = 39,
		touch_cancel = 40,
		touchpad_swipe = 41,
		touchpad_pinch = 42,
		pad_button_press = 43,
		pad_button_release = 44,
		pad_ring = 45,
		pad_strip = 46,
		pad_group_mode = 47,
		event_last = 48,
	}
	public ref struct EventAny
	{
		private IntPtr _pointer;
		public EventAny(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventAny(IntPtr pointer) => new EventAny(pointer, checkType: true);
		public static explicit operator IntPtr(EventAny value) => value._pointer;
	}
	public ref struct EventExpose
	{
		private IntPtr _pointer;
		public EventExpose(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventExpose(IntPtr pointer) => new EventExpose(pointer, checkType: true);
		public static explicit operator IntPtr(EventExpose value) => value._pointer;
	}
	public ref struct EventVisibility
	{
		private IntPtr _pointer;
		public EventVisibility(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventVisibility(IntPtr pointer) => new EventVisibility(pointer, checkType: true);
		public static explicit operator IntPtr(EventVisibility value) => value._pointer;
	}
	public ref struct EventMotion
	{
		private IntPtr _pointer;
		public EventMotion(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventMotion(IntPtr pointer) => new EventMotion(pointer, checkType: true);
		public static explicit operator IntPtr(EventMotion value) => value._pointer;
	}
	public ref struct EventButton
	{
		private IntPtr _pointer;
		public EventButton(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventButton(IntPtr pointer) => new EventButton(pointer, checkType: true);
		public static explicit operator IntPtr(EventButton value) => value._pointer;
	}
	public ref struct EventTouch
	{
		private IntPtr _pointer;
		public EventTouch(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventTouch(IntPtr pointer) => new EventTouch(pointer, checkType: true);
		public static explicit operator IntPtr(EventTouch value) => value._pointer;
	}
	public ref struct EventScroll
	{
		private IntPtr _pointer;
		public EventScroll(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventScroll(IntPtr pointer) => new EventScroll(pointer, checkType: true);
		public static explicit operator IntPtr(EventScroll value) => value._pointer;
	}
	public ref struct EventKey
	{
		private IntPtr _pointer;
		public EventKey(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventKey(IntPtr pointer) => new EventKey(pointer, checkType: true);
		public static explicit operator IntPtr(EventKey value) => value._pointer;
	}
	public ref struct EventCrossing
	{
		private IntPtr _pointer;
		public EventCrossing(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventCrossing(IntPtr pointer) => new EventCrossing(pointer, checkType: true);
		public static explicit operator IntPtr(EventCrossing value) => value._pointer;
	}
	public ref struct EventFocus
	{
		private IntPtr _pointer;
		public EventFocus(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventFocus(IntPtr pointer) => new EventFocus(pointer, checkType: true);
		public static explicit operator IntPtr(EventFocus value) => value._pointer;
	}
	public ref struct EventConfigure
	{
		private IntPtr _pointer;
		public EventConfigure(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventConfigure(IntPtr pointer) => new EventConfigure(pointer, checkType: true);
		public static explicit operator IntPtr(EventConfigure value) => value._pointer;
	}
	public ref struct EventProperty
	{
		private IntPtr _pointer;
		public EventProperty(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventProperty(IntPtr pointer) => new EventProperty(pointer, checkType: true);
		public static explicit operator IntPtr(EventProperty value) => value._pointer;
	}
	public ref struct EventSelection
	{
		private IntPtr _pointer;
		public EventSelection(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventSelection(IntPtr pointer) => new EventSelection(pointer, checkType: true);
		public static explicit operator IntPtr(EventSelection value) => value._pointer;
	}
	public ref struct EventOwnerChange
	{
		private IntPtr _pointer;
		public EventOwnerChange(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventOwnerChange(IntPtr pointer) => new EventOwnerChange(pointer, checkType: true);
		public static explicit operator IntPtr(EventOwnerChange value) => value._pointer;
	}
	public ref struct EventProximity
	{
		private IntPtr _pointer;
		public EventProximity(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventProximity(IntPtr pointer) => new EventProximity(pointer, checkType: true);
		public static explicit operator IntPtr(EventProximity value) => value._pointer;
	}
	public ref struct EventDND
	{
		private IntPtr _pointer;
		public EventDND(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventDND(IntPtr pointer) => new EventDND(pointer, checkType: true);
		public static explicit operator IntPtr(EventDND value) => value._pointer;
	}
	public ref struct EventWindowState
	{
		private IntPtr _pointer;
		public EventWindowState(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventWindowState(IntPtr pointer) => new EventWindowState(pointer, checkType: true);
		public static explicit operator IntPtr(EventWindowState value) => value._pointer;
	}
	public ref struct EventSetting
	{
		private IntPtr _pointer;
		public EventSetting(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventSetting(IntPtr pointer) => new EventSetting(pointer, checkType: true);
		public static explicit operator IntPtr(EventSetting value) => value._pointer;
	}
	public ref struct EventGrabBroken
	{
		private IntPtr _pointer;
		public EventGrabBroken(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventGrabBroken(IntPtr pointer) => new EventGrabBroken(pointer, checkType: true);
		public static explicit operator IntPtr(EventGrabBroken value) => value._pointer;
	}
	public ref struct EventTouchpadSwipe
	{
		private IntPtr _pointer;
		public EventTouchpadSwipe(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventTouchpadSwipe(IntPtr pointer) => new EventTouchpadSwipe(pointer, checkType: true);
		public static explicit operator IntPtr(EventTouchpadSwipe value) => value._pointer;
	}
	public ref struct EventTouchpadPinch
	{
		private IntPtr _pointer;
		public EventTouchpadPinch(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventTouchpadPinch(IntPtr pointer) => new EventTouchpadPinch(pointer, checkType: true);
		public static explicit operator IntPtr(EventTouchpadPinch value) => value._pointer;
	}
	public ref struct EventPadButton
	{
		private IntPtr _pointer;
		public EventPadButton(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventPadButton(IntPtr pointer) => new EventPadButton(pointer, checkType: true);
		public static explicit operator IntPtr(EventPadButton value) => value._pointer;
	}
	public ref struct EventPadAxis
	{
		private IntPtr _pointer;
		public EventPadAxis(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventPadAxis(IntPtr pointer) => new EventPadAxis(pointer, checkType: true);
		public static explicit operator IntPtr(EventPadAxis value) => value._pointer;
	}
	public ref struct EventPadGroupMode
	{
		private IntPtr _pointer;
		public EventPadGroupMode(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventPadGroupMode(IntPtr pointer) => new EventPadGroupMode(pointer, checkType: true);
		public static explicit operator IntPtr(EventPadGroupMode value) => value._pointer;
	}
	public ref struct EventSequence
	{
		private IntPtr _pointer;
		public EventSequence(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EventSequence(IntPtr pointer) => new EventSequence(pointer, checkType: true);
		public static explicit operator IntPtr(EventSequence value) => value._pointer;
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_event_sequence_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum ScrollDirection
	{
		up = 0,
		down = 1,
		left = 2,
		right = 3,
		smooth = 4,
	}
	public enum NotifyType
	{
		ancestor = 0,
		@virtual = 1,
		inferior = 2,
		nonlinear = 3,
		nonlinear_virtual = 4,
		unknown = 5,
	}
	public ref struct Rectangle
	{
		private IntPtr _pointer;
		public Rectangle(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Rectangle(IntPtr pointer) => new Rectangle(pointer, checkType: true);
		public static explicit operator IntPtr(Rectangle value) => value._pointer;
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_rectangle_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum OwnerChange
	{
		new_owner = 0,
		destroy = 1,
		close = 2,
	}
	public enum PropertyState
	{
		new_value = 0,
		delete = 1,
	}
	public enum SettingAction
	{
		@new = 0,
		changed = 1,
		deleted = 2,
	}
	public enum TouchpadGesturePhase
	{
		begin = 0,
		update = 1,
		end = 2,
		cancel = 3,
	}
	public enum VisibilityState
	{
		unobscured = 0,
		partial = 1,
		fully_obscured = 2,
	}
	[Flags]
	public enum WindowState
	{
		withdrawn = 1,
		iconified = 2,
		maximized = 4,
		sticky = 8,
		fullscreen = 16,
		above = 32,
		below = 64,
		focused = 128,
		tiled = 256,
		top_tiled = 512,
		top_resizable = 1024,
		right_tiled = 2048,
		right_resizable = 4096,
		bottom_tiled = 8192,
		bottom_resizable = 16384,
		left_tiled = 32768,
		left_resizable = 65536,
	}
	public enum FilterReturn
	{
		@continue = 0,
		translate = 1,
		remove = 2,
	}
	public ref struct FrameClock
	{
		private IntPtr _pointer;
		public FrameClock(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator FrameClock(IntPtr pointer) => new FrameClock(pointer, checkType: true);
		public static explicit operator IntPtr(FrameClock value) => value._pointer;
		public static implicit operator GObject.Object(FrameClock value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator FrameClock(GObject.Object value) => new FrameClock((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_frame_clock_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct FrameTimings
	{
		private IntPtr _pointer;
		public FrameTimings(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FrameTimings(IntPtr pointer) => new FrameTimings(pointer, checkType: true);
		public static explicit operator IntPtr(FrameTimings value) => value._pointer;
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_frame_timings_get_type")]
		public static extern GLib.GType TypeOf();
	}
	[Flags]
	public enum FrameClockPhase
	{
		none = 0,
		flush_events = 1,
		before_paint = 2,
		update = 4,
		layout = 8,
		paint = 16,
		resume_events = 32,
		after_paint = 64,
	}
	public ref struct FrameClockClass
	{
		private IntPtr _pointer;
		public FrameClockClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FrameClockClass(IntPtr pointer) => new FrameClockClass(pointer, checkType: true);
		public static explicit operator IntPtr(FrameClockClass value) => value._pointer;
	}
	public ref struct FrameClockPrivate
	{
		private IntPtr _pointer;
		public FrameClockPrivate(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FrameClockPrivate(IntPtr pointer) => new FrameClockPrivate(pointer, checkType: true);
		public static explicit operator IntPtr(FrameClockPrivate value) => value._pointer;
	}
	public enum FullscreenMode
	{
		current_monitor = 0,
		all_monitors = 1,
	}
	public ref struct GLContext
	{
		private IntPtr _pointer;
		public GLContext(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator GLContext(IntPtr pointer) => new GLContext(pointer, checkType: true);
		public static explicit operator IntPtr(GLContext value) => value._pointer;
		public static implicit operator GObject.Object(GLContext value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator GLContext(GObject.Object value) => new GLContext((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_gl_context_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum GLError
	{
		not_available = 0,
		unsupported_format = 1,
		unsupported_profile = 2,
	}
	public enum Gravity
	{
		north_west = 1,
		north = 2,
		north_east = 3,
		west = 4,
		center = 5,
		east = 6,
		south_west = 7,
		south = 8,
		south_east = 9,
		@static = 10,
	}
	public ref struct Geometry
	{
		private IntPtr _pointer;
		public Geometry(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Geometry(IntPtr pointer) => new Geometry(pointer, checkType: true);
		public static explicit operator IntPtr(Geometry value) => value._pointer;
	}
	public ref struct Keymap
	{
		private IntPtr _pointer;
		public Keymap(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Keymap(IntPtr pointer) => new Keymap(pointer, checkType: true);
		public static explicit operator IntPtr(Keymap value) => value._pointer;
		public static implicit operator GObject.Object(Keymap value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Keymap(GObject.Object value) => new Keymap((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_keymap_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct KeymapKey
	{
		private IntPtr _pointer;
		public KeymapKey(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator KeymapKey(IntPtr pointer) => new KeymapKey(pointer, checkType: true);
		public static explicit operator IntPtr(KeymapKey value) => value._pointer;
	}
	public enum ModifierIntent
	{
		primary_accelerator = 0,
		context_menu = 1,
		extend_selection = 2,
		modify_selection = 3,
		no_text_input = 4,
		shift_group = 5,
		default_mod_mask = 6,
	}
	public enum SubpixelLayout
	{
		unknown = 0,
		none = 1,
		horizontal_rgb = 2,
		horizontal_bgr = 3,
		vertical_rgb = 4,
		vertical_bgr = 5,
	}
	public ref struct MonitorClass
	{
		private IntPtr _pointer;
		public MonitorClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MonitorClass(IntPtr pointer) => new MonitorClass(pointer, checkType: true);
		public static explicit operator IntPtr(MonitorClass value) => value._pointer;
	}
	public ref struct Point
	{
		private IntPtr _pointer;
		public Point(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Point(IntPtr pointer) => new Point(pointer, checkType: true);
		public static explicit operator IntPtr(Point value) => value._pointer;
	}
	public enum PropMode
	{
		replace = 0,
		prepend = 1,
		append = 2,
	}
	public ref struct RGBA
	{
		private IntPtr _pointer;
		public RGBA(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RGBA(IntPtr pointer) => new RGBA(pointer, checkType: true);
		public static explicit operator IntPtr(RGBA value) => value._pointer;
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_rgba_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Visual
	{
		private IntPtr _pointer;
		public Visual(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Visual(IntPtr pointer) => new Visual(pointer, checkType: true);
		public static explicit operator IntPtr(Visual value) => value._pointer;
		public static implicit operator GObject.Object(Visual value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Visual(GObject.Object value) => new Visual((IntPtr)value, checkType: true);
		[DllImport("libgdk-3.so.0", EntryPoint = "gdk_visual_get_type")]
		public static extern GLib.GType TypeOf();
	}
	[Flags]
	public enum SeatCapabilities
	{
		none = 0,
		pointer = 1,
		touch = 2,
		tablet_stylus = 4,
		keyboard = 8,
		all_pointing = 7,
		all = 15,
	}
	public enum Status
	{
		ok = 0,
		error = -1,
		error_param = -2,
		error_file = -3,
		error_mem = -4,
	}
	public enum VisualType
	{
		static_gray = 0,
		grayscale = 1,
		static_color = 2,
		pseudo_color = 3,
		true_color = 4,
		direct_color = 5,
	}
	[Flags]
	public enum WMDecoration
	{
		all = 1,
		border = 2,
		resizeh = 4,
		title = 8,
		menu = 16,
		minimize = 32,
		maximize = 64,
	}
	[Flags]
	public enum WMFunction
	{
		all = 1,
		resize = 2,
		move = 4,
		minimize = 8,
		maximize = 16,
		close = 32,
	}
	public ref struct WindowAttr
	{
		private IntPtr _pointer;
		public WindowAttr(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator WindowAttr(IntPtr pointer) => new WindowAttr(pointer, checkType: true);
		public static explicit operator IntPtr(WindowAttr value) => value._pointer;
	}
	[Flags]
	public enum WindowAttributesType
	{
		title = 2,
		x = 4,
		y = 8,
		cursor = 16,
		visual = 32,
		wmclass = 64,
		noredir = 128,
		type_hint = 256,
	}
	[Flags]
	public enum WindowHints
	{
		pos = 1,
		min_size = 2,
		max_size = 4,
		base_size = 8,
		aspect = 16,
		resize_inc = 32,
		win_gravity = 64,
		user_pos = 128,
		user_size = 256,
	}
	public enum WindowEdge
	{
		north_west = 0,
		north = 1,
		north_east = 2,
		west = 3,
		east = 4,
		south_west = 5,
		south = 6,
		south_east = 7,
	}
	public enum WindowTypeHint
	{
		normal = 0,
		dialog = 1,
		menu = 2,
		toolbar = 3,
		splashscreen = 4,
		utility = 5,
		dock = 6,
		desktop = 7,
		dropdown_menu = 8,
		popup_menu = 9,
		tooltip = 10,
		notification = 11,
		combo = 12,
		dnd = 13,
	}
	public enum WindowType
	{
		root = 0,
		toplevel = 1,
		child = 2,
		temp = 3,
		foreign = 4,
		offscreen = 5,
		subsurface = 6,
	}
	public enum WindowWindowClass
	{
		input_output = 0,
		input_only = 1,
	}
	public ref struct WindowClass
	{
		private IntPtr _pointer;
		public WindowClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator WindowClass(IntPtr pointer) => new WindowClass(pointer, checkType: true);
		public static explicit operator IntPtr(WindowClass value) => value._pointer;
	}
	public ref struct WindowRedirect
	{
		private IntPtr _pointer;
		public WindowRedirect(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator WindowRedirect(IntPtr pointer) => new WindowRedirect(pointer, checkType: true);
		public static explicit operator IntPtr(WindowRedirect value) => value._pointer;
	}
	public static class GdkInterop {
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_add_option_entries_libgtk_only(GLib.OptionGroup group);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_beep();
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Context gdk_cairo_create(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_draw_from_gl(cairo.Context cr, Gdk.Window window, int source, int source_type, int buffer_scale, int x, int y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DrawingContext gdk_cairo_get_drawing_context(cairo.Context cr);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_rectangle(cairo.Context cr, Gdk.Rectangle rectangle);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_region(cairo.Context cr, cairo.Region region);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Region gdk_cairo_region_create_from_surface(cairo.Surface surface);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_color(cairo.Context cr, Gdk.Color color);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_pixbuf(cairo.Context cr, GdkPixbuf.Pixbuf pixbuf, double pixbuf_x, double pixbuf_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_rgba(cairo.Context cr, Gdk.RGBA rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_window(cairo.Context cr, Gdk.Window window, double x, double y);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Surface gdk_cairo_surface_create_from_pixbuf(GdkPixbuf.Pixbuf pixbuf, int scale, Gdk.Window for_window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_disable_multidevice();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_abort(Gdk.DragContext context, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragContext gdk_drag_begin(Gdk.Window window, System.IntPtr targets);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragContext gdk_drag_begin_for_device(Gdk.Window window, Gdk.Device device, System.IntPtr targets);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragContext gdk_drag_begin_from_point(Gdk.Window window, Gdk.Device device, System.IntPtr targets, int x_root, int y_root);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_drop(Gdk.DragContext context, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_drop_done(Gdk.DragContext context, bool success);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_drag_drop_succeeded(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_find_window_for_screen(Gdk.DragContext context, Gdk.Window drag_window, Gdk.Screen screen, int x_root, int y_root, out Gdk.Window dest_window, out Gdk.DragProtocol protocol);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_drag_motion(Gdk.DragContext context, Gdk.Window dest_window, Gdk.DragProtocol protocol, int x_root, int y_root, Gdk.DragAction suggested_action, Gdk.DragAction possible_actions, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_status(Gdk.DragContext context, Gdk.DragAction action, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drop_finish(Gdk.DragContext context, bool success, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drop_reply(Gdk.DragContext context, bool accepted, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_error_trap_pop();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_error_trap_pop_ignored();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_error_trap_push();
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_events_get_angle(System.IntPtr event1, System.IntPtr event2, System.IntPtr angle);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_events_get_center(System.IntPtr event1, System.IntPtr event2, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_events_get_distance(System.IntPtr event1, System.IntPtr event2, System.IntPtr distance);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_events_pending();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_flush();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_get_default_root_window();
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_get_display();
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_get_display_arg_name();
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_get_program_class();
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_get_show_events();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_init(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_init_check(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_keyboard_grab(Gdk.Window window, bool owner_events, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_keyboard_ungrab(uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_keyval_convert_case(uint symbol, System.IntPtr lower, System.IntPtr upper);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keyval_from_name(string keyval_name);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keyval_is_lower(uint keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keyval_is_upper(uint keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_keyval_name(uint keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keyval_to_lower(uint keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keyval_to_unicode(uint keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keyval_to_upper(uint keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_list_visuals();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_notify_startup_complete();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_notify_startup_complete_with_id(string startup_id);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_offscreen_window_get_embedder(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Surface gdk_offscreen_window_get_surface(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_offscreen_window_set_embedder(Gdk.Window window, Gdk.Window embedder);
		[DllImport("libgdk-3.so.0")]
		public static extern Pango.Context gdk_pango_context_get();
		[DllImport("libgdk-3.so.0")]
		public static extern Pango.Context gdk_pango_context_get_for_display(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Pango.Context gdk_pango_context_get_for_screen(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Region gdk_pango_layout_get_clip_region(Pango.Layout layout, int x_origin, int y_origin, System.IntPtr index_ranges, int n_ranges);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Region gdk_pango_layout_line_get_clip_region(Pango.LayoutLine line, int x_origin, int y_origin, System.IntPtr index_ranges, int n_ranges);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_parse_args(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgdk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_get_from_surface(cairo.Surface surface, int src_x, int src_y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_get_from_window(Gdk.Window window, int src_x, int src_y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_pointer_grab(Gdk.Window window, bool owner_events, Gdk.EventMask event_mask, Gdk.Window confine_to, Gdk.Cursor cursor, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_pointer_is_grabbed();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_pointer_ungrab(uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_pre_parse_libgtk_only();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_query_depths(System.IntPtr depths, System.IntPtr count);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_query_visual_types(System.IntPtr visual_types, System.IntPtr count);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_selection_property_get(Gdk.Window requestor, System.IntPtr data, Gdk.Atom prop_type, System.IntPtr prop_format);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_allowed_backends(string backends);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_double_click_time(uint msec);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_program_class(string program_class);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_show_events(bool show_events);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_setting_get(string name, GObject.Value value);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_synthesize_window_state(Gdk.Window window, Gdk.WindowState unset_flags, Gdk.WindowState set_flags);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_test_render_sync(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_test_simulate_button(Gdk.Window window, int x, int y, uint button, Gdk.ModifierType modifiers, Gdk.EventType button_pressrelease);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_test_simulate_key(Gdk.Window window, int x, int y, uint keyval, Gdk.ModifierType modifiers, Gdk.EventType key_pressrelease);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_threads_add_idle(System.IntPtr function, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_threads_add_idle_full(int priority, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_threads_add_timeout(uint interval, System.IntPtr function, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_threads_add_timeout_full(int priority, uint interval, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_threads_add_timeout_seconds(uint interval, System.IntPtr function, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_threads_add_timeout_seconds_full(int priority, uint interval, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_threads_enter();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_threads_init();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_threads_leave();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_threads_set_lock_functions(System.IntPtr enter_fn, System.IntPtr leave_fn);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_unicode_to_keyval(uint wc);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_utf8_to_string_target(string str);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.AppLaunchContext gdk_app_launch_context_new();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_desktop(Gdk.AppLaunchContext context, int desktop);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_display(Gdk.AppLaunchContext context, Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_icon(Gdk.AppLaunchContext context, Gio.Icon icon);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_icon_name(Gdk.AppLaunchContext context, string icon_name);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_screen(Gdk.AppLaunchContext context, Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_timestamp(Gdk.AppLaunchContext context, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_display_get_default();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_display_open(string display_name);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_display_open_default_libgtk_only();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_beep(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_close(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_device_is_grabbed(Gdk.Display display, Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_flush(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.AppLaunchContext gdk_display_get_app_launch_context(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_display_get_default_cursor_size(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_display_get_default_group(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Screen gdk_display_get_default_screen(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Seat gdk_display_get_default_seat(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DeviceManager gdk_display_get_device_manager(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_event(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_get_maximal_cursor_size(Gdk.Display display, System.IntPtr width, System.IntPtr height);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Monitor gdk_display_get_monitor(Gdk.Display display, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Monitor gdk_display_get_monitor_at_point(Gdk.Display display, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Monitor gdk_display_get_monitor_at_window(Gdk.Display display, Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_get_n_monitors(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_get_n_screens(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_display_get_name(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_get_pointer(Gdk.Display display, out Gdk.Screen screen, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Monitor gdk_display_get_primary_monitor(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Screen gdk_display_get_screen(Gdk.Display display, int screen_num);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_display_get_window_at_pointer(Gdk.Display display, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_has_pending(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_is_closed(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_keyboard_ungrab(Gdk.Display display, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_list_devices(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_list_seats(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_notify_startup_complete(Gdk.Display display, string startup_id);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_peek_event(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_pointer_is_grabbed(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_pointer_ungrab(Gdk.Display display, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_put_event(Gdk.Display display, System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_set_double_click_distance(Gdk.Display display, uint distance);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_set_double_click_time(Gdk.Display display, uint msec);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_store_clipboard(Gdk.Display display, Gdk.Window clipboard_window, uint time_, System.IntPtr targets, int n_targets);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_supports_clipboard_persistence(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_supports_composite(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_supports_cursor_alpha(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_supports_cursor_color(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_supports_input_shapes(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_supports_selection_notification(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_display_supports_shapes(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_sync(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_warp_pointer(Gdk.Display display, Gdk.Screen screen, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Screen gdk_screen_get_default();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_height();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_height_mm();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_width();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_width_mm();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_screen_get_active_window(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_screen_get_display(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.FontOptions gdk_screen_get_font_options(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_height(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_height_mm(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_at_point(Gdk.Screen screen, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_at_window(Gdk.Screen screen, Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_height_mm(Gdk.Screen screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_screen_get_monitor_plug_name(Gdk.Screen screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_scale_factor(Gdk.Screen screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_width_mm(Gdk.Screen screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_n_monitors(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_number(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_primary_monitor(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern double gdk_screen_get_resolution(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_screen_get_rgba_visual(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_screen_get_root_window(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_screen_get_setting(Gdk.Screen screen, string name, GObject.Value value);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_screen_get_system_visual(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_toplevel_windows(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_width(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_width_mm(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_window_stack(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_screen_is_composited(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_list_visuals(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_screen_make_display_name(Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_screen_set_font_options(Gdk.Screen screen, cairo.FontOptions options);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_screen_set_resolution(Gdk.Screen screen, double dpi);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Color gdk_color_copy(Gdk.Color color);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_color_equal(Gdk.Color colora, Gdk.Color colorb);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_color_free(Gdk.Color color);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_color_hash(Gdk.Color color);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_color_to_string(Gdk.Color color);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_cursor_new(Gdk.CursorType cursor_type);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_cursor_new_for_display(Gdk.Display display, Gdk.CursorType cursor_type);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_cursor_new_from_name(Gdk.Display display, string name);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_cursor_new_from_pixbuf(Gdk.Display display, GdkPixbuf.Pixbuf pixbuf, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_cursor_new_from_surface(Gdk.Display display, cairo.Surface surface, double x, double y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.CursorType gdk_cursor_get_cursor_type(Gdk.Cursor cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_cursor_get_display(Gdk.Cursor cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_cursor_get_image(Gdk.Cursor cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Surface gdk_cursor_get_surface(Gdk.Cursor cursor, System.IntPtr x_hot, System.IntPtr y_hot);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_cursor_ref(Gdk.Cursor cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cursor_unref(Gdk.Cursor cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_free_history(System.IntPtr events, int n_events);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_device_grab_info_libgtk_only(Gdk.Display display, Gdk.Device device, out Gdk.Window grab_window, System.IntPtr owner_events);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Device gdk_device_get_associated_device(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.AxisFlags gdk_device_get_axes(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_device_get_axis(Gdk.Device device, System.IntPtr axes, Gdk.AxisUse use, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.AxisUse gdk_device_get_axis_use(Gdk.Device device, uint index_);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DeviceType gdk_device_get_device_type(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_device_get_display(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_device_get_has_cursor(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_device_get_history(Gdk.Device device, Gdk.Window window, uint start, uint stop, System.IntPtr events, System.IntPtr n_events);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_device_get_key(Gdk.Device device, uint index_, System.IntPtr keyval, out Gdk.ModifierType modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_device_get_last_event_window(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.InputMode gdk_device_get_mode(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_n_axes(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_n_keys(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_device_get_name(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_get_position(Gdk.Device device, out Gdk.Screen screen, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_get_position_double(Gdk.Device device, out Gdk.Screen screen, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_device_get_product_id(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Seat gdk_device_get_seat(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.InputSource gdk_device_get_source(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_get_state(Gdk.Device device, Gdk.Window window, System.IntPtr axes, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_device_get_vendor_id(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_device_get_window_at_position(Gdk.Device device, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_device_get_window_at_position_double(Gdk.Device device, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_device_grab(Gdk.Device device, Gdk.Window window, Gdk.GrabOwnership grab_ownership, bool owner_events, Gdk.EventMask event_mask, Gdk.Cursor cursor, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_list_axes(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_list_slave_devices(Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_set_axis_use(Gdk.Device device, uint index_, Gdk.AxisUse use);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_set_key(Gdk.Device device, uint index_, uint keyval, Gdk.ModifierType modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_device_set_mode(Gdk.Device device, Gdk.InputMode mode);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_ungrab(Gdk.Device device, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_warp(Gdk.Device device, Gdk.Screen screen, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_new(Gdk.Window parent, Gdk.WindowAttr attributes, Gdk.WindowAttributesType attributes_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_at_pointer(System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_constrain_size(Gdk.Geometry geometry, Gdk.WindowHints flags, int width, int height, System.IntPtr new_width, System.IntPtr new_height);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_process_all_updates();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_debug_updates(bool setting);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_add_filter(Gdk.Window window, System.IntPtr function, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_beep(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DrawingContext gdk_window_begin_draw_frame(Gdk.Window window, cairo.Region region);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_move_drag(Gdk.Window window, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_move_drag_for_device(Gdk.Window window, Gdk.Device device, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_paint_rect(Gdk.Window window, Gdk.Rectangle rectangle);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_paint_region(Gdk.Window window, cairo.Region region);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_resize_drag(Gdk.Window window, Gdk.WindowEdge edge, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_resize_drag_for_device(Gdk.Window window, Gdk.WindowEdge edge, Gdk.Device device, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_configure_finished(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_coords_from_parent(Gdk.Window window, double parent_x, double parent_y, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_coords_to_parent(Gdk.Window window, double x, double y, System.IntPtr parent_x, System.IntPtr parent_y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GLContext gdk_window_create_gl_context(Gdk.Window window, out GLib.Error error);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Surface gdk_window_create_similar_image_surface(Gdk.Window window, int format, int width, int height, int scale);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Surface gdk_window_create_similar_surface(Gdk.Window window, cairo.Content content, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_deiconify(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_destroy(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_destroy_notify(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_enable_synchronized_configure(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_end_draw_frame(Gdk.Window window, Gdk.DrawingContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_end_paint(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_ensure_native(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_flush(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_focus(Gdk.Window window, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_freeze_toplevel_updates_libgtk_only(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_freeze_updates(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_fullscreen(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_fullscreen_on_monitor(Gdk.Window window, int monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_geometry_changed(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_accept_focus(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Pattern gdk_window_get_background_pattern(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_children(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_children_with_user_data(Gdk.Window window, System.IntPtr user_data);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Region gdk_window_get_clip_region(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_composited(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_window_get_cursor(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_decorations(Gdk.Window window, out Gdk.WMDecoration decorations);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Cursor gdk_window_get_device_cursor(Gdk.Window window, Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventMask gdk_window_get_device_events(Gdk.Window window, Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_device_position(Gdk.Window window, Gdk.Device device, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_device_position_double(Gdk.Window window, Gdk.Device device, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_window_get_display(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragProtocol gdk_window_get_drag_protocol(Gdk.Window window, out Gdk.Window target);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_effective_parent(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_effective_toplevel(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_event_compression(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventMask gdk_window_get_events(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_focus_on_map(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.FrameClock gdk_window_get_frame_clock(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.FullscreenMode gdk_window_get_fullscreen_mode(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_geometry(Gdk.Window window, System.IntPtr x, System.IntPtr y, System.IntPtr width, System.IntPtr height);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_group(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_height(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_modal_hint(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_origin(Gdk.Window window, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_parent(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_pass_through(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_pointer(Gdk.Window window, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_position(Gdk.Window window, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_root_coords(Gdk.Window window, int x, int y, System.IntPtr root_x, System.IntPtr root_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_root_origin(Gdk.Window window, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_scale_factor(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Screen gdk_window_get_screen(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventMask gdk_window_get_source_events(Gdk.Window window, Gdk.InputSource source);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.WindowState gdk_window_get_state(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_get_support_multidevice(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_window_get_toplevel(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.WindowTypeHint gdk_window_get_type_hint(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Region gdk_window_get_update_area(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_user_data(Gdk.Window window, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Region gdk_window_get_visible_region(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_window_get_visual(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_width(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.WindowType gdk_window_get_window_type(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_has_native(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_hide(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_iconify(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_input_shape_combine_region(Gdk.Window window, cairo.Region shape_region, int offset_x, int offset_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_invalidate_maybe_recurse(Gdk.Window window, cairo.Region region, System.IntPtr child_func, System.IntPtr user_data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_invalidate_rect(Gdk.Window window, Gdk.Rectangle rect, bool invalidate_children);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_invalidate_region(Gdk.Window window, cairo.Region region, bool invalidate_children);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_is_destroyed(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_is_input_only(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_is_shaped(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_is_viewable(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_is_visible(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_lower(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_mark_paint_from_clip(Gdk.Window window, cairo.Context cr);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_maximize(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_merge_child_input_shapes(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_merge_child_shapes(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_move(Gdk.Window window, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_move_region(Gdk.Window window, cairo.Region region, int dx, int dy);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_move_resize(Gdk.Window window, int x, int y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_peek_children(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_process_updates(Gdk.Window window, bool update_children);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_raise(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_register_dnd(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_remove_filter(Gdk.Window window, System.IntPtr function, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_reparent(Gdk.Window window, Gdk.Window new_parent, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_resize(Gdk.Window window, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_restack(Gdk.Window window, Gdk.Window sibling, bool above);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_scroll(Gdk.Window window, int dx, int dy);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_accept_focus(Gdk.Window window, bool accept_focus);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_background(Gdk.Window window, Gdk.Color color);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_background_pattern(Gdk.Window window, cairo.Pattern pattern);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_background_rgba(Gdk.Window window, Gdk.RGBA rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_child_input_shapes(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_child_shapes(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_composited(Gdk.Window window, bool composited);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_cursor(Gdk.Window window, Gdk.Cursor cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_decorations(Gdk.Window window, Gdk.WMDecoration decorations);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_device_cursor(Gdk.Window window, Gdk.Device device, Gdk.Cursor cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_device_events(Gdk.Window window, Gdk.Device device, Gdk.EventMask event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_event_compression(Gdk.Window window, bool event_compression);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_events(Gdk.Window window, Gdk.EventMask event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_focus_on_map(Gdk.Window window, bool focus_on_map);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_fullscreen_mode(Gdk.Window window, Gdk.FullscreenMode mode);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_functions(Gdk.Window window, Gdk.WMFunction functions);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_geometry_hints(Gdk.Window window, Gdk.Geometry geometry, Gdk.WindowHints geom_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_group(Gdk.Window window, Gdk.Window leader);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_icon_list(Gdk.Window window, System.IntPtr pixbufs);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_icon_name(Gdk.Window window, string name);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_invalidate_handler(Gdk.Window window, System.IntPtr handler);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_keep_above(Gdk.Window window, bool setting);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_keep_below(Gdk.Window window, bool setting);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_modal_hint(Gdk.Window window, bool modal);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_opacity(Gdk.Window window, double opacity);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_opaque_region(Gdk.Window window, cairo.Region region);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_override_redirect(Gdk.Window window, bool override_redirect);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_pass_through(Gdk.Window window, bool pass_through);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_role(Gdk.Window window, string role);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_shadow_width(Gdk.Window window, int left, int right, int top, int bottom);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_skip_pager_hint(Gdk.Window window, bool skips_pager);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_skip_taskbar_hint(Gdk.Window window, bool skips_taskbar);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_source_events(Gdk.Window window, Gdk.InputSource source, Gdk.EventMask event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_startup_id(Gdk.Window window, string startup_id);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_set_static_gravities(Gdk.Window window, bool use_static);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_support_multidevice(Gdk.Window window, bool support_multidevice);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_title(Gdk.Window window, string title);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_transient_for(Gdk.Window window, Gdk.Window parent);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_type_hint(Gdk.Window window, Gdk.WindowTypeHint hint);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_urgency_hint(Gdk.Window window, bool urgent);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_user_data(Gdk.Window window, GObject.Object user_data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_shape_combine_region(Gdk.Window window, cairo.Region shape_region, int offset_x, int offset_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_show(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_show_unraised(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_window_show_window_menu(Gdk.Window window, System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_stick(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_thaw_toplevel_updates_libgtk_only(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_thaw_updates(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_unfullscreen(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_unmaximize(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_unstick(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_withdraw(Gdk.Window window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.SeatCapabilities gdk_seat_get_capabilities(Gdk.Seat seat);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_seat_get_display(Gdk.Seat seat);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Device gdk_seat_get_keyboard(Gdk.Seat seat);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Device gdk_seat_get_pointer(Gdk.Seat seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_slaves(Gdk.Seat seat, Gdk.SeatCapabilities capabilities);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_seat_grab(Gdk.Seat seat, Gdk.Window window, Gdk.SeatCapabilities capabilities, bool owner_events, Gdk.Cursor cursor, System.IntPtr @event, System.IntPtr prepare_func, System.IntPtr prepare_func_data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_seat_ungrab(Gdk.Seat seat);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Device gdk_device_manager_get_client_pointer(Gdk.DeviceManager device_manager);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_device_manager_get_display(Gdk.DeviceManager device_manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_manager_list_devices(Gdk.DeviceManager device_manager, Gdk.DeviceType type);
		[DllImport("libgdk-3.so.0")]
		public static extern ulong gdk_device_tool_get_hardware_id(Gdk.DeviceTool tool);
		[DllImport("libgdk-3.so.0")]
		public static extern ulong gdk_device_tool_get_serial(Gdk.DeviceTool tool);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DeviceToolType gdk_device_tool_get_tool_type(Gdk.DeviceTool tool);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_feature_group(Gdk.DevicePad pad, Gdk.DevicePadFeature feature, int feature_idx);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_group_n_modes(Gdk.DevicePad pad, int group_idx);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_n_features(Gdk.DevicePad pad, Gdk.DevicePadFeature feature);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_n_groups(Gdk.DevicePad pad);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_new(Gdk.EventType type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_copy(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_free(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_axis(System.IntPtr @event, Gdk.AxisUse axis_use, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_button(System.IntPtr @event, System.IntPtr button);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_click_count(System.IntPtr @event, System.IntPtr click_count);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_coords(System.IntPtr @event, System.IntPtr x_win, System.IntPtr y_win);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Device gdk_event_get_device(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DeviceTool gdk_event_get_device_tool(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventSequence gdk_event_get_event_sequence(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventType gdk_event_get_event_type(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_keycode(System.IntPtr @event, System.IntPtr keycode);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_keyval(System.IntPtr @event, System.IntPtr keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_pointer_emulated(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_root_coords(System.IntPtr @event, System.IntPtr x_root, System.IntPtr y_root);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_scancode(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Screen gdk_event_get_screen(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_scroll_deltas(System.IntPtr @event, System.IntPtr delta_x, System.IntPtr delta_y);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_scroll_direction(System.IntPtr @event, out Gdk.ScrollDirection direction);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Seat gdk_event_get_seat(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Device gdk_event_get_source_device(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_get_state(System.IntPtr @event, out Gdk.ModifierType state);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_event_get_time(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_event_get_window(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_is_scroll_stop_event(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_put(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_device(System.IntPtr @event, Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_device_tool(System.IntPtr @event, Gdk.DeviceTool tool);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_screen(System.IntPtr @event, Gdk.Screen screen);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_source_device(System.IntPtr @event, Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_event_triggers_context_menu(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_handler_set(System.IntPtr func, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_peek();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_request_motions(Gdk.EventMotion @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_monitor_get_display(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_height_mm(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_monitor_get_manufacturer(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_monitor_get_model(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_refresh_rate(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_scale_factor(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.SubpixelLayout gdk_monitor_get_subpixel_layout(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_width_mm(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_monitor_is_primary(Gdk.Monitor monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DisplayManager gdk_display_manager_get();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_display_manager_get_default_display(Gdk.DisplayManager manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_manager_list_displays(Gdk.DisplayManager manager);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_display_manager_open_display(Gdk.DisplayManager manager, string name);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_manager_set_default_display(Gdk.DisplayManager manager, Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragAction gdk_drag_context_get_actions(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_drag_context_get_dest_window(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Device gdk_drag_context_get_device(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_drag_context_get_drag_window(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragProtocol gdk_drag_context_get_protocol(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragAction gdk_drag_context_get_selected_action(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_drag_context_get_source_window(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragAction gdk_drag_context_get_suggested_action(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_list_targets(Gdk.DragContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_drag_context_manage_dnd(Gdk.DragContext context, Gdk.Window ipc_window, Gdk.DragAction actions);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_context_set_device(Gdk.DragContext context, Gdk.Device device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_context_set_hotspot(Gdk.DragContext context, int hot_x, int hot_y);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Context gdk_drawing_context_get_cairo_context(Gdk.DrawingContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern cairo.Region gdk_drawing_context_get_clip(Gdk.DrawingContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_drawing_context_get_window(Gdk.DrawingContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_drawing_context_is_valid(Gdk.DrawingContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_rectangle_equal(Gdk.Rectangle rect1, Gdk.Rectangle rect2);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_begin_updating(Gdk.FrameClock frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_end_updating(Gdk.FrameClock frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.FrameTimings gdk_frame_clock_get_current_timings(Gdk.FrameClock frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_clock_get_frame_counter(Gdk.FrameClock frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_clock_get_frame_time(Gdk.FrameClock frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_clock_get_history_start(Gdk.FrameClock frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_get_refresh_info(Gdk.FrameClock frame_clock, long base_time, System.IntPtr refresh_interval_return, System.IntPtr presentation_time_return);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.FrameTimings gdk_frame_clock_get_timings(Gdk.FrameClock frame_clock, long frame_counter);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_request_phase(Gdk.FrameClock frame_clock, Gdk.FrameClockPhase phase);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_frame_timings_get_complete(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_frame_counter(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_frame_time(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_predicted_presentation_time(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_presentation_time(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_refresh_interval(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.FrameTimings gdk_frame_timings_ref(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_timings_unref(Gdk.FrameTimings timings);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_clear_current();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GLContext gdk_gl_context_get_current();
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_gl_context_get_debug_enabled(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Display gdk_gl_context_get_display(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_gl_context_get_forward_compatible(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_get_required_version(Gdk.GLContext context, System.IntPtr major, System.IntPtr minor);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GLContext gdk_gl_context_get_shared_context(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_gl_context_get_use_es(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_get_version(Gdk.GLContext context, System.IntPtr major, System.IntPtr minor);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Window gdk_gl_context_get_window(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_gl_context_is_legacy(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_make_current(Gdk.GLContext context);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_gl_context_realize(Gdk.GLContext context, out GLib.Error error);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_debug_enabled(Gdk.GLContext context, bool enabled);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_forward_compatible(Gdk.GLContext context, bool compatible);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_required_version(Gdk.GLContext context, int major, int minor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_use_es(Gdk.GLContext context, int use_es);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_gl_error_quark();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Keymap gdk_keymap_get_default();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Keymap gdk_keymap_get_for_display(Gdk.Display display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_keymap_add_virtual_modifiers(Gdk.Keymap keymap, ref Gdk.ModifierType state);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_get_caps_lock_state(Gdk.Keymap keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern Pango.Direction gdk_keymap_get_direction(Gdk.Keymap keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_get_entries_for_keycode(Gdk.Keymap keymap, uint hardware_keycode, System.IntPtr keys, System.IntPtr keyvals, System.IntPtr n_entries);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_get_entries_for_keyval(Gdk.Keymap keymap, uint keyval, System.IntPtr keys, System.IntPtr n_keys);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.ModifierType gdk_keymap_get_modifier_mask(Gdk.Keymap keymap, Gdk.ModifierIntent intent);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keymap_get_modifier_state(Gdk.Keymap keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_get_num_lock_state(Gdk.Keymap keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_get_scroll_lock_state(Gdk.Keymap keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_have_bidi_layouts(Gdk.Keymap keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keymap_lookup_key(Gdk.Keymap keymap, Gdk.KeymapKey key);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_map_virtual_modifiers(Gdk.Keymap keymap, ref Gdk.ModifierType state);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_keymap_translate_keyboard_state(Gdk.Keymap keymap, uint hardware_keycode, Gdk.ModifierType state, int group, System.IntPtr keyval, System.IntPtr effective_group, System.IntPtr level, out Gdk.ModifierType consumed_modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.RGBA gdk_rgba_copy(Gdk.RGBA rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_rgba_equal(Gdk.RGBA p1, Gdk.RGBA p2);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_rgba_free(Gdk.RGBA rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_rgba_hash(Gdk.RGBA p);
		[DllImport("libgdk-3.so.0")]
		public static extern bool gdk_rgba_parse(Gdk.RGBA rgba, string spec);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_rgba_to_string(Gdk.RGBA rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_visual_get_best();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_best_depth();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.VisualType gdk_visual_get_best_type();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_visual_get_best_with_both(int depth, Gdk.VisualType visual_type);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_visual_get_best_with_depth(int depth);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_visual_get_best_with_type(Gdk.VisualType visual_type);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Visual gdk_visual_get_system();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_bits_per_rgb(Gdk.Visual visual);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_visual_get_blue_pixel_details(Gdk.Visual visual, System.IntPtr mask, System.IntPtr shift, System.IntPtr precision);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.ByteOrder gdk_visual_get_byte_order(Gdk.Visual visual);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_colormap_size(Gdk.Visual visual);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_depth(Gdk.Visual visual);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_visual_get_green_pixel_details(Gdk.Visual visual, System.IntPtr mask, System.IntPtr shift, System.IntPtr precision);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_visual_get_red_pixel_details(Gdk.Visual visual, System.IntPtr mask, System.IntPtr shift, System.IntPtr precision);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.Screen gdk_visual_get_screen(Gdk.Visual visual);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.VisualType gdk_visual_get_visual_type(Gdk.Visual visual);
	}
}
