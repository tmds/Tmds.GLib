using System;
using System.Runtime.InteropServices;
namespace GObject {
	public static class GObjectInterop {
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_boxed_copy(ulong boxed_type, System.IntPtr src_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_boxed_free(ulong boxed_type, System.IntPtr boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_boxed_type_register_static(string name, System.IntPtr boxed_copy, System.IntPtr boxed_free);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_clear_object(System.IntPtr object_ptr);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_enum_complete_type_info(ulong g_enum_type, System.IntPtr info, System.IntPtr const_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_enum_get_value(System.IntPtr enum_class, int value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_enum_get_value_by_name(System.IntPtr enum_class, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_enum_get_value_by_nick(System.IntPtr enum_class, string nick);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_enum_register_static(string name, System.IntPtr const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_enum_to_string(ulong g_enum_type, int value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_flags_complete_type_info(ulong g_flags_type, System.IntPtr info, System.IntPtr const_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_flags_get_first_value(System.IntPtr flags_class, uint value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_flags_get_value_by_name(System.IntPtr flags_class, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_flags_get_value_by_nick(System.IntPtr flags_class, string nick);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_flags_register_static(string name, System.IntPtr const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_flags_to_string(ulong flags_type, uint value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_gtype_get_type();
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_boolean(string name, string nick, string blurb, int default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_boxed(string name, string nick, string blurb, ulong boxed_type, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_char(string name, string nick, string blurb, sbyte minimum, sbyte maximum, sbyte default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_double(string name, string nick, string blurb, double minimum, double maximum, double default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_enum(string name, string nick, string blurb, ulong enum_type, int default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_flags(string name, string nick, string blurb, ulong flags_type, uint default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_float(string name, string nick, string blurb, float minimum, float maximum, float default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_gtype(string name, string nick, string blurb, ulong is_a_type, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_int(string name, string nick, string blurb, int minimum, int maximum, int default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_int64(string name, string nick, string blurb, long minimum, long maximum, long default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_long(string name, string nick, string blurb, long minimum, long maximum, long default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_object(string name, string nick, string blurb, ulong object_type, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_override(string name, System.IntPtr overridden);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_param(string name, string nick, string blurb, ulong param_type, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pointer(string name, string nick, string blurb, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_string(string name, string nick, string blurb, string default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_uchar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_uint(string name, string nick, string blurb, uint minimum, uint maximum, uint default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_uint64(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_ulong(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_unichar(string name, string nick, string blurb, uint default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_value_array(string name, string nick, string blurb, System.IntPtr element_spec, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_variant(string name, string nick, string blurb, System.IntPtr type, System.IntPtr default_value, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_param_type_register_static(string name, System.IntPtr pspec_info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_param_value_convert(System.IntPtr pspec, System.IntPtr src_value, System.IntPtr dest_value, int strict_validation);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_param_value_defaults(System.IntPtr pspec, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_value_set_default(System.IntPtr pspec, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_param_value_validate(System.IntPtr pspec, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_param_values_cmp(System.IntPtr pspec, System.IntPtr value1, System.IntPtr value2);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_pointer_type_register_static(string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_signal_accumulator_first_wins(System.IntPtr ihint, System.IntPtr return_accu, System.IntPtr handler_return, System.IntPtr dummy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_signal_accumulator_true_handled(System.IntPtr ihint, System.IntPtr return_accu, System.IntPtr handler_return, System.IntPtr dummy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_add_emission_hook(uint signal_id, uint detail, System.IntPtr hook_func, System.IntPtr hook_data, System.IntPtr data_destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_chain_from_overridden(System.IntPtr instance_and_params, System.IntPtr return_value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_closure(System.IntPtr instance, string detailed_signal, System.IntPtr closure, int after);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_closure_by_id(System.IntPtr instance, uint signal_id, uint detail, System.IntPtr closure, int after);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_data(System.IntPtr instance, string detailed_signal, System.IntPtr c_handler, System.IntPtr data, System.IntPtr destroy_data, int connect_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_object(System.IntPtr instance, string detailed_signal, System.IntPtr c_handler, System.IntPtr gobject, int connect_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_emitv(System.IntPtr instance_and_params, uint signal_id, uint detail, System.IntPtr return_value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_signal_get_invocation_hint(System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handler_block(System.IntPtr instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handler_disconnect(System.IntPtr instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_handler_find(System.IntPtr instance, int mask, uint signal_id, uint detail, System.IntPtr closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_signal_handler_is_connected(System.IntPtr instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handler_unblock(System.IntPtr instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_handlers_block_matched(System.IntPtr instance, int mask, uint signal_id, uint detail, System.IntPtr closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handlers_destroy(System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_handlers_disconnect_matched(System.IntPtr instance, int mask, uint signal_id, uint detail, System.IntPtr closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_handlers_unblock_matched(System.IntPtr instance, int mask, uint signal_id, uint detail, System.IntPtr closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_signal_has_handler_pending(System.IntPtr instance, uint signal_id, uint detail, int may_be_blocked);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_signal_list_ids(ulong itype, System.IntPtr n_ids);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_lookup(string name, ulong itype);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_signal_name(uint signal_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_newv(string signal_name, ulong itype, int signal_flags, System.IntPtr class_closure, System.IntPtr accumulator, System.IntPtr accu_data, System.IntPtr c_marshaller, ulong return_type, uint n_params, System.IntPtr param_types);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_override_class_closure(uint signal_id, ulong instance_type, System.IntPtr class_closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_override_class_handler(string signal_name, ulong instance_type, System.IntPtr class_handler);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_signal_parse_name(string detailed_signal, ulong itype, System.IntPtr signal_id_p, System.IntPtr detail_p, int force_detail_quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_query(uint signal_id, System.IntPtr query);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_remove_emission_hook(uint signal_id, ulong hook_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_set_va_marshaller(uint signal_id, ulong instance_type, System.IntPtr va_marshaller);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_stop_emission(System.IntPtr instance, uint signal_id, uint detail);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_stop_emission_by_name(System.IntPtr instance, string detailed_signal);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_signal_type_cclosure_new(ulong itype, uint struct_offset);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_source_set_closure(System.IntPtr source, System.IntPtr closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_source_set_dummy_callback(System.IntPtr source);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_strdup_value_contents(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_class_cache_func(System.IntPtr cache_data, System.IntPtr cache_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_class_private(ulong class_type, ulong private_size);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_add_instance_private(ulong class_type, ulong private_size);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_interface_check(System.IntPtr check_data, System.IntPtr check_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_interface_dynamic(ulong instance_type, ulong interface_type, System.IntPtr plugin);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_interface_static(ulong instance_type, ulong interface_type, System.IntPtr info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_check_class_cast(System.IntPtr g_class, ulong is_a_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_check_class_is_a(System.IntPtr g_class, ulong is_a_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_check_instance(System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_check_instance_cast(System.IntPtr instance, ulong iface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_check_instance_is_a(System.IntPtr instance, ulong iface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_check_instance_is_fundamentally_a(System.IntPtr instance, ulong fundamental_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_check_is_value_type(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_check_value(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_check_value_holds(System.IntPtr value, ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_children(ulong type, System.IntPtr n_children);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_create_instance(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_default_interface_peek(ulong g_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_default_interface_ref(ulong g_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_default_interface_unref(System.IntPtr g_iface);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_type_depth(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_ensure(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_free_instance(System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_from_name(string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_fundamental(ulong type_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_fundamental_next();
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_get_instance_count(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_get_plugin(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_get_qdata(ulong type, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_type_get_type_registration_serial();
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_init();
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_init_with_debug_flags(int debug_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_interfaces(ulong type, System.IntPtr n_interfaces);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_is_a(ulong type, ulong is_a_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_type_name(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_type_name_from_class(System.IntPtr g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_type_name_from_instance(System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_next_base(ulong leaf_type, ulong root_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_parent(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_type_qname(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_query(ulong type, System.IntPtr query);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_register_dynamic(ulong parent_type, string type_name, System.IntPtr plugin, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_register_fundamental(ulong type_id, string type_name, System.IntPtr info, System.IntPtr finfo, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_register_static(ulong parent_type, string type_name, System.IntPtr info, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_register_static_simple(ulong parent_type, string type_name, uint class_size, System.IntPtr class_init, uint instance_size, System.IntPtr instance_init, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_remove_class_cache_func(System.IntPtr cache_data, System.IntPtr cache_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_remove_interface_check(System.IntPtr check_data, System.IntPtr check_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_set_qdata(ulong type, uint quark, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_test_flags(ulong type, uint flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_add_private(System.IntPtr g_class, ulong private_size);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_class_get_instance_private_offset(System.IntPtr g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_class_get_private(System.IntPtr klass, ulong private_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_class_peek_parent(System.IntPtr g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_unref(System.IntPtr g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_unref_uncached(System.IntPtr g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_adjust_private_offset(System.IntPtr g_class, System.IntPtr private_size_or_offset);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_class_peek(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_class_peek_static(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_class_ref(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_binding_get_flags(System.IntPtr binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_binding_get_source(System.IntPtr binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_binding_get_source_property(System.IntPtr binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_binding_get_target(System.IntPtr binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_binding_get_target_property(System.IntPtr binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_binding_unbind(System.IntPtr binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_new_with_properties(ulong object_type, uint n_properties, System.IntPtr names, System.IntPtr values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_newv(ulong object_type, uint n_parameters, System.IntPtr parameters);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_object_compat_control(ulong what, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_interface_find_property(System.IntPtr g_iface, string property_name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_interface_install_property(System.IntPtr g_iface, System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_interface_list_properties(System.IntPtr g_iface, System.IntPtr n_properties_p);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_add_toggle_ref(System.IntPtr @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_add_weak_pointer(System.IntPtr @object, System.IntPtr weak_pointer_location);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_bind_property(System.IntPtr source, string source_property, System.IntPtr target, string target_property, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_bind_property_full(System.IntPtr source, string source_property, System.IntPtr target, string target_property, int flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_bind_property_with_closures(System.IntPtr source, string source_property, System.IntPtr target, string target_property, int flags, System.IntPtr transform_to, System.IntPtr transform_from);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_dup_data(System.IntPtr @object, string key, System.IntPtr dup_func, System.IntPtr user_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_dup_qdata(System.IntPtr @object, uint quark, System.IntPtr dup_func, System.IntPtr user_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_force_floating(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_freeze_notify(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_get_data(System.IntPtr @object, string key);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_get_property(System.IntPtr @object, string property_name, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_get_qdata(System.IntPtr @object, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_getv(System.IntPtr @object, uint n_properties, System.IntPtr names, System.IntPtr values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_object_is_floating(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_notify(System.IntPtr @object, string property_name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_notify_by_pspec(System.IntPtr @object, System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_ref(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_ref_sink(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_remove_toggle_ref(System.IntPtr @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_remove_weak_pointer(System.IntPtr @object, System.IntPtr weak_pointer_location);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_object_replace_data(System.IntPtr @object, string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_object_replace_qdata(System.IntPtr @object, uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_run_dispose(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_data(System.IntPtr @object, string key, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_data_full(System.IntPtr @object, string key, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_property(System.IntPtr @object, string property_name, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_qdata(System.IntPtr @object, uint quark, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_qdata_full(System.IntPtr @object, uint quark, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_setv(System.IntPtr @object, uint n_properties, System.IntPtr names, System.IntPtr values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_steal_data(System.IntPtr @object, string key);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_steal_qdata(System.IntPtr @object, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_thaw_notify(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_unref(System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_watch_closure(System.IntPtr @object, System.IntPtr closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_weak_ref(System.IntPtr @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_weak_unref(System.IntPtr @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_copy(System.IntPtr src_value, System.IntPtr dest_value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_dup_boxed(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_dup_object(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_dup_param(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_value_dup_string(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_dup_variant(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_fits_pointer(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_get_boolean(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_get_boxed(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern sbyte g_value_get_char(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern double g_value_get_double(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_get_enum(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_value_get_flags(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern float g_value_get_float(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_value_get_gtype(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_get_int(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern long g_value_get_int64(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern long g_value_get_long(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_get_object(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_get_param(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_get_pointer(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern sbyte g_value_get_schar(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_value_get_string(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern byte g_value_get_uchar(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_value_get_uint(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_value_get_uint64(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_value_get_ulong(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_get_variant(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_init(System.IntPtr value, ulong g_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_init_from_instance(System.IntPtr value, System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_peek_pointer(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_reset(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_boolean(System.IntPtr value, int v_boolean);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_boxed(System.IntPtr value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_boxed_take_ownership(System.IntPtr value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_char(System.IntPtr value, sbyte v_char);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_double(System.IntPtr value, double v_double);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_enum(System.IntPtr value, int v_enum);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_flags(System.IntPtr value, uint v_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_float(System.IntPtr value, float v_float);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_gtype(System.IntPtr value, ulong v_gtype);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_instance(System.IntPtr value, System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_int(System.IntPtr value, int v_int);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_int64(System.IntPtr value, long v_int64);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_long(System.IntPtr value, long v_long);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_object(System.IntPtr value, System.IntPtr v_object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_object_take_ownership(System.IntPtr value, System.IntPtr v_object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_param(System.IntPtr value, System.IntPtr param);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_param_take_ownership(System.IntPtr value, System.IntPtr param);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_pointer(System.IntPtr value, System.IntPtr v_pointer);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_schar(System.IntPtr value, sbyte v_char);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_static_boxed(System.IntPtr value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_static_string(System.IntPtr value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_string(System.IntPtr value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_string_take_ownership(System.IntPtr value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_uchar(System.IntPtr value, byte v_uchar);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_uint(System.IntPtr value, uint v_uint);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_uint64(System.IntPtr value, ulong v_uint64);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_ulong(System.IntPtr value, ulong v_ulong);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_variant(System.IntPtr value, System.IntPtr variant);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_boxed(System.IntPtr value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_object(System.IntPtr value, System.IntPtr v_object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_param(System.IntPtr value, System.IntPtr param);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_string(System.IntPtr value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_variant(System.IntPtr value, System.IntPtr variant);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_transform(System.IntPtr src_value, System.IntPtr dest_value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_unset(System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_register_transform_func(ulong src_type, ulong dest_type, System.IntPtr transform_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_type_compatible(ulong src_type, ulong dest_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_type_transformable(ulong src_type, ulong dest_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_closure_new_object(uint sizeof_closure, System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_closure_new_simple(uint sizeof_closure, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_add_finalize_notifier(System.IntPtr closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_add_invalidate_notifier(System.IntPtr closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_add_marshal_guards(System.IntPtr closure, System.IntPtr pre_marshal_data, System.IntPtr pre_marshal_notify, System.IntPtr post_marshal_data, System.IntPtr post_marshal_notify);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_invalidate(System.IntPtr closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_invoke(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_closure_ref(System.IntPtr closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_remove_finalize_notifier(System.IntPtr closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_remove_invalidate_notifier(System.IntPtr closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_set_marshal(System.IntPtr closure, System.IntPtr marshal);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_set_meta_marshal(System.IntPtr closure, System.IntPtr marshal_data, System.IntPtr meta_marshal);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_sink(System.IntPtr closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_unref(System.IntPtr closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_instance_get_private(System.IntPtr instance, ulong private_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXED(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_BOOLEAN__FLAGS(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_STRING__OBJECT_POINTER(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__BOOLEAN(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__BOXED(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__CHAR(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__DOUBLE(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__ENUM(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__FLAGS(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__FLOAT(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__INT(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__LONG(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__OBJECT(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__PARAM(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__POINTER(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__STRING(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__UCHAR(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__UINT(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__UINT_POINTER(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__ULONG(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__VARIANT(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__VOID(System.IntPtr closure, System.IntPtr return_value, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_generic(System.IntPtr closure, System.IntPtr return_gvalue, uint n_param_values, System.IntPtr param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_cclosure_new(System.IntPtr callback_func, System.IntPtr user_data, System.IntPtr destroy_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_cclosure_new_object(System.IntPtr callback_func, System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_cclosure_new_object_swap(System.IntPtr callback_func, System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_cclosure_new_swap(System.IntPtr callback_func, System.IntPtr user_data, System.IntPtr destroy_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_internal(ulong param_type, string name, string nick, string blurb, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_param_spec_get_blurb(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_get_default_value(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_param_spec_get_name(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_param_spec_get_name_quark(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_param_spec_get_nick(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_get_qdata(System.IntPtr pspec, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_get_redirect_target(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_ref(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_ref_sink(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_set_qdata(System.IntPtr pspec, uint quark, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_set_qdata_full(System.IntPtr pspec, uint quark, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_sink(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_steal_qdata(System.IntPtr pspec, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_unref(System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_interface_peek_parent(System.IntPtr g_iface);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_interface_add_prerequisite(ulong interface_type, ulong prerequisite_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_interface_get_plugin(ulong instance_type, ulong interface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_interface_peek(System.IntPtr instance_class, ulong iface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_interface_prerequisites(ulong interface_type, System.IntPtr n_prerequisites);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_class_find_property(System.IntPtr oclass, string property_name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_install_properties(System.IntPtr oclass, uint n_pspecs, System.IntPtr pspecs);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_install_property(System.IntPtr oclass, uint property_id, System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_class_list_properties(System.IntPtr oclass, System.IntPtr n_properties);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_override_property(System.IntPtr oclass, uint property_id, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_pool_insert(System.IntPtr pool, System.IntPtr pspec, ulong owner_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pool_list(System.IntPtr pool, ulong owner_type, System.IntPtr n_pspecs_p);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pool_list_owned(System.IntPtr pool, ulong owner_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pool_lookup(System.IntPtr pool, string param_name, ulong owner_type, int walk_ancestors);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_pool_remove(System.IntPtr pool, System.IntPtr pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pool_new(int type_prefixing);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_value_table_peek(ulong type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_plugin_complete_interface_info(System.IntPtr plugin, ulong instance_type, ulong interface_type, System.IntPtr info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_plugin_complete_type_info(System.IntPtr plugin, ulong g_type, System.IntPtr info, System.IntPtr value_table);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_plugin_unuse(System.IntPtr plugin);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_plugin_use(System.IntPtr plugin);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_add_interface(System.IntPtr module, ulong instance_type, ulong interface_type, System.IntPtr interface_info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_module_register_enum(System.IntPtr module, string name, System.IntPtr const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_module_register_flags(System.IntPtr module, string name, System.IntPtr const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_type_module_register_type(System.IntPtr module, ulong parent_type, string type_name, System.IntPtr type_info, int flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_set_name(System.IntPtr module, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_unuse(System.IntPtr module);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_module_use(System.IntPtr module);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_new(uint n_prealloced);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_append(System.IntPtr value_array, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_copy(System.IntPtr value_array);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_array_free(System.IntPtr value_array);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_get_nth(System.IntPtr value_array, uint index_);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_insert(System.IntPtr value_array, uint index_, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_prepend(System.IntPtr value_array, System.IntPtr value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_remove(System.IntPtr value_array, uint index_);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_sort(System.IntPtr value_array, System.IntPtr compare_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_array_sort_with_data(System.IntPtr value_array, System.IntPtr compare_func, System.IntPtr user_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_weak_ref_clear(System.IntPtr weak_ref);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_weak_ref_get(System.IntPtr weak_ref);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_weak_ref_init(System.IntPtr weak_ref, System.IntPtr @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_weak_ref_set(System.IntPtr weak_ref, System.IntPtr @object);
	}
}
