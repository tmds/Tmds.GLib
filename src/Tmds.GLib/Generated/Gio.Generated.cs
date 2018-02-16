using System;
using System.Runtime.InteropServices;

namespace Gio
{
    public static class GioInterop
    {
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_bus_get(int bus_type, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_bus_get_finish(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_bus_get_sync(int bus_type, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_own_name(int bus_type, string name, int flags, System.IntPtr bus_acquired_handler, System.IntPtr name_acquired_handler, System.IntPtr name_lost_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_own_name_on_connection(System.IntPtr connection, string name, int flags, System.IntPtr name_acquired_handler, System.IntPtr name_lost_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_own_name_on_connection_with_closures(System.IntPtr connection, string name, int flags, System.IntPtr name_acquired_closure, System.IntPtr name_lost_closure);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_own_name_with_closures(int bus_type, string name, int flags, System.IntPtr bus_acquired_closure, System.IntPtr name_acquired_closure, System.IntPtr name_lost_closure);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_bus_unown_name(uint owner_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_bus_unwatch_name(uint watcher_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_watch_name(int bus_type, string name, int flags, System.IntPtr name_appeared_handler, System.IntPtr name_vanished_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_watch_name_on_connection(System.IntPtr connection, string name, int flags, System.IntPtr name_appeared_handler, System.IntPtr name_vanished_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_watch_name_on_connection_with_closures(System.IntPtr connection, string name, int flags, System.IntPtr name_appeared_closure, System.IntPtr name_vanished_closure);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_bus_watch_name_with_closures(int bus_type, string name, int flags, System.IntPtr name_appeared_closure, System.IntPtr name_vanished_closure);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_content_type_can_be_executable(string type);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_content_type_equals(string type1, string type2);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_content_type_from_mime_type(string mime_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_content_type_get_description(string type);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_content_type_get_generic_icon_name(string type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_content_type_get_icon(string type);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_content_type_get_mime_type(string type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_content_type_get_symbolic_icon(string type);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_content_type_guess(string filename, System.IntPtr data, ulong data_size, System.IntPtr result_uncertain);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_content_type_guess_for_tree(System.IntPtr root);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_content_type_is_a(string type, string supertype);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_content_type_is_mime_type(string type, string mime_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_content_type_is_unknown(string type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_content_types_get_registered();
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_address_escape_value(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_address_get_for_bus_sync(int bus_type, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_address_get_stream(string address, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_address_get_stream_finish(System.IntPtr res, string out_guid, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_address_get_stream_sync(string address, string out_guid, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_generate_guid();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_gvalue_to_gvariant(System.IntPtr gvalue, System.IntPtr type);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_gvariant_to_gvalue(System.IntPtr value, System.IntPtr out_gvalue);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_is_address(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_is_guid(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_is_interface_name(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_is_member_name(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_is_name(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_is_supported_address(string @string, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_is_unique_name(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_error_from_errno(int err_no);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_io_error_quark();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_modules_load_all_in_directory(System.IntPtr dirname);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_modules_load_all_in_directory_with_scope(System.IntPtr dirname, System.IntPtr scope);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_modules_scan_all_in_directory(System.IntPtr dirname);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_modules_scan_all_in_directory_with_scope(System.IntPtr dirname, System.IntPtr scope);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_scheduler_cancel_all_jobs();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_scheduler_push_job(System.IntPtr job_func, System.IntPtr user_data, System.IntPtr notify, int io_priority, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_keyfile_settings_backend_new(string filename, string root_path, string root_group);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_settings_backend_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_networking_init();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_null_settings_backend_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_pollable_source_new(System.IntPtr pollable_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_pollable_source_new_full(System.IntPtr pollable_stream, System.IntPtr child_source, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_pollable_stream_read(System.IntPtr stream, System.IntPtr buffer, ulong count, int blocking, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_pollable_stream_write(System.IntPtr stream, System.IntPtr buffer, ulong count, int blocking, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_pollable_stream_write_all(System.IntPtr stream, System.IntPtr buffer, ulong count, int blocking, System.IntPtr bytes_written, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resources_enumerate_children(string path, int lookup_flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_resources_get_info(string path, int lookup_flags, System.IntPtr size, System.IntPtr flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resources_lookup_data(string path, int lookup_flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resources_open_stream(string path, int lookup_flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resources_register(System.IntPtr resource);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resources_unregister(System.IntPtr resource);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_report_gerror_in_idle(System.IntPtr @object, System.IntPtr callback, System.IntPtr user_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_report_take_gerror_in_idle(System.IntPtr @object, System.IntPtr callback, System.IntPtr user_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_is_mount_path_system_internal(System.IntPtr mount_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_at(System.IntPtr mount_path, System.IntPtr time_read);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_compare(System.IntPtr mount1, System.IntPtr mount2);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_copy(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_for(System.IntPtr file_path, System.IntPtr time_read);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_unix_mount_free(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_get_device_path(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_unix_mount_get_fs_type(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_get_mount_path(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_guess_can_eject(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_guess_icon(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_unix_mount_guess_name(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_guess_should_display(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_guess_symbolic_icon(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_is_readonly(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_is_system_internal(System.IntPtr mount_entry);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_points_changed_since(ulong time);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_points_get(System.IntPtr time_read);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mounts_changed_since(ulong time);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mounts_get(System.IntPtr time_read);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_action_name_is_valid(string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_action_parse_detailed_name(string detailed_name, string action_name, System.IntPtr target_value, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_action_print_detailed_name(string action_name, System.IntPtr target_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_activate(System.IntPtr action, System.IntPtr parameter);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_change_state(System.IntPtr action, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_action_get_enabled(System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_action_get_name(System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_get_parameter_type(System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_get_state(System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_get_state_hint(System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_get_state_type(System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_action_new(string name, System.IntPtr parameter_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_action_new_stateful(string name, System.IntPtr parameter_type, System.IntPtr state);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_action_set_enabled(System.IntPtr simple, int enabled);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_action_set_state(System.IntPtr simple, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_action_set_state_hint(System.IntPtr simple, System.IntPtr state_hint);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_group_action_added(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_group_action_enabled_changed(System.IntPtr action_group, string action_name, int enabled);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_group_action_removed(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_group_action_state_changed(System.IntPtr action_group, string action_name, System.IntPtr state);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_group_activate_action(System.IntPtr action_group, string action_name, System.IntPtr parameter);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_group_change_action_state(System.IntPtr action_group, string action_name, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_action_group_get_action_enabled(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_group_get_action_parameter_type(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_group_get_action_state(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_group_get_action_state_hint(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_group_get_action_state_type(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_action_group_has_action(System.IntPtr action_group, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_group_list_actions(System.IntPtr action_group);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_action_group_query_action(System.IntPtr action_group, string action_name, System.IntPtr enabled, System.IntPtr parameter_type, System.IntPtr state_type, System.IntPtr state_hint, System.IntPtr state);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_map_add_action(System.IntPtr action_map, System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_map_add_action_entries(System.IntPtr action_map, System.IntPtr entries, int n_entries, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_action_map_lookup_action(System.IntPtr action_map, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_action_map_remove_action(System.IntPtr action_map, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_create_from_commandline(string commandline, string application_name, int flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_all();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_all_for_type(string content_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_default_for_type(string content_type, int must_support_uris);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_default_for_uri_scheme(string uri_scheme);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_fallback_for_type(string content_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_recommended_for_type(string content_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_launch_default_for_uri(string uri, System.IntPtr launch_context, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_app_info_launch_default_for_uri_async(string uri, System.IntPtr launch_context, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_launch_default_for_uri_finish(System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_app_info_reset_type_associations(string content_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_add_supports_type(System.IntPtr appinfo, string content_type, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_can_delete(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_can_remove_supports_type(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_delete(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_dup(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_equal(System.IntPtr appinfo1, System.IntPtr appinfo2);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_commandline(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_app_info_get_description(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_app_info_get_display_name(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_executable(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_icon(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_app_info_get_id(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_app_info_get_name(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_get_supported_types(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_launch(System.IntPtr appinfo, System.IntPtr files, System.IntPtr launch_context, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_launch_uris(System.IntPtr appinfo, System.IntPtr uris, System.IntPtr launch_context, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_remove_supports_type(System.IntPtr appinfo, string content_type, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_set_as_default_for_extension(System.IntPtr appinfo, System.IntPtr extension, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_set_as_default_for_type(System.IntPtr appinfo, string content_type, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_set_as_last_used_for_type(System.IntPtr appinfo, string content_type, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_should_show(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_supports_files(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_app_info_supports_uris(System.IntPtr appinfo);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_launch_context_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_app_launch_context_get_display(System.IntPtr context, System.IntPtr info, System.IntPtr files);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_launch_context_get_environment(System.IntPtr context);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_app_launch_context_get_startup_notify_id(System.IntPtr context, System.IntPtr info, System.IntPtr files);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_app_launch_context_launch_failed(System.IntPtr context, string startup_notify_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_app_launch_context_setenv(System.IntPtr context, string variable, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_app_launch_context_unsetenv(System.IntPtr context, string variable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_cancellable_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_cancellable_get_current();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_cancellable_cancel(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_cancellable_connect(System.IntPtr cancellable, System.IntPtr callback, System.IntPtr data, System.IntPtr data_destroy_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_cancellable_disconnect(System.IntPtr cancellable, ulong handler_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_cancellable_get_fd(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_cancellable_is_cancelled(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_cancellable_make_pollfd(System.IntPtr cancellable, System.IntPtr pollfd);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_cancellable_pop_current(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_cancellable_push_current(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_cancellable_release_fd(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_cancellable_reset(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_cancellable_set_error_if_cancelled(System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_cancellable_source_new(System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_async_result_get_source_object(System.IntPtr res);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_async_result_get_user_data(System.IntPtr res);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_async_result_is_tagged(System.IntPtr res, System.IntPtr source_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_async_result_legacy_propagate_error(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_icon_deserialize(System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_icon_hash(System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_icon_new_for_string(string str, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_icon_equal(System.IntPtr icon1, System.IntPtr icon2);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_icon_serialize(System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_icon_to_string(System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_new_for_commandline_arg(string arg);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_new_for_commandline_arg_and_cwd(string arg, System.IntPtr cwd);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_new_for_path(System.IntPtr path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_new_for_uri(string uri);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_new_tmp(System.IntPtr tmpl, System.IntPtr iostream, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_parse_name(string parse_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_append_to(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_append_to_async(System.IntPtr file, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_append_to_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_copy(System.IntPtr source, System.IntPtr destination, int flags, System.IntPtr cancellable, System.IntPtr progress_callback, System.IntPtr progress_callback_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_copy_async(System.IntPtr source, System.IntPtr destination, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr progress_callback, System.IntPtr progress_callback_data, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_copy_attributes(System.IntPtr source, System.IntPtr destination, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_copy_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_create(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_create_async(System.IntPtr file, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_create_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_create_readwrite(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_create_readwrite_async(System.IntPtr file, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_create_readwrite_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_delete(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_delete_async(System.IntPtr file, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_delete_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_dup(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_eject_mountable(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_eject_mountable_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_eject_mountable_with_operation(System.IntPtr file, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_eject_mountable_with_operation_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_enumerate_children(System.IntPtr file, string attributes, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_enumerate_children_async(System.IntPtr file, string attributes, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_enumerate_children_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_equal(System.IntPtr file1, System.IntPtr file2);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_find_enclosing_mount(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_find_enclosing_mount_async(System.IntPtr file, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_find_enclosing_mount_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_get_basename(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_get_child(System.IntPtr file, System.IntPtr name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_get_child_for_display_name(System.IntPtr file, string display_name, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_get_parent(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_get_parse_name(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_get_path(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_get_relative_path(System.IntPtr parent, System.IntPtr descendant);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_get_uri(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_get_uri_scheme(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_has_parent(System.IntPtr file, System.IntPtr parent);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_has_prefix(System.IntPtr file, System.IntPtr prefix);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_has_uri_scheme(System.IntPtr file, string uri_scheme);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_file_hash(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_is_native(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_load_contents(System.IntPtr file, System.IntPtr cancellable, System.IntPtr contents, System.IntPtr length, string etag_out, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_load_contents_async(System.IntPtr file, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_load_contents_finish(System.IntPtr file, System.IntPtr res, System.IntPtr contents, System.IntPtr length, string etag_out, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_load_partial_contents_async(System.IntPtr file, System.IntPtr cancellable, System.IntPtr read_more_callback, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_load_partial_contents_finish(System.IntPtr file, System.IntPtr res, System.IntPtr contents, System.IntPtr length, string etag_out, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_make_directory(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_make_directory_async(System.IntPtr file, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_make_directory_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_make_directory_with_parents(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_make_symbolic_link(System.IntPtr file, System.IntPtr symlink_value, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_measure_disk_usage(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr progress_callback, System.IntPtr progress_data, System.IntPtr disk_usage, System.IntPtr num_dirs, System.IntPtr num_files, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_measure_disk_usage_async(System.IntPtr file, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr progress_callback, System.IntPtr progress_data, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_measure_disk_usage_finish(System.IntPtr file, System.IntPtr result, System.IntPtr disk_usage, System.IntPtr num_dirs, System.IntPtr num_files, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_monitor(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_monitor_directory(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_monitor_file(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_mount_enclosing_volume(System.IntPtr location, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_mount_enclosing_volume_finish(System.IntPtr location, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_mount_mountable(System.IntPtr file, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_mount_mountable_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_move(System.IntPtr source, System.IntPtr destination, int flags, System.IntPtr cancellable, System.IntPtr progress_callback, System.IntPtr progress_callback_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_open_readwrite(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_open_readwrite_async(System.IntPtr file, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_open_readwrite_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_poll_mountable(System.IntPtr file, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_poll_mountable_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_query_default_handler(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_query_exists(System.IntPtr file, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_query_file_type(System.IntPtr file, int flags, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_query_filesystem_info(System.IntPtr file, string attributes, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_query_filesystem_info_async(System.IntPtr file, string attributes, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_query_filesystem_info_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_query_info(System.IntPtr file, string attributes, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_query_info_async(System.IntPtr file, string attributes, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_query_info_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_query_settable_attributes(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_query_writable_namespaces(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_read(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_read_async(System.IntPtr file, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_read_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_replace(System.IntPtr file, string etag, int make_backup, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_replace_async(System.IntPtr file, string etag, int make_backup, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_replace_contents(System.IntPtr file, System.IntPtr contents, ulong length, string etag, int make_backup, int flags, string new_etag, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_replace_contents_async(System.IntPtr file, System.IntPtr contents, ulong length, string etag, int make_backup, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_replace_contents_bytes_async(System.IntPtr file, System.IntPtr contents, string etag, int make_backup, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_replace_contents_finish(System.IntPtr file, System.IntPtr res, string new_etag, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_replace_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_replace_readwrite(System.IntPtr file, string etag, int make_backup, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_replace_readwrite_async(System.IntPtr file, string etag, int make_backup, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_replace_readwrite_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_resolve_relative_path(System.IntPtr file, System.IntPtr relative_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attribute(System.IntPtr file, string attribute, int type, System.IntPtr value_p, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attribute_byte_string(System.IntPtr file, string attribute, string value, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attribute_int32(System.IntPtr file, string attribute, int value, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attribute_int64(System.IntPtr file, string attribute, long value, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attribute_string(System.IntPtr file, string attribute, string value, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attribute_uint32(System.IntPtr file, string attribute, uint value, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attribute_uint64(System.IntPtr file, string attribute, ulong value, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_set_attributes_async(System.IntPtr file, System.IntPtr info, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attributes_finish(System.IntPtr file, System.IntPtr result, System.IntPtr info, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_set_attributes_from_info(System.IntPtr file, System.IntPtr info, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_set_display_name(System.IntPtr file, string display_name, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_set_display_name_async(System.IntPtr file, string display_name, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_set_display_name_finish(System.IntPtr file, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_start_mountable(System.IntPtr file, int flags, System.IntPtr start_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_start_mountable_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_stop_mountable(System.IntPtr file, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_stop_mountable_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_supports_thread_contexts(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_trash(System.IntPtr file, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_trash_async(System.IntPtr file, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_trash_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_unmount_mountable(System.IntPtr file, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_unmount_mountable_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_unmount_mountable_with_operation(System.IntPtr file, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_unmount_mountable_with_operation_finish(System.IntPtr file, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_app_info_monitor_get();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_new(string application_id, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_id_is_valid(string application_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_activate(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_add_main_option(System.IntPtr application, string long_name, sbyte short_name, int flags, int arg, string description, string arg_description);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_add_main_option_entries(System.IntPtr application, System.IntPtr entries);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_add_option_group(System.IntPtr application, System.IntPtr group);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_bind_busy_property(System.IntPtr application, System.IntPtr @object, string property);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_application_get_application_id(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_get_dbus_connection(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_application_get_dbus_object_path(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_get_flags(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_application_get_inactivity_timeout(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_get_is_busy(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_get_is_registered(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_get_is_remote(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_application_get_resource_base_path(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_hold(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_mark_busy(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_open(System.IntPtr application, System.IntPtr files, int n_files, string hint);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_quit(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_register(System.IntPtr application, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_release(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_run(System.IntPtr application, int argc, System.IntPtr argv);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_send_notification(System.IntPtr application, string id, System.IntPtr notification);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_set_action_group(System.IntPtr application, System.IntPtr action_group);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_set_application_id(System.IntPtr application, string application_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_set_default(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_set_flags(System.IntPtr application, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_set_inactivity_timeout(System.IntPtr application, uint inactivity_timeout);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_set_resource_base_path(System.IntPtr application, string resource_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_unbind_busy_property(System.IntPtr application, System.IntPtr @object, string property);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_unmark_busy(System.IntPtr application);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_withdraw_notification(System.IntPtr application, string id);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_new_finish(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_new_for_address_finish(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_new_for_address_sync(string address, int flags, System.IntPtr observer, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_new_sync(System.IntPtr stream, string guid, int flags, System.IntPtr observer, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_new(System.IntPtr stream, string guid, int flags, System.IntPtr observer, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_new_for_address(string address, int flags, System.IntPtr observer, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_add_filter(System.IntPtr connection, System.IntPtr filter_function, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_call(System.IntPtr connection, string bus_name, string object_path, string interface_name, string method_name, System.IntPtr parameters, System.IntPtr reply_type, int flags, int timeout_msec, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_call_finish(System.IntPtr connection, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_call_sync(System.IntPtr connection, string bus_name, string object_path, string interface_name, string method_name, System.IntPtr parameters, System.IntPtr reply_type, int flags, int timeout_msec, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_call_with_unix_fd_list(System.IntPtr connection, string bus_name, string object_path, string interface_name, string method_name, System.IntPtr parameters, System.IntPtr reply_type, int flags, int timeout_msec, System.IntPtr fd_list, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_call_with_unix_fd_list_finish(System.IntPtr connection, System.IntPtr out_fd_list, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_call_with_unix_fd_list_sync(System.IntPtr connection, string bus_name, string object_path, string interface_name, string method_name, System.IntPtr parameters, System.IntPtr reply_type, int flags, int timeout_msec, System.IntPtr fd_list, System.IntPtr out_fd_list, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_close(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_close_finish(System.IntPtr connection, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_close_sync(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_emit_signal(System.IntPtr connection, string destination_bus_name, string object_path, string interface_name, string signal_name, System.IntPtr parameters, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_export_action_group(System.IntPtr connection, string object_path, System.IntPtr action_group, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_export_menu_model(System.IntPtr connection, string object_path, System.IntPtr menu, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_flush(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_flush_finish(System.IntPtr connection, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_flush_sync(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_get_capabilities(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_get_exit_on_close(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_connection_get_guid(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_get_last_serial(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_get_peer_credentials(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_get_stream(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_connection_get_unique_name(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_is_closed(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_register_object(System.IntPtr connection, string object_path, System.IntPtr interface_info, System.IntPtr vtable, System.IntPtr user_data, System.IntPtr user_data_free_func, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_register_object_with_closures(System.IntPtr connection, string object_path, System.IntPtr interface_info, System.IntPtr method_call_closure, System.IntPtr get_property_closure, System.IntPtr set_property_closure, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_register_subtree(System.IntPtr connection, string object_path, System.IntPtr vtable, int flags, System.IntPtr user_data, System.IntPtr user_data_free_func, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_remove_filter(System.IntPtr connection, uint filter_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_send_message(System.IntPtr connection, System.IntPtr message, int flags, System.IntPtr out_serial, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_send_message_with_reply(System.IntPtr connection, System.IntPtr message, int flags, int timeout_msec, System.IntPtr out_serial, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_send_message_with_reply_finish(System.IntPtr connection, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_connection_send_message_with_reply_sync(System.IntPtr connection, System.IntPtr message, int flags, int timeout_msec, System.IntPtr out_serial, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_set_exit_on_close(System.IntPtr connection, int exit_on_close);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_connection_signal_subscribe(System.IntPtr connection, string sender, string interface_name, string member, string object_path, string arg0, int flags, System.IntPtr callback, System.IntPtr user_data, System.IntPtr user_data_free_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_signal_unsubscribe(System.IntPtr connection, uint subscription_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_start_message_processing(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_unexport_action_group(System.IntPtr connection, uint export_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_connection_unexport_menu_model(System.IntPtr connection, uint export_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_unregister_object(System.IntPtr connection, uint registration_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_connection_unregister_subtree(System.IntPtr connection, uint registration_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_notification_new(string title);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_add_button(System.IntPtr notification, string label, string detailed_action);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_add_button_with_target_value(System.IntPtr notification, string label, string action, System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_set_body(System.IntPtr notification, string body);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_set_default_action(System.IntPtr notification, string detailed_action);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_set_default_action_and_target_value(System.IntPtr notification, string action, System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_set_icon(System.IntPtr notification, System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_set_priority(System.IntPtr notification, int priority);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_set_title(System.IntPtr notification, string title);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_notification_set_urgent(System.IntPtr notification, int urgent);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_command_line_create_file_for_arg(System.IntPtr cmdline, string arg);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_command_line_get_arguments(System.IntPtr cmdline, System.IntPtr argc);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_command_line_get_cwd(System.IntPtr cmdline);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_command_line_get_environ(System.IntPtr cmdline);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_command_line_get_exit_status(System.IntPtr cmdline);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_application_command_line_get_is_remote(System.IntPtr cmdline);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_command_line_get_options_dict(System.IntPtr cmdline);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_command_line_get_platform_data(System.IntPtr cmdline);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_application_command_line_get_stdin(System.IntPtr cmdline);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_application_command_line_getenv(System.IntPtr cmdline, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_application_command_line_set_exit_status(System.IntPtr cmdline, int exit_status);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_input_stream_clear_pending(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_input_stream_close(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_input_stream_close_async(System.IntPtr stream, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_input_stream_close_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_input_stream_has_pending(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_input_stream_is_closed(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_input_stream_read(System.IntPtr stream, System.IntPtr buffer, ulong count, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_input_stream_read_all(System.IntPtr stream, System.IntPtr buffer, ulong count, System.IntPtr bytes_read, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_input_stream_read_all_async(System.IntPtr stream, System.IntPtr buffer, ulong count, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_input_stream_read_all_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr bytes_read, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_input_stream_read_async(System.IntPtr stream, System.IntPtr buffer, ulong count, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_input_stream_read_bytes(System.IntPtr stream, ulong count, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_input_stream_read_bytes_async(System.IntPtr stream, ulong count, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_input_stream_read_bytes_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_input_stream_read_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_input_stream_set_pending(System.IntPtr stream, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_input_stream_skip(System.IntPtr stream, ulong count, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_input_stream_skip_async(System.IntPtr stream, ulong count, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_input_stream_skip_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_async_initable_newv_async(ulong object_type, uint n_parameters, System.IntPtr parameters, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_async_initable_init_async(System.IntPtr initable, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_async_initable_init_finish(System.IntPtr initable, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_async_initable_new_finish(System.IntPtr initable, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_seekable_can_seek(System.IntPtr seekable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_seekable_can_truncate(System.IntPtr seekable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_seekable_seek(System.IntPtr seekable, long offset, int type, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_seekable_tell(System.IntPtr seekable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_seekable_truncate(System.IntPtr seekable, long offset, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_buffered_input_stream_new(System.IntPtr base_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_buffered_input_stream_new_sized(System.IntPtr base_stream, ulong size);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_buffered_input_stream_fill(System.IntPtr stream, long count, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_buffered_input_stream_fill_async(System.IntPtr stream, long count, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_buffered_input_stream_fill_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_buffered_input_stream_get_available(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_buffered_input_stream_get_buffer_size(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_buffered_input_stream_peek(System.IntPtr stream, System.IntPtr buffer, ulong offset, ulong count);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_buffered_input_stream_peek_buffer(System.IntPtr stream, System.IntPtr count);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_buffered_input_stream_read_byte(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_buffered_input_stream_set_buffer_size(System.IntPtr stream, ulong size);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_filter_input_stream_get_base_stream(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_filter_input_stream_get_close_base_stream(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_filter_input_stream_set_close_base_stream(System.IntPtr stream, int close_base);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_output_stream_clear_pending(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_close(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_output_stream_close_async(System.IntPtr stream, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_close_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_flush(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_output_stream_flush_async(System.IntPtr stream, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_flush_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_has_pending(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_is_closed(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_is_closing(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_set_pending(System.IntPtr stream, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_output_stream_splice(System.IntPtr stream, System.IntPtr source, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_output_stream_splice_async(System.IntPtr stream, System.IntPtr source, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_output_stream_splice_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_output_stream_write(System.IntPtr stream, System.IntPtr buffer, ulong count, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_write_all(System.IntPtr stream, System.IntPtr buffer, ulong count, System.IntPtr bytes_written, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_output_stream_write_all_async(System.IntPtr stream, System.IntPtr buffer, ulong count, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_output_stream_write_all_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_output_stream_write_async(System.IntPtr stream, System.IntPtr buffer, ulong count, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_output_stream_write_bytes(System.IntPtr stream, System.IntPtr bytes, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_output_stream_write_bytes_async(System.IntPtr stream, System.IntPtr bytes, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_output_stream_write_bytes_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_output_stream_write_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_buffered_output_stream_new(System.IntPtr base_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_buffered_output_stream_new_sized(System.IntPtr base_stream, ulong size);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_buffered_output_stream_get_auto_grow(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_buffered_output_stream_get_buffer_size(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_buffered_output_stream_set_auto_grow(System.IntPtr stream, int auto_grow);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_buffered_output_stream_set_buffer_size(System.IntPtr stream, ulong size);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_filter_output_stream_get_base_stream(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_filter_output_stream_get_close_base_stream(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_filter_output_stream_set_close_base_stream(System.IntPtr stream, int close_base);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_loadable_icon_load(System.IntPtr icon, int size, string type, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_loadable_icon_load_async(System.IntPtr icon, int size, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_loadable_icon_load_finish(System.IntPtr icon, System.IntPtr res, string type, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_bytes_icon_new(System.IntPtr bytes);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_bytes_icon_get_bytes(System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_converter_convert(System.IntPtr converter, System.IntPtr inbuf, ulong inbuf_size, System.IntPtr outbuf, ulong outbuf_size, int flags, System.IntPtr bytes_read, System.IntPtr bytes_written, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_converter_reset(System.IntPtr converter);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_initable_newv(ulong object_type, uint n_parameters, System.IntPtr parameters, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_initable_init(System.IntPtr initable, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_charset_converter_new(string to_charset, string from_charset, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_charset_converter_get_num_fallbacks(System.IntPtr converter);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_charset_converter_get_use_fallback(System.IntPtr converter);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_charset_converter_set_use_fallback(System.IntPtr converter, int use_fallback);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_pollable_input_stream_can_poll(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_pollable_input_stream_create_source(System.IntPtr stream, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_pollable_input_stream_is_readable(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_pollable_input_stream_read_nonblocking(System.IntPtr stream, System.IntPtr buffer, ulong count, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_converter_input_stream_new(System.IntPtr base_stream, System.IntPtr converter);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_converter_input_stream_get_converter(System.IntPtr converter_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_pollable_output_stream_can_poll(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_pollable_output_stream_create_source(System.IntPtr stream, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_pollable_output_stream_is_writable(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_pollable_output_stream_write_nonblocking(System.IntPtr stream, System.IntPtr buffer, ulong count, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_converter_output_stream_new(System.IntPtr base_stream, System.IntPtr converter);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_converter_output_stream_get_converter(System.IntPtr converter_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_credentials_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_credentials_get_native(System.IntPtr credentials, int native_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_credentials_get_unix_pid(System.IntPtr credentials, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_credentials_get_unix_user(System.IntPtr credentials, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_credentials_is_same_user(System.IntPtr credentials, System.IntPtr other_credentials, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_credentials_set_native(System.IntPtr credentials, int native_type, System.IntPtr native);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_credentials_set_unix_user(System.IntPtr credentials, uint uid, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_credentials_to_string(System.IntPtr credentials);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_remote_action_group_activate_action_full(System.IntPtr remote, string action_name, System.IntPtr parameter, System.IntPtr platform_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_remote_action_group_change_action_state_full(System.IntPtr remote, string action_name, System.IntPtr value, System.IntPtr platform_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_action_group_get(System.IntPtr connection, string bus_name, string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_annotation_info_ref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_annotation_info_unref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_annotation_info_lookup(System.IntPtr annotations, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_arg_info_ref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_arg_info_unref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_auth_observer_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_auth_observer_allow_mechanism(System.IntPtr observer, string mechanism);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_auth_observer_authorize_authenticated_peer(System.IntPtr observer, System.IntPtr stream, System.IntPtr credentials);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_stream_splice_finish(System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_stream_clear_pending(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_stream_close(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_stream_close_async(System.IntPtr stream, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_stream_close_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_stream_get_input_stream(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_stream_get_output_stream(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_stream_has_pending(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_stream_is_closed(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_stream_set_pending(System.IntPtr stream, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_stream_splice_async(System.IntPtr stream1, System.IntPtr stream2, int flags, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_list_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_list_new_from_array(System.IntPtr fds, int n_fds);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_fd_list_append(System.IntPtr list, int fd, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_fd_list_get(System.IntPtr list, int index_, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_fd_list_get_length(System.IntPtr list);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_list_peek_fds(System.IntPtr list, System.IntPtr length);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_list_steal_fds(System.IntPtr list, System.IntPtr length);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_model_get_item_attribute_value(System.IntPtr model, int item_index, string attribute, System.IntPtr expected_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_model_get_item_link(System.IntPtr model, int item_index, string link);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_menu_model_get_n_items(System.IntPtr model);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_menu_model_is_mutable(System.IntPtr model);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_model_items_changed(System.IntPtr model, int position, int removed, int added);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_model_iterate_item_attributes(System.IntPtr model, int item_index);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_model_iterate_item_links(System.IntPtr model, int item_index);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_info_cache_build(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_info_cache_release(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_info_generate_xml(System.IntPtr info, uint indent, System.IntPtr string_builder);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_info_lookup_method(System.IntPtr info, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_info_lookup_property(System.IntPtr info, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_info_lookup_signal(System.IntPtr info, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_info_ref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_info_unref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_new_from_blob(System.IntPtr blob, ulong blob_len, int capabilities, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_new_method_call(string name, string path, string interface_, string method);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_new_signal(string path, string interface_, string signal);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_dbus_message_bytes_needed(System.IntPtr blob, ulong blob_len, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_copy(System.IntPtr message, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_arg0(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_get_body(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_message_get_byte_order(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_destination(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_error_name(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_message_get_flags(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_get_header(System.IntPtr message, int header_field);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_get_header_fields(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_interface(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_message_get_locked(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_member(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_message_get_message_type(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_message_get_num_unix_fds(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_path(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_message_get_reply_serial(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_sender(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_message_get_serial(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_get_signature(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_get_unix_fd_list(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_lock(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_new_method_error_literal(System.IntPtr method_call_message, string error_name, string error_message);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_new_method_reply(System.IntPtr method_call_message);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_message_print(System.IntPtr message, uint indent);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_body(System.IntPtr message, System.IntPtr body);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_byte_order(System.IntPtr message, int byte_order);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_destination(System.IntPtr message, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_error_name(System.IntPtr message, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_flags(System.IntPtr message, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_header(System.IntPtr message, int header_field, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_interface(System.IntPtr message, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_member(System.IntPtr message, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_message_type(System.IntPtr message, int type);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_num_unix_fds(System.IntPtr message, uint value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_path(System.IntPtr message, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_reply_serial(System.IntPtr message, uint value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_sender(System.IntPtr message, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_serial(System.IntPtr message, uint serial);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_signature(System.IntPtr message, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_message_set_unix_fd_list(System.IntPtr message, System.IntPtr fd_list);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_message_to_blob(System.IntPtr message, System.IntPtr out_size, int capabilities, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_message_to_gerror(System.IntPtr message, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_error_encode_gerror(System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_error_get_remote_error(System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_error_is_remote_error(System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_error_new_for_dbus_error(string dbus_error_name, string dbus_error_message);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_dbus_error_quark();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_error_register_error(uint error_domain, int error_code, string dbus_error_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_error_register_error_domain(string error_domain_quark_name, System.IntPtr quark_volatile, System.IntPtr entries, uint num_entries);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_error_strip_remote_error(System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_error_unregister_error(uint error_domain, int error_code, string dbus_error_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_get_interface(System.IntPtr @object, string interface_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_get_interfaces(System.IntPtr @object);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_object_get_object_path(System.IntPtr @object);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_dup_object(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_get_info(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_get_object(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_set_object(System.IntPtr interface_, System.IntPtr @object);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_method_info_ref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_method_info_unref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_signal_info_ref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_signal_info_unref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_property_info_ref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_property_info_unref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_method_invocation_get_connection(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_method_invocation_get_interface_name(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_method_invocation_get_message(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_method_invocation_get_method_info(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_method_invocation_get_method_name(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_method_invocation_get_object_path(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_method_invocation_get_parameters(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_method_invocation_get_property_info(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_method_invocation_get_sender(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_method_invocation_get_user_data(System.IntPtr invocation);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_method_invocation_return_dbus_error(System.IntPtr invocation, string error_name, string error_message);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_method_invocation_return_error_literal(System.IntPtr invocation, uint domain, int code, string message);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_method_invocation_return_gerror(System.IntPtr invocation, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_method_invocation_return_value(System.IntPtr invocation, System.IntPtr parameters);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_method_invocation_return_value_with_unix_fd_list(System.IntPtr invocation, System.IntPtr parameters, System.IntPtr fd_list);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_method_invocation_take_error(System.IntPtr invocation, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_interface_skeleton_export(System.IntPtr interface_, System.IntPtr connection, string object_path, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_skeleton_flush(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_skeleton_get_connection(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_skeleton_get_connections(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_interface_skeleton_get_flags(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_skeleton_get_info(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_interface_skeleton_get_object_path(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_skeleton_get_properties(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_interface_skeleton_get_vtable(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_interface_skeleton_has_connection(System.IntPtr interface_, System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_skeleton_set_flags(System.IntPtr interface_, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_skeleton_unexport(System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_interface_skeleton_unexport_from_connection(System.IntPtr interface_, System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_menu_model_get(System.IntPtr connection, string bus_name, string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_node_info_new_for_xml(string xml_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_node_info_generate_xml(System.IntPtr info, uint indent, System.IntPtr string_builder);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_node_info_lookup_interface(System.IntPtr info, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_node_info_ref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_node_info_unref(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_get_interface(System.IntPtr manager, string object_path, string interface_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_get_object(System.IntPtr manager, string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_object_manager_get_object_path(System.IntPtr manager);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_get_objects(System.IntPtr manager);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_client_new_finish(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_client_new_for_bus_finish(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_client_new_for_bus_sync(int bus_type, int flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_client_new_sync(System.IntPtr connection, int flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_manager_client_new(System.IntPtr connection, int flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_manager_client_new_for_bus(int bus_type, int flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_client_get_connection(System.IntPtr manager);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_object_manager_client_get_flags(System.IntPtr manager);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_object_manager_client_get_name(System.IntPtr manager);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_object_manager_client_get_name_owner(System.IntPtr manager);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_proxy_new(System.IntPtr connection, string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_proxy_get_connection(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_new_finish(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_new_for_bus_finish(System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_new_for_bus_sync(int bus_type, int flags, System.IntPtr info, string name, string object_path, string interface_name, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_new_sync(System.IntPtr connection, int flags, System.IntPtr info, string name, string object_path, string interface_name, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_proxy_new(System.IntPtr connection, int flags, System.IntPtr info, string name, string object_path, string interface_name, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_proxy_new_for_bus(int bus_type, int flags, System.IntPtr info, string name, string object_path, string interface_name, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_proxy_call(System.IntPtr proxy, string method_name, System.IntPtr parameters, int flags, int timeout_msec, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_call_finish(System.IntPtr proxy, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_call_sync(System.IntPtr proxy, string method_name, System.IntPtr parameters, int flags, int timeout_msec, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_proxy_call_with_unix_fd_list(System.IntPtr proxy, string method_name, System.IntPtr parameters, int flags, int timeout_msec, System.IntPtr fd_list, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_call_with_unix_fd_list_finish(System.IntPtr proxy, System.IntPtr out_fd_list, System.IntPtr res, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_call_with_unix_fd_list_sync(System.IntPtr proxy, string method_name, System.IntPtr parameters, int flags, int timeout_msec, System.IntPtr fd_list, System.IntPtr out_fd_list, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_get_cached_property(System.IntPtr proxy, string property_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_get_cached_property_names(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_get_connection(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_proxy_get_default_timeout(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_proxy_get_flags(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_proxy_get_interface_info(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_proxy_get_interface_name(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_proxy_get_name(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_proxy_get_name_owner(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_proxy_get_object_path(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_proxy_set_cached_property(System.IntPtr proxy, string property_name, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_proxy_set_default_timeout(System.IntPtr proxy, int timeout_msec);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_proxy_set_interface_info(System.IntPtr proxy, System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_server_new(string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_manager_server_export(System.IntPtr manager, System.IntPtr @object);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_manager_server_export_uniquely(System.IntPtr manager, System.IntPtr @object);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_manager_server_get_connection(System.IntPtr manager);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_object_manager_server_is_exported(System.IntPtr manager, System.IntPtr @object);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_manager_server_set_connection(System.IntPtr manager, System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_object_manager_server_unexport(System.IntPtr manager, string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_object_skeleton_new(string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_skeleton_add_interface(System.IntPtr @object, System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_skeleton_flush(System.IntPtr @object);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_skeleton_remove_interface(System.IntPtr @object, System.IntPtr interface_);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_skeleton_remove_interface_by_name(System.IntPtr @object, string interface_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_object_skeleton_set_object_path(System.IntPtr @object, string object_path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dbus_server_new_sync(string address, int flags, string guid, System.IntPtr observer, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_server_get_client_address(System.IntPtr server);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_server_get_flags(System.IntPtr server);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_dbus_server_get_guid(System.IntPtr server);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dbus_server_is_active(System.IntPtr server);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_server_start(System.IntPtr server);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dbus_server_stop(System.IntPtr server);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_data_input_stream_new(System.IntPtr base_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_input_stream_get_byte_order(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_input_stream_get_newline_type(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern byte g_data_input_stream_read_byte(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern short g_data_input_stream_read_int16(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_input_stream_read_int32(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_data_input_stream_read_int64(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_data_input_stream_read_line(System.IntPtr stream, System.IntPtr length, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_data_input_stream_read_line_async(System.IntPtr stream, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_data_input_stream_read_line_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr length, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_data_input_stream_read_line_finish_utf8(System.IntPtr stream, System.IntPtr result, System.IntPtr length, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_data_input_stream_read_line_utf8(System.IntPtr stream, System.IntPtr length, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_data_input_stream_read_uint16(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_data_input_stream_read_uint32(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_data_input_stream_read_uint64(System.IntPtr stream, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_data_input_stream_read_until(System.IntPtr stream, string stop_chars, System.IntPtr length, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_data_input_stream_read_until_async(System.IntPtr stream, string stop_chars, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_data_input_stream_read_until_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr length, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_data_input_stream_read_upto(System.IntPtr stream, string stop_chars, long stop_chars_len, System.IntPtr length, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_data_input_stream_read_upto_async(System.IntPtr stream, string stop_chars, long stop_chars_len, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_data_input_stream_read_upto_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr length, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_data_input_stream_set_byte_order(System.IntPtr stream, int order);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_data_input_stream_set_newline_type(System.IntPtr stream, int type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_data_output_stream_new(System.IntPtr base_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_get_byte_order(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_byte(System.IntPtr stream, byte data, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_int16(System.IntPtr stream, short data, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_int32(System.IntPtr stream, int data, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_int64(System.IntPtr stream, long data, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_string(System.IntPtr stream, string str, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_uint16(System.IntPtr stream, ushort data, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_uint32(System.IntPtr stream, uint data, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_data_output_stream_put_uint64(System.IntPtr stream, ulong data, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_data_output_stream_set_byte_order(System.IntPtr stream, int order);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_datagram_based_condition_check(System.IntPtr datagram_based, int condition);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_datagram_based_condition_wait(System.IntPtr datagram_based, int condition, long timeout, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_datagram_based_create_source(System.IntPtr datagram_based, int condition, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_datagram_based_receive_messages(System.IntPtr datagram_based, System.IntPtr messages, uint num_messages, int flags, long timeout, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_datagram_based_send_messages(System.IntPtr datagram_based, System.IntPtr messages, uint num_messages, int flags, long timeout, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_new(string desktop_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_new_from_filename(System.IntPtr filename);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_new_from_keyfile(System.IntPtr key_file);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_get_implementations(string @interface);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_search(string search_string);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_desktop_app_info_set_desktop_env(string desktop_env);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_desktop_app_info_get_action_name(System.IntPtr info, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_desktop_app_info_get_boolean(System.IntPtr info, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_desktop_app_info_get_categories(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_get_filename(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_desktop_app_info_get_generic_name(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_desktop_app_info_get_is_hidden(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_get_keywords(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_desktop_app_info_get_nodisplay(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_desktop_app_info_get_show_in(System.IntPtr info, string desktop_env);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_desktop_app_info_get_startup_wm_class(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_desktop_app_info_get_string(System.IntPtr info, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_desktop_app_info_has_key(System.IntPtr info, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_desktop_app_info_launch_action(System.IntPtr info, string action_name, System.IntPtr launch_context);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_desktop_app_info_launch_uris_as_manager(System.IntPtr appinfo, System.IntPtr uris, System.IntPtr launch_context, int spawn_flags, System.IntPtr user_setup, System.IntPtr user_setup_data, System.IntPtr pid_callback, System.IntPtr pid_callback_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_list_actions(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_desktop_app_info_lookup_get_default_for_uri_scheme(System.IntPtr lookup, string uri_scheme);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_can_eject(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_can_poll_for_media(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_can_start(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_can_start_degraded(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_can_stop(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_drive_eject(System.IntPtr drive, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_eject_finish(System.IntPtr drive, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_drive_eject_with_operation(System.IntPtr drive, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_eject_with_operation_finish(System.IntPtr drive, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_drive_enumerate_identifiers(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_drive_get_icon(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_drive_get_identifier(System.IntPtr drive, string kind);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_drive_get_name(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_drive_get_sort_key(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_get_start_stop_type(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_drive_get_symbolic_icon(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_drive_get_volumes(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_has_media(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_has_volumes(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_is_media_check_automatic(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_is_media_removable(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_is_removable(System.IntPtr drive);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_drive_poll_for_media(System.IntPtr drive, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_poll_for_media_finish(System.IntPtr drive, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_drive_start(System.IntPtr drive, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_start_finish(System.IntPtr drive, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_drive_stop(System.IntPtr drive, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_drive_stop_finish(System.IntPtr drive, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_operation_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_operation_get_anonymous(System.IntPtr op);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_operation_get_choice(System.IntPtr op);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_mount_operation_get_domain(System.IntPtr op);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_mount_operation_get_password(System.IntPtr op);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_operation_get_password_save(System.IntPtr op);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_mount_operation_get_username(System.IntPtr op);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_operation_reply(System.IntPtr op, int result);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_operation_set_anonymous(System.IntPtr op, int anonymous);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_operation_set_choice(System.IntPtr op, int choice);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_operation_set_domain(System.IntPtr op, string domain);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_operation_set_password(System.IntPtr op, string password);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_operation_set_password_save(System.IntPtr op, int save);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_operation_set_username(System.IntPtr op, string username);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_volume_can_eject(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_volume_can_mount(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_volume_eject(System.IntPtr volume, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_volume_eject_finish(System.IntPtr volume, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_volume_eject_with_operation(System.IntPtr volume, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_volume_eject_with_operation_finish(System.IntPtr volume, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_enumerate_identifiers(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_get_activation_root(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_get_drive(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_get_icon(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_volume_get_identifier(System.IntPtr volume, string kind);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_get_mount(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_volume_get_name(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_volume_get_sort_key(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_get_symbolic_icon(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_volume_get_uuid(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_volume_mount(System.IntPtr volume, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_volume_mount_finish(System.IntPtr volume, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_volume_should_automount(System.IntPtr volume);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_close(System.IntPtr conn, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_close_async(System.IntPtr conn, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_close_finish(System.IntPtr conn, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_emit_accept_certificate(System.IntPtr conn, System.IntPtr peer_cert, int errors);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_connection_get_certificate(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_connection_get_database(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_connection_get_interaction(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_connection_get_peer_certificate(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_get_peer_certificate_errors(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_get_rehandshake_mode(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_get_require_close_notify(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_handshake(System.IntPtr conn, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_handshake_async(System.IntPtr conn, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_handshake_finish(System.IntPtr conn, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_set_certificate(System.IntPtr conn, System.IntPtr certificate);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_set_database(System.IntPtr conn, System.IntPtr database);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_set_interaction(System.IntPtr conn, System.IntPtr interaction);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_set_rehandshake_mode(System.IntPtr conn, int mode);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_set_require_close_notify(System.IntPtr conn, int require_close_notify);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_shutdown(System.IntPtr conn, int shutdown_read, int shutdown_write, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_connection_shutdown_async(System.IntPtr conn, int shutdown_read, int shutdown_write, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_connection_shutdown_finish(System.IntPtr conn, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_client_connection_new(System.IntPtr base_socket, System.IntPtr server_identity, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_client_connection_get_accepted_cas(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_client_connection_get_server_identity(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_dtls_client_connection_get_validation_flags(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_client_connection_set_server_identity(System.IntPtr conn, System.IntPtr identity);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_dtls_client_connection_set_validation_flags(System.IntPtr conn, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_connectable_enumerate(System.IntPtr connectable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_connectable_proxy_enumerate(System.IntPtr connectable);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_socket_connectable_to_string(System.IntPtr connectable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_certificate_new_from_file(System.IntPtr file, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_certificate_new_from_files(System.IntPtr cert_file, System.IntPtr key_file, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_certificate_new_from_pem(string data, long length, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_certificate_list_new_from_file(System.IntPtr file, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_certificate_get_issuer(System.IntPtr cert);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_certificate_is_same(System.IntPtr cert_one, System.IntPtr cert_two);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_certificate_verify(System.IntPtr cert, System.IntPtr identity, System.IntPtr trusted_ca);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_tls_database_create_certificate_handle(System.IntPtr self, System.IntPtr certificate);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_database_lookup_certificate_for_handle(System.IntPtr self, string handle, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_database_lookup_certificate_for_handle_async(System.IntPtr self, string handle, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_database_lookup_certificate_for_handle_finish(System.IntPtr self, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_database_lookup_certificate_issuer(System.IntPtr self, System.IntPtr certificate, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_database_lookup_certificate_issuer_async(System.IntPtr self, System.IntPtr certificate, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_database_lookup_certificate_issuer_finish(System.IntPtr self, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_database_lookup_certificates_issued_by(System.IntPtr self, System.IntPtr issuer_raw_dn, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_database_lookup_certificates_issued_by_async(System.IntPtr self, System.IntPtr issuer_raw_dn, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_database_lookup_certificates_issued_by_finish(System.IntPtr self, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_database_verify_chain(System.IntPtr self, System.IntPtr chain, string purpose, System.IntPtr identity, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_database_verify_chain_async(System.IntPtr self, System.IntPtr chain, string purpose, System.IntPtr identity, System.IntPtr interaction, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_database_verify_chain_finish(System.IntPtr self, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_interaction_ask_password(System.IntPtr interaction, System.IntPtr password, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_interaction_ask_password_async(System.IntPtr interaction, System.IntPtr password, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_interaction_ask_password_finish(System.IntPtr interaction, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_interaction_invoke_ask_password(System.IntPtr interaction, System.IntPtr password, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_interaction_invoke_request_certificate(System.IntPtr interaction, System.IntPtr connection, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_interaction_request_certificate(System.IntPtr interaction, System.IntPtr connection, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_interaction_request_certificate_async(System.IntPtr interaction, System.IntPtr connection, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_interaction_request_certificate_finish(System.IntPtr interaction, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_dtls_server_connection_new(System.IntPtr base_socket, System.IntPtr certificate, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_emblem_new(System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_emblem_new_with_origin(System.IntPtr icon, int origin);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_emblem_get_icon(System.IntPtr emblem);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_emblem_get_origin(System.IntPtr emblem);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_emblemed_icon_new(System.IntPtr icon, System.IntPtr emblem);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_emblemed_icon_add_emblem(System.IntPtr emblemed, System.IntPtr emblem);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_emblemed_icon_clear_emblems(System.IntPtr emblemed);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_emblemed_icon_get_emblems(System.IntPtr emblemed);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_emblemed_icon_get_icon(System.IntPtr emblemed);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_io_stream_get_etag(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_io_stream_query_info(System.IntPtr stream, string attributes, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_io_stream_query_info_async(System.IntPtr stream, string attributes, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_io_stream_query_info_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_output_stream_get_etag(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_output_stream_query_info(System.IntPtr stream, string attributes, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_output_stream_query_info_async(System.IntPtr stream, string attributes, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_output_stream_query_info_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_enumerator_close(System.IntPtr enumerator, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_enumerator_close_async(System.IntPtr enumerator, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_enumerator_close_finish(System.IntPtr enumerator, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_enumerator_get_child(System.IntPtr enumerator, System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_enumerator_get_container(System.IntPtr enumerator);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_enumerator_has_pending(System.IntPtr enumerator);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_enumerator_is_closed(System.IntPtr enumerator);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_enumerator_iterate(System.IntPtr direnum, System.IntPtr out_info, System.IntPtr out_child, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_enumerator_next_file(System.IntPtr enumerator, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_enumerator_next_files_async(System.IntPtr enumerator, int num_files, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_enumerator_next_files_finish(System.IntPtr enumerator, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_enumerator_set_pending(System.IntPtr enumerator, int pending);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_can_eject(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_can_unmount(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_eject(System.IntPtr mount, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_eject_finish(System.IntPtr mount, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_eject_with_operation(System.IntPtr mount, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_eject_with_operation_finish(System.IntPtr mount, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_get_default_location(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_get_drive(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_get_icon(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_mount_get_name(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_get_root(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_mount_get_sort_key(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_get_symbolic_icon(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_mount_get_uuid(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_get_volume(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_guess_content_type(System.IntPtr mount, int force_rescan, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_guess_content_type_finish(System.IntPtr mount, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_mount_guess_content_type_sync(System.IntPtr mount, int force_rescan, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_is_shadowed(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_remount(System.IntPtr mount, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_remount_finish(System.IntPtr mount, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_shadow(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_unmount(System.IntPtr mount, int flags, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_unmount_finish(System.IntPtr mount, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_unmount_with_operation(System.IntPtr mount, int flags, System.IntPtr mount_operation, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_mount_unmount_with_operation_finish(System.IntPtr mount, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_mount_unshadow(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_monitor_cancel(System.IntPtr monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_monitor_emit_event(System.IntPtr monitor, System.IntPtr child, System.IntPtr other_file, int event_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_monitor_is_cancelled(System.IntPtr monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_monitor_set_rate_limit(System.IntPtr monitor, int limit_msecs);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_clear_status(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_copy_into(System.IntPtr src_info, System.IntPtr dest_info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_dup(System.IntPtr other);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_attribute_as_string(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_attribute_boolean(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_attribute_byte_string(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_attribute_data(System.IntPtr info, string attribute, System.IntPtr type, System.IntPtr value_pp, System.IntPtr status);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_attribute_int32(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_file_info_get_attribute_int64(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_get_attribute_object(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_attribute_status(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_attribute_string(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_get_attribute_stringv(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_attribute_type(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_file_info_get_attribute_uint32(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_file_info_get_attribute_uint64(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_content_type(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_get_deletion_date(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_display_name(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_edit_name(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_etag(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_file_type(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_get_icon(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_is_backup(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_is_hidden(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_is_symlink(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_get_modification_time(System.IntPtr info, System.IntPtr result);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_get_name(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_file_info_get_size(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_get_sort_order(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_get_symbolic_icon(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_info_get_symlink_target(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_has_attribute(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_has_namespace(System.IntPtr info, string name_space);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_info_list_attributes(System.IntPtr info, string name_space);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_remove_attribute(System.IntPtr info, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute(System.IntPtr info, string attribute, int type, System.IntPtr value_p);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_boolean(System.IntPtr info, string attribute, int attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_byte_string(System.IntPtr info, string attribute, string attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_int32(System.IntPtr info, string attribute, int attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_int64(System.IntPtr info, string attribute, long attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_mask(System.IntPtr info, System.IntPtr mask);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_object(System.IntPtr info, string attribute, System.IntPtr attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_info_set_attribute_status(System.IntPtr info, string attribute, int status);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_string(System.IntPtr info, string attribute, string attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_stringv(System.IntPtr info, string attribute, System.IntPtr attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_uint32(System.IntPtr info, string attribute, uint attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_attribute_uint64(System.IntPtr info, string attribute, ulong attr_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_content_type(System.IntPtr info, string content_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_display_name(System.IntPtr info, string display_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_edit_name(System.IntPtr info, string edit_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_file_type(System.IntPtr info, int type);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_icon(System.IntPtr info, System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_is_hidden(System.IntPtr info, int is_hidden);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_is_symlink(System.IntPtr info, int is_symlink);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_modification_time(System.IntPtr info, System.IntPtr mtime);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_name(System.IntPtr info, System.IntPtr name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_size(System.IntPtr info, long size);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_sort_order(System.IntPtr info, int sort_order);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_symbolic_icon(System.IntPtr info, System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_set_symlink_target(System.IntPtr info, string symlink_target);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_info_unset_attribute_mask(System.IntPtr info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_attribute_info_list_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_attribute_info_list_add(System.IntPtr list, string name, int type, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_attribute_info_list_dup(System.IntPtr list);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_attribute_info_list_lookup(System.IntPtr list, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_attribute_info_list_ref(System.IntPtr list);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_attribute_info_list_unref(System.IntPtr list);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_input_stream_query_info(System.IntPtr stream, string attributes, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_input_stream_query_info_async(System.IntPtr stream, string attributes, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_input_stream_query_info_finish(System.IntPtr stream, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_attribute_matcher_new(string attributes);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_attribute_matcher_enumerate_namespace(System.IntPtr matcher, string ns);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_attribute_matcher_enumerate_next(System.IntPtr matcher);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_attribute_matcher_matches(System.IntPtr matcher, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_attribute_matcher_matches_only(System.IntPtr matcher, string attribute);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_attribute_matcher_ref(System.IntPtr matcher);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_attribute_matcher_subtract(System.IntPtr matcher, System.IntPtr subtract);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_file_attribute_matcher_to_string(System.IntPtr matcher);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_file_attribute_matcher_unref(System.IntPtr matcher);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_file_descriptor_based_get_fd(System.IntPtr fd_based);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_icon_new(System.IntPtr file);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_file_icon_get_file(System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_filename_completer_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_filename_completer_get_completion_suffix(System.IntPtr completer, string initial_text);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_filename_completer_get_completions(System.IntPtr completer, string initial_text);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_filename_completer_set_dirs_only(System.IntPtr completer, int dirs_only);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_io_extension_get_name(System.IntPtr extension);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_extension_get_priority(System.IntPtr extension);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_io_extension_get_type(System.IntPtr extension);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_extension_ref_class(System.IntPtr extension);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_extension_point_get_extension_by_name(System.IntPtr extension_point, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_extension_point_get_extensions(System.IntPtr extension_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_io_extension_point_get_required_type(System.IntPtr extension_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_extension_point_set_required_type(System.IntPtr extension_point, ulong type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_extension_point_implement(string extension_point_name, ulong type, string extension_name, int priority);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_extension_point_lookup(string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_extension_point_register(string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_module_new(System.IntPtr filename);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_module_query();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_module_load(System.IntPtr module);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_module_unload(System.IntPtr module);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_module_scope_block(System.IntPtr scope, string basename);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_module_scope_free(System.IntPtr scope);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_io_module_scope_new(int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_io_scheduler_job_send_to_mainloop(System.IntPtr job, System.IntPtr func, System.IntPtr user_data, System.IntPtr notify);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_io_scheduler_job_send_to_mainloop_async(System.IntPtr job, System.IntPtr func, System.IntPtr user_data, System.IntPtr notify);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_new_any(int family);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_new_from_bytes(System.IntPtr bytes, int family);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_new_from_string(string @string);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_new_loopback(int family);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_equal(System.IntPtr address, System.IntPtr other_address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_family(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_any(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_link_local(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_loopback(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_mc_global(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_mc_link_local(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_mc_node_local(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_mc_org_local(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_mc_site_local(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_multicast(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_get_is_site_local(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_inet_address_get_native_size(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_to_bytes(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_inet_address_to_string(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_mask_new(System.IntPtr addr, uint length, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_mask_new_from_string(string mask_string, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_mask_equal(System.IntPtr mask, System.IntPtr mask2);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_address_mask_get_address(System.IntPtr mask);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_mask_get_family(System.IntPtr mask);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_inet_address_mask_get_length(System.IntPtr mask);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_inet_address_mask_matches(System.IntPtr mask, System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_inet_address_mask_to_string(System.IntPtr mask);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_address_new_from_native(System.IntPtr native, ulong len);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_address_get_family(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_address_get_native_size(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_address_to_native(System.IntPtr address, System.IntPtr dest, ulong destlen, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_socket_address_new(System.IntPtr address, ushort port);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_socket_address_new_from_string(string address, uint port);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_inet_socket_address_get_address(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_inet_socket_address_get_flowinfo(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_inet_socket_address_get_port(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_inet_socket_address_get_scope_id(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_control_message_deserialize(int level, int type, ulong size, System.IntPtr data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_control_message_get_level(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_control_message_get_msg_type(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_socket_control_message_get_size(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_control_message_serialize(System.IntPtr message, System.IntPtr data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_list_model_get_item(System.IntPtr list, uint position);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_list_model_get_item_type(System.IntPtr list);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_list_model_get_n_items(System.IntPtr list);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_list_model_get_object(System.IntPtr list, uint position);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_list_model_items_changed(System.IntPtr list, uint position, uint removed, uint added);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_list_store_new(ulong item_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_list_store_append(System.IntPtr store, System.IntPtr item);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_list_store_insert(System.IntPtr store, uint position, System.IntPtr item);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_list_store_insert_sorted(System.IntPtr store, System.IntPtr item, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_list_store_remove(System.IntPtr store, uint position);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_list_store_remove_all(System.IntPtr store);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_list_store_sort(System.IntPtr store, System.IntPtr compare_func, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_list_store_splice(System.IntPtr store, uint position, uint n_removals, System.IntPtr additions, uint n_additions);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_input_stream_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_input_stream_new_from_bytes(System.IntPtr bytes);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_input_stream_new_from_data(System.IntPtr data, long len, System.IntPtr destroy);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_memory_input_stream_add_bytes(System.IntPtr stream, System.IntPtr bytes);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_memory_input_stream_add_data(System.IntPtr stream, System.IntPtr data, long len, System.IntPtr destroy);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_output_stream_new(System.IntPtr data, ulong size, System.IntPtr realloc_function, System.IntPtr destroy_function);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_output_stream_new_resizable();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_output_stream_get_data(System.IntPtr ostream);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_memory_output_stream_get_data_size(System.IntPtr ostream);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_memory_output_stream_get_size(System.IntPtr ostream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_output_stream_steal_as_bytes(System.IntPtr ostream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_memory_output_stream_steal_data(System.IntPtr ostream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_append(System.IntPtr menu, string label, string detailed_action);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_append_item(System.IntPtr menu, System.IntPtr item);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_append_section(System.IntPtr menu, string label, System.IntPtr section);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_append_submenu(System.IntPtr menu, string label, System.IntPtr submenu);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_freeze(System.IntPtr menu);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_insert(System.IntPtr menu, int position, string label, string detailed_action);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_insert_item(System.IntPtr menu, int position, System.IntPtr item);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_insert_section(System.IntPtr menu, int position, string label, System.IntPtr section);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_insert_submenu(System.IntPtr menu, int position, string label, System.IntPtr submenu);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_prepend(System.IntPtr menu, string label, string detailed_action);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_prepend_item(System.IntPtr menu, System.IntPtr item);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_prepend_section(System.IntPtr menu, string label, System.IntPtr section);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_prepend_submenu(System.IntPtr menu, string label, System.IntPtr submenu);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_remove(System.IntPtr menu, int position);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_remove_all(System.IntPtr menu);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_item_new(string label, string detailed_action);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_item_new_from_model(System.IntPtr model, int item_index);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_item_new_section(string label, System.IntPtr section);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_item_new_submenu(string label, System.IntPtr submenu);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_item_get_attribute_value(System.IntPtr menu_item, string attribute, System.IntPtr expected_type);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_item_get_link(System.IntPtr menu_item, string link);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_action_and_target_value(System.IntPtr menu_item, string action, System.IntPtr target_value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_attribute_value(System.IntPtr menu_item, string attribute, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_detailed_action(System.IntPtr menu_item, string detailed_action);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_icon(System.IntPtr menu_item, System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_label(System.IntPtr menu_item, string label);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_link(System.IntPtr menu_item, string link, System.IntPtr model);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_section(System.IntPtr menu_item, System.IntPtr section);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_menu_item_set_submenu(System.IntPtr menu_item, System.IntPtr submenu);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_menu_attribute_iter_get_name(System.IntPtr iter);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_menu_attribute_iter_get_next(System.IntPtr iter, string out_name, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_attribute_iter_get_value(System.IntPtr iter);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_menu_attribute_iter_next(System.IntPtr iter);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_menu_link_iter_get_name(System.IntPtr iter);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_menu_link_iter_get_next(System.IntPtr iter, string out_link, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_menu_link_iter_get_value(System.IntPtr iter);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_menu_link_iter_next(System.IntPtr iter);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_monitor_adopt_orphan_mount(System.IntPtr mount);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_monitor_get();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_monitor_get_connected_drives(System.IntPtr volume_monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_monitor_get_mount_for_uuid(System.IntPtr volume_monitor, string uuid);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_monitor_get_mounts(System.IntPtr volume_monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_monitor_get_volume_for_uuid(System.IntPtr volume_monitor, string uuid);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_volume_monitor_get_volumes(System.IntPtr volume_monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_network_address_new(string hostname, ushort port);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_network_address_new_loopback(ushort port);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_network_address_parse(string host_and_port, ushort default_port, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_network_address_parse_uri(string uri, ushort default_port, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_network_address_get_hostname(System.IntPtr addr);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_network_address_get_port(System.IntPtr addr);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_network_address_get_scheme(System.IntPtr addr);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_network_monitor_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_network_monitor_can_reach(System.IntPtr monitor, System.IntPtr connectable, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_network_monitor_can_reach_async(System.IntPtr monitor, System.IntPtr connectable, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_network_monitor_can_reach_finish(System.IntPtr monitor, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_network_monitor_get_connectivity(System.IntPtr monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_network_monitor_get_network_available(System.IntPtr monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_network_monitor_get_network_metered(System.IntPtr monitor);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_network_service_new(string service, string protocol, string domain);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_network_service_get_domain(System.IntPtr srv);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_network_service_get_protocol(System.IntPtr srv);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_network_service_get_scheme(System.IntPtr srv);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_network_service_get_service(System.IntPtr srv);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_network_service_set_scheme(System.IntPtr srv, string scheme);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_permission_acquire(System.IntPtr permission, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_permission_acquire_async(System.IntPtr permission, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_permission_acquire_finish(System.IntPtr permission, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_permission_get_allowed(System.IntPtr permission);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_permission_get_can_acquire(System.IntPtr permission);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_permission_get_can_release(System.IntPtr permission);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_permission_impl_update(System.IntPtr permission, int allowed, int can_acquire, int can_release);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_permission_release(System.IntPtr permission, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_permission_release_async(System.IntPtr permission, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_permission_release_finish(System.IntPtr permission, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_property_action_new(string name, System.IntPtr @object, string property_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_proxy_get_default_for_protocol(string protocol);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_proxy_connect(System.IntPtr proxy, System.IntPtr connection, System.IntPtr proxy_address, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_proxy_connect_async(System.IntPtr proxy, System.IntPtr connection, System.IntPtr proxy_address, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_proxy_connect_finish(System.IntPtr proxy, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_proxy_supports_hostname(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_proxy_address_new(System.IntPtr inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_proxy_address_get_destination_hostname(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_proxy_address_get_destination_port(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_proxy_address_get_destination_protocol(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_proxy_address_get_password(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_proxy_address_get_protocol(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_proxy_address_get_uri(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_proxy_address_get_username(System.IntPtr proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_proxy_resolver_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_proxy_resolver_is_supported(System.IntPtr resolver);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_proxy_resolver_lookup(System.IntPtr resolver, string uri, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_proxy_resolver_lookup_async(System.IntPtr resolver, string uri, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_proxy_resolver_lookup_finish(System.IntPtr resolver, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_address_enumerator_next(System.IntPtr enumerator, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_address_enumerator_next_async(System.IntPtr enumerator, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_address_enumerator_next_finish(System.IntPtr enumerator, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resolver_free_addresses(System.IntPtr addresses);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resolver_free_targets(System.IntPtr targets);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resolver_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_resolver_lookup_by_address(System.IntPtr resolver, System.IntPtr address, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resolver_lookup_by_address_async(System.IntPtr resolver, System.IntPtr address, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_resolver_lookup_by_address_finish(System.IntPtr resolver, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resolver_lookup_by_name(System.IntPtr resolver, string hostname, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resolver_lookup_by_name_async(System.IntPtr resolver, string hostname, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resolver_lookup_by_name_finish(System.IntPtr resolver, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resolver_lookup_records(System.IntPtr resolver, string rrname, int record_type, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resolver_lookup_records_async(System.IntPtr resolver, string rrname, int record_type, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resolver_lookup_records_finish(System.IntPtr resolver, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resolver_lookup_service(System.IntPtr resolver, string service, string protocol, string domain, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resolver_lookup_service_async(System.IntPtr resolver, string service, string protocol, string domain, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resolver_lookup_service_finish(System.IntPtr resolver, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resolver_set_default(System.IntPtr resolver);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_srv_target_copy(System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_srv_target_free(System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_srv_target_get_hostname(System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_srv_target_get_port(System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_srv_target_get_priority(System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_srv_target_get_weight(System.IntPtr target);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_srv_target_list_sort(System.IntPtr targets);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_resolver_error_quark();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resource_new_from_data(System.IntPtr data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resource_enumerate_children(System.IntPtr resource, string path, int lookup_flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_resource_get_info(System.IntPtr resource, string path, int lookup_flags, System.IntPtr size, System.IntPtr flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resource_lookup_data(System.IntPtr resource, string path, int lookup_flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resource_open_stream(System.IntPtr resource, string path, int lookup_flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resource_ref(System.IntPtr resource);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_resource_unref(System.IntPtr resource);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_resource_load(System.IntPtr filename, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_resource_error_quark();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_new(string schema_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_new_full(System.IntPtr schema, System.IntPtr backend, string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_new_with_backend(string schema_id, System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_new_with_backend_and_path(string schema_id, System.IntPtr backend, string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_new_with_path(string schema_id, string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_list_relocatable_schemas();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_list_schemas();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_sync();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_unbind(System.IntPtr @object, string property);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_apply(System.IntPtr settings);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_bind(System.IntPtr settings, string key, System.IntPtr @object, string property, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_bind_with_mapping(System.IntPtr settings, string key, System.IntPtr @object, string property, int flags, System.IntPtr get_mapping, System.IntPtr set_mapping, System.IntPtr user_data, System.IntPtr destroy);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_bind_writable(System.IntPtr settings, string key, System.IntPtr @object, string property, int inverted);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_create_action(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_delay(System.IntPtr settings);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_get_boolean(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_get_child(System.IntPtr settings, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_get_default_value(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern double g_settings_get_double(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_get_enum(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_settings_get_flags(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_get_has_unapplied(System.IntPtr settings);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_get_int(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_settings_get_int64(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_get_mapped(System.IntPtr settings, string key, System.IntPtr mapping, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_get_range(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_settings_get_string(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_get_strv(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_settings_get_uint(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_settings_get_uint64(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_get_user_value(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_get_value(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_is_writable(System.IntPtr settings, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_list_children(System.IntPtr settings);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_list_keys(System.IntPtr settings);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_range_check(System.IntPtr settings, string key, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_reset(System.IntPtr settings, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_revert(System.IntPtr settings);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_boolean(System.IntPtr settings, string key, int value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_double(System.IntPtr settings, string key, double value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_enum(System.IntPtr settings, string key, int value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_flags(System.IntPtr settings, string key, uint value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_int(System.IntPtr settings, string key, int value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_int64(System.IntPtr settings, string key, long value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_string(System.IntPtr settings, string key, string value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_strv(System.IntPtr settings, string key, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_uint(System.IntPtr settings, string key, uint value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_uint64(System.IntPtr settings, string key, ulong value);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_set_value(System.IntPtr settings, string key, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_settings_schema_get_id(System.IntPtr schema);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_get_key(System.IntPtr schema, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_settings_schema_get_path(System.IntPtr schema);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_schema_has_key(System.IntPtr schema, string name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_list_children(System.IntPtr schema);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_list_keys(System.IntPtr schema);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_ref(System.IntPtr schema);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_schema_unref(System.IntPtr schema);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_backend_flatten_tree(System.IntPtr tree, string path, System.IntPtr keys, System.IntPtr values);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_backend_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_backend_changed(System.IntPtr backend, string key, System.IntPtr origin_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_backend_changed_tree(System.IntPtr backend, System.IntPtr tree, System.IntPtr origin_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_backend_keys_changed(System.IntPtr backend, string path, System.IntPtr items, System.IntPtr origin_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_backend_path_changed(System.IntPtr backend, string path, System.IntPtr origin_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_backend_path_writable_changed(System.IntPtr backend, string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_backend_writable_changed(System.IntPtr backend, string key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_key_get_default_value(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_settings_schema_key_get_description(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_settings_schema_key_get_name(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_key_get_range(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_settings_schema_key_get_summary(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_key_get_value_type(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_settings_schema_key_range_check(System.IntPtr key, System.IntPtr value);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_key_ref(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_schema_key_unref(System.IntPtr key);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_source_new_from_directory(System.IntPtr directory, System.IntPtr parent, int trusted, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_schema_source_list_schemas(System.IntPtr source, int recursive, System.IntPtr non_relocatable, System.IntPtr relocatable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_source_lookup(System.IntPtr source, string schema_id, int recursive);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_source_ref(System.IntPtr source);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_settings_schema_source_unref(System.IntPtr source);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_settings_schema_source_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_action_group_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_action_group_add_entries(System.IntPtr simple, System.IntPtr entries, int n_entries, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_action_group_insert(System.IntPtr simple, System.IntPtr action);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_action_group_lookup(System.IntPtr simple, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_action_group_remove(System.IntPtr simple, string action_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_async_result_new(System.IntPtr source_object, System.IntPtr callback, System.IntPtr user_data, System.IntPtr source_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_async_result_new_from_error(System.IntPtr source_object, System.IntPtr callback, System.IntPtr user_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_async_result_new_take_error(System.IntPtr source_object, System.IntPtr callback, System.IntPtr user_data, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_simple_async_result_is_valid(System.IntPtr result, System.IntPtr source, System.IntPtr source_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_complete(System.IntPtr simple);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_complete_in_idle(System.IntPtr simple);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_simple_async_result_get_op_res_gboolean(System.IntPtr simple);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_async_result_get_op_res_gpointer(System.IntPtr simple);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_simple_async_result_get_op_res_gssize(System.IntPtr simple);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_async_result_get_source_tag(System.IntPtr simple);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_simple_async_result_propagate_error(System.IntPtr simple, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_run_in_thread(System.IntPtr simple, System.IntPtr func, int io_priority, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_set_check_cancellable(System.IntPtr simple, System.IntPtr check_cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_set_from_error(System.IntPtr simple, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_set_handle_cancellation(System.IntPtr simple, int handle_cancellation);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_set_op_res_gboolean(System.IntPtr simple, int op_res);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_set_op_res_gpointer(System.IntPtr simple, System.IntPtr op_res, System.IntPtr destroy_op_res);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_set_op_res_gssize(System.IntPtr simple, long op_res);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_async_result_take_error(System.IntPtr simple, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_io_stream_new(System.IntPtr input_stream, System.IntPtr output_stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_permission_new(int allowed);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_simple_proxy_resolver_new(string default_proxy, string ignore_hosts);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_proxy_resolver_set_default_proxy(System.IntPtr resolver, string default_proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_proxy_resolver_set_ignore_hosts(System.IntPtr resolver, string ignore_hosts);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_simple_proxy_resolver_set_uri_proxy(System.IntPtr resolver, string uri_scheme, string proxy);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_new(int family, int type, int protocol, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_new_from_fd(int fd, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_accept(System.IntPtr socket, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_bind(System.IntPtr socket, System.IntPtr address, int allow_reuse, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_check_connect_result(System.IntPtr socket, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_close(System.IntPtr socket, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_condition_check(System.IntPtr socket, int condition);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_condition_timed_wait(System.IntPtr socket, int condition, long timeout, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_condition_wait(System.IntPtr socket, int condition, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_connect(System.IntPtr socket, System.IntPtr address, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_connection_factory_create_connection(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_create_source(System.IntPtr socket, int condition, System.IntPtr cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_get_available_bytes(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_blocking(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_broadcast(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_get_credentials(System.IntPtr socket, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_family(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_fd(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_keepalive(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_listen_backlog(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_get_local_address(System.IntPtr socket, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_multicast_loopback(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_socket_get_multicast_ttl(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_option(System.IntPtr socket, int level, int optname, System.IntPtr value, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_protocol(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_get_remote_address(System.IntPtr socket, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_get_socket_type(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_socket_get_timeout(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_socket_get_ttl(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_is_closed(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_is_connected(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_join_multicast_group(System.IntPtr socket, System.IntPtr group, int source_specific, string iface, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_leave_multicast_group(System.IntPtr socket, System.IntPtr group, int source_specific, string iface, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_listen(System.IntPtr socket, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_receive(System.IntPtr socket, System.IntPtr buffer, ulong size, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_receive_from(System.IntPtr socket, System.IntPtr address, System.IntPtr buffer, ulong size, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_receive_message(System.IntPtr socket, System.IntPtr address, System.IntPtr vectors, int num_vectors, System.IntPtr messages, System.IntPtr num_messages, System.IntPtr flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_receive_messages(System.IntPtr socket, System.IntPtr messages, uint num_messages, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_receive_with_blocking(System.IntPtr socket, System.IntPtr buffer, ulong size, int blocking, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_send(System.IntPtr socket, System.IntPtr buffer, ulong size, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_send_message(System.IntPtr socket, System.IntPtr address, System.IntPtr vectors, int num_vectors, System.IntPtr messages, int num_messages, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_send_messages(System.IntPtr socket, System.IntPtr messages, uint num_messages, int flags, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_send_to(System.IntPtr socket, System.IntPtr address, System.IntPtr buffer, ulong size, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_socket_send_with_blocking(System.IntPtr socket, System.IntPtr buffer, ulong size, int blocking, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_blocking(System.IntPtr socket, int blocking);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_broadcast(System.IntPtr socket, int broadcast);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_keepalive(System.IntPtr socket, int keepalive);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_listen_backlog(System.IntPtr socket, int backlog);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_multicast_loopback(System.IntPtr socket, int loopback);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_multicast_ttl(System.IntPtr socket, uint ttl);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_set_option(System.IntPtr socket, int level, int optname, int value, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_timeout(System.IntPtr socket, uint timeout);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_set_ttl(System.IntPtr socket, uint ttl);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_shutdown(System.IntPtr socket, int shutdown_read, int shutdown_write, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_speaks_ipv4(System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_socket_connection_factory_lookup_type(int family, int type, int protocol_id);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_connection_factory_register_type(ulong g_type, int family, int type, int protocol);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_connection_connect(System.IntPtr connection, System.IntPtr address, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_connection_connect_async(System.IntPtr connection, System.IntPtr address, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_connection_connect_finish(System.IntPtr connection, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_connection_get_local_address(System.IntPtr connection, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_connection_get_remote_address(System.IntPtr connection, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_connection_get_socket(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_connection_is_connected(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_add_application_proxy(System.IntPtr client, string protocol);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect(System.IntPtr client, System.IntPtr connectable, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_connect_async(System.IntPtr client, System.IntPtr connectable, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect_finish(System.IntPtr client, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect_to_host(System.IntPtr client, string host_and_port, ushort default_port, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_connect_to_host_async(System.IntPtr client, string host_and_port, ushort default_port, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect_to_host_finish(System.IntPtr client, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect_to_service(System.IntPtr client, string domain, string service, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_connect_to_service_async(System.IntPtr client, string domain, string service, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect_to_service_finish(System.IntPtr client, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect_to_uri(System.IntPtr client, string uri, ushort default_port, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_connect_to_uri_async(System.IntPtr client, string uri, ushort default_port, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_connect_to_uri_finish(System.IntPtr client, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_client_get_enable_proxy(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_client_get_family(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_get_local_address(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_client_get_protocol(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_client_get_proxy_resolver(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_client_get_socket_type(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_socket_client_get_timeout(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_client_get_tls(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_client_get_tls_validation_flags(System.IntPtr client);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_enable_proxy(System.IntPtr client, int enable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_family(System.IntPtr client, int family);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_local_address(System.IntPtr client, System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_protocol(System.IntPtr client, int protocol);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_proxy_resolver(System.IntPtr client, System.IntPtr proxy_resolver);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_socket_type(System.IntPtr client, int type);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_timeout(System.IntPtr client, uint timeout);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_tls(System.IntPtr client, int tls);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_client_set_tls_validation_flags(System.IntPtr client, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_listener_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_listener_accept(System.IntPtr listener, System.IntPtr source_object, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_listener_accept_async(System.IntPtr listener, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_listener_accept_finish(System.IntPtr listener, System.IntPtr result, System.IntPtr source_object, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_listener_accept_socket(System.IntPtr listener, System.IntPtr source_object, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_listener_accept_socket_async(System.IntPtr listener, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_listener_accept_socket_finish(System.IntPtr listener, System.IntPtr result, System.IntPtr source_object, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_listener_add_address(System.IntPtr listener, System.IntPtr address, int type, int protocol, System.IntPtr source_object, System.IntPtr effective_address, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern ushort g_socket_listener_add_any_inet_port(System.IntPtr listener, System.IntPtr source_object, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_listener_add_inet_port(System.IntPtr listener, ushort port, System.IntPtr source_object, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_listener_add_socket(System.IntPtr listener, System.IntPtr socket, System.IntPtr source_object, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_listener_close(System.IntPtr listener);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_listener_set_backlog(System.IntPtr listener, int listen_backlog);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_socket_service_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_socket_service_is_active(System.IntPtr service);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_service_start(System.IntPtr service);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_socket_service_stop(System.IntPtr service);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_static_resource_fini(System.IntPtr static_resource);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_static_resource_get_resource(System.IntPtr static_resource);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_static_resource_init(System.IntPtr static_resource);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_subprocess_newv(System.IntPtr argv, int flags, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_communicate(System.IntPtr subprocess, System.IntPtr stdin_buf, System.IntPtr cancellable, System.IntPtr stdout_buf, System.IntPtr stderr_buf, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_communicate_async(System.IntPtr subprocess, System.IntPtr stdin_buf, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_communicate_finish(System.IntPtr subprocess, System.IntPtr result, System.IntPtr stdout_buf, System.IntPtr stderr_buf, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_communicate_utf8(System.IntPtr subprocess, string stdin_buf, System.IntPtr cancellable, string stdout_buf, string stderr_buf, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_communicate_utf8_async(System.IntPtr subprocess, string stdin_buf, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_communicate_utf8_finish(System.IntPtr subprocess, System.IntPtr result, string stdout_buf, string stderr_buf, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_force_exit(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_get_exit_status(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_subprocess_get_identifier(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_get_if_exited(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_get_if_signaled(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_get_status(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_subprocess_get_stderr_pipe(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_subprocess_get_stdin_pipe(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_subprocess_get_stdout_pipe(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_get_successful(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_get_term_sig(System.IntPtr subprocess);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_send_signal(System.IntPtr subprocess, int signal_num);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_wait(System.IntPtr subprocess, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_wait_async(System.IntPtr subprocess, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_wait_check(System.IntPtr subprocess, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_wait_check_async(System.IntPtr subprocess, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_wait_check_finish(System.IntPtr subprocess, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_subprocess_wait_finish(System.IntPtr subprocess, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_subprocess_launcher_new(int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_subprocess_launcher_getenv(System.IntPtr self, string variable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_set_child_setup(System.IntPtr self, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr destroy_notify);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_set_cwd(System.IntPtr self, System.IntPtr cwd);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_set_environ(System.IntPtr self, System.IntPtr env);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_set_flags(System.IntPtr self, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_set_stderr_file_path(System.IntPtr self, System.IntPtr path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_set_stdin_file_path(System.IntPtr self, string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_set_stdout_file_path(System.IntPtr self, System.IntPtr path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_setenv(System.IntPtr self, string variable, string value, int overwrite);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_subprocess_launcher_spawnv(System.IntPtr self, System.IntPtr argv, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_take_fd(System.IntPtr self, int source_fd, int target_fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_take_stderr_fd(System.IntPtr self, int fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_take_stdin_fd(System.IntPtr self, int fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_take_stdout_fd(System.IntPtr self, int fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_subprocess_launcher_unsetenv(System.IntPtr self, string variable);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_task_new(System.IntPtr source_object, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr callback_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_is_valid(System.IntPtr result, System.IntPtr source_object);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_report_error(System.IntPtr source_object, System.IntPtr callback, System.IntPtr callback_data, System.IntPtr source_tag, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_attach_source(System.IntPtr task, System.IntPtr source, System.IntPtr callback);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_task_get_cancellable(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_get_check_cancellable(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_get_completed(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_task_get_context(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_get_priority(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_get_return_on_cancel(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_task_get_source_object(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_task_get_source_tag(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_task_get_task_data(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_had_error(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_propagate_boolean(System.IntPtr task, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern long g_task_propagate_int(System.IntPtr task, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_task_propagate_pointer(System.IntPtr task, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_return_boolean(System.IntPtr task, int result);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_return_error(System.IntPtr task, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_return_error_if_cancelled(System.IntPtr task);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_return_int(System.IntPtr task, long result);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_return_pointer(System.IntPtr task, System.IntPtr result, System.IntPtr result_destroy);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_run_in_thread(System.IntPtr task, System.IntPtr task_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_run_in_thread_sync(System.IntPtr task, System.IntPtr task_func);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_set_check_cancellable(System.IntPtr task, int check_cancellable);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_set_priority(System.IntPtr task, int priority);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_task_set_return_on_cancel(System.IntPtr task, int return_on_cancel);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_set_source_tag(System.IntPtr task, System.IntPtr source_tag);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_task_set_task_data(System.IntPtr task, System.IntPtr task_data, System.IntPtr task_data_destroy);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tcp_connection_get_graceful_disconnect(System.IntPtr connection);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tcp_connection_set_graceful_disconnect(System.IntPtr connection, int graceful_disconnect);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tcp_wrapper_connection_new(System.IntPtr base_io_stream, System.IntPtr socket);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tcp_wrapper_connection_get_base_io_stream(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_test_dbus_new(int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_test_dbus_unset();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_test_dbus_add_service_dir(System.IntPtr self, string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_test_dbus_down(System.IntPtr self);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_test_dbus_get_bus_address(System.IntPtr self);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_test_dbus_get_flags(System.IntPtr self);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_test_dbus_stop(System.IntPtr self);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_test_dbus_up(System.IntPtr self);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_themed_icon_new(string iconname);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_themed_icon_new_from_names(System.IntPtr iconnames, int len);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_themed_icon_new_with_default_fallbacks(string iconname);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_themed_icon_append_name(System.IntPtr icon, string iconname);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_themed_icon_get_names(System.IntPtr icon);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_themed_icon_prepend_name(System.IntPtr icon, string iconname);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_threaded_socket_service_new(int max_threads);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_backend_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_tls_backend_get_certificate_type(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_tls_backend_get_client_connection_type(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_backend_get_default_database(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_tls_backend_get_dtls_client_connection_type(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_tls_backend_get_dtls_server_connection_type(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_tls_backend_get_file_database_type(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_tls_backend_get_server_connection_type(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_backend_supports_dtls(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_backend_supports_tls(System.IntPtr backend);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_connection_emit_accept_certificate(System.IntPtr conn, System.IntPtr peer_cert, int errors);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_connection_get_certificate(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_connection_get_database(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_connection_get_interaction(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_connection_get_peer_certificate(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_connection_get_peer_certificate_errors(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_connection_get_rehandshake_mode(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_connection_get_require_close_notify(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_connection_get_use_system_certdb(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_connection_handshake(System.IntPtr conn, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_connection_handshake_async(System.IntPtr conn, int io_priority, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_connection_handshake_finish(System.IntPtr conn, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_connection_set_certificate(System.IntPtr conn, System.IntPtr certificate);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_connection_set_database(System.IntPtr conn, System.IntPtr database);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_connection_set_interaction(System.IntPtr conn, System.IntPtr interaction);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_connection_set_rehandshake_mode(System.IntPtr conn, int mode);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_connection_set_require_close_notify(System.IntPtr conn, int require_close_notify);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_connection_set_use_system_certdb(System.IntPtr conn, int use_system_certdb);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_client_connection_new(System.IntPtr base_io_stream, System.IntPtr server_identity, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_client_connection_copy_session_state(System.IntPtr conn, System.IntPtr source);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_client_connection_get_accepted_cas(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_client_connection_get_server_identity(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_client_connection_get_use_ssl3(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_client_connection_get_validation_flags(System.IntPtr conn);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_client_connection_set_server_identity(System.IntPtr conn, System.IntPtr identity);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_client_connection_set_use_ssl3(System.IntPtr conn, int use_ssl3);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_client_connection_set_validation_flags(System.IntPtr conn, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern uint g_tls_error_quark();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_file_database_new(System.IntPtr anchors, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_password_new(int flags, string description);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_tls_password_get_description(System.IntPtr password);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_tls_password_get_flags(System.IntPtr password);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_password_get_value(System.IntPtr password, System.IntPtr length);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_tls_password_get_warning(System.IntPtr password);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_password_set_description(System.IntPtr password, string description);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_password_set_flags(System.IntPtr password, int flags);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_password_set_value(System.IntPtr password, System.IntPtr value, long length);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_password_set_value_full(System.IntPtr password, System.IntPtr value, long length, System.IntPtr destroy);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_tls_password_set_warning(System.IntPtr password, string warning);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_tls_server_connection_new(System.IntPtr base_io_stream, System.IntPtr certificate, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_connection_receive_credentials(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_unix_connection_receive_credentials_async(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_connection_receive_credentials_finish(System.IntPtr connection, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_connection_receive_fd(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_connection_send_credentials(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_unix_connection_send_credentials_async(System.IntPtr connection, System.IntPtr cancellable, System.IntPtr callback, System.IntPtr user_data);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_connection_send_credentials_finish(System.IntPtr connection, System.IntPtr result, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_connection_send_fd(System.IntPtr connection, int fd, System.IntPtr cancellable, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_credentials_message_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_credentials_message_new_with_credentials(System.IntPtr credentials);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_credentials_message_is_supported();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_credentials_message_get_credentials(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_message_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_message_new_with_fd_list(System.IntPtr fd_list);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_fd_message_append_fd(System.IntPtr message, int fd, System.IntPtr error);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_message_get_fd_list(System.IntPtr message);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_fd_message_steal_fds(System.IntPtr message, System.IntPtr length);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_input_stream_new(int fd, int close_fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_input_stream_get_close_fd(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_input_stream_get_fd(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_unix_input_stream_set_close_fd(System.IntPtr stream, int close_fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_monitor_new();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_monitor_get();
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_unix_mount_monitor_set_rate_limit(System.IntPtr mount_monitor, int limit_msec);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_point_compare(System.IntPtr mount1, System.IntPtr mount2);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_point_copy(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_unix_mount_point_free(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_point_get_device_path(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_unix_mount_point_get_fs_type(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_point_get_mount_path(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_unix_mount_point_get_options(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_point_guess_can_eject(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_point_guess_icon(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_unix_mount_point_guess_name(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_mount_point_guess_symbolic_icon(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_point_is_loopback(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_point_is_readonly(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_mount_point_is_user_mountable(System.IntPtr mount_point);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_output_stream_new(int fd, int close_fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_output_stream_get_close_fd(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_output_stream_get_fd(System.IntPtr stream);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_unix_output_stream_set_close_fd(System.IntPtr stream, int close_fd);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_socket_address_new(string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_socket_address_new_abstract(System.IntPtr path, int path_len);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_unix_socket_address_new_with_type(System.IntPtr path, int path_len, int type);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_socket_address_abstract_names_supported();
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_socket_address_get_address_type(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_unix_socket_address_get_is_abstract(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern string g_unix_socket_address_get_path(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern ulong g_unix_socket_address_get_path_len(System.IntPtr address);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_vfs_get_default();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_vfs_get_local();
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_vfs_get_file_for_path(System.IntPtr vfs, string path);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_vfs_get_file_for_uri(System.IntPtr vfs, string uri);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_vfs_get_supported_uri_schemes(System.IntPtr vfs);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_vfs_is_active(System.IntPtr vfs);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_vfs_parse_name(System.IntPtr vfs, string parse_name);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_vfs_register_uri_scheme(System.IntPtr vfs, string scheme, System.IntPtr uri_func, System.IntPtr uri_data, System.IntPtr uri_destroy, System.IntPtr parse_name_func, System.IntPtr parse_name_data, System.IntPtr parse_name_destroy);
        [DllImport("libgio-2.0.so.0")]
        public static extern int g_vfs_unregister_uri_scheme(System.IntPtr vfs, string scheme);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_zlib_compressor_new(int format, int level);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_zlib_compressor_get_file_info(System.IntPtr compressor);
        [DllImport("libgio-2.0.so.0")]
        public static extern void g_zlib_compressor_set_file_info(System.IntPtr compressor, System.IntPtr file_info);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_zlib_decompressor_new(int format);
        [DllImport("libgio-2.0.so.0")]
        public static extern System.IntPtr g_zlib_decompressor_get_file_info(System.IntPtr decompressor);
    }
}