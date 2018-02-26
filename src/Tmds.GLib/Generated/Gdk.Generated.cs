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
	public enum DevicePadFeature
	{
		button = 0,
		ring = 1,
		strip = 2,
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
	public enum FullscreenMode
	{
		current_monitor = 0,
		all_monitors = 1,
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
	public enum PropMode
	{
		replace = 0,
		prepend = 1,
		append = 2,
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
	public static class GdkInterop {
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_add_option_entries_libgtk_only(System.IntPtr group);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_beep();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cairo_create(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_draw_from_gl(System.IntPtr cr, System.IntPtr window, int source, int source_type, int buffer_scale, int x, int y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_cairo_get_clip_rectangle(System.IntPtr cr, System.IntPtr rect);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cairo_get_drawing_context(System.IntPtr cr);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_rectangle(System.IntPtr cr, System.IntPtr rectangle);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_region(System.IntPtr cr, System.IntPtr region);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cairo_region_create_from_surface(System.IntPtr surface);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_color(System.IntPtr cr, System.IntPtr color);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_pixbuf(System.IntPtr cr, System.IntPtr pixbuf, double pixbuf_x, double pixbuf_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_rgba(System.IntPtr cr, System.IntPtr rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cairo_set_source_window(System.IntPtr cr, System.IntPtr window, double x, double y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cairo_surface_create_from_pixbuf(System.IntPtr pixbuf, int scale, System.IntPtr for_window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_disable_multidevice();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_abort(System.IntPtr context, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_begin(System.IntPtr window, System.IntPtr targets);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_begin_for_device(System.IntPtr window, System.IntPtr device, System.IntPtr targets);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_begin_from_point(System.IntPtr window, System.IntPtr device, System.IntPtr targets, int x_root, int y_root);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_drop(System.IntPtr context, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_drop_done(System.IntPtr context, int success);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_drop_succeeded(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_find_window_for_screen(System.IntPtr context, System.IntPtr drag_window, System.IntPtr screen, int x_root, int y_root, System.IntPtr dest_window, out Gdk.DragProtocol protocol);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_get_selection(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_motion(System.IntPtr context, System.IntPtr dest_window, Gdk.DragProtocol protocol, int x_root, int y_root, Gdk.DragAction suggested_action, Gdk.DragAction possible_actions, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_status(System.IntPtr context, Gdk.DragAction action, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drop_finish(System.IntPtr context, int success, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drop_reply(System.IntPtr context, int accepted, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_error_trap_pop();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_error_trap_pop_ignored();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_error_trap_push();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_events_get_angle(System.IntPtr event1, System.IntPtr event2, System.IntPtr angle);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_events_get_center(System.IntPtr event1, System.IntPtr event2, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_events_get_distance(System.IntPtr event1, System.IntPtr event2, System.IntPtr distance);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_events_pending();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_flush();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_get_default_root_window();
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_get_display();
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_get_display_arg_name();
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_get_program_class();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_get_show_events();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_init(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_init_check(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_keyboard_grab(System.IntPtr window, int owner_events, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_keyboard_ungrab(uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_keyval_convert_case(uint symbol, System.IntPtr lower, System.IntPtr upper);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keyval_from_name(string keyval_name);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keyval_is_lower(uint keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keyval_is_upper(uint keyval);
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
		public static extern System.IntPtr gdk_offscreen_window_get_embedder(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_offscreen_window_get_surface(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_offscreen_window_set_embedder(System.IntPtr window, System.IntPtr embedder);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_pango_context_get();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_pango_context_get_for_display(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_pango_context_get_for_screen(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_pango_layout_get_clip_region(System.IntPtr layout, int x_origin, int y_origin, System.IntPtr index_ranges, int n_ranges);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_pango_layout_line_get_clip_region(System.IntPtr line, int x_origin, int y_origin, System.IntPtr index_ranges, int n_ranges);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_parse_args(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_pixbuf_get_from_surface(System.IntPtr surface, int src_x, int src_y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_pixbuf_get_from_window(System.IntPtr window, int src_x, int src_y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_pointer_grab(System.IntPtr window, int owner_events, Gdk.EventMask event_mask, System.IntPtr confine_to, System.IntPtr cursor, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_pointer_is_grabbed();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_pointer_ungrab(uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_pre_parse_libgtk_only();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_property_change(System.IntPtr window, System.IntPtr property, System.IntPtr type, int format, Gdk.PropMode mode, System.IntPtr data, int nelements);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_property_delete(System.IntPtr window, System.IntPtr property);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_property_get(System.IntPtr window, System.IntPtr property, System.IntPtr type, ulong offset, ulong length, int pdelete, System.IntPtr actual_property_type, System.IntPtr actual_format, System.IntPtr actual_length, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_query_depths(System.IntPtr depths, System.IntPtr count);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_query_visual_types(System.IntPtr visual_types, System.IntPtr count);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_selection_convert(System.IntPtr requestor, System.IntPtr selection, System.IntPtr target, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_selection_owner_get(System.IntPtr selection);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_selection_owner_get_for_display(System.IntPtr display, System.IntPtr selection);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_selection_owner_set(System.IntPtr owner, System.IntPtr selection, uint time_, int send_event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_selection_owner_set_for_display(System.IntPtr display, System.IntPtr owner, System.IntPtr selection, uint time_, int send_event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_selection_property_get(System.IntPtr requestor, System.IntPtr data, System.IntPtr prop_type, System.IntPtr prop_format);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_selection_send_notify(System.IntPtr requestor, System.IntPtr selection, System.IntPtr target, System.IntPtr property, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_selection_send_notify_for_display(System.IntPtr display, System.IntPtr requestor, System.IntPtr selection, System.IntPtr target, System.IntPtr property, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_allowed_backends(string backends);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_double_click_time(uint msec);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_program_class(string program_class);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_set_show_events(int show_events);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_setting_get(string name, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_synthesize_window_state(System.IntPtr window, Gdk.WindowState unset_flags, Gdk.WindowState set_flags);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_test_render_sync(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_test_simulate_button(System.IntPtr window, int x, int y, uint button, Gdk.ModifierType modifiers, Gdk.EventType button_pressrelease);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_test_simulate_key(System.IntPtr window, int x, int y, uint keyval, Gdk.ModifierType modifiers, Gdk.EventType key_pressrelease);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_text_property_to_utf8_list_for_display(System.IntPtr display, System.IntPtr encoding, int format, System.IntPtr text, int length, System.IntPtr list);
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
		public static extern System.IntPtr gdk_app_launch_context_new();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_desktop(System.IntPtr context, int desktop);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_display(System.IntPtr context, System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_icon(System.IntPtr context, System.IntPtr icon);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_icon_name(System.IntPtr context, string icon_name);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_screen(System.IntPtr context, System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_app_launch_context_set_timestamp(System.IntPtr context, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_default();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_open(string display_name);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_open_default_libgtk_only();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_beep(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_close(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_device_is_grabbed(System.IntPtr display, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_flush(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_app_launch_context(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_display_get_default_cursor_size(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_default_group(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_default_screen(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_default_seat(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_device_manager(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_event(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_get_maximal_cursor_size(System.IntPtr display, System.IntPtr width, System.IntPtr height);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_monitor(System.IntPtr display, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_monitor_at_point(System.IntPtr display, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_monitor_at_window(System.IntPtr display, System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_get_n_monitors(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_get_n_screens(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_display_get_name(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_get_pointer(System.IntPtr display, System.IntPtr screen, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_primary_monitor(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_screen(System.IntPtr display, int screen_num);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_get_window_at_pointer(System.IntPtr display, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_has_pending(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_is_closed(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_keyboard_ungrab(System.IntPtr display, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_list_devices(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_list_seats(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_notify_startup_complete(System.IntPtr display, string startup_id);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_peek_event(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_pointer_is_grabbed(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_pointer_ungrab(System.IntPtr display, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_put_event(System.IntPtr display, System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_request_selection_notification(System.IntPtr display, System.IntPtr selection);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_set_double_click_distance(System.IntPtr display, uint distance);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_set_double_click_time(System.IntPtr display, uint msec);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_store_clipboard(System.IntPtr display, System.IntPtr clipboard_window, uint time_, System.IntPtr targets, int n_targets);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_supports_clipboard_persistence(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_supports_composite(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_supports_cursor_alpha(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_supports_cursor_color(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_supports_input_shapes(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_supports_selection_notification(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_display_supports_shapes(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_sync(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_warp_pointer(System.IntPtr display, System.IntPtr screen, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_default();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_height();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_height_mm();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_width();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_width_mm();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_active_window(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_display(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_font_options(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_height(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_height_mm(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_at_point(System.IntPtr screen, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_at_window(System.IntPtr screen, System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_screen_get_monitor_geometry(System.IntPtr screen, int monitor_num, System.IntPtr dest);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_height_mm(System.IntPtr screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_screen_get_monitor_plug_name(System.IntPtr screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_scale_factor(System.IntPtr screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_monitor_width_mm(System.IntPtr screen, int monitor_num);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_screen_get_monitor_workarea(System.IntPtr screen, int monitor_num, System.IntPtr dest);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_n_monitors(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_number(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_primary_monitor(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern double gdk_screen_get_resolution(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_rgba_visual(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_root_window(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_setting(System.IntPtr screen, string name, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_system_visual(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_toplevel_windows(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_width(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_get_width_mm(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_get_window_stack(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_screen_is_composited(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_screen_list_visuals(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_screen_make_display_name(System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_screen_set_font_options(System.IntPtr screen, System.IntPtr options);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_screen_set_resolution(System.IntPtr screen, double dpi);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_atom_name(System.IntPtr atom);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_atom_intern(string atom_name, int only_if_exists);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_atom_intern_static_string(string atom_name);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_color_copy(System.IntPtr color);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_color_equal(System.IntPtr colora, System.IntPtr colorb);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_color_free(System.IntPtr color);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_color_hash(System.IntPtr color);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_color_to_string(System.IntPtr color);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_color_parse(string spec, System.IntPtr color);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new(Gdk.CursorType cursor_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_for_display(System.IntPtr display, Gdk.CursorType cursor_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_from_name(System.IntPtr display, string name);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_from_pixbuf(System.IntPtr display, System.IntPtr pixbuf, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_from_surface(System.IntPtr display, System.IntPtr surface, double x, double y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.CursorType gdk_cursor_get_cursor_type(System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_get_display(System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_get_image(System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_get_surface(System.IntPtr cursor, System.IntPtr x_hot, System.IntPtr y_hot);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_ref(System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_cursor_unref(System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_free_history(System.IntPtr events, int n_events);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_grab_info_libgtk_only(System.IntPtr display, System.IntPtr device, System.IntPtr grab_window, System.IntPtr owner_events);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_associated_device(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.AxisFlags gdk_device_get_axes(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_axis(System.IntPtr device, System.IntPtr axes, Gdk.AxisUse use, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.AxisUse gdk_device_get_axis_use(System.IntPtr device, uint index_);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_axis_value(System.IntPtr device, System.IntPtr axes, System.IntPtr axis_label, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DeviceType gdk_device_get_device_type(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_display(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_has_cursor(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_history(System.IntPtr device, System.IntPtr window, uint start, uint stop, System.IntPtr events, System.IntPtr n_events);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_key(System.IntPtr device, uint index_, System.IntPtr keyval, out Gdk.ModifierType modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_last_event_window(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.InputMode gdk_device_get_mode(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_n_axes(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_n_keys(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_device_get_name(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_get_position(System.IntPtr device, System.IntPtr screen, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_get_position_double(System.IntPtr device, System.IntPtr screen, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_device_get_product_id(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_seat(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.InputSource gdk_device_get_source(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_get_state(System.IntPtr device, System.IntPtr window, System.IntPtr axes, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_device_get_vendor_id(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_window_at_position(System.IntPtr device, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_window_at_position_double(System.IntPtr device, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_device_grab(System.IntPtr device, System.IntPtr window, Gdk.GrabOwnership grab_ownership, int owner_events, Gdk.EventMask event_mask, System.IntPtr cursor, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_list_axes(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_list_slave_devices(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_set_axis_use(System.IntPtr device, uint index_, Gdk.AxisUse use);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_set_key(System.IntPtr device, uint index_, uint keyval, Gdk.ModifierType modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_set_mode(System.IntPtr device, Gdk.InputMode mode);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_ungrab(System.IntPtr device, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_warp(System.IntPtr device, System.IntPtr screen, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_new(System.IntPtr parent, System.IntPtr attributes, Gdk.WindowAttributesType attributes_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_at_pointer(System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_constrain_size(System.IntPtr geometry, Gdk.WindowHints flags, int width, int height, System.IntPtr new_width, System.IntPtr new_height);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_process_all_updates();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_debug_updates(int setting);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_add_filter(System.IntPtr window, System.IntPtr function, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_beep(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_begin_draw_frame(System.IntPtr window, System.IntPtr region);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_move_drag(System.IntPtr window, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_move_drag_for_device(System.IntPtr window, System.IntPtr device, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_paint_rect(System.IntPtr window, System.IntPtr rectangle);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_paint_region(System.IntPtr window, System.IntPtr region);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_resize_drag(System.IntPtr window, Gdk.WindowEdge edge, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_resize_drag_for_device(System.IntPtr window, Gdk.WindowEdge edge, System.IntPtr device, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_configure_finished(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_coords_from_parent(System.IntPtr window, double parent_x, double parent_y, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_coords_to_parent(System.IntPtr window, double x, double y, System.IntPtr parent_x, System.IntPtr parent_y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_create_gl_context(System.IntPtr window, System.IntPtr error);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_create_similar_image_surface(System.IntPtr window, int format, int width, int height, int scale);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_create_similar_surface(System.IntPtr window, cairo.Content content, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_deiconify(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_destroy(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_destroy_notify(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_enable_synchronized_configure(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_end_draw_frame(System.IntPtr window, System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_end_paint(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_ensure_native(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_flush(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_focus(System.IntPtr window, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_freeze_toplevel_updates_libgtk_only(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_freeze_updates(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_fullscreen(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_fullscreen_on_monitor(System.IntPtr window, int monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_geometry_changed(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_accept_focus(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_background_pattern(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_children(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_children_with_user_data(System.IntPtr window, System.IntPtr user_data);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_clip_region(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_composited(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_cursor(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_decorations(System.IntPtr window, out Gdk.WMDecoration decorations);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_device_cursor(System.IntPtr window, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventMask gdk_window_get_device_events(System.IntPtr window, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_device_position(System.IntPtr window, System.IntPtr device, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_device_position_double(System.IntPtr window, System.IntPtr device, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_display(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragProtocol gdk_window_get_drag_protocol(System.IntPtr window, System.IntPtr target);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_effective_parent(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_effective_toplevel(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_event_compression(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventMask gdk_window_get_events(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_focus_on_map(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_frame_clock(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_frame_extents(System.IntPtr window, System.IntPtr rect);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.FullscreenMode gdk_window_get_fullscreen_mode(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_geometry(System.IntPtr window, System.IntPtr x, System.IntPtr y, System.IntPtr width, System.IntPtr height);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_group(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_height(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_modal_hint(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_origin(System.IntPtr window, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_parent(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_pass_through(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_pointer(System.IntPtr window, System.IntPtr x, System.IntPtr y, out Gdk.ModifierType mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_position(System.IntPtr window, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_root_coords(System.IntPtr window, int x, int y, System.IntPtr root_x, System.IntPtr root_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_root_origin(System.IntPtr window, System.IntPtr x, System.IntPtr y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_scale_factor(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_screen(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventMask gdk_window_get_source_events(System.IntPtr window, Gdk.InputSource source);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.WindowState gdk_window_get_state(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_support_multidevice(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_toplevel(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.WindowTypeHint gdk_window_get_type_hint(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_update_area(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_user_data(System.IntPtr window, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_visible_region(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_visual(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_width(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.WindowType gdk_window_get_window_type(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_has_native(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_hide(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_iconify(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_input_shape_combine_region(System.IntPtr window, System.IntPtr shape_region, int offset_x, int offset_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_invalidate_maybe_recurse(System.IntPtr window, System.IntPtr region, System.IntPtr child_func, System.IntPtr user_data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_invalidate_rect(System.IntPtr window, System.IntPtr rect, int invalidate_children);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_invalidate_region(System.IntPtr window, System.IntPtr region, int invalidate_children);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_is_destroyed(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_is_input_only(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_is_shaped(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_is_viewable(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_is_visible(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_lower(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_mark_paint_from_clip(System.IntPtr window, System.IntPtr cr);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_maximize(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_merge_child_input_shapes(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_merge_child_shapes(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_move(System.IntPtr window, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_move_region(System.IntPtr window, System.IntPtr region, int dx, int dy);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_move_resize(System.IntPtr window, int x, int y, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_peek_children(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_process_updates(System.IntPtr window, int update_children);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_raise(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_register_dnd(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_remove_filter(System.IntPtr window, System.IntPtr function, System.IntPtr data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_reparent(System.IntPtr window, System.IntPtr new_parent, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_resize(System.IntPtr window, int width, int height);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_restack(System.IntPtr window, System.IntPtr sibling, int above);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_scroll(System.IntPtr window, int dx, int dy);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_accept_focus(System.IntPtr window, int accept_focus);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_background(System.IntPtr window, System.IntPtr color);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_background_pattern(System.IntPtr window, System.IntPtr pattern);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_background_rgba(System.IntPtr window, System.IntPtr rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_child_input_shapes(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_child_shapes(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_composited(System.IntPtr window, int composited);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_cursor(System.IntPtr window, System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_decorations(System.IntPtr window, Gdk.WMDecoration decorations);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_device_cursor(System.IntPtr window, System.IntPtr device, System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_device_events(System.IntPtr window, System.IntPtr device, Gdk.EventMask event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_event_compression(System.IntPtr window, int event_compression);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_events(System.IntPtr window, Gdk.EventMask event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_focus_on_map(System.IntPtr window, int focus_on_map);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_fullscreen_mode(System.IntPtr window, Gdk.FullscreenMode mode);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_functions(System.IntPtr window, Gdk.WMFunction functions);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_geometry_hints(System.IntPtr window, System.IntPtr geometry, Gdk.WindowHints geom_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_group(System.IntPtr window, System.IntPtr leader);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_icon_list(System.IntPtr window, System.IntPtr pixbufs);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_icon_name(System.IntPtr window, string name);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_invalidate_handler(System.IntPtr window, System.IntPtr handler);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_keep_above(System.IntPtr window, int setting);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_keep_below(System.IntPtr window, int setting);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_modal_hint(System.IntPtr window, int modal);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_opacity(System.IntPtr window, double opacity);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_opaque_region(System.IntPtr window, System.IntPtr region);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_override_redirect(System.IntPtr window, int override_redirect);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_pass_through(System.IntPtr window, int pass_through);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_role(System.IntPtr window, string role);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_shadow_width(System.IntPtr window, int left, int right, int top, int bottom);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_skip_pager_hint(System.IntPtr window, int skips_pager);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_skip_taskbar_hint(System.IntPtr window, int skips_taskbar);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_source_events(System.IntPtr window, Gdk.InputSource source, Gdk.EventMask event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_startup_id(System.IntPtr window, string startup_id);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_set_static_gravities(System.IntPtr window, int use_static);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_support_multidevice(System.IntPtr window, int support_multidevice);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_title(System.IntPtr window, string title);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_transient_for(System.IntPtr window, System.IntPtr parent);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_type_hint(System.IntPtr window, Gdk.WindowTypeHint hint);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_urgency_hint(System.IntPtr window, int urgent);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_user_data(System.IntPtr window, System.IntPtr user_data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_shape_combine_region(System.IntPtr window, System.IntPtr shape_region, int offset_x, int offset_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_show(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_show_unraised(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_show_window_menu(System.IntPtr window, System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_stick(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_thaw_toplevel_updates_libgtk_only(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_thaw_updates(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_unfullscreen(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_unmaximize(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_unstick(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_withdraw(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.SeatCapabilities gdk_seat_get_capabilities(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_display(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_keyboard(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_pointer(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_slaves(System.IntPtr seat, Gdk.SeatCapabilities capabilities);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.GrabStatus gdk_seat_grab(System.IntPtr seat, System.IntPtr window, Gdk.SeatCapabilities capabilities, int owner_events, System.IntPtr cursor, System.IntPtr @event, System.IntPtr prepare_func, System.IntPtr prepare_func_data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_seat_ungrab(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_manager_get_client_pointer(System.IntPtr device_manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_manager_get_display(System.IntPtr device_manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_manager_list_devices(System.IntPtr device_manager, Gdk.DeviceType type);
		[DllImport("libgdk-3.so.0")]
		public static extern ulong gdk_device_tool_get_hardware_id(System.IntPtr tool);
		[DllImport("libgdk-3.so.0")]
		public static extern ulong gdk_device_tool_get_serial(System.IntPtr tool);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DeviceToolType gdk_device_tool_get_tool_type(System.IntPtr tool);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_feature_group(System.IntPtr pad, Gdk.DevicePadFeature feature, int feature_idx);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_group_n_modes(System.IntPtr pad, int group_idx);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_n_features(System.IntPtr pad, Gdk.DevicePadFeature feature);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_n_groups(System.IntPtr pad);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_new(Gdk.EventType type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_copy(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_free(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_axis(System.IntPtr @event, Gdk.AxisUse axis_use, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_button(System.IntPtr @event, System.IntPtr button);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_click_count(System.IntPtr @event, System.IntPtr click_count);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_coords(System.IntPtr @event, System.IntPtr x_win, System.IntPtr y_win);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_device(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_device_tool(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_event_sequence(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.EventType gdk_event_get_event_type(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_keycode(System.IntPtr @event, System.IntPtr keycode);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_keyval(System.IntPtr @event, System.IntPtr keyval);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_pointer_emulated(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_root_coords(System.IntPtr @event, System.IntPtr x_root, System.IntPtr y_root);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_scancode(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_screen(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_scroll_deltas(System.IntPtr @event, System.IntPtr delta_x, System.IntPtr delta_y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_scroll_direction(System.IntPtr @event, out Gdk.ScrollDirection direction);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_seat(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_source_device(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_state(System.IntPtr @event, out Gdk.ModifierType state);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_event_get_time(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_window(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_is_scroll_stop_event(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_put(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_device(System.IntPtr @event, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_device_tool(System.IntPtr @event, System.IntPtr tool);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_screen(System.IntPtr @event, System.IntPtr screen);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_set_source_device(System.IntPtr @event, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_triggers_context_menu(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_handler_set(System.IntPtr func, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_peek();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_request_motions(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_monitor_get_display(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_monitor_get_geometry(System.IntPtr monitor, System.IntPtr geometry);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_height_mm(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_monitor_get_manufacturer(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_monitor_get_model(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_refresh_rate(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_scale_factor(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.SubpixelLayout gdk_monitor_get_subpixel_layout(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_get_width_mm(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_monitor_get_workarea(System.IntPtr monitor, System.IntPtr workarea);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_monitor_is_primary(System.IntPtr monitor);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_manager_get();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_manager_get_default_display(System.IntPtr manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_manager_list_displays(System.IntPtr manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_display_manager_open_display(System.IntPtr manager, string name);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_display_manager_set_default_display(System.IntPtr manager, System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragAction gdk_drag_context_get_actions(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_dest_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_device(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_drag_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragProtocol gdk_drag_context_get_protocol(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragAction gdk_drag_context_get_selected_action(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_source_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.DragAction gdk_drag_context_get_suggested_action(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_list_targets(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_context_manage_dnd(System.IntPtr context, System.IntPtr ipc_window, Gdk.DragAction actions);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_context_set_device(System.IntPtr context, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_context_set_hotspot(System.IntPtr context, int hot_x, int hot_y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drawing_context_get_cairo_context(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drawing_context_get_clip(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drawing_context_get_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drawing_context_is_valid(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_rectangle_equal(System.IntPtr rect1, System.IntPtr rect2);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_rectangle_intersect(System.IntPtr src1, System.IntPtr src2, System.IntPtr dest);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_rectangle_union(System.IntPtr src1, System.IntPtr src2, System.IntPtr dest);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_begin_updating(System.IntPtr frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_end_updating(System.IntPtr frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_frame_clock_get_current_timings(System.IntPtr frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_clock_get_frame_counter(System.IntPtr frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_clock_get_frame_time(System.IntPtr frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_clock_get_history_start(System.IntPtr frame_clock);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_get_refresh_info(System.IntPtr frame_clock, long base_time, System.IntPtr refresh_interval_return, System.IntPtr presentation_time_return);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_frame_clock_get_timings(System.IntPtr frame_clock, long frame_counter);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_clock_request_phase(System.IntPtr frame_clock, Gdk.FrameClockPhase phase);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_frame_timings_get_complete(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_frame_counter(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_frame_time(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_predicted_presentation_time(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_presentation_time(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern long gdk_frame_timings_get_refresh_interval(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_frame_timings_ref(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_frame_timings_unref(System.IntPtr timings);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_clear_current();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_gl_context_get_current();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_gl_context_get_debug_enabled(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_gl_context_get_display(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_gl_context_get_forward_compatible(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_get_required_version(System.IntPtr context, System.IntPtr major, System.IntPtr minor);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_gl_context_get_shared_context(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_gl_context_get_use_es(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_get_version(System.IntPtr context, System.IntPtr major, System.IntPtr minor);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_gl_context_get_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_gl_context_is_legacy(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_make_current(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_gl_context_realize(System.IntPtr context, System.IntPtr error);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_debug_enabled(System.IntPtr context, int enabled);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_forward_compatible(System.IntPtr context, int compatible);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_required_version(System.IntPtr context, int major, int minor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_gl_context_set_use_es(System.IntPtr context, int use_es);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_gl_error_quark();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_keymap_get_default();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_keymap_get_for_display(System.IntPtr display);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_keymap_add_virtual_modifiers(System.IntPtr keymap, ref Gdk.ModifierType state);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_caps_lock_state(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern Pango.Direction gdk_keymap_get_direction(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_entries_for_keycode(System.IntPtr keymap, uint hardware_keycode, System.IntPtr keys, System.IntPtr keyvals, System.IntPtr n_entries);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_entries_for_keyval(System.IntPtr keymap, uint keyval, System.IntPtr keys, System.IntPtr n_keys);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.ModifierType gdk_keymap_get_modifier_mask(System.IntPtr keymap, Gdk.ModifierIntent intent);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keymap_get_modifier_state(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_num_lock_state(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_scroll_lock_state(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_have_bidi_layouts(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_keymap_lookup_key(System.IntPtr keymap, System.IntPtr key);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_map_virtual_modifiers(System.IntPtr keymap, ref Gdk.ModifierType state);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_translate_keyboard_state(System.IntPtr keymap, uint hardware_keycode, Gdk.ModifierType state, int group, System.IntPtr keyval, System.IntPtr effective_group, System.IntPtr level, out Gdk.ModifierType consumed_modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_rgba_copy(System.IntPtr rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_rgba_equal(System.IntPtr p1, System.IntPtr p2);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_rgba_free(System.IntPtr rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern uint gdk_rgba_hash(System.IntPtr p);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_rgba_parse(System.IntPtr rgba, string spec);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_rgba_to_string(System.IntPtr rgba);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_best();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_best_depth();
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.VisualType gdk_visual_get_best_type();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_best_with_both(int depth, Gdk.VisualType visual_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_best_with_depth(int depth);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_best_with_type(Gdk.VisualType visual_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_system();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_bits_per_rgb(System.IntPtr visual);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_visual_get_blue_pixel_details(System.IntPtr visual, System.IntPtr mask, System.IntPtr shift, System.IntPtr precision);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.ByteOrder gdk_visual_get_byte_order(System.IntPtr visual);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_colormap_size(System.IntPtr visual);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_depth(System.IntPtr visual);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_visual_get_green_pixel_details(System.IntPtr visual, System.IntPtr mask, System.IntPtr shift, System.IntPtr precision);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_visual_get_red_pixel_details(System.IntPtr visual, System.IntPtr mask, System.IntPtr shift, System.IntPtr precision);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_screen(System.IntPtr visual);
		[DllImport("libgdk-3.so.0")]
		public static extern Gdk.VisualType gdk_visual_get_visual_type(System.IntPtr visual);
	}
}
