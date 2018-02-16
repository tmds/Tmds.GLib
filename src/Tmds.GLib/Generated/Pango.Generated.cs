using System;
using System.Runtime.InteropServices;

namespace Pango
{
    public static class PangoInterop
    {
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_background_alpha_new(ushort alpha);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_background_new(ushort red, ushort green, ushort blue);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_fallback_new(int enable_fallback);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_family_new(string family);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_foreground_alpha_new(ushort alpha);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_foreground_new(ushort red, ushort green, ushort blue);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_gravity_hint_new(int hint);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_gravity_new(int gravity);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_letter_spacing_new(int letter_spacing);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_rise_new(int rise);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_scale_new(double scale_factor);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_stretch_new(int stretch);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_strikethrough_color_new(ushort red, ushort green, ushort blue);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_strikethrough_new(int strikethrough);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_style_new(int style);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_underline_color_new(ushort red, ushort green, ushort blue);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_underline_new(int underline);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_variant_new(int variant);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_weight_new(int weight);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_break(string text, int length, System.IntPtr analysis, System.IntPtr attrs, int attrs_len);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_config_key_get(string key);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_config_key_get_system(string key);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_default_break(string text, int length, System.IntPtr analysis, System.IntPtr attrs, int attrs_len);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_extents_to_pixels(System.IntPtr inclusive, System.IntPtr nearest);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_find_base_dir(string text, int length);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_find_map(System.IntPtr language, uint engine_type_id, uint render_type_id);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_find_paragraph_boundary(string text, int length, System.IntPtr paragraph_delimiter_index, System.IntPtr next_paragraph_start);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_get_lib_subdirectory();
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_get_log_attrs(string text, int length, int level, System.IntPtr language, System.IntPtr log_attrs, int attrs_len);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_get_mirror_char(uint ch, System.IntPtr mirrored_ch);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_get_sysconf_subdirectory();
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_is_zero_width(uint ch);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_itemize(System.IntPtr context, string text, int start_index, int length, System.IntPtr attrs, System.IntPtr cached_iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_itemize_with_base_dir(System.IntPtr context, int base_dir, string text, int start_index, int length, System.IntPtr attrs, System.IntPtr cached_iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_log2vis_get_embedding_levels(string text, int length, System.IntPtr pbase_dir);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_lookup_aliases(string fontname, System.IntPtr families, System.IntPtr n_families);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_markup_parser_finish(System.IntPtr context, System.IntPtr attr_list, string text, System.IntPtr accel_char, System.IntPtr error);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_markup_parser_new(uint accel_marker);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_module_register(System.IntPtr module);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_parse_enum(ulong type, string str, System.IntPtr value, int warn, string possible_values);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_parse_markup(string markup_text, int length, uint accel_marker, System.IntPtr attr_list, string text, System.IntPtr accel_char, System.IntPtr error);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_parse_stretch(string str, System.IntPtr stretch, int warn);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_parse_style(string str, System.IntPtr style, int warn);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_parse_variant(string str, System.IntPtr variant, int warn);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_parse_weight(string str, System.IntPtr weight, int warn);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_quantize_line_geometry(System.IntPtr thickness, System.IntPtr position);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_read_line(System.IntPtr stream, System.IntPtr str);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_reorder_items(System.IntPtr logical_items);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_scan_int(string pos, System.IntPtr @out);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_scan_string(string pos, System.IntPtr @out);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_scan_word(string pos, System.IntPtr @out);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_shape(string text, int length, System.IntPtr analysis, System.IntPtr glyphs);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_shape_full(string item_text, int item_length, string paragraph_text, int paragraph_length, System.IntPtr analysis, System.IntPtr glyphs);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_skip_space(string pos);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_split_file_list(string str);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_trim_string(string str);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_unichar_direction(uint ch);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_units_from_double(double d);
        [DllImport("libpango-1.0.so.0")]
        public static extern double pango_units_to_double(int i);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_version();
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_version_check(int required_major, int required_minor, int required_micro);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_version_string();
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_glyph_item_apply_attrs(System.IntPtr glyph_item, string text, System.IntPtr list);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_glyph_item_copy(System.IntPtr orig);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_item_free(System.IntPtr glyph_item);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_item_get_logical_widths(System.IntPtr glyph_item, string text, System.IntPtr logical_widths);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_item_letter_space(System.IntPtr glyph_item, string text, System.IntPtr log_attrs, int letter_spacing);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_glyph_item_split(System.IntPtr orig, string text, int split_index);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_descriptions_free(System.IntPtr descs, int n_descs);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_describe(System.IntPtr font);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_describe_with_absolute_size(System.IntPtr font);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_find_shaper(System.IntPtr font, System.IntPtr language, uint ch);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_get_coverage(System.IntPtr font, System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_get_font_map(System.IntPtr font);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_get_glyph_extents(System.IntPtr font, uint glyph, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_get_metrics(System.IntPtr font, System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_language_get_sample_string(System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_language_get_scripts(System.IntPtr language, System.IntPtr num_scripts);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_language_includes_script(System.IntPtr language, int script);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_language_matches(System.IntPtr language, string range_list);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_language_to_string(System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_language_from_string(string language);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_language_get_default();
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_attr_type_get_name(int type);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_attr_type_register(string name);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attribute_copy(System.IntPtr attr);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attribute_destroy(System.IntPtr attr);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_attribute_equal(System.IntPtr attr1, System.IntPtr attr2);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attribute_init(System.IntPtr attr, System.IntPtr klass);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_color_copy(System.IntPtr src);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_color_free(System.IntPtr color);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_color_parse(System.IntPtr color, string spec);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_color_to_string(System.IntPtr color);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_description_new();
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_better_match(System.IntPtr desc, System.IntPtr old_match, System.IntPtr new_match);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_description_copy(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_description_copy_static(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_equal(System.IntPtr desc1, System.IntPtr desc2);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_free(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_font_description_get_family(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_gravity(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_set_fields(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_size(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_size_is_absolute(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_stretch(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_style(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_variant(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_description_get_weight(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern uint pango_font_description_hash(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_merge(System.IntPtr desc, System.IntPtr desc_to_merge, int replace_existing);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_merge_static(System.IntPtr desc, System.IntPtr desc_to_merge, int replace_existing);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_absolute_size(System.IntPtr desc, double size);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_family(System.IntPtr desc, string family);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_family_static(System.IntPtr desc, string family);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_gravity(System.IntPtr desc, int gravity);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_size(System.IntPtr desc, int size);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_stretch(System.IntPtr desc, int stretch);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_style(System.IntPtr desc, int style);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_variant(System.IntPtr desc, int variant);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_set_weight(System.IntPtr desc, int weight);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_font_description_to_filename(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_font_description_to_string(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_description_unset_fields(System.IntPtr desc, int to_unset);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_description_from_string(string str);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_font_desc_new(System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_font_features_new(string features);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_iterator_copy(System.IntPtr iterator);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_iterator_destroy(System.IntPtr iterator);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_iterator_get(System.IntPtr iterator, int type);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_iterator_get_attrs(System.IntPtr iterator);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_iterator_get_font(System.IntPtr iterator, System.IntPtr desc, System.IntPtr language, System.IntPtr extra_attrs);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_attr_iterator_next(System.IntPtr iterator);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_iterator_range(System.IntPtr iterator, System.IntPtr start, System.IntPtr end);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_language_new(System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_list_new();
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_list_change(System.IntPtr list, System.IntPtr attr);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_list_copy(System.IntPtr list);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_list_filter(System.IntPtr list, System.IntPtr func, System.IntPtr data);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_list_get_iterator(System.IntPtr list);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_list_insert(System.IntPtr list, System.IntPtr attr);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_list_insert_before(System.IntPtr list, System.IntPtr attr);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_list_ref(System.IntPtr list);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_list_splice(System.IntPtr list, System.IntPtr other, int pos, int len);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_attr_list_unref(System.IntPtr list);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_shape_new(System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_shape_new_with_data(System.IntPtr ink_rect, System.IntPtr logical_rect, System.IntPtr data, System.IntPtr copy_func, System.IntPtr destroy_func);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_size_new(int size);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_attr_size_new_absolute(int size);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_bidi_type_for_unichar(uint ch);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_new();
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_changed(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_context_get_base_dir(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_context_get_base_gravity(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_get_font_description(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_get_font_map(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_context_get_gravity(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_context_get_gravity_hint(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_get_language(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_get_matrix(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_get_metrics(System.IntPtr context, System.IntPtr desc, System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern uint pango_context_get_serial(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_list_families(System.IntPtr context, System.IntPtr families, System.IntPtr n_families);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_load_font(System.IntPtr context, System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_context_load_fontset(System.IntPtr context, System.IntPtr desc, System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_set_base_dir(System.IntPtr context, int direction);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_set_base_gravity(System.IntPtr context, int gravity);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_set_font_description(System.IntPtr context, System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_set_font_map(System.IntPtr context, System.IntPtr font_map);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_set_gravity_hint(System.IntPtr context, int hint);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_set_language(System.IntPtr context, System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_context_set_matrix(System.IntPtr context, System.IntPtr matrix);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_gravity_get_for_matrix(System.IntPtr matrix);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_gravity_get_for_script(int script, int base_gravity, int hint);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_gravity_get_for_script_and_width(int script, int wide, int base_gravity, int hint);
        [DllImport("libpango-1.0.so.0")]
        public static extern double pango_gravity_to_rotation(int gravity);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_map_changed(System.IntPtr fontmap);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_map_create_context(System.IntPtr fontmap);
        [DllImport("libpango-1.0.so.0")]
        public static extern uint pango_font_map_get_serial(System.IntPtr fontmap);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_font_map_get_shape_engine_type(System.IntPtr fontmap);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_map_list_families(System.IntPtr fontmap, System.IntPtr families, System.IntPtr n_families);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_map_load_font(System.IntPtr fontmap, System.IntPtr context, System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_map_load_fontset(System.IntPtr fontmap, System.IntPtr context, System.IntPtr desc, System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_concat(System.IntPtr matrix, System.IntPtr new_matrix);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_matrix_copy(System.IntPtr matrix);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_free(System.IntPtr matrix);
        [DllImport("libpango-1.0.so.0")]
        public static extern double pango_matrix_get_font_scale_factor(System.IntPtr matrix);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_get_font_scale_factors(System.IntPtr matrix, System.IntPtr xscale, System.IntPtr yscale);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_rotate(System.IntPtr matrix, double degrees);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_scale(System.IntPtr matrix, double scale_x, double scale_y);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_transform_distance(System.IntPtr matrix, System.IntPtr dx, System.IntPtr dy);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_transform_pixel_rectangle(System.IntPtr matrix, System.IntPtr rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_transform_point(System.IntPtr matrix, System.IntPtr x, System.IntPtr y);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_transform_rectangle(System.IntPtr matrix, System.IntPtr rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_matrix_translate(System.IntPtr matrix, double tx, double ty);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_metrics_new();
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_approximate_char_width(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_approximate_digit_width(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_ascent(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_descent(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_strikethrough_position(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_strikethrough_thickness(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_underline_position(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_metrics_get_underline_thickness(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_metrics_ref(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_metrics_unref(System.IntPtr metrics);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_font_family_get_name(System.IntPtr family);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_family_is_monospace(System.IntPtr family);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_family_list_faces(System.IntPtr family, System.IntPtr faces, System.IntPtr n_faces);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_fontset_foreach(System.IntPtr fontset, System.IntPtr func, System.IntPtr data);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_fontset_get_font(System.IntPtr fontset, uint wc);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_fontset_get_metrics(System.IntPtr fontset);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_coverage_copy(System.IntPtr coverage);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_coverage_get(System.IntPtr coverage, int index_);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_coverage_max(System.IntPtr coverage, System.IntPtr other);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_coverage_ref(System.IntPtr coverage);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_coverage_set(System.IntPtr coverage, int index_, int level);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_coverage_to_bytes(System.IntPtr coverage, System.IntPtr bytes, System.IntPtr n_bytes);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_coverage_unref(System.IntPtr coverage);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_coverage_from_bytes(System.IntPtr bytes, int n_bytes);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_coverage_new();
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_script_for_unichar(uint ch);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_script_get_sample_language(int script);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_glyph_string_new();
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_glyph_string_copy(System.IntPtr @string);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_string_extents(System.IntPtr glyphs, System.IntPtr font, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_string_extents_range(System.IntPtr glyphs, int start, int end, System.IntPtr font, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_string_free(System.IntPtr @string);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_string_get_logical_widths(System.IntPtr glyphs, string text, int length, int embedding_level, System.IntPtr logical_widths);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_glyph_string_get_width(System.IntPtr glyphs);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_string_index_to_x(System.IntPtr glyphs, string text, int length, System.IntPtr analysis, int index_, int trailing, System.IntPtr x_pos);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_string_set_size(System.IntPtr @string, int new_len);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_string_x_to_index(System.IntPtr glyphs, string text, int length, System.IntPtr analysis, int x_pos, System.IntPtr index_, System.IntPtr trailing);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_font_face_describe(System.IntPtr face);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_font_face_get_face_name(System.IntPtr face);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_font_face_is_synthesized(System.IntPtr face);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_font_face_list_sizes(System.IntPtr face, System.IntPtr sizes, System.IntPtr n_sizes);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_fontset_simple_new(System.IntPtr language);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_fontset_simple_append(System.IntPtr fontset, System.IntPtr font);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_fontset_simple_size(System.IntPtr fontset);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_item_new();
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_item_copy(System.IntPtr item);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_item_free(System.IntPtr item);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_item_split(System.IntPtr orig, int split_index, int split_offset);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_glyph_item_iter_copy(System.IntPtr orig);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_glyph_item_iter_free(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_glyph_item_iter_init_end(System.IntPtr iter, System.IntPtr glyph_item, string text);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_glyph_item_iter_init_start(System.IntPtr iter, System.IntPtr glyph_item, string text);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_glyph_item_iter_next_cluster(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_glyph_item_iter_prev_cluster(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_new(System.IntPtr context);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_context_changed(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_copy(System.IntPtr src);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_alignment(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_attributes(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_auto_dir(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_baseline(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_character_count(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_context(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_get_cursor_pos(System.IntPtr layout, int index_, System.IntPtr strong_pos, System.IntPtr weak_pos);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_ellipsize(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_get_extents(System.IntPtr layout, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_font_description(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_height(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_indent(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_iter(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_justify(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_line(System.IntPtr layout, int line);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_line_count(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_line_readonly(System.IntPtr layout, int line);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_lines(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_lines_readonly(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_get_log_attrs(System.IntPtr layout, System.IntPtr attrs, System.IntPtr n_attrs);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_log_attrs_readonly(System.IntPtr layout, System.IntPtr n_attrs);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_get_pixel_extents(System.IntPtr layout, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_get_pixel_size(System.IntPtr layout, System.IntPtr width, System.IntPtr height);
        [DllImport("libpango-1.0.so.0")]
        public static extern uint pango_layout_get_serial(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_single_paragraph_mode(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_get_size(System.IntPtr layout, System.IntPtr width, System.IntPtr height);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_spacing(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_get_tabs(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern string pango_layout_get_text(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_unknown_glyphs_count(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_width(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_get_wrap(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_index_to_line_x(System.IntPtr layout, int index_, int trailing, System.IntPtr line, System.IntPtr x_pos);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_index_to_pos(System.IntPtr layout, int index_, System.IntPtr pos);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_is_ellipsized(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_is_wrapped(System.IntPtr layout);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_move_cursor_visually(System.IntPtr layout, int strong, int old_index, int old_trailing, int direction, System.IntPtr new_index, System.IntPtr new_trailing);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_alignment(System.IntPtr layout, int alignment);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_attributes(System.IntPtr layout, System.IntPtr attrs);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_auto_dir(System.IntPtr layout, int auto_dir);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_ellipsize(System.IntPtr layout, int ellipsize);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_font_description(System.IntPtr layout, System.IntPtr desc);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_height(System.IntPtr layout, int height);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_indent(System.IntPtr layout, int indent);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_justify(System.IntPtr layout, int justify);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_markup(System.IntPtr layout, string markup, int length);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_markup_with_accel(System.IntPtr layout, string markup, int length, uint accel_marker, System.IntPtr accel_char);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_single_paragraph_mode(System.IntPtr layout, int setting);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_spacing(System.IntPtr layout, int spacing);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_tabs(System.IntPtr layout, System.IntPtr tabs);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_text(System.IntPtr layout, string text, int length);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_width(System.IntPtr layout, int width);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_set_wrap(System.IntPtr layout, int wrap);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_xy_to_index(System.IntPtr layout, int x, int y, System.IntPtr index_, System.IntPtr trailing);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_iter_at_last_line(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_iter_copy(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_iter_free(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_iter_get_baseline(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_iter_get_char_extents(System.IntPtr iter, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_iter_get_cluster_extents(System.IntPtr iter, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_iter_get_index(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_iter_get_layout(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_iter_get_layout_extents(System.IntPtr iter, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_iter_get_line(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_iter_get_line_extents(System.IntPtr iter, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_iter_get_line_readonly(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_iter_get_line_yrange(System.IntPtr iter, System.IntPtr y0_, System.IntPtr y1_);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_iter_get_run(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_iter_get_run_extents(System.IntPtr iter, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_iter_get_run_readonly(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_iter_next_char(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_iter_next_cluster(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_iter_next_line(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_iter_next_run(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_line_get_extents(System.IntPtr line, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_line_get_pixel_extents(System.IntPtr layout_line, System.IntPtr ink_rect, System.IntPtr logical_rect);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_line_get_x_ranges(System.IntPtr line, int start_index, int end_index, System.IntPtr ranges, System.IntPtr n_ranges);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_line_index_to_x(System.IntPtr line, int index_, int trailing, System.IntPtr x_pos);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_layout_line_ref(System.IntPtr line);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_layout_line_unref(System.IntPtr line);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_layout_line_x_to_index(System.IntPtr line, int x_pos, System.IntPtr index_, System.IntPtr trailing);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_tab_array_new(int initial_size, int positions_in_pixels);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_tab_array_copy(System.IntPtr src);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_tab_array_free(System.IntPtr tab_array);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_tab_array_get_positions_in_pixels(System.IntPtr tab_array);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_tab_array_get_size(System.IntPtr tab_array);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_tab_array_get_tab(System.IntPtr tab_array, int tab_index, System.IntPtr alignment, System.IntPtr location);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_tab_array_get_tabs(System.IntPtr tab_array, System.IntPtr alignments, System.IntPtr locations);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_tab_array_resize(System.IntPtr tab_array, int new_size);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_tab_array_set_tab(System.IntPtr tab_array, int tab_index, int alignment, int location);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_map_get_engine(System.IntPtr map, int script);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_map_get_engines(System.IntPtr map, int script, System.IntPtr exact_engines, System.IntPtr fallback_engines);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_activate(System.IntPtr renderer);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_deactivate(System.IntPtr renderer);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_error_underline(System.IntPtr renderer, int x, int y, int width, int height);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_glyph(System.IntPtr renderer, System.IntPtr font, uint glyph, double x, double y);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_glyph_item(System.IntPtr renderer, string text, System.IntPtr glyph_item, int x, int y);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_glyphs(System.IntPtr renderer, System.IntPtr font, System.IntPtr glyphs, int x, int y);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_layout(System.IntPtr renderer, System.IntPtr layout, int x, int y);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_layout_line(System.IntPtr renderer, System.IntPtr line, int x, int y);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_rectangle(System.IntPtr renderer, int part, int x, int y, int width, int height);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_draw_trapezoid(System.IntPtr renderer, int part, double y1_, double x11, double x21, double y2, double x12, double x22);
        [DllImport("libpango-1.0.so.0")]
        public static extern ushort pango_renderer_get_alpha(System.IntPtr renderer, int part);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_renderer_get_color(System.IntPtr renderer, int part);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_renderer_get_layout(System.IntPtr renderer);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_renderer_get_layout_line(System.IntPtr renderer);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_renderer_get_matrix(System.IntPtr renderer);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_part_changed(System.IntPtr renderer, int part);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_set_alpha(System.IntPtr renderer, int part, ushort alpha);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_set_color(System.IntPtr renderer, int part, System.IntPtr color);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_renderer_set_matrix(System.IntPtr renderer, System.IntPtr matrix);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_script_iter_free(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern void pango_script_iter_get_range(System.IntPtr iter, string start, string end, System.IntPtr script);
        [DllImport("libpango-1.0.so.0")]
        public static extern int pango_script_iter_next(System.IntPtr iter);
        [DllImport("libpango-1.0.so.0")]
        public static extern System.IntPtr pango_script_iter_new(string text, int length);
    }
}