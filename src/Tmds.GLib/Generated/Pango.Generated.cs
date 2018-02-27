using System;
using System.Runtime.InteropServices;
namespace Pango {
	public ref struct GlyphItem
	{
		private IntPtr _pointer;
		public GlyphItem(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator GlyphItem(IntPtr pointer) => new GlyphItem(pointer, checkType: true);
		public static explicit operator IntPtr(GlyphItem value) => value._pointer;
		public System.IntPtr apply_attrs(string text, Pango.AttrList list) => Pango.PangoInterop.pango_glyph_item_apply_attrs(this, text, list);
		public Pango.GlyphItem copy() => Pango.PangoInterop.pango_glyph_item_copy(this);
		public void free() => Pango.PangoInterop.pango_glyph_item_free(this);
		public void get_logical_widths(string text, System.IntPtr logical_widths) => Pango.PangoInterop.pango_glyph_item_get_logical_widths(this, text, logical_widths);
		public void letter_space(string text, System.IntPtr log_attrs, int letter_spacing) => Pango.PangoInterop.pango_glyph_item_letter_space(this, text, log_attrs, letter_spacing);
		public Pango.GlyphItem split(string text, int split_index) => Pango.PangoInterop.pango_glyph_item_split(this, text, split_index);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_glyph_item_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum Alignment
	{
		left = 0,
		center = 1,
		right = 2,
	}
	public ref struct EngineShape
	{
		private IntPtr _pointer;
		public EngineShape(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator EngineShape(IntPtr pointer) => new EngineShape(pointer, checkType: true);
		public static explicit operator IntPtr(EngineShape value) => value._pointer;
		public static implicit operator Pango.Engine(EngineShape value) => new Pango.Engine((IntPtr)value, checkType: false);
		public static explicit operator EngineShape(Pango.Engine value) => new EngineShape((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(EngineShape value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator EngineShape(GObject.Object value) => new EngineShape((IntPtr)value, checkType: true);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_engine_shape_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct EngineLang
	{
		private IntPtr _pointer;
		public EngineLang(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator EngineLang(IntPtr pointer) => new EngineLang(pointer, checkType: true);
		public static explicit operator IntPtr(EngineLang value) => value._pointer;
		public static implicit operator Pango.Engine(EngineLang value) => new Pango.Engine((IntPtr)value, checkType: false);
		public static explicit operator EngineLang(Pango.Engine value) => new EngineLang((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(EngineLang value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator EngineLang(GObject.Object value) => new EngineLang((IntPtr)value, checkType: true);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_engine_lang_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Font
	{
		private IntPtr _pointer;
		public Font(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Font(IntPtr pointer) => new Font(pointer, checkType: true);
		public static explicit operator IntPtr(Font value) => value._pointer;
		public static implicit operator GObject.Object(Font value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Font(GObject.Object value) => new Font((IntPtr)value, checkType: true);
		public static void descriptions_free(System.IntPtr descs, int n_descs) => PangoInterop.pango_font_descriptions_free(descs, n_descs);
		public Pango.FontDescription describe() => Pango.PangoInterop.pango_font_describe(this);
		public Pango.FontDescription describe_with_absolute_size() => Pango.PangoInterop.pango_font_describe_with_absolute_size(this);
		public Pango.EngineShape find_shaper(Pango.Language language, uint ch) => Pango.PangoInterop.pango_font_find_shaper(this, language, ch);
		public Pango.Coverage get_coverage(Pango.Language language) => Pango.PangoInterop.pango_font_get_coverage(this, language);
		public Pango.FontMap get_font_map() => Pango.PangoInterop.pango_font_get_font_map(this);
		public Pango.FontMetrics get_metrics(Pango.Language language) => Pango.PangoInterop.pango_font_get_metrics(this, language);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_font_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Language
	{
		private IntPtr _pointer;
		public Language(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Language(IntPtr pointer) => new Language(pointer, checkType: true);
		public static explicit operator IntPtr(Language value) => value._pointer;
		public string get_sample_string() => Pango.PangoInterop.pango_language_get_sample_string(this);
		public System.IntPtr get_scripts(System.IntPtr num_scripts) => Pango.PangoInterop.pango_language_get_scripts(this, num_scripts);
		public bool includes_script(Pango.Script script) => Pango.PangoInterop.pango_language_includes_script(this, script);
		public bool matches(string range_list) => Pango.PangoInterop.pango_language_matches(this, range_list);
		public string to_string() => Pango.PangoInterop.pango_language_to_string(this);
		public static Pango.Language from_string(string language) => PangoInterop.pango_language_from_string(language);
		public static Pango.Language get_default() => PangoInterop.pango_language_get_default();
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_language_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Analysis
	{
		private IntPtr _pointer;
		public Analysis(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Analysis(IntPtr pointer) => new Analysis(pointer, checkType: true);
		public static explicit operator IntPtr(Analysis value) => value._pointer;
	}
	public enum AttrType
	{
		invalid = 0,
		language = 1,
		family = 2,
		style = 3,
		weight = 4,
		variant = 5,
		stretch = 6,
		size = 7,
		font_desc = 8,
		foreground = 9,
		background = 10,
		underline = 11,
		strikethrough = 12,
		rise = 13,
		shape = 14,
		scale = 15,
		fallback = 16,
		letter_spacing = 17,
		underline_color = 18,
		strikethrough_color = 19,
		absolute_size = 20,
		gravity = 21,
		gravity_hint = 22,
		font_features = 23,
		foreground_alpha = 24,
		background_alpha = 25,
	}
	public ref struct Attribute
	{
		private IntPtr _pointer;
		public Attribute(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Attribute(IntPtr pointer) => new Attribute(pointer, checkType: true);
		public static explicit operator IntPtr(Attribute value) => value._pointer;
		public Pango.Attribute copy() => Pango.PangoInterop.pango_attribute_copy(this);
		public void destroy() => Pango.PangoInterop.pango_attribute_destroy(this);
		public bool equal(Pango.Attribute attr2) => Pango.PangoInterop.pango_attribute_equal(this, attr2);
		public void init(Pango.AttrClass klass) => Pango.PangoInterop.pango_attribute_init(this, klass);
	}
	public ref struct AttrClass
	{
		private IntPtr _pointer;
		public AttrClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrClass(IntPtr pointer) => new AttrClass(pointer, checkType: true);
		public static explicit operator IntPtr(AttrClass value) => value._pointer;
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
		public Pango.Color copy() => Pango.PangoInterop.pango_color_copy(this);
		public void free() => Pango.PangoInterop.pango_color_free(this);
		public bool parse(string spec) => Pango.PangoInterop.pango_color_parse(this, spec);
		public string to_string() => Pango.PangoInterop.pango_color_to_string(this);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_color_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct AttrColor
	{
		private IntPtr _pointer;
		public AttrColor(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrColor(IntPtr pointer) => new AttrColor(pointer, checkType: true);
		public static explicit operator IntPtr(AttrColor value) => value._pointer;
	}
	public ref struct AttrFloat
	{
		private IntPtr _pointer;
		public AttrFloat(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrFloat(IntPtr pointer) => new AttrFloat(pointer, checkType: true);
		public static explicit operator IntPtr(AttrFloat value) => value._pointer;
	}
	public ref struct FontDescription
	{
		private IntPtr _pointer;
		public FontDescription(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontDescription(IntPtr pointer) => new FontDescription(pointer, checkType: true);
		public static explicit operator IntPtr(FontDescription value) => value._pointer;
		public static Pango.FontDescription @new() => PangoInterop.pango_font_description_new();
		public bool better_match(Pango.FontDescription old_match, Pango.FontDescription new_match) => Pango.PangoInterop.pango_font_description_better_match(this, old_match, new_match);
		public Pango.FontDescription copy() => Pango.PangoInterop.pango_font_description_copy(this);
		public Pango.FontDescription copy_static() => Pango.PangoInterop.pango_font_description_copy_static(this);
		public bool equal(Pango.FontDescription desc2) => Pango.PangoInterop.pango_font_description_equal(this, desc2);
		public void free() => Pango.PangoInterop.pango_font_description_free(this);
		public string get_family() => Pango.PangoInterop.pango_font_description_get_family(this);
		public Pango.Gravity get_gravity() => Pango.PangoInterop.pango_font_description_get_gravity(this);
		public Pango.FontMask get_set_fields() => Pango.PangoInterop.pango_font_description_get_set_fields(this);
		public int get_size() => Pango.PangoInterop.pango_font_description_get_size(this);
		public bool get_size_is_absolute() => Pango.PangoInterop.pango_font_description_get_size_is_absolute(this);
		public Pango.Stretch get_stretch() => Pango.PangoInterop.pango_font_description_get_stretch(this);
		public Pango.Style get_style() => Pango.PangoInterop.pango_font_description_get_style(this);
		public Pango.Variant get_variant() => Pango.PangoInterop.pango_font_description_get_variant(this);
		public Pango.Weight get_weight() => Pango.PangoInterop.pango_font_description_get_weight(this);
		public uint hash() => Pango.PangoInterop.pango_font_description_hash(this);
		public void merge(Pango.FontDescription desc_to_merge, bool replace_existing) => Pango.PangoInterop.pango_font_description_merge(this, desc_to_merge, replace_existing);
		public void merge_static(Pango.FontDescription desc_to_merge, bool replace_existing) => Pango.PangoInterop.pango_font_description_merge_static(this, desc_to_merge, replace_existing);
		public void set_absolute_size(double size) => Pango.PangoInterop.pango_font_description_set_absolute_size(this, size);
		public void set_family(string family) => Pango.PangoInterop.pango_font_description_set_family(this, family);
		public void set_family_static(string family) => Pango.PangoInterop.pango_font_description_set_family_static(this, family);
		public void set_gravity(Pango.Gravity gravity) => Pango.PangoInterop.pango_font_description_set_gravity(this, gravity);
		public void set_size(int size) => Pango.PangoInterop.pango_font_description_set_size(this, size);
		public void set_stretch(Pango.Stretch stretch) => Pango.PangoInterop.pango_font_description_set_stretch(this, stretch);
		public void set_style(Pango.Style style) => Pango.PangoInterop.pango_font_description_set_style(this, style);
		public void set_variant(Pango.Variant variant) => Pango.PangoInterop.pango_font_description_set_variant(this, variant);
		public void set_weight(Pango.Weight weight) => Pango.PangoInterop.pango_font_description_set_weight(this, weight);
		public string to_filename() => Pango.PangoInterop.pango_font_description_to_filename(this);
		public string to_string() => Pango.PangoInterop.pango_font_description_to_string(this);
		public void unset_fields(Pango.FontMask to_unset) => Pango.PangoInterop.pango_font_description_unset_fields(this, to_unset);
		public static Pango.FontDescription from_string(string str) => PangoInterop.pango_font_description_from_string(str);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_font_description_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct AttrFontDesc
	{
		private IntPtr _pointer;
		public AttrFontDesc(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrFontDesc(IntPtr pointer) => new AttrFontDesc(pointer, checkType: true);
		public static explicit operator IntPtr(AttrFontDesc value) => value._pointer;
		public static Pango.Attribute @new(Pango.FontDescription desc) => PangoInterop.pango_attr_font_desc_new(desc);
	}
	public ref struct AttrFontFeatures
	{
		private IntPtr _pointer;
		public AttrFontFeatures(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrFontFeatures(IntPtr pointer) => new AttrFontFeatures(pointer, checkType: true);
		public static explicit operator IntPtr(AttrFontFeatures value) => value._pointer;
		public static Pango.Attribute @new(string features) => PangoInterop.pango_attr_font_features_new(features);
	}
	public ref struct AttrInt
	{
		private IntPtr _pointer;
		public AttrInt(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrInt(IntPtr pointer) => new AttrInt(pointer, checkType: true);
		public static explicit operator IntPtr(AttrInt value) => value._pointer;
	}
	public ref struct AttrIterator
	{
		private IntPtr _pointer;
		public AttrIterator(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrIterator(IntPtr pointer) => new AttrIterator(pointer, checkType: true);
		public static explicit operator IntPtr(AttrIterator value) => value._pointer;
		public Pango.AttrIterator copy() => Pango.PangoInterop.pango_attr_iterator_copy(this);
		public void destroy() => Pango.PangoInterop.pango_attr_iterator_destroy(this);
		public Pango.Attribute get(Pango.AttrType type) => Pango.PangoInterop.pango_attr_iterator_get(this, type);
		public System.IntPtr get_attrs() => Pango.PangoInterop.pango_attr_iterator_get_attrs(this);
		public bool next() => Pango.PangoInterop.pango_attr_iterator_next(this);
		public void range(System.IntPtr start, System.IntPtr end) => Pango.PangoInterop.pango_attr_iterator_range(this, start, end);
	}
	public ref struct AttrLanguage
	{
		private IntPtr _pointer;
		public AttrLanguage(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrLanguage(IntPtr pointer) => new AttrLanguage(pointer, checkType: true);
		public static explicit operator IntPtr(AttrLanguage value) => value._pointer;
		public static Pango.Attribute @new(Pango.Language language) => PangoInterop.pango_attr_language_new(language);
	}
	public ref struct AttrList
	{
		private IntPtr _pointer;
		public AttrList(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrList(IntPtr pointer) => new AttrList(pointer, checkType: true);
		public static explicit operator IntPtr(AttrList value) => value._pointer;
		public static Pango.AttrList @new() => PangoInterop.pango_attr_list_new();
		public void change(Pango.Attribute attr) => Pango.PangoInterop.pango_attr_list_change(this, attr);
		public Pango.AttrList copy() => Pango.PangoInterop.pango_attr_list_copy(this);
		public Pango.AttrList filter(System.IntPtr func, System.IntPtr data) => Pango.PangoInterop.pango_attr_list_filter(this, func, data);
		public Pango.AttrIterator get_iterator() => Pango.PangoInterop.pango_attr_list_get_iterator(this);
		public void insert(Pango.Attribute attr) => Pango.PangoInterop.pango_attr_list_insert(this, attr);
		public void insert_before(Pango.Attribute attr) => Pango.PangoInterop.pango_attr_list_insert_before(this, attr);
		public Pango.AttrList @ref() => Pango.PangoInterop.pango_attr_list_ref(this);
		public void splice(Pango.AttrList other, int pos, int len) => Pango.PangoInterop.pango_attr_list_splice(this, other, pos, len);
		public void unref() => Pango.PangoInterop.pango_attr_list_unref(this);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_attr_list_get_type")]
		public static extern GLib.GType TypeOf();
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
	}
	public ref struct AttrShape
	{
		private IntPtr _pointer;
		public AttrShape(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrShape(IntPtr pointer) => new AttrShape(pointer, checkType: true);
		public static explicit operator IntPtr(AttrShape value) => value._pointer;
		public static Pango.Attribute @new(Pango.Rectangle ink_rect, Pango.Rectangle logical_rect) => PangoInterop.pango_attr_shape_new(ink_rect, logical_rect);
		public static Pango.Attribute new_with_data(Pango.Rectangle ink_rect, Pango.Rectangle logical_rect, System.IntPtr data, System.IntPtr copy_func, System.IntPtr destroy_func) => PangoInterop.pango_attr_shape_new_with_data(ink_rect, logical_rect, data, copy_func, destroy_func);
	}
	public ref struct AttrSize
	{
		private IntPtr _pointer;
		public AttrSize(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrSize(IntPtr pointer) => new AttrSize(pointer, checkType: true);
		public static explicit operator IntPtr(AttrSize value) => value._pointer;
		public static Pango.Attribute @new(int size) => PangoInterop.pango_attr_size_new(size);
		public static Pango.Attribute new_absolute(int size) => PangoInterop.pango_attr_size_new_absolute(size);
	}
	public ref struct AttrString
	{
		private IntPtr _pointer;
		public AttrString(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AttrString(IntPtr pointer) => new AttrString(pointer, checkType: true);
		public static explicit operator IntPtr(AttrString value) => value._pointer;
	}
	public enum BidiType
	{
		l = 0,
		lre = 1,
		lro = 2,
		r = 3,
		al = 4,
		rle = 5,
		rlo = 6,
		pdf = 7,
		en = 8,
		es = 9,
		et = 10,
		an = 11,
		cs = 12,
		nsm = 13,
		bn = 14,
		b = 15,
		s = 16,
		ws = 17,
		on = 18,
	}
	public ref struct Context
	{
		private IntPtr _pointer;
		public Context(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Context(IntPtr pointer) => new Context(pointer, checkType: true);
		public static explicit operator IntPtr(Context value) => value._pointer;
		public static implicit operator GObject.Object(Context value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Context(GObject.Object value) => new Context((IntPtr)value, checkType: true);
		public static Pango.Context @new() => PangoInterop.pango_context_new();
		public void changed() => Pango.PangoInterop.pango_context_changed(this);
		public Pango.Direction get_base_dir() => Pango.PangoInterop.pango_context_get_base_dir(this);
		public Pango.Gravity get_base_gravity() => Pango.PangoInterop.pango_context_get_base_gravity(this);
		public Pango.FontDescription get_font_description() => Pango.PangoInterop.pango_context_get_font_description(this);
		public Pango.FontMap get_font_map() => Pango.PangoInterop.pango_context_get_font_map(this);
		public Pango.Gravity get_gravity() => Pango.PangoInterop.pango_context_get_gravity(this);
		public Pango.GravityHint get_gravity_hint() => Pango.PangoInterop.pango_context_get_gravity_hint(this);
		public Pango.Language get_language() => Pango.PangoInterop.pango_context_get_language(this);
		public Pango.Matrix get_matrix() => Pango.PangoInterop.pango_context_get_matrix(this);
		public Pango.FontMetrics get_metrics(Pango.FontDescription desc, Pango.Language language) => Pango.PangoInterop.pango_context_get_metrics(this, desc, language);
		public uint get_serial() => Pango.PangoInterop.pango_context_get_serial(this);
		public void list_families(System.IntPtr families, System.IntPtr n_families) => Pango.PangoInterop.pango_context_list_families(this, families, n_families);
		public Pango.Font load_font(Pango.FontDescription desc) => Pango.PangoInterop.pango_context_load_font(this, desc);
		public Pango.Fontset load_fontset(Pango.FontDescription desc, Pango.Language language) => Pango.PangoInterop.pango_context_load_fontset(this, desc, language);
		public void set_base_dir(Pango.Direction direction) => Pango.PangoInterop.pango_context_set_base_dir(this, direction);
		public void set_base_gravity(Pango.Gravity gravity) => Pango.PangoInterop.pango_context_set_base_gravity(this, gravity);
		public void set_font_description(Pango.FontDescription desc) => Pango.PangoInterop.pango_context_set_font_description(this, desc);
		public void set_font_map(Pango.FontMap font_map) => Pango.PangoInterop.pango_context_set_font_map(this, font_map);
		public void set_gravity_hint(Pango.GravityHint hint) => Pango.PangoInterop.pango_context_set_gravity_hint(this, hint);
		public void set_language(Pango.Language language) => Pango.PangoInterop.pango_context_set_language(this, language);
		public void set_matrix(Pango.Matrix matrix) => Pango.PangoInterop.pango_context_set_matrix(this, matrix);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_context_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum Direction
	{
		ltr = 0,
		rtl = 1,
		ttb_ltr = 2,
		ttb_rtl = 3,
		weak_ltr = 4,
		weak_rtl = 5,
		neutral = 6,
	}
	public enum Gravity
	{
		south = 0,
		east = 1,
		north = 2,
		west = 3,
		auto = 4,
	}
	public ref struct FontMap
	{
		private IntPtr _pointer;
		public FontMap(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator FontMap(IntPtr pointer) => new FontMap(pointer, checkType: true);
		public static explicit operator IntPtr(FontMap value) => value._pointer;
		public static implicit operator GObject.Object(FontMap value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator FontMap(GObject.Object value) => new FontMap((IntPtr)value, checkType: true);
		public void changed() => Pango.PangoInterop.pango_font_map_changed(this);
		public Pango.Context create_context() => Pango.PangoInterop.pango_font_map_create_context(this);
		public uint get_serial() => Pango.PangoInterop.pango_font_map_get_serial(this);
		public string get_shape_engine_type() => Pango.PangoInterop.pango_font_map_get_shape_engine_type(this);
		public void list_families(System.IntPtr families, System.IntPtr n_families) => Pango.PangoInterop.pango_font_map_list_families(this, families, n_families);
		public Pango.Font load_font(Pango.Context context, Pango.FontDescription desc) => Pango.PangoInterop.pango_font_map_load_font(this, context, desc);
		public Pango.Fontset load_fontset(Pango.Context context, Pango.FontDescription desc, Pango.Language language) => Pango.PangoInterop.pango_font_map_load_fontset(this, context, desc, language);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_font_map_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum GravityHint
	{
		natural = 0,
		strong = 1,
		line = 2,
	}
	public ref struct Matrix
	{
		private IntPtr _pointer;
		public Matrix(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Matrix(IntPtr pointer) => new Matrix(pointer, checkType: true);
		public static explicit operator IntPtr(Matrix value) => value._pointer;
		public void concat(Pango.Matrix new_matrix) => Pango.PangoInterop.pango_matrix_concat(this, new_matrix);
		public Pango.Matrix copy() => Pango.PangoInterop.pango_matrix_copy(this);
		public void free() => Pango.PangoInterop.pango_matrix_free(this);
		public double get_font_scale_factor() => Pango.PangoInterop.pango_matrix_get_font_scale_factor(this);
		public void get_font_scale_factors(System.IntPtr xscale, System.IntPtr yscale) => Pango.PangoInterop.pango_matrix_get_font_scale_factors(this, xscale, yscale);
		public void rotate(double degrees) => Pango.PangoInterop.pango_matrix_rotate(this, degrees);
		public void scale(double scale_x, double scale_y) => Pango.PangoInterop.pango_matrix_scale(this, scale_x, scale_y);
		public void transform_distance(System.IntPtr dx, System.IntPtr dy) => Pango.PangoInterop.pango_matrix_transform_distance(this, dx, dy);
		public void transform_point(System.IntPtr x, System.IntPtr y) => Pango.PangoInterop.pango_matrix_transform_point(this, x, y);
		public void translate(double tx, double ty) => Pango.PangoInterop.pango_matrix_translate(this, tx, ty);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_matrix_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct FontMetrics
	{
		private IntPtr _pointer;
		public FontMetrics(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontMetrics(IntPtr pointer) => new FontMetrics(pointer, checkType: true);
		public static explicit operator IntPtr(FontMetrics value) => value._pointer;
		public static Pango.FontMetrics @new() => PangoInterop.pango_font_metrics_new();
		public int get_approximate_char_width() => Pango.PangoInterop.pango_font_metrics_get_approximate_char_width(this);
		public int get_approximate_digit_width() => Pango.PangoInterop.pango_font_metrics_get_approximate_digit_width(this);
		public int get_ascent() => Pango.PangoInterop.pango_font_metrics_get_ascent(this);
		public int get_descent() => Pango.PangoInterop.pango_font_metrics_get_descent(this);
		public int get_strikethrough_position() => Pango.PangoInterop.pango_font_metrics_get_strikethrough_position(this);
		public int get_strikethrough_thickness() => Pango.PangoInterop.pango_font_metrics_get_strikethrough_thickness(this);
		public int get_underline_position() => Pango.PangoInterop.pango_font_metrics_get_underline_position(this);
		public int get_underline_thickness() => Pango.PangoInterop.pango_font_metrics_get_underline_thickness(this);
		public Pango.FontMetrics @ref() => Pango.PangoInterop.pango_font_metrics_ref(this);
		public void unref() => Pango.PangoInterop.pango_font_metrics_unref(this);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_font_metrics_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct FontFamily
	{
		private IntPtr _pointer;
		public FontFamily(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator FontFamily(IntPtr pointer) => new FontFamily(pointer, checkType: true);
		public static explicit operator IntPtr(FontFamily value) => value._pointer;
		public static implicit operator GObject.Object(FontFamily value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator FontFamily(GObject.Object value) => new FontFamily((IntPtr)value, checkType: true);
		public string get_name() => Pango.PangoInterop.pango_font_family_get_name(this);
		public bool is_monospace() => Pango.PangoInterop.pango_font_family_is_monospace(this);
		public void list_faces(System.IntPtr faces, System.IntPtr n_faces) => Pango.PangoInterop.pango_font_family_list_faces(this, faces, n_faces);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_font_family_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Fontset
	{
		private IntPtr _pointer;
		public Fontset(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Fontset(IntPtr pointer) => new Fontset(pointer, checkType: true);
		public static explicit operator IntPtr(Fontset value) => value._pointer;
		public static implicit operator GObject.Object(Fontset value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Fontset(GObject.Object value) => new Fontset((IntPtr)value, checkType: true);
		public void @foreach(System.IntPtr func, System.IntPtr data) => Pango.PangoInterop.pango_fontset_foreach(this, func, data);
		public Pango.Font get_font(uint wc) => Pango.PangoInterop.pango_fontset_get_font(this, wc);
		public Pango.FontMetrics get_metrics() => Pango.PangoInterop.pango_fontset_get_metrics(this);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_fontset_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ContextClass
	{
		private IntPtr _pointer;
		public ContextClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ContextClass(IntPtr pointer) => new ContextClass(pointer, checkType: true);
		public static explicit operator IntPtr(ContextClass value) => value._pointer;
	}
	public ref struct Coverage
	{
		private IntPtr _pointer;
		public Coverage(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Coverage(IntPtr pointer) => new Coverage(pointer, checkType: true);
		public static explicit operator IntPtr(Coverage value) => value._pointer;
		public Pango.Coverage copy() => Pango.PangoInterop.pango_coverage_copy(this);
		public Pango.CoverageLevel get(int index_) => Pango.PangoInterop.pango_coverage_get(this, index_);
		public void max(Pango.Coverage other) => Pango.PangoInterop.pango_coverage_max(this, other);
		public Pango.Coverage @ref() => Pango.PangoInterop.pango_coverage_ref(this);
		public void set(int index_, Pango.CoverageLevel level) => Pango.PangoInterop.pango_coverage_set(this, index_, level);
		public void to_bytes(System.IntPtr bytes, System.IntPtr n_bytes) => Pango.PangoInterop.pango_coverage_to_bytes(this, bytes, n_bytes);
		public void unref() => Pango.PangoInterop.pango_coverage_unref(this);
		public static Pango.Coverage from_bytes(System.IntPtr bytes, int n_bytes) => PangoInterop.pango_coverage_from_bytes(bytes, n_bytes);
		public static Pango.Coverage @new() => PangoInterop.pango_coverage_new();
	}
	public enum CoverageLevel
	{
		none = 0,
		fallback = 1,
		approximate = 2,
		exact = 3,
	}
	public enum EllipsizeMode
	{
		none = 0,
		start = 1,
		middle = 2,
		end = 3,
	}
	public ref struct Engine
	{
		private IntPtr _pointer;
		public Engine(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Engine(IntPtr pointer) => new Engine(pointer, checkType: true);
		public static explicit operator IntPtr(Engine value) => value._pointer;
		public static implicit operator GObject.Object(Engine value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Engine(GObject.Object value) => new Engine((IntPtr)value, checkType: true);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_engine_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct EngineClass
	{
		private IntPtr _pointer;
		public EngineClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EngineClass(IntPtr pointer) => new EngineClass(pointer, checkType: true);
		public static explicit operator IntPtr(EngineClass value) => value._pointer;
	}
	public ref struct EngineScriptInfo
	{
		private IntPtr _pointer;
		public EngineScriptInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EngineScriptInfo(IntPtr pointer) => new EngineScriptInfo(pointer, checkType: true);
		public static explicit operator IntPtr(EngineScriptInfo value) => value._pointer;
	}
	public ref struct EngineInfo
	{
		private IntPtr _pointer;
		public EngineInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EngineInfo(IntPtr pointer) => new EngineInfo(pointer, checkType: true);
		public static explicit operator IntPtr(EngineInfo value) => value._pointer;
	}
	public ref struct LogAttr
	{
		private IntPtr _pointer;
		public LogAttr(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator LogAttr(IntPtr pointer) => new LogAttr(pointer, checkType: true);
		public static explicit operator IntPtr(LogAttr value) => value._pointer;
	}
	public ref struct EngineLangClass
	{
		private IntPtr _pointer;
		public EngineLangClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EngineLangClass(IntPtr pointer) => new EngineLangClass(pointer, checkType: true);
		public static explicit operator IntPtr(EngineLangClass value) => value._pointer;
	}
	public enum Script
	{
		invalid_code = -1,
		common = 0,
		inherited = 1,
		arabic = 2,
		armenian = 3,
		bengali = 4,
		bopomofo = 5,
		cherokee = 6,
		coptic = 7,
		cyrillic = 8,
		deseret = 9,
		devanagari = 10,
		ethiopic = 11,
		georgian = 12,
		gothic = 13,
		greek = 14,
		gujarati = 15,
		gurmukhi = 16,
		han = 17,
		hangul = 18,
		hebrew = 19,
		hiragana = 20,
		kannada = 21,
		katakana = 22,
		khmer = 23,
		lao = 24,
		latin = 25,
		malayalam = 26,
		mongolian = 27,
		myanmar = 28,
		ogham = 29,
		old_italic = 30,
		oriya = 31,
		runic = 32,
		sinhala = 33,
		syriac = 34,
		tamil = 35,
		telugu = 36,
		thaana = 37,
		thai = 38,
		tibetan = 39,
		canadian_aboriginal = 40,
		yi = 41,
		tagalog = 42,
		hanunoo = 43,
		buhid = 44,
		tagbanwa = 45,
		braille = 46,
		cypriot = 47,
		limbu = 48,
		osmanya = 49,
		shavian = 50,
		linear_b = 51,
		tai_le = 52,
		ugaritic = 53,
		new_tai_lue = 54,
		buginese = 55,
		glagolitic = 56,
		tifinagh = 57,
		syloti_nagri = 58,
		old_persian = 59,
		kharoshthi = 60,
		unknown = 61,
		balinese = 62,
		cuneiform = 63,
		phoenician = 64,
		phags_pa = 65,
		nko = 66,
		kayah_li = 67,
		lepcha = 68,
		rejang = 69,
		sundanese = 70,
		saurashtra = 71,
		cham = 72,
		ol_chiki = 73,
		vai = 74,
		carian = 75,
		lycian = 76,
		lydian = 77,
		batak = 78,
		brahmi = 79,
		mandaic = 80,
		chakma = 81,
		meroitic_cursive = 82,
		meroitic_hieroglyphs = 83,
		miao = 84,
		sharada = 85,
		sora_sompeng = 86,
		takri = 87,
		bassa_vah = 88,
		caucasian_albanian = 89,
		duployan = 90,
		elbasan = 91,
		grantha = 92,
		khojki = 93,
		khudawadi = 94,
		linear_a = 95,
		mahajani = 96,
		manichaean = 97,
		mende_kikakui = 98,
		modi = 99,
		mro = 100,
		nabataean = 101,
		old_north_arabian = 102,
		old_permic = 103,
		pahawh_hmong = 104,
		palmyrene = 105,
		pau_cin_hau = 106,
		psalter_pahlavi = 107,
		siddham = 108,
		tirhuta = 109,
		warang_citi = 110,
		ahom = 111,
		anatolian_hieroglyphs = 112,
		hatran = 113,
		multani = 114,
		old_hungarian = 115,
		signwriting = 116,
	}
	public ref struct GlyphString
	{
		private IntPtr _pointer;
		public GlyphString(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator GlyphString(IntPtr pointer) => new GlyphString(pointer, checkType: true);
		public static explicit operator IntPtr(GlyphString value) => value._pointer;
		public static Pango.GlyphString @new() => PangoInterop.pango_glyph_string_new();
		public Pango.GlyphString copy() => Pango.PangoInterop.pango_glyph_string_copy(this);
		public void free() => Pango.PangoInterop.pango_glyph_string_free(this);
		public void get_logical_widths(string text, int length, int embedding_level, System.IntPtr logical_widths) => Pango.PangoInterop.pango_glyph_string_get_logical_widths(this, text, length, embedding_level, logical_widths);
		public int get_width() => Pango.PangoInterop.pango_glyph_string_get_width(this);
		public void index_to_x(string text, int length, Pango.Analysis analysis, int index_, bool trailing, System.IntPtr x_pos) => Pango.PangoInterop.pango_glyph_string_index_to_x(this, text, length, analysis, index_, trailing, x_pos);
		public void set_size(int new_len) => Pango.PangoInterop.pango_glyph_string_set_size(this, new_len);
		public void x_to_index(string text, int length, Pango.Analysis analysis, int x_pos, System.IntPtr index_, System.IntPtr trailing) => Pango.PangoInterop.pango_glyph_string_x_to_index(this, text, length, analysis, x_pos, index_, trailing);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_glyph_string_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct EngineShapeClass
	{
		private IntPtr _pointer;
		public EngineShapeClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EngineShapeClass(IntPtr pointer) => new EngineShapeClass(pointer, checkType: true);
		public static explicit operator IntPtr(EngineShapeClass value) => value._pointer;
	}
	public ref struct FontClass
	{
		private IntPtr _pointer;
		public FontClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontClass(IntPtr pointer) => new FontClass(pointer, checkType: true);
		public static explicit operator IntPtr(FontClass value) => value._pointer;
	}
	[Flags]
	public enum FontMask
	{
		family = 1,
		style = 2,
		variant = 4,
		weight = 8,
		stretch = 16,
		size = 32,
		gravity = 64,
	}
	public enum Stretch
	{
		ultra_condensed = 0,
		extra_condensed = 1,
		condensed = 2,
		semi_condensed = 3,
		normal = 4,
		semi_expanded = 5,
		expanded = 6,
		extra_expanded = 7,
		ultra_expanded = 8,
	}
	public enum Style
	{
		normal = 0,
		oblique = 1,
		italic = 2,
	}
	public enum Variant
	{
		normal = 0,
		small_caps = 1,
	}
	public enum Weight
	{
		thin = 100,
		ultralight = 200,
		light = 300,
		semilight = 350,
		book = 380,
		normal = 400,
		medium = 500,
		semibold = 600,
		bold = 700,
		ultrabold = 800,
		heavy = 900,
		ultraheavy = 1000,
	}
	public ref struct FontFace
	{
		private IntPtr _pointer;
		public FontFace(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator FontFace(IntPtr pointer) => new FontFace(pointer, checkType: true);
		public static explicit operator IntPtr(FontFace value) => value._pointer;
		public static implicit operator GObject.Object(FontFace value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator FontFace(GObject.Object value) => new FontFace((IntPtr)value, checkType: true);
		public Pango.FontDescription describe() => Pango.PangoInterop.pango_font_face_describe(this);
		public string get_face_name() => Pango.PangoInterop.pango_font_face_get_face_name(this);
		public bool is_synthesized() => Pango.PangoInterop.pango_font_face_is_synthesized(this);
		public void list_sizes(System.IntPtr sizes, System.IntPtr n_sizes) => Pango.PangoInterop.pango_font_face_list_sizes(this, sizes, n_sizes);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_font_face_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct FontFaceClass
	{
		private IntPtr _pointer;
		public FontFaceClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontFaceClass(IntPtr pointer) => new FontFaceClass(pointer, checkType: true);
		public static explicit operator IntPtr(FontFaceClass value) => value._pointer;
	}
	public ref struct FontFamilyClass
	{
		private IntPtr _pointer;
		public FontFamilyClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontFamilyClass(IntPtr pointer) => new FontFamilyClass(pointer, checkType: true);
		public static explicit operator IntPtr(FontFamilyClass value) => value._pointer;
	}
	public ref struct FontMapClass
	{
		private IntPtr _pointer;
		public FontMapClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontMapClass(IntPtr pointer) => new FontMapClass(pointer, checkType: true);
		public static explicit operator IntPtr(FontMapClass value) => value._pointer;
	}
	public ref struct FontsetClass
	{
		private IntPtr _pointer;
		public FontsetClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontsetClass(IntPtr pointer) => new FontsetClass(pointer, checkType: true);
		public static explicit operator IntPtr(FontsetClass value) => value._pointer;
	}
	public ref struct FontsetSimple
	{
		private IntPtr _pointer;
		public FontsetSimple(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator FontsetSimple(IntPtr pointer) => new FontsetSimple(pointer, checkType: true);
		public static explicit operator IntPtr(FontsetSimple value) => value._pointer;
		public static implicit operator Pango.Fontset(FontsetSimple value) => new Pango.Fontset((IntPtr)value, checkType: false);
		public static explicit operator FontsetSimple(Pango.Fontset value) => new FontsetSimple((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(FontsetSimple value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator FontsetSimple(GObject.Object value) => new FontsetSimple((IntPtr)value, checkType: true);
		public static Pango.FontsetSimple @new(Pango.Language language) => PangoInterop.pango_fontset_simple_new(language);
		public void append(Pango.Font font) => Pango.PangoInterop.pango_fontset_simple_append(this, font);
		public int size() => Pango.PangoInterop.pango_fontset_simple_size(this);
		public void @foreach(System.IntPtr func, System.IntPtr data) => Pango.PangoInterop.pango_fontset_foreach(this, func, data);
		public Pango.Font get_font(uint wc) => Pango.PangoInterop.pango_fontset_get_font(this, wc);
		public Pango.FontMetrics get_metrics() => Pango.PangoInterop.pango_fontset_get_metrics(this);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_fontset_simple_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct FontsetSimpleClass
	{
		private IntPtr _pointer;
		public FontsetSimpleClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FontsetSimpleClass(IntPtr pointer) => new FontsetSimpleClass(pointer, checkType: true);
		public static explicit operator IntPtr(FontsetSimpleClass value) => value._pointer;
	}
	public ref struct GlyphGeometry
	{
		private IntPtr _pointer;
		public GlyphGeometry(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator GlyphGeometry(IntPtr pointer) => new GlyphGeometry(pointer, checkType: true);
		public static explicit operator IntPtr(GlyphGeometry value) => value._pointer;
	}
	public ref struct GlyphVisAttr
	{
		private IntPtr _pointer;
		public GlyphVisAttr(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator GlyphVisAttr(IntPtr pointer) => new GlyphVisAttr(pointer, checkType: true);
		public static explicit operator IntPtr(GlyphVisAttr value) => value._pointer;
	}
	public ref struct GlyphInfo
	{
		private IntPtr _pointer;
		public GlyphInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator GlyphInfo(IntPtr pointer) => new GlyphInfo(pointer, checkType: true);
		public static explicit operator IntPtr(GlyphInfo value) => value._pointer;
	}
	public ref struct Item
	{
		private IntPtr _pointer;
		public Item(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Item(IntPtr pointer) => new Item(pointer, checkType: true);
		public static explicit operator IntPtr(Item value) => value._pointer;
		public static Pango.Item @new() => PangoInterop.pango_item_new();
		public Pango.Item copy() => Pango.PangoInterop.pango_item_copy(this);
		public void free() => Pango.PangoInterop.pango_item_free(this);
		public Pango.Item split(int split_index, int split_offset) => Pango.PangoInterop.pango_item_split(this, split_index, split_offset);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_item_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct GlyphItemIter
	{
		private IntPtr _pointer;
		public GlyphItemIter(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator GlyphItemIter(IntPtr pointer) => new GlyphItemIter(pointer, checkType: true);
		public static explicit operator IntPtr(GlyphItemIter value) => value._pointer;
		public Pango.GlyphItemIter copy() => Pango.PangoInterop.pango_glyph_item_iter_copy(this);
		public void free() => Pango.PangoInterop.pango_glyph_item_iter_free(this);
		public bool init_end(Pango.GlyphItem glyph_item, string text) => Pango.PangoInterop.pango_glyph_item_iter_init_end(this, glyph_item, text);
		public bool init_start(Pango.GlyphItem glyph_item, string text) => Pango.PangoInterop.pango_glyph_item_iter_init_start(this, glyph_item, text);
		public bool next_cluster() => Pango.PangoInterop.pango_glyph_item_iter_next_cluster(this);
		public bool prev_cluster() => Pango.PangoInterop.pango_glyph_item_iter_prev_cluster(this);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_glyph_item_iter_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct IncludedModule
	{
		private IntPtr _pointer;
		public IncludedModule(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator IncludedModule(IntPtr pointer) => new IncludedModule(pointer, checkType: true);
		public static explicit operator IntPtr(IncludedModule value) => value._pointer;
	}
	public ref struct Layout
	{
		private IntPtr _pointer;
		public Layout(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Layout(IntPtr pointer) => new Layout(pointer, checkType: true);
		public static explicit operator IntPtr(Layout value) => value._pointer;
		public static implicit operator GObject.Object(Layout value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Layout(GObject.Object value) => new Layout((IntPtr)value, checkType: true);
		public static Pango.Layout @new(Pango.Context context) => PangoInterop.pango_layout_new(context);
		public void context_changed() => Pango.PangoInterop.pango_layout_context_changed(this);
		public Pango.Layout copy() => Pango.PangoInterop.pango_layout_copy(this);
		public Pango.Alignment get_alignment() => Pango.PangoInterop.pango_layout_get_alignment(this);
		public Pango.AttrList get_attributes() => Pango.PangoInterop.pango_layout_get_attributes(this);
		public bool get_auto_dir() => Pango.PangoInterop.pango_layout_get_auto_dir(this);
		public int get_baseline() => Pango.PangoInterop.pango_layout_get_baseline(this);
		public int get_character_count() => Pango.PangoInterop.pango_layout_get_character_count(this);
		public Pango.Context get_context() => Pango.PangoInterop.pango_layout_get_context(this);
		public Pango.EllipsizeMode get_ellipsize() => Pango.PangoInterop.pango_layout_get_ellipsize(this);
		public Pango.FontDescription get_font_description() => Pango.PangoInterop.pango_layout_get_font_description(this);
		public int get_height() => Pango.PangoInterop.pango_layout_get_height(this);
		public int get_indent() => Pango.PangoInterop.pango_layout_get_indent(this);
		public Pango.LayoutIter get_iter() => Pango.PangoInterop.pango_layout_get_iter(this);
		public bool get_justify() => Pango.PangoInterop.pango_layout_get_justify(this);
		public Pango.LayoutLine get_line(int line) => Pango.PangoInterop.pango_layout_get_line(this, line);
		public int get_line_count() => Pango.PangoInterop.pango_layout_get_line_count(this);
		public Pango.LayoutLine get_line_readonly(int line) => Pango.PangoInterop.pango_layout_get_line_readonly(this, line);
		public System.IntPtr get_lines() => Pango.PangoInterop.pango_layout_get_lines(this);
		public System.IntPtr get_lines_readonly() => Pango.PangoInterop.pango_layout_get_lines_readonly(this);
		public void get_log_attrs(System.IntPtr attrs, System.IntPtr n_attrs) => Pango.PangoInterop.pango_layout_get_log_attrs(this, attrs, n_attrs);
		public System.IntPtr get_log_attrs_readonly(System.IntPtr n_attrs) => Pango.PangoInterop.pango_layout_get_log_attrs_readonly(this, n_attrs);
		public void get_pixel_size(System.IntPtr width, System.IntPtr height) => Pango.PangoInterop.pango_layout_get_pixel_size(this, width, height);
		public uint get_serial() => Pango.PangoInterop.pango_layout_get_serial(this);
		public bool get_single_paragraph_mode() => Pango.PangoInterop.pango_layout_get_single_paragraph_mode(this);
		public void get_size(System.IntPtr width, System.IntPtr height) => Pango.PangoInterop.pango_layout_get_size(this, width, height);
		public int get_spacing() => Pango.PangoInterop.pango_layout_get_spacing(this);
		public Pango.TabArray get_tabs() => Pango.PangoInterop.pango_layout_get_tabs(this);
		public string get_text() => Pango.PangoInterop.pango_layout_get_text(this);
		public int get_unknown_glyphs_count() => Pango.PangoInterop.pango_layout_get_unknown_glyphs_count(this);
		public int get_width() => Pango.PangoInterop.pango_layout_get_width(this);
		public Pango.WrapMode get_wrap() => Pango.PangoInterop.pango_layout_get_wrap(this);
		public void index_to_line_x(int index_, bool trailing, System.IntPtr line, System.IntPtr x_pos) => Pango.PangoInterop.pango_layout_index_to_line_x(this, index_, trailing, line, x_pos);
		public bool is_ellipsized() => Pango.PangoInterop.pango_layout_is_ellipsized(this);
		public bool is_wrapped() => Pango.PangoInterop.pango_layout_is_wrapped(this);
		public void move_cursor_visually(bool strong, int old_index, int old_trailing, int direction, System.IntPtr new_index, System.IntPtr new_trailing) => Pango.PangoInterop.pango_layout_move_cursor_visually(this, strong, old_index, old_trailing, direction, new_index, new_trailing);
		public void set_alignment(Pango.Alignment alignment) => Pango.PangoInterop.pango_layout_set_alignment(this, alignment);
		public void set_attributes(Pango.AttrList attrs) => Pango.PangoInterop.pango_layout_set_attributes(this, attrs);
		public void set_auto_dir(bool auto_dir) => Pango.PangoInterop.pango_layout_set_auto_dir(this, auto_dir);
		public void set_ellipsize(Pango.EllipsizeMode ellipsize) => Pango.PangoInterop.pango_layout_set_ellipsize(this, ellipsize);
		public void set_font_description(Pango.FontDescription desc) => Pango.PangoInterop.pango_layout_set_font_description(this, desc);
		public void set_height(int height) => Pango.PangoInterop.pango_layout_set_height(this, height);
		public void set_indent(int indent) => Pango.PangoInterop.pango_layout_set_indent(this, indent);
		public void set_justify(bool justify) => Pango.PangoInterop.pango_layout_set_justify(this, justify);
		public void set_markup(string markup, int length) => Pango.PangoInterop.pango_layout_set_markup(this, markup, length);
		public void set_markup_with_accel(string markup, int length, uint accel_marker, System.IntPtr accel_char) => Pango.PangoInterop.pango_layout_set_markup_with_accel(this, markup, length, accel_marker, accel_char);
		public void set_single_paragraph_mode(bool setting) => Pango.PangoInterop.pango_layout_set_single_paragraph_mode(this, setting);
		public void set_spacing(int spacing) => Pango.PangoInterop.pango_layout_set_spacing(this, spacing);
		public void set_tabs(Pango.TabArray tabs) => Pango.PangoInterop.pango_layout_set_tabs(this, tabs);
		public void set_text(string text, int length) => Pango.PangoInterop.pango_layout_set_text(this, text, length);
		public void set_width(int width) => Pango.PangoInterop.pango_layout_set_width(this, width);
		public void set_wrap(Pango.WrapMode wrap) => Pango.PangoInterop.pango_layout_set_wrap(this, wrap);
		public bool xy_to_index(int x, int y, System.IntPtr index_, System.IntPtr trailing) => Pango.PangoInterop.pango_layout_xy_to_index(this, x, y, index_, trailing);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_layout_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct LayoutIter
	{
		private IntPtr _pointer;
		public LayoutIter(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator LayoutIter(IntPtr pointer) => new LayoutIter(pointer, checkType: true);
		public static explicit operator IntPtr(LayoutIter value) => value._pointer;
		public bool at_last_line() => Pango.PangoInterop.pango_layout_iter_at_last_line(this);
		public Pango.LayoutIter copy() => Pango.PangoInterop.pango_layout_iter_copy(this);
		public void free() => Pango.PangoInterop.pango_layout_iter_free(this);
		public int get_baseline() => Pango.PangoInterop.pango_layout_iter_get_baseline(this);
		public int get_index() => Pango.PangoInterop.pango_layout_iter_get_index(this);
		public Pango.Layout get_layout() => Pango.PangoInterop.pango_layout_iter_get_layout(this);
		public Pango.LayoutLine get_line() => Pango.PangoInterop.pango_layout_iter_get_line(this);
		public Pango.LayoutLine get_line_readonly() => Pango.PangoInterop.pango_layout_iter_get_line_readonly(this);
		public void get_line_yrange(System.IntPtr y0_, System.IntPtr y1_) => Pango.PangoInterop.pango_layout_iter_get_line_yrange(this, y0_, y1_);
		public Pango.GlyphItem get_run() => Pango.PangoInterop.pango_layout_iter_get_run(this);
		public Pango.GlyphItem get_run_readonly() => Pango.PangoInterop.pango_layout_iter_get_run_readonly(this);
		public bool next_char() => Pango.PangoInterop.pango_layout_iter_next_char(this);
		public bool next_cluster() => Pango.PangoInterop.pango_layout_iter_next_cluster(this);
		public bool next_line() => Pango.PangoInterop.pango_layout_iter_next_line(this);
		public bool next_run() => Pango.PangoInterop.pango_layout_iter_next_run(this);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_layout_iter_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct LayoutLine
	{
		private IntPtr _pointer;
		public LayoutLine(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator LayoutLine(IntPtr pointer) => new LayoutLine(pointer, checkType: true);
		public static explicit operator IntPtr(LayoutLine value) => value._pointer;
		public void get_x_ranges(int start_index, int end_index, System.IntPtr ranges, System.IntPtr n_ranges) => Pango.PangoInterop.pango_layout_line_get_x_ranges(this, start_index, end_index, ranges, n_ranges);
		public void index_to_x(int index_, bool trailing, System.IntPtr x_pos) => Pango.PangoInterop.pango_layout_line_index_to_x(this, index_, trailing, x_pos);
		public Pango.LayoutLine @ref() => Pango.PangoInterop.pango_layout_line_ref(this);
		public void unref() => Pango.PangoInterop.pango_layout_line_unref(this);
		public bool x_to_index(int x_pos, System.IntPtr index_, System.IntPtr trailing) => Pango.PangoInterop.pango_layout_line_x_to_index(this, x_pos, index_, trailing);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_layout_line_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct TabArray
	{
		private IntPtr _pointer;
		public TabArray(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TabArray(IntPtr pointer) => new TabArray(pointer, checkType: true);
		public static explicit operator IntPtr(TabArray value) => value._pointer;
		public static Pango.TabArray @new(int initial_size, bool positions_in_pixels) => PangoInterop.pango_tab_array_new(initial_size, positions_in_pixels);
		public Pango.TabArray copy() => Pango.PangoInterop.pango_tab_array_copy(this);
		public void free() => Pango.PangoInterop.pango_tab_array_free(this);
		public bool get_positions_in_pixels() => Pango.PangoInterop.pango_tab_array_get_positions_in_pixels(this);
		public int get_size() => Pango.PangoInterop.pango_tab_array_get_size(this);
		public void get_tab(int tab_index, out Pango.TabAlign alignment, System.IntPtr location) => Pango.PangoInterop.pango_tab_array_get_tab(this, tab_index, out alignment, location);
		public void resize(int new_size) => Pango.PangoInterop.pango_tab_array_resize(this, new_size);
		public void set_tab(int tab_index, Pango.TabAlign alignment, int location) => Pango.PangoInterop.pango_tab_array_set_tab(this, tab_index, alignment, location);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_tab_array_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum WrapMode
	{
		word = 0,
		@char = 1,
		word_char = 2,
	}
	public ref struct LayoutClass
	{
		private IntPtr _pointer;
		public LayoutClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator LayoutClass(IntPtr pointer) => new LayoutClass(pointer, checkType: true);
		public static explicit operator IntPtr(LayoutClass value) => value._pointer;
	}
	public ref struct Map
	{
		private IntPtr _pointer;
		public Map(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Map(IntPtr pointer) => new Map(pointer, checkType: true);
		public static explicit operator IntPtr(Map value) => value._pointer;
		public Pango.Engine get_engine(Pango.Script script) => Pango.PangoInterop.pango_map_get_engine(this, script);
		public void get_engines(Pango.Script script, System.IntPtr exact_engines, System.IntPtr fallback_engines) => Pango.PangoInterop.pango_map_get_engines(this, script, exact_engines, fallback_engines);
	}
	public ref struct MapEntry
	{
		private IntPtr _pointer;
		public MapEntry(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MapEntry(IntPtr pointer) => new MapEntry(pointer, checkType: true);
		public static explicit operator IntPtr(MapEntry value) => value._pointer;
	}
	public enum RenderPart
	{
		foreground = 0,
		background = 1,
		underline = 2,
		strikethrough = 3,
	}
	public ref struct Renderer
	{
		private IntPtr _pointer;
		public Renderer(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Renderer(IntPtr pointer) => new Renderer(pointer, checkType: true);
		public static explicit operator IntPtr(Renderer value) => value._pointer;
		public static implicit operator GObject.Object(Renderer value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Renderer(GObject.Object value) => new Renderer((IntPtr)value, checkType: true);
		public void activate() => Pango.PangoInterop.pango_renderer_activate(this);
		public void deactivate() => Pango.PangoInterop.pango_renderer_deactivate(this);
		public void draw_error_underline(int x, int y, int width, int height) => Pango.PangoInterop.pango_renderer_draw_error_underline(this, x, y, width, height);
		public void draw_glyph(Pango.Font font, uint glyph, double x, double y) => Pango.PangoInterop.pango_renderer_draw_glyph(this, font, glyph, x, y);
		public void draw_glyph_item(string text, Pango.GlyphItem glyph_item, int x, int y) => Pango.PangoInterop.pango_renderer_draw_glyph_item(this, text, glyph_item, x, y);
		public void draw_glyphs(Pango.Font font, Pango.GlyphString glyphs, int x, int y) => Pango.PangoInterop.pango_renderer_draw_glyphs(this, font, glyphs, x, y);
		public void draw_layout(Pango.Layout layout, int x, int y) => Pango.PangoInterop.pango_renderer_draw_layout(this, layout, x, y);
		public void draw_layout_line(Pango.LayoutLine line, int x, int y) => Pango.PangoInterop.pango_renderer_draw_layout_line(this, line, x, y);
		public void draw_rectangle(Pango.RenderPart part, int x, int y, int width, int height) => Pango.PangoInterop.pango_renderer_draw_rectangle(this, part, x, y, width, height);
		public void draw_trapezoid(Pango.RenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22) => Pango.PangoInterop.pango_renderer_draw_trapezoid(this, part, y1_, x11, x21, y2, x12, x22);
		public ushort get_alpha(Pango.RenderPart part) => Pango.PangoInterop.pango_renderer_get_alpha(this, part);
		public Pango.Color get_color(Pango.RenderPart part) => Pango.PangoInterop.pango_renderer_get_color(this, part);
		public Pango.Layout get_layout() => Pango.PangoInterop.pango_renderer_get_layout(this);
		public Pango.LayoutLine get_layout_line() => Pango.PangoInterop.pango_renderer_get_layout_line(this);
		public Pango.Matrix get_matrix() => Pango.PangoInterop.pango_renderer_get_matrix(this);
		public void part_changed(Pango.RenderPart part) => Pango.PangoInterop.pango_renderer_part_changed(this, part);
		public void set_alpha(Pango.RenderPart part, ushort alpha) => Pango.PangoInterop.pango_renderer_set_alpha(this, part, alpha);
		public void set_color(Pango.RenderPart part, Pango.Color color) => Pango.PangoInterop.pango_renderer_set_color(this, part, color);
		public void set_matrix(Pango.Matrix matrix) => Pango.PangoInterop.pango_renderer_set_matrix(this, matrix);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public void get_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_get_property(this, property_name, value);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_property(string property_name, GObject.Value value) => GObject.GObjectInterop.g_object_set_property(this, property_name, value);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void unref() => GObject.GObjectInterop.g_object_unref(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libpango-1.0.so.0", EntryPoint = "pango_renderer_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum Underline
	{
		none = 0,
		single = 1,
		@double = 2,
		low = 3,
		error = 4,
	}
	public ref struct RendererPrivate
	{
		private IntPtr _pointer;
		public RendererPrivate(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RendererPrivate(IntPtr pointer) => new RendererPrivate(pointer, checkType: true);
		public static explicit operator IntPtr(RendererPrivate value) => value._pointer;
	}
	public ref struct RendererClass
	{
		private IntPtr _pointer;
		public RendererClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RendererClass(IntPtr pointer) => new RendererClass(pointer, checkType: true);
		public static explicit operator IntPtr(RendererClass value) => value._pointer;
	}
	public ref struct ScriptForLang
	{
		private IntPtr _pointer;
		public ScriptForLang(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ScriptForLang(IntPtr pointer) => new ScriptForLang(pointer, checkType: true);
		public static explicit operator IntPtr(ScriptForLang value) => value._pointer;
	}
	public ref struct ScriptIter
	{
		private IntPtr _pointer;
		public ScriptIter(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ScriptIter(IntPtr pointer) => new ScriptIter(pointer, checkType: true);
		public static explicit operator IntPtr(ScriptIter value) => value._pointer;
		public void free() => Pango.PangoInterop.pango_script_iter_free(this);
		public void get_range(string start, string end, out Pango.Script script) => Pango.PangoInterop.pango_script_iter_get_range(this, start, end, out script);
		public bool next() => Pango.PangoInterop.pango_script_iter_next(this);
		public static Pango.ScriptIter @new(string text, int length) => PangoInterop.pango_script_iter_new(text, length);
	}
	public enum TabAlign
	{
		left = 0,
	}
	public static class PangoInterop {
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_background_alpha_new(ushort alpha);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_background_new(ushort red, ushort green, ushort blue);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_fallback_new(bool enable_fallback);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_family_new(string family);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_foreground_alpha_new(ushort alpha);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_foreground_new(ushort red, ushort green, ushort blue);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_gravity_hint_new(Pango.GravityHint hint);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_gravity_new(Pango.Gravity gravity);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_letter_spacing_new(int letter_spacing);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_rise_new(int rise);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_scale_new(double scale_factor);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_stretch_new(Pango.Stretch stretch);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_strikethrough_color_new(ushort red, ushort green, ushort blue);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_strikethrough_new(bool strikethrough);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_style_new(Pango.Style style);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_underline_color_new(ushort red, ushort green, ushort blue);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_underline_new(Pango.Underline underline);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_variant_new(Pango.Variant variant);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_weight_new(Pango.Weight weight);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_break(string text, int length, Pango.Analysis analysis, System.IntPtr attrs, int attrs_len);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_config_key_get(string key);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_config_key_get_system(string key);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_default_break(string text, int length, Pango.Analysis analysis, Pango.LogAttr attrs, int attrs_len);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_extents_to_pixels(Pango.Rectangle inclusive, Pango.Rectangle nearest);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Direction pango_find_base_dir(string text, int length);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Map pango_find_map(Pango.Language language, uint engine_type_id, uint render_type_id);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_find_paragraph_boundary(string text, int length, System.IntPtr paragraph_delimiter_index, System.IntPtr next_paragraph_start);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_get_lib_subdirectory();
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_get_log_attrs(string text, int length, int level, Pango.Language language, System.IntPtr log_attrs, int attrs_len);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_get_mirror_char(uint ch, System.IntPtr mirrored_ch);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_get_sysconf_subdirectory();
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_is_zero_width(uint ch);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_itemize(Pango.Context context, string text, int start_index, int length, Pango.AttrList attrs, Pango.AttrIterator cached_iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_itemize_with_base_dir(Pango.Context context, Pango.Direction base_dir, string text, int start_index, int length, Pango.AttrList attrs, Pango.AttrIterator cached_iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_lookup_aliases(string fontname, System.IntPtr families, System.IntPtr n_families);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_markup_parser_finish(GLib.MarkupParseContext context, out Pango.AttrList attr_list, string text, System.IntPtr accel_char, out GLib.Error error);
		[DllImport("libpango-1.0.so.0")]
		public static extern GLib.MarkupParseContext pango_markup_parser_new(uint accel_marker);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_module_register(Pango.IncludedModule module);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_parse_enum(GLib.GType type, string str, System.IntPtr value, bool warn, string possible_values);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_parse_markup(string markup_text, int length, uint accel_marker, out Pango.AttrList attr_list, string text, System.IntPtr accel_char, out GLib.Error error);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_parse_stretch(string str, out Pango.Stretch stretch, bool warn);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_parse_style(string str, out Pango.Style style, bool warn);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_parse_variant(string str, out Pango.Variant variant, bool warn);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_parse_weight(string str, out Pango.Weight weight, bool warn);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_quantize_line_geometry(System.IntPtr thickness, System.IntPtr position);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_reorder_items(System.IntPtr logical_items);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_scan_int(string pos, System.IntPtr @out);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_shape(string text, int length, Pango.Analysis analysis, Pango.GlyphString glyphs);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_shape_full(string item_text, int item_length, string paragraph_text, int paragraph_length, Pango.Analysis analysis, Pango.GlyphString glyphs);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_skip_space(string pos);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_split_file_list(string str);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_trim_string(string str);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Direction pango_unichar_direction(uint ch);
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
		public static extern System.IntPtr pango_glyph_item_apply_attrs(Pango.GlyphItem glyph_item, string text, Pango.AttrList list);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GlyphItem pango_glyph_item_copy(Pango.GlyphItem orig);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_item_free(Pango.GlyphItem glyph_item);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_item_get_logical_widths(Pango.GlyphItem glyph_item, string text, System.IntPtr logical_widths);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_item_letter_space(Pango.GlyphItem glyph_item, string text, System.IntPtr log_attrs, int letter_spacing);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GlyphItem pango_glyph_item_split(Pango.GlyphItem orig, string text, int split_index);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_descriptions_free(System.IntPtr descs, int n_descs);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_font_describe(Pango.Font font);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_font_describe_with_absolute_size(Pango.Font font);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.EngineShape pango_font_find_shaper(Pango.Font font, Pango.Language language, uint ch);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Coverage pango_font_get_coverage(Pango.Font font, Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMap pango_font_get_font_map(Pango.Font font);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMetrics pango_font_get_metrics(Pango.Font font, Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_language_get_sample_string(Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_language_get_scripts(Pango.Language language, System.IntPtr num_scripts);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_language_includes_script(Pango.Language language, Pango.Script script);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_language_matches(Pango.Language language, string range_list);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_language_to_string(Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Language pango_language_from_string(string language);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Language pango_language_get_default();
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_attr_type_get_name(Pango.AttrType type);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrType pango_attr_type_register(string name);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attribute_copy(Pango.Attribute attr);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attribute_destroy(Pango.Attribute attr);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_attribute_equal(Pango.Attribute attr1, Pango.Attribute attr2);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attribute_init(Pango.Attribute attr, Pango.AttrClass klass);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Color pango_color_copy(Pango.Color src);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_color_free(Pango.Color color);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_color_parse(Pango.Color color, string spec);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_color_to_string(Pango.Color color);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_font_description_new();
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_font_description_better_match(Pango.FontDescription desc, Pango.FontDescription old_match, Pango.FontDescription new_match);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_font_description_copy(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_font_description_copy_static(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_font_description_equal(Pango.FontDescription desc1, Pango.FontDescription desc2);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_free(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_font_description_get_family(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Gravity pango_font_description_get_gravity(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMask pango_font_description_get_set_fields(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_description_get_size(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_font_description_get_size_is_absolute(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Stretch pango_font_description_get_stretch(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Style pango_font_description_get_style(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Variant pango_font_description_get_variant(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Weight pango_font_description_get_weight(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern uint pango_font_description_hash(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_merge(Pango.FontDescription desc, Pango.FontDescription desc_to_merge, bool replace_existing);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_merge_static(Pango.FontDescription desc, Pango.FontDescription desc_to_merge, bool replace_existing);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_absolute_size(Pango.FontDescription desc, double size);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_family(Pango.FontDescription desc, string family);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_family_static(Pango.FontDescription desc, string family);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_gravity(Pango.FontDescription desc, Pango.Gravity gravity);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_size(Pango.FontDescription desc, int size);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_stretch(Pango.FontDescription desc, Pango.Stretch stretch);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_style(Pango.FontDescription desc, Pango.Style style);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_variant(Pango.FontDescription desc, Pango.Variant variant);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_set_weight(Pango.FontDescription desc, Pango.Weight weight);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_font_description_to_filename(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_font_description_to_string(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_description_unset_fields(Pango.FontDescription desc, Pango.FontMask to_unset);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_font_description_from_string(string str);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_font_desc_new(Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_font_features_new(string features);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrIterator pango_attr_iterator_copy(Pango.AttrIterator iterator);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attr_iterator_destroy(Pango.AttrIterator iterator);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_iterator_get(Pango.AttrIterator iterator, Pango.AttrType type);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_attr_iterator_get_attrs(Pango.AttrIterator iterator);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_attr_iterator_next(Pango.AttrIterator iterator);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attr_iterator_range(Pango.AttrIterator iterator, System.IntPtr start, System.IntPtr end);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_language_new(Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrList pango_attr_list_new();
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attr_list_change(Pango.AttrList list, Pango.Attribute attr);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrList pango_attr_list_copy(Pango.AttrList list);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrList pango_attr_list_filter(Pango.AttrList list, System.IntPtr func, System.IntPtr data);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrIterator pango_attr_list_get_iterator(Pango.AttrList list);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attr_list_insert(Pango.AttrList list, Pango.Attribute attr);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attr_list_insert_before(Pango.AttrList list, Pango.Attribute attr);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrList pango_attr_list_ref(Pango.AttrList list);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attr_list_splice(Pango.AttrList list, Pango.AttrList other, int pos, int len);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_attr_list_unref(Pango.AttrList list);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_shape_new(Pango.Rectangle ink_rect, Pango.Rectangle logical_rect);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_shape_new_with_data(Pango.Rectangle ink_rect, Pango.Rectangle logical_rect, System.IntPtr data, System.IntPtr copy_func, System.IntPtr destroy_func);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_size_new(int size);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Attribute pango_attr_size_new_absolute(int size);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.BidiType pango_bidi_type_for_unichar(uint ch);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Context pango_context_new();
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_changed(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Direction pango_context_get_base_dir(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Gravity pango_context_get_base_gravity(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_context_get_font_description(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMap pango_context_get_font_map(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Gravity pango_context_get_gravity(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GravityHint pango_context_get_gravity_hint(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Language pango_context_get_language(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Matrix pango_context_get_matrix(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMetrics pango_context_get_metrics(Pango.Context context, Pango.FontDescription desc, Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern uint pango_context_get_serial(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_list_families(Pango.Context context, System.IntPtr families, System.IntPtr n_families);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Font pango_context_load_font(Pango.Context context, Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Fontset pango_context_load_fontset(Pango.Context context, Pango.FontDescription desc, Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_set_base_dir(Pango.Context context, Pango.Direction direction);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_set_base_gravity(Pango.Context context, Pango.Gravity gravity);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_set_font_description(Pango.Context context, Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_set_font_map(Pango.Context context, Pango.FontMap font_map);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_set_gravity_hint(Pango.Context context, Pango.GravityHint hint);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_set_language(Pango.Context context, Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_context_set_matrix(Pango.Context context, Pango.Matrix matrix);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Gravity pango_gravity_get_for_matrix(Pango.Matrix matrix);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Gravity pango_gravity_get_for_script(Pango.Script script, Pango.Gravity base_gravity, Pango.GravityHint hint);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Gravity pango_gravity_get_for_script_and_width(Pango.Script script, bool wide, Pango.Gravity base_gravity, Pango.GravityHint hint);
		[DllImport("libpango-1.0.so.0")]
		public static extern double pango_gravity_to_rotation(Pango.Gravity gravity);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_map_changed(Pango.FontMap fontmap);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Context pango_font_map_create_context(Pango.FontMap fontmap);
		[DllImport("libpango-1.0.so.0")]
		public static extern uint pango_font_map_get_serial(Pango.FontMap fontmap);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_font_map_get_shape_engine_type(Pango.FontMap fontmap);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_map_list_families(Pango.FontMap fontmap, System.IntPtr families, System.IntPtr n_families);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Font pango_font_map_load_font(Pango.FontMap fontmap, Pango.Context context, Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Fontset pango_font_map_load_fontset(Pango.FontMap fontmap, Pango.Context context, Pango.FontDescription desc, Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_concat(Pango.Matrix matrix, Pango.Matrix new_matrix);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Matrix pango_matrix_copy(Pango.Matrix matrix);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_free(Pango.Matrix matrix);
		[DllImport("libpango-1.0.so.0")]
		public static extern double pango_matrix_get_font_scale_factor(Pango.Matrix matrix);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_get_font_scale_factors(Pango.Matrix matrix, System.IntPtr xscale, System.IntPtr yscale);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_rotate(Pango.Matrix matrix, double degrees);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_scale(Pango.Matrix matrix, double scale_x, double scale_y);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_transform_distance(Pango.Matrix matrix, System.IntPtr dx, System.IntPtr dy);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_transform_point(Pango.Matrix matrix, System.IntPtr x, System.IntPtr y);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_matrix_translate(Pango.Matrix matrix, double tx, double ty);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMetrics pango_font_metrics_new();
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_approximate_char_width(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_approximate_digit_width(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_ascent(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_descent(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_strikethrough_position(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_strikethrough_thickness(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_underline_position(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_font_metrics_get_underline_thickness(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMetrics pango_font_metrics_ref(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_metrics_unref(Pango.FontMetrics metrics);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_font_family_get_name(Pango.FontFamily family);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_font_family_is_monospace(Pango.FontFamily family);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_family_list_faces(Pango.FontFamily family, System.IntPtr faces, System.IntPtr n_faces);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_fontset_foreach(Pango.Fontset fontset, System.IntPtr func, System.IntPtr data);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Font pango_fontset_get_font(Pango.Fontset fontset, uint wc);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontMetrics pango_fontset_get_metrics(Pango.Fontset fontset);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Coverage pango_coverage_copy(Pango.Coverage coverage);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.CoverageLevel pango_coverage_get(Pango.Coverage coverage, int index_);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_coverage_max(Pango.Coverage coverage, Pango.Coverage other);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Coverage pango_coverage_ref(Pango.Coverage coverage);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_coverage_set(Pango.Coverage coverage, int index_, Pango.CoverageLevel level);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_coverage_to_bytes(Pango.Coverage coverage, System.IntPtr bytes, System.IntPtr n_bytes);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_coverage_unref(Pango.Coverage coverage);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Coverage pango_coverage_from_bytes(System.IntPtr bytes, int n_bytes);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Coverage pango_coverage_new();
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Script pango_script_for_unichar(uint ch);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Language pango_script_get_sample_language(Pango.Script script);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GlyphString pango_glyph_string_new();
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GlyphString pango_glyph_string_copy(Pango.GlyphString @string);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_string_free(Pango.GlyphString @string);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_string_get_logical_widths(Pango.GlyphString glyphs, string text, int length, int embedding_level, System.IntPtr logical_widths);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_glyph_string_get_width(Pango.GlyphString glyphs);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_string_index_to_x(Pango.GlyphString glyphs, string text, int length, Pango.Analysis analysis, int index_, bool trailing, System.IntPtr x_pos);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_string_set_size(Pango.GlyphString @string, int new_len);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_string_x_to_index(Pango.GlyphString glyphs, string text, int length, Pango.Analysis analysis, int x_pos, System.IntPtr index_, System.IntPtr trailing);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_font_face_describe(Pango.FontFace face);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_font_face_get_face_name(Pango.FontFace face);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_font_face_is_synthesized(Pango.FontFace face);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_font_face_list_sizes(Pango.FontFace face, System.IntPtr sizes, System.IntPtr n_sizes);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontsetSimple pango_fontset_simple_new(Pango.Language language);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_fontset_simple_append(Pango.FontsetSimple fontset, Pango.Font font);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_fontset_simple_size(Pango.FontsetSimple fontset);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Item pango_item_new();
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Item pango_item_copy(Pango.Item item);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_item_free(Pango.Item item);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Item pango_item_split(Pango.Item orig, int split_index, int split_offset);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GlyphItemIter pango_glyph_item_iter_copy(Pango.GlyphItemIter orig);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_glyph_item_iter_free(Pango.GlyphItemIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_glyph_item_iter_init_end(Pango.GlyphItemIter iter, Pango.GlyphItem glyph_item, string text);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_glyph_item_iter_init_start(Pango.GlyphItemIter iter, Pango.GlyphItem glyph_item, string text);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_glyph_item_iter_next_cluster(Pango.GlyphItemIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_glyph_item_iter_prev_cluster(Pango.GlyphItemIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Layout pango_layout_new(Pango.Context context);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_context_changed(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Layout pango_layout_copy(Pango.Layout src);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Alignment pango_layout_get_alignment(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.AttrList pango_layout_get_attributes(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_get_auto_dir(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_baseline(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_character_count(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Context pango_layout_get_context(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.EllipsizeMode pango_layout_get_ellipsize(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.FontDescription pango_layout_get_font_description(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_height(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_indent(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutIter pango_layout_get_iter(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_get_justify(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutLine pango_layout_get_line(Pango.Layout layout, int line);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_line_count(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutLine pango_layout_get_line_readonly(Pango.Layout layout, int line);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_layout_get_lines(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_layout_get_lines_readonly(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_get_log_attrs(Pango.Layout layout, System.IntPtr attrs, System.IntPtr n_attrs);
		[DllImport("libpango-1.0.so.0")]
		public static extern System.IntPtr pango_layout_get_log_attrs_readonly(Pango.Layout layout, System.IntPtr n_attrs);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_get_pixel_size(Pango.Layout layout, System.IntPtr width, System.IntPtr height);
		[DllImport("libpango-1.0.so.0")]
		public static extern uint pango_layout_get_serial(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_get_single_paragraph_mode(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_get_size(Pango.Layout layout, System.IntPtr width, System.IntPtr height);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_spacing(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.TabArray pango_layout_get_tabs(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern string pango_layout_get_text(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_unknown_glyphs_count(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_get_width(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.WrapMode pango_layout_get_wrap(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_index_to_line_x(Pango.Layout layout, int index_, bool trailing, System.IntPtr line, System.IntPtr x_pos);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_is_ellipsized(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_is_wrapped(Pango.Layout layout);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_move_cursor_visually(Pango.Layout layout, bool strong, int old_index, int old_trailing, int direction, System.IntPtr new_index, System.IntPtr new_trailing);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_alignment(Pango.Layout layout, Pango.Alignment alignment);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_attributes(Pango.Layout layout, Pango.AttrList attrs);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_auto_dir(Pango.Layout layout, bool auto_dir);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_ellipsize(Pango.Layout layout, Pango.EllipsizeMode ellipsize);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_font_description(Pango.Layout layout, Pango.FontDescription desc);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_height(Pango.Layout layout, int height);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_indent(Pango.Layout layout, int indent);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_justify(Pango.Layout layout, bool justify);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_markup(Pango.Layout layout, string markup, int length);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_markup_with_accel(Pango.Layout layout, string markup, int length, uint accel_marker, System.IntPtr accel_char);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_single_paragraph_mode(Pango.Layout layout, bool setting);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_spacing(Pango.Layout layout, int spacing);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_tabs(Pango.Layout layout, Pango.TabArray tabs);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_text(Pango.Layout layout, string text, int length);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_width(Pango.Layout layout, int width);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_set_wrap(Pango.Layout layout, Pango.WrapMode wrap);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_xy_to_index(Pango.Layout layout, int x, int y, System.IntPtr index_, System.IntPtr trailing);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_iter_at_last_line(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutIter pango_layout_iter_copy(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_iter_free(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_iter_get_baseline(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_layout_iter_get_index(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Layout pango_layout_iter_get_layout(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutLine pango_layout_iter_get_line(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutLine pango_layout_iter_get_line_readonly(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_iter_get_line_yrange(Pango.LayoutIter iter, System.IntPtr y0_, System.IntPtr y1_);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GlyphItem pango_layout_iter_get_run(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.GlyphItem pango_layout_iter_get_run_readonly(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_iter_next_char(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_iter_next_cluster(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_iter_next_line(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_iter_next_run(Pango.LayoutIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_line_get_x_ranges(Pango.LayoutLine line, int start_index, int end_index, System.IntPtr ranges, System.IntPtr n_ranges);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_line_index_to_x(Pango.LayoutLine line, int index_, bool trailing, System.IntPtr x_pos);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutLine pango_layout_line_ref(Pango.LayoutLine line);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_layout_line_unref(Pango.LayoutLine line);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_layout_line_x_to_index(Pango.LayoutLine line, int x_pos, System.IntPtr index_, System.IntPtr trailing);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.TabArray pango_tab_array_new(int initial_size, bool positions_in_pixels);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.TabArray pango_tab_array_copy(Pango.TabArray src);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_tab_array_free(Pango.TabArray tab_array);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_tab_array_get_positions_in_pixels(Pango.TabArray tab_array);
		[DllImport("libpango-1.0.so.0")]
		public static extern int pango_tab_array_get_size(Pango.TabArray tab_array);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_tab_array_get_tab(Pango.TabArray tab_array, int tab_index, out Pango.TabAlign alignment, System.IntPtr location);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_tab_array_resize(Pango.TabArray tab_array, int new_size);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_tab_array_set_tab(Pango.TabArray tab_array, int tab_index, Pango.TabAlign alignment, int location);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Engine pango_map_get_engine(Pango.Map map, Pango.Script script);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_map_get_engines(Pango.Map map, Pango.Script script, System.IntPtr exact_engines, System.IntPtr fallback_engines);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_activate(Pango.Renderer renderer);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_deactivate(Pango.Renderer renderer);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_error_underline(Pango.Renderer renderer, int x, int y, int width, int height);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_glyph(Pango.Renderer renderer, Pango.Font font, uint glyph, double x, double y);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_glyph_item(Pango.Renderer renderer, string text, Pango.GlyphItem glyph_item, int x, int y);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_glyphs(Pango.Renderer renderer, Pango.Font font, Pango.GlyphString glyphs, int x, int y);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_layout(Pango.Renderer renderer, Pango.Layout layout, int x, int y);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_layout_line(Pango.Renderer renderer, Pango.LayoutLine line, int x, int y);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_rectangle(Pango.Renderer renderer, Pango.RenderPart part, int x, int y, int width, int height);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_draw_trapezoid(Pango.Renderer renderer, Pango.RenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22);
		[DllImport("libpango-1.0.so.0")]
		public static extern ushort pango_renderer_get_alpha(Pango.Renderer renderer, Pango.RenderPart part);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Color pango_renderer_get_color(Pango.Renderer renderer, Pango.RenderPart part);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Layout pango_renderer_get_layout(Pango.Renderer renderer);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.LayoutLine pango_renderer_get_layout_line(Pango.Renderer renderer);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.Matrix pango_renderer_get_matrix(Pango.Renderer renderer);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_part_changed(Pango.Renderer renderer, Pango.RenderPart part);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_set_alpha(Pango.Renderer renderer, Pango.RenderPart part, ushort alpha);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_set_color(Pango.Renderer renderer, Pango.RenderPart part, Pango.Color color);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_renderer_set_matrix(Pango.Renderer renderer, Pango.Matrix matrix);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_script_iter_free(Pango.ScriptIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern void pango_script_iter_get_range(Pango.ScriptIter iter, string start, string end, out Pango.Script script);
		[DllImport("libpango-1.0.so.0")]
		public static extern bool pango_script_iter_next(Pango.ScriptIter iter);
		[DllImport("libpango-1.0.so.0")]
		public static extern Pango.ScriptIter pango_script_iter_new(string text, int length);
	}
}
