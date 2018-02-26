using System;
using System.Runtime.InteropServices;
namespace Atk {
	public enum CoordType
	{
		screen = 0,
		window = 1,
	}
	public enum Layer
	{
		invalid = 0,
		background = 1,
		canvas = 2,
		widget = 3,
		mdi = 4,
		popup = 5,
		overlay = 6,
		window = 7,
	}
	[Flags]
	public enum HyperlinkStateFlags
	{
		inline = 1,
	}
	public enum KeyEventType
	{
		press = 0,
		release = 1,
		last_defined = 2,
	}
	public enum RelationType
	{
		@null = 0,
		controlled_by = 1,
		controller_for = 2,
		label_for = 3,
		labelled_by = 4,
		member_of = 5,
		node_child_of = 6,
		flows_to = 7,
		flows_from = 8,
		subwindow_of = 9,
		embeds = 10,
		embedded_by = 11,
		popup_for = 12,
		parent_window_of = 13,
		described_by = 14,
		description_for = 15,
		node_parent_of = 16,
		details = 17,
		details_for = 18,
		error_message = 19,
		error_for = 20,
		last_defined = 21,
	}
	public enum Role
	{
		invalid = 0,
		accelerator_label = 1,
		alert = 2,
		animation = 3,
		arrow = 4,
		calendar = 5,
		canvas = 6,
		check_box = 7,
		check_menu_item = 8,
		color_chooser = 9,
		column_header = 10,
		combo_box = 11,
		date_editor = 12,
		desktop_icon = 13,
		desktop_frame = 14,
		dial = 15,
		dialog = 16,
		directory_pane = 17,
		drawing_area = 18,
		file_chooser = 19,
		filler = 20,
		font_chooser = 21,
		frame = 22,
		glass_pane = 23,
		html_container = 24,
		icon = 25,
		image = 26,
		internal_frame = 27,
		label = 28,
		layered_pane = 29,
		list = 30,
		list_item = 31,
		menu = 32,
		menu_bar = 33,
		menu_item = 34,
		option_pane = 35,
		page_tab = 36,
		page_tab_list = 37,
		panel = 38,
		password_text = 39,
		popup_menu = 40,
		progress_bar = 41,
		push_button = 42,
		radio_button = 43,
		radio_menu_item = 44,
		root_pane = 45,
		row_header = 46,
		scroll_bar = 47,
		scroll_pane = 48,
		separator = 49,
		slider = 50,
		split_pane = 51,
		spin_button = 52,
		statusbar = 53,
		table = 54,
		table_cell = 55,
		table_column_header = 56,
		table_row_header = 57,
		tear_off_menu_item = 58,
		terminal = 59,
		text = 60,
		toggle_button = 61,
		tool_bar = 62,
		tool_tip = 63,
		tree = 64,
		tree_table = 65,
		unknown = 66,
		viewport = 67,
		window = 68,
		header = 69,
		footer = 70,
		paragraph = 71,
		ruler = 72,
		application = 73,
		autocomplete = 74,
		edit_bar = 75,
		embedded = 76,
		entry = 77,
		chart = 78,
		caption = 79,
		document_frame = 80,
		heading = 81,
		page = 82,
		section = 83,
		redundant_object = 84,
		form = 85,
		link = 86,
		input_method_window = 87,
		table_row = 88,
		tree_item = 89,
		document_spreadsheet = 90,
		document_presentation = 91,
		document_text = 92,
		document_web = 93,
		document_email = 94,
		comment = 95,
		list_box = 96,
		grouping = 97,
		image_map = 98,
		notification = 99,
		info_bar = 100,
		level_bar = 101,
		title_bar = 102,
		block_quote = 103,
		audio = 104,
		video = 105,
		definition = 106,
		article = 107,
		landmark = 108,
		log = 109,
		marquee = 110,
		math = 111,
		rating = 112,
		timer = 113,
		description_list = 114,
		description_term = 115,
		description_value = 116,
		@static = 117,
		math_fraction = 118,
		math_root = 119,
		subscript = 120,
		superscript = 121,
		footnote = 122,
		last_defined = 123,
	}
	public enum StateType
	{
		invalid = 0,
		active = 1,
		armed = 2,
		busy = 3,
		@checked = 4,
		defunct = 5,
		editable = 6,
		enabled = 7,
		expandable = 8,
		expanded = 9,
		focusable = 10,
		focused = 11,
		horizontal = 12,
		iconified = 13,
		modal = 14,
		multi_line = 15,
		multiselectable = 16,
		opaque = 17,
		pressed = 18,
		resizable = 19,
		selectable = 20,
		selected = 21,
		sensitive = 22,
		showing = 23,
		single_line = 24,
		stale = 25,
		transient = 26,
		vertical = 27,
		visible = 28,
		manages_descendants = 29,
		indeterminate = 30,
		truncated = 31,
		required = 32,
		invalid_entry = 33,
		supports_autocompletion = 34,
		selectable_text = 35,
		@default = 36,
		animated = 37,
		visited = 38,
		checkable = 39,
		has_popup = 40,
		has_tooltip = 41,
		read_only = 42,
		last_defined = 43,
	}
	public enum TextClipType
	{
		none = 0,
		min = 1,
		max = 2,
		both = 3,
	}
	public enum TextGranularity
	{
		@char = 0,
		word = 1,
		sentence = 2,
		line = 3,
		paragraph = 4,
	}
	public enum TextBoundary
	{
		@char = 0,
		word_start = 1,
		word_end = 2,
		sentence_start = 3,
		sentence_end = 4,
		line_start = 5,
		line_end = 6,
	}
	public enum TextAttribute
	{
		invalid = 0,
		left_margin = 1,
		right_margin = 2,
		indent = 3,
		invisible = 4,
		editable = 5,
		pixels_above_lines = 6,
		pixels_below_lines = 7,
		pixels_inside_wrap = 8,
		bg_full_height = 9,
		rise = 10,
		underline = 11,
		strikethrough = 12,
		size = 13,
		scale = 14,
		weight = 15,
		language = 16,
		family_name = 17,
		bg_color = 18,
		fg_color = 19,
		bg_stipple = 20,
		fg_stipple = 21,
		wrap_mode = 22,
		direction = 23,
		justification = 24,
		stretch = 25,
		variant = 26,
		style = 27,
		last_defined = 28,
	}
	public enum ValueType
	{
		very_weak = 0,
		weak = 1,
		acceptable = 2,
		strong = 3,
		very_strong = 4,
		very_low = 5,
		low = 6,
		medium = 7,
		high = 8,
		very_high = 9,
		very_bad = 10,
		bad = 11,
		good = 12,
		very_good = 13,
		best = 14,
		last_defined = 15,
	}
	public static class AtkInterop {
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_add_focus_tracker(System.IntPtr focus_tracker);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_add_global_event_listener(System.IntPtr listener, string event_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_add_key_event_listener(System.IntPtr listener, System.IntPtr data);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_focus_tracker_init(System.IntPtr init);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_focus_tracker_notify(System.IntPtr @object);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_binary_age();
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_get_default_registry();
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_get_focus_object();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_interface_age();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_major_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_micro_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_minor_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_get_root();
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_get_toolkit_name();
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_get_toolkit_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_get_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_remove_focus_tracker(uint tracker_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_remove_global_event_listener(uint listener_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_remove_key_event_listener(uint listener_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_action_do_action(System.IntPtr action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_description(System.IntPtr action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_keybinding(System.IntPtr action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_localized_name(System.IntPtr action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_action_get_n_actions(System.IntPtr action);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_name(System.IntPtr action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_action_set_description(System.IntPtr action, int i, string desc);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_attribute_set_free(System.IntPtr attrib_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_component_add_focus_handler(System.IntPtr component, System.IntPtr handler);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_component_contains(System.IntPtr component, int x, int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_component_get_alpha(System.IntPtr component);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_get_extents(System.IntPtr component, System.IntPtr x, System.IntPtr y, System.IntPtr width, System.IntPtr height, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Layer atk_component_get_layer(System.IntPtr component);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_component_get_mdi_zorder(System.IntPtr component);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_get_position(System.IntPtr component, System.IntPtr x, System.IntPtr y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_get_size(System.IntPtr component, System.IntPtr width, System.IntPtr height);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_component_grab_focus(System.IntPtr component);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_component_ref_accessible_at_point(System.IntPtr component, int x, int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_remove_focus_handler(System.IntPtr component, uint handler_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_component_set_extents(System.IntPtr component, int x, int y, int width, int height, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_component_set_position(System.IntPtr component, int x, int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_component_set_size(System.IntPtr component, int width, int height);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_add_relationship(System.IntPtr @object, Atk.RelationType relationship, System.IntPtr target);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_object_connect_property_change_handler(System.IntPtr accessible, System.IntPtr handler);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_object_get_attributes(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_object_get_description(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_get_index_in_parent(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Layer atk_object_get_layer(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_get_mdi_zorder(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_get_n_accessible_children(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_object_get_name(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_object_get_object_locale(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_object_get_parent(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Role atk_object_get_role(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_initialize(System.IntPtr accessible, System.IntPtr data);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_notify_state_change(System.IntPtr accessible, ulong state, int value);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_object_peek_parent(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_object_ref_accessible_child(System.IntPtr accessible, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_object_ref_relation_set(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_object_ref_state_set(System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_remove_property_change_handler(System.IntPtr accessible, uint handler_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_remove_relationship(System.IntPtr @object, Atk.RelationType relationship, System.IntPtr target);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_description(System.IntPtr accessible, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_name(System.IntPtr accessible, string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_parent(System.IntPtr accessible, System.IntPtr parent);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_role(System.IntPtr accessible, Atk.Role role);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_document_get_attribute_value(System.IntPtr document, string attribute_name);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_document_get_attributes(System.IntPtr document);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_document_get_current_page_number(System.IntPtr document);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_document_get_document(System.IntPtr document);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_document_get_document_type(System.IntPtr document);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_document_get_locale(System.IntPtr document);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_document_get_page_count(System.IntPtr document);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_document_set_attribute_value(System.IntPtr document, string attribute_name, string attribute_value);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_copy_text(System.IntPtr text, int start_pos, int end_pos);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_cut_text(System.IntPtr text, int start_pos, int end_pos);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_delete_text(System.IntPtr text, int start_pos, int end_pos);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_insert_text(System.IntPtr text, string @string, int length, System.IntPtr position);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_paste_text(System.IntPtr text, int position);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_editable_text_set_run_attributes(System.IntPtr text, System.IntPtr attrib_set, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_set_text_contents(System.IntPtr text, string @string);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_gobject_accessible_for_object(System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_gobject_accessible_get_object(System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_get_end_index(System.IntPtr link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_get_n_anchors(System.IntPtr link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_hyperlink_get_object(System.IntPtr link_, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_get_start_index(System.IntPtr link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_hyperlink_get_uri(System.IntPtr link_, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_is_inline(System.IntPtr link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_is_selected_link(System.IntPtr link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_is_valid(System.IntPtr link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_hyperlink_impl_get_hyperlink(System.IntPtr impl);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_hypertext_get_link(System.IntPtr hypertext, int link_index);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hypertext_get_link_index(System.IntPtr hypertext, int char_index);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hypertext_get_n_links(System.IntPtr hypertext);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_image_get_image_description(System.IntPtr image);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_image_get_image_locale(System.IntPtr image);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_image_get_image_position(System.IntPtr image, System.IntPtr x, System.IntPtr y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_image_get_image_size(System.IntPtr image, System.IntPtr width, System.IntPtr height);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_image_set_image_description(System.IntPtr image, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_implementor_ref_accessible(System.IntPtr implementor);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_misc_get_instance();
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_misc_threads_enter(System.IntPtr misc);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_misc_threads_leave(System.IntPtr misc);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_selection_add_selection(System.IntPtr selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_selection_clear_selection(System.IntPtr selection);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_selection_get_selection_count(System.IntPtr selection);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_selection_is_child_selected(System.IntPtr selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_selection_ref_selection(System.IntPtr selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_selection_remove_selection(System.IntPtr selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_selection_select_all_selection(System.IntPtr selection);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_add_column_selection(System.IntPtr table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_add_row_selection(System.IntPtr table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_get_caption(System.IntPtr table);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_column_at_index(System.IntPtr table, int index_);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_table_get_column_description(System.IntPtr table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_column_extent_at(System.IntPtr table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_get_column_header(System.IntPtr table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_index_at(System.IntPtr table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_n_columns(System.IntPtr table);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_n_rows(System.IntPtr table);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_row_at_index(System.IntPtr table, int index_);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_table_get_row_description(System.IntPtr table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_row_extent_at(System.IntPtr table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_get_row_header(System.IntPtr table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_selected_columns(System.IntPtr table, System.IntPtr selected);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_selected_rows(System.IntPtr table, System.IntPtr selected);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_get_summary(System.IntPtr table);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_is_column_selected(System.IntPtr table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_is_row_selected(System.IntPtr table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_is_selected(System.IntPtr table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_ref_at(System.IntPtr table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_remove_column_selection(System.IntPtr table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_remove_row_selection(System.IntPtr table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_caption(System.IntPtr table, System.IntPtr caption);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_column_description(System.IntPtr table, int column, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_column_header(System.IntPtr table, int column, System.IntPtr header);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_row_description(System.IntPtr table, int row, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_row_header(System.IntPtr table, int row, System.IntPtr header);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_summary(System.IntPtr table, System.IntPtr accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_cell_get_column_header_cells(System.IntPtr cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_cell_get_column_span(System.IntPtr cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_cell_get_position(System.IntPtr cell, System.IntPtr row, System.IntPtr column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_cell_get_row_column_span(System.IntPtr cell, System.IntPtr row, System.IntPtr column, System.IntPtr row_span, System.IntPtr column_span);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_cell_get_row_header_cells(System.IntPtr cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_cell_get_row_span(System.IntPtr cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_cell_get_table(System.IntPtr cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_text_free_ranges(System.IntPtr ranges);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_add_selection(System.IntPtr text, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_text_get_bounded_ranges(System.IntPtr text, System.IntPtr rect, Atk.CoordType coord_type, Atk.TextClipType x_clip_type, Atk.TextClipType y_clip_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_caret_offset(System.IntPtr text);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_text_get_character_at_offset(System.IntPtr text, int offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_character_count(System.IntPtr text);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_text_get_character_extents(System.IntPtr text, int offset, System.IntPtr x, System.IntPtr y, System.IntPtr width, System.IntPtr height, Atk.CoordType coords);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_text_get_default_attributes(System.IntPtr text);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_n_selections(System.IntPtr text);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_offset_at_point(System.IntPtr text, int x, int y, Atk.CoordType coords);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_text_get_range_extents(System.IntPtr text, int start_offset, int end_offset, Atk.CoordType coord_type, System.IntPtr rect);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_text_get_run_attributes(System.IntPtr text, int offset, System.IntPtr start_offset, System.IntPtr end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_selection(System.IntPtr text, int selection_num, System.IntPtr start_offset, System.IntPtr end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_string_at_offset(System.IntPtr text, int offset, Atk.TextGranularity granularity, System.IntPtr start_offset, System.IntPtr end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text(System.IntPtr text, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text_after_offset(System.IntPtr text, int offset, Atk.TextBoundary boundary_type, System.IntPtr start_offset, System.IntPtr end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text_at_offset(System.IntPtr text, int offset, Atk.TextBoundary boundary_type, System.IntPtr start_offset, System.IntPtr end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text_before_offset(System.IntPtr text, int offset, Atk.TextBoundary boundary_type, System.IntPtr start_offset, System.IntPtr end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_remove_selection(System.IntPtr text, int selection_num);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_set_caret_offset(System.IntPtr text, int offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_set_selection(System.IntPtr text, int selection_num, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_get_current_value(System.IntPtr obj, System.IntPtr value);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_value_get_increment(System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_get_maximum_value(System.IntPtr obj, System.IntPtr value);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_get_minimum_increment(System.IntPtr obj, System.IntPtr value);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_get_minimum_value(System.IntPtr obj, System.IntPtr value);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_value_get_range(System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_value_get_sub_ranges(System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_get_value_and_text(System.IntPtr obj, System.IntPtr value, string text);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_value_set_current_value(System.IntPtr obj, System.IntPtr value);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_set_value(System.IntPtr obj, double new_value);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_no_op_object_new(System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_object_factory_create_accessible(System.IntPtr factory, System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern ulong atk_object_factory_get_accessible_type(System.IntPtr factory);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_factory_invalidate(System.IntPtr factory);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_no_op_object_factory_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.RelationType atk_relation_type_for_name(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_relation_type_get_name(Atk.RelationType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.RelationType atk_relation_type_register(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Role atk_role_for_name(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_role_get_localized_name(Atk.Role role);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_role_get_name(Atk.Role role);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Role atk_role_register(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_relation_set_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_set_add(System.IntPtr set, System.IntPtr relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_set_add_relation_by_type(System.IntPtr set, Atk.RelationType relationship, System.IntPtr target);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_relation_set_contains(System.IntPtr set, Atk.RelationType relationship);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_relation_set_contains_target(System.IntPtr set, Atk.RelationType relationship, System.IntPtr target);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_relation_set_get_n_relations(System.IntPtr set);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_relation_set_get_relation(System.IntPtr set, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_relation_set_get_relation_by_type(System.IntPtr set, Atk.RelationType relationship);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_set_remove(System.IntPtr set, System.IntPtr relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_state_set_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_state_set_add_state(System.IntPtr set, Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_state_set_add_states(System.IntPtr set, System.IntPtr types, int n_types);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_state_set_and_sets(System.IntPtr set, System.IntPtr compare_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_state_set_clear_states(System.IntPtr set);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_state_set_contains_state(System.IntPtr set, Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_state_set_contains_states(System.IntPtr set, System.IntPtr types, int n_types);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_state_set_is_empty(System.IntPtr set);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_state_set_or_sets(System.IntPtr set, System.IntPtr compare_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_state_set_remove_state(System.IntPtr set, Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_state_set_xor_sets(System.IntPtr set, System.IntPtr compare_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_plug_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_plug_get_id(System.IntPtr plug);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_range_new(double lower_limit, double upper_limit, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_range_copy(System.IntPtr src);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_range_free(System.IntPtr range);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_range_get_description(System.IntPtr range);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_range_get_lower_limit(System.IntPtr range);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_range_get_upper_limit(System.IntPtr range);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_registry_get_factory(System.IntPtr registry, ulong type);
		[DllImport("libatk-1.0.so.0")]
		public static extern ulong atk_registry_get_factory_type(System.IntPtr registry, ulong type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_registry_set_factory_type(System.IntPtr registry, ulong type, ulong factory_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_relation_new(System.IntPtr targets, int n_targets, Atk.RelationType relationship);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_add_target(System.IntPtr relation, System.IntPtr target);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.RelationType atk_relation_get_relation_type(System.IntPtr relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_relation_get_target(System.IntPtr relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_relation_remove_target(System.IntPtr relation, System.IntPtr target);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_socket_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_socket_embed(System.IntPtr obj, string plug_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_socket_is_occupied(System.IntPtr obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateType atk_state_type_for_name(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_state_type_get_name(Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateType atk_state_type_register(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_streamable_content_get_mime_type(System.IntPtr streamable, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_streamable_content_get_n_mime_types(System.IntPtr streamable);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_streamable_content_get_stream(System.IntPtr streamable, string mime_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_streamable_content_get_uri(System.IntPtr streamable, string mime_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.TextAttribute atk_text_attribute_for_name(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_attribute_get_name(Atk.TextAttribute attr);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_attribute_get_value(Atk.TextAttribute attr, int index_);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.TextAttribute atk_text_attribute_register(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_value_type_get_localized_name(Atk.ValueType value_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_value_type_get_name(Atk.ValueType value_type);
	}
}
