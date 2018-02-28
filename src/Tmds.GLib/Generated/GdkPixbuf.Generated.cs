using System;
using System.Runtime.InteropServices;
namespace GdkPixbuf {
	public enum Colorspace
	{
		rgb = 0,
	}
	public enum InterpType
	{
		nearest = 0,
		tiles = 1,
		bilinear = 2,
		hyper = 3,
	}
	public ref struct Pixbuf
	{
		private IntPtr _pointer;
		public Pixbuf(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Pixbuf(IntPtr pointer) => new Pixbuf(pointer, checkType: true);
		public static explicit operator IntPtr(Pixbuf value) => value._pointer;
		public static implicit operator GObject.Object(Pixbuf value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Pixbuf(GObject.Object value) => new Pixbuf((IntPtr)value, checkType: true);
		public static GdkPixbuf.Pixbuf @new(GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height) => GdkPixbufInterop.gdk_pixbuf_new(colorspace, has_alpha, bits_per_sample, width, height);
		public static GdkPixbuf.Pixbuf new_from_bytes(GLib.Bytes data, GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride) => GdkPixbufInterop.gdk_pixbuf_new_from_bytes(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride);
		public static GdkPixbuf.Pixbuf new_from_data(System.IntPtr data, GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, System.IntPtr destroy_fn, System.IntPtr destroy_fn_data) => GdkPixbufInterop.gdk_pixbuf_new_from_data(data, colorspace, has_alpha, bits_per_sample, width, height, rowstride, destroy_fn, destroy_fn_data);
		public static GdkPixbuf.Pixbuf new_from_file(string filename, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_file(filename, out error);
		public static GdkPixbuf.Pixbuf new_from_file_at_scale(string filename, int width, int height, bool preserve_aspect_ratio, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_file_at_scale(filename, width, height, preserve_aspect_ratio, out error);
		public static GdkPixbuf.Pixbuf new_from_file_at_size(string filename, int width, int height, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_file_at_size(filename, width, height, out error);
		public static GdkPixbuf.Pixbuf new_from_inline(int data_length, System.IntPtr data, bool copy_pixels, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_inline(data_length, data, copy_pixels, out error);
		public static GdkPixbuf.Pixbuf new_from_resource(string resource_path, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_resource(resource_path, out error);
		public static GdkPixbuf.Pixbuf new_from_resource_at_scale(string resource_path, int width, int height, bool preserve_aspect_ratio, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_resource_at_scale(resource_path, width, height, preserve_aspect_ratio, out error);
		public static GdkPixbuf.Pixbuf new_from_stream(Gio.InputStream stream, Gio.Cancellable cancellable, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_stream(stream, cancellable, out error);
		public static GdkPixbuf.Pixbuf new_from_stream_at_scale(Gio.InputStream stream, int width, int height, bool preserve_aspect_ratio, Gio.Cancellable cancellable, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_stream_at_scale(stream, width, height, preserve_aspect_ratio, cancellable, out error);
		public static GdkPixbuf.Pixbuf new_from_stream_finish(Gio.AsyncResult async_result, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_new_from_stream_finish(async_result, out error);
		public static GdkPixbuf.Pixbuf new_from_xpm_data(System.IntPtr data) => GdkPixbufInterop.gdk_pixbuf_new_from_xpm_data(data);
		public static int calculate_rowstride(GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height) => GdkPixbufInterop.gdk_pixbuf_calculate_rowstride(colorspace, has_alpha, bits_per_sample, width, height);
		public static GdkPixbuf.Pixbuf from_pixdata(GdkPixbuf.Pixdata pixdata, bool copy_pixels, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_from_pixdata(pixdata, copy_pixels, out error);
		public static GdkPixbuf.PixbufFormat get_file_info(string filename, out int width, out int height) => GdkPixbufInterop.gdk_pixbuf_get_file_info(filename, out width, out height);
		public static void get_file_info_async(string filename, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data) => GdkPixbufInterop.gdk_pixbuf_get_file_info_async(filename, cancellable, callback, user_data);
		public static GdkPixbuf.PixbufFormat get_file_info_finish(Gio.AsyncResult async_result, out int width, out int height, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_get_file_info_finish(async_result, out width, out height, out error);
		public static System.IntPtr get_formats() => GdkPixbufInterop.gdk_pixbuf_get_formats();
		public static void new_from_stream_async(Gio.InputStream stream, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data) => GdkPixbufInterop.gdk_pixbuf_new_from_stream_async(stream, cancellable, callback, user_data);
		public static void new_from_stream_at_scale_async(Gio.InputStream stream, int width, int height, bool preserve_aspect_ratio, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data) => GdkPixbufInterop.gdk_pixbuf_new_from_stream_at_scale_async(stream, width, height, preserve_aspect_ratio, cancellable, callback, user_data);
		public static bool save_to_stream_finish(Gio.AsyncResult async_result, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_save_to_stream_finish(async_result, out error);
		public GdkPixbuf.Pixbuf add_alpha(bool substitute_color, byte r, byte g, byte b) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_add_alpha(this, substitute_color, r, g, b);
		public GdkPixbuf.Pixbuf apply_embedded_orientation() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_apply_embedded_orientation(this);
		public void composite(GdkPixbuf.Pixbuf dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkPixbuf.InterpType interp_type, int overall_alpha) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_composite(this, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha);
		public void composite_color(GdkPixbuf.Pixbuf dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkPixbuf.InterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_composite_color(this, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type, overall_alpha, check_x, check_y, check_size, color1, color2);
		public GdkPixbuf.Pixbuf composite_color_simple(int dest_width, int dest_height, GdkPixbuf.InterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_composite_color_simple(this, dest_width, dest_height, interp_type, overall_alpha, check_size, color1, color2);
		public GdkPixbuf.Pixbuf copy() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_copy(this);
		public void copy_area(int src_x, int src_y, int width, int height, GdkPixbuf.Pixbuf dest_pixbuf, int dest_x, int dest_y) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_copy_area(this, src_x, src_y, width, height, dest_pixbuf, dest_x, dest_y);
		public bool copy_options(GdkPixbuf.Pixbuf dest_pixbuf) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_copy_options(this, dest_pixbuf);
		public void fill(uint pixel) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_fill(this, pixel);
		public GdkPixbuf.Pixbuf flip(bool horizontal) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_flip(this, horizontal);
		public int get_bits_per_sample() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_bits_per_sample(this);
		public ulong get_byte_length() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_byte_length(this);
		public GdkPixbuf.Colorspace get_colorspace() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_colorspace(this);
		public bool get_has_alpha() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_has_alpha(this);
		public int get_height() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_height(this);
		public int get_n_channels() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_n_channels(this);
		public string get_option(string key) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_option(this, key);
		public System.IntPtr get_options() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_options(this);
		public System.IntPtr get_pixels() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_pixels(this);
		public System.IntPtr get_pixels_with_length(out uint length) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_pixels_with_length(this, out length);
		public int get_rowstride() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_rowstride(this);
		public int get_width() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_get_width(this);
		public GdkPixbuf.Pixbuf new_subpixbuf(int src_x, int src_y, int width, int height) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_new_subpixbuf(this, src_x, src_y, width, height);
		public GLib.Bytes read_pixel_bytes() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_read_pixel_bytes(this);
		public byte read_pixels() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_read_pixels(this);
		public GdkPixbuf.Pixbuf @ref() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_ref(this);
		public bool remove_option(string key) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_remove_option(this, key);
		public GdkPixbuf.Pixbuf rotate_simple(GdkPixbuf.PixbufRotation angle) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_rotate_simple(this, angle);
		public void saturate_and_pixelate(GdkPixbuf.Pixbuf dest, float saturation, bool pixelate) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_saturate_and_pixelate(this, dest, saturation, pixelate);
		public bool save_to_bufferv(out System.IntPtr buffer, out ulong buffer_size, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_save_to_bufferv(this, out buffer, out buffer_size, type, option_keys, option_values, out error);
		public bool save_to_callbackv(System.IntPtr save_func, System.IntPtr user_data, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_save_to_callbackv(this, save_func, user_data, type, option_keys, option_values, out error);
		public bool save_to_streamv(Gio.OutputStream stream, string type, System.IntPtr option_keys, System.IntPtr option_values, Gio.Cancellable cancellable, out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_save_to_streamv(this, stream, type, option_keys, option_values, cancellable, out error);
		public void save_to_streamv_async(Gio.OutputStream stream, string type, System.IntPtr option_keys, System.IntPtr option_values, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_save_to_streamv_async(this, stream, type, option_keys, option_values, cancellable, callback, user_data);
		public bool savev(string filename, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_savev(this, filename, type, option_keys, option_values, out error);
		public void scale(GdkPixbuf.Pixbuf dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkPixbuf.InterpType interp_type) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_scale(this, dest, dest_x, dest_y, dest_width, dest_height, offset_x, offset_y, scale_x, scale_y, interp_type);
		public GdkPixbuf.Pixbuf scale_simple(int dest_width, int dest_height, GdkPixbuf.InterpType interp_type) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_scale_simple(this, dest_width, dest_height, interp_type);
		public bool set_option(string key, string value) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_set_option(this, key, value);
		public void unref() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_unref(this);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, ref weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, ref weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libgdk_pixbuf-2.0.so.0", EntryPoint = "gdk_pixbuf_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Pixdata
	{
		private IntPtr _pointer;
		public Pixdata(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Pixdata(IntPtr pointer) => new Pixdata(pointer, checkType: true);
		public static explicit operator IntPtr(Pixdata value) => value._pointer;
		public bool deserialize(uint stream_length, System.IntPtr stream, out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixdata_deserialize(this, stream_length, stream, out error);
		public System.IntPtr from_pixbuf(GdkPixbuf.Pixbuf pixbuf, bool use_rle) => GdkPixbuf.GdkPixbufInterop.gdk_pixdata_from_pixbuf(this, pixbuf, use_rle);
		public System.IntPtr serialize(out uint stream_length_p) => GdkPixbuf.GdkPixbufInterop.gdk_pixdata_serialize(this, out stream_length_p);
	}
	public ref struct PixbufFormat
	{
		private IntPtr _pointer;
		public PixbufFormat(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PixbufFormat(IntPtr pointer) => new PixbufFormat(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufFormat value) => value._pointer;
		public GdkPixbuf.PixbufFormat copy() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_copy(this);
		public void free() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_free(this);
		public string get_description() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_get_description(this);
		public System.IntPtr get_extensions() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_get_extensions(this);
		public string get_license() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_get_license(this);
		public System.IntPtr get_mime_types() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_get_mime_types(this);
		public string get_name() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_get_name(this);
		public bool is_disabled() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_is_disabled(this);
		public bool is_save_option_supported(string option_key) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_is_save_option_supported(this, option_key);
		public bool is_scalable() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_is_scalable(this);
		public bool is_writable() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_is_writable(this);
		public void set_disabled(bool disabled) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_format_set_disabled(this, disabled);
		[DllImport("libgdk_pixbuf-2.0.so.0", EntryPoint = "gdk_pixbuf_format_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum PixbufRotation
	{
		none = 0,
		counterclockwise = 90,
		upsidedown = 180,
		clockwise = 270,
	}
	public enum PixbufAlphaMode
	{
		bilevel = 0,
		full = 1,
	}
	public ref struct PixbufAnimation
	{
		private IntPtr _pointer;
		public PixbufAnimation(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator PixbufAnimation(IntPtr pointer) => new PixbufAnimation(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufAnimation value) => value._pointer;
		public static implicit operator GObject.Object(PixbufAnimation value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator PixbufAnimation(GObject.Object value) => new PixbufAnimation((IntPtr)value, checkType: true);
		public static GdkPixbuf.PixbufAnimation new_from_file(string filename, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_animation_new_from_file(filename, out error);
		public static GdkPixbuf.PixbufAnimation new_from_resource(string resource_path, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_animation_new_from_resource(resource_path, out error);
		public static GdkPixbuf.PixbufAnimation new_from_stream(Gio.InputStream stream, Gio.Cancellable cancellable, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_animation_new_from_stream(stream, cancellable, out error);
		public static GdkPixbuf.PixbufAnimation new_from_stream_finish(Gio.AsyncResult async_result, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_animation_new_from_stream_finish(async_result, out error);
		public static void new_from_stream_async(Gio.InputStream stream, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data) => GdkPixbufInterop.gdk_pixbuf_animation_new_from_stream_async(stream, cancellable, callback, user_data);
		public int get_height() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_get_height(this);
		public GdkPixbuf.Pixbuf get_static_image() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_get_static_image(this);
		public int get_width() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_get_width(this);
		public bool is_static_image() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_is_static_image(this);
		public GdkPixbuf.PixbufAnimation @ref() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_ref(this);
		public void unref() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_unref(this);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, ref weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, ref weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libgdk_pixbuf-2.0.so.0", EntryPoint = "gdk_pixbuf_animation_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct PixbufAnimationIter
	{
		private IntPtr _pointer;
		public PixbufAnimationIter(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator PixbufAnimationIter(IntPtr pointer) => new PixbufAnimationIter(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufAnimationIter value) => value._pointer;
		public static implicit operator GObject.Object(PixbufAnimationIter value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator PixbufAnimationIter(GObject.Object value) => new PixbufAnimationIter((IntPtr)value, checkType: true);
		public int get_delay_time() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_iter_get_delay_time(this);
		public GdkPixbuf.Pixbuf get_pixbuf() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_iter_get_pixbuf(this);
		public bool on_currently_loading_frame() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_iter_on_currently_loading_frame(this);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, ref weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, ref weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
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
		[DllImport("libgdk_pixbuf-2.0.so.0", EntryPoint = "gdk_pixbuf_animation_iter_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum PixbufError
	{
		corrupt_image = 0,
		insufficient_memory = 1,
		bad_option = 2,
		unknown_type = 3,
		unsupported_operation = 4,
		failed = 5,
		incomplete_animation = 6,
	}
	public ref struct PixbufLoader
	{
		private IntPtr _pointer;
		public PixbufLoader(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator PixbufLoader(IntPtr pointer) => new PixbufLoader(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufLoader value) => value._pointer;
		public static implicit operator GObject.Object(PixbufLoader value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator PixbufLoader(GObject.Object value) => new PixbufLoader((IntPtr)value, checkType: true);
		public static GdkPixbuf.PixbufLoader @new() => GdkPixbufInterop.gdk_pixbuf_loader_new();
		public static GdkPixbuf.PixbufLoader new_with_mime_type(string mime_type, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_loader_new_with_mime_type(mime_type, out error);
		public static GdkPixbuf.PixbufLoader new_with_type(string image_type, out GLib.Error error) => GdkPixbufInterop.gdk_pixbuf_loader_new_with_type(image_type, out error);
		public bool close(out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_loader_close(this, out error);
		public GdkPixbuf.PixbufAnimation get_animation() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_loader_get_animation(this);
		public GdkPixbuf.PixbufFormat get_format() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_loader_get_format(this);
		public GdkPixbuf.Pixbuf get_pixbuf() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_loader_get_pixbuf(this);
		public void set_size(int width, int height) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_loader_set_size(this, width, height);
		public bool write(System.IntPtr buf, ulong count, out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_loader_write(this, buf, count, out error);
		public bool write_bytes(GLib.Bytes buffer, out GLib.Error error) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_loader_write_bytes(this, buffer, out error);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, ref weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, ref weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
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
		[DllImport("libgdk_pixbuf-2.0.so.0", EntryPoint = "gdk_pixbuf_loader_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct PixbufLoaderClass
	{
		private IntPtr _pointer;
		public PixbufLoaderClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PixbufLoaderClass(IntPtr pointer) => new PixbufLoaderClass(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufLoaderClass value) => value._pointer;
	}
	public ref struct PixbufSimpleAnim
	{
		private IntPtr _pointer;
		public PixbufSimpleAnim(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator PixbufSimpleAnim(IntPtr pointer) => new PixbufSimpleAnim(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufSimpleAnim value) => value._pointer;
		public static implicit operator GdkPixbuf.PixbufAnimation(PixbufSimpleAnim value) => new GdkPixbuf.PixbufAnimation((IntPtr)value, checkType: false);
		public static explicit operator PixbufSimpleAnim(GdkPixbuf.PixbufAnimation value) => new PixbufSimpleAnim((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(PixbufSimpleAnim value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator PixbufSimpleAnim(GObject.Object value) => new PixbufSimpleAnim((IntPtr)value, checkType: true);
		public static GdkPixbuf.PixbufSimpleAnim @new(int width, int height, float rate) => GdkPixbufInterop.gdk_pixbuf_simple_anim_new(width, height, rate);
		public void add_frame(GdkPixbuf.Pixbuf pixbuf) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_simple_anim_add_frame(this, pixbuf);
		public bool get_loop() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_simple_anim_get_loop(this);
		public void set_loop(bool loop) => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_simple_anim_set_loop(this, loop);
		public int get_height() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_get_height(this);
		public GdkPixbuf.Pixbuf get_static_image() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_get_static_image(this);
		public int get_width() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_get_width(this);
		public bool is_static_image() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_is_static_image(this);
		public GdkPixbuf.PixbufAnimation @ref() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_ref(this);
		public void unref() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_unref(this);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, ref weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, ref weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_object_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_qdata_full(this, quark, data, destroy);
		public void setv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_setv(this, n_properties, names, values);
		public System.IntPtr steal_data(string key) => GObject.GObjectInterop.g_object_steal_data(this, key);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_object_steal_qdata(this, quark);
		public void thaw_notify() => GObject.GObjectInterop.g_object_thaw_notify(this);
		public void watch_closure(GObject.Closure closure) => GObject.GObjectInterop.g_object_watch_closure(this, closure);
		public void weak_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_ref(this, notify, data);
		public void weak_unref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_weak_unref(this, notify, data);
		[DllImport("libgdk_pixbuf-2.0.so.0", EntryPoint = "gdk_pixbuf_simple_anim_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct PixbufSimpleAnimClass
	{
		private IntPtr _pointer;
		public PixbufSimpleAnimClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PixbufSimpleAnimClass(IntPtr pointer) => new PixbufSimpleAnimClass(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufSimpleAnimClass value) => value._pointer;
	}
	public ref struct PixbufSimpleAnimIter
	{
		private IntPtr _pointer;
		public PixbufSimpleAnimIter(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator PixbufSimpleAnimIter(IntPtr pointer) => new PixbufSimpleAnimIter(pointer, checkType: true);
		public static explicit operator IntPtr(PixbufSimpleAnimIter value) => value._pointer;
		public static implicit operator GdkPixbuf.PixbufAnimationIter(PixbufSimpleAnimIter value) => new GdkPixbuf.PixbufAnimationIter((IntPtr)value, checkType: false);
		public static explicit operator PixbufSimpleAnimIter(GdkPixbuf.PixbufAnimationIter value) => new PixbufSimpleAnimIter((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(PixbufSimpleAnimIter value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator PixbufSimpleAnimIter(GObject.Object value) => new PixbufSimpleAnimIter((IntPtr)value, checkType: true);
		public int get_delay_time() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_iter_get_delay_time(this);
		public GdkPixbuf.Pixbuf get_pixbuf() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_iter_get_pixbuf(this);
		public bool on_currently_loading_frame() => GdkPixbuf.GdkPixbufInterop.gdk_pixbuf_animation_iter_on_currently_loading_frame(this);
		public void add_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_add_toggle_ref(this, notify, data);
		public void add_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_add_weak_pointer(this, ref weak_pointer_location);
		public GObject.Binding bind_property(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags) => GObject.GObjectInterop.g_object_bind_property(this, source_property, target, target_property, flags);
		public GObject.Binding bind_property_full(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify) => GObject.GObjectInterop.g_object_bind_property_full(this, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
		public GObject.Binding bind_property_with_closures(string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from) => GObject.GObjectInterop.g_object_bind_property_with_closures(this, source_property, target, target_property, flags, transform_to, transform_from);
		public System.IntPtr dup_data(string key, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_data(this, key, dup_func, user_data);
		public System.IntPtr dup_qdata(uint quark, System.IntPtr dup_func, System.IntPtr user_data) => GObject.GObjectInterop.g_object_dup_qdata(this, quark, dup_func, user_data);
		public void force_floating() => GObject.GObjectInterop.g_object_force_floating(this);
		public void freeze_notify() => GObject.GObjectInterop.g_object_freeze_notify(this);
		public System.IntPtr get_data(string key) => GObject.GObjectInterop.g_object_get_data(this, key);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_object_get_qdata(this, quark);
		public void getv(uint n_properties, System.IntPtr names, System.IntPtr values) => GObject.GObjectInterop.g_object_getv(this, n_properties, names, values);
		public bool is_floating() => GObject.GObjectInterop.g_object_is_floating(this);
		public void notify(string property_name) => GObject.GObjectInterop.g_object_notify(this, property_name);
		public void notify_by_pspec(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_notify_by_pspec(this, pspec);
		public GObject.Object @ref() => GObject.GObjectInterop.g_object_ref(this);
		public GObject.Object ref_sink() => GObject.GObjectInterop.g_object_ref_sink(this);
		public void remove_toggle_ref(System.IntPtr notify, System.IntPtr data) => GObject.GObjectInterop.g_object_remove_toggle_ref(this, notify, data);
		public void remove_weak_pointer(ref System.IntPtr weak_pointer_location) => GObject.GObjectInterop.g_object_remove_weak_pointer(this, ref weak_pointer_location);
		public bool replace_data(string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_data(this, key, oldval, newval, destroy, old_destroy);
		public bool replace_qdata(uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy) => GObject.GObjectInterop.g_object_replace_qdata(this, quark, oldval, newval, destroy, old_destroy);
		public void run_dispose() => GObject.GObjectInterop.g_object_run_dispose(this);
		public void set_data(string key, System.IntPtr data) => GObject.GObjectInterop.g_object_set_data(this, key, data);
		public void set_data_full(string key, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_object_set_data_full(this, key, data, destroy);
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
		[DllImport("libgdk_pixbuf-2.0.so.0", EntryPoint = "gdk_pixbuf_simple_anim_iter_get_type")]
		public static extern GLib.GType TypeOf();
	}
	[Flags]
	public enum PixdataDumpType
	{
		pixdata_stream = 0,
		pixdata_struct = 1,
		macros = 2,
		gtypes = 0,
		ctypes = 256,
		@static = 512,
		@const = 1024,
		rle_decoder = 65536,
	}
	[Flags]
	public enum PixdataType
	{
		color_type_rgb = 1,
		color_type_rgba = 2,
		color_type_mask = 255,
		sample_width_8 = 65536,
		sample_width_mask = 983040,
		encoding_raw = 16777216,
		encoding_rle = 33554432,
		encoding_mask = 251658240,
	}
	public static class GdkPixbufInterop {
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new(GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_bytes(GLib.Bytes data, GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_data(System.IntPtr data, GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height, int rowstride, System.IntPtr destroy_fn, System.IntPtr destroy_fn_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_file(string filename, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, bool preserve_aspect_ratio, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_inline(int data_length, System.IntPtr data, bool copy_pixels, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_resource(string resource_path, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, bool preserve_aspect_ratio, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_stream(Gio.InputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_stream_at_scale(Gio.InputStream stream, int width, int height, bool preserve_aspect_ratio, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_stream_finish(Gio.AsyncResult async_result, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_xpm_data(System.IntPtr data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_calculate_rowstride(GdkPixbuf.Colorspace colorspace, bool has_alpha, int bits_per_sample, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_from_pixdata(GdkPixbuf.Pixdata pixdata, bool copy_pixels, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufFormat gdk_pixbuf_get_file_info(string filename, out int width, out int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_get_file_info_async(string filename, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufFormat gdk_pixbuf_get_file_info_finish(Gio.AsyncResult async_result, out int width, out int height, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_get_formats();
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_new_from_stream_async(Gio.InputStream stream, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_new_from_stream_at_scale_async(Gio.InputStream stream, int width, int height, bool preserve_aspect_ratio, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_save_to_stream_finish(Gio.AsyncResult async_result, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_add_alpha(GdkPixbuf.Pixbuf pixbuf, bool substitute_color, byte r, byte g, byte b);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_apply_embedded_orientation(GdkPixbuf.Pixbuf src);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_composite(GdkPixbuf.Pixbuf src, GdkPixbuf.Pixbuf dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkPixbuf.InterpType interp_type, int overall_alpha);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_composite_color(GdkPixbuf.Pixbuf src, GdkPixbuf.Pixbuf dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkPixbuf.InterpType interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_composite_color_simple(GdkPixbuf.Pixbuf src, int dest_width, int dest_height, GdkPixbuf.InterpType interp_type, int overall_alpha, int check_size, uint color1, uint color2);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_copy(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_copy_area(GdkPixbuf.Pixbuf src_pixbuf, int src_x, int src_y, int width, int height, GdkPixbuf.Pixbuf dest_pixbuf, int dest_x, int dest_y);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_copy_options(GdkPixbuf.Pixbuf src_pixbuf, GdkPixbuf.Pixbuf dest_pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_fill(GdkPixbuf.Pixbuf pixbuf, uint pixel);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_flip(GdkPixbuf.Pixbuf src, bool horizontal);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_bits_per_sample(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern ulong gdk_pixbuf_get_byte_length(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Colorspace gdk_pixbuf_get_colorspace(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_get_has_alpha(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_height(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_n_channels(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern string gdk_pixbuf_get_option(GdkPixbuf.Pixbuf pixbuf, string key);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_get_options(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_get_pixels(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_get_pixels_with_length(GdkPixbuf.Pixbuf pixbuf, out uint length);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_rowstride(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_width(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_subpixbuf(GdkPixbuf.Pixbuf src_pixbuf, int src_x, int src_y, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GLib.Bytes gdk_pixbuf_read_pixel_bytes(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern byte gdk_pixbuf_read_pixels(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_ref(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_remove_option(GdkPixbuf.Pixbuf pixbuf, string key);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_rotate_simple(GdkPixbuf.Pixbuf src, GdkPixbuf.PixbufRotation angle);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_saturate_and_pixelate(GdkPixbuf.Pixbuf src, GdkPixbuf.Pixbuf dest, float saturation, bool pixelate);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_save_to_bufferv(GdkPixbuf.Pixbuf pixbuf, out System.IntPtr buffer, out ulong buffer_size, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_save_to_callbackv(GdkPixbuf.Pixbuf pixbuf, System.IntPtr save_func, System.IntPtr user_data, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_save_to_streamv(GdkPixbuf.Pixbuf pixbuf, Gio.OutputStream stream, string type, System.IntPtr option_keys, System.IntPtr option_values, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_save_to_streamv_async(GdkPixbuf.Pixbuf pixbuf, Gio.OutputStream stream, string type, System.IntPtr option_keys, System.IntPtr option_values, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_savev(GdkPixbuf.Pixbuf pixbuf, string filename, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_scale(GdkPixbuf.Pixbuf src, GdkPixbuf.Pixbuf dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkPixbuf.InterpType interp_type);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_scale_simple(GdkPixbuf.Pixbuf src, int dest_width, int dest_height, GdkPixbuf.InterpType interp_type);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_set_option(GdkPixbuf.Pixbuf pixbuf, string key, string value);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_unref(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixdata_deserialize(GdkPixbuf.Pixdata pixdata, uint stream_length, System.IntPtr stream, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixdata_from_pixbuf(GdkPixbuf.Pixdata pixdata, GdkPixbuf.Pixbuf pixbuf, bool use_rle);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixdata_serialize(GdkPixbuf.Pixdata pixdata, out uint stream_length_p);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufFormat gdk_pixbuf_format_copy(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_format_free(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern string gdk_pixbuf_format_get_description(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_format_get_extensions(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern string gdk_pixbuf_format_get_license(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_format_get_mime_types(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern string gdk_pixbuf_format_get_name(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_format_is_disabled(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_format_is_save_option_supported(GdkPixbuf.PixbufFormat format, string option_key);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_format_is_scalable(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_format_is_writable(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_format_set_disabled(GdkPixbuf.PixbufFormat format, bool disabled);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_animation_new_from_file(string filename, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_animation_new_from_resource(string resource_path, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_animation_new_from_stream(Gio.InputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_animation_new_from_stream_finish(Gio.AsyncResult async_result, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_animation_new_from_stream_async(Gio.InputStream stream, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_get_height(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_animation_get_static_image(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_get_width(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_animation_is_static_image(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_animation_ref(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_animation_unref(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_iter_get_delay_time(GdkPixbuf.PixbufAnimationIter iter);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_animation_iter_get_pixbuf(GdkPixbuf.PixbufAnimationIter iter);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_animation_iter_on_currently_loading_frame(GdkPixbuf.PixbufAnimationIter iter);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern uint gdk_pixbuf_error_quark();
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufLoader gdk_pixbuf_loader_new();
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufLoader gdk_pixbuf_loader_new_with_mime_type(string mime_type, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufLoader gdk_pixbuf_loader_new_with_type(string image_type, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_loader_close(GdkPixbuf.PixbufLoader loader, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_loader_get_animation(GdkPixbuf.PixbufLoader loader);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufFormat gdk_pixbuf_loader_get_format(GdkPixbuf.PixbufLoader loader);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_loader_get_pixbuf(GdkPixbuf.PixbufLoader loader);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_loader_set_size(GdkPixbuf.PixbufLoader loader, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_loader_write(GdkPixbuf.PixbufLoader loader, System.IntPtr buf, ulong count, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_loader_write_bytes(GdkPixbuf.PixbufLoader loader, GLib.Bytes buffer, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufSimpleAnim gdk_pixbuf_simple_anim_new(int width, int height, float rate);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_simple_anim_add_frame(GdkPixbuf.PixbufSimpleAnim animation, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern bool gdk_pixbuf_simple_anim_get_loop(GdkPixbuf.PixbufSimpleAnim animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_simple_anim_set_loop(GdkPixbuf.PixbufSimpleAnim animation, bool loop);
	}
}
