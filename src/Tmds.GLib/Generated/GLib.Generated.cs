using System;
using System.Runtime.InteropServices;

namespace GLib
{
    public static class GLibInterop
    {
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_access(System.IntPtr filename, int mode);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ascii_digit_value(sbyte c);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_ascii_dtostr(string buffer, int buf_len, double d);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_ascii_formatd(string buffer, int buf_len, string format, double d);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ascii_strcasecmp(string s1, string s2);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_ascii_strdown(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ascii_string_to_signed(string str, uint @base, long min, long max, System.IntPtr out_num, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ascii_string_to_unsigned(string str, uint @base, ulong min, ulong max, System.IntPtr out_num, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ascii_strncasecmp(string s1, string s2, ulong n);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_ascii_strtod(string nptr, string endptr);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_ascii_strtoll(string nptr, string endptr, uint @base);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_ascii_strtoull(string nptr, string endptr, uint @base);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_ascii_strup(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern sbyte g_ascii_tolower(sbyte c);
        [DllImport("libglib-2.0.so.0")]
        public static extern sbyte g_ascii_toupper(sbyte c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ascii_xdigit_value(sbyte c);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_assert_warning(string log_domain, string file, int line, string pretty_function, string expression);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_assertion_message(string domain, string file, int line, string func, string message);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_assertion_message_cmpstr(string domain, string file, int line, string func, string expr, string arg1, string cmp, string arg2);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_assertion_message_error(string domain, string file, int line, string func, string expr, System.IntPtr error, uint error_domain, int error_code);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_assertion_message_expr(string domain, string file, int line, string func, string expr);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_atexit(System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_atomic_int_add(System.IntPtr atomic, int val);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_atomic_int_and(System.IntPtr atomic, uint val);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_atomic_int_compare_and_exchange(System.IntPtr atomic, int oldval, int newval);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_atomic_int_dec_and_test(System.IntPtr atomic);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_atomic_int_exchange_and_add(System.IntPtr atomic, int val);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_atomic_int_get(System.IntPtr atomic);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_atomic_int_inc(System.IntPtr atomic);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_atomic_int_or(System.IntPtr atomic, uint val);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_atomic_int_set(System.IntPtr atomic, int newval);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_atomic_int_xor(System.IntPtr atomic, uint val);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_atomic_pointer_add(System.IntPtr atomic, long val);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_atomic_pointer_and(System.IntPtr atomic, ulong val);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_atomic_pointer_compare_and_exchange(System.IntPtr atomic, System.IntPtr oldval, System.IntPtr newval);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_atomic_pointer_get(System.IntPtr atomic);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_atomic_pointer_or(System.IntPtr atomic, ulong val);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_atomic_pointer_set(System.IntPtr atomic, System.IntPtr newval);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_atomic_pointer_xor(System.IntPtr atomic, ulong val);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_base64_decode(string text, System.IntPtr out_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_base64_decode_inplace(System.IntPtr text, System.IntPtr out_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_base64_decode_step(System.IntPtr @in, ulong len, System.IntPtr @out, System.IntPtr state, System.IntPtr save);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_base64_encode(System.IntPtr data, ulong len);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_base64_encode_close(int break_lines, System.IntPtr @out, System.IntPtr state, System.IntPtr save);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_base64_encode_step(System.IntPtr @in, ulong len, int break_lines, System.IntPtr @out, System.IntPtr state, System.IntPtr save);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_basename(System.IntPtr file_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bit_lock(System.IntPtr address, int lock_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bit_nth_lsf(ulong mask, int nth_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bit_nth_msf(ulong mask, int nth_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_bit_storage(ulong number);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bit_trylock(System.IntPtr address, int lock_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bit_unlock(System.IntPtr address, int lock_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_build_filenamev(System.IntPtr args);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_build_pathv(string separator, System.IntPtr args);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_chdir(System.IntPtr path);
        [DllImport("libglib-2.0.so.0")]
        public static extern string glib_check_version(uint required_major, uint required_minor, uint required_micro);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_child_watch_add(int pid, System.IntPtr function, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_child_watch_add_full(int priority, int pid, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_child_watch_source_new(int pid);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_clear_error(System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_clear_pointer(System.IntPtr pp, System.IntPtr destroy);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_close(int fd, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_compute_checksum_for_bytes(int checksum_type, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_compute_checksum_for_data(int checksum_type, System.IntPtr data, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_compute_checksum_for_string(int checksum_type, string str, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_compute_hmac_for_bytes(int digest_type, System.IntPtr key, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_compute_hmac_for_data(int digest_type, System.IntPtr key, ulong key_len, System.IntPtr data, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_compute_hmac_for_string(int digest_type, System.IntPtr key, ulong key_len, string str, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_convert(string str, long len, string to_codeset, string from_codeset, System.IntPtr bytes_read, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_convert_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_convert_with_fallback(string str, long len, string to_codeset, string from_codeset, string fallback, System.IntPtr bytes_read, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_datalist_clear(System.IntPtr datalist);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_datalist_foreach(System.IntPtr datalist, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_datalist_get_data(System.IntPtr datalist, string key);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_datalist_get_flags(System.IntPtr datalist);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_datalist_id_dup_data(System.IntPtr datalist, uint key_id, System.IntPtr dup_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_datalist_id_get_data(System.IntPtr datalist, uint key_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_datalist_id_remove_no_notify(System.IntPtr datalist, uint key_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_datalist_id_replace_data(System.IntPtr datalist, uint key_id, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_datalist_id_set_data_full(System.IntPtr datalist, uint key_id, System.IntPtr data, System.IntPtr destroy_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_datalist_init(System.IntPtr datalist);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_datalist_set_flags(System.IntPtr datalist, uint flags);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_datalist_unset_flags(System.IntPtr datalist, uint flags);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_dataset_destroy(System.IntPtr dataset_location);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_dataset_foreach(System.IntPtr dataset_location, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_dataset_id_get_data(System.IntPtr dataset_location, uint key_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_dataset_id_remove_no_notify(System.IntPtr dataset_location, uint key_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_dataset_id_set_data_full(System.IntPtr dataset_location, uint key_id, System.IntPtr data, System.IntPtr destroy_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_dcgettext(string domain, string msgid, int category);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_dgettext(string domain, string msgid);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_direct_equal(System.IntPtr v1, System.IntPtr v2);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_direct_hash(System.IntPtr v);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_dngettext(string domain, string msgid, string msgid_plural, ulong n);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_double_equal(System.IntPtr v1, System.IntPtr v2);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_double_hash(System.IntPtr v);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_dpgettext(string domain, string msgctxtid, ulong msgidoffset);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_dpgettext2(string domain, string context, string msgid);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_environ_getenv(System.IntPtr envp, string variable);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_environ_setenv(System.IntPtr envp, string variable, string value, int overwrite);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_environ_unsetenv(System.IntPtr envp, string variable);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_file_error_from_errno(int err_no);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_file_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_file_get_contents(System.IntPtr filename, System.IntPtr contents, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_file_open_tmp(System.IntPtr tmpl, System.IntPtr name_used, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_file_read_link(System.IntPtr filename, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_file_set_contents(System.IntPtr filename, System.IntPtr contents, long length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_file_test(System.IntPtr filename, int test);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_filename_display_basename(System.IntPtr filename);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_filename_display_name(System.IntPtr filename);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_filename_from_uri(string uri, string hostname, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_filename_from_utf8(string utf8string, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_filename_to_uri(System.IntPtr filename, string hostname, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_filename_to_utf8(System.IntPtr opsysstring, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_find_program_in_path(System.IntPtr program);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_format_size(ulong size);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_format_size_for_display(long size);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_format_size_full(ulong size, int flags);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_free(System.IntPtr mem);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_get_application_name();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_get_charset(string charset);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_get_codeset();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_current_dir();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_get_current_time(System.IntPtr result);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_environ();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_get_filename_charsets(string charsets);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_home_dir();
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_get_host_name();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_language_names();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_locale_variants(string locale);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_get_monotonic_time();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_get_num_processors();
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_get_prgname();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_real_name();
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_get_real_time();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_system_config_dirs();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_system_data_dirs();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_tmp_dir();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_user_cache_dir();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_user_config_dir();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_user_data_dir();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_user_name();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_user_runtime_dir();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_get_user_special_dir(int directory);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_getenv(string variable);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hostname_is_ascii_encoded(string hostname);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hostname_is_ip_address(string hostname);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hostname_is_non_ascii(string hostname);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_hostname_to_ascii(string hostname);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_hostname_to_unicode(string hostname);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_idle_add(System.IntPtr function, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_idle_add_full(int priority, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_idle_remove_by_data(System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_idle_source_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_int64_equal(System.IntPtr v1, System.IntPtr v2);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_int64_hash(System.IntPtr v);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_int_equal(System.IntPtr v1, System.IntPtr v2);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_int_hash(System.IntPtr v);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_intern_static_string(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_intern_string(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_io_add_watch(System.IntPtr channel, int condition, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_io_add_watch_full(System.IntPtr channel, int priority, int condition, System.IntPtr func, System.IntPtr user_data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_io_create_watch(System.IntPtr channel, int condition);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_listenv();
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_locale_from_utf8(string utf8string, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_locale_to_utf8(string opsysstring, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_log_default_handler(string log_domain, int log_level, string message, System.IntPtr unused_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_log_remove_handler(string log_domain, uint handler_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_log_set_always_fatal(int fatal_mask);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_log_set_default_handler(System.IntPtr log_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_log_set_fatal_mask(string log_domain, int fatal_mask);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_log_set_handler(string log_domain, int log_levels, System.IntPtr log_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_log_set_handler_full(string log_domain, int log_levels, System.IntPtr log_func, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_log_set_writer_func(System.IntPtr func, System.IntPtr user_data, System.IntPtr user_data_free);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_log_structured_array(int log_level, System.IntPtr fields, ulong n_fields);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_log_variant(string log_domain, int log_level, System.IntPtr fields);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_log_writer_default(int log_level, System.IntPtr fields, ulong n_fields, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_log_writer_format_fields(int log_level, System.IntPtr fields, ulong n_fields, int use_color);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_log_writer_is_journald(int output_fd);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_log_writer_journald(int log_level, System.IntPtr fields, ulong n_fields, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_log_writer_standard_streams(int log_level, System.IntPtr fields, ulong n_fields, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_log_writer_supports_color(int output_fd);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_current_source();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_depth();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_malloc(ulong n_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_malloc0(ulong n_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_malloc0_n(ulong n_blocks, ulong n_block_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_malloc_n(ulong n_blocks, ulong n_block_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_markup_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_markup_escape_text(string text, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_mem_is_system_malloc();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mem_profile();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mem_set_vtable(System.IntPtr vtable);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_memdup(System.IntPtr mem, uint byte_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_mkdir_with_parents(System.IntPtr pathname, int mode);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_mkdtemp(System.IntPtr tmpl);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_mkdtemp_full(System.IntPtr tmpl, int mode);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_mkstemp(System.IntPtr tmpl);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_mkstemp_full(System.IntPtr tmpl, int flags, int mode);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_nullify_pointer(System.IntPtr nullify_location);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_number_parser_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_on_error_query(string prg_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_on_error_stack_trace(string prg_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_option_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_parse_debug_string(string @string, System.IntPtr keys, uint nkeys);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_path_get_basename(System.IntPtr file_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_path_get_dirname(System.IntPtr file_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_path_is_absolute(System.IntPtr file_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_path_skip_root(System.IntPtr file_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_pattern_match(System.IntPtr pspec, uint string_length, string @string, string string_reversed);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_pattern_match_simple(string pattern, string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_pattern_match_string(System.IntPtr pspec, string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_pointer_bit_lock(System.IntPtr address, int lock_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_pointer_bit_trylock(System.IntPtr address, int lock_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_pointer_bit_unlock(System.IntPtr address, int lock_bit);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_poll(System.IntPtr fds, uint nfds, int timeout);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_propagate_error(System.IntPtr dest, System.IntPtr src);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_qsort_with_data(System.IntPtr pbase, int total_elems, ulong size, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_quark_from_static_string(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_quark_from_string(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_quark_to_string(uint quark);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_quark_try_string(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_random_double();
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_random_double_range(double begin, double end);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_random_int();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_random_int_range(int begin, int end);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_random_set_seed(uint seed);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_realloc(System.IntPtr mem, ulong n_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_realloc_n(System.IntPtr mem, ulong n_blocks, ulong n_block_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_reload_user_special_dirs_cache();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_return_if_fail_warning(string log_domain, string pretty_function, string expression);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_rmdir(System.IntPtr filename);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_set_application_name(string application_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_set_error_literal(System.IntPtr err, uint domain, int code, string message);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_set_prgname(string prgname);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_set_print_handler(System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_set_printerr_handler(System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_setenv(string variable, string value, int overwrite);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_shell_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_shell_parse_argv(string command_line, System.IntPtr argcp, System.IntPtr argvp, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_shell_quote(string unquoted_string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_shell_unquote(string quoted_string, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slice_alloc(ulong block_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slice_alloc0(ulong block_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slice_copy(ulong block_size, System.IntPtr mem_block);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_slice_free1(ulong block_size, System.IntPtr mem_block);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_slice_free_chain_with_offset(ulong block_size, System.IntPtr mem_chain, ulong next_offset);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_slice_get_config(int ckey);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slice_get_config_state(int ckey, long address, System.IntPtr n_values);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_slice_set_config(int ckey, long value);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_spaced_primes_closest(uint num);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_spawn_async(System.IntPtr working_directory, System.IntPtr argv, System.IntPtr envp, int flags, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr child_pid, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_spawn_async_with_pipes(System.IntPtr working_directory, System.IntPtr argv, System.IntPtr envp, int flags, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr child_pid, System.IntPtr standard_input, System.IntPtr standard_output, System.IntPtr standard_error, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_spawn_check_exit_status(int exit_status, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_spawn_close_pid(int pid);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_spawn_command_line_async(string command_line, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_spawn_command_line_sync(string command_line, System.IntPtr standard_output, System.IntPtr standard_error, System.IntPtr exit_status, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_spawn_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_spawn_exit_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_spawn_sync(System.IntPtr working_directory, System.IntPtr argv, System.IntPtr envp, int flags, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr standard_output, System.IntPtr standard_error, System.IntPtr exit_status, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_stpcpy(string dest, string src);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_str_equal(System.IntPtr v1, System.IntPtr v2);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_str_has_prefix(string str, string prefix);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_str_has_suffix(string str, string suffix);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_str_hash(System.IntPtr v);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_str_is_ascii(string str);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_str_match_string(string search_term, string potential_hit, int accept_alternates);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_str_to_ascii(string str, string from_locale);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_str_tokenize_and_fold(string @string, string translit_locale, System.IntPtr ascii_alternates);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strcanon(string @string, string valid_chars, sbyte substitutor);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_strcasecmp(string s1, string s2);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strchomp(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strchug(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_strcmp0(string str1, string str2);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strcompress(string source);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strdelimit(string @string, string delimiters, sbyte new_delimiter);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strdown(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strdup(string str);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_strdupv(string str_array);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strerror(int errnum);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strescape(string source, string exceptions);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_strfreev(string str_array);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_new(string init);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_new_len(string init, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_sized_new(ulong dfl_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strip_context(string msgid, string msgval);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strjoinv(string separator, string str_array);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_strlcat(string dest, string src, ulong dest_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_strlcpy(string dest, string src, ulong dest_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_strncasecmp(string s1, string s2, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strndup(string str, ulong n);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strnfill(ulong length, sbyte fill_char);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strreverse(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strrstr(string haystack, string needle);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strrstr_len(string haystack, long haystack_len, string needle);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strsignal(int signum);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_strsplit(string @string, string delimiter, int max_tokens);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_strsplit_set(string @string, string delimiters, int max_tokens);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strstr_len(string haystack, long haystack_len, string needle);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_strtod(string nptr, string endptr);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_strup(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_strv_contains(string strv, string str);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_strv_get_type();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_strv_length(string str_array);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_add_data_func(string testpath, System.IntPtr test_data, System.IntPtr test_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_add_data_func_full(string testpath, System.IntPtr test_data, System.IntPtr test_func, System.IntPtr data_free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_add_func(string testpath, System.IntPtr test_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_add_vtable(string testpath, ulong data_size, System.IntPtr test_data, System.IntPtr data_setup, System.IntPtr data_test, System.IntPtr data_teardown);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_assert_expected_messages_internal(string domain, string file, int line, string func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_bug(string bug_uri_snippet);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_bug_base(string uri_pattern);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_test_create_case(string test_name, ulong data_size, System.IntPtr test_data, System.IntPtr data_setup, System.IntPtr data_test, System.IntPtr data_teardown);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_test_create_suite(string suite_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_expect_message(string log_domain, int log_level, string pattern);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_fail();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_failed();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_test_get_dir(int file_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_test_get_root();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_incomplete(string msg);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_log_set_fatal_handler(System.IntPtr log_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_test_log_type_name(int log_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_queue_destroy(System.IntPtr destroy_func, System.IntPtr destroy_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_queue_free(System.IntPtr gfree_pointer);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_test_rand_double();
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_test_rand_double_range(double range_start, double range_end);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_rand_int();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_rand_int_range(int begin, int end);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_run();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_run_suite(System.IntPtr suite);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_set_nonfatal_assertions();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_skip(string msg);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_subprocess();
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_test_timer_elapsed();
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_test_timer_last();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_timer_start();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_trap_assertions(string domain, string file, int line, string func, ulong assertion_flags, string pattern);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_trap_fork(ulong usec_timeout, int test_trap_flags);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_trap_has_passed();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_test_trap_reached_timeout();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_trap_subprocess(string test_path, ulong usec_timeout, int test_flags);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_timeout_add(uint interval, System.IntPtr function, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_timeout_add_full(int priority, uint interval, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_timeout_add_seconds(uint interval, System.IntPtr function, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_timeout_add_seconds_full(int priority, uint interval, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_timeout_source_new(uint interval);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_timeout_source_new_seconds(uint interval);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_try_malloc(ulong n_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_try_malloc0(ulong n_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_try_malloc0_n(ulong n_blocks, ulong n_block_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_try_malloc_n(ulong n_blocks, ulong n_block_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_try_realloc(System.IntPtr mem, ulong n_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_try_realloc_n(System.IntPtr mem, ulong n_blocks, ulong n_block_bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ucs4_to_utf16(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_ucs4_to_utf8(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_break_type(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_combining_class(uint uc);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_compose(uint a, uint b, System.IntPtr ch);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_decompose(uint ch, System.IntPtr a, System.IntPtr b);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_digit_value(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_unichar_fully_decompose(uint ch, int compat, System.IntPtr result, ulong result_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_get_mirror_char(uint ch, System.IntPtr mirrored_ch);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_get_script(uint ch);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isalnum(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isalpha(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_iscntrl(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isdefined(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isdigit(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isgraph(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_islower(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_ismark(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isprint(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_ispunct(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isspace(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_istitle(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isupper(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_iswide(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_iswide_cjk(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_isxdigit(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_iszerowidth(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_to_utf8(uint c, string outbuf);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unichar_tolower(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unichar_totitle(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unichar_toupper(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_type(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_validate(uint ch);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unichar_xdigit_value(uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_unicode_canonical_decomposition(uint ch, System.IntPtr result_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_unicode_canonical_ordering(System.IntPtr @string, ulong len);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unicode_script_from_iso15924(uint iso15924);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unicode_script_to_iso15924(int script);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unix_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unix_fd_add(int fd, int condition, System.IntPtr function, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unix_fd_add_full(int priority, int fd, int condition, System.IntPtr function, System.IntPtr user_data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_source_new(int fd, int condition);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unix_open_pipe(System.IntPtr fds, int flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unix_set_fd_nonblocking(int fd, int nonblock, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unix_signal_add(int signum, System.IntPtr handler, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_unix_signal_add_full(int priority, int signum, System.IntPtr handler, System.IntPtr user_data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_unix_signal_source_new(int signum);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_unlink(System.IntPtr filename);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_unsetenv(string variable);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_uri_escape_string(string unescaped, string reserved_chars_allowed, int allow_utf8);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_uri_list_extract_uris(string uri_list);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_uri_parse_scheme(string uri);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_uri_unescape_segment(string escaped_string, string escaped_string_end, string illegal_characters);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_uri_unescape_string(string escaped_string, string illegal_characters);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_usleep(ulong microseconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_utf16_to_ucs4(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf16_to_utf8(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_casefold(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_utf8_collate(string str1, string str2);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_collate_key(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_collate_key_for_filename(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_find_next_char(string p, string end);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_find_prev_char(string str, string p);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_utf8_get_char(string p);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_utf8_get_char_validated(string p, long max_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_make_valid(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_normalize(string str, long len, int mode);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_offset_to_pointer(string str, long offset);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_utf8_pointer_to_offset(string str, string pos);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_prev_char(string p);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_strchr(string p, long len, uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_strdown(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_utf8_strlen(string p, long max);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_strncpy(string dest, string src, ulong n);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_strrchr(string p, long len, uint c);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_strreverse(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_strup(string str, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_utf8_substring(string str, long start_pos, long end_pos);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_utf8_to_ucs4(string str, long len, System.IntPtr items_read, System.IntPtr items_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_utf8_to_ucs4_fast(string str, long len, System.IntPtr items_written);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_utf8_to_utf16(string str, long len, System.IntPtr items_read, System.IntPtr items_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_utf8_validate(System.IntPtr str, long max_len, string end);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_uuid_string_is_valid(string str);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_uuid_string_random();
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_get_gtype();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_warn_message(string domain, string file, int line, string func, string warnexpr);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_append_vals(System.IntPtr array, System.IntPtr data, uint len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_array_free(System.IntPtr array, int free_segment);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_array_get_element_size(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_insert_vals(System.IntPtr array, uint index_, System.IntPtr data, uint len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_new(int zero_terminated, int clear_, uint element_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_prepend_vals(System.IntPtr array, System.IntPtr data, uint len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_ref(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_remove_index(System.IntPtr array, uint index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_remove_index_fast(System.IntPtr array, uint index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_remove_range(System.IntPtr array, uint index_, uint length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_array_set_clear_func(System.IntPtr array, System.IntPtr clear_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_set_size(System.IntPtr array, uint length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_array_sized_new(int zero_terminated, int clear_, uint element_size, uint reserved_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_array_sort(System.IntPtr array, System.IntPtr compare_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_array_sort_with_data(System.IntPtr array, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_array_unref(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_async_queue_length(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_async_queue_length_unlocked(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_lock(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_pop(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_pop_unlocked(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_push(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_push_front(System.IntPtr queue, System.IntPtr item);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_push_front_unlocked(System.IntPtr queue, System.IntPtr item);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_push_sorted(System.IntPtr queue, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_push_sorted_unlocked(System.IntPtr queue, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_push_unlocked(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_ref(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_ref_unlocked(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_async_queue_remove(System.IntPtr queue, System.IntPtr item);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_async_queue_remove_unlocked(System.IntPtr queue, System.IntPtr item);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_sort(System.IntPtr queue, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_sort_unlocked(System.IntPtr queue, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_timed_pop(System.IntPtr queue, System.IntPtr end_time);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_timed_pop_unlocked(System.IntPtr queue, System.IntPtr end_time);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_timeout_pop(System.IntPtr queue, ulong timeout);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_timeout_pop_unlocked(System.IntPtr queue, ulong timeout);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_try_pop(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_try_pop_unlocked(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_unlock(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_unref(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_async_queue_unref_and_unlock(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_async_queue_new_full(System.IntPtr item_free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_time_val_add(System.IntPtr time_, long microseconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_time_val_to_iso8601(System.IntPtr time_);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_time_val_from_iso8601(string iso_date, System.IntPtr time_);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_add_application(System.IntPtr bookmark, string uri, string name, string exec);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_add_group(System.IntPtr bookmark, string uri, string group);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_free(System.IntPtr bookmark);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_bookmark_file_get_added(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_get_app_info(System.IntPtr bookmark, string uri, string name, string exec, System.IntPtr count, System.IntPtr stamp, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bookmark_file_get_applications(System.IntPtr bookmark, string uri, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_bookmark_file_get_description(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bookmark_file_get_groups(System.IntPtr bookmark, string uri, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_get_icon(System.IntPtr bookmark, string uri, string href, string mime_type, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_get_is_private(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_bookmark_file_get_mime_type(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_bookmark_file_get_modified(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_get_size(System.IntPtr bookmark);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_bookmark_file_get_title(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bookmark_file_get_uris(System.IntPtr bookmark, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_bookmark_file_get_visited(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_has_application(System.IntPtr bookmark, string uri, string name, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_has_group(System.IntPtr bookmark, string uri, string group, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_has_item(System.IntPtr bookmark, string uri);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_load_from_data(System.IntPtr bookmark, string data, ulong length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_load_from_data_dirs(System.IntPtr bookmark, System.IntPtr file, System.IntPtr full_path, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_load_from_file(System.IntPtr bookmark, System.IntPtr filename, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_move_item(System.IntPtr bookmark, string old_uri, string new_uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_remove_application(System.IntPtr bookmark, string uri, string name, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_remove_group(System.IntPtr bookmark, string uri, string group, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_remove_item(System.IntPtr bookmark, string uri, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_added(System.IntPtr bookmark, string uri, long added);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_set_app_info(System.IntPtr bookmark, string uri, string name, string exec, int count, long stamp, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_description(System.IntPtr bookmark, string uri, string description);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_groups(System.IntPtr bookmark, string uri, string groups, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_icon(System.IntPtr bookmark, string uri, string href, string mime_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_is_private(System.IntPtr bookmark, string uri, int is_private);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_mime_type(System.IntPtr bookmark, string uri, string mime_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_modified(System.IntPtr bookmark, string uri, long modified);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_title(System.IntPtr bookmark, string uri, string title);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bookmark_file_set_visited(System.IntPtr bookmark, string uri, long visited);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_bookmark_file_to_data(System.IntPtr bookmark, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bookmark_file_to_file(System.IntPtr bookmark, System.IntPtr filename, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_bookmark_file_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bookmark_file_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_error_new_literal(uint domain, int code, string message);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_error_copy(System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_error_free(System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_error_matches(System.IntPtr error, uint domain, int code);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_append(System.IntPtr array, System.IntPtr data, uint len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_free(System.IntPtr array, int free_segment);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_free_to_bytes(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_new_take(System.IntPtr data, ulong len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_prepend(System.IntPtr array, System.IntPtr data, uint len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_ref(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_remove_index(System.IntPtr array, uint index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_remove_index_fast(System.IntPtr array, uint index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_remove_range(System.IntPtr array, uint index_, uint length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_set_size(System.IntPtr array, uint length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_byte_array_sized_new(uint reserved_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_byte_array_sort(System.IntPtr array, System.IntPtr compare_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_byte_array_sort_with_data(System.IntPtr array, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_byte_array_unref(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_new(System.IntPtr data, ulong size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_new_static(System.IntPtr data, ulong size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_new_take(System.IntPtr data, ulong size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_new_with_free_func(System.IntPtr data, ulong size, System.IntPtr free_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bytes_compare(System.IntPtr bytes1, System.IntPtr bytes2);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_bytes_equal(System.IntPtr bytes1, System.IntPtr bytes2);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_get_data(System.IntPtr bytes, System.IntPtr size);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_bytes_get_size(System.IntPtr bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_bytes_hash(System.IntPtr bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_new_from_bytes(System.IntPtr bytes, ulong offset, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_ref(System.IntPtr bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_bytes_unref(System.IntPtr bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_unref_to_array(System.IntPtr bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_bytes_unref_to_data(System.IntPtr bytes, System.IntPtr size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_checksum_new(int checksum_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_checksum_copy(System.IntPtr checksum);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_checksum_free(System.IntPtr checksum);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_checksum_get_digest(System.IntPtr checksum, System.IntPtr buffer, System.IntPtr digest_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_checksum_get_string(System.IntPtr checksum);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_checksum_reset(System.IntPtr checksum);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_checksum_update(System.IntPtr checksum, System.IntPtr data, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_checksum_type_get_length(int checksum_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_cond_broadcast(System.IntPtr cond);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_cond_clear(System.IntPtr cond);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_cond_init(System.IntPtr cond);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_cond_signal(System.IntPtr cond);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_cond_wait(System.IntPtr cond, System.IntPtr mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_cond_wait_until(System.IntPtr cond, System.IntPtr mutex, long end_time);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mutex_clear(System.IntPtr mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mutex_init(System.IntPtr mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mutex_lock(System.IntPtr mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_mutex_trylock(System.IntPtr mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mutex_unlock(System.IntPtr mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_new_dmy(byte day, int month, ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_new_julian(uint julian_day);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_add_days(System.IntPtr date, uint n_days);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_add_months(System.IntPtr date, uint n_months);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_add_years(System.IntPtr date, uint n_years);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_clamp(System.IntPtr date, System.IntPtr min_date, System.IntPtr max_date);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_clear(System.IntPtr date, uint n_dates);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_compare(System.IntPtr lhs, System.IntPtr rhs);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_days_between(System.IntPtr date1, System.IntPtr date2);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_free(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern byte g_date_get_day(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_date_get_day_of_year(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_date_get_iso8601_week_of_year(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_date_get_julian(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_date_get_monday_week_of_year(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_get_month(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_date_get_sunday_week_of_year(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_get_weekday(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern ushort g_date_get_year(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_is_first_of_month(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_is_last_of_month(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_order(System.IntPtr date1, System.IntPtr date2);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_day(System.IntPtr date, byte day);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_dmy(System.IntPtr date, byte day, int month, ushort y);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_julian(System.IntPtr date, uint julian_date);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_month(System.IntPtr date, int month);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_parse(System.IntPtr date, string str);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_time(System.IntPtr date, int time_);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_time_t(System.IntPtr date, long timet);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_time_val(System.IntPtr date, System.IntPtr timeval);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_set_year(System.IntPtr date, ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_subtract_days(System.IntPtr date, uint n_days);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_subtract_months(System.IntPtr date, uint n_months);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_subtract_years(System.IntPtr date, uint n_years);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_to_struct_tm(System.IntPtr date, System.IntPtr tm);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_valid(System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern byte g_date_get_days_in_month(int month, ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern byte g_date_get_monday_weeks_in_year(ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern byte g_date_get_sunday_weeks_in_year(ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_is_leap_year(ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_date_strftime(string s, ulong slen, string format, System.IntPtr date);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_valid_day(byte day);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_valid_dmy(byte day, int month, ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_valid_julian(uint julian_date);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_valid_month(int month);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_valid_weekday(int weekday);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_valid_year(ushort year);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new(System.IntPtr tz, int year, int month, int day, int hour, int minute, double seconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_from_timeval_local(System.IntPtr tv);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_from_timeval_utc(System.IntPtr tv);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_from_unix_local(long t);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_from_unix_utc(long t);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_local(int year, int month, int day, int hour, int minute, double seconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_now(System.IntPtr tz);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_now_local();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_now_utc();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_new_utc(int year, int month, int day, int hour, int minute, double seconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add(System.IntPtr datetime, long timespan);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_days(System.IntPtr datetime, int days);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_full(System.IntPtr datetime, int years, int months, int days, int hours, int minutes, double seconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_hours(System.IntPtr datetime, int hours);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_minutes(System.IntPtr datetime, int minutes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_months(System.IntPtr datetime, int months);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_seconds(System.IntPtr datetime, double seconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_weeks(System.IntPtr datetime, int weeks);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_add_years(System.IntPtr datetime, int years);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_date_time_difference(System.IntPtr end, System.IntPtr begin);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_date_time_format(System.IntPtr datetime, string format);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_day_of_month(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_day_of_week(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_day_of_year(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_hour(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_microsecond(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_minute(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_month(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_second(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_date_time_get_seconds(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_date_time_get_timezone_abbreviation(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_date_time_get_utc_offset(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_week_numbering_year(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_week_of_year(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_get_year(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_time_get_ymd(System.IntPtr datetime, System.IntPtr year, System.IntPtr month, System.IntPtr day);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_is_daylight_savings(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_ref(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_to_local(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_to_timeval(System.IntPtr datetime, System.IntPtr tv);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_to_timezone(System.IntPtr datetime, System.IntPtr tz);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_date_time_to_unix(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_date_time_to_utc(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_date_time_unref(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_compare(System.IntPtr dt1, System.IntPtr dt2);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_date_time_equal(System.IntPtr dt1, System.IntPtr dt2);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_date_time_hash(System.IntPtr datetime);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_time_zone_new(string identifier);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_time_zone_new_local();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_time_zone_new_utc();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_time_zone_adjust_time(System.IntPtr tz, int type, System.IntPtr time_);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_time_zone_find_interval(System.IntPtr tz, int type, long time_);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_time_zone_get_abbreviation(System.IntPtr tz, int interval);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_time_zone_get_offset(System.IntPtr tz, int interval);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_time_zone_is_dst(System.IntPtr tz, int interval);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_time_zone_ref(System.IntPtr tz);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_time_zone_unref(System.IntPtr tz);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_dir_close(System.IntPtr dir);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_dir_read_name(System.IntPtr dir);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_dir_rewind(System.IntPtr dir);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_dir_make_tmp(System.IntPtr tmpl, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_dir_open(string path, uint flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_add(System.IntPtr hash_table, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_contains(System.IntPtr hash_table, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_destroy(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_find(System.IntPtr hash_table, System.IntPtr predicate, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_foreach(System.IntPtr hash_table, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_hash_table_foreach_remove(System.IntPtr hash_table, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_hash_table_foreach_steal(System.IntPtr hash_table, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_get_keys(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_get_keys_as_array(System.IntPtr hash_table, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_get_values(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_insert(System.IntPtr hash_table, System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_lookup(System.IntPtr hash_table, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_lookup_extended(System.IntPtr hash_table, System.IntPtr lookup_key, System.IntPtr orig_key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_new(System.IntPtr hash_func, System.IntPtr key_equal_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_new_full(System.IntPtr hash_func, System.IntPtr key_equal_func, System.IntPtr key_destroy_func, System.IntPtr value_destroy_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_ref(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_remove(System.IntPtr hash_table, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_remove_all(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_replace(System.IntPtr hash_table, System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_hash_table_size(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_steal(System.IntPtr hash_table, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_steal_all(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_unref(System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hash_table_iter_get_hash_table(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_iter_init(System.IntPtr iter, System.IntPtr hash_table);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hash_table_iter_next(System.IntPtr iter, System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_iter_remove(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_iter_replace(System.IntPtr iter, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hash_table_iter_steal(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hmac_copy(System.IntPtr hmac);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hmac_get_digest(System.IntPtr hmac, System.IntPtr buffer, System.IntPtr digest_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_hmac_get_string(System.IntPtr hmac);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hmac_ref(System.IntPtr hmac);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hmac_unref(System.IntPtr hmac);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hmac_update(System.IntPtr hmac, System.IntPtr data, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hmac_new(int digest_type, System.IntPtr key, ulong key_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hook_compare_ids(System.IntPtr new_hook, System.IntPtr sibling);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_alloc(System.IntPtr hook_list);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_hook_destroy(System.IntPtr hook_list, ulong hook_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_destroy_link(System.IntPtr hook_list, System.IntPtr hook);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_find(System.IntPtr hook_list, int need_valids, System.IntPtr func, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_find_data(System.IntPtr hook_list, int need_valids, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_find_func(System.IntPtr hook_list, int need_valids, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_find_func_data(System.IntPtr hook_list, int need_valids, System.IntPtr func, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_first_valid(System.IntPtr hook_list, int may_be_in_call);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_free(System.IntPtr hook_list, System.IntPtr hook);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_get(System.IntPtr hook_list, ulong hook_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_insert_before(System.IntPtr hook_list, System.IntPtr sibling, System.IntPtr hook);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_insert_sorted(System.IntPtr hook_list, System.IntPtr hook, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_next_valid(System.IntPtr hook_list, System.IntPtr hook, int may_be_in_call);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_prepend(System.IntPtr hook_list, System.IntPtr hook);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_hook_ref(System.IntPtr hook_list, System.IntPtr hook);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_unref(System.IntPtr hook_list, System.IntPtr hook);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_list_clear(System.IntPtr hook_list);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_list_init(System.IntPtr hook_list, uint hook_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_list_invoke(System.IntPtr hook_list, int may_recurse);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_list_invoke_check(System.IntPtr hook_list, int may_recurse);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_list_marshal(System.IntPtr hook_list, int may_recurse, System.IntPtr marshaller, System.IntPtr marshal_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_hook_list_marshal_check(System.IntPtr hook_list, int may_recurse, System.IntPtr marshaller, System.IntPtr marshal_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_append(System.IntPtr @string, string val);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_append_c(System.IntPtr @string, sbyte c);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_append_len(System.IntPtr @string, string val, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_append_unichar(System.IntPtr @string, uint wc);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_append_uri_escaped(System.IntPtr @string, string unescaped, string reserved_chars_allowed, int allow_utf8);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_ascii_down(System.IntPtr @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_ascii_up(System.IntPtr @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_assign(System.IntPtr @string, string rval);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_down(System.IntPtr @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_string_equal(System.IntPtr v, System.IntPtr v2);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_erase(System.IntPtr @string, long pos, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_string_free(System.IntPtr @string, int free_segment);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_free_to_bytes(System.IntPtr @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_string_hash(System.IntPtr str);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_insert(System.IntPtr @string, long pos, string val);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_insert_c(System.IntPtr @string, long pos, sbyte c);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_insert_len(System.IntPtr @string, long pos, string val, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_insert_unichar(System.IntPtr @string, long pos, uint wc);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_overwrite(System.IntPtr @string, ulong pos, string val);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_overwrite_len(System.IntPtr @string, ulong pos, string val, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_prepend(System.IntPtr @string, string val);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_prepend_c(System.IntPtr @string, sbyte c);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_prepend_len(System.IntPtr @string, string val, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_prepend_unichar(System.IntPtr @string, uint wc);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_set_size(System.IntPtr @string, ulong len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_truncate(System.IntPtr @string, ulong len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_up(System.IntPtr @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_io_channel_new_file(System.IntPtr filename, string mode, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_io_channel_unix_new(int fd);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_io_channel_close(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_flush(System.IntPtr channel, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_get_buffer_condition(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_io_channel_get_buffer_size(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_get_buffered(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_get_close_on_unref(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_io_channel_get_encoding(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_get_flags(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_io_channel_get_line_term(System.IntPtr channel, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_io_channel_init(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_read(System.IntPtr channel, string buf, ulong count, System.IntPtr bytes_read);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_read_chars(System.IntPtr channel, System.IntPtr buf, ulong count, System.IntPtr bytes_read, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_read_line(System.IntPtr channel, string str_return, System.IntPtr length, System.IntPtr terminator_pos, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_read_line_string(System.IntPtr channel, System.IntPtr buffer, System.IntPtr terminator_pos, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_read_to_end(System.IntPtr channel, System.IntPtr str_return, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_read_unichar(System.IntPtr channel, System.IntPtr thechar, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_io_channel_ref(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_seek(System.IntPtr channel, long offset, int type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_seek_position(System.IntPtr channel, long offset, int type, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_io_channel_set_buffer_size(System.IntPtr channel, ulong size);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_io_channel_set_buffered(System.IntPtr channel, int buffered);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_io_channel_set_close_on_unref(System.IntPtr channel, int do_close);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_set_encoding(System.IntPtr channel, string encoding, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_set_flags(System.IntPtr channel, int flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_io_channel_set_line_term(System.IntPtr channel, string line_term, int length);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_shutdown(System.IntPtr channel, int flush, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_unix_get_fd(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_io_channel_unref(System.IntPtr channel);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_write(System.IntPtr channel, string buf, ulong count, System.IntPtr bytes_written);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_write_chars(System.IntPtr channel, System.IntPtr buf, long count, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_write_unichar(System.IntPtr channel, uint thechar, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_io_channel_error_from_errno(int en);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_io_channel_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_source_new(System.IntPtr source_funcs, uint struct_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_add_child_source(System.IntPtr source, System.IntPtr child_source);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_add_poll(System.IntPtr source, System.IntPtr fd);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_source_add_unix_fd(System.IntPtr source, int fd, int events);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_source_attach(System.IntPtr source, System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_destroy(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_source_get_can_recurse(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_source_get_context(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_get_current_time(System.IntPtr source, System.IntPtr timeval);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_source_get_id(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_source_get_name(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_source_get_priority(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_source_get_ready_time(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_source_get_time(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_source_is_destroyed(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_modify_unix_fd(System.IntPtr source, System.IntPtr tag, int new_events);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_source_query_unix_fd(System.IntPtr source, System.IntPtr tag);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_source_ref(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_remove_child_source(System.IntPtr source, System.IntPtr child_source);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_remove_poll(System.IntPtr source, System.IntPtr fd);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_remove_unix_fd(System.IntPtr source, System.IntPtr tag);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_callback(System.IntPtr source, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_callback_indirect(System.IntPtr source, System.IntPtr callback_data, System.IntPtr callback_funcs);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_can_recurse(System.IntPtr source, int can_recurse);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_funcs(System.IntPtr source, System.IntPtr funcs);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_name(System.IntPtr source, string name);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_priority(System.IntPtr source, int priority);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_ready_time(System.IntPtr source, long ready_time);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_unref(System.IntPtr source);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_source_remove(uint tag);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_source_remove_by_funcs_user_data(System.IntPtr funcs, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_source_remove_by_user_data(System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_source_set_name_by_id(uint tag, string name);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_free(System.IntPtr key_file);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_get_boolean(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_get_boolean_list(System.IntPtr key_file, string group_name, string key, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_key_file_get_comment(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_key_file_get_double(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_get_double_list(System.IntPtr key_file, string group_name, string key, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_get_groups(System.IntPtr key_file, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_key_file_get_int64(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_get_integer(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_get_integer_list(System.IntPtr key_file, string group_name, string key, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_get_keys(System.IntPtr key_file, string group_name, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_key_file_get_locale_string(System.IntPtr key_file, string group_name, string key, string locale, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_get_locale_string_list(System.IntPtr key_file, string group_name, string key, string locale, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_key_file_get_start_group(System.IntPtr key_file);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_key_file_get_string(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_get_string_list(System.IntPtr key_file, string group_name, string key, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_key_file_get_uint64(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_key_file_get_value(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_has_group(System.IntPtr key_file, string group_name);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_has_key(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_load_from_bytes(System.IntPtr key_file, System.IntPtr bytes, int flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_load_from_data(System.IntPtr key_file, string data, ulong length, int flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_load_from_data_dirs(System.IntPtr key_file, System.IntPtr file, System.IntPtr full_path, int flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_load_from_dirs(System.IntPtr key_file, System.IntPtr file, System.IntPtr search_dirs, System.IntPtr full_path, int flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_load_from_file(System.IntPtr key_file, System.IntPtr file, int flags, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_key_file_ref(System.IntPtr key_file);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_remove_comment(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_remove_group(System.IntPtr key_file, string group_name, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_remove_key(System.IntPtr key_file, string group_name, string key, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_save_to_file(System.IntPtr key_file, string filename, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_boolean(System.IntPtr key_file, string group_name, string key, int value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_boolean_list(System.IntPtr key_file, string group_name, string key, System.IntPtr list, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_key_file_set_comment(System.IntPtr key_file, string group_name, string key, string comment, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_double(System.IntPtr key_file, string group_name, string key, double value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_double_list(System.IntPtr key_file, string group_name, string key, System.IntPtr list, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_int64(System.IntPtr key_file, string group_name, string key, long value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_integer(System.IntPtr key_file, string group_name, string key, int value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_integer_list(System.IntPtr key_file, string group_name, string key, System.IntPtr list, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_list_separator(System.IntPtr key_file, sbyte separator);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_locale_string(System.IntPtr key_file, string group_name, string key, string locale, string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_locale_string_list(System.IntPtr key_file, string group_name, string key, string locale, System.IntPtr list, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_string(System.IntPtr key_file, string group_name, string key, string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_string_list(System.IntPtr key_file, string group_name, string key, System.IntPtr list, ulong length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_uint64(System.IntPtr key_file, string group_name, string key, ulong value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_set_value(System.IntPtr key_file, string group_name, string key, string value);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_key_file_to_data(System.IntPtr key_file, System.IntPtr length, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_key_file_unref(System.IntPtr key_file);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_key_file_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_alloc();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_append(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_concat(System.IntPtr list1, System.IntPtr list2);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_copy(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_copy_deep(System.IntPtr list, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_delete_link(System.IntPtr list, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_find(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_find_custom(System.IntPtr list, System.IntPtr data, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_first(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_list_foreach(System.IntPtr list, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_list_free(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_list_free_1(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_list_free_full(System.IntPtr list, System.IntPtr free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_list_index(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_insert(System.IntPtr list, System.IntPtr data, int position);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_insert_before(System.IntPtr list, System.IntPtr sibling, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_insert_sorted(System.IntPtr list, System.IntPtr data, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_insert_sorted_with_data(System.IntPtr list, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_last(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_list_length(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_nth(System.IntPtr list, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_nth_data(System.IntPtr list, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_nth_prev(System.IntPtr list, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_list_position(System.IntPtr list, System.IntPtr llink);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_prepend(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_remove(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_remove_all(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_remove_link(System.IntPtr list, System.IntPtr llink);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_reverse(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_sort(System.IntPtr list, System.IntPtr compare_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_list_sort_with_data(System.IntPtr list, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_acquire(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_add_poll(System.IntPtr context, System.IntPtr fd, int priority);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_check(System.IntPtr context, int max_priority, System.IntPtr fds, int n_fds);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_dispatch(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_find_source_by_funcs_user_data(System.IntPtr context, System.IntPtr funcs, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_find_source_by_id(System.IntPtr context, uint source_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_find_source_by_user_data(System.IntPtr context, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_get_poll_func(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_invoke(System.IntPtr context, System.IntPtr function, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_invoke_full(System.IntPtr context, int priority, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_is_owner(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_iteration(System.IntPtr context, int may_block);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_pending(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_pop_thread_default(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_prepare(System.IntPtr context, System.IntPtr priority);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_push_thread_default(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_query(System.IntPtr context, int max_priority, System.IntPtr timeout_, System.IntPtr fds, int n_fds);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_ref(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_release(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_remove_poll(System.IntPtr context, System.IntPtr fd);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_set_poll_func(System.IntPtr context, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_unref(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_context_wait(System.IntPtr context, System.IntPtr cond, System.IntPtr mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_context_wakeup(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_default();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_get_thread_default();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_context_ref_thread_default();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_loop_new(System.IntPtr context, int is_running);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_loop_get_context(System.IntPtr loop);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_main_loop_is_running(System.IntPtr loop);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_loop_quit(System.IntPtr loop);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_main_loop_ref(System.IntPtr loop);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_loop_run(System.IntPtr loop);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_main_loop_unref(System.IntPtr loop);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_mapped_file_new(System.IntPtr filename, int writable, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_mapped_file_new_from_fd(int fd, int writable, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mapped_file_free(System.IntPtr file);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_mapped_file_get_bytes(System.IntPtr file);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_mapped_file_get_contents(System.IntPtr file);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_mapped_file_get_length(System.IntPtr file);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_mapped_file_ref(System.IntPtr file);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_mapped_file_unref(System.IntPtr file);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_markup_parse_context_new(System.IntPtr parser, int flags, System.IntPtr user_data, System.IntPtr user_data_dnotify);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_markup_parse_context_end_parse(System.IntPtr context, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_markup_parse_context_free(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_markup_parse_context_get_element(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_markup_parse_context_get_element_stack(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_markup_parse_context_get_position(System.IntPtr context, System.IntPtr line_number, System.IntPtr char_number);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_markup_parse_context_get_user_data(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_markup_parse_context_parse(System.IntPtr context, string text, long text_len, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_markup_parse_context_pop(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_markup_parse_context_push(System.IntPtr context, System.IntPtr parser, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_markup_parse_context_ref(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_markup_parse_context_unref(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_match_info_expand_references(System.IntPtr match_info, string string_to_expand, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_match_info_fetch(System.IntPtr match_info, int match_num);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_match_info_fetch_all(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_match_info_fetch_named(System.IntPtr match_info, string name);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_match_info_fetch_named_pos(System.IntPtr match_info, string name, System.IntPtr start_pos, System.IntPtr end_pos);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_match_info_fetch_pos(System.IntPtr match_info, int match_num, System.IntPtr start_pos, System.IntPtr end_pos);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_match_info_free(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_match_info_get_match_count(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_match_info_get_regex(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_match_info_get_string(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_match_info_is_partial_match(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_match_info_matches(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_match_info_next(System.IntPtr match_info, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_match_info_ref(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_match_info_unref(System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_regex_new(string pattern, int compile_options, int match_options, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_get_capture_count(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_get_compile_flags(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_get_has_cr_or_lf(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_get_match_flags(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_get_max_backref(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_get_max_lookbehind(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_regex_get_pattern(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_get_string_number(System.IntPtr regex, string name);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_match(System.IntPtr regex, string @string, int match_options, System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_match_all(System.IntPtr regex, string @string, int match_options, System.IntPtr match_info);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_match_all_full(System.IntPtr regex, System.IntPtr @string, long string_len, int start_position, int match_options, System.IntPtr match_info, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_match_full(System.IntPtr regex, System.IntPtr @string, long string_len, int start_position, int match_options, System.IntPtr match_info, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_regex_ref(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_regex_replace(System.IntPtr regex, System.IntPtr @string, long string_len, int start_position, string replacement, int match_options, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_regex_replace_eval(System.IntPtr regex, System.IntPtr @string, long string_len, int start_position, int match_options, System.IntPtr eval, System.IntPtr user_data, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_regex_replace_literal(System.IntPtr regex, System.IntPtr @string, long string_len, int start_position, string replacement, int match_options, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_regex_split(System.IntPtr regex, string @string, int match_options);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_regex_split_full(System.IntPtr regex, System.IntPtr @string, long string_len, int start_position, int match_options, int max_tokens, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_regex_unref(System.IntPtr regex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_check_replacement(string replacement, System.IntPtr has_references, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_regex_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_regex_escape_nul(string @string, int length);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_regex_escape_string(System.IntPtr @string, int length);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_regex_match_simple(string pattern, string @string, int compile_options, int match_options);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_regex_split_simple(string pattern, string @string, int compile_options, int match_options);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_node_child_index(System.IntPtr node, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_node_child_position(System.IntPtr node, System.IntPtr child);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_node_children_foreach(System.IntPtr node, int flags, System.IntPtr func, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_copy(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_copy_deep(System.IntPtr node, System.IntPtr copy_func, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_node_depth(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_node_destroy(System.IntPtr root);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_find(System.IntPtr root, int order, int flags, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_find_child(System.IntPtr node, int flags, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_first_sibling(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_get_root(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_insert(System.IntPtr parent, int position, System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_insert_after(System.IntPtr parent, System.IntPtr sibling, System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_insert_before(System.IntPtr parent, System.IntPtr sibling, System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_node_is_ancestor(System.IntPtr node, System.IntPtr descendant);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_last_child(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_last_sibling(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_node_max_height(System.IntPtr root);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_node_n_children(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_node_n_nodes(System.IntPtr root, int flags);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_nth_child(System.IntPtr node, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_prepend(System.IntPtr parent, System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_node_reverse_children(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_node_traverse(System.IntPtr root, int order, int flags, int max_depth, System.IntPtr func, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_node_unlink(System.IntPtr node);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_node_new(System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_once_impl(System.IntPtr once, System.IntPtr func, System.IntPtr arg);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_once_init_enter(System.IntPtr location);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_once_init_leave(System.IntPtr location, ulong result);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_add_group(System.IntPtr context, System.IntPtr group);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_add_main_entries(System.IntPtr context, System.IntPtr entries, string translation_domain);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_free(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_option_context_get_description(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_option_context_get_help(System.IntPtr context, int main_help, System.IntPtr group);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_option_context_get_help_enabled(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_option_context_get_ignore_unknown_options(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_option_context_get_main_group(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_option_context_get_strict_posix(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_option_context_get_summary(System.IntPtr context);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_option_context_parse(System.IntPtr context, System.IntPtr argc, System.IntPtr argv, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_option_context_parse_strv(System.IntPtr context, System.IntPtr arguments, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_description(System.IntPtr context, string description);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_help_enabled(System.IntPtr context, int help_enabled);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_ignore_unknown_options(System.IntPtr context, int ignore_unknown);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_main_group(System.IntPtr context, System.IntPtr group);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_strict_posix(System.IntPtr context, int strict_posix);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_summary(System.IntPtr context, string summary);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_translate_func(System.IntPtr context, System.IntPtr func, System.IntPtr data, System.IntPtr destroy_notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_context_set_translation_domain(System.IntPtr context, string domain);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_option_context_new(string parameter_string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_option_group_new(string name, string description, string help_description, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_group_add_entries(System.IntPtr group, System.IntPtr entries);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_group_free(System.IntPtr group);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_option_group_ref(System.IntPtr group);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_group_set_error_hook(System.IntPtr group, System.IntPtr error_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_group_set_parse_hooks(System.IntPtr group, System.IntPtr pre_parse_func, System.IntPtr post_parse_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_group_set_translate_func(System.IntPtr group, System.IntPtr func, System.IntPtr data, System.IntPtr destroy_notify);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_group_set_translation_domain(System.IntPtr group, string domain);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_option_group_unref(System.IntPtr group);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_pattern_spec_equal(System.IntPtr pspec1, System.IntPtr pspec2);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_pattern_spec_free(System.IntPtr pspec);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_pattern_spec_new(string pattern);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_private_get(System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_private_replace(System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_private_set(System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_add(System.IntPtr array, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ptr_array_find(System.IntPtr haystack, System.IntPtr needle, System.IntPtr index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ptr_array_find_with_equal_func(System.IntPtr haystack, System.IntPtr needle, System.IntPtr equal_func, System.IntPtr index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_foreach(System.IntPtr array, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_free(System.IntPtr array, int free_seg);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_insert(System.IntPtr array, int index_, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_new_full(uint reserved_size, System.IntPtr element_free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_new_with_free_func(System.IntPtr element_free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_ref(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ptr_array_remove(System.IntPtr array, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_ptr_array_remove_fast(System.IntPtr array, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_remove_index(System.IntPtr array, uint index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_remove_index_fast(System.IntPtr array, uint index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_remove_range(System.IntPtr array, uint index_, uint length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_set_free_func(System.IntPtr array, System.IntPtr element_free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_set_size(System.IntPtr array, int length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_ptr_array_sized_new(uint reserved_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_sort(System.IntPtr array, System.IntPtr compare_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_sort_with_data(System.IntPtr array, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_ptr_array_unref(System.IntPtr array);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_clear(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_copy(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_delete_link(System.IntPtr queue, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_find(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_find_custom(System.IntPtr queue, System.IntPtr data, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_foreach(System.IntPtr queue, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_free(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_free_full(System.IntPtr queue, System.IntPtr free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_queue_get_length(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_queue_index(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_init(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_insert_after(System.IntPtr queue, System.IntPtr sibling, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_insert_before(System.IntPtr queue, System.IntPtr sibling, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_insert_sorted(System.IntPtr queue, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_queue_is_empty(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_queue_link_index(System.IntPtr queue, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_peek_head(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_peek_head_link(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_peek_nth(System.IntPtr queue, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_peek_nth_link(System.IntPtr queue, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_peek_tail(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_peek_tail_link(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_pop_head(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_pop_head_link(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_pop_nth(System.IntPtr queue, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_pop_nth_link(System.IntPtr queue, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_pop_tail(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_pop_tail_link(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_push_head(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_push_head_link(System.IntPtr queue, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_push_nth(System.IntPtr queue, System.IntPtr data, int n);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_push_nth_link(System.IntPtr queue, int n, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_push_tail(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_push_tail_link(System.IntPtr queue, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_queue_remove(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_queue_remove_all(System.IntPtr queue, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_reverse(System.IntPtr queue);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_sort(System.IntPtr queue, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_queue_unlink(System.IntPtr queue, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_queue_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rw_lock_clear(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rw_lock_init(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rw_lock_reader_lock(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_rw_lock_reader_trylock(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rw_lock_reader_unlock(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rw_lock_writer_lock(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_rw_lock_writer_trylock(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rw_lock_writer_unlock(System.IntPtr rw_lock);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_rand_copy(System.IntPtr rand_);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_rand_double(System.IntPtr rand_);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_rand_double_range(System.IntPtr rand_, double begin, double end);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rand_free(System.IntPtr rand_);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_rand_int(System.IntPtr rand_);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_rand_int_range(System.IntPtr rand_, int begin, int end);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rand_set_seed(System.IntPtr rand_, uint seed);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rand_set_seed_array(System.IntPtr rand_, System.IntPtr seed, uint seed_length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_rand_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_rand_new_with_seed(uint seed);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_rand_new_with_seed_array(System.IntPtr seed, uint seed_length);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rec_mutex_clear(System.IntPtr rec_mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rec_mutex_init(System.IntPtr rec_mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rec_mutex_lock(System.IntPtr rec_mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_rec_mutex_trylock(System.IntPtr rec_mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_rec_mutex_unlock(System.IntPtr rec_mutex);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_alloc();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_append(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_concat(System.IntPtr list1, System.IntPtr list2);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_copy(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_copy_deep(System.IntPtr list, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_delete_link(System.IntPtr list, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_find(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_find_custom(System.IntPtr list, System.IntPtr data, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_slist_foreach(System.IntPtr list, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_slist_free(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_slist_free_1(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_slist_free_full(System.IntPtr list, System.IntPtr free_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_slist_index(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_insert(System.IntPtr list, System.IntPtr data, int position);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_insert_before(System.IntPtr slist, System.IntPtr sibling, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_insert_sorted(System.IntPtr list, System.IntPtr data, System.IntPtr func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_insert_sorted_with_data(System.IntPtr list, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_last(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_slist_length(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_nth(System.IntPtr list, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_nth_data(System.IntPtr list, uint n);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_slist_position(System.IntPtr list, System.IntPtr llink);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_prepend(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_remove(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_remove_all(System.IntPtr list, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_remove_link(System.IntPtr list, System.IntPtr link_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_reverse(System.IntPtr list);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_sort(System.IntPtr list, System.IntPtr compare_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_slist_sort_with_data(System.IntPtr list, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_scanner_cur_line(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_scanner_cur_position(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_scanner_cur_token(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_destroy(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_scanner_eof(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_scanner_get_next_token(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_input_file(System.IntPtr scanner, int input_fd);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_input_text(System.IntPtr scanner, string text, uint text_len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_scanner_lookup_symbol(System.IntPtr scanner, string symbol);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_scanner_peek_next_token(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_scope_add_symbol(System.IntPtr scanner, uint scope_id, string symbol, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_scope_foreach_symbol(System.IntPtr scanner, uint scope_id, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_scanner_scope_lookup_symbol(System.IntPtr scanner, uint scope_id, string symbol);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_scope_remove_symbol(System.IntPtr scanner, uint scope_id, string symbol);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_scanner_set_scope(System.IntPtr scanner, uint scope_id);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_sync_file_offset(System.IntPtr scanner);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_scanner_unexp_token(System.IntPtr scanner, int expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_scanner_new(System.IntPtr config_templ);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_sequence_iter_compare(System.IntPtr a, System.IntPtr b);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_sequence_iter_get_position(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_iter_get_sequence(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_sequence_iter_is_begin(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_sequence_iter_is_end(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_iter_move(System.IntPtr iter, int delta);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_iter_next(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_iter_prev(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_append(System.IntPtr seq, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_foreach(System.IntPtr seq, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_free(System.IntPtr seq);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_get_begin_iter(System.IntPtr seq);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_get_end_iter(System.IntPtr seq);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_get_iter_at_pos(System.IntPtr seq, int pos);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_sequence_get_length(System.IntPtr seq);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_insert_sorted(System.IntPtr seq, System.IntPtr data, System.IntPtr cmp_func, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_insert_sorted_iter(System.IntPtr seq, System.IntPtr data, System.IntPtr iter_cmp, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_sequence_is_empty(System.IntPtr seq);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_lookup(System.IntPtr seq, System.IntPtr data, System.IntPtr cmp_func, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_lookup_iter(System.IntPtr seq, System.IntPtr data, System.IntPtr iter_cmp, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_prepend(System.IntPtr seq, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_search(System.IntPtr seq, System.IntPtr data, System.IntPtr cmp_func, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_search_iter(System.IntPtr seq, System.IntPtr data, System.IntPtr iter_cmp, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_sort(System.IntPtr seq, System.IntPtr cmp_func, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_sort_iter(System.IntPtr seq, System.IntPtr cmp_func, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_foreach_range(System.IntPtr begin, System.IntPtr end, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_get(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_insert_before(System.IntPtr iter, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_move(System.IntPtr src, System.IntPtr dest);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_move_range(System.IntPtr dest, System.IntPtr begin, System.IntPtr end);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_new(System.IntPtr data_destroy);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_sequence_range_get_midpoint(System.IntPtr begin, System.IntPtr end);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_remove(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_remove_range(System.IntPtr begin, System.IntPtr end);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_set(System.IntPtr iter, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_sort_changed(System.IntPtr iter, System.IntPtr cmp_func, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_sort_changed_iter(System.IntPtr iter, System.IntPtr iter_cmp, System.IntPtr cmp_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_sequence_swap(System.IntPtr a, System.IntPtr b);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_string_chunk_clear(System.IntPtr chunk);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_string_chunk_free(System.IntPtr chunk);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_string_chunk_insert(System.IntPtr chunk, string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_string_chunk_insert_const(System.IntPtr chunk, string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_string_chunk_insert_len(System.IntPtr chunk, string @string, long len);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_string_chunk_new(ulong size);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_log_buffer_free(System.IntPtr tbuffer);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_test_log_buffer_pop(System.IntPtr tbuffer);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_log_buffer_push(System.IntPtr tbuffer, uint n_bytes, System.IntPtr bytes);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_test_log_buffer_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_log_msg_free(System.IntPtr tmsg);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_suite_add(System.IntPtr suite, System.IntPtr test_case);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_test_suite_add_suite(System.IntPtr suite, System.IntPtr nestedsuite);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_thread_new(string name, System.IntPtr func, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_thread_try_new(string name, System.IntPtr func, System.IntPtr data, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_thread_join(System.IntPtr thread);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_thread_ref(System.IntPtr thread);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_unref(System.IntPtr thread);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_thread_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_exit(System.IntPtr retval);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_thread_self();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_yield();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_pool_free(System.IntPtr pool, int immediate, int wait_);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_thread_pool_get_max_threads(System.IntPtr pool);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_thread_pool_get_num_threads(System.IntPtr pool);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_thread_pool_move_to_front(System.IntPtr pool, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_thread_pool_push(System.IntPtr pool, System.IntPtr data, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_thread_pool_set_max_threads(System.IntPtr pool, int max_threads, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_pool_set_sort_function(System.IntPtr pool, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_thread_pool_unprocessed(System.IntPtr pool);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_thread_pool_get_max_idle_time();
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_thread_pool_get_max_unused_threads();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_thread_pool_get_num_unused_threads();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_thread_pool_new(System.IntPtr func, System.IntPtr user_data, int max_threads, int exclusive, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_pool_set_max_idle_time(uint interval);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_pool_set_max_unused_threads(int max_threads);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_thread_pool_stop_unused_threads();
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_timer_continue(System.IntPtr timer);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_timer_destroy(System.IntPtr timer);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_timer_elapsed(System.IntPtr timer, System.IntPtr microseconds);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_timer_reset(System.IntPtr timer);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_timer_start(System.IntPtr timer);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_timer_stop(System.IntPtr timer);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_timer_new();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_trash_stack_height(System.IntPtr stack_p);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_trash_stack_peek(System.IntPtr stack_p);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_trash_stack_pop(System.IntPtr stack_p);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_trash_stack_push(System.IntPtr stack_p, System.IntPtr data_p);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_tree_destroy(System.IntPtr tree);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_tree_foreach(System.IntPtr tree, System.IntPtr func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_tree_height(System.IntPtr tree);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_tree_insert(System.IntPtr tree, System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_tree_lookup(System.IntPtr tree, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_tree_lookup_extended(System.IntPtr tree, System.IntPtr lookup_key, System.IntPtr orig_key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_tree_nnodes(System.IntPtr tree);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_tree_ref(System.IntPtr tree);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_tree_remove(System.IntPtr tree, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_tree_replace(System.IntPtr tree, System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_tree_search(System.IntPtr tree, System.IntPtr search_func, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_tree_steal(System.IntPtr tree, System.IntPtr key);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_tree_traverse(System.IntPtr tree, System.IntPtr traverse_func, int traverse_type, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_tree_unref(System.IntPtr tree);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_tree_new(System.IntPtr key_compare_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_tree_new_full(System.IntPtr key_compare_func, System.IntPtr key_compare_data, System.IntPtr key_destroy_func, System.IntPtr value_destroy_func);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_tree_new_with_data(System.IntPtr key_compare_func, System.IntPtr key_compare_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_array(System.IntPtr child_type, System.IntPtr children, ulong n_children);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_boolean(int value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_byte(byte value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_bytestring(System.IntPtr @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_bytestring_array(System.IntPtr strv, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_dict_entry(System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_double(double value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_fixed_array(System.IntPtr element_type, System.IntPtr elements, ulong n_elements, ulong element_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_from_bytes(System.IntPtr type, System.IntPtr bytes, int trusted);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_from_data(System.IntPtr type, System.IntPtr data, ulong size, int trusted, System.IntPtr notify, System.IntPtr user_data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_handle(int value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_int16(short value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_int32(int value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_int64(long value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_maybe(System.IntPtr child_type, System.IntPtr child);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_object_path(string object_path);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_objv(System.IntPtr strv, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_parsed_va(string format, System.IntPtr app);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_signature(string signature);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_string(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_strv(System.IntPtr strv, long length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_take_string(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_tuple(System.IntPtr children, ulong n_children);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_uint16(ushort value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_uint32(uint value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_uint64(ulong value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_va(string format_string, string endptr, System.IntPtr app);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_new_variant(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_byteswap(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_check_format_string(System.IntPtr value, string format_string, int copy_only);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_classify(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_compare(System.IntPtr one, System.IntPtr two);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dup_bytestring(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dup_bytestring_array(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dup_objv(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_variant_dup_string(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dup_strv(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_equal(System.IntPtr one, System.IntPtr two);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_get_boolean(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern byte g_variant_get_byte(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_bytestring(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_bytestring_array(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_child_value(System.IntPtr value, ulong index_);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_data(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_data_as_bytes(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern double g_variant_get_double(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_fixed_array(System.IntPtr value, System.IntPtr n_elements, ulong element_size);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_get_handle(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern short g_variant_get_int16(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_get_int32(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern long g_variant_get_int64(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_maybe(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_normal_form(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_objv(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_get_size(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_variant_get_string(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_strv(System.IntPtr value, System.IntPtr length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_type(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_variant_get_type_string(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern ushort g_variant_get_uint16(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_variant_get_uint32(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_get_uint64(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_get_va(System.IntPtr value, string format_string, string endptr, System.IntPtr app);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_get_variant(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_variant_hash(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_is_container(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_is_floating(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_is_normal_form(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_is_of_type(System.IntPtr value, System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_iter_new(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_lookup_value(System.IntPtr dictionary, string key, System.IntPtr expected_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_n_children(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_variant_print(System.IntPtr value, int type_annotate);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_print_string(System.IntPtr value, System.IntPtr @string, int type_annotate);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_ref(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_ref_sink(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_store(System.IntPtr value, System.IntPtr data);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_take_ref(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_unref(System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_is_object_path(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_is_signature(string @string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_parse(System.IntPtr type, string text, string limit, string endptr, System.IntPtr error);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_variant_parse_error_print_context(System.IntPtr error, string source_str);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_variant_parse_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_variant_parser_get_error_quark();
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_new(string type_string);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_new_array(System.IntPtr element);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_new_dict_entry(System.IntPtr key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_new_maybe(System.IntPtr element);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_new_tuple(System.IntPtr items, int length);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_copy(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_variant_type_dup_string(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_element(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_equal(System.IntPtr type1, System.IntPtr type2);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_first(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_type_free(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_type_get_string_length(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern uint g_variant_type_hash(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_array(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_basic(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_container(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_definite(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_dict_entry(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_maybe(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_subtype_of(System.IntPtr type, System.IntPtr supertype);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_tuple(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_is_variant(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_key(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_type_n_items(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_next(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern string g_variant_type_peek_string(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_value(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_type_checked_(string arg0);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_string_is_valid(string type_string);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_type_string_scan(string @string, string limit, string endptr);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_iter_copy(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_iter_free(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_iter_init(System.IntPtr iter, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern ulong g_variant_iter_n_children(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_iter_next_value(System.IntPtr iter);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_builder_new(System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_builder_add_value(System.IntPtr builder, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_builder_clear(System.IntPtr builder);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_builder_close(System.IntPtr builder);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_builder_end(System.IntPtr builder);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_builder_init(System.IntPtr builder, System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_builder_open(System.IntPtr builder, System.IntPtr type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_builder_ref(System.IntPtr builder);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_builder_unref(System.IntPtr builder);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dict_new(System.IntPtr from_asv);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_dict_clear(System.IntPtr dict);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_dict_contains(System.IntPtr dict, string key);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dict_end(System.IntPtr dict);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_dict_init(System.IntPtr dict, System.IntPtr from_asv);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_dict_insert_value(System.IntPtr dict, string key, System.IntPtr value);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dict_lookup_value(System.IntPtr dict, string key, System.IntPtr expected_type);
        [DllImport("libglib-2.0.so.0")]
        public static extern System.IntPtr g_variant_dict_ref(System.IntPtr dict);
        [DllImport("libglib-2.0.so.0")]
        public static extern int g_variant_dict_remove(System.IntPtr dict, string key);
        [DllImport("libglib-2.0.so.0")]
        public static extern void g_variant_dict_unref(System.IntPtr dict);
    }
}