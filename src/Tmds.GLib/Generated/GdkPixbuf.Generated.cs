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
		public static explicit operator Pixbuf(IntPtr pointer) => new Pixbuf { _pointer = pointer };
		public static explicit operator IntPtr(Pixbuf value) => value._pointer
;		public static implicit operator GObject.Object(Pixbuf value) => (GObject.Object)value._pointer
;		public static explicit operator Pixbuf(GObject.Object value) => (Pixbuf)(IntPtr)value
;	}
	public ref struct Pixdata
	{
		private IntPtr _pointer;
		public static explicit operator Pixdata(IntPtr pointer) => new Pixdata { _pointer = pointer };
		public static explicit operator IntPtr(Pixdata value) => value._pointer
;	}
	public ref struct PixbufFormat
	{
		private IntPtr _pointer;
		public static explicit operator PixbufFormat(IntPtr pointer) => new PixbufFormat { _pointer = pointer };
		public static explicit operator IntPtr(PixbufFormat value) => value._pointer
;	}
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
		public static explicit operator PixbufAnimation(IntPtr pointer) => new PixbufAnimation { _pointer = pointer };
		public static explicit operator IntPtr(PixbufAnimation value) => value._pointer
;		public static implicit operator GObject.Object(PixbufAnimation value) => (GObject.Object)value._pointer
;		public static explicit operator PixbufAnimation(GObject.Object value) => (PixbufAnimation)(IntPtr)value
;	}
	public ref struct PixbufAnimationIter
	{
		private IntPtr _pointer;
		public static explicit operator PixbufAnimationIter(IntPtr pointer) => new PixbufAnimationIter { _pointer = pointer };
		public static explicit operator IntPtr(PixbufAnimationIter value) => value._pointer
;		public static implicit operator GObject.Object(PixbufAnimationIter value) => (GObject.Object)value._pointer
;		public static explicit operator PixbufAnimationIter(GObject.Object value) => (PixbufAnimationIter)(IntPtr)value
;	}
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
		public static explicit operator PixbufLoader(IntPtr pointer) => new PixbufLoader { _pointer = pointer };
		public static explicit operator IntPtr(PixbufLoader value) => value._pointer
