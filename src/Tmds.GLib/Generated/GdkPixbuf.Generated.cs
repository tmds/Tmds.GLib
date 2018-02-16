using System;
using System.Runtime.InteropServices;

namespace GdkPixbuf
{
    public static class GdkPixbufInterop
    {
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new(int colorspace, int has_alpha, int bits_per_sample, int width, int height);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_bytes(System.IntPtr data, int colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_data(System.IntPtr data, int colorspace, int has_alpha, int bits_per_sample, int width, int height, int rowstride, System.IntPtr destroy_fn, System.IntPtr destroy_fn_data);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_file(string filename, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_file_at_scale(string filename, int width, int height, int preserve_aspect_ratio, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_file_at_size(string filename, int width, int height, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_inline(int data_length, System.IntPtr data, int copy_pixels, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_resource(string resource_path, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_resource_at_scale(string resource_path, int width, int height, int preserve_aspect_ratio, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_stream(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_stream_at_scale(System.IntPtr stream, int width, int height, int preserve_aspect_ratio, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_stream_finish(System.IntPtr async_result, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_from_xpm_data(System.IntPtr data);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_calculate_rowstride(int colorspace, int has_alpha, int bits_per_sample, int width, int height);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_from_pixdata(System.IntPtr pixdata, int copy_pixels, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_get_file_info(string filename, System.IntPtr width, System.IntPtr height);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_get_file_info_async(string filename, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_get_file_info_finish(System.IntPtr async_result, System.IntPtr width, System.IntPtr height, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_get_formats();
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_new_from_stream_async(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_new_from_stream_at_scale_async(System.IntPtr stream, int width, int height, int preserve_aspect_ratio, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_save_to_stream_finish(System.IntPtr async_result, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_add_alpha(System.IntPtr pixbuf, int substitute_color, byte r, byte g, byte b);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_apply_embedded_orientation(System.IntPtr src);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_composite(System.IntPtr src, System.IntPtr dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, int interp_type, int overall_alpha);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_composite_color(System.IntPtr src, System.IntPtr dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, int interp_type, int overall_alpha, int check_x, int check_y, int check_size, uint color1, uint color2);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_composite_color_simple(System.IntPtr src, int dest_width, int dest_height, int interp_type, int overall_alpha, int check_size, uint color1, uint color2);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_copy(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_copy_area(System.IntPtr src_pixbuf, int src_x, int src_y, int width, int height, System.IntPtr dest_pixbuf, int dest_x, int dest_y);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_copy_options(System.IntPtr src_pixbuf, System.IntPtr dest_pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_fill(System.IntPtr pixbuf, uint pixel);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_flip(System.IntPtr src, int horizontal);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_get_bits_per_sample(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern ulong gdk_pixbuf_get_byte_length(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_get_colorspace(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_get_has_alpha(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_get_height(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_get_n_channels(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern string gdk_pixbuf_get_option(System.IntPtr pixbuf, string key);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_get_options(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_get_pixels(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_get_pixels_with_length(System.IntPtr pixbuf, System.IntPtr length);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_get_rowstride(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_get_width(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_new_subpixbuf(System.IntPtr src_pixbuf, int src_x, int src_y, int width, int height);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_read_pixel_bytes(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_read_pixels(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_ref(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_remove_option(System.IntPtr pixbuf, string key);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_rotate_simple(System.IntPtr src, int angle);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_saturate_and_pixelate(System.IntPtr src, System.IntPtr dest, float saturation, int pixelate);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_save_to_bufferv(System.IntPtr pixbuf, System.IntPtr buffer, System.IntPtr buffer_size, string type, System.IntPtr option_keys, System.IntPtr option_values, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_save_to_callbackv(System.IntPtr pixbuf, System.IntPtr save_func, System.IntPtr user_data, string type, System.IntPtr option_keys, System.IntPtr option_values, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_save_to_streamv(System.IntPtr pixbuf, System.IntPtr stream, string type, System.IntPtr option_keys, System.IntPtr option_values, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_save_to_streamv_async(System.IntPtr pixbuf, System.IntPtr stream, string type, System.IntPtr option_keys, System.IntPtr option_values, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_savev(System.IntPtr pixbuf, string filename, string type, System.IntPtr option_keys, System.IntPtr option_values, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_scale(System.IntPtr src, System.IntPtr dest, int dest_x, int dest_y, int dest_width, int dest_height, double offset_x, double offset_y, double scale_x, double scale_y, int interp_type);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_scale_simple(System.IntPtr src, int dest_width, int dest_height, int interp_type);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_set_option(System.IntPtr pixbuf, string key, string value);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_unref(System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixdata_deserialize(System.IntPtr pixdata, uint stream_length, System.IntPtr stream, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixdata_from_pixbuf(System.IntPtr pixdata, System.IntPtr pixbuf, int use_rle);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixdata_serialize(System.IntPtr pixdata, System.IntPtr stream_length_p);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixdata_to_csource(System.IntPtr pixdata, string name, int dump_type);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_format_copy(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_format_free(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern string gdk_pixbuf_format_get_description(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_format_get_extensions(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern string gdk_pixbuf_format_get_license(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_format_get_mime_types(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern string gdk_pixbuf_format_get_name(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_format_is_disabled(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_format_is_save_option_supported(System.IntPtr format, string option_key);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_format_is_scalable(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_format_is_writable(System.IntPtr format);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_format_set_disabled(System.IntPtr format, int disabled);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_new_from_file(string filename, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_new_from_resource(string resource_path, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_new_from_stream(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_new_from_stream_finish(System.IntPtr async_result, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_animation_new_from_stream_async(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_animation_get_height(System.IntPtr animation);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_get_iter(System.IntPtr animation, System.IntPtr start_time);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_get_static_image(System.IntPtr animation);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_animation_get_width(System.IntPtr animation);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_animation_is_static_image(System.IntPtr animation);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_ref(System.IntPtr animation);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_animation_unref(System.IntPtr animation);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_animation_iter_advance(System.IntPtr iter, System.IntPtr current_time);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_animation_iter_get_delay_time(System.IntPtr iter);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_animation_iter_get_pixbuf(System.IntPtr iter);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_animation_iter_on_currently_loading_frame(System.IntPtr iter);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern uint gdk_pixbuf_error_quark();
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_loader_new();
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_loader_new_with_mime_type(string mime_type, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_loader_new_with_type(string image_type, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_loader_close(System.IntPtr loader, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_loader_get_animation(System.IntPtr loader);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_loader_get_format(System.IntPtr loader);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_loader_get_pixbuf(System.IntPtr loader);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_loader_set_size(System.IntPtr loader, int width, int height);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_loader_write(System.IntPtr loader, System.IntPtr buf, ulong count, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_loader_write_bytes(System.IntPtr loader, System.IntPtr buffer, System.IntPtr error);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern System.IntPtr gdk_pixbuf_simple_anim_new(int width, int height, float rate);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_simple_anim_add_frame(System.IntPtr animation, System.IntPtr pixbuf);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern int gdk_pixbuf_simple_anim_get_loop(System.IntPtr animation);
        [DllImport("libgdk_pixbuf-2.0.so.0")]
        public static extern void gdk_pixbuf_simple_anim_set_loop(System.IntPtr animation, int loop);
    }
}