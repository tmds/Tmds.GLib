using System;
using System.Runtime.InteropServices;

namespace Gtk
{
    public static class GtkInterop
    {
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_groups_activate(System.IntPtr @object, uint accel_key, int accel_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_groups_from_object(System.IntPtr @object);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accelerator_get_default_mod_mask();
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_accelerator_get_label(uint accelerator_key, int accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_accelerator_get_label_with_keycode(System.IntPtr display, uint accelerator_key, uint keycode, int accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_accelerator_name(uint accelerator_key, int accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_accelerator_name_with_keycode(System.IntPtr display, uint accelerator_key, uint keycode, int accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accelerator_parse(string accelerator, System.IntPtr accelerator_key, System.IntPtr accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accelerator_parse_with_keycode(string accelerator, System.IntPtr accelerator_key, System.IntPtr accelerator_codes, System.IntPtr accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accelerator_set_default_mod_mask(int default_mod_mask);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accelerator_valid(uint keyval, int modifiers);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_alternative_dialog_button_order(System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_bindings_activate(System.IntPtr @object, uint keyval, int modifiers);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_bindings_activate_event(System.IntPtr @object, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cairo_should_draw_window(System.IntPtr cr, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cairo_transform_to_window(System.IntPtr cr, System.IntPtr widget, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_check_version(uint required_major, uint required_minor, uint required_micro);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_device_grab_add(System.IntPtr widget, System.IntPtr device, int block_others);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_device_grab_remove(System.IntPtr widget, System.IntPtr device);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_disable_setlocale();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_distribute_natural_allocation(int extra_space, uint n_requested_sizes, System.IntPtr sizes);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_cancel(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_finish(System.IntPtr context, int success, int del, uint time_);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_drag_get_source_widget(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_set_icon_default(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_set_icon_gicon(System.IntPtr context, System.IntPtr icon, int hot_x, int hot_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_set_icon_name(System.IntPtr context, string icon_name, int hot_x, int hot_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_set_icon_pixbuf(System.IntPtr context, System.IntPtr pixbuf, int hot_x, int hot_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_set_icon_stock(System.IntPtr context, string stock_id, int hot_x, int hot_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_set_icon_surface(System.IntPtr context, System.IntPtr surface);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_set_icon_widget(System.IntPtr context, System.IntPtr widget, int hot_x, int hot_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_draw_insertion_cursor(System.IntPtr widget, System.IntPtr cr, System.IntPtr location, int is_primary, int direction, int draw_arrow);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_events_pending();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_false();
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_get_binary_age();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_get_current_event();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_get_current_event_device();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_get_current_event_state(System.IntPtr state);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_get_current_event_time();
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_get_debug_flags();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_get_default_language();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_get_event_widget(System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_get_interface_age();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_get_locale_direction();
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_get_major_version();
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_get_micro_version();
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_get_minor_version();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_get_option_group(int open_default_display);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_grab_get_current();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_init(System.IntPtr argc, System.IntPtr argv);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_init_check(System.IntPtr argc, System.IntPtr argv);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_init_with_args(System.IntPtr argc, System.IntPtr argv, string parameter_string, System.IntPtr entries, string translation_domain, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_key_snooper_install(System.IntPtr snooper, System.IntPtr func_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_key_snooper_remove(uint snooper_handler_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_main();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_main_do_event(System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_main_iteration();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_main_iteration_do(int blocking);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_main_level();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_main_quit();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_arrow(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int arrow_type, int fill, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_box(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_box_gap(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height, int gap_side, int gap_x, int gap_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_check(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_diamond(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_expander(System.IntPtr style, System.IntPtr cr, int state_type, System.IntPtr widget, string detail, int x, int y, int expander_style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_extension(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height, int gap_side);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_flat_box(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_focus(System.IntPtr style, System.IntPtr cr, int state_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_handle(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_hline(System.IntPtr style, System.IntPtr cr, int state_type, System.IntPtr widget, string detail, int x1, int x2, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_layout(System.IntPtr style, System.IntPtr cr, int state_type, int use_text, System.IntPtr widget, string detail, int x, int y, System.IntPtr layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_option(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_resize_grip(System.IntPtr style, System.IntPtr cr, int state_type, System.IntPtr widget, string detail, int edge, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_shadow(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_shadow_gap(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height, int gap_side, int gap_x, int gap_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_slider(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_spinner(System.IntPtr style, System.IntPtr cr, int state_type, System.IntPtr widget, string detail, uint step, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_tab(System.IntPtr style, System.IntPtr cr, int state_type, int shadow_type, System.IntPtr widget, string detail, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paint_vline(System.IntPtr style, System.IntPtr cr, int state_type, System.IntPtr widget, string detail, int y1_, int y2_, int x);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_parse_args(System.IntPtr argc, System.IntPtr argv);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_run_page_setup_dialog(System.IntPtr parent, System.IntPtr page_setup, System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_run_page_setup_dialog_async(System.IntPtr parent, System.IntPtr page_setup, System.IntPtr settings, System.IntPtr done_cb, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_propagate_event(System.IntPtr widget, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_rc_add_default_file(System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_find_module_in_path(string module_file);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_find_pixmap_in_path(System.IntPtr settings, System.IntPtr scanner, string pixmap_file);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_get_default_files();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_get_im_module_file();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_get_im_module_path();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_get_module_dir();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_get_style(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_get_style_by_paths(System.IntPtr settings, string widget_path, string class_path, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_rc_get_theme_dir();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_rc_parse(string filename);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_rc_parse_color(System.IntPtr scanner, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_rc_parse_color_full(System.IntPtr scanner, System.IntPtr style, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_rc_parse_priority(System.IntPtr scanner, System.IntPtr priority);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_rc_parse_state(System.IntPtr scanner, System.IntPtr state);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_rc_parse_string(string rc_string);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_rc_reparse_all();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_rc_reparse_all_for_settings(System.IntPtr settings, int force_load);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_rc_reset_styles(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_scanner_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_rc_set_default_files(System.IntPtr filenames);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_activity(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_arrow(System.IntPtr context, System.IntPtr cr, double angle, double x, double y, double size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_background(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_background_get_clip(System.IntPtr context, double x, double y, double width, double height, System.IntPtr out_clip);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_check(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_expander(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_extension(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height, int gap_side);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_focus(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_frame(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_frame_gap(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height, int gap_side, double xy0_gap, double xy1_gap);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_handle(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_icon(System.IntPtr context, System.IntPtr cr, System.IntPtr pixbuf, double x, double y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_render_icon_pixbuf(System.IntPtr context, System.IntPtr source, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_icon_surface(System.IntPtr context, System.IntPtr cr, System.IntPtr surface, double x, double y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_insertion_cursor(System.IntPtr context, System.IntPtr cr, double x, double y, System.IntPtr layout, int index, int direction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_layout(System.IntPtr context, System.IntPtr cr, double x, double y, System.IntPtr layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_line(System.IntPtr context, System.IntPtr cr, double x0, double y0, double x1, double y1);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_option(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_render_slider(System.IntPtr context, System.IntPtr cr, double x, double y, double width, double height, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_rgb_to_hsv(double r, double g, double b, System.IntPtr h, System.IntPtr s, System.IntPtr v);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_selection_add_target(System.IntPtr widget, System.IntPtr selection, System.IntPtr target, uint info);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_selection_add_targets(System.IntPtr widget, System.IntPtr selection, System.IntPtr targets, uint ntargets);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_selection_clear_targets(System.IntPtr widget, System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_convert(System.IntPtr widget, System.IntPtr selection, System.IntPtr target, uint time_);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_owner_set(System.IntPtr widget, System.IntPtr selection, uint time_);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_owner_set_for_display(System.IntPtr display, System.IntPtr widget, System.IntPtr selection, uint time_);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_selection_remove_all(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_set_debug_flags(uint flags);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_show_uri(System.IntPtr screen, string uri, uint timestamp, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_show_uri_on_window(System.IntPtr parent, string uri, uint timestamp, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stock_add(System.IntPtr items, uint n_items);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stock_add_static(System.IntPtr items, uint n_items);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stock_list_ids();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_stock_lookup(string stock_id, System.IntPtr item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stock_set_translate_func(string domain, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_table_free(System.IntPtr targets, int n_targets);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_target_table_new_from_list(System.IntPtr list, System.IntPtr n_targets);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_targets_include_image(System.IntPtr targets, int n_targets, int writable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_targets_include_rich_text(System.IntPtr targets, int n_targets, System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_targets_include_text(System.IntPtr targets, int n_targets);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_targets_include_uri(System.IntPtr targets, int n_targets);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_test_create_simple_window(string window_title, string dialog_text);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_test_find_label(System.IntPtr widget, string label_pattern);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_test_find_sibling(System.IntPtr base_widget, ulong widget_type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_test_find_widget(System.IntPtr widget, string label_pattern, ulong widget_type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_test_list_all_types(System.IntPtr n_types);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_test_register_all_types();
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_test_slider_get_value(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_test_slider_set_perc(System.IntPtr widget, double percentage);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_test_spin_button_click(System.IntPtr spinner, uint button, int upwards);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_test_text_get(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_test_text_set(System.IntPtr widget, string @string);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_test_widget_click(System.IntPtr widget, uint button, int modifiers);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_test_widget_send_key(System.IntPtr widget, uint keyval, int modifiers);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_test_widget_wait_for_draw(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_get_row_drag_data(System.IntPtr selection_data, System.IntPtr tree_model, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_set_row_drag_data(System.IntPtr selection_data, System.IntPtr tree_model, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_true();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_buildable_add_child(System.IntPtr buildable, System.IntPtr builder, System.IntPtr child, string type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_buildable_construct_child(System.IntPtr buildable, System.IntPtr builder, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_buildable_custom_finished(System.IntPtr buildable, System.IntPtr builder, System.IntPtr child, string tagname, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_buildable_custom_tag_end(System.IntPtr buildable, System.IntPtr builder, System.IntPtr child, string tagname, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_buildable_custom_tag_start(System.IntPtr buildable, System.IntPtr builder, System.IntPtr child, string tagname, System.IntPtr parser, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_buildable_get_internal_child(System.IntPtr buildable, System.IntPtr builder, string childname);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_buildable_get_name(System.IntPtr buildable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_buildable_parser_finished(System.IntPtr buildable, System.IntPtr builder);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_buildable_set_buildable_property(System.IntPtr buildable, System.IntPtr builder, string name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_buildable_set_name(System.IntPtr buildable, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_default_direction();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_default_style();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_pop_composite_child();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_push_composite_child();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_default_direction(int dir);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_activate(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_add_accelerator(System.IntPtr widget, string accel_signal, System.IntPtr accel_group, uint accel_key, int accel_mods, int accel_flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_add_device_events(System.IntPtr widget, System.IntPtr device, int events);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_add_events(System.IntPtr widget, int events);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_add_mnemonic_label(System.IntPtr widget, System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_widget_add_tick_callback(System.IntPtr widget, System.IntPtr callback, System.IntPtr user_data, System.IntPtr notify);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_can_activate_accel(System.IntPtr widget, uint signal_id);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_child_focus(System.IntPtr widget, int direction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_child_notify(System.IntPtr widget, string child_property);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_path(System.IntPtr widget, System.IntPtr path_length, string path, string path_reversed);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_compute_expand(System.IntPtr widget, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_create_pango_context(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_create_pango_layout(System.IntPtr widget, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_destroy(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_destroyed(System.IntPtr widget, System.IntPtr widget_pointer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_device_is_shadowed(System.IntPtr widget, System.IntPtr device);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_drag_begin(System.IntPtr widget, System.IntPtr targets, int actions, int button, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_drag_begin_with_coordinates(System.IntPtr widget, System.IntPtr targets, int actions, int button, System.IntPtr @event, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_drag_check_threshold(System.IntPtr widget, int start_x, int start_y, int current_x, int current_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_add_image_targets(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_add_text_targets(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_add_uri_targets(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_drag_dest_find_target(System.IntPtr widget, System.IntPtr context, System.IntPtr target_list);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_drag_dest_get_target_list(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_drag_dest_get_track_motion(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_set(System.IntPtr widget, int flags, System.IntPtr targets, int n_targets, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_set_proxy(System.IntPtr widget, System.IntPtr proxy_window, int protocol, int use_coordinates);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_set_target_list(System.IntPtr widget, System.IntPtr target_list);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_set_track_motion(System.IntPtr widget, int track_motion);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_dest_unset(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_get_data(System.IntPtr widget, System.IntPtr context, System.IntPtr target, uint time_);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_highlight(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_add_image_targets(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_add_text_targets(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_add_uri_targets(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_drag_source_get_target_list(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_set(System.IntPtr widget, int start_button_mask, System.IntPtr targets, int n_targets, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_set_icon_gicon(System.IntPtr widget, System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_set_icon_name(System.IntPtr widget, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_set_icon_pixbuf(System.IntPtr widget, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_set_icon_stock(System.IntPtr widget, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_set_target_list(System.IntPtr widget, System.IntPtr target_list);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_source_unset(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_drag_unhighlight(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_draw(System.IntPtr widget, System.IntPtr cr);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_ensure_style(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_error_bell(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_event(System.IntPtr widget, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_freeze_child_notify(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_accessible(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_action_group(System.IntPtr widget, string prefix);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_allocated_baseline(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_allocated_height(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_allocated_size(System.IntPtr widget, System.IntPtr allocation, System.IntPtr baseline);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_allocated_width(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_allocation(System.IntPtr widget, System.IntPtr allocation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_ancestor(System.IntPtr widget, ulong widget_type);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_app_paintable(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_can_default(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_can_focus(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_child_requisition(System.IntPtr widget, System.IntPtr requisition);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_child_visible(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_clip(System.IntPtr widget, System.IntPtr clip);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_clipboard(System.IntPtr widget, System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_get_composite_name(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_device_enabled(System.IntPtr widget, System.IntPtr device);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_device_events(System.IntPtr widget, System.IntPtr device);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_direction(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_display(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_double_buffered(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_events(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_focus_on_click(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_font_map(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_font_options(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_frame_clock(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_halign(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_has_tooltip(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_has_window(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_hexpand(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_hexpand_set(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_mapped(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_margin_bottom(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_margin_end(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_margin_left(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_margin_right(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_margin_start(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_margin_top(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_modifier_mask(System.IntPtr widget, int intent);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_modifier_style(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_get_name(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_no_show_all(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_widget_get_opacity(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_pango_context(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_parent(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_parent_window(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_path(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_pointer(System.IntPtr widget, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_preferred_height(System.IntPtr widget, System.IntPtr minimum_height, System.IntPtr natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_preferred_height_and_baseline_for_width(System.IntPtr widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height, System.IntPtr minimum_baseline, System.IntPtr natural_baseline);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_preferred_height_for_width(System.IntPtr widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_preferred_size(System.IntPtr widget, System.IntPtr minimum_size, System.IntPtr natural_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_preferred_width(System.IntPtr widget, System.IntPtr minimum_width, System.IntPtr natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_preferred_width_for_height(System.IntPtr widget, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_realized(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_receives_default(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_request_mode(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_requisition(System.IntPtr widget, System.IntPtr requisition);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_root_window(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_scale_factor(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_screen(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_sensitive(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_settings(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_get_size_request(System.IntPtr widget, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_state(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_state_flags(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_style(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_style_context(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_support_multidevice(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_template_child(System.IntPtr widget, ulong widget_type, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_get_tooltip_markup(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_get_tooltip_text(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_tooltip_window(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_toplevel(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_valign(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_valign_with_baseline(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_vexpand(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_vexpand_set(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_get_visible(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_visual(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_get_window(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grab_add(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_grab_default(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_grab_focus(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grab_remove(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_has_default(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_has_focus(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_has_grab(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_has_rc_style(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_has_screen(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_has_visible_focus(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_hide(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_hide_on_delete(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_in_destruction(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_init_template(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_input_shape_combine_region(System.IntPtr widget, System.IntPtr region);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_insert_action_group(System.IntPtr widget, string name, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_intersect(System.IntPtr widget, System.IntPtr area, System.IntPtr intersection);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_is_ancestor(System.IntPtr widget, System.IntPtr ancestor);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_is_composited(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_is_drawable(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_is_focus(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_is_sensitive(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_is_toplevel(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_is_visible(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_keynav_failed(System.IntPtr widget, int direction);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_list_accel_closures(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_list_action_prefixes(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_list_mnemonic_labels(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_map(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_mnemonic_activate(System.IntPtr widget, int group_cycling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_modify_base(System.IntPtr widget, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_modify_bg(System.IntPtr widget, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_modify_cursor(System.IntPtr widget, System.IntPtr primary, System.IntPtr secondary);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_modify_fg(System.IntPtr widget, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_modify_font(System.IntPtr widget, System.IntPtr font_desc);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_modify_style(System.IntPtr widget, System.IntPtr style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_modify_text(System.IntPtr widget, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_override_background_color(System.IntPtr widget, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_override_color(System.IntPtr widget, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_override_cursor(System.IntPtr widget, System.IntPtr cursor, System.IntPtr secondary_cursor);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_override_font(System.IntPtr widget, System.IntPtr font_desc);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_override_symbolic_color(System.IntPtr widget, string name, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path(System.IntPtr widget, System.IntPtr path_length, string path, string path_reversed);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_queue_allocate(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_queue_compute_expand(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_queue_draw(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_queue_draw_area(System.IntPtr widget, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_queue_draw_region(System.IntPtr widget, System.IntPtr region);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_queue_resize(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_queue_resize_no_redraw(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_realize(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_region_intersect(System.IntPtr widget, System.IntPtr region);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_register_window(System.IntPtr widget, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_remove_accelerator(System.IntPtr widget, System.IntPtr accel_group, uint accel_key, int accel_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_remove_mnemonic_label(System.IntPtr widget, System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_remove_tick_callback(System.IntPtr widget, uint id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_render_icon(System.IntPtr widget, string stock_id, int size, string detail);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_render_icon_pixbuf(System.IntPtr widget, string stock_id, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_reparent(System.IntPtr widget, System.IntPtr new_parent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_reset_rc_styles(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_reset_style(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_send_expose(System.IntPtr widget, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_send_focus_change(System.IntPtr widget, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_accel_path(System.IntPtr widget, string accel_path, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_allocation(System.IntPtr widget, System.IntPtr allocation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_app_paintable(System.IntPtr widget, int app_paintable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_can_default(System.IntPtr widget, int can_default);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_can_focus(System.IntPtr widget, int can_focus);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_child_visible(System.IntPtr widget, int is_visible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_clip(System.IntPtr widget, System.IntPtr clip);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_composite_name(System.IntPtr widget, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_device_enabled(System.IntPtr widget, System.IntPtr device, int enabled);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_device_events(System.IntPtr widget, System.IntPtr device, int events);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_direction(System.IntPtr widget, int dir);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_double_buffered(System.IntPtr widget, int double_buffered);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_events(System.IntPtr widget, int events);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_focus_on_click(System.IntPtr widget, int focus_on_click);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_font_map(System.IntPtr widget, System.IntPtr font_map);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_font_options(System.IntPtr widget, System.IntPtr options);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_halign(System.IntPtr widget, int align);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_has_tooltip(System.IntPtr widget, int has_tooltip);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_has_window(System.IntPtr widget, int has_window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_hexpand(System.IntPtr widget, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_hexpand_set(System.IntPtr widget, int set);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_mapped(System.IntPtr widget, int mapped);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_margin_bottom(System.IntPtr widget, int margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_margin_end(System.IntPtr widget, int margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_margin_left(System.IntPtr widget, int margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_margin_right(System.IntPtr widget, int margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_margin_start(System.IntPtr widget, int margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_margin_top(System.IntPtr widget, int margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_name(System.IntPtr widget, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_no_show_all(System.IntPtr widget, int no_show_all);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_opacity(System.IntPtr widget, double opacity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_parent(System.IntPtr widget, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_parent_window(System.IntPtr widget, System.IntPtr parent_window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_realized(System.IntPtr widget, int realized);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_receives_default(System.IntPtr widget, int receives_default);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_redraw_on_allocate(System.IntPtr widget, int redraw_on_allocate);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_sensitive(System.IntPtr widget, int sensitive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_size_request(System.IntPtr widget, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_state(System.IntPtr widget, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_state_flags(System.IntPtr widget, int flags, int clear);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_style(System.IntPtr widget, System.IntPtr style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_support_multidevice(System.IntPtr widget, int support_multidevice);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_tooltip_markup(System.IntPtr widget, string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_tooltip_text(System.IntPtr widget, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_tooltip_window(System.IntPtr widget, System.IntPtr custom_window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_valign(System.IntPtr widget, int align);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_vexpand(System.IntPtr widget, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_vexpand_set(System.IntPtr widget, int set);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_visible(System.IntPtr widget, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_visual(System.IntPtr widget, System.IntPtr visual);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_set_window(System.IntPtr widget, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_shape_combine_region(System.IntPtr widget, System.IntPtr region);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_show(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_show_all(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_show_now(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_size_allocate(System.IntPtr widget, System.IntPtr allocation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_size_allocate_with_baseline(System.IntPtr widget, System.IntPtr allocation, int baseline);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_size_request(System.IntPtr widget, System.IntPtr requisition);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_style_attach(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_style_get_property(System.IntPtr widget, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_thaw_child_notify(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_translate_coordinates(System.IntPtr src_widget, System.IntPtr dest_widget, int src_x, int src_y, System.IntPtr dest_x, System.IntPtr dest_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_trigger_tooltip_query(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_unmap(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_unparent(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_unrealize(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_unregister_window(System.IntPtr widget, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_unset_state_flags(System.IntPtr widget, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_about_dialog_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_add_credit_section(System.IntPtr about, string section_name, System.IntPtr people);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_about_dialog_get_artists(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_about_dialog_get_authors(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_comments(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_copyright(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_about_dialog_get_documenters(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_license(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_about_dialog_get_license_type(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_about_dialog_get_logo(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_logo_icon_name(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_program_name(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_translator_credits(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_version(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_website(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_about_dialog_get_website_label(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_about_dialog_get_wrap_license(System.IntPtr about);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_artists(System.IntPtr about, System.IntPtr artists);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_authors(System.IntPtr about, System.IntPtr authors);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_comments(System.IntPtr about, string comments);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_copyright(System.IntPtr about, string copyright);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_documenters(System.IntPtr about, System.IntPtr documenters);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_license(System.IntPtr about, string license);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_license_type(System.IntPtr about, int license_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_logo(System.IntPtr about, System.IntPtr logo);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_logo_icon_name(System.IntPtr about, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_program_name(System.IntPtr about, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_translator_credits(System.IntPtr about, string translator_credits);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_version(System.IntPtr about, string version);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_website(System.IntPtr about, string website);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_website_label(System.IntPtr about, string website_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_about_dialog_set_wrap_license(System.IntPtr about, int wrap_license);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_dialog_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_dialog_add_action_widget(System.IntPtr dialog, System.IntPtr child, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_dialog_add_button(System.IntPtr dialog, string button_text, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_dialog_get_action_area(System.IntPtr dialog);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_dialog_get_content_area(System.IntPtr dialog);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_dialog_get_header_bar(System.IntPtr dialog);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_dialog_get_response_for_widget(System.IntPtr dialog, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_dialog_get_widget_for_response(System.IntPtr dialog, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_dialog_response(System.IntPtr dialog, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_dialog_run(System.IntPtr dialog);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_dialog_set_alternative_button_order_from_array(System.IntPtr dialog, int n_params, System.IntPtr new_order);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_dialog_set_default_response(System.IntPtr dialog, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_dialog_set_response_sensitive(System.IntPtr dialog, int response_id, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_group_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_group_from_accel_closure(System.IntPtr closure);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_group_activate(System.IntPtr accel_group, uint accel_quark, System.IntPtr acceleratable, uint accel_key, int accel_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_group_connect(System.IntPtr accel_group, uint accel_key, int accel_mods, int accel_flags, System.IntPtr closure);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_group_connect_by_path(System.IntPtr accel_group, string accel_path, System.IntPtr closure);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_group_disconnect(System.IntPtr accel_group, System.IntPtr closure);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_group_disconnect_key(System.IntPtr accel_group, uint accel_key, int accel_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_group_find(System.IntPtr accel_group, System.IntPtr find_func, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_group_get_is_locked(System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_group_get_modifier_mask(System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_group_lock(System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_group_query(System.IntPtr accel_group, uint accel_key, int accel_mods, System.IntPtr n_entries);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_group_unlock(System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_label_new(string @string);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_label_get_accel(System.IntPtr accel_label, System.IntPtr accelerator_key, System.IntPtr accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_label_get_accel_widget(System.IntPtr accel_label);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_accel_label_get_accel_width(System.IntPtr accel_label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_label_refetch(System.IntPtr accel_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_label_set_accel(System.IntPtr accel_label, uint accelerator_key, int accelerator_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_label_set_accel_closure(System.IntPtr accel_label, System.IntPtr accel_closure);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_label_set_accel_widget(System.IntPtr accel_label, System.IntPtr accel_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_label_new(string str);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_label_new_with_mnemonic(string str);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_label_get_angle(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_label_get_attributes(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_label_get_current_uri(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_ellipsize(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_justify(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_label_get_label(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_label_get_layout(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_get_layout_offsets(System.IntPtr label, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_line_wrap(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_line_wrap_mode(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_lines(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_max_width_chars(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_label_get_mnemonic_keyval(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_label_get_mnemonic_widget(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_selectable(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_selection_bounds(System.IntPtr label, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_single_line_mode(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_label_get_text(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_track_visited_links(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_use_markup(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_use_underline(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_label_get_width_chars(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern float gtk_label_get_xalign(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern float gtk_label_get_yalign(System.IntPtr label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_select_region(System.IntPtr label, int start_offset, int end_offset);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_angle(System.IntPtr label, double angle);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_attributes(System.IntPtr label, System.IntPtr attrs);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_ellipsize(System.IntPtr label, int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_justify(System.IntPtr label, int jtype);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_label(System.IntPtr label, string str);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_line_wrap(System.IntPtr label, int wrap);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_line_wrap_mode(System.IntPtr label, int wrap_mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_lines(System.IntPtr label, int lines);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_markup(System.IntPtr label, string str);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_markup_with_mnemonic(System.IntPtr label, string str);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_max_width_chars(System.IntPtr label, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_mnemonic_widget(System.IntPtr label, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_pattern(System.IntPtr label, string pattern);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_selectable(System.IntPtr label, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_single_line_mode(System.IntPtr label, int single_line_mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_text(System.IntPtr label, string str);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_text_with_mnemonic(System.IntPtr label, string str);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_track_visited_links(System.IntPtr label, int track_links);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_use_markup(System.IntPtr label, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_use_underline(System.IntPtr label, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_width_chars(System.IntPtr label, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_xalign(System.IntPtr label, float xalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_label_set_yalign(System.IntPtr label, float yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_add_entry(string accel_path, uint accel_key, int accel_mods);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_add_filter(string filter_pattern);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_map_change_entry(string accel_path, uint accel_key, int accel_mods, int replace);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_foreach(System.IntPtr data, System.IntPtr foreach_func);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_foreach_unfiltered(System.IntPtr data, System.IntPtr foreach_func);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accel_map_get();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_load(System.IntPtr file_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_load_fd(int fd);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_load_scanner(System.IntPtr scanner);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_lock_path(string accel_path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_accel_map_lookup_entry(string accel_path, System.IntPtr key);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_save(System.IntPtr file_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_save_fd(int fd);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accel_map_unlock_path(string accel_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accessible_connect_widget_destroyed(System.IntPtr accessible);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_accessible_get_widget(System.IntPtr accessible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_accessible_set_widget(System.IntPtr accessible, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_new(string name, string label, string tooltip, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_activate(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_block_activate(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_connect_accelerator(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_create_icon(System.IntPtr action, int icon_size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_create_menu(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_create_menu_item(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_create_tool_item(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_disconnect_accelerator(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_get_accel_closure(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_get_accel_path(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_get_always_show_image(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_get_gicon(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_get_icon_name(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_get_is_important(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_get_label(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_get_name(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_get_proxies(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_get_sensitive(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_get_short_label(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_get_stock_id(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_get_tooltip(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_get_visible(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_get_visible_horizontal(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_get_visible_vertical(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_is_sensitive(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_is_visible(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_accel_group(System.IntPtr action, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_accel_path(System.IntPtr action, string accel_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_always_show_image(System.IntPtr action, int always_show);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_gicon(System.IntPtr action, System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_icon_name(System.IntPtr action, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_is_important(System.IntPtr action, int is_important);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_label(System.IntPtr action, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_sensitive(System.IntPtr action, int sensitive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_short_label(System.IntPtr action, string short_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_stock_id(System.IntPtr action, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_tooltip(System.IntPtr action, string tooltip);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_visible(System.IntPtr action, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_visible_horizontal(System.IntPtr action, int visible_horizontal);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_set_visible_vertical(System.IntPtr action, int visible_vertical);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_unblock_activate(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_group_new(string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_action(System.IntPtr action_group, System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_action_with_accel(System.IntPtr action_group, System.IntPtr action, string accelerator);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_actions(System.IntPtr action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_actions_full(System.IntPtr action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_radio_actions(System.IntPtr action_group, System.IntPtr entries, uint n_entries, int value, System.IntPtr on_change, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_radio_actions_full(System.IntPtr action_group, System.IntPtr entries, uint n_entries, int value, System.IntPtr on_change, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_toggle_actions(System.IntPtr action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_add_toggle_actions_full(System.IntPtr action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_group_get_accel_group(System.IntPtr action_group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_group_get_action(System.IntPtr action_group, string action_name);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_group_get_name(System.IntPtr action_group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_group_get_sensitive(System.IntPtr action_group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_action_group_get_visible(System.IntPtr action_group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_group_list_actions(System.IntPtr action_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_remove_action(System.IntPtr action_group, System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_set_accel_group(System.IntPtr action_group, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_set_sensitive(System.IntPtr action_group, int sensitive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_set_translate_func(System.IntPtr action_group, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_set_translation_domain(System.IntPtr action_group, string domain);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_group_set_visible(System.IntPtr action_group, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_action_group_translate_string(System.IntPtr action_group, string @string);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_bar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_action_bar_get_center_widget(System.IntPtr action_bar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_bar_pack_end(System.IntPtr action_bar, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_bar_pack_start(System.IntPtr action_bar, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_action_bar_set_center_widget(System.IntPtr action_bar, System.IntPtr center_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_bin_get_child(System.IntPtr bin);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_actionable_get_action_name(System.IntPtr actionable);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_actionable_get_action_target_value(System.IntPtr actionable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_actionable_set_action_name(System.IntPtr actionable, string action_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_actionable_set_action_target_value(System.IntPtr actionable, System.IntPtr target_value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_actionable_set_detailed_action_name(System.IntPtr actionable, string detailed_action_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_activatable_do_set_related_action(System.IntPtr activatable, System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_activatable_get_related_action(System.IntPtr activatable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_activatable_get_use_action_appearance(System.IntPtr activatable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_activatable_set_related_action(System.IntPtr activatable, System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_activatable_set_use_action_appearance(System.IntPtr activatable, int use_appearance);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_activatable_sync_action_properties(System.IntPtr activatable, System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_changed(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_clamp_page(System.IntPtr adjustment, double lower, double upper);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_configure(System.IntPtr adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_adjustment_get_lower(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_adjustment_get_minimum_increment(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_adjustment_get_page_increment(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_adjustment_get_page_size(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_adjustment_get_step_increment(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_adjustment_get_upper(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_adjustment_get_value(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_set_lower(System.IntPtr adjustment, double lower);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_set_page_increment(System.IntPtr adjustment, double page_increment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_set_page_size(System.IntPtr adjustment, double page_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_set_step_increment(System.IntPtr adjustment, double step_increment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_set_upper(System.IntPtr adjustment, double upper);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_set_value(System.IntPtr adjustment, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_adjustment_value_changed(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_alignment_new(float xalign, float yalign, float xscale, float yscale);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_alignment_get_padding(System.IntPtr alignment, System.IntPtr padding_top, System.IntPtr padding_bottom, System.IntPtr padding_left, System.IntPtr padding_right);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_alignment_set(System.IntPtr alignment, float xalign, float yalign, float xscale, float yscale);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_alignment_set_padding(System.IntPtr alignment, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_app_chooser_get_app_info(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_app_chooser_get_content_type(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_refresh(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_editable_editing_done(System.IntPtr cell_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_editable_remove_widget(System.IntPtr cell_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_editable_start_editing(System.IntPtr cell_editable, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_layout_add_attribute(System.IntPtr cell_layout, System.IntPtr cell, string attribute, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_layout_clear(System.IntPtr cell_layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_layout_clear_attributes(System.IntPtr cell_layout, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_layout_get_area(System.IntPtr cell_layout);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_layout_get_cells(System.IntPtr cell_layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_layout_pack_end(System.IntPtr cell_layout, System.IntPtr cell, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_layout_pack_start(System.IntPtr cell_layout, System.IntPtr cell, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_layout_reorder(System.IntPtr cell_layout, System.IntPtr cell, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_layout_set_cell_data_func(System.IntPtr cell_layout, System.IntPtr cell, System.IntPtr func, System.IntPtr func_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_app_chooser_button_new(string content_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_button_append_custom_item(System.IntPtr self, string name, string label, System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_button_append_separator(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_app_chooser_button_get_heading(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_app_chooser_button_get_show_default_item(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_app_chooser_button_get_show_dialog_item(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_button_set_active_custom_item(System.IntPtr self, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_button_set_heading(System.IntPtr self, string heading);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_button_set_show_default_item(System.IntPtr self, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_button_set_show_dialog_item(System.IntPtr self, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_new_with_area(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_new_with_area_and_entry(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_new_with_entry();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_new_with_model(System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_new_with_model_and_entry(System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_active(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_combo_box_get_active_id(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_active_iter(System.IntPtr combo_box, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_add_tearoffs(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_button_sensitivity(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_column_span_column(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_entry_text_column(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_focus_on_click(System.IntPtr combo);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_has_entry(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_id_column(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_get_model(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_get_popup_accessible(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_popup_fixed_width(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_get_row_separator_func(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_row_span_column(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_combo_box_get_title(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_get_wrap_width(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_popdown(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_popup(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_popup_for_device(System.IntPtr combo_box, System.IntPtr device);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_active(System.IntPtr combo_box, int index_);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_combo_box_set_active_id(System.IntPtr combo_box, string active_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_active_iter(System.IntPtr combo_box, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_add_tearoffs(System.IntPtr combo_box, int add_tearoffs);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_button_sensitivity(System.IntPtr combo_box, int sensitivity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_column_span_column(System.IntPtr combo_box, int column_span);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_entry_text_column(System.IntPtr combo_box, int text_column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_focus_on_click(System.IntPtr combo, int focus_on_click);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_id_column(System.IntPtr combo_box, int id_column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_model(System.IntPtr combo_box, System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_popup_fixed_width(System.IntPtr combo_box, int @fixed);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_row_separator_func(System.IntPtr combo_box, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_row_span_column(System.IntPtr combo_box, int row_span);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_title(System.IntPtr combo_box, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_set_wrap_width(System.IntPtr combo_box, int width);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_new(int type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_default_icon_list();
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_window_get_default_icon_name();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_list_toplevels();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_auto_startup_notification(int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_default_icon(System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_set_default_icon_from_file(System.IntPtr filename, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_default_icon_list(System.IntPtr list);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_default_icon_name(string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_interactive_debugging(int enable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_activate_default(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_activate_focus(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_activate_key(System.IntPtr window, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_add_accel_group(System.IntPtr window, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_add_mnemonic(System.IntPtr window, uint keyval, System.IntPtr target);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_begin_move_drag(System.IntPtr window, int button, int root_x, int root_y, uint timestamp);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_begin_resize_drag(System.IntPtr window, int edge, int button, int root_x, int root_y, uint timestamp);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_close(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_deiconify(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_fullscreen(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_fullscreen_on_monitor(System.IntPtr window, System.IntPtr screen, int monitor);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_accept_focus(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_application(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_attached_to(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_decorated(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_get_default_size(System.IntPtr window, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_default_widget(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_deletable(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_destroy_with_parent(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_focus(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_focus_on_map(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_focus_visible(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_gravity(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_group(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_has_resize_grip(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_hide_titlebar_when_maximized(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_icon(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_icon_list(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_window_get_icon_name(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_mnemonic_modifier(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_mnemonics_visible(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_modal(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_window_get_opacity(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_get_position(System.IntPtr window, System.IntPtr root_x, System.IntPtr root_y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_resizable(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_resize_grip_area(System.IntPtr window, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_window_get_role(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_screen(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_get_size(System.IntPtr window, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_skip_pager_hint(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_skip_taskbar_hint(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_window_get_title(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_titlebar(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_get_transient_for(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_type_hint(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_urgency_hint(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_get_window_type(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_has_group(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_has_toplevel_focus(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_iconify(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_is_active(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_is_maximized(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_maximize(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_mnemonic_activate(System.IntPtr window, uint keyval, int modifier);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_move(System.IntPtr window, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_parse_geometry(System.IntPtr window, string geometry);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_present(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_present_with_time(System.IntPtr window, uint timestamp);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_propagate_key_event(System.IntPtr window, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_remove_accel_group(System.IntPtr window, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_remove_mnemonic(System.IntPtr window, uint keyval, System.IntPtr target);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_reshow_with_initial_size(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_resize(System.IntPtr window, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_resize_grip_is_visible(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_resize_to_geometry(System.IntPtr window, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_accept_focus(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_application(System.IntPtr window, System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_attached_to(System.IntPtr window, System.IntPtr attach_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_decorated(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_default(System.IntPtr window, System.IntPtr default_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_default_geometry(System.IntPtr window, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_default_size(System.IntPtr window, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_deletable(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_destroy_with_parent(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_focus(System.IntPtr window, System.IntPtr focus);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_focus_on_map(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_focus_visible(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_geometry_hints(System.IntPtr window, System.IntPtr geometry_widget, System.IntPtr geometry, int geom_mask);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_gravity(System.IntPtr window, int gravity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_has_resize_grip(System.IntPtr window, int value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_has_user_ref_count(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_hide_titlebar_when_maximized(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_icon(System.IntPtr window, System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_window_set_icon_from_file(System.IntPtr window, System.IntPtr filename, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_icon_list(System.IntPtr window, System.IntPtr list);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_icon_name(System.IntPtr window, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_keep_above(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_keep_below(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_mnemonic_modifier(System.IntPtr window, int modifier);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_mnemonics_visible(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_modal(System.IntPtr window, int modal);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_opacity(System.IntPtr window, double opacity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_position(System.IntPtr window, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_resizable(System.IntPtr window, int resizable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_role(System.IntPtr window, string role);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_screen(System.IntPtr window, System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_skip_pager_hint(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_skip_taskbar_hint(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_startup_id(System.IntPtr window, string startup_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_title(System.IntPtr window, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_titlebar(System.IntPtr window, System.IntPtr titlebar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_transient_for(System.IntPtr window, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_type_hint(System.IntPtr window, int hint);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_urgency_hint(System.IntPtr window, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_set_wmclass(System.IntPtr window, string wmclass_name, string wmclass_class);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_stick(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_unfullscreen(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_unmaximize(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_unstick(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_app_chooser_dialog_new(System.IntPtr parent, int flags, System.IntPtr file);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_app_chooser_dialog_new_for_content_type(System.IntPtr parent, int flags, string content_type);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_app_chooser_dialog_get_heading(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_app_chooser_dialog_get_widget(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_dialog_set_heading(System.IntPtr self, string heading);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_orientable_get_orientation(System.IntPtr orientable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_orientable_set_orientation(System.IntPtr orientable, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_app_chooser_widget_new(string content_type);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_app_chooser_widget_get_default_text(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_app_chooser_widget_get_show_all(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_app_chooser_widget_get_show_default(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_app_chooser_widget_get_show_fallback(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_app_chooser_widget_get_show_other(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_app_chooser_widget_get_show_recommended(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_widget_set_default_text(System.IntPtr self, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_widget_set_show_all(System.IntPtr self, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_widget_set_show_default(System.IntPtr self, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_widget_set_show_fallback(System.IntPtr self, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_widget_set_show_other(System.IntPtr self, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_app_chooser_widget_set_show_recommended(System.IntPtr self, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_box_new(int orientation, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_box_get_baseline_position(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_box_get_center_widget(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_box_get_homogeneous(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_box_get_spacing(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_pack_end(System.IntPtr box, System.IntPtr child, int expand, int fill, uint padding);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_pack_start(System.IntPtr box, System.IntPtr child, int expand, int fill, uint padding);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_query_child_packing(System.IntPtr box, System.IntPtr child, System.IntPtr expand, System.IntPtr fill, System.IntPtr padding, System.IntPtr pack_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_reorder_child(System.IntPtr box, System.IntPtr child, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_set_baseline_position(System.IntPtr box, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_set_center_widget(System.IntPtr box, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_set_child_packing(System.IntPtr box, System.IntPtr child, int expand, int fill, uint padding, int pack_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_set_homogeneous(System.IntPtr box, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_box_set_spacing(System.IntPtr box, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_new_from_model(System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_get_for_attach_widget(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_attach(System.IntPtr menu, System.IntPtr child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_attach_to_widget(System.IntPtr menu, System.IntPtr attach_widget, System.IntPtr detacher);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_detach(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_get_accel_group(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_menu_get_accel_path(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_get_active(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_get_attach_widget(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_get_monitor(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_get_reserve_toggle_size(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_get_tearoff_state(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_menu_get_title(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_place_on_monitor(System.IntPtr menu, System.IntPtr monitor);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_popdown(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_popup(System.IntPtr menu, System.IntPtr parent_menu_shell, System.IntPtr parent_menu_item, System.IntPtr func, System.IntPtr data, uint button, uint activate_time);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_popup_at_pointer(System.IntPtr menu, System.IntPtr trigger_event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_popup_at_rect(System.IntPtr menu, System.IntPtr rect_window, System.IntPtr rect, int rect_anchor, int menu_anchor, System.IntPtr trigger_event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_popup_at_widget(System.IntPtr menu, System.IntPtr widget, int widget_anchor, int menu_anchor, System.IntPtr trigger_event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_popup_for_device(System.IntPtr menu, System.IntPtr device, System.IntPtr parent_menu_shell, System.IntPtr parent_menu_item, System.IntPtr func, System.IntPtr data, System.IntPtr destroy, uint button, uint activate_time);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_reorder_child(System.IntPtr menu, System.IntPtr child, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_reposition(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_accel_group(System.IntPtr menu, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_accel_path(System.IntPtr menu, string accel_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_active(System.IntPtr menu, uint index);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_monitor(System.IntPtr menu, int monitor_num);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_reserve_toggle_size(System.IntPtr menu, int reserve_toggle_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_screen(System.IntPtr menu, System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_tearoff_state(System.IntPtr menu, int torn_off);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_set_title(System.IntPtr menu, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_new(string application_id, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_add_accelerator(System.IntPtr application, string accelerator, string action_name, System.IntPtr parameter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_add_window(System.IntPtr application, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_accels_for_action(System.IntPtr application, string detailed_action_name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_actions_for_accel(System.IntPtr application, string accel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_active_window(System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_app_menu(System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_menu_by_id(System.IntPtr application, string id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_menubar(System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_window_by_id(System.IntPtr application, uint id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_get_windows(System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_application_inhibit(System.IntPtr application, System.IntPtr window, int flags, string reason);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_application_is_inhibited(System.IntPtr application, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_list_action_descriptions(System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_application_prefers_app_menu(System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_remove_accelerator(System.IntPtr application, string action_name, System.IntPtr parameter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_remove_window(System.IntPtr application, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_set_accels_for_action(System.IntPtr application, string detailed_action_name, System.IntPtr accels);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_set_app_menu(System.IntPtr application, System.IntPtr app_menu);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_set_menubar(System.IntPtr application, System.IntPtr menubar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_uninhibit(System.IntPtr application, uint cookie);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_window_new(System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_application_window_get_help_overlay(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_application_window_get_id(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_application_window_get_show_menubar(System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_window_set_help_overlay(System.IntPtr window, System.IntPtr help_overlay);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_application_window_set_show_menubar(System.IntPtr window, int show_menubar);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_arrow_new(int arrow_type, int shadow_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_arrow_set(System.IntPtr arrow, int arrow_type, int shadow_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_misc_get_alignment(System.IntPtr misc, System.IntPtr xalign, System.IntPtr yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_misc_get_padding(System.IntPtr misc, System.IntPtr xpad, System.IntPtr ypad);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_misc_set_alignment(System.IntPtr misc, float xalign, float yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_misc_set_padding(System.IntPtr misc, int xpad, int ypad);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_aspect_frame_new(string label, float xalign, float yalign, float ratio, int obey_child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_aspect_frame_set(System.IntPtr aspect_frame, float xalign, float yalign, float ratio, int obey_child);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_frame_new(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_frame_get_label(System.IntPtr frame);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_frame_get_label_align(System.IntPtr frame, System.IntPtr xalign, System.IntPtr yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_frame_get_label_widget(System.IntPtr frame);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_frame_get_shadow_type(System.IntPtr frame);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_frame_set_label(System.IntPtr frame, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_frame_set_label_align(System.IntPtr frame, float xalign, float yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_frame_set_label_widget(System.IntPtr frame, System.IntPtr label_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_frame_set_shadow_type(System.IntPtr frame, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_assistant_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_add_action_widget(System.IntPtr assistant, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_append_page(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_commit(System.IntPtr assistant);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_get_current_page(System.IntPtr assistant);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_get_n_pages(System.IntPtr assistant);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_assistant_get_nth_page(System.IntPtr assistant, int page_num);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_get_page_complete(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_get_page_has_padding(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_assistant_get_page_header_image(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_assistant_get_page_side_image(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_assistant_get_page_title(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_get_page_type(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_insert_page(System.IntPtr assistant, System.IntPtr page, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_next_page(System.IntPtr assistant);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_assistant_prepend_page(System.IntPtr assistant, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_previous_page(System.IntPtr assistant);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_remove_action_widget(System.IntPtr assistant, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_remove_page(System.IntPtr assistant, int page_num);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_current_page(System.IntPtr assistant, int page_num);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_forward_page_func(System.IntPtr assistant, System.IntPtr page_func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_page_complete(System.IntPtr assistant, System.IntPtr page, int complete);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_page_has_padding(System.IntPtr assistant, System.IntPtr page, int has_padding);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_page_header_image(System.IntPtr assistant, System.IntPtr page, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_page_side_image(System.IntPtr assistant, System.IntPtr page, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_page_title(System.IntPtr assistant, System.IntPtr page, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_set_page_type(System.IntPtr assistant, System.IntPtr page, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_assistant_update_buttons_state(System.IntPtr assistant);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_add(System.IntPtr container, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_check_resize(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_child_get_property(System.IntPtr container, System.IntPtr child, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_child_notify(System.IntPtr container, System.IntPtr child, string child_property);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_child_notify_by_pspec(System.IntPtr container, System.IntPtr child, System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_child_set_property(System.IntPtr container, System.IntPtr child, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_container_child_type(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_forall(System.IntPtr container, System.IntPtr callback, System.IntPtr callback_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_foreach(System.IntPtr container, System.IntPtr callback, System.IntPtr callback_data);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_container_get_border_width(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_get_children(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_container_get_focus_chain(System.IntPtr container, System.IntPtr focusable_widgets);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_get_focus_child(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_get_focus_hadjustment(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_get_focus_vadjustment(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_get_path_for_child(System.IntPtr container, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_container_get_resize_mode(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_propagate_draw(System.IntPtr container, System.IntPtr child, System.IntPtr cr);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_remove(System.IntPtr container, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_resize_children(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_set_border_width(System.IntPtr container, uint border_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_set_focus_chain(System.IntPtr container, System.IntPtr focusable_widgets);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_set_focus_child(System.IntPtr container, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_set_focus_hadjustment(System.IntPtr container, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_set_focus_vadjustment(System.IntPtr container, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_set_reallocate_redraws(System.IntPtr container, int needs_redraws);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_set_resize_mode(System.IntPtr container, int resize_mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_unset_focus_chain(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_class_find_child_property(System.IntPtr cclass, string property_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_class_handle_border_width(System.IntPtr klass);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_class_install_child_properties(System.IntPtr cclass, uint n_pspecs, System.IntPtr pspecs);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_class_install_child_property(System.IntPtr cclass, uint property_id, System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_class_list_child_properties(System.IntPtr cclass, System.IntPtr n_properties);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_binding_set_activate(System.IntPtr binding_set, uint keyval, int modifiers, System.IntPtr @object);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_binding_set_add_path(System.IntPtr binding_set, int path_type, string path_pattern, int priority);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_binding_set_by_class(System.IntPtr object_class);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_binding_set_find(string set_name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_binding_set_new(string set_name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_binding_entry_add_signal_from_string(System.IntPtr binding_set, string signal_desc);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_binding_entry_add_signall(System.IntPtr binding_set, uint keyval, int modifiers, string signal_name, System.IntPtr binding_args);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_binding_entry_remove(System.IntPtr binding_set, uint keyval, int modifiers);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_binding_entry_skip(System.IntPtr binding_set, uint keyval, int modifiers);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_renderer_cell_accessible_new(System.IntPtr renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_border_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_border_copy(System.IntPtr border_);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_border_free(System.IntPtr border_);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_new_from_file(string filename);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_new_from_resource(string resource_path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_new_from_string(string @string, long length);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_builder_add_callback_symbol(System.IntPtr builder, string callback_name, System.IntPtr callback_symbol);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_add_from_file(System.IntPtr builder, string filename, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_add_from_resource(System.IntPtr builder, string resource_path, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_add_from_string(System.IntPtr builder, string buffer, ulong length, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_add_objects_from_file(System.IntPtr builder, string filename, System.IntPtr object_ids, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_add_objects_from_resource(System.IntPtr builder, string resource_path, System.IntPtr object_ids, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_add_objects_from_string(System.IntPtr builder, string buffer, ulong length, System.IntPtr object_ids, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_builder_connect_signals(System.IntPtr builder, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_builder_connect_signals_full(System.IntPtr builder, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_builder_expose_object(System.IntPtr builder, string name, System.IntPtr @object);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_extend_with_template(System.IntPtr builder, System.IntPtr widget, ulong template_type, string buffer, ulong length, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_get_application(System.IntPtr builder);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_get_object(System.IntPtr builder, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_get_objects(System.IntPtr builder);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_builder_get_translation_domain(System.IntPtr builder);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_builder_get_type_from_name(System.IntPtr builder, string type_name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_builder_lookup_callback_symbol(System.IntPtr builder, string callback_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_builder_set_application(System.IntPtr builder, System.IntPtr application);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_builder_set_translation_domain(System.IntPtr builder, string domain);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_builder_value_from_string(System.IntPtr builder, System.IntPtr pspec, string @string, System.IntPtr value, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_builder_value_from_string_type(System.IntPtr builder, ulong type, string @string, System.IntPtr value, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_builder_error_quark();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_new_from_icon_name(string icon_name, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_new_from_stock(string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_new_with_label(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_new_with_mnemonic(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_clicked(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_enter(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_get_alignment(System.IntPtr button, System.IntPtr xalign, System.IntPtr yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_get_always_show_image(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_get_event_window(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_get_focus_on_click(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_get_image(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_get_image_position(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_button_get_label(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_get_relief(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_get_use_stock(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_get_use_underline(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_leave(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_pressed(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_released(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_alignment(System.IntPtr button, float xalign, float yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_always_show_image(System.IntPtr button, int always_show);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_focus_on_click(System.IntPtr button, int focus_on_click);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_image(System.IntPtr button, System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_image_position(System.IntPtr button, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_label(System.IntPtr button, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_relief(System.IntPtr button, int relief);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_use_stock(System.IntPtr button, int use_stock);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_set_use_underline(System.IntPtr button, int use_underline);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_button_box_new(int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_box_get_child_non_homogeneous(System.IntPtr widget, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_box_get_child_secondary(System.IntPtr widget, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_button_box_get_layout(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_box_set_child_non_homogeneous(System.IntPtr widget, System.IntPtr child, int non_homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_box_set_child_secondary(System.IntPtr widget, System.IntPtr child, int is_secondary);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_button_box_set_layout(System.IntPtr widget, int layout_style);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_calendar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_clear_marks(System.IntPtr calendar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_get_date(System.IntPtr calendar, System.IntPtr year, System.IntPtr month, System.IntPtr day);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_calendar_get_day_is_marked(System.IntPtr calendar, uint day);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_calendar_get_detail_height_rows(System.IntPtr calendar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_calendar_get_detail_width_chars(System.IntPtr calendar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_calendar_get_display_options(System.IntPtr calendar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_mark_day(System.IntPtr calendar, uint day);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_select_day(System.IntPtr calendar, uint day);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_select_month(System.IntPtr calendar, uint month, uint year);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_set_detail_func(System.IntPtr calendar, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_set_detail_height_rows(System.IntPtr calendar, int rows);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_set_detail_width_chars(System.IntPtr calendar, int chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_set_display_options(System.IntPtr calendar, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_calendar_unmark_day(System.IntPtr calendar, uint day);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_bind_template_callback_full(System.IntPtr widget_class, string callback_name, System.IntPtr callback_symbol);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_bind_template_child_full(System.IntPtr widget_class, string name, int internal_child, long struct_offset);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_class_find_style_property(System.IntPtr klass, string property_name);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_class_get_css_name(System.IntPtr widget_class);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_install_style_property(System.IntPtr klass, System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_install_style_property_parser(System.IntPtr klass, System.IntPtr pspec, System.IntPtr parser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_class_list_style_properties(System.IntPtr klass, System.IntPtr n_properties);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_set_accessible_role(System.IntPtr widget_class, int role);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_set_accessible_type(System.IntPtr widget_class, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_set_connect_func(System.IntPtr widget_class, System.IntPtr connect_func, System.IntPtr connect_data, System.IntPtr connect_data_destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_set_css_name(System.IntPtr widget_class, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_set_template(System.IntPtr widget_class, System.IntPtr template_bytes);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_class_set_template_from_resource(System.IntPtr widget_class, string resource_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_accessible_parent_activate(System.IntPtr parent, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_accessible_parent_edit(System.IntPtr parent, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_accessible_parent_expand_collapse(System.IntPtr parent, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_accessible_parent_get_cell_area(System.IntPtr parent, System.IntPtr cell, System.IntPtr cell_rect);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_accessible_parent_get_cell_extents(System.IntPtr parent, System.IntPtr cell, System.IntPtr x, System.IntPtr y, System.IntPtr width, System.IntPtr height, int coord_type);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_accessible_parent_get_child_index(System.IntPtr parent, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_accessible_parent_get_renderer_state(System.IntPtr parent, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_accessible_parent_grab_focus(System.IntPtr parent, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_accessible_parent_update_relationset(System.IntPtr parent, System.IntPtr cell, System.IntPtr relationset);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_activate(System.IntPtr cell, System.IntPtr @event, System.IntPtr widget, string path, System.IntPtr background_area, System.IntPtr cell_area, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_aligned_area(System.IntPtr cell, System.IntPtr widget, int flags, System.IntPtr cell_area, System.IntPtr aligned_area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_alignment(System.IntPtr cell, System.IntPtr xalign, System.IntPtr yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_fixed_size(System.IntPtr cell, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_padding(System.IntPtr cell, System.IntPtr xpad, System.IntPtr ypad);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_preferred_height(System.IntPtr cell, System.IntPtr widget, System.IntPtr minimum_size, System.IntPtr natural_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_preferred_height_for_width(System.IntPtr cell, System.IntPtr widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_preferred_size(System.IntPtr cell, System.IntPtr widget, System.IntPtr minimum_size, System.IntPtr natural_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_preferred_width(System.IntPtr cell, System.IntPtr widget, System.IntPtr minimum_size, System.IntPtr natural_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_preferred_width_for_height(System.IntPtr cell, System.IntPtr widget, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_get_request_mode(System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_get_sensitive(System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_get_size(System.IntPtr cell, System.IntPtr widget, System.IntPtr cell_area, System.IntPtr x_offset, System.IntPtr y_offset, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_get_state(System.IntPtr cell, System.IntPtr widget, int cell_state);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_get_visible(System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_is_activatable(System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_render(System.IntPtr cell, System.IntPtr cr, System.IntPtr widget, System.IntPtr background_area, System.IntPtr cell_area, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_set_alignment(System.IntPtr cell, float xalign, float yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_set_fixed_size(System.IntPtr cell, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_set_padding(System.IntPtr cell, int xpad, int ypad);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_set_sensitive(System.IntPtr cell, int sensitive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_set_visible(System.IntPtr cell, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_start_editing(System.IntPtr cell, System.IntPtr @event, System.IntPtr widget, string path, System.IntPtr background_area, System.IntPtr cell_area, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_stop_editing(System.IntPtr cell, int canceled);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_activate(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr cell_area, int flags, int edit_only);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_activate_cell(System.IntPtr area, System.IntPtr widget, System.IntPtr renderer, System.IntPtr @event, System.IntPtr cell_area, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_add(System.IntPtr area, System.IntPtr renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_add_focus_sibling(System.IntPtr area, System.IntPtr renderer, System.IntPtr sibling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_apply_attributes(System.IntPtr area, System.IntPtr tree_model, System.IntPtr iter, int is_expander, int is_expanded);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_attribute_connect(System.IntPtr area, System.IntPtr renderer, string attribute, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_attribute_disconnect(System.IntPtr area, System.IntPtr renderer, string attribute);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_attribute_get_column(System.IntPtr area, System.IntPtr renderer, string attribute);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_cell_get_property(System.IntPtr area, System.IntPtr renderer, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_cell_set_property(System.IntPtr area, System.IntPtr renderer, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_copy_context(System.IntPtr area, System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_create_context(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_event(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr @event, System.IntPtr cell_area, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_focus(System.IntPtr area, int direction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_foreach(System.IntPtr area, System.IntPtr callback, System.IntPtr callback_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_foreach_alloc(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr cell_area, System.IntPtr background_area, System.IntPtr callback, System.IntPtr callback_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_get_cell_allocation(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr renderer, System.IntPtr cell_area, System.IntPtr allocation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_get_cell_at_position(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr cell_area, int x, int y, System.IntPtr alloc_area);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_cell_area_get_current_path_string(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_get_edit_widget(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_get_edited_cell(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_get_focus_cell(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_get_focus_from_sibling(System.IntPtr area, System.IntPtr renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_get_focus_siblings(System.IntPtr area, System.IntPtr renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_get_preferred_height(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr minimum_height, System.IntPtr natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_get_preferred_height_for_width(System.IntPtr area, System.IntPtr context, System.IntPtr widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_get_preferred_width(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr minimum_width, System.IntPtr natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_get_preferred_width_for_height(System.IntPtr area, System.IntPtr context, System.IntPtr widget, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_get_request_mode(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_has_renderer(System.IntPtr area, System.IntPtr renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_inner_cell_area(System.IntPtr area, System.IntPtr widget, System.IntPtr cell_area, System.IntPtr inner_area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_is_activatable(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_is_focus_sibling(System.IntPtr area, System.IntPtr renderer, System.IntPtr sibling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_remove(System.IntPtr area, System.IntPtr renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_remove_focus_sibling(System.IntPtr area, System.IntPtr renderer, System.IntPtr sibling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_render(System.IntPtr area, System.IntPtr context, System.IntPtr widget, System.IntPtr cr, System.IntPtr background_area, System.IntPtr cell_area, int flags, int paint_focus);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_request_renderer(System.IntPtr area, System.IntPtr renderer, int orientation, System.IntPtr widget, int for_size, System.IntPtr minimum_size, System.IntPtr natural_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_set_focus_cell(System.IntPtr area, System.IntPtr renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_stop_editing(System.IntPtr area, int canceled);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_allocate(System.IntPtr context, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_get_allocation(System.IntPtr context, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_context_get_area(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_get_preferred_height(System.IntPtr context, System.IntPtr minimum_height, System.IntPtr natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_get_preferred_height_for_width(System.IntPtr context, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_get_preferred_width(System.IntPtr context, System.IntPtr minimum_width, System.IntPtr natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_get_preferred_width_for_height(System.IntPtr context, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_push_preferred_height(System.IntPtr context, int minimum_height, int natural_height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_push_preferred_width(System.IntPtr context, int minimum_width, int natural_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_context_reset(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_filter_new(System.IntPtr child_model, System.IntPtr root);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_foreach(System.IntPtr model, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_tree_model_get_column_type(System.IntPtr tree_model, int index_);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_get_flags(System.IntPtr tree_model);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_get_iter(System.IntPtr tree_model, System.IntPtr iter, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_get_iter_first(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_get_iter_from_string(System.IntPtr tree_model, System.IntPtr iter, string path_string);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_get_n_columns(System.IntPtr tree_model);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_get_path(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_tree_model_get_string_from_iter(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_get_value(System.IntPtr tree_model, System.IntPtr iter, int column, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_iter_children(System.IntPtr tree_model, System.IntPtr iter, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_iter_has_child(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_iter_n_children(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_iter_next(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_iter_nth_child(System.IntPtr tree_model, System.IntPtr iter, System.IntPtr parent, int n);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_iter_parent(System.IntPtr tree_model, System.IntPtr iter, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_iter_previous(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_ref_node(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_row_changed(System.IntPtr tree_model, System.IntPtr path, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_row_deleted(System.IntPtr tree_model, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_row_has_child_toggled(System.IntPtr tree_model, System.IntPtr path, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_row_inserted(System.IntPtr tree_model, System.IntPtr path, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_rows_reordered(System.IntPtr tree_model, System.IntPtr path, System.IntPtr iter, System.IntPtr new_order);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_rows_reordered_with_length(System.IntPtr tree_model, System.IntPtr path, System.IntPtr iter, System.IntPtr new_order, int length);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_sort_new_with_model(System.IntPtr child_model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_unref_node(System.IntPtr tree_model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_iter_copy(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_iter_free(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_area_box_get_spacing(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_box_pack_end(System.IntPtr box, System.IntPtr renderer, int expand, int align, int @fixed);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_box_pack_start(System.IntPtr box, System.IntPtr renderer, int expand, int align, int @fixed);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_box_set_spacing(System.IntPtr box, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_class_find_cell_property(System.IntPtr aclass, string property_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_area_class_install_cell_property(System.IntPtr aclass, uint property_id, System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_area_class_list_cell_properties(System.IntPtr aclass, System.IntPtr n_properties);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_requisition_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_requisition_copy(System.IntPtr requisition);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_requisition_free(System.IntPtr requisition);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_text_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_text_set_fixed_height_from_font(System.IntPtr renderer, int number_of_rows);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_accel_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_class_set_accessible_type(System.IntPtr renderer_class, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_combo_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_pixbuf_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_progress_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_spin_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_size_from_name(string name);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_icon_size_get_name(int size);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_size_lookup(int size, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_size_lookup_for_settings(System.IntPtr settings, int size, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_size_register(string name, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_size_register_alias(string alias, int target);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_spinner_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_renderer_toggle_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_toggle_get_activatable(System.IntPtr toggle);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_toggle_get_active(System.IntPtr toggle);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_renderer_toggle_get_radio(System.IntPtr toggle);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_toggle_set_activatable(System.IntPtr toggle, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_toggle_set_active(System.IntPtr toggle, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_renderer_toggle_set_radio(System.IntPtr toggle, int radio);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_path_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_path_new_first();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_path_new_from_indicesv(System.IntPtr indices, ulong length);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_path_new_from_string(string path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_path_append_index(System.IntPtr path, int index_);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_path_compare(System.IntPtr a, System.IntPtr b);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_path_copy(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_path_down(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_path_free(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_path_get_depth(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_path_get_indices(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_path_get_indices_with_depth(System.IntPtr path, System.IntPtr depth);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_path_is_ancestor(System.IntPtr path, System.IntPtr descendant);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_path_is_descendant(System.IntPtr path, System.IntPtr ancestor);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_path_next(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_path_prepend_index(System.IntPtr path, int index_);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_path_prev(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_tree_path_to_string(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_path_up(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_view_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_view_new_with_context(System.IntPtr area, System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_view_new_with_markup(string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_view_new_with_pixbuf(System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_view_new_with_text(string text);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_view_get_displayed_row(System.IntPtr cell_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_view_get_draw_sensitive(System.IntPtr cell_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_view_get_fit_model(System.IntPtr cell_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_cell_view_get_model(System.IntPtr cell_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_cell_view_get_size_of_row(System.IntPtr cell_view, System.IntPtr path, System.IntPtr requisition);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_view_set_background_color(System.IntPtr cell_view, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_view_set_background_rgba(System.IntPtr cell_view, System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_view_set_displayed_row(System.IntPtr cell_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_view_set_draw_sensitive(System.IntPtr cell_view, int draw_sensitive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_view_set_fit_model(System.IntPtr cell_view, int fit_model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_cell_view_set_model(System.IntPtr cell_view, System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toggle_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toggle_button_new_with_label(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toggle_button_new_with_mnemonic(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toggle_button_get_active(System.IntPtr toggle_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toggle_button_get_inconsistent(System.IntPtr toggle_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toggle_button_get_mode(System.IntPtr toggle_button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_button_set_active(System.IntPtr toggle_button, int is_active);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_button_set_inconsistent(System.IntPtr toggle_button, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_button_set_mode(System.IntPtr toggle_button, int draw_indicator);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_button_toggled(System.IntPtr toggle_button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_check_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_check_button_new_with_label(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_check_button_new_with_mnemonic(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_check_menu_item_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_check_menu_item_new_with_label(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_check_menu_item_new_with_mnemonic(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_check_menu_item_get_active(System.IntPtr check_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_check_menu_item_get_draw_as_radio(System.IntPtr check_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_check_menu_item_get_inconsistent(System.IntPtr check_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_check_menu_item_set_active(System.IntPtr check_menu_item, int is_active);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_check_menu_item_set_draw_as_radio(System.IntPtr check_menu_item, int draw_as_radio);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_check_menu_item_set_inconsistent(System.IntPtr check_menu_item, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_check_menu_item_toggled(System.IntPtr check_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_item_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_item_new_with_label(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_item_new_with_mnemonic(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_activate(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_deselect(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_menu_item_get_accel_path(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_menu_item_get_label(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_item_get_reserve_indicator(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_item_get_right_justified(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_item_get_submenu(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_item_get_use_underline(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_select(System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_set_accel_path(System.IntPtr menu_item, string accel_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_set_label(System.IntPtr menu_item, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_set_reserve_indicator(System.IntPtr menu_item, int reserve);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_set_right_justified(System.IntPtr menu_item, int right_justified);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_set_submenu(System.IntPtr menu_item, System.IntPtr submenu);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_set_use_underline(System.IntPtr menu_item, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_toggle_size_allocate(System.IntPtr menu_item, int allocation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_item_toggle_size_request(System.IntPtr menu_item, System.IntPtr requisition);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_get(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_get_default(System.IntPtr display);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_get_for_display(System.IntPtr display, System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_clear(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_get_display(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_get_owner(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_get_selection(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_request_contents(System.IntPtr clipboard, System.IntPtr target, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_request_image(System.IntPtr clipboard, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_request_rich_text(System.IntPtr clipboard, System.IntPtr buffer, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_request_targets(System.IntPtr clipboard, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_request_text(System.IntPtr clipboard, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_request_uris(System.IntPtr clipboard, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_set_can_store(System.IntPtr clipboard, System.IntPtr targets, int n_targets);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_set_image(System.IntPtr clipboard, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_set_text(System.IntPtr clipboard, string text, int len);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_set_with_data(System.IntPtr clipboard, System.IntPtr targets, uint n_targets, System.IntPtr get_func, System.IntPtr clear_func, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_set_with_owner(System.IntPtr clipboard, System.IntPtr targets, uint n_targets, System.IntPtr get_func, System.IntPtr clear_func, System.IntPtr owner);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_clipboard_store(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_wait_for_contents(System.IntPtr clipboard, System.IntPtr target);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_wait_for_image(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_wait_for_rich_text(System.IntPtr clipboard, System.IntPtr buffer, System.IntPtr format, System.IntPtr length);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_wait_for_targets(System.IntPtr clipboard, System.IntPtr targets, System.IntPtr n_targets);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_clipboard_wait_for_text(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_clipboard_wait_for_uris(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_wait_is_image_available(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_wait_is_rich_text_available(System.IntPtr clipboard, System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_wait_is_target_available(System.IntPtr clipboard, System.IntPtr target);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_wait_is_text_available(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_clipboard_wait_is_uris_available(System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_new(System.IntPtr table);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_add_mark(System.IntPtr buffer, System.IntPtr mark, System.IntPtr where);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_add_selection_clipboard(System.IntPtr buffer, System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_apply_tag(System.IntPtr buffer, System.IntPtr tag, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_apply_tag_by_name(System.IntPtr buffer, string name, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_backspace(System.IntPtr buffer, System.IntPtr iter, int interactive, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_begin_user_action(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_copy_clipboard(System.IntPtr buffer, System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_create_child_anchor(System.IntPtr buffer, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_create_mark(System.IntPtr buffer, string mark_name, System.IntPtr where, int left_gravity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_cut_clipboard(System.IntPtr buffer, System.IntPtr clipboard, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_delete(System.IntPtr buffer, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_delete_interactive(System.IntPtr buffer, System.IntPtr start_iter, System.IntPtr end_iter, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_delete_mark(System.IntPtr buffer, System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_delete_mark_by_name(System.IntPtr buffer, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_delete_selection(System.IntPtr buffer, int interactive, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_deserialize(System.IntPtr register_buffer, System.IntPtr content_buffer, System.IntPtr format, System.IntPtr iter, System.IntPtr data, ulong length, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_deserialize_get_can_create_tags(System.IntPtr buffer, System.IntPtr format);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_deserialize_set_can_create_tags(System.IntPtr buffer, System.IntPtr format, int can_create_tags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_end_user_action(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_bounds(System.IntPtr buffer, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_get_char_count(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_copy_target_list(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_deserialize_formats(System.IntPtr buffer, System.IntPtr n_formats);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_end_iter(System.IntPtr buffer, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_get_has_selection(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_insert(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_iter_at_child_anchor(System.IntPtr buffer, System.IntPtr iter, System.IntPtr anchor);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_iter_at_line(System.IntPtr buffer, System.IntPtr iter, int line_number);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_iter_at_line_index(System.IntPtr buffer, System.IntPtr iter, int line_number, int byte_index);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_iter_at_line_offset(System.IntPtr buffer, System.IntPtr iter, int line_number, int char_offset);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_iter_at_mark(System.IntPtr buffer, System.IntPtr iter, System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_iter_at_offset(System.IntPtr buffer, System.IntPtr iter, int char_offset);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_get_line_count(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_mark(System.IntPtr buffer, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_get_modified(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_paste_target_list(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_selection_bound(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_get_selection_bounds(System.IntPtr buffer, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_serialize_formats(System.IntPtr buffer, System.IntPtr n_formats);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_text_buffer_get_slice(System.IntPtr buffer, System.IntPtr start, System.IntPtr end, int include_hidden_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_get_start_iter(System.IntPtr buffer, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_get_tag_table(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_text_buffer_get_text(System.IntPtr buffer, System.IntPtr start, System.IntPtr end, int include_hidden_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_insert(System.IntPtr buffer, System.IntPtr iter, string text, int len);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_insert_at_cursor(System.IntPtr buffer, string text, int len);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_insert_child_anchor(System.IntPtr buffer, System.IntPtr iter, System.IntPtr anchor);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_insert_interactive(System.IntPtr buffer, System.IntPtr iter, string text, int len, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_insert_interactive_at_cursor(System.IntPtr buffer, string text, int len, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_insert_markup(System.IntPtr buffer, System.IntPtr iter, string markup, int len);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_insert_pixbuf(System.IntPtr buffer, System.IntPtr iter, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_insert_range(System.IntPtr buffer, System.IntPtr iter, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_buffer_insert_range_interactive(System.IntPtr buffer, System.IntPtr iter, System.IntPtr start, System.IntPtr end, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_move_mark(System.IntPtr buffer, System.IntPtr mark, System.IntPtr where);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_move_mark_by_name(System.IntPtr buffer, string name, System.IntPtr where);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_paste_clipboard(System.IntPtr buffer, System.IntPtr clipboard, System.IntPtr override_location, int default_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_place_cursor(System.IntPtr buffer, System.IntPtr where);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_register_deserialize_format(System.IntPtr buffer, string mime_type, System.IntPtr function, System.IntPtr user_data, System.IntPtr user_data_destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_register_deserialize_tagset(System.IntPtr buffer, string tagset_name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_register_serialize_format(System.IntPtr buffer, string mime_type, System.IntPtr function, System.IntPtr user_data, System.IntPtr user_data_destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_register_serialize_tagset(System.IntPtr buffer, string tagset_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_remove_all_tags(System.IntPtr buffer, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_remove_selection_clipboard(System.IntPtr buffer, System.IntPtr clipboard);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_remove_tag(System.IntPtr buffer, System.IntPtr tag, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_remove_tag_by_name(System.IntPtr buffer, string name, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_select_range(System.IntPtr buffer, System.IntPtr ins, System.IntPtr bound);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_buffer_serialize(System.IntPtr register_buffer, System.IntPtr content_buffer, System.IntPtr format, System.IntPtr start, System.IntPtr end, System.IntPtr length);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_set_modified(System.IntPtr buffer, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_set_text(System.IntPtr buffer, string text, int len);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_unregister_deserialize_format(System.IntPtr buffer, System.IntPtr format);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_buffer_unregister_serialize_format(System.IntPtr buffer, System.IntPtr format);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_target_entry_new(string target, uint flags, uint info);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_target_entry_copy(System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_entry_free(System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_copy(System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_selection_data_free(System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_data(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_data_type(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_data_with_length(System.IntPtr selection_data, System.IntPtr length);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_display(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_get_format(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_get_length(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_pixbuf(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_selection(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_target(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_get_targets(System.IntPtr selection_data, System.IntPtr targets, System.IntPtr n_atoms);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_selection_data_get_text(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_selection_data_get_uris(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_selection_data_set(System.IntPtr selection_data, System.IntPtr type, int format, System.IntPtr data, int length);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_set_pixbuf(System.IntPtr selection_data, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_set_text(System.IntPtr selection_data, string str, int len);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_set_uris(System.IntPtr selection_data, System.IntPtr uris);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_targets_include_image(System.IntPtr selection_data, int writable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_targets_include_rich_text(System.IntPtr selection_data, System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_targets_include_text(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_selection_data_targets_include_uri(System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_chooser_add_palette(System.IntPtr chooser, int orientation, int colors_per_line, int n_colors, System.IntPtr colors);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_chooser_get_rgba(System.IntPtr chooser, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_color_chooser_get_use_alpha(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_chooser_set_rgba(System.IntPtr chooser, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_chooser_set_use_alpha(System.IntPtr chooser, int use_alpha);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_button_new_with_color(System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_button_new_with_rgba(System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern ushort gtk_color_button_get_alpha(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_button_get_color(System.IntPtr button, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_button_get_rgba(System.IntPtr button, System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_color_button_get_title(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_color_button_get_use_alpha(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_button_set_alpha(System.IntPtr button, ushort alpha);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_button_set_color(System.IntPtr button, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_button_set_rgba(System.IntPtr button, System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_button_set_title(System.IntPtr button, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_button_set_use_alpha(System.IntPtr button, int use_alpha);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_chooser_dialog_new(string title, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_chooser_widget_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_selection_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_color_selection_palette_from_string(string str, System.IntPtr colors, System.IntPtr n_colors);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_color_selection_palette_to_string(System.IntPtr colors, int n_colors);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_selection_set_change_palette_with_screen_hook(System.IntPtr func);
        [DllImport("libgtk-3.so.0")]
        public static extern ushort gtk_color_selection_get_current_alpha(System.IntPtr colorsel);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_get_current_color(System.IntPtr colorsel, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_get_current_rgba(System.IntPtr colorsel, System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_color_selection_get_has_opacity_control(System.IntPtr colorsel);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_color_selection_get_has_palette(System.IntPtr colorsel);
        [DllImport("libgtk-3.so.0")]
        public static extern ushort gtk_color_selection_get_previous_alpha(System.IntPtr colorsel);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_get_previous_color(System.IntPtr colorsel, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_get_previous_rgba(System.IntPtr colorsel, System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_color_selection_is_adjusting(System.IntPtr colorsel);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_current_alpha(System.IntPtr colorsel, ushort alpha);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_current_color(System.IntPtr colorsel, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_current_rgba(System.IntPtr colorsel, System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_has_opacity_control(System.IntPtr colorsel, int has_opacity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_has_palette(System.IntPtr colorsel, int has_palette);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_previous_alpha(System.IntPtr colorsel, ushort alpha);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_previous_color(System.IntPtr colorsel, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_color_selection_set_previous_rgba(System.IntPtr colorsel, System.IntPtr rgba);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_selection_dialog_new(string title);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_color_selection_dialog_get_color_selection(System.IntPtr colorsel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_text_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_combo_box_text_new_with_entry();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_append(System.IntPtr combo_box, string id, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_append_text(System.IntPtr combo_box, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_combo_box_text_get_active_text(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_insert(System.IntPtr combo_box, int position, string id, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_insert_text(System.IntPtr combo_box, int position, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_prepend(System.IntPtr combo_box, string id, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_prepend_text(System.IntPtr combo_box, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_remove(System.IntPtr combo_box, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_combo_box_text_remove_all(System.IntPtr combo_box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_path_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_append_for_widget(System.IntPtr path, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_append_type(System.IntPtr path, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_append_with_siblings(System.IntPtr path, System.IntPtr siblings, uint sibling_index);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_path_copy(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_free(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_widget_path_get_object_type(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_has_parent(System.IntPtr path, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_is_type(System.IntPtr path, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_add_class(System.IntPtr path, int pos, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_add_region(System.IntPtr path, int pos, string name, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_clear_classes(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_clear_regions(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_path_iter_get_name(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_path_iter_get_object_name(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_widget_path_iter_get_object_type(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_widget_path_iter_get_sibling_index(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_path_iter_get_siblings(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_iter_get_state(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_iter_has_class(System.IntPtr path, int pos, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_iter_has_name(System.IntPtr path, int pos, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_iter_has_qclass(System.IntPtr path, int pos, uint qname);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_iter_has_qname(System.IntPtr path, int pos, uint qname);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_iter_has_qregion(System.IntPtr path, int pos, uint qname, System.IntPtr flags);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_iter_has_region(System.IntPtr path, int pos, string name, System.IntPtr flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_path_iter_list_classes(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_path_iter_list_regions(System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_remove_class(System.IntPtr path, int pos, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_remove_region(System.IntPtr path, int pos, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_set_name(System.IntPtr path, int pos, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_set_object_name(System.IntPtr path, int pos, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_set_object_type(System.IntPtr path, int pos, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_iter_set_state(System.IntPtr path, int pos, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_widget_path_length(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_prepend_type(System.IntPtr path, ulong type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_widget_path_ref(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_widget_path_to_string(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_widget_path_unref(System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_cell_accessible_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_cell_accessible_add_child(System.IntPtr container, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_container_cell_accessible_get_children(System.IntPtr container);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_container_cell_accessible_remove_child(System.IntPtr container, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_provider_get_icon_factory(System.IntPtr provider, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_provider_get_style(System.IntPtr provider, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_provider_get_style_property(System.IntPtr provider, System.IntPtr path, int state, System.IntPtr pspec, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_css_provider_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_css_provider_get_default();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_css_provider_get_named(string name, string variant);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_css_provider_load_from_data(System.IntPtr css_provider, System.IntPtr data, long length, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_css_provider_load_from_file(System.IntPtr css_provider, System.IntPtr file, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_css_provider_load_from_path(System.IntPtr css_provider, string path, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_css_provider_load_from_resource(System.IntPtr css_provider, string resource_path);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_css_provider_to_string(System.IntPtr provider);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_css_section_get_end_line(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_css_section_get_end_position(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_css_section_get_file(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_css_section_get_parent(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_css_section_get_section_type(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_css_section_get_start_line(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_css_section_get_start_position(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_css_section_ref(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_css_section_unref(System.IntPtr section);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_css_provider_error_quark();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_drawing_area_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_copy_clipboard(System.IntPtr editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_cut_clipboard(System.IntPtr editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_delete_selection(System.IntPtr editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_delete_text(System.IntPtr editable, int start_pos, int end_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_editable_get_chars(System.IntPtr editable, int start_pos, int end_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_editable_get_editable(System.IntPtr editable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_editable_get_position(System.IntPtr editable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_editable_get_selection_bounds(System.IntPtr editable, System.IntPtr start_pos, System.IntPtr end_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_insert_text(System.IntPtr editable, string new_text, int new_text_length, System.IntPtr position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_paste_clipboard(System.IntPtr editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_select_region(System.IntPtr editable, int start_pos, int end_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_set_editable(System.IntPtr editable, int is_editable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_editable_set_position(System.IntPtr editable, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_buffer_new(string initial_chars, int n_initial_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_entry_buffer_delete_text(System.IntPtr buffer, uint position, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_buffer_emit_deleted_text(System.IntPtr buffer, uint position, uint n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_buffer_emit_inserted_text(System.IntPtr buffer, uint position, string chars, uint n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_entry_buffer_get_bytes(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_entry_buffer_get_length(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_buffer_get_max_length(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_buffer_get_text(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_entry_buffer_insert_text(System.IntPtr buffer, uint position, string chars, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_buffer_set_max_length(System.IntPtr buffer, int max_length);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_buffer_set_text(System.IntPtr buffer, string chars, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_new_with_buffer(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_activates_default(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern float gtk_entry_get_alignment(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_attributes(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_buffer(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_completion(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_current_icon_drag_source(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_cursor_hadjustment(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_has_frame(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_icon_activatable(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_get_icon_area(System.IntPtr entry, int icon_pos, System.IntPtr icon_area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_icon_at_pos(System.IntPtr entry, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_icon_gicon(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_get_icon_name(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_icon_pixbuf(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_icon_sensitive(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_get_icon_stock(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_icon_storage_type(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_get_icon_tooltip_markup(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_get_icon_tooltip_text(System.IntPtr entry, int icon_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_inner_border(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_input_hints(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_input_purpose(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_entry_get_invisible_char(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_layout(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_get_layout_offsets(System.IntPtr entry, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_max_length(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_max_width_chars(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_overwrite_mode(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_get_placeholder_text(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_entry_get_progress_fraction(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_entry_get_progress_pulse_step(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_get_tabs(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_get_text(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_get_text_area(System.IntPtr entry, System.IntPtr text_area);
        [DllImport("libgtk-3.so.0")]
        public static extern ushort gtk_entry_get_text_length(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_visibility(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_get_width_chars(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_grab_focus_without_selecting(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_im_context_filter_keypress(System.IntPtr entry, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_layout_index_to_text_index(System.IntPtr entry, int layout_index);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_progress_pulse(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_reset_im_context(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_activates_default(System.IntPtr entry, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_alignment(System.IntPtr entry, float xalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_attributes(System.IntPtr entry, System.IntPtr attrs);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_buffer(System.IntPtr entry, System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_completion(System.IntPtr entry, System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_cursor_hadjustment(System.IntPtr entry, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_has_frame(System.IntPtr entry, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_activatable(System.IntPtr entry, int icon_pos, int activatable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_drag_source(System.IntPtr entry, int icon_pos, System.IntPtr target_list, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_from_gicon(System.IntPtr entry, int icon_pos, System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_from_icon_name(System.IntPtr entry, int icon_pos, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_from_pixbuf(System.IntPtr entry, int icon_pos, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_from_stock(System.IntPtr entry, int icon_pos, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_sensitive(System.IntPtr entry, int icon_pos, int sensitive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_tooltip_markup(System.IntPtr entry, int icon_pos, string tooltip);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_icon_tooltip_text(System.IntPtr entry, int icon_pos, string tooltip);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_inner_border(System.IntPtr entry, System.IntPtr border);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_input_hints(System.IntPtr entry, int hints);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_input_purpose(System.IntPtr entry, int purpose);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_invisible_char(System.IntPtr entry, uint ch);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_max_length(System.IntPtr entry, int max);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_max_width_chars(System.IntPtr entry, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_overwrite_mode(System.IntPtr entry, int overwrite);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_placeholder_text(System.IntPtr entry, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_progress_fraction(System.IntPtr entry, double fraction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_progress_pulse_step(System.IntPtr entry, double fraction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_tabs(System.IntPtr entry, System.IntPtr tabs);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_text(System.IntPtr entry, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_visibility(System.IntPtr entry, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_set_width_chars(System.IntPtr entry, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_text_index_to_layout_index(System.IntPtr entry, int text_index);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_unset_invisible_char(System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_completion_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_completion_new_with_area(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_complete(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_completion_compute_prefix(System.IntPtr completion, string key);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_delete_action(System.IntPtr completion, int index_);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_entry_completion_get_completion_prefix(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_completion_get_entry(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_completion_get_inline_completion(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_completion_get_inline_selection(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_completion_get_minimum_key_length(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_entry_completion_get_model(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_completion_get_popup_completion(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_completion_get_popup_set_width(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_completion_get_popup_single_match(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_entry_completion_get_text_column(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_insert_action_markup(System.IntPtr completion, int index_, string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_insert_action_text(System.IntPtr completion, int index_, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_insert_prefix(System.IntPtr completion);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_inline_completion(System.IntPtr completion, int inline_completion);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_inline_selection(System.IntPtr completion, int inline_selection);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_match_func(System.IntPtr completion, System.IntPtr func, System.IntPtr func_data, System.IntPtr func_notify);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_minimum_key_length(System.IntPtr completion, int length);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_model(System.IntPtr completion, System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_popup_completion(System.IntPtr completion, int popup_completion);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_popup_set_width(System.IntPtr completion, int popup_set_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_popup_single_match(System.IntPtr completion, int popup_single_match);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_entry_completion_set_text_column(System.IntPtr completion, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_target_list_new(System.IntPtr targets, uint ntargets);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_add(System.IntPtr list, System.IntPtr target, uint flags, uint info);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_add_image_targets(System.IntPtr list, uint info, int writable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_add_rich_text_targets(System.IntPtr list, uint info, int deserializable, System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_add_table(System.IntPtr list, System.IntPtr targets, uint ntargets);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_add_text_targets(System.IntPtr list, uint info);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_add_uri_targets(System.IntPtr list, uint info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_target_list_find(System.IntPtr list, System.IntPtr target, System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_target_list_ref(System.IntPtr list);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_remove(System.IntPtr list, System.IntPtr target);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_target_list_unref(System.IntPtr list);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_event_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_event_box_get_above_child(System.IntPtr event_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_event_box_get_visible_window(System.IntPtr event_box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_event_box_set_above_child(System.IntPtr event_box, int above_child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_event_box_set_visible_window(System.IntPtr event_box, int visible_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_event_controller_get_propagation_phase(System.IntPtr controller);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_event_controller_get_widget(System.IntPtr controller);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_event_controller_handle_event(System.IntPtr controller, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_event_controller_reset(System.IntPtr controller);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_event_controller_set_propagation_phase(System.IntPtr controller, int phase);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_expander_new(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_expander_new_with_mnemonic(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_expander_get_expanded(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_expander_get_label(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_expander_get_label_fill(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_expander_get_label_widget(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_expander_get_resize_toplevel(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_expander_get_spacing(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_expander_get_use_markup(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_expander_get_use_underline(System.IntPtr expander);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_expanded(System.IntPtr expander, int expanded);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_label(System.IntPtr expander, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_label_fill(System.IntPtr expander, int label_fill);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_label_widget(System.IntPtr expander, System.IntPtr label_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_resize_toplevel(System.IntPtr expander, int resize_toplevel);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_spacing(System.IntPtr expander, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_use_markup(System.IntPtr expander, int use_markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_expander_set_use_underline(System.IntPtr expander, int use_underline);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_add_choice(System.IntPtr chooser, string id, string label, string options, string option_labels);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_add_filter(System.IntPtr chooser, System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_add_shortcut_folder(System.IntPtr chooser, System.IntPtr folder, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_add_shortcut_folder_uri(System.IntPtr chooser, string uri, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_action(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_get_choice(System.IntPtr chooser, string id);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_create_folders(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_current_folder(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_current_folder_file(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_get_current_folder_uri(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_get_current_name(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_do_overwrite_confirmation(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_extra_widget(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_file(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_filename(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_filenames(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_files(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_filter(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_local_only(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_preview_file(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_preview_filename(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_get_preview_uri(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_preview_widget(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_preview_widget_active(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_select_multiple(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_show_hidden(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_get_uri(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_get_uris(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_get_use_preview_label(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_list_filters(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_list_shortcut_folder_uris(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_list_shortcut_folders(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_remove_choice(System.IntPtr chooser, string id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_remove_filter(System.IntPtr chooser, System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_remove_shortcut_folder(System.IntPtr chooser, System.IntPtr folder, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_remove_shortcut_folder_uri(System.IntPtr chooser, string uri, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_select_all(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_select_file(System.IntPtr chooser, System.IntPtr file, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_select_filename(System.IntPtr chooser, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_select_uri(System.IntPtr chooser, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_action(System.IntPtr chooser, int action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_choice(System.IntPtr chooser, string id, string option);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_create_folders(System.IntPtr chooser, int create_folders);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_set_current_folder(System.IntPtr chooser, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_set_current_folder_file(System.IntPtr chooser, System.IntPtr file, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_set_current_folder_uri(System.IntPtr chooser, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_current_name(System.IntPtr chooser, System.IntPtr name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_do_overwrite_confirmation(System.IntPtr chooser, int do_overwrite_confirmation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_extra_widget(System.IntPtr chooser, System.IntPtr extra_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_set_file(System.IntPtr chooser, System.IntPtr file, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_set_filename(System.IntPtr chooser, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_filter(System.IntPtr chooser, System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_local_only(System.IntPtr chooser, int local_only);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_preview_widget(System.IntPtr chooser, System.IntPtr preview_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_preview_widget_active(System.IntPtr chooser, int active);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_select_multiple(System.IntPtr chooser, int select_multiple);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_show_hidden(System.IntPtr chooser, int show_hidden);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_set_uri(System.IntPtr chooser, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_set_use_preview_label(System.IntPtr chooser, int use_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_unselect_all(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_unselect_file(System.IntPtr chooser, System.IntPtr file);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_unselect_filename(System.IntPtr chooser, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_unselect_uri(System.IntPtr chooser, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_filter_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_filter_new_from_gvariant(System.IntPtr variant);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_filter_add_custom(System.IntPtr filter, int needed, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_filter_add_mime_type(System.IntPtr filter, string mime_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_filter_add_pattern(System.IntPtr filter, string pattern);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_filter_add_pixbuf_formats(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_filter_filter(System.IntPtr filter, System.IntPtr filter_info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_filter_get_name(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_filter_get_needed(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_filter_set_name(System.IntPtr filter, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_filter_to_gvariant(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_button_new(string title, int action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_button_new_with_dialog(System.IntPtr dialog);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_button_get_focus_on_click(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_button_get_title(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_file_chooser_button_get_width_chars(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_button_set_focus_on_click(System.IntPtr button, int focus_on_click);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_button_set_title(System.IntPtr button, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_button_set_width_chars(System.IntPtr button, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_file_chooser_error_quark();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_native_new(string title, System.IntPtr parent, int action, string accept_label, string cancel_label);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_native_get_accept_label(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_file_chooser_native_get_cancel_label(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_native_set_accept_label(System.IntPtr self, string accept_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_file_chooser_native_set_cancel_label(System.IntPtr self, string cancel_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_native_dialog_destroy(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_native_dialog_get_modal(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_native_dialog_get_title(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_native_dialog_get_transient_for(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_native_dialog_get_visible(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_native_dialog_hide(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_native_dialog_run(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_native_dialog_set_modal(System.IntPtr self, int modal);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_native_dialog_set_title(System.IntPtr self, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_native_dialog_set_transient_for(System.IntPtr self, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_native_dialog_show(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_file_chooser_widget_new(int action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_fixed_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_fixed_move(System.IntPtr @fixed, System.IntPtr widget, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_fixed_put(System.IntPtr @fixed, System.IntPtr widget, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_flow_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_bind_model(System.IntPtr box, System.IntPtr model, System.IntPtr create_widget_func, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_flow_box_get_activate_on_single_click(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_flow_box_get_child_at_index(System.IntPtr box, int idx);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_flow_box_get_child_at_pos(System.IntPtr box, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_flow_box_get_column_spacing(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_flow_box_get_homogeneous(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_flow_box_get_max_children_per_line(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_flow_box_get_min_children_per_line(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_flow_box_get_row_spacing(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_flow_box_get_selected_children(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_flow_box_get_selection_mode(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_insert(System.IntPtr box, System.IntPtr widget, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_invalidate_filter(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_invalidate_sort(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_select_all(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_select_child(System.IntPtr box, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_selected_foreach(System.IntPtr box, System.IntPtr func, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_activate_on_single_click(System.IntPtr box, int single);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_column_spacing(System.IntPtr box, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_filter_func(System.IntPtr box, System.IntPtr filter_func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_hadjustment(System.IntPtr box, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_homogeneous(System.IntPtr box, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_max_children_per_line(System.IntPtr box, uint n_children);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_min_children_per_line(System.IntPtr box, uint n_children);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_row_spacing(System.IntPtr box, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_selection_mode(System.IntPtr box, int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_sort_func(System.IntPtr box, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_set_vadjustment(System.IntPtr box, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_unselect_all(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_unselect_child(System.IntPtr box, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_flow_box_child_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_flow_box_child_changed(System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_flow_box_child_get_index(System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_flow_box_child_is_selected(System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_chooser_get_font(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_chooser_get_font_desc(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_chooser_get_font_face(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_chooser_get_font_family(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_chooser_get_font_map(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_chooser_get_font_size(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_chooser_get_preview_text(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_chooser_get_show_preview_entry(System.IntPtr fontchooser);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_chooser_set_filter_func(System.IntPtr fontchooser, System.IntPtr filter, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_chooser_set_font(System.IntPtr fontchooser, string fontname);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_chooser_set_font_desc(System.IntPtr fontchooser, System.IntPtr font_desc);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_chooser_set_font_map(System.IntPtr fontchooser, System.IntPtr fontmap);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_chooser_set_preview_text(System.IntPtr fontchooser, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_chooser_set_show_preview_entry(System.IntPtr fontchooser, int show_preview_entry);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_button_new_with_font(string fontname);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_button_get_font_name(System.IntPtr font_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_button_get_show_size(System.IntPtr font_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_button_get_show_style(System.IntPtr font_button);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_button_get_title(System.IntPtr font_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_button_get_use_font(System.IntPtr font_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_button_get_use_size(System.IntPtr font_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_button_set_font_name(System.IntPtr font_button, string fontname);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_button_set_show_size(System.IntPtr font_button, int show_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_button_set_show_style(System.IntPtr font_button, int show_style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_button_set_title(System.IntPtr font_button, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_button_set_use_font(System.IntPtr font_button, int use_font);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_button_set_use_size(System.IntPtr font_button, int use_size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_chooser_dialog_new(string title, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_chooser_widget_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_get_face(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_get_face_list(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_get_family(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_get_family_list(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_selection_get_font_name(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_get_preview_entry(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_selection_get_preview_text(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_selection_get_size(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_get_size_entry(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_get_size_list(System.IntPtr fontsel);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_selection_set_font_name(System.IntPtr fontsel, string fontname);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_selection_set_preview_text(System.IntPtr fontsel, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_dialog_new(string title);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_dialog_get_cancel_button(System.IntPtr fsd);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_selection_dialog_get_font_name(System.IntPtr fsd);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_dialog_get_font_selection(System.IntPtr fsd);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_font_selection_dialog_get_ok_button(System.IntPtr fsd);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_font_selection_dialog_get_preview_text(System.IntPtr fsd);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_font_selection_dialog_set_font_name(System.IntPtr fsd, string fontname);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_font_selection_dialog_set_preview_text(System.IntPtr fsd, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gl_area_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_attach_buffers(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gl_area_get_auto_render(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gl_area_get_context(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gl_area_get_error(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gl_area_get_has_alpha(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gl_area_get_has_depth_buffer(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gl_area_get_has_stencil_buffer(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_get_required_version(System.IntPtr area, System.IntPtr major, System.IntPtr minor);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gl_area_get_use_es(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_make_current(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_queue_render(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_set_auto_render(System.IntPtr area, int auto_render);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_set_error(System.IntPtr area, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_set_has_alpha(System.IntPtr area, int has_alpha);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_set_has_depth_buffer(System.IntPtr area, int has_depth_buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_set_has_stencil_buffer(System.IntPtr area, int has_stencil_buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_set_required_version(System.IntPtr area, int major, int minor);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gl_area_set_use_es(System.IntPtr area, int use_es);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_get_bounding_box(System.IntPtr gesture, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_get_bounding_box_center(System.IntPtr gesture, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_get_device(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_get_group(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_get_last_event(System.IntPtr gesture, System.IntPtr sequence);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_get_last_updated_sequence(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_get_point(System.IntPtr gesture, System.IntPtr sequence, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_get_sequence_state(System.IntPtr gesture, System.IntPtr sequence);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_get_sequences(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_get_window(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_group(System.IntPtr group_gesture, System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_handles_sequence(System.IntPtr gesture, System.IntPtr sequence);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_is_active(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_is_grouped_with(System.IntPtr gesture, System.IntPtr other);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_is_recognized(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_set_sequence_state(System.IntPtr gesture, System.IntPtr sequence, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_set_state(System.IntPtr gesture, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_set_window(System.IntPtr gesture, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_ungroup(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_drag_new(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_drag_get_offset(System.IntPtr gesture, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_drag_get_start_point(System.IntPtr gesture, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_gesture_single_get_button(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_gesture_single_get_current_button(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_single_get_current_sequence(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_single_get_exclusive(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_single_get_touch_only(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_single_set_button(System.IntPtr gesture, uint button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_single_set_exclusive(System.IntPtr gesture, int exclusive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_single_set_touch_only(System.IntPtr gesture, int touch_only);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_long_press_new(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_multi_press_new(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_multi_press_get_area(System.IntPtr gesture, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_multi_press_set_area(System.IntPtr gesture, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_pan_new(System.IntPtr widget, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_pan_get_orientation(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gesture_pan_set_orientation(System.IntPtr gesture, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_rotate_new(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_gesture_rotate_get_angle_delta(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_swipe_new(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gesture_swipe_get_velocity(System.IntPtr gesture, System.IntPtr velocity_x, System.IntPtr velocity_y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gesture_zoom_new(System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_gesture_zoom_get_scale_delta(System.IntPtr gesture);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gradient_new_linear(double x0, double y0, double x1, double y1);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gradient_new_radial(double x0, double y0, double radius0, double x1, double y1, double radius1);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gradient_add_color_stop(System.IntPtr gradient, double offset, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gradient_ref(System.IntPtr gradient);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_gradient_resolve(System.IntPtr gradient, System.IntPtr props, System.IntPtr resolved_gradient);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_gradient_resolve_for_context(System.IntPtr gradient, System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_gradient_to_string(System.IntPtr gradient);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_gradient_unref(System.IntPtr gradient);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_symbolic_color_new_alpha(System.IntPtr color, double factor);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_symbolic_color_new_literal(System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_symbolic_color_new_mix(System.IntPtr color1, System.IntPtr color2, double factor);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_symbolic_color_new_name(string name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_symbolic_color_new_shade(System.IntPtr color, double factor);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_symbolic_color_new_win32(string theme_class, int id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_symbolic_color_ref(System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_symbolic_color_resolve(System.IntPtr color, System.IntPtr props, System.IntPtr resolved_color);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_symbolic_color_to_string(System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_symbolic_color_unref(System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_properties_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_properties_lookup_property(string property_name, System.IntPtr parse_func, System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_properties_register_property(System.IntPtr parse_func, System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_properties_clear(System.IntPtr props);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_properties_get_property(System.IntPtr props, string property, int state, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_properties_lookup_color(System.IntPtr props, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_properties_map_color(System.IntPtr props, string name, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_properties_merge(System.IntPtr props, System.IntPtr props_to_merge, int replace);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_properties_set_property(System.IntPtr props, string property, int state, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_properties_unset_property(System.IntPtr props, string property, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_add_provider_for_screen(System.IntPtr screen, System.IntPtr provider, uint priority);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_remove_provider_for_screen(System.IntPtr screen, System.IntPtr provider);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_reset_widgets(System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_add_class(System.IntPtr context, string class_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_add_provider(System.IntPtr context, System.IntPtr provider, uint priority);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_add_region(System.IntPtr context, string region_name, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_cancel_animations(System.IntPtr context, System.IntPtr region_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_background_color(System.IntPtr context, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_border(System.IntPtr context, int state, System.IntPtr border);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_border_color(System.IntPtr context, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_color(System.IntPtr context, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_get_direction(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_get_font(System.IntPtr context, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_get_frame_clock(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_get_junction_sides(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_margin(System.IntPtr context, int state, System.IntPtr margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_padding(System.IntPtr context, int state, System.IntPtr padding);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_get_parent(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_get_path(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_property(System.IntPtr context, string property, int state, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_get_scale(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_get_screen(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_get_section(System.IntPtr context, string property);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_get_state(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_get_style_property(System.IntPtr context, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_has_class(System.IntPtr context, string class_name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_has_region(System.IntPtr context, string region_name, System.IntPtr flags_return);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_invalidate(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_list_classes(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_list_regions(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_lookup_color(System.IntPtr context, string color_name, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_context_lookup_icon_set(System.IntPtr context, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_notify_state_change(System.IntPtr context, System.IntPtr window, System.IntPtr region_id, int state, int state_value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_pop_animatable_region(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_push_animatable_region(System.IntPtr context, System.IntPtr region_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_remove_class(System.IntPtr context, string class_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_remove_provider(System.IntPtr context, System.IntPtr provider);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_remove_region(System.IntPtr context, string region_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_restore(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_save(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_scroll_animations(System.IntPtr context, System.IntPtr window, int dx, int dy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_background(System.IntPtr context, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_direction(System.IntPtr context, int direction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_frame_clock(System.IntPtr context, System.IntPtr frame_clock);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_junction_sides(System.IntPtr context, int sides);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_parent(System.IntPtr context, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_path(System.IntPtr context, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_scale(System.IntPtr context, int scale);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_screen(System.IntPtr context, System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_context_set_state(System.IntPtr context, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_context_state_is_running(System.IntPtr context, int state, System.IntPtr progress);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_style_context_to_string(System.IntPtr context, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_grid_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_attach(System.IntPtr grid, System.IntPtr child, int left, int top, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_attach_next_to(System.IntPtr grid, System.IntPtr child, System.IntPtr sibling, int side, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_grid_get_baseline_row(System.IntPtr grid);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_grid_get_child_at(System.IntPtr grid, int left, int top);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_grid_get_column_homogeneous(System.IntPtr grid);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_grid_get_column_spacing(System.IntPtr grid);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_grid_get_row_baseline_position(System.IntPtr grid, int row);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_grid_get_row_homogeneous(System.IntPtr grid);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_grid_get_row_spacing(System.IntPtr grid);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_insert_column(System.IntPtr grid, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_insert_next_to(System.IntPtr grid, System.IntPtr sibling, int side);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_insert_row(System.IntPtr grid, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_remove_column(System.IntPtr grid, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_remove_row(System.IntPtr grid, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_set_baseline_row(System.IntPtr grid, int row);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_set_column_homogeneous(System.IntPtr grid, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_set_column_spacing(System.IntPtr grid, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_set_row_baseline_position(System.IntPtr grid, int row, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_set_row_homogeneous(System.IntPtr grid, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_grid_set_row_spacing(System.IntPtr grid, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hbox_new(int homogeneous, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hbutton_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paned_new(int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paned_add1(System.IntPtr paned, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paned_add2(System.IntPtr paned, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paned_get_child1(System.IntPtr paned);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paned_get_child2(System.IntPtr paned);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paned_get_handle_window(System.IntPtr paned);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_paned_get_position(System.IntPtr paned);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_paned_get_wide_handle(System.IntPtr paned);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paned_pack1(System.IntPtr paned, System.IntPtr child, int resize, int shrink);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paned_pack2(System.IntPtr paned, System.IntPtr child, int resize, int shrink);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paned_set_position(System.IntPtr paned, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paned_set_wide_handle(System.IntPtr paned, int wide);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hpaned_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hsv_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_hsv_to_rgb(double h, double s, double v, System.IntPtr r, System.IntPtr g, System.IntPtr b);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_hsv_get_color(System.IntPtr hsv, System.IntPtr h, System.IntPtr s, System.IntPtr v);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_hsv_get_metrics(System.IntPtr hsv, System.IntPtr size, System.IntPtr ring_width);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_hsv_is_adjusting(System.IntPtr hsv);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_hsv_set_color(System.IntPtr hsv, double h, double s, double v);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_hsv_set_metrics(System.IntPtr hsv, int size, int ring_width);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_new(int orientation, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_new_with_range(int orientation, double min, double max, double step);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_add_mark(System.IntPtr scale, double value, int position, string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_clear_marks(System.IntPtr scale);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scale_get_digits(System.IntPtr scale);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scale_get_draw_value(System.IntPtr scale);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scale_get_has_origin(System.IntPtr scale);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_get_layout(System.IntPtr scale);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_get_layout_offsets(System.IntPtr scale, System.IntPtr x, System.IntPtr y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scale_get_value_pos(System.IntPtr scale);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_set_digits(System.IntPtr scale, int digits);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_set_draw_value(System.IntPtr scale, int draw_value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_set_has_origin(System.IntPtr scale, int has_origin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_set_value_pos(System.IntPtr scale, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hscale_new(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hscale_new_with_range(double min, double max, double step);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrollbar_new(int orientation, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hscrollbar_new(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_separator_new(int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_hseparator_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_handle_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_handle_box_get_child_detached(System.IntPtr handle_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_handle_box_get_handle_position(System.IntPtr handle_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_handle_box_get_shadow_type(System.IntPtr handle_box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_handle_box_get_snap_edge(System.IntPtr handle_box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_handle_box_set_handle_position(System.IntPtr handle_box, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_handle_box_set_shadow_type(System.IntPtr handle_box, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_handle_box_set_snap_edge(System.IntPtr handle_box, int edge);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_header_bar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_header_bar_get_custom_title(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_header_bar_get_decoration_layout(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_header_bar_get_has_subtitle(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_header_bar_get_show_close_button(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_header_bar_get_subtitle(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_header_bar_get_title(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_pack_end(System.IntPtr bar, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_pack_start(System.IntPtr bar, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_set_custom_title(System.IntPtr bar, System.IntPtr title_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_set_decoration_layout(System.IntPtr bar, string layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_set_has_subtitle(System.IntPtr bar, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_set_show_close_button(System.IntPtr bar, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_set_subtitle(System.IntPtr bar, string subtitle);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_header_bar_set_title(System.IntPtr bar, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_im_context_delete_surrounding(System.IntPtr context, int offset, int n_chars);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_im_context_filter_keypress(System.IntPtr context, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_focus_in(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_focus_out(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_get_preedit_string(System.IntPtr context, string str, System.IntPtr attrs, System.IntPtr cursor_pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_im_context_get_surrounding(System.IntPtr context, string text, System.IntPtr cursor_index);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_reset(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_set_client_window(System.IntPtr context, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_set_cursor_location(System.IntPtr context, System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_set_surrounding(System.IntPtr context, string text, int len, int cursor_index);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_set_use_preedit(System.IntPtr context, int use_preedit);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_im_context_simple_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_simple_add_compose_file(System.IntPtr context_simple, string compose_file);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_context_simple_add_table(System.IntPtr context_simple, System.IntPtr data, int max_seq_len, int n_seqs);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_im_multicontext_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_multicontext_append_menuitems(System.IntPtr context, System.IntPtr menushell);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_im_multicontext_get_context_id(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_im_multicontext_set_context_id(System.IntPtr context, string context_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_activate_item(System.IntPtr menu_shell, System.IntPtr menu_item, int force_deactivate);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_append(System.IntPtr menu_shell, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_bind_model(System.IntPtr menu_shell, System.IntPtr model, string action_namespace, int with_separators);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_cancel(System.IntPtr menu_shell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_deactivate(System.IntPtr menu_shell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_deselect(System.IntPtr menu_shell);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_shell_get_parent_shell(System.IntPtr menu_shell);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_shell_get_selected_item(System.IntPtr menu_shell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_shell_get_take_focus(System.IntPtr menu_shell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_insert(System.IntPtr menu_shell, System.IntPtr child, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_prepend(System.IntPtr menu_shell, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_select_first(System.IntPtr menu_shell, int search_sensitive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_select_item(System.IntPtr menu_shell, System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_shell_set_take_focus(System.IntPtr menu_shell, int take_focus);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_factory_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_factory_lookup_default(string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_factory_add(System.IntPtr factory, string stock_id, System.IntPtr icon_set);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_factory_add_default(System.IntPtr factory);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_factory_lookup(System.IntPtr factory, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_factory_remove_default(System.IntPtr factory);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_set_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_set_new_from_pixbuf(System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_set_add_source(System.IntPtr icon_set, System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_set_copy(System.IntPtr icon_set);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_set_get_sizes(System.IntPtr icon_set, System.IntPtr sizes, System.IntPtr n_sizes);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_set_ref(System.IntPtr icon_set);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_set_render_icon(System.IntPtr icon_set, System.IntPtr style, int direction, int state, int size, System.IntPtr widget, string detail);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_set_render_icon_pixbuf(System.IntPtr icon_set, System.IntPtr context, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_set_render_icon_surface(System.IntPtr icon_set, System.IntPtr context, int size, int scale, System.IntPtr for_window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_set_unref(System.IntPtr icon_set);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_new_for_pixbuf(System.IntPtr icon_theme, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_copy(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_info_free(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_info_get_attach_points(System.IntPtr icon_info, System.IntPtr points, System.IntPtr n_points);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_info_get_base_scale(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_info_get_base_size(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_get_builtin_pixbuf(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_icon_info_get_display_name(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_info_get_embedded_rect(System.IntPtr icon_info, System.IntPtr rectangle);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_get_filename(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_info_is_symbolic(System.IntPtr icon_info);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_icon(System.IntPtr icon_info, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_info_load_icon_async(System.IntPtr icon_info, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_icon_finish(System.IntPtr icon_info, System.IntPtr res, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_surface(System.IntPtr icon_info, System.IntPtr for_window, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_symbolic(System.IntPtr icon_info, System.IntPtr fg, System.IntPtr success_color, System.IntPtr warning_color, System.IntPtr error_color, System.IntPtr was_symbolic, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_info_load_symbolic_async(System.IntPtr icon_info, System.IntPtr fg, System.IntPtr success_color, System.IntPtr warning_color, System.IntPtr error_color, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_symbolic_finish(System.IntPtr icon_info, System.IntPtr res, System.IntPtr was_symbolic, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_symbolic_for_context(System.IntPtr icon_info, System.IntPtr context, System.IntPtr was_symbolic, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_info_load_symbolic_for_context_async(System.IntPtr icon_info, System.IntPtr context, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_symbolic_for_context_finish(System.IntPtr icon_info, System.IntPtr res, System.IntPtr was_symbolic, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_info_load_symbolic_for_style(System.IntPtr icon_info, System.IntPtr style, int state, System.IntPtr was_symbolic, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_info_set_raw_coordinates(System.IntPtr icon_info, int raw_coordinates);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_add_builtin_icon(string icon_name, int size, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_get_default();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_get_for_screen(System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_add_resource_path(System.IntPtr icon_theme, string path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_append_search_path(System.IntPtr icon_theme, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_choose_icon(System.IntPtr icon_theme, System.IntPtr icon_names, int size, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_choose_icon_for_scale(System.IntPtr icon_theme, System.IntPtr icon_names, int size, int scale, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_icon_theme_get_example_icon_name(System.IntPtr icon_theme);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_get_icon_sizes(System.IntPtr icon_theme, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_get_search_path(System.IntPtr icon_theme, System.IntPtr path, System.IntPtr n_elements);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_theme_has_icon(System.IntPtr icon_theme, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_list_contexts(System.IntPtr icon_theme);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_list_icons(System.IntPtr icon_theme, string context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_load_icon(System.IntPtr icon_theme, string icon_name, int size, int flags, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_load_icon_for_scale(System.IntPtr icon_theme, string icon_name, int size, int scale, int flags, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_load_surface(System.IntPtr icon_theme, string icon_name, int size, int scale, System.IntPtr for_window, int flags, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_lookup_by_gicon(System.IntPtr icon_theme, System.IntPtr icon, int size, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_lookup_by_gicon_for_scale(System.IntPtr icon_theme, System.IntPtr icon, int size, int scale, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_lookup_icon(System.IntPtr icon_theme, string icon_name, int size, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_theme_lookup_icon_for_scale(System.IntPtr icon_theme, string icon_name, int size, int scale, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_prepend_search_path(System.IntPtr icon_theme, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_theme_rescan_if_needed(System.IntPtr icon_theme);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_set_custom_theme(System.IntPtr icon_theme, string theme_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_set_screen(System.IntPtr icon_theme, System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_theme_set_search_path(System.IntPtr icon_theme, System.IntPtr path, int n_elements);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_apply_default_background(System.IntPtr style, System.IntPtr cr, System.IntPtr window, int state_type, int x, int y, int width, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_attach(System.IntPtr style, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_copy(System.IntPtr style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_detach(System.IntPtr style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_get_style_property(System.IntPtr style, ulong widget_type, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_has_context(System.IntPtr style);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_style_lookup_color(System.IntPtr style, string color_name, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_lookup_icon_set(System.IntPtr style, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_style_render_icon(System.IntPtr style, System.IntPtr source, int direction, int state, int size, System.IntPtr widget, string detail);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_style_set_background(System.IntPtr style, System.IntPtr window, int state_type);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_source_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_source_copy(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_free(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_source_get_direction(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_source_get_direction_wildcarded(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_source_get_filename(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_icon_source_get_icon_name(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_source_get_pixbuf(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_source_get_size(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_source_get_size_wildcarded(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_source_get_state(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_source_get_state_wildcarded(System.IntPtr source);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_direction(System.IntPtr source, int direction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_direction_wildcarded(System.IntPtr source, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_filename(System.IntPtr source, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_icon_name(System.IntPtr source, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_pixbuf(System.IntPtr source, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_size(System.IntPtr source, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_size_wildcarded(System.IntPtr source, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_state(System.IntPtr source, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_source_set_state_wildcarded(System.IntPtr source, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_settings_get_default();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_settings_get_for_screen(System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_settings_install_property(System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_settings_install_property_parser(System.IntPtr pspec, System.IntPtr parser);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_settings_reset_property(System.IntPtr settings, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_settings_set_double_property(System.IntPtr settings, string name, double v_double, string origin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_settings_set_long_property(System.IntPtr settings, string name, long v_long, string origin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_settings_set_property_value(System.IntPtr settings, string name, System.IntPtr svalue);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_settings_set_string_property(System.IntPtr settings, string name, string v_string, string origin);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_icon_theme_error_quark();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrollable_get_border(System.IntPtr scrollable, System.IntPtr border);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrollable_get_hadjustment(System.IntPtr scrollable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrollable_get_hscroll_policy(System.IntPtr scrollable);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrollable_get_vadjustment(System.IntPtr scrollable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrollable_get_vscroll_policy(System.IntPtr scrollable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrollable_set_hadjustment(System.IntPtr scrollable, System.IntPtr hadjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrollable_set_hscroll_policy(System.IntPtr scrollable, int policy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrollable_set_vadjustment(System.IntPtr scrollable, System.IntPtr vadjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrollable_set_vscroll_policy(System.IntPtr scrollable, int policy);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_view_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_view_new_with_area(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_view_new_with_model(System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_convert_widget_to_bin_window_coords(System.IntPtr icon_view, int wx, int wy, System.IntPtr bx, System.IntPtr by);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_view_create_drag_icon(System.IntPtr icon_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_enable_model_drag_dest(System.IntPtr icon_view, System.IntPtr targets, int n_targets, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_enable_model_drag_source(System.IntPtr icon_view, int start_button_mask, System.IntPtr targets, int n_targets, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_activate_on_single_click(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_cell_rect(System.IntPtr icon_view, System.IntPtr path, System.IntPtr cell, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_column_spacing(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_columns(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_cursor(System.IntPtr icon_view, System.IntPtr path, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_dest_item_at_pos(System.IntPtr icon_view, int drag_x, int drag_y, System.IntPtr path, System.IntPtr pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_get_drag_dest_item(System.IntPtr icon_view, System.IntPtr path, System.IntPtr pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_item_at_pos(System.IntPtr icon_view, int x, int y, System.IntPtr path, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_item_column(System.IntPtr icon_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_item_orientation(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_item_padding(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_item_row(System.IntPtr icon_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_item_width(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_margin(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_markup_column(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_view_get_model(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_view_get_path_at_pos(System.IntPtr icon_view, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_pixbuf_column(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_reorderable(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_row_spacing(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_icon_view_get_selected_items(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_selection_mode(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_spacing(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_text_column(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_tooltip_column(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_tooltip_context(System.IntPtr icon_view, System.IntPtr x, System.IntPtr y, int keyboard_tip, System.IntPtr model, System.IntPtr path, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_get_visible_range(System.IntPtr icon_view, System.IntPtr start_path, System.IntPtr end_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_item_activated(System.IntPtr icon_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_icon_view_path_is_selected(System.IntPtr icon_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_scroll_to_path(System.IntPtr icon_view, System.IntPtr path, int use_align, float row_align, float col_align);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_select_all(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_select_path(System.IntPtr icon_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_selected_foreach(System.IntPtr icon_view, System.IntPtr func, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_activate_on_single_click(System.IntPtr icon_view, int single);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_column_spacing(System.IntPtr icon_view, int column_spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_columns(System.IntPtr icon_view, int columns);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_cursor(System.IntPtr icon_view, System.IntPtr path, System.IntPtr cell, int start_editing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_drag_dest_item(System.IntPtr icon_view, System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_item_orientation(System.IntPtr icon_view, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_item_padding(System.IntPtr icon_view, int item_padding);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_item_width(System.IntPtr icon_view, int item_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_margin(System.IntPtr icon_view, int margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_markup_column(System.IntPtr icon_view, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_model(System.IntPtr icon_view, System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_pixbuf_column(System.IntPtr icon_view, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_reorderable(System.IntPtr icon_view, int reorderable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_row_spacing(System.IntPtr icon_view, int row_spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_selection_mode(System.IntPtr icon_view, int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_spacing(System.IntPtr icon_view, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_text_column(System.IntPtr icon_view, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_tooltip_cell(System.IntPtr icon_view, System.IntPtr tooltip, System.IntPtr path, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_tooltip_column(System.IntPtr icon_view, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_set_tooltip_item(System.IntPtr icon_view, System.IntPtr tooltip, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_unselect_all(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_unselect_path(System.IntPtr icon_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_unset_model_drag_dest(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_icon_view_unset_model_drag_source(System.IntPtr icon_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_trigger_tooltip_query(System.IntPtr display);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_custom(System.IntPtr tooltip, System.IntPtr custom_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_icon(System.IntPtr tooltip, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_icon_from_gicon(System.IntPtr tooltip, System.IntPtr gicon, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_icon_from_icon_name(System.IntPtr tooltip, string icon_name, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_icon_from_stock(System.IntPtr tooltip, string stock_id, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_markup(System.IntPtr tooltip, string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_text(System.IntPtr tooltip, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tooltip_set_tip_area(System.IntPtr tooltip, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_animation(System.IntPtr animation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_file(System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_gicon(System.IntPtr icon, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_icon_name(string icon_name, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_icon_set(System.IntPtr icon_set, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_pixbuf(System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_resource(string resource_path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_stock(string stock_id, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_new_from_surface(System.IntPtr surface);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_clear(System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_get_animation(System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_get_gicon(System.IntPtr image, System.IntPtr gicon, System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_get_icon_name(System.IntPtr image, string icon_name, System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_get_icon_set(System.IntPtr image, System.IntPtr icon_set, System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_get_pixbuf(System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_image_get_pixel_size(System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_get_stock(System.IntPtr image, string stock_id, System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_image_get_storage_type(System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_animation(System.IntPtr image, System.IntPtr animation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_file(System.IntPtr image, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_gicon(System.IntPtr image, System.IntPtr icon, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_icon_name(System.IntPtr image, string icon_name, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_icon_set(System.IntPtr image, System.IntPtr icon_set, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_pixbuf(System.IntPtr image, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_resource(System.IntPtr image, string resource_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_stock(System.IntPtr image, string stock_id, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_from_surface(System.IntPtr image, System.IntPtr surface);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_set_pixel_size(System.IntPtr image, int pixel_size);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_menu_item_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_menu_item_new_from_stock(string stock_id, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_menu_item_new_with_label(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_menu_item_new_with_mnemonic(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_image_menu_item_get_always_show_image(System.IntPtr image_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_image_menu_item_get_image(System.IntPtr image_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_image_menu_item_get_use_stock(System.IntPtr image_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_menu_item_set_accel_group(System.IntPtr image_menu_item, System.IntPtr accel_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_menu_item_set_always_show_image(System.IntPtr image_menu_item, int always_show);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_menu_item_set_image(System.IntPtr image_menu_item, System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_image_menu_item_set_use_stock(System.IntPtr image_menu_item, int use_stock);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_info_bar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_info_bar_add_action_widget(System.IntPtr info_bar, System.IntPtr child, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_info_bar_add_button(System.IntPtr info_bar, string button_text, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_info_bar_get_action_area(System.IntPtr info_bar);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_info_bar_get_content_area(System.IntPtr info_bar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_info_bar_get_message_type(System.IntPtr info_bar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_info_bar_get_show_close_button(System.IntPtr info_bar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_info_bar_response(System.IntPtr info_bar, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_info_bar_set_default_response(System.IntPtr info_bar, int response_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_info_bar_set_message_type(System.IntPtr info_bar, int message_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_info_bar_set_response_sensitive(System.IntPtr info_bar, int response_id, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_info_bar_set_show_close_button(System.IntPtr info_bar, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_invisible_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_invisible_new_for_screen(System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_invisible_get_screen(System.IntPtr invisible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_invisible_set_screen(System.IntPtr invisible, System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_layout_new(System.IntPtr hadjustment, System.IntPtr vadjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_layout_get_bin_window(System.IntPtr layout);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_layout_get_hadjustment(System.IntPtr layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_layout_get_size(System.IntPtr layout, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_layout_get_vadjustment(System.IntPtr layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_layout_move(System.IntPtr layout, System.IntPtr child_widget, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_layout_put(System.IntPtr layout, System.IntPtr child_widget, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_layout_set_hadjustment(System.IntPtr layout, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_layout_set_size(System.IntPtr layout, uint width, uint height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_layout_set_vadjustment(System.IntPtr layout, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_level_bar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_level_bar_new_for_interval(double min_value, double max_value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_level_bar_add_offset_value(System.IntPtr self, string name, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_level_bar_get_inverted(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_level_bar_get_max_value(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_level_bar_get_min_value(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_level_bar_get_mode(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_level_bar_get_offset_value(System.IntPtr self, string name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_level_bar_get_value(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_level_bar_remove_offset_value(System.IntPtr self, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_level_bar_set_inverted(System.IntPtr self, int inverted);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_level_bar_set_max_value(System.IntPtr self, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_level_bar_set_min_value(System.IntPtr self, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_level_bar_set_mode(System.IntPtr self, int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_level_bar_set_value(System.IntPtr self, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_link_button_new(string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_link_button_new_with_label(string uri, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_link_button_get_uri(System.IntPtr link_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_link_button_get_visited(System.IntPtr link_button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_link_button_set_uri(System.IntPtr link_button, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_link_button_set_visited(System.IntPtr link_button, int visited);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_bind_model(System.IntPtr box, System.IntPtr model, System.IntPtr create_widget_func, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_drag_highlight_row(System.IntPtr box, System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_drag_unhighlight_row(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_box_get_activate_on_single_click(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_get_adjustment(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_get_row_at_index(System.IntPtr box, int index_);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_get_row_at_y(System.IntPtr box, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_get_selected_row(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_get_selected_rows(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_box_get_selection_mode(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_insert(System.IntPtr box, System.IntPtr child, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_invalidate_filter(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_invalidate_headers(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_invalidate_sort(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_prepend(System.IntPtr box, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_select_all(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_select_row(System.IntPtr box, System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_selected_foreach(System.IntPtr box, System.IntPtr func, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_set_activate_on_single_click(System.IntPtr box, int single);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_set_adjustment(System.IntPtr box, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_set_filter_func(System.IntPtr box, System.IntPtr filter_func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_set_header_func(System.IntPtr box, System.IntPtr update_header, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_set_placeholder(System.IntPtr box, System.IntPtr placeholder);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_set_selection_mode(System.IntPtr box, int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_set_sort_func(System.IntPtr box, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_unselect_all(System.IntPtr box);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_unselect_row(System.IntPtr box, System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_row_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_row_changed(System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_box_row_get_activatable(System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_box_row_get_header(System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_box_row_get_index(System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_box_row_get_selectable(System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_box_row_is_selected(System.IntPtr row);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_row_set_activatable(System.IntPtr row, int activatable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_row_set_header(System.IntPtr row, System.IntPtr header);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_box_row_set_selectable(System.IntPtr row, int selectable);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_drag_dest_drag_data_received(System.IntPtr drag_dest, System.IntPtr dest, System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_drag_dest_row_drop_possible(System.IntPtr drag_dest, System.IntPtr dest_path, System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_drag_source_drag_data_delete(System.IntPtr drag_source, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_drag_source_drag_data_get(System.IntPtr drag_source, System.IntPtr path, System.IntPtr selection_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_drag_source_row_draggable(System.IntPtr drag_source, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_sortable_get_sort_column_id(System.IntPtr sortable, System.IntPtr sort_column_id, System.IntPtr order);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_sortable_has_default_sort_func(System.IntPtr sortable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_sortable_set_default_sort_func(System.IntPtr sortable, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_sortable_set_sort_column_id(System.IntPtr sortable, int sort_column_id, int order);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_sortable_set_sort_func(System.IntPtr sortable, int sort_column_id, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_sortable_sort_column_changed(System.IntPtr sortable);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_list_store_newv(int n_columns, System.IntPtr types);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_append(System.IntPtr list_store, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_clear(System.IntPtr list_store);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_insert(System.IntPtr list_store, System.IntPtr iter, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_insert_after(System.IntPtr list_store, System.IntPtr iter, System.IntPtr sibling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_insert_before(System.IntPtr list_store, System.IntPtr iter, System.IntPtr sibling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_insert_with_valuesv(System.IntPtr list_store, System.IntPtr iter, int position, System.IntPtr columns, System.IntPtr values, int n_values);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_store_iter_is_valid(System.IntPtr list_store, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_move_after(System.IntPtr store, System.IntPtr iter, System.IntPtr position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_move_before(System.IntPtr store, System.IntPtr iter, System.IntPtr position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_prepend(System.IntPtr list_store, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_list_store_remove(System.IntPtr list_store, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_reorder(System.IntPtr store, System.IntPtr new_order);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_set_column_types(System.IntPtr list_store, int n_columns, System.IntPtr types);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_set_value(System.IntPtr list_store, System.IntPtr iter, int column, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_set_valuesv(System.IntPtr list_store, System.IntPtr iter, System.IntPtr columns, System.IntPtr values, int n_values);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_list_store_swap(System.IntPtr store, System.IntPtr a, System.IntPtr b);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_lock_button_new(System.IntPtr permission);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_lock_button_get_permission(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_lock_button_set_permission(System.IntPtr button, System.IntPtr permission);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_bar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_bar_new_from_model(System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_bar_get_child_pack_direction(System.IntPtr menubar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_bar_get_pack_direction(System.IntPtr menubar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_bar_set_child_pack_direction(System.IntPtr menubar, int child_pack_dir);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_bar_set_pack_direction(System.IntPtr menubar, int pack_dir);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_button_get_align_widget(System.IntPtr menu_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_button_get_direction(System.IntPtr menu_button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_button_get_menu_model(System.IntPtr menu_button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_button_get_popover(System.IntPtr menu_button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_button_get_popup(System.IntPtr menu_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_menu_button_get_use_popover(System.IntPtr menu_button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_button_set_align_widget(System.IntPtr menu_button, System.IntPtr align_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_button_set_direction(System.IntPtr menu_button, int direction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_button_set_menu_model(System.IntPtr menu_button, System.IntPtr menu_model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_button_set_popover(System.IntPtr menu_button, System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_button_set_popup(System.IntPtr menu_button, System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_button_set_use_popover(System.IntPtr menu_button, int use_popover);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_popover_new(System.IntPtr relative_to);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_popover_new_from_model(System.IntPtr relative_to, System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_bind_model(System.IntPtr popover, System.IntPtr model, string action_namespace);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_popover_get_constrain_to(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_popover_get_default_widget(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_popover_get_modal(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_popover_get_pointing_to(System.IntPtr popover, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_popover_get_position(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_popover_get_relative_to(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_popover_get_transitions_enabled(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_popdown(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_popup(System.IntPtr popover);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_set_constrain_to(System.IntPtr popover, int constraint);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_set_default_widget(System.IntPtr popover, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_set_modal(System.IntPtr popover, int modal);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_set_pointing_to(System.IntPtr popover, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_set_position(System.IntPtr popover, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_set_relative_to(System.IntPtr popover, System.IntPtr relative_to);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_set_transitions_enabled(System.IntPtr popover, int transitions_enabled);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_ellipsize_mode(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_expand(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_homogeneous(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_icon_size(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_is_important(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_orientation(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_get_proxy_menu_item(System.IntPtr tool_item, string menu_item_id);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_relief_style(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern float gtk_tool_item_get_text_alignment(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_text_orientation(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_get_text_size_group(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_toolbar_style(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_use_drag_window(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_visible_horizontal(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_get_visible_vertical(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_rebuild_menu(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_retrieve_proxy_menu_item(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_expand(System.IntPtr tool_item, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_homogeneous(System.IntPtr tool_item, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_is_important(System.IntPtr tool_item, int is_important);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_proxy_menu_item(System.IntPtr tool_item, string menu_item_id, System.IntPtr menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_tooltip_markup(System.IntPtr tool_item, string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_tooltip_text(System.IntPtr tool_item, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_use_drag_window(System.IntPtr tool_item, int use_drag_window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_visible_horizontal(System.IntPtr tool_item, int visible_horizontal);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_set_visible_vertical(System.IntPtr tool_item, int visible_vertical);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_toolbar_reconfigured(System.IntPtr tool_item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_tool_button_new(System.IntPtr icon_widget, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_tool_button_new_from_stock(string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_menu_tool_button_get_menu(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_tool_button_set_arrow_tooltip_markup(System.IntPtr button, string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_tool_button_set_arrow_tooltip_text(System.IntPtr button, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_menu_tool_button_set_menu(System.IntPtr button, System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_button_new(System.IntPtr icon_widget, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_button_new_from_stock(string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_tool_button_get_icon_name(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_button_get_icon_widget(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_tool_button_get_label(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_button_get_label_widget(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_tool_button_get_stock_id(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_button_get_use_underline(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_button_set_icon_name(System.IntPtr button, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_button_set_icon_widget(System.IntPtr button, System.IntPtr icon_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_button_set_label(System.IntPtr button, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_button_set_label_widget(System.IntPtr button, System.IntPtr label_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_button_set_stock_id(System.IntPtr button, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_button_set_use_underline(System.IntPtr button, int use_underline);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_message_dialog_get_image(System.IntPtr dialog);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_message_dialog_get_message_area(System.IntPtr message_dialog);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_message_dialog_set_image(System.IntPtr dialog, System.IntPtr image);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_message_dialog_set_markup(System.IntPtr message_dialog, string str);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_model_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_mount_operation_new(System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_mount_operation_get_parent(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_mount_operation_get_screen(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_mount_operation_is_showing(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_mount_operation_set_parent(System.IntPtr op, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_mount_operation_set_screen(System.IntPtr op, System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_notebook_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_append_page(System.IntPtr notebook, System.IntPtr child, System.IntPtr tab_label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_append_page_menu(System.IntPtr notebook, System.IntPtr child, System.IntPtr tab_label, System.IntPtr menu_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_detach_tab(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_notebook_get_action_widget(System.IntPtr notebook, int pack_type);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_current_page(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_notebook_get_group_name(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_notebook_get_menu_label(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_notebook_get_menu_label_text(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_n_pages(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_notebook_get_nth_page(System.IntPtr notebook, int page_num);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_scrollable(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_show_border(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_show_tabs(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_tab_detachable(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern ushort gtk_notebook_get_tab_hborder(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_notebook_get_tab_label(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_notebook_get_tab_label_text(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_tab_pos(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_get_tab_reorderable(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern ushort gtk_notebook_get_tab_vborder(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_insert_page(System.IntPtr notebook, System.IntPtr child, System.IntPtr tab_label, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_insert_page_menu(System.IntPtr notebook, System.IntPtr child, System.IntPtr tab_label, System.IntPtr menu_label, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_next_page(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_page_num(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_popup_disable(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_popup_enable(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_prepend_page(System.IntPtr notebook, System.IntPtr child, System.IntPtr tab_label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_notebook_prepend_page_menu(System.IntPtr notebook, System.IntPtr child, System.IntPtr tab_label, System.IntPtr menu_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_prev_page(System.IntPtr notebook);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_remove_page(System.IntPtr notebook, int page_num);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_reorder_child(System.IntPtr notebook, System.IntPtr child, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_action_widget(System.IntPtr notebook, System.IntPtr widget, int pack_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_current_page(System.IntPtr notebook, int page_num);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_group_name(System.IntPtr notebook, string group_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_menu_label(System.IntPtr notebook, System.IntPtr child, System.IntPtr menu_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_menu_label_text(System.IntPtr notebook, System.IntPtr child, string menu_text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_scrollable(System.IntPtr notebook, int scrollable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_show_border(System.IntPtr notebook, int show_border);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_show_tabs(System.IntPtr notebook, int show_tabs);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_tab_detachable(System.IntPtr notebook, System.IntPtr child, int detachable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_tab_label(System.IntPtr notebook, System.IntPtr child, System.IntPtr tab_label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_tab_label_text(System.IntPtr notebook, System.IntPtr child, string tab_text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_tab_pos(System.IntPtr notebook, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_set_tab_reorderable(System.IntPtr notebook, System.IntPtr child, int reorderable);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_notebook_page_accessible_new(System.IntPtr notebook, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_notebook_page_accessible_invalidate(System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_numerable_icon_new(System.IntPtr base_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_numerable_icon_new_with_style_context(System.IntPtr base_icon, System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_numerable_icon_get_background_gicon(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_numerable_icon_get_background_icon_name(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_numerable_icon_get_count(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_numerable_icon_get_label(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_numerable_icon_get_style_context(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_numerable_icon_set_background_gicon(System.IntPtr self, System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_numerable_icon_set_background_icon_name(System.IntPtr self, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_numerable_icon_set_count(System.IntPtr self, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_numerable_icon_set_label(System.IntPtr self, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_numerable_icon_set_style_context(System.IntPtr self, System.IntPtr style);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_offscreen_window_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_offscreen_window_get_pixbuf(System.IntPtr offscreen);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_offscreen_window_get_surface(System.IntPtr offscreen);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_overlay_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_overlay_add_overlay(System.IntPtr overlay, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_overlay_get_overlay_pass_through(System.IntPtr overlay, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_overlay_reorder_overlay(System.IntPtr overlay, System.IntPtr child, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_overlay_set_overlay_pass_through(System.IntPtr overlay, System.IntPtr widget, int pass_through);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_pad_controller_new(System.IntPtr window, System.IntPtr group, System.IntPtr pad);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_pad_controller_set_action(System.IntPtr controller, int type, int index, int mode, string label, string action_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_pad_controller_set_action_entries(System.IntPtr controller, System.IntPtr entries, int n_entries);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_page_setup_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_page_setup_new_from_file(System.IntPtr file_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_page_setup_new_from_gvariant(System.IntPtr variant);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_page_setup_new_from_key_file(System.IntPtr key_file, string group_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_page_setup_copy(System.IntPtr other);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_bottom_margin(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_left_margin(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_page_setup_get_orientation(System.IntPtr setup);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_page_height(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_page_width(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_paper_height(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_page_setup_get_paper_size(System.IntPtr setup);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_paper_width(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_right_margin(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_page_setup_get_top_margin(System.IntPtr setup, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_page_setup_load_file(System.IntPtr setup, System.IntPtr file_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_page_setup_load_key_file(System.IntPtr setup, System.IntPtr key_file, string group_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_set_bottom_margin(System.IntPtr setup, double margin, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_set_left_margin(System.IntPtr setup, double margin, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_set_orientation(System.IntPtr setup, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_set_paper_size(System.IntPtr setup, System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_set_paper_size_and_default_margins(System.IntPtr setup, System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_set_right_margin(System.IntPtr setup, double margin, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_set_top_margin(System.IntPtr setup, double margin, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_page_setup_to_file(System.IntPtr setup, System.IntPtr file_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_page_setup_to_gvariant(System.IntPtr setup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_page_setup_to_key_file(System.IntPtr setup, System.IntPtr key_file, string group_name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_new(string name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_new_custom(string name, string display_name, double width, double height, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_new_from_gvariant(System.IntPtr variant);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_new_from_ipp(string ipp_name, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_new_from_key_file(System.IntPtr key_file, string group_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_new_from_ppd(string ppd_name, string ppd_display_name, double width, double height);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_copy(System.IntPtr other);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paper_size_free(System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_paper_size_get_default_bottom_margin(System.IntPtr size, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_paper_size_get_default_left_margin(System.IntPtr size, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_paper_size_get_default_right_margin(System.IntPtr size, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_paper_size_get_default_top_margin(System.IntPtr size, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_paper_size_get_display_name(System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_paper_size_get_height(System.IntPtr size, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_paper_size_get_name(System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_paper_size_get_ppd_name(System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_paper_size_get_width(System.IntPtr size, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_paper_size_is_custom(System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_paper_size_is_equal(System.IntPtr size1, System.IntPtr size2);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_paper_size_is_ipp(System.IntPtr size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paper_size_set_size(System.IntPtr size, double width, double height, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_to_gvariant(System.IntPtr paper_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_paper_size_to_key_file(System.IntPtr size, System.IntPtr key_file, string group_name);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_paper_size_get_default();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_paper_size_get_paper_sizes(int include_custom);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_places_sidebar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_add_shortcut(System.IntPtr sidebar, System.IntPtr location);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_local_only(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_places_sidebar_get_location(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_places_sidebar_get_nth_bookmark(System.IntPtr sidebar, int n);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_open_flags(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_show_connect_to_server(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_show_desktop(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_show_enter_location(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_show_other_locations(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_show_recent(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_show_starred_location(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_places_sidebar_get_show_trash(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_places_sidebar_list_shortcuts(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_remove_shortcut(System.IntPtr sidebar, System.IntPtr location);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_drop_targets_visible(System.IntPtr sidebar, int visible, System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_local_only(System.IntPtr sidebar, int local_only);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_location(System.IntPtr sidebar, System.IntPtr location);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_open_flags(System.IntPtr sidebar, int flags);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_show_connect_to_server(System.IntPtr sidebar, int show_connect_to_server);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_show_desktop(System.IntPtr sidebar, int show_desktop);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_show_enter_location(System.IntPtr sidebar, int show_enter_location);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_show_other_locations(System.IntPtr sidebar, int show_other_locations);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_show_recent(System.IntPtr sidebar, int show_recent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_show_starred_location(System.IntPtr sidebar, int show_starred_location);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_places_sidebar_set_show_trash(System.IntPtr sidebar, int show_trash);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrolled_window_new(System.IntPtr hadjustment, System.IntPtr vadjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_add_with_viewport(System.IntPtr scrolled_window, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_capture_button_press(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrolled_window_get_hadjustment(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrolled_window_get_hscrollbar(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_kinetic_scrolling(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_max_content_height(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_max_content_width(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_min_content_height(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_min_content_width(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_overlay_scrolling(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_placement(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_get_policy(System.IntPtr scrolled_window, System.IntPtr hscrollbar_policy, System.IntPtr vscrollbar_policy);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_propagate_natural_height(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_propagate_natural_width(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_scrolled_window_get_shadow_type(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrolled_window_get_vadjustment(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scrolled_window_get_vscrollbar(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_capture_button_press(System.IntPtr scrolled_window, int capture_button_press);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_hadjustment(System.IntPtr scrolled_window, System.IntPtr hadjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_kinetic_scrolling(System.IntPtr scrolled_window, int kinetic_scrolling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_max_content_height(System.IntPtr scrolled_window, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_max_content_width(System.IntPtr scrolled_window, int width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_min_content_height(System.IntPtr scrolled_window, int height);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_min_content_width(System.IntPtr scrolled_window, int width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_overlay_scrolling(System.IntPtr scrolled_window, int overlay_scrolling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_placement(System.IntPtr scrolled_window, int window_placement);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_policy(System.IntPtr scrolled_window, int hscrollbar_policy, int vscrollbar_policy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_propagate_natural_height(System.IntPtr scrolled_window, int propagate);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_propagate_natural_width(System.IntPtr scrolled_window, int propagate);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_shadow_type(System.IntPtr scrolled_window, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_set_vadjustment(System.IntPtr scrolled_window, System.IntPtr vadjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scrolled_window_unset_placement(System.IntPtr scrolled_window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_plug_new(ulong socket_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_plug_new_for_display(System.IntPtr display, ulong socket_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_plug_construct(System.IntPtr plug, ulong socket_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_plug_construct_for_display(System.IntPtr plug, System.IntPtr display, ulong socket_id);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_plug_get_embedded(System.IntPtr plug);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_plug_get_id(System.IntPtr plug);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_plug_get_socket_window(System.IntPtr plug);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_popover_menu_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_popover_menu_open_submenu(System.IntPtr popover, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_context_create_pango_context(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_context_create_pango_layout(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_context_get_cairo_context(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_context_get_dpi_x(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_context_get_dpi_y(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_context_get_hard_margins(System.IntPtr context, System.IntPtr top, System.IntPtr bottom, System.IntPtr left, System.IntPtr right);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_context_get_height(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_context_get_page_setup(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_context_get_pango_fontmap(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_context_get_width(System.IntPtr context);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_context_set_cairo_context(System.IntPtr context, System.IntPtr cr, double dpi_x, double dpi_y);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_print_error_quark();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_preview_end_preview(System.IntPtr preview);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_preview_is_selected(System.IntPtr preview, int page_nr);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_preview_render_page(System.IntPtr preview, int page_nr);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_operation_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_cancel(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_draw_page_finish(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_operation_get_default_page_setup(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_get_embed_page_setup(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_get_error(System.IntPtr op, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_get_has_selection(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_get_n_pages_to_print(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_operation_get_print_settings(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_get_status(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_operation_get_status_string(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_get_support_selection(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_is_finished(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_operation_run(System.IntPtr op, int action, System.IntPtr parent, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_allow_async(System.IntPtr op, int allow_async);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_current_page(System.IntPtr op, int current_page);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_custom_tab_label(System.IntPtr op, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_default_page_setup(System.IntPtr op, System.IntPtr default_page_setup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_defer_drawing(System.IntPtr op);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_embed_page_setup(System.IntPtr op, int embed);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_export_filename(System.IntPtr op, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_has_selection(System.IntPtr op, int has_selection);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_job_name(System.IntPtr op, string job_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_n_pages(System.IntPtr op, int n_pages);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_print_settings(System.IntPtr op, System.IntPtr print_settings);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_show_progress(System.IntPtr op, int show_progress);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_support_selection(System.IntPtr op, int support_selection);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_track_print_status(System.IntPtr op, int track_status);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_unit(System.IntPtr op, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_operation_set_use_full_page(System.IntPtr op, int full_page);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_new_from_file(System.IntPtr file_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_new_from_gvariant(System.IntPtr variant);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_new_from_key_file(System.IntPtr key_file, string group_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_copy(System.IntPtr other);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_foreach(System.IntPtr settings, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_settings_get(System.IntPtr settings, string key);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_bool(System.IntPtr settings, string key);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_collate(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_settings_get_default_source(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_settings_get_dither(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_settings_get_double(System.IntPtr settings, string key);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_settings_get_double_with_default(System.IntPtr settings, string key, double def);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_duplex(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_settings_get_finishings(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_int(System.IntPtr settings, string key);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_int_with_default(System.IntPtr settings, string key, int def);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_settings_get_length(System.IntPtr settings, string key, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_settings_get_media_type(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_n_copies(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_number_up(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_number_up_layout(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_orientation(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_settings_get_output_bin(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_get_page_ranges(System.IntPtr settings, System.IntPtr num_ranges);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_page_set(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_settings_get_paper_height(System.IntPtr settings, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_get_paper_size(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_settings_get_paper_width(System.IntPtr settings, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_print_pages(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_print_settings_get_printer(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_settings_get_printer_lpi(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_quality(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_resolution(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_resolution_x(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_resolution_y(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_reverse(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_print_settings_get_scale(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_get_use_color(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_has_key(System.IntPtr settings, string key);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_load_file(System.IntPtr settings, System.IntPtr file_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_load_key_file(System.IntPtr settings, System.IntPtr key_file, string group_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set(System.IntPtr settings, string key, string value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_bool(System.IntPtr settings, string key, int value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_collate(System.IntPtr settings, int collate);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_default_source(System.IntPtr settings, string default_source);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_dither(System.IntPtr settings, string dither);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_double(System.IntPtr settings, string key, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_duplex(System.IntPtr settings, int duplex);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_finishings(System.IntPtr settings, string finishings);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_int(System.IntPtr settings, string key, int value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_length(System.IntPtr settings, string key, double value, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_media_type(System.IntPtr settings, string media_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_n_copies(System.IntPtr settings, int num_copies);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_number_up(System.IntPtr settings, int number_up);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_number_up_layout(System.IntPtr settings, int number_up_layout);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_orientation(System.IntPtr settings, int orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_output_bin(System.IntPtr settings, string output_bin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_page_ranges(System.IntPtr settings, System.IntPtr page_ranges, int num_ranges);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_page_set(System.IntPtr settings, int page_set);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_paper_height(System.IntPtr settings, double height, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_paper_size(System.IntPtr settings, System.IntPtr paper_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_paper_width(System.IntPtr settings, double width, int unit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_print_pages(System.IntPtr settings, int pages);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_printer(System.IntPtr settings, string printer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_printer_lpi(System.IntPtr settings, double lpi);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_quality(System.IntPtr settings, int quality);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_resolution(System.IntPtr settings, int resolution);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_resolution_xy(System.IntPtr settings, int resolution_x, int resolution_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_reverse(System.IntPtr settings, int reverse);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_scale(System.IntPtr settings, double scale);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_set_use_color(System.IntPtr settings, int use_color);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_print_settings_to_file(System.IntPtr settings, System.IntPtr file_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_print_settings_to_gvariant(System.IntPtr settings);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_to_key_file(System.IntPtr settings, System.IntPtr key_file, string group_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_print_settings_unset(System.IntPtr settings, string key);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_progress_bar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_progress_bar_get_ellipsize(System.IntPtr pbar);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_progress_bar_get_fraction(System.IntPtr pbar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_progress_bar_get_inverted(System.IntPtr pbar);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_progress_bar_get_pulse_step(System.IntPtr pbar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_progress_bar_get_show_text(System.IntPtr pbar);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_progress_bar_get_text(System.IntPtr pbar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_progress_bar_pulse(System.IntPtr pbar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_progress_bar_set_ellipsize(System.IntPtr pbar, int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_progress_bar_set_fraction(System.IntPtr pbar, double fraction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_progress_bar_set_inverted(System.IntPtr pbar, int inverted);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_progress_bar_set_pulse_step(System.IntPtr pbar, double fraction);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_progress_bar_set_show_text(System.IntPtr pbar, int show_text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_progress_bar_set_text(System.IntPtr pbar, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_action_new(string name, string label, string tooltip, string stock_id, int value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_radio_action_get_current_value(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_action_get_group(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_action_join_group(System.IntPtr action, System.IntPtr group_source);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_action_set_current_value(System.IntPtr action, int current_value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_action_set_group(System.IntPtr action, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toggle_action_new(string name, string label, string tooltip, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toggle_action_get_active(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toggle_action_get_draw_as_radio(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_action_set_active(System.IntPtr action, int is_active);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_action_set_draw_as_radio(System.IntPtr action, int draw_as_radio);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_action_toggled(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_button_new(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_button_new_from_widget(System.IntPtr radio_group_member);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_button_new_with_label(System.IntPtr group, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_button_new_with_label_from_widget(System.IntPtr radio_group_member, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_button_new_with_mnemonic(System.IntPtr group, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_button_new_with_mnemonic_from_widget(System.IntPtr radio_group_member, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_button_get_group(System.IntPtr radio_button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_button_join_group(System.IntPtr radio_button, System.IntPtr group_source);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_button_set_group(System.IntPtr radio_button, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_menu_item_new(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_menu_item_new_from_widget(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_menu_item_new_with_label(System.IntPtr group, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_menu_item_new_with_label_from_widget(System.IntPtr group, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_menu_item_new_with_mnemonic(System.IntPtr group, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_menu_item_new_with_mnemonic_from_widget(System.IntPtr group, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_menu_item_get_group(System.IntPtr radio_menu_item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_menu_item_join_group(System.IntPtr radio_menu_item, System.IntPtr group_source);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_menu_item_set_group(System.IntPtr radio_menu_item, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_tool_button_new(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_tool_button_new_from_stock(System.IntPtr group, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_tool_button_new_from_widget(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_tool_button_new_with_stock_from_widget(System.IntPtr group, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_radio_tool_button_get_group(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_radio_tool_button_set_group(System.IntPtr button, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toggle_tool_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toggle_tool_button_new_from_stock(string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toggle_tool_button_get_active(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toggle_tool_button_set_active(System.IntPtr button, int is_active);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_range_get_adjustment(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_range_get_fill_level(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_flippable(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_inverted(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_lower_stepper_sensitivity(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_min_slider_size(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_get_range_rect(System.IntPtr range, System.IntPtr range_rect);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_restrict_to_fill_level(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_round_digits(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_show_fill_level(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_get_slider_range(System.IntPtr range, System.IntPtr slider_start, System.IntPtr slider_end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_slider_size_fixed(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_range_get_upper_stepper_sensitivity(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_range_get_value(System.IntPtr range);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_adjustment(System.IntPtr range, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_fill_level(System.IntPtr range, double fill_level);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_flippable(System.IntPtr range, int flippable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_increments(System.IntPtr range, double step, double page);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_inverted(System.IntPtr range, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_lower_stepper_sensitivity(System.IntPtr range, int sensitivity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_min_slider_size(System.IntPtr range, int min_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_range(System.IntPtr range, double min, double max);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_restrict_to_fill_level(System.IntPtr range, int restrict_to_fill_level);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_round_digits(System.IntPtr range, int round_digits);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_show_fill_level(System.IntPtr range, int show_fill_level);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_slider_size_fixed(System.IntPtr range, int size_fixed);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_upper_stepper_sensitivity(System.IntPtr range, int sensitivity);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_range_set_value(System.IntPtr range, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_rc_property_parse_border(System.IntPtr pspec, System.IntPtr gstring, System.IntPtr property_value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_rc_property_parse_color(System.IntPtr pspec, System.IntPtr gstring, System.IntPtr property_value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_rc_property_parse_enum(System.IntPtr pspec, System.IntPtr gstring, System.IntPtr property_value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_rc_property_parse_flags(System.IntPtr pspec, System.IntPtr gstring, System.IntPtr property_value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_rc_property_parse_requisition(System.IntPtr pspec, System.IntPtr gstring, System.IntPtr property_value);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_style_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_rc_style_copy(System.IntPtr orig);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_add_filter(System.IntPtr chooser, System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_get_current_item(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_chooser_get_current_uri(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_get_filter(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_get_items(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_limit(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_local_only(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_select_multiple(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_show_icons(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_show_not_found(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_show_private(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_show_tips(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_get_sort_type(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_get_uris(System.IntPtr chooser, System.IntPtr length);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_list_filters(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_remove_filter(System.IntPtr chooser, System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_select_all(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_select_uri(System.IntPtr chooser, string uri, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_set_current_uri(System.IntPtr chooser, string uri, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_filter(System.IntPtr chooser, System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_limit(System.IntPtr chooser, int limit);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_local_only(System.IntPtr chooser, int local_only);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_select_multiple(System.IntPtr chooser, int select_multiple);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_show_icons(System.IntPtr chooser, int show_icons);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_show_not_found(System.IntPtr chooser, int show_not_found);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_show_private(System.IntPtr chooser, int show_private);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_show_tips(System.IntPtr chooser, int show_tips);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_sort_func(System.IntPtr chooser, System.IntPtr sort_func, System.IntPtr sort_data, System.IntPtr data_destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_set_sort_type(System.IntPtr chooser, int sort_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_unselect_all(System.IntPtr chooser);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_unselect_uri(System.IntPtr chooser, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_manager_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_manager_get_default();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_manager_add_full(System.IntPtr manager, string uri, System.IntPtr recent_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_manager_add_item(System.IntPtr manager, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_manager_get_items(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_manager_has_item(System.IntPtr manager, string uri);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_manager_lookup_item(System.IntPtr manager, string uri, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_manager_move_item(System.IntPtr manager, string uri, string new_uri, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_manager_purge_items(System.IntPtr manager, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_manager_remove_item(System.IntPtr manager, string uri, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_action_new(string name, string label, string tooltip, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_action_new_for_manager(string name, string label, string tooltip, string stock_id, System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_action_get_show_numbers(System.IntPtr action);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_action_set_show_numbers(System.IntPtr action, int show_numbers);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_filter_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_add_age(System.IntPtr filter, int days);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_add_application(System.IntPtr filter, string application);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_add_custom(System.IntPtr filter, int needed, System.IntPtr func, System.IntPtr data, System.IntPtr data_destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_add_group(System.IntPtr filter, string group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_add_mime_type(System.IntPtr filter, string mime_type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_add_pattern(System.IntPtr filter, string pattern);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_add_pixbuf_formats(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_filter_filter(System.IntPtr filter, System.IntPtr filter_info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_filter_get_name(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_filter_get_needed(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_filter_set_name(System.IntPtr filter, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_info_create_app_info(System.IntPtr info, string app_name, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_exists(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern long gtk_recent_info_get_added(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_get_age(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_get_application_info(System.IntPtr info, string app_name, string app_exec, System.IntPtr count, System.IntPtr time_);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_info_get_applications(System.IntPtr info, System.IntPtr length);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_info_get_description(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_info_get_display_name(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_info_get_gicon(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_info_get_groups(System.IntPtr info, System.IntPtr length);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_info_get_icon(System.IntPtr info, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_info_get_mime_type(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern long gtk_recent_info_get_modified(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_get_private_hint(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_info_get_short_name(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_info_get_uri(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_info_get_uri_display(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern long gtk_recent_info_get_visited(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_has_application(System.IntPtr info, string app_name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_has_group(System.IntPtr info, string group_name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_is_local(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_recent_info_last_application(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_info_match(System.IntPtr info_a, System.IntPtr info_b);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_info_ref(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_info_unref(System.IntPtr info);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_recent_chooser_error_quark();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_menu_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_menu_new_for_manager(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_recent_chooser_menu_get_show_numbers(System.IntPtr menu);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_recent_chooser_menu_set_show_numbers(System.IntPtr menu, int show_numbers);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_widget_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_recent_chooser_widget_new_for_manager(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_recent_manager_error_quark();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_revealer_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_revealer_get_child_revealed(System.IntPtr revealer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_revealer_get_reveal_child(System.IntPtr revealer);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_revealer_get_transition_duration(System.IntPtr revealer);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_revealer_get_transition_type(System.IntPtr revealer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_revealer_set_reveal_child(System.IntPtr revealer, int reveal_child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_revealer_set_transition_duration(System.IntPtr revealer, uint duration);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_revealer_set_transition_type(System.IntPtr revealer, int transition);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_button_new(int size, double min, double max, double step, System.IntPtr icons);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_button_get_adjustment(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_button_get_minus_button(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_button_get_plus_button(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_scale_button_get_popup(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_scale_button_get_value(System.IntPtr button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_button_set_adjustment(System.IntPtr button, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_button_set_icons(System.IntPtr button, System.IntPtr icons);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_scale_button_set_value(System.IntPtr button, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_search_bar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_search_bar_connect_entry(System.IntPtr bar, System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_search_bar_get_search_mode(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_search_bar_get_show_close_button(System.IntPtr bar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_search_bar_handle_event(System.IntPtr bar, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_search_bar_set_search_mode(System.IntPtr bar, int search_mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_search_bar_set_show_close_button(System.IntPtr bar, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_search_entry_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_search_entry_handle_event(System.IntPtr entry, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_separator_menu_item_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_separator_tool_item_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_separator_tool_item_get_draw(System.IntPtr item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_separator_tool_item_set_draw(System.IntPtr item, int draw);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_shortcut_label_new(string accelerator);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_shortcut_label_get_accelerator(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_shortcut_label_get_disabled_text(System.IntPtr self);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_shortcut_label_set_accelerator(System.IntPtr self, string accelerator);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_shortcut_label_set_disabled_text(System.IntPtr self, string disabled_text);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_size_group_new(int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_size_group_add_widget(System.IntPtr size_group, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_size_group_get_ignore_hidden(System.IntPtr size_group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_size_group_get_mode(System.IntPtr size_group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_size_group_get_widgets(System.IntPtr size_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_size_group_remove_widget(System.IntPtr size_group, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_size_group_set_ignore_hidden(System.IntPtr size_group, int ignore_hidden);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_size_group_set_mode(System.IntPtr size_group, int mode);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_socket_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_socket_add_id(System.IntPtr socket_, ulong window);
        [DllImport("libgtk-3.so.0")]
        public static extern ulong gtk_socket_get_id(System.IntPtr socket_);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_socket_get_plug_window(System.IntPtr socket_);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_spin_button_new(System.IntPtr adjustment, double climb_rate, uint digits);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_spin_button_new_with_range(double min, double max, double step);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_configure(System.IntPtr spin_button, System.IntPtr adjustment, double climb_rate, uint digits);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_spin_button_get_adjustment(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_spin_button_get_digits(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_get_increments(System.IntPtr spin_button, System.IntPtr step, System.IntPtr page);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_spin_button_get_numeric(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_get_range(System.IntPtr spin_button, System.IntPtr min, System.IntPtr max);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_spin_button_get_snap_to_ticks(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_spin_button_get_update_policy(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern double gtk_spin_button_get_value(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_spin_button_get_value_as_int(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_spin_button_get_wrap(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_adjustment(System.IntPtr spin_button, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_digits(System.IntPtr spin_button, uint digits);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_increments(System.IntPtr spin_button, double step, double page);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_numeric(System.IntPtr spin_button, int numeric);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_range(System.IntPtr spin_button, double min, double max);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_snap_to_ticks(System.IntPtr spin_button, int snap_to_ticks);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_update_policy(System.IntPtr spin_button, int policy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_value(System.IntPtr spin_button, double value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_set_wrap(System.IntPtr spin_button, int wrap);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_spin(System.IntPtr spin_button, int direction, double increment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spin_button_update(System.IntPtr spin_button);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_spinner_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spinner_start(System.IntPtr spinner);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_spinner_stop(System.IntPtr spinner);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stack_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_add_named(System.IntPtr stack, System.IntPtr child, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_add_titled(System.IntPtr stack, System.IntPtr child, string name, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stack_get_child_by_name(System.IntPtr stack, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_stack_get_hhomogeneous(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_stack_get_homogeneous(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_stack_get_interpolate_size(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_stack_get_transition_duration(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_stack_get_transition_running(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_stack_get_transition_type(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_stack_get_vhomogeneous(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stack_get_visible_child(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_stack_get_visible_child_name(System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_hhomogeneous(System.IntPtr stack, int hhomogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_homogeneous(System.IntPtr stack, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_interpolate_size(System.IntPtr stack, int interpolate_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_transition_duration(System.IntPtr stack, uint duration);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_transition_type(System.IntPtr stack, int transition);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_vhomogeneous(System.IntPtr stack, int vhomogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_visible_child(System.IntPtr stack, System.IntPtr child);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_visible_child_full(System.IntPtr stack, string name, int transition);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_set_visible_child_name(System.IntPtr stack, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stack_sidebar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stack_sidebar_get_stack(System.IntPtr sidebar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_sidebar_set_stack(System.IntPtr sidebar, System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stack_switcher_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stack_switcher_get_stack(System.IntPtr switcher);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stack_switcher_set_stack(System.IntPtr switcher, System.IntPtr stack);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_new_from_file(System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_new_from_gicon(System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_new_from_icon_name(string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_new_from_pixbuf(System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_new_from_stock(string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_position_menu(System.IntPtr menu, System.IntPtr x, System.IntPtr y, System.IntPtr push_in, System.IntPtr user_data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_status_icon_get_geometry(System.IntPtr status_icon, System.IntPtr screen, System.IntPtr area, System.IntPtr orientation);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_get_gicon(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_status_icon_get_has_tooltip(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_status_icon_get_icon_name(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_get_pixbuf(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_status_icon_get_screen(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_status_icon_get_size(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_status_icon_get_stock(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_status_icon_get_storage_type(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_status_icon_get_title(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_status_icon_get_tooltip_markup(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_status_icon_get_tooltip_text(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_status_icon_get_visible(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_status_icon_get_x11_window_id(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_status_icon_is_embedded(System.IntPtr status_icon);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_from_file(System.IntPtr status_icon, System.IntPtr filename);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_from_gicon(System.IntPtr status_icon, System.IntPtr icon);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_from_icon_name(System.IntPtr status_icon, string icon_name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_from_pixbuf(System.IntPtr status_icon, System.IntPtr pixbuf);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_from_stock(System.IntPtr status_icon, string stock_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_has_tooltip(System.IntPtr status_icon, int has_tooltip);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_name(System.IntPtr status_icon, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_screen(System.IntPtr status_icon, System.IntPtr screen);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_title(System.IntPtr status_icon, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_tooltip_markup(System.IntPtr status_icon, string markup);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_tooltip_text(System.IntPtr status_icon, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_status_icon_set_visible(System.IntPtr status_icon, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_statusbar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_statusbar_get_context_id(System.IntPtr statusbar, string context_description);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_statusbar_get_message_area(System.IntPtr statusbar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_statusbar_pop(System.IntPtr statusbar, uint context_id);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_statusbar_push(System.IntPtr statusbar, uint context_id, string text);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_statusbar_remove(System.IntPtr statusbar, uint context_id, uint message_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_statusbar_remove_all(System.IntPtr statusbar, uint context_id);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_stock_item_copy(System.IntPtr item);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_stock_item_free(System.IntPtr item);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_switch_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_switch_get_active(System.IntPtr sw);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_switch_get_state(System.IntPtr sw);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_switch_set_active(System.IntPtr sw, int is_active);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_switch_set_state(System.IntPtr sw, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_table_new(uint rows, uint columns, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_attach(System.IntPtr table, System.IntPtr child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach, int xoptions, int yoptions, uint xpadding, uint ypadding);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_attach_defaults(System.IntPtr table, System.IntPtr widget, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_table_get_col_spacing(System.IntPtr table, uint column);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_table_get_default_col_spacing(System.IntPtr table);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_table_get_default_row_spacing(System.IntPtr table);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_table_get_homogeneous(System.IntPtr table);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_table_get_row_spacing(System.IntPtr table, uint row);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_get_size(System.IntPtr table, System.IntPtr rows, System.IntPtr columns);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_resize(System.IntPtr table, uint rows, uint columns);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_set_col_spacing(System.IntPtr table, uint column, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_set_col_spacings(System.IntPtr table, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_set_homogeneous(System.IntPtr table, int homogeneous);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_set_row_spacing(System.IntPtr table, uint row, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_table_set_row_spacings(System.IntPtr table, uint spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tearoff_menu_item_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_attributes_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_attributes_copy(System.IntPtr src);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_attributes_copy_values(System.IntPtr src, System.IntPtr dest);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_attributes_ref(System.IntPtr values);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_attributes_unref(System.IntPtr values);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_tag_table_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_tag_table_add(System.IntPtr table, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_tag_table_foreach(System.IntPtr table, System.IntPtr func, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_tag_table_get_size(System.IntPtr table);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_tag_table_lookup(System.IntPtr table, string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_tag_table_remove(System.IntPtr table, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_mark_new(string name, int left_gravity);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_mark_get_buffer(System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_mark_get_deleted(System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_mark_get_left_gravity(System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_text_mark_get_name(System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_mark_get_visible(System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_mark_set_visible(System.IntPtr mark, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_assign(System.IntPtr iter, System.IntPtr other);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_char(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_chars(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_cursor_position(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_cursor_positions(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_find_char(System.IntPtr iter, System.IntPtr pred, System.IntPtr user_data, System.IntPtr limit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_lines(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_search(System.IntPtr iter, string str, int flags, System.IntPtr match_start, System.IntPtr match_end, System.IntPtr limit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_sentence_start(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_sentence_starts(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_to_tag_toggle(System.IntPtr iter, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_visible_cursor_position(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_visible_cursor_positions(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_visible_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_visible_lines(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_visible_word_start(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_visible_word_starts(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_word_start(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_backward_word_starts(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_begins_tag(System.IntPtr iter, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_can_insert(System.IntPtr iter, int default_editability);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_compare(System.IntPtr lhs, System.IntPtr rhs);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_copy(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_editable(System.IntPtr iter, int default_setting);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_ends_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_ends_sentence(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_ends_tag(System.IntPtr iter, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_ends_word(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_equal(System.IntPtr lhs, System.IntPtr rhs);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_char(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_chars(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_cursor_position(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_cursor_positions(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_find_char(System.IntPtr iter, System.IntPtr pred, System.IntPtr user_data, System.IntPtr limit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_lines(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_search(System.IntPtr iter, string str, int flags, System.IntPtr match_start, System.IntPtr match_end, System.IntPtr limit);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_sentence_end(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_sentence_ends(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_forward_to_end(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_to_line_end(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_to_tag_toggle(System.IntPtr iter, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_visible_cursor_position(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_visible_cursor_positions(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_visible_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_visible_lines(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_visible_word_end(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_visible_word_ends(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_word_end(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_forward_word_ends(System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_free(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_attributes(System.IntPtr iter, System.IntPtr values);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_get_buffer(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_bytes_in_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_text_iter_get_char(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_chars_in_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_get_child_anchor(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_get_language(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_line_index(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_line_offset(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_get_marks(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_offset(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_get_pixbuf(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_text_iter_get_slice(System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_get_tags(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_text_iter_get_text(System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_iter_get_toggled_tags(System.IntPtr iter, int toggled_on);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_visible_line_index(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_get_visible_line_offset(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_text_iter_get_visible_slice(System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_text_iter_get_visible_text(System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_has_tag(System.IntPtr iter, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_in_range(System.IntPtr iter, System.IntPtr start, System.IntPtr end);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_inside_sentence(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_inside_word(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_is_cursor_position(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_is_end(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_is_start(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_order(System.IntPtr first, System.IntPtr second);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_set_line(System.IntPtr iter, int line_number);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_set_line_index(System.IntPtr iter, int byte_on_line);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_set_line_offset(System.IntPtr iter, int char_on_line);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_set_offset(System.IntPtr iter, int char_offset);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_set_visible_line_index(System.IntPtr iter, int byte_on_line);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_iter_set_visible_line_offset(System.IntPtr iter, int char_on_line);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_starts_line(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_starts_sentence(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_starts_tag(System.IntPtr iter, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_starts_word(System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_iter_toggles_tag(System.IntPtr iter, System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_tag_new(string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_tag_changed(System.IntPtr tag, int size_changed);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_tag_event(System.IntPtr tag, System.IntPtr event_object, System.IntPtr @event, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_tag_get_priority(System.IntPtr tag);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_tag_set_priority(System.IntPtr tag, int priority);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_child_anchor_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_child_anchor_get_deleted(System.IntPtr anchor);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_child_anchor_get_widgets(System.IntPtr anchor);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_new_with_buffer(System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_add_child_at_anchor(System.IntPtr text_view, System.IntPtr child, System.IntPtr anchor);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_add_child_in_window(System.IntPtr text_view, System.IntPtr child, int which_window, int xpos, int ypos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_backward_display_line(System.IntPtr text_view, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_backward_display_line_start(System.IntPtr text_view, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_buffer_to_window_coords(System.IntPtr text_view, int win, int buffer_x, int buffer_y, System.IntPtr window_x, System.IntPtr window_y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_forward_display_line(System.IntPtr text_view, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_forward_display_line_end(System.IntPtr text_view, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_accepts_tab(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_border_window_size(System.IntPtr text_view, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_bottom_margin(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_get_buffer(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_get_cursor_locations(System.IntPtr text_view, System.IntPtr iter, System.IntPtr strong, System.IntPtr weak);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_cursor_visible(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_get_default_attributes(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_editable(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_get_hadjustment(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_indent(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_input_hints(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_input_purpose(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_iter_at_location(System.IntPtr text_view, System.IntPtr iter, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_iter_at_position(System.IntPtr text_view, System.IntPtr iter, System.IntPtr trailing, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_get_iter_location(System.IntPtr text_view, System.IntPtr iter, System.IntPtr location);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_justification(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_left_margin(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_get_line_at_y(System.IntPtr text_view, System.IntPtr target_iter, int y, System.IntPtr line_top);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_get_line_yrange(System.IntPtr text_view, System.IntPtr iter, System.IntPtr y, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_monospace(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_overwrite(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_pixels_above_lines(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_pixels_below_lines(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_pixels_inside_wrap(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_right_margin(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_get_tabs(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_top_margin(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_get_vadjustment(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_get_visible_rect(System.IntPtr text_view, System.IntPtr visible_rect);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_text_view_get_window(System.IntPtr text_view, int win);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_window_type(System.IntPtr text_view, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_get_wrap_mode(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_im_context_filter_keypress(System.IntPtr text_view, System.IntPtr @event);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_move_child(System.IntPtr text_view, System.IntPtr child, int xpos, int ypos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_move_mark_onscreen(System.IntPtr text_view, System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_move_visually(System.IntPtr text_view, System.IntPtr iter, int count);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_place_cursor_onscreen(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_reset_cursor_blink(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_reset_im_context(System.IntPtr text_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_scroll_mark_onscreen(System.IntPtr text_view, System.IntPtr mark);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_scroll_to_iter(System.IntPtr text_view, System.IntPtr iter, double within_margin, int use_align, double xalign, double yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_scroll_to_mark(System.IntPtr text_view, System.IntPtr mark, double within_margin, int use_align, double xalign, double yalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_accepts_tab(System.IntPtr text_view, int accepts_tab);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_border_window_size(System.IntPtr text_view, int type, int size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_bottom_margin(System.IntPtr text_view, int bottom_margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_buffer(System.IntPtr text_view, System.IntPtr buffer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_cursor_visible(System.IntPtr text_view, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_editable(System.IntPtr text_view, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_indent(System.IntPtr text_view, int indent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_input_hints(System.IntPtr text_view, int hints);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_input_purpose(System.IntPtr text_view, int purpose);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_justification(System.IntPtr text_view, int justification);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_left_margin(System.IntPtr text_view, int left_margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_monospace(System.IntPtr text_view, int monospace);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_overwrite(System.IntPtr text_view, int overwrite);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_pixels_above_lines(System.IntPtr text_view, int pixels_above_lines);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_pixels_below_lines(System.IntPtr text_view, int pixels_below_lines);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_pixels_inside_wrap(System.IntPtr text_view, int pixels_inside_wrap);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_right_margin(System.IntPtr text_view, int right_margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_tabs(System.IntPtr text_view, System.IntPtr tabs);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_top_margin(System.IntPtr text_view, int top_margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_set_wrap_mode(System.IntPtr text_view, int wrap_mode);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_text_view_starts_display_line(System.IntPtr text_view, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_text_view_window_to_buffer_coords(System.IntPtr text_view, int win, int window_x, int window_y, System.IntPtr buffer_x, System.IntPtr buffer_y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_theming_engine_load(string name);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_register_property(string name_space, System.IntPtr parse_func, System.IntPtr pspec);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_background_color(System.IntPtr engine, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_border(System.IntPtr engine, int state, System.IntPtr border);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_border_color(System.IntPtr engine, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_color(System.IntPtr engine, int state, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_theming_engine_get_direction(System.IntPtr engine);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_theming_engine_get_font(System.IntPtr engine, int state);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_theming_engine_get_junction_sides(System.IntPtr engine);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_margin(System.IntPtr engine, int state, System.IntPtr margin);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_padding(System.IntPtr engine, int state, System.IntPtr padding);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_theming_engine_get_path(System.IntPtr engine);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_property(System.IntPtr engine, string property, int state, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_theming_engine_get_screen(System.IntPtr engine);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_theming_engine_get_state(System.IntPtr engine);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_theming_engine_get_style_property(System.IntPtr engine, string property_name, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_theming_engine_has_class(System.IntPtr engine, string style_class);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_theming_engine_has_region(System.IntPtr engine, string style_region, System.IntPtr flags);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_theming_engine_lookup_color(System.IntPtr engine, string color_name, System.IntPtr color);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_theming_engine_state_is_running(System.IntPtr engine, int state, System.IntPtr progress);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_shell_get_ellipsize_mode(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_shell_get_icon_size(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_shell_get_orientation(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_shell_get_relief_style(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_shell_get_style(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern float gtk_tool_shell_get_text_alignment(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_shell_get_text_orientation(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_shell_get_text_size_group(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_shell_rebuild_menu(System.IntPtr shell);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_group_new(string label);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_group_get_collapsed(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_group_get_drop_item(System.IntPtr group, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_group_get_ellipsize(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_group_get_header_relief(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_item_group_get_item_position(System.IntPtr group, System.IntPtr item);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_tool_item_group_get_label(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_group_get_label_widget(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_tool_item_group_get_n_items(System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_item_group_get_nth_item(System.IntPtr group, uint index);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_group_insert(System.IntPtr group, System.IntPtr item, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_group_set_collapsed(System.IntPtr group, int collapsed);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_group_set_ellipsize(System.IntPtr group, int ellipsize);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_group_set_header_relief(System.IntPtr group, int style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_group_set_item_position(System.IntPtr group, System.IntPtr item, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_group_set_label(System.IntPtr group, string label);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_item_group_set_label_widget(System.IntPtr group, System.IntPtr label_widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_get_drag_target_group();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_get_drag_target_item();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_add_drag_dest(System.IntPtr palette, System.IntPtr widget, int flags, int targets, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_get_drag_item(System.IntPtr palette, System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_get_drop_group(System.IntPtr palette, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_get_drop_item(System.IntPtr palette, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_palette_get_exclusive(System.IntPtr palette, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_palette_get_expand(System.IntPtr palette, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_palette_get_group_position(System.IntPtr palette, System.IntPtr group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_get_hadjustment(System.IntPtr palette);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_palette_get_icon_size(System.IntPtr palette);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tool_palette_get_style(System.IntPtr palette);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tool_palette_get_vadjustment(System.IntPtr palette);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_set_drag_source(System.IntPtr palette, int targets);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_set_exclusive(System.IntPtr palette, System.IntPtr group, int exclusive);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_set_expand(System.IntPtr palette, System.IntPtr group, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_set_group_position(System.IntPtr palette, System.IntPtr group, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_set_icon_size(System.IntPtr palette, int icon_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_set_style(System.IntPtr palette, int style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_unset_icon_size(System.IntPtr palette);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tool_palette_unset_style(System.IntPtr palette);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toolbar_new();
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toolbar_get_drop_index(System.IntPtr toolbar, int x, int y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toolbar_get_icon_size(System.IntPtr toolbar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toolbar_get_item_index(System.IntPtr toolbar, System.IntPtr item);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toolbar_get_n_items(System.IntPtr toolbar);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toolbar_get_nth_item(System.IntPtr toolbar, int n);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toolbar_get_relief_style(System.IntPtr toolbar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toolbar_get_show_arrow(System.IntPtr toolbar);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_toolbar_get_style(System.IntPtr toolbar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toolbar_insert(System.IntPtr toolbar, System.IntPtr item, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toolbar_set_drop_highlight_item(System.IntPtr toolbar, System.IntPtr tool_item, int index_);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toolbar_set_icon_size(System.IntPtr toolbar, int icon_size);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toolbar_set_show_arrow(System.IntPtr toolbar, int show_arrow);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toolbar_set_style(System.IntPtr toolbar, int style);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toolbar_unset_icon_size(System.IntPtr toolbar);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_toolbar_unset_style(System.IntPtr toolbar);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_toplevel_accessible_get_children(System.IntPtr accessible);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_column_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_column_new_with_area(System.IntPtr area);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_add_attribute(System.IntPtr tree_column, System.IntPtr cell_renderer, string attribute, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_cell_get_position(System.IntPtr tree_column, System.IntPtr cell_renderer, System.IntPtr x_offset, System.IntPtr width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_cell_get_size(System.IntPtr tree_column, System.IntPtr cell_area, System.IntPtr x_offset, System.IntPtr y_offset, System.IntPtr width, System.IntPtr height);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_cell_is_visible(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_cell_set_cell_data(System.IntPtr tree_column, System.IntPtr tree_model, System.IntPtr iter, int is_expander, int is_expanded);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_clear(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_clear_attributes(System.IntPtr tree_column, System.IntPtr cell_renderer);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_clicked(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_focus_cell(System.IntPtr tree_column, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern float gtk_tree_view_column_get_alignment(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_column_get_button(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_clickable(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_expand(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_fixed_width(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_max_width(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_min_width(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_reorderable(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_resizable(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_sizing(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_sort_column_id(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_sort_indicator(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_sort_order(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_spacing(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_tree_view_column_get_title(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_column_get_tree_view(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_visible(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_column_get_widget(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_width(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_column_get_x_offset(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_pack_end(System.IntPtr tree_column, System.IntPtr cell, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_pack_start(System.IntPtr tree_column, System.IntPtr cell, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_queue_resize(System.IntPtr tree_column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_alignment(System.IntPtr tree_column, float xalign);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_cell_data_func(System.IntPtr tree_column, System.IntPtr cell_renderer, System.IntPtr func, System.IntPtr func_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_clickable(System.IntPtr tree_column, int clickable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_expand(System.IntPtr tree_column, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_fixed_width(System.IntPtr tree_column, int fixed_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_max_width(System.IntPtr tree_column, int max_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_min_width(System.IntPtr tree_column, int min_width);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_reorderable(System.IntPtr tree_column, int reorderable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_resizable(System.IntPtr tree_column, int resizable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_sizing(System.IntPtr tree_column, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_sort_column_id(System.IntPtr tree_column, int sort_column_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_sort_indicator(System.IntPtr tree_column, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_sort_order(System.IntPtr tree_column, int order);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_spacing(System.IntPtr tree_column, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_title(System.IntPtr tree_column, string title);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_visible(System.IntPtr tree_column, int visible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_column_set_widget(System.IntPtr tree_column, System.IntPtr widget);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_new_with_model(System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_append_column(System.IntPtr tree_view, System.IntPtr column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_collapse_all(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_collapse_row(System.IntPtr tree_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_columns_autosize(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_convert_bin_window_to_tree_coords(System.IntPtr tree_view, int bx, int by, System.IntPtr tx, System.IntPtr ty);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_convert_bin_window_to_widget_coords(System.IntPtr tree_view, int bx, int by, System.IntPtr wx, System.IntPtr wy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_convert_tree_to_bin_window_coords(System.IntPtr tree_view, int tx, int ty, System.IntPtr bx, System.IntPtr by);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_convert_tree_to_widget_coords(System.IntPtr tree_view, int tx, int ty, System.IntPtr wx, System.IntPtr wy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_convert_widget_to_bin_window_coords(System.IntPtr tree_view, int wx, int wy, System.IntPtr bx, System.IntPtr by);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_convert_widget_to_tree_coords(System.IntPtr tree_view, int wx, int wy, System.IntPtr tx, System.IntPtr ty);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_create_row_drag_icon(System.IntPtr tree_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_enable_model_drag_dest(System.IntPtr tree_view, System.IntPtr targets, int n_targets, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_enable_model_drag_source(System.IntPtr tree_view, int start_button_mask, System.IntPtr targets, int n_targets, int actions);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_expand_all(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_expand_row(System.IntPtr tree_view, System.IntPtr path, int open_all);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_expand_to_path(System.IntPtr tree_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_activate_on_single_click(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_get_background_area(System.IntPtr tree_view, System.IntPtr path, System.IntPtr column, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_bin_window(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_get_cell_area(System.IntPtr tree_view, System.IntPtr path, System.IntPtr column, System.IntPtr rect);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_column(System.IntPtr tree_view, int n);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_columns(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_get_cursor(System.IntPtr tree_view, System.IntPtr path, System.IntPtr focus_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_dest_row_at_pos(System.IntPtr tree_view, int drag_x, int drag_y, System.IntPtr path, System.IntPtr pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_get_drag_dest_row(System.IntPtr tree_view, System.IntPtr path, System.IntPtr pos);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_enable_search(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_enable_tree_lines(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_expander_column(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_fixed_height_mode(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_grid_lines(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_hadjustment(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_headers_clickable(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_headers_visible(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_hover_expand(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_hover_selection(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_level_indentation(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_model(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_tree_view_get_n_columns(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_path_at_pos(System.IntPtr tree_view, int x, int y, System.IntPtr path, System.IntPtr column, System.IntPtr cell_x, System.IntPtr cell_y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_reorderable(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_row_separator_func(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_rubber_banding(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_rules_hint(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_search_column(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_search_entry(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_search_equal_func(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_search_position_func(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_selection(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_show_expanders(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_tooltip_column(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_tooltip_context(System.IntPtr tree_view, System.IntPtr x, System.IntPtr y, int keyboard_tip, System.IntPtr model, System.IntPtr path, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_view_get_vadjustment(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_get_visible_range(System.IntPtr tree_view, System.IntPtr start_path, System.IntPtr end_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_get_visible_rect(System.IntPtr tree_view, System.IntPtr visible_rect);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_insert_column(System.IntPtr tree_view, System.IntPtr column, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_insert_column_with_data_func(System.IntPtr tree_view, int position, string title, System.IntPtr cell, System.IntPtr func, System.IntPtr data, System.IntPtr dnotify);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_is_blank_at_pos(System.IntPtr tree_view, int x, int y, System.IntPtr path, System.IntPtr column, System.IntPtr cell_x, System.IntPtr cell_y);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_is_rubber_banding_active(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_map_expanded_rows(System.IntPtr tree_view, System.IntPtr func, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_move_column_after(System.IntPtr tree_view, System.IntPtr column, System.IntPtr base_column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_remove_column(System.IntPtr tree_view, System.IntPtr column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_row_activated(System.IntPtr tree_view, System.IntPtr path, System.IntPtr column);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_view_row_expanded(System.IntPtr tree_view, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_scroll_to_cell(System.IntPtr tree_view, System.IntPtr path, System.IntPtr column, int use_align, float row_align, float col_align);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_scroll_to_point(System.IntPtr tree_view, int tree_x, int tree_y);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_activate_on_single_click(System.IntPtr tree_view, int single);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_column_drag_function(System.IntPtr tree_view, System.IntPtr func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_cursor(System.IntPtr tree_view, System.IntPtr path, System.IntPtr focus_column, int start_editing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_cursor_on_cell(System.IntPtr tree_view, System.IntPtr path, System.IntPtr focus_column, System.IntPtr focus_cell, int start_editing);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_destroy_count_func(System.IntPtr tree_view, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_drag_dest_row(System.IntPtr tree_view, System.IntPtr path, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_enable_search(System.IntPtr tree_view, int enable_search);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_enable_tree_lines(System.IntPtr tree_view, int enabled);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_expander_column(System.IntPtr tree_view, System.IntPtr column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_fixed_height_mode(System.IntPtr tree_view, int enable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_grid_lines(System.IntPtr tree_view, int grid_lines);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_hadjustment(System.IntPtr tree_view, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_headers_clickable(System.IntPtr tree_view, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_headers_visible(System.IntPtr tree_view, int headers_visible);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_hover_expand(System.IntPtr tree_view, int expand);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_hover_selection(System.IntPtr tree_view, int hover);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_level_indentation(System.IntPtr tree_view, int indentation);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_model(System.IntPtr tree_view, System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_reorderable(System.IntPtr tree_view, int reorderable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_row_separator_func(System.IntPtr tree_view, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_rubber_banding(System.IntPtr tree_view, int enable);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_rules_hint(System.IntPtr tree_view, int setting);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_search_column(System.IntPtr tree_view, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_search_entry(System.IntPtr tree_view, System.IntPtr entry);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_search_equal_func(System.IntPtr tree_view, System.IntPtr search_equal_func, System.IntPtr search_user_data, System.IntPtr search_destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_search_position_func(System.IntPtr tree_view, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_show_expanders(System.IntPtr tree_view, int enabled);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_tooltip_cell(System.IntPtr tree_view, System.IntPtr tooltip, System.IntPtr path, System.IntPtr column, System.IntPtr cell);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_tooltip_column(System.IntPtr tree_view, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_tooltip_row(System.IntPtr tree_view, System.IntPtr tooltip, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_set_vadjustment(System.IntPtr tree_view, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_unset_rows_drag_dest(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_view_unset_rows_drag_source(System.IntPtr tree_view);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_filter_clear_cache(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_filter_convert_child_iter_to_iter(System.IntPtr filter, System.IntPtr filter_iter, System.IntPtr child_iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_filter_convert_child_path_to_path(System.IntPtr filter, System.IntPtr child_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_filter_convert_iter_to_child_iter(System.IntPtr filter, System.IntPtr child_iter, System.IntPtr filter_iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_filter_convert_path_to_child_path(System.IntPtr filter, System.IntPtr filter_path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_filter_get_model(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_filter_refilter(System.IntPtr filter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_filter_set_modify_func(System.IntPtr filter, int n_columns, System.IntPtr types, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_filter_set_visible_column(System.IntPtr filter, int column);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_filter_set_visible_func(System.IntPtr filter, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_sort_clear_cache(System.IntPtr tree_model_sort);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_sort_convert_child_iter_to_iter(System.IntPtr tree_model_sort, System.IntPtr sort_iter, System.IntPtr child_iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_sort_convert_child_path_to_path(System.IntPtr tree_model_sort, System.IntPtr child_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_sort_convert_iter_to_child_iter(System.IntPtr tree_model_sort, System.IntPtr child_iter, System.IntPtr sorted_iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_sort_convert_path_to_child_path(System.IntPtr tree_model_sort, System.IntPtr sorted_path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_model_sort_get_model(System.IntPtr tree_model);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_model_sort_iter_is_valid(System.IntPtr tree_model_sort, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_model_sort_reset_default_sort_func(System.IntPtr tree_model_sort);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_row_reference_new(System.IntPtr model, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_row_reference_new_proxy(System.IntPtr proxy, System.IntPtr model, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_row_reference_copy(System.IntPtr reference);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_row_reference_free(System.IntPtr reference);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_row_reference_get_model(System.IntPtr reference);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_row_reference_get_path(System.IntPtr reference);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_row_reference_valid(System.IntPtr reference);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_row_reference_deleted(System.IntPtr proxy, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_row_reference_inserted(System.IntPtr proxy, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_row_reference_reordered(System.IntPtr proxy, System.IntPtr path, System.IntPtr iter, System.IntPtr new_order);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_selection_count_selected_rows(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_selection_get_mode(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_selection_get_select_function(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_selection_get_selected(System.IntPtr selection, System.IntPtr model, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_selection_get_selected_rows(System.IntPtr selection, System.IntPtr model);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_selection_get_tree_view(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_selection_get_user_data(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_selection_iter_is_selected(System.IntPtr selection, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_selection_path_is_selected(System.IntPtr selection, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_select_all(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_select_iter(System.IntPtr selection, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_select_path(System.IntPtr selection, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_select_range(System.IntPtr selection, System.IntPtr start_path, System.IntPtr end_path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_selected_foreach(System.IntPtr selection, System.IntPtr func, System.IntPtr data);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_set_mode(System.IntPtr selection, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_set_select_function(System.IntPtr selection, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_unselect_all(System.IntPtr selection);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_unselect_iter(System.IntPtr selection, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_unselect_path(System.IntPtr selection, System.IntPtr path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_selection_unselect_range(System.IntPtr selection, System.IntPtr start_path, System.IntPtr end_path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_tree_store_newv(int n_columns, System.IntPtr types);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_append(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_clear(System.IntPtr tree_store);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_insert(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr parent, int position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_insert_after(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr parent, System.IntPtr sibling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_insert_before(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr parent, System.IntPtr sibling);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_insert_with_valuesv(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr parent, int position, System.IntPtr columns, System.IntPtr values, int n_values);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_store_is_ancestor(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr descendant);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_store_iter_depth(System.IntPtr tree_store, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_store_iter_is_valid(System.IntPtr tree_store, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_move_after(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_move_before(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr position);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_prepend(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr parent);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_tree_store_remove(System.IntPtr tree_store, System.IntPtr iter);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_reorder(System.IntPtr tree_store, System.IntPtr parent, System.IntPtr new_order);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_set_column_types(System.IntPtr tree_store, int n_columns, System.IntPtr types);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_set_value(System.IntPtr tree_store, System.IntPtr iter, int column, System.IntPtr value);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_set_valuesv(System.IntPtr tree_store, System.IntPtr iter, System.IntPtr columns, System.IntPtr values, int n_values);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_tree_store_swap(System.IntPtr tree_store, System.IntPtr a, System.IntPtr b);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_ui_manager_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_ui_manager_add_ui(System.IntPtr manager, uint merge_id, string path, string name, string action, int type, int top);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_ui_manager_add_ui_from_file(System.IntPtr manager, System.IntPtr filename, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_ui_manager_add_ui_from_resource(System.IntPtr manager, string resource_path, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_ui_manager_add_ui_from_string(System.IntPtr manager, string buffer, long length, System.IntPtr error);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_ui_manager_ensure_update(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_ui_manager_get_accel_group(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_ui_manager_get_action(System.IntPtr manager, string path);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_ui_manager_get_action_groups(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_ui_manager_get_add_tearoffs(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_ui_manager_get_toplevels(System.IntPtr manager, int types);
        [DllImport("libgtk-3.so.0")]
        public static extern string gtk_ui_manager_get_ui(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_ui_manager_get_widget(System.IntPtr manager, string path);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_ui_manager_insert_action_group(System.IntPtr manager, System.IntPtr action_group, int pos);
        [DllImport("libgtk-3.so.0")]
        public static extern uint gtk_ui_manager_new_merge_id(System.IntPtr manager);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_ui_manager_remove_action_group(System.IntPtr manager, System.IntPtr action_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_ui_manager_remove_ui(System.IntPtr manager, uint merge_id);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_ui_manager_set_add_tearoffs(System.IntPtr manager, int add_tearoffs);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_vbox_new(int homogeneous, int spacing);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_vbutton_box_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_vpaned_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_vscale_new(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_vscale_new_with_range(double min, double max, double step);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_vscrollbar_new(System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_vseparator_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_viewport_new(System.IntPtr hadjustment, System.IntPtr vadjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_viewport_get_bin_window(System.IntPtr viewport);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_viewport_get_hadjustment(System.IntPtr viewport);
        [DllImport("libgtk-3.so.0")]
        public static extern int gtk_viewport_get_shadow_type(System.IntPtr viewport);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_viewport_get_vadjustment(System.IntPtr viewport);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_viewport_get_view_window(System.IntPtr viewport);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_viewport_set_hadjustment(System.IntPtr viewport, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_viewport_set_shadow_type(System.IntPtr viewport, int type);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_viewport_set_vadjustment(System.IntPtr viewport, System.IntPtr adjustment);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_volume_button_new();
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_group_new();
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_group_add_window(System.IntPtr window_group, System.IntPtr window);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_group_get_current_device_grab(System.IntPtr window_group, System.IntPtr device);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_group_get_current_grab(System.IntPtr window_group);
        [DllImport("libgtk-3.so.0")]
        public static extern System.IntPtr gtk_window_group_list_windows(System.IntPtr window_group);
        [DllImport("libgtk-3.so.0")]
        public static extern void gtk_window_group_remove_window(System.IntPtr window_group, System.IntPtr window);
    }
}