;		public static implicit operator GObject.Object(PixbufLoader value) => (GObject.Object)value._pointer
;		public static explicit operator PixbufLoader(GObject.Object value) => (PixbufLoader)(IntPtr)value
;	}
	public ref struct PixbufLoaderClass
	{
		private IntPtr _pointer;
		public static explicit operator PixbufLoaderClass(IntPtr pointer) => new PixbufLoaderClass { _pointer = pointer };
		public static explicit operator IntPtr(PixbufLoaderClass value) => value._pointer
;	}
	public ref struct PixbufSimpleAnim
	{
		private IntPtr _pointer;
		public static explicit operator PixbufSimpleAnim(IntPtr pointer) => new PixbufSimpleAnim { _pointer = pointer };
		public static explicit operator IntPtr(PixbufSimpleAnim value) => value._pointer
;		public static implicit operator GdkPixbuf.PixbufAnimation(PixbufSimpleAnim value) => (GdkPixbuf.PixbufAnimation)value._pointer
;		public static explicit operator PixbufSimpleAnim(GdkPixbuf.PixbufAnimation value) => (PixbufSimpleAnim)(IntPtr)value
;		public static implicit operator GObject.Object(PixbufSimpleAnim value) => (GObject.Object)value._pointer
;		public static explicit operator PixbufSimpleAnim(GObject.Object value) => (PixbufSimpleAnim)(IntPtr)value
;	}
	public ref struct PixbufSimpleAnimClass
	{
		private IntPtr _pointer;
		public static explicit operator PixbufSimpleAnimClass(IntPtr pointer) => new PixbufSimpleAnimClass { _pointer = pointer };
		public static explicit operator IntPtr(PixbufSimpleAnimClass value) => value._pointer
;	}
	public ref struct PixbufSimpleAnimIter
	{
		private IntPtr _pointer;
		public static explicit operator PixbufSimpleAnimIter(IntPtr pointer) => new PixbufSimpleAnimIter { _pointer = pointer };
		public static explicit operator IntPtr(PixbufSimpleAnimIter value) => value._pointer
;		public static implicit operator GdkPixbuf.PixbufAnimationIter(PixbufSimpleAnimIter value) => (GdkPixbuf.PixbufAnimationIter)value._pointer
;		public static explicit operator PixbufSimpleAnimIter(GdkPixbuf.PixbufAnimationIter value) => (PixbufSimpleAnimIter)(IntPtr)value
;		public static implicit operator GObject.Object(PixbufSimpleAnimIter value) => (GObject.Object)value._pointer
;		public static explicit operator PixbufSimpleAnimIter(GObject.Object value) => (PixbufSimpleAnimIter)(IntPtr)value
;	}
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
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new(GdkPixbuf.Colorspace colorspace, int has_alpha, int bits_per_sample, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_bytes(GLib.Bytes data, GdkPixbuf.Colorspace colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_data(System.IntPtr data, GdkPixbuf.Colorspace colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride, System.IntPtr destroy_fn, System.IntPtr destroy_fn_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_file(string filename, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, int preserve_aspect_ratio, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_inline(int data_length, System.IntPtr data, int copy_pixels, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_resource(string resource_path, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, int preserve_aspect_ratio, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_stream(Gio.InputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_stream_at_scale(Gio.InputStream stream, int width, int height, int preserve_aspect_ratio, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_stream_finish(Gio.AsyncResult async_result, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_from_xpm_data(System.IntPtr data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_calculate_rowstride(GdkPixbuf.Colorspace colorspace, int has_alpha, int bits_per_sample, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_from_pixdata(GdkPixbuf.Pixdata pixdata, int copy_pixels, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufFormat gdk_pixbuf_get_file_info(string filename, System.IntPtr width, System.IntPtr height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_get_file_info_async(string filename, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufFormat gdk_pixbuf_get_file_info_finish(Gio.AsyncResult async_result, System.IntPtr width, System.IntPtr height, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_get_formats();
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_new_from_stream_async(Gio.InputStream stream, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_new_from_stream_at_scale_async(Gio.InputStream stream, int width, int height, int preserve_aspect_ratio, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_save_to_stream_finish(Gio.AsyncResult async_result, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_add_alpha(GdkPixbuf.Pixbuf pixbuf, int substitute_color, byte r, byte g, byte b);
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
		public static extern int gdk_pixbuf_copy_options(GdkPixbuf.Pixbuf src_pixbuf, GdkPixbuf.Pixbuf dest_pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_fill(GdkPixbuf.Pixbuf pixbuf, uint pixel);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_flip(GdkPixbuf.Pixbuf src, int horizontal);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_bits_per_sample(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern ulong gdk_pixbuf_get_byte_length(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Colorspace gdk_pixbuf_get_colorspace(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_has_alpha(GdkPixbuf.Pixbuf pixbuf);
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
		public static extern System.IntPtr gdk_pixbuf_get_pixels_with_length(GdkPixbuf.Pixbuf pixbuf, System.IntPtr length);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_rowstride(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_get_width(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_new_subpixbuf(GdkPixbuf.Pixbuf src_pixbuf, int src_x, int src_y, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GLib.Bytes gdk_pixbuf_read_pixel_bytes(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixbuf_read_pixels(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_ref(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_remove_option(GdkPixbuf.Pixbuf pixbuf, string key);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_rotate_simple(GdkPixbuf.Pixbuf src, GdkPixbuf.PixbufRotation angle);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_saturate_and_pixelate(GdkPixbuf.Pixbuf src, GdkPixbuf.Pixbuf dest, float saturation, int pixelate);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_save_to_bufferv(GdkPixbuf.Pixbuf pixbuf, System.IntPtr buffer, System.IntPtr buffer_size, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_save_to_callbackv(GdkPixbuf.Pixbuf pixbuf, System.IntPtr save_func, System.IntPtr user_data, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_save_to_streamv(GdkPixbuf.Pixbuf pixbuf, Gio.OutputStream stream, string type, System.IntPtr option_keys, System.IntPtr option_values, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_save_to_streamv_async(GdkPixbuf.Pixbuf pixbuf, Gio.OutputStream stream, string type, System.IntPtr option_keys, System.IntPtr option_values, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_savev(GdkPixbuf.Pixbuf pixbuf, string filename, string type, System.IntPtr option_keys, System.IntPtr option_values, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_scale(GdkPixbuf.Pixbuf src, GdkPixbuf.Pixbuf dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, GdkPixbuf.InterpType interp_type);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_scale_simple(GdkPixbuf.Pixbuf src, int dest_width, int dest_height, GdkPixbuf.InterpType interp_type);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_set_option(GdkPixbuf.Pixbuf pixbuf, string key, string value);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_unref(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixdata_deserialize(GdkPixbuf.Pixdata pixdata, uint stream_length, System.IntPtr stream, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixdata_from_pixbuf(GdkPixbuf.Pixdata pixdata, GdkPixbuf.Pixbuf pixbuf, int use_rle);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern System.IntPtr gdk_pixdata_serialize(GdkPixbuf.Pixdata pixdata, System.IntPtr stream_length_p);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GLib.String gdk_pixdata_to_csource(GdkPixbuf.Pixdata pixdata, string name, GdkPixbuf.PixdataDumpType dump_type);
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
		public static extern int gdk_pixbuf_format_is_disabled(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_format_is_save_option_supported(GdkPixbuf.PixbufFormat format, string option_key);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_format_is_scalable(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_format_is_writable(GdkPixbuf.PixbufFormat format);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_format_set_disabled(GdkPixbuf.PixbufFormat format, int disabled);
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
		public static extern GdkPixbuf.PixbufAnimationIter gdk_pixbuf_animation_get_iter(GdkPixbuf.PixbufAnimation animation, GLib.TimeVal start_time);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_animation_get_static_image(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_get_width(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_is_static_image(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_animation_ref(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_animation_unref(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_iter_advance(GdkPixbuf.PixbufAnimationIter iter, GLib.TimeVal current_time);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_iter_get_delay_time(GdkPixbuf.PixbufAnimationIter iter);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_animation_iter_get_pixbuf(GdkPixbuf.PixbufAnimationIter iter);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_animation_iter_on_currently_loading_frame(GdkPixbuf.PixbufAnimationIter iter);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern uint gdk_pixbuf_error_quark();
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufLoader gdk_pixbuf_loader_new();
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufLoader gdk_pixbuf_loader_new_with_mime_type(string mime_type, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufLoader gdk_pixbuf_loader_new_with_type(string image_type, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_loader_close(GdkPixbuf.PixbufLoader loader, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gdk_pixbuf_loader_get_animation(GdkPixbuf.PixbufLoader loader);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufFormat gdk_pixbuf_loader_get_format(GdkPixbuf.PixbufLoader loader);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.Pixbuf gdk_pixbuf_loader_get_pixbuf(GdkPixbuf.PixbufLoader loader);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_loader_set_size(GdkPixbuf.PixbufLoader loader, int width, int height);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_loader_write(GdkPixbuf.PixbufLoader loader, System.IntPtr buf, ulong count, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_loader_write_bytes(GdkPixbuf.PixbufLoader loader, GLib.Bytes buffer, out GLib.Error error);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern GdkPixbuf.PixbufSimpleAnim gdk_pixbuf_simple_anim_new(int width, int height, float rate);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_simple_anim_add_frame(GdkPixbuf.PixbufSimpleAnim animation, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern int gdk_pixbuf_simple_anim_get_loop(GdkPixbuf.PixbufSimpleAnim animation);
		[DllImport("libgdk_pixbuf-2.0.so.0")]
		public static extern void gdk_pixbuf_simple_anim_set_loop(GdkPixbuf.PixbufSimpleAnim animation, int loop);
	}
}
