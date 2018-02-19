using System;
using System.Runtime.InteropServices;
namespace Gdk {
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
		public static extern void gdk_drag_find_window_for_screen(System.IntPtr context, System.IntPtr drag_window, System.IntPtr screen, int x_root, int y_root, System.IntPtr dest_window, System.IntPtr protocol);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_get_selection(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_motion(System.IntPtr context, System.IntPtr dest_window, int protocol, int x_root, int y_root, int suggested_action, int possible_actions, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_drag_status(System.IntPtr context, int action, uint time_);
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
		public static extern int gdk_keyboard_grab(System.IntPtr window, int owner_events, uint time_);
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
		public static extern int gdk_pointer_grab(System.IntPtr window, int owner_events, int event_mask, System.IntPtr confine_to, System.IntPtr cursor, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_pointer_is_grabbed();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_pointer_ungrab(uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_pre_parse_libgtk_only();
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_property_change(System.IntPtr window, System.IntPtr property, System.IntPtr type, int format, int mode, System.IntPtr data, int nelements);
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
		public static extern void gdk_synthesize_window_state(System.IntPtr window, int unset_flags, int set_flags);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_test_render_sync(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_test_simulate_button(System.IntPtr window, int x, int y, uint button, int modifiers, int button_pressrelease);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_test_simulate_key(System.IntPtr window, int x, int y, uint keyval, int modifiers, int key_pressrelease);
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
		public static extern void gdk_display_get_pointer(System.IntPtr display, System.IntPtr screen, System.IntPtr x, System.IntPtr y, System.IntPtr mask);
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
		public static extern System.IntPtr gdk_cursor_new(int cursor_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_for_display(System.IntPtr display, int cursor_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_from_name(System.IntPtr display, string name);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_from_pixbuf(System.IntPtr display, System.IntPtr pixbuf, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_cursor_new_from_surface(System.IntPtr display, System.IntPtr surface, double x, double y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_cursor_get_cursor_type(System.IntPtr cursor);
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
		public static extern int gdk_device_get_axes(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_axis(System.IntPtr device, System.IntPtr axes, int use, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_axis_use(System.IntPtr device, uint index_);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_axis_value(System.IntPtr device, System.IntPtr axes, System.IntPtr axis_label, System.IntPtr value);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_device_type(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_display(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_has_cursor(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_history(System.IntPtr device, System.IntPtr window, uint start, uint stop, System.IntPtr events, System.IntPtr n_events);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_key(System.IntPtr device, uint index_, System.IntPtr keyval, System.IntPtr modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_last_event_window(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_get_mode(System.IntPtr device);
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
		public static extern int gdk_device_get_source(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_get_state(System.IntPtr device, System.IntPtr window, System.IntPtr axes, System.IntPtr mask);
		[DllImport("libgdk-3.so.0")]
		public static extern string gdk_device_get_vendor_id(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_window_at_position(System.IntPtr device, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_get_window_at_position_double(System.IntPtr device, System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_grab(System.IntPtr device, System.IntPtr window, int grab_ownership, int owner_events, int event_mask, System.IntPtr cursor, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_list_axes(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_list_slave_devices(System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_set_axis_use(System.IntPtr device, uint index_, int use);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_set_key(System.IntPtr device, uint index_, uint keyval, int modifiers);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_set_mode(System.IntPtr device, int mode);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_ungrab(System.IntPtr device, uint time_);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_device_warp(System.IntPtr device, System.IntPtr screen, int x, int y);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_new(System.IntPtr parent, System.IntPtr attributes, int attributes_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_at_pointer(System.IntPtr win_x, System.IntPtr win_y);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_constrain_size(System.IntPtr geometry, int flags, int width, int height, System.IntPtr new_width, System.IntPtr new_height);
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
		public static extern void gdk_window_begin_resize_drag(System.IntPtr window, int edge, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_begin_resize_drag_for_device(System.IntPtr window, int edge, System.IntPtr device, int button, int root_x, int root_y, uint timestamp);
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
		public static extern System.IntPtr gdk_window_create_similar_surface(System.IntPtr window, int content, int width, int height);
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
		public static extern int gdk_window_get_decorations(System.IntPtr window, System.IntPtr decorations);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_device_cursor(System.IntPtr window, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_device_events(System.IntPtr window, System.IntPtr device);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_device_position(System.IntPtr window, System.IntPtr device, System.IntPtr x, System.IntPtr y, System.IntPtr mask);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_device_position_double(System.IntPtr window, System.IntPtr device, System.IntPtr x, System.IntPtr y, System.IntPtr mask);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_display(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_drag_protocol(System.IntPtr window, System.IntPtr target);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_effective_parent(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_effective_toplevel(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_event_compression(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_events(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_focus_on_map(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_frame_clock(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_get_frame_extents(System.IntPtr window, System.IntPtr rect);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_fullscreen_mode(System.IntPtr window);
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
		public static extern System.IntPtr gdk_window_get_pointer(System.IntPtr window, System.IntPtr x, System.IntPtr y, System.IntPtr mask);
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
		public static extern int gdk_window_get_source_events(System.IntPtr window, int source);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_state(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_support_multidevice(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_window_get_toplevel(System.IntPtr window);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_window_get_type_hint(System.IntPtr window);
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
		public static extern int gdk_window_get_window_type(System.IntPtr window);
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
		public static extern void gdk_window_set_decorations(System.IntPtr window, int decorations);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_device_cursor(System.IntPtr window, System.IntPtr device, System.IntPtr cursor);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_device_events(System.IntPtr window, System.IntPtr device, int event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_event_compression(System.IntPtr window, int event_compression);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_events(System.IntPtr window, int event_mask);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_focus_on_map(System.IntPtr window, int focus_on_map);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_fullscreen_mode(System.IntPtr window, int mode);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_functions(System.IntPtr window, int functions);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_window_set_geometry_hints(System.IntPtr window, System.IntPtr geometry, int geom_mask);
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
		public static extern void gdk_window_set_source_events(System.IntPtr window, int source, int event_mask);
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
		public static extern void gdk_window_set_type_hint(System.IntPtr window, int hint);
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
		public static extern int gdk_seat_get_capabilities(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_display(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_keyboard(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_pointer(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_seat_get_slaves(System.IntPtr seat, int capabilities);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_seat_grab(System.IntPtr seat, System.IntPtr window, int capabilities, int owner_events, System.IntPtr cursor, System.IntPtr @event, System.IntPtr prepare_func, System.IntPtr prepare_func_data);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_seat_ungrab(System.IntPtr seat);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_manager_get_client_pointer(System.IntPtr device_manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_manager_get_display(System.IntPtr device_manager);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_device_manager_list_devices(System.IntPtr device_manager, int type);
		[DllImport("libgdk-3.so.0")]
		public static extern ulong gdk_device_tool_get_hardware_id(System.IntPtr tool);
		[DllImport("libgdk-3.so.0")]
		public static extern ulong gdk_device_tool_get_serial(System.IntPtr tool);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_tool_get_tool_type(System.IntPtr tool);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_feature_group(System.IntPtr pad, int feature, int feature_idx);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_group_n_modes(System.IntPtr pad, int group_idx);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_n_features(System.IntPtr pad, int feature);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_device_pad_get_n_groups(System.IntPtr pad);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_new(int type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_copy(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_event_free(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_axis(System.IntPtr @event, int axis_use, System.IntPtr value);
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
		public static extern int gdk_event_get_event_type(System.IntPtr @event);
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
		public static extern int gdk_event_get_scroll_direction(System.IntPtr @event, System.IntPtr direction);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_seat(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_event_get_source_device(System.IntPtr @event);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_event_get_state(System.IntPtr @event, System.IntPtr state);
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
		public static extern int gdk_monitor_get_subpixel_layout(System.IntPtr monitor);
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
		public static extern int gdk_drag_context_get_actions(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_dest_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_device(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_drag_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_context_get_protocol(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_context_get_selected_action(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_get_source_window(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_context_get_suggested_action(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_drag_context_list_targets(System.IntPtr context);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_drag_context_manage_dnd(System.IntPtr context, System.IntPtr ipc_window, int actions);
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
		public static extern void gdk_frame_clock_request_phase(System.IntPtr frame_clock, int phase);
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
		public static extern void gdk_keymap_add_virtual_modifiers(System.IntPtr keymap, System.IntPtr state);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_caps_lock_state(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_direction(System.IntPtr keymap);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_entries_for_keycode(System.IntPtr keymap, uint hardware_keycode, System.IntPtr keys, System.IntPtr keyvals, System.IntPtr n_entries);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_entries_for_keyval(System.IntPtr keymap, uint keyval, System.IntPtr keys, System.IntPtr n_keys);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_get_modifier_mask(System.IntPtr keymap, int intent);
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
		public static extern int gdk_keymap_map_virtual_modifiers(System.IntPtr keymap, System.IntPtr state);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_keymap_translate_keyboard_state(System.IntPtr keymap, uint hardware_keycode, int state, int group, System.IntPtr keyval, System.IntPtr effective_group, System.IntPtr level, System.IntPtr consumed_modifiers);
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
		public static extern int gdk_visual_get_best_type();
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_best_with_both(int depth, int visual_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_best_with_depth(int depth);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_best_with_type(int visual_type);
		[DllImport("libgdk-3.so.0")]
		public static extern System.IntPtr gdk_visual_get_system();
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_bits_per_rgb(System.IntPtr visual);
		[DllImport("libgdk-3.so.0")]
		public static extern void gdk_visual_get_blue_pixel_details(System.IntPtr visual, System.IntPtr mask, System.IntPtr shift, System.IntPtr precision);
		[DllImport("libgdk-3.so.0")]
		public static extern int gdk_visual_get_byte_order(System.IntPtr visual);
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
		public static extern int gdk_visual_get_visual_type(System.IntPtr visual);
	}
}
