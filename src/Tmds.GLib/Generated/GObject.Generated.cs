using System;
using System.Runtime.InteropServices;
namespace GObject {
	public ref struct TypeClass
	{
		private IntPtr _pointer;
		public TypeClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeClass(IntPtr pointer) => new TypeClass(pointer, checkType: true);
		public static explicit operator IntPtr(TypeClass value) => value._pointer;
		public void add_private(ulong private_size) => GObject.GObjectInterop.g_type_class_add_private(this, private_size);
		public int get_instance_private_offset() => GObject.GObjectInterop.g_type_class_get_instance_private_offset(this);
		public System.IntPtr get_private(GLib.GType private_type) => GObject.GObjectInterop.g_type_class_get_private(this, private_type);
		public GObject.TypeClass peek_parent() => GObject.GObjectInterop.g_type_class_peek_parent(this);
		public void unref() => GObject.GObjectInterop.g_type_class_unref(this);
		public void unref_uncached() => GObject.GObjectInterop.g_type_class_unref_uncached(this);
		public static void adjust_private_offset(System.IntPtr g_class, int private_size_or_offset) => GObjectInterop.g_type_class_adjust_private_offset(g_class, private_size_or_offset);
		public static GObject.TypeClass peek(GLib.GType type) => GObjectInterop.g_type_class_peek(type);
		public static GObject.TypeClass peek_static(GLib.GType type) => GObjectInterop.g_type_class_peek_static(type);
		public static GObject.TypeClass @ref(GLib.GType type) => GObjectInterop.g_type_class_ref(type);
	}
	[Flags]
	public enum BindingFlags
	{
		@default = 0,
		bidirectional = 1,
		sync_create = 2,
		invert_boolean = 4,
	}
	public ref struct Binding
	{
		private IntPtr _pointer;
		public Binding(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Binding(IntPtr pointer) => new Binding(pointer, checkType: true);
		public static explicit operator IntPtr(Binding value) => value._pointer;
		public static implicit operator GObject.Object(Binding value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Binding(GObject.Object value) => new Binding((IntPtr)value, checkType: true);
		public GObject.BindingFlags get_flags() => GObject.GObjectInterop.g_binding_get_flags(this);
		public GObject.Object get_source() => GObject.GObjectInterop.g_binding_get_source(this);
		public string get_source_property() => GObject.GObjectInterop.g_binding_get_source_property(this);
		public GObject.Object get_target() => GObject.GObjectInterop.g_binding_get_target(this);
		public string get_target_property() => GObject.GObjectInterop.g_binding_get_target_property(this);
		public void unbind() => GObject.GObjectInterop.g_binding_unbind(this);
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
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_binding_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Object
	{
		private IntPtr _pointer;
		public Object(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Object(IntPtr pointer) => new Object(pointer, checkType: true);
		public static explicit operator IntPtr(Object value) => value._pointer;
		public static GObject.Object new_with_properties(GLib.GType object_type, uint n_properties, System.IntPtr names, System.IntPtr values) => GObjectInterop.g_object_new_with_properties(object_type, n_properties, names, values);
		public static GObject.Object newv(GLib.GType object_type, uint n_parameters, System.IntPtr parameters) => GObjectInterop.g_object_newv(object_type, n_parameters, parameters);
		public static ulong compat_control(ulong what, System.IntPtr data) => GObjectInterop.g_object_compat_control(what, data);
		public static GObject.ParamSpec interface_find_property(GObject.TypeInterface g_iface, string property_name) => GObjectInterop.g_object_interface_find_property(g_iface, property_name);
		public static void interface_install_property(GObject.TypeInterface g_iface, GObject.ParamSpec pspec) => GObjectInterop.g_object_interface_install_property(g_iface, pspec);
		public static System.IntPtr interface_list_properties(GObject.TypeInterface g_iface, out uint n_properties_p) => GObjectInterop.g_object_interface_list_properties(g_iface, out n_properties_p);
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
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_object_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Closure
	{
		private IntPtr _pointer;
		public Closure(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Closure(IntPtr pointer) => new Closure(pointer, checkType: true);
		public static explicit operator IntPtr(Closure value) => value._pointer;
		public static GObject.Closure new_object(uint sizeof_closure, GObject.Object @object) => GObjectInterop.g_closure_new_object(sizeof_closure, @object);
		public static GObject.Closure new_simple(uint sizeof_closure, System.IntPtr data) => GObjectInterop.g_closure_new_simple(sizeof_closure, data);
		public void add_finalize_notifier(System.IntPtr notify_data, System.IntPtr notify_func) => GObject.GObjectInterop.g_closure_add_finalize_notifier(this, notify_data, notify_func);
		public void add_invalidate_notifier(System.IntPtr notify_data, System.IntPtr notify_func) => GObject.GObjectInterop.g_closure_add_invalidate_notifier(this, notify_data, notify_func);
		public void add_marshal_guards(System.IntPtr pre_marshal_data, System.IntPtr pre_marshal_notify, System.IntPtr post_marshal_data, System.IntPtr post_marshal_notify) => GObject.GObjectInterop.g_closure_add_marshal_guards(this, pre_marshal_data, pre_marshal_notify, post_marshal_data, post_marshal_notify);
		public void invalidate() => GObject.GObjectInterop.g_closure_invalidate(this);
		public GObject.Closure @ref() => GObject.GObjectInterop.g_closure_ref(this);
		public void remove_finalize_notifier(System.IntPtr notify_data, System.IntPtr notify_func) => GObject.GObjectInterop.g_closure_remove_finalize_notifier(this, notify_data, notify_func);
		public void remove_invalidate_notifier(System.IntPtr notify_data, System.IntPtr notify_func) => GObject.GObjectInterop.g_closure_remove_invalidate_notifier(this, notify_data, notify_func);
		public void set_marshal(System.IntPtr marshal) => GObject.GObjectInterop.g_closure_set_marshal(this, marshal);
		public void set_meta_marshal(System.IntPtr marshal_data, System.IntPtr meta_marshal) => GObject.GObjectInterop.g_closure_set_meta_marshal(this, marshal_data, meta_marshal);
		public void sink() => GObject.GObjectInterop.g_closure_sink(this);
		public void unref() => GObject.GObjectInterop.g_closure_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_closure_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct TypeInstance
	{
		private IntPtr _pointer;
		public TypeInstance(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeInstance(IntPtr pointer) => new TypeInstance(pointer, checkType: true);
		public static explicit operator IntPtr(TypeInstance value) => value._pointer;
		public System.IntPtr get_private(GLib.GType private_type) => GObject.GObjectInterop.g_type_instance_get_private(this, private_type);
	}
	public ref struct CClosure
	{
		private IntPtr _pointer;
		public CClosure(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator CClosure(IntPtr pointer) => new CClosure(pointer, checkType: true);
		public static explicit operator IntPtr(CClosure value) => value._pointer;
		public static GObject.Closure @new(System.IntPtr callback_func, System.IntPtr user_data, System.IntPtr destroy_data) => GObjectInterop.g_cclosure_new(callback_func, user_data, destroy_data);
		public static GObject.Closure new_object(System.IntPtr callback_func, GObject.Object @object) => GObjectInterop.g_cclosure_new_object(callback_func, @object);
		public static GObject.Closure new_object_swap(System.IntPtr callback_func, GObject.Object @object) => GObjectInterop.g_cclosure_new_object_swap(callback_func, @object);
		public static GObject.Closure new_swap(System.IntPtr callback_func, System.IntPtr user_data, System.IntPtr destroy_data) => GObjectInterop.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}
	public ref struct ClosureNotifyData
	{
		private IntPtr _pointer;
		public ClosureNotifyData(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ClosureNotifyData(IntPtr pointer) => new ClosureNotifyData(pointer, checkType: true);
		public static explicit operator IntPtr(ClosureNotifyData value) => value._pointer;
	}
	[Flags]
	public enum ConnectFlags
	{
		after = 1,
		swapped = 2,
	}
	public ref struct EnumValue
	{
		private IntPtr _pointer;
		public EnumValue(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EnumValue(IntPtr pointer) => new EnumValue(pointer, checkType: true);
		public static explicit operator IntPtr(EnumValue value) => value._pointer;
	}
	public ref struct EnumClass
	{
		private IntPtr _pointer;
		public EnumClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EnumClass(IntPtr pointer) => new EnumClass(pointer, checkType: true);
		public static explicit operator IntPtr(EnumClass value) => value._pointer;
	}
	public ref struct FlagsValue
	{
		private IntPtr _pointer;
		public FlagsValue(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FlagsValue(IntPtr pointer) => new FlagsValue(pointer, checkType: true);
		public static explicit operator IntPtr(FlagsValue value) => value._pointer;
	}
	public ref struct FlagsClass
	{
		private IntPtr _pointer;
		public FlagsClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator FlagsClass(IntPtr pointer) => new FlagsClass(pointer, checkType: true);
		public static explicit operator IntPtr(FlagsClass value) => value._pointer;
	}
	public ref struct InitiallyUnowned
	{
		private IntPtr _pointer;
		public InitiallyUnowned(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator InitiallyUnowned(IntPtr pointer) => new InitiallyUnowned(pointer, checkType: true);
		public static explicit operator IntPtr(InitiallyUnowned value) => value._pointer;
		public static implicit operator GObject.Object(InitiallyUnowned value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator InitiallyUnowned(GObject.Object value) => new InitiallyUnowned((IntPtr)value, checkType: true);
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
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_initially_unowned_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ObjectConstructParam
	{
		private IntPtr _pointer;
		public ObjectConstructParam(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ObjectConstructParam(IntPtr pointer) => new ObjectConstructParam(pointer, checkType: true);
		public static explicit operator IntPtr(ObjectConstructParam value) => value._pointer;
	}
	public ref struct ParamSpec
	{
		private IntPtr _pointer;
		public ParamSpec(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpec(IntPtr pointer) => new ParamSpec(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpec value) => value._pointer;
		public static GObject.ParamSpec @internal(GLib.GType param_type, string name, string nick, string blurb, GObject.ParamFlags flags) => GObjectInterop.g_param_spec_internal(param_type, name, nick, blurb, flags);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct InitiallyUnownedClass
	{
		private IntPtr _pointer;
		public InitiallyUnownedClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator InitiallyUnownedClass(IntPtr pointer) => new InitiallyUnownedClass(pointer, checkType: true);
		public static explicit operator IntPtr(InitiallyUnownedClass value) => value._pointer;
	}
	public ref struct TypeInterface
	{
		private IntPtr _pointer;
		public TypeInterface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeInterface(IntPtr pointer) => new TypeInterface(pointer, checkType: true);
		public static explicit operator IntPtr(TypeInterface value) => value._pointer;
		public GObject.TypeInterface peek_parent() => GObject.GObjectInterop.g_type_interface_peek_parent(this);
		public static void add_prerequisite(GLib.GType interface_type, GLib.GType prerequisite_type) => GObjectInterop.g_type_interface_add_prerequisite(interface_type, prerequisite_type);
		public static GObject.TypePlugin get_plugin(GLib.GType instance_type, GLib.GType interface_type) => GObjectInterop.g_type_interface_get_plugin(instance_type, interface_type);
		public static GObject.TypeInterface peek(GObject.TypeClass instance_class, GLib.GType iface_type) => GObjectInterop.g_type_interface_peek(instance_class, iface_type);
		public static System.IntPtr prerequisites(GLib.GType interface_type, out uint n_prerequisites) => GObjectInterop.g_type_interface_prerequisites(interface_type, out n_prerequisites);
	}
	public ref struct InterfaceInfo
	{
		private IntPtr _pointer;
		public InterfaceInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator InterfaceInfo(IntPtr pointer) => new InterfaceInfo(pointer, checkType: true);
		public static explicit operator IntPtr(InterfaceInfo value) => value._pointer;
	}
	public ref struct Parameter
	{
		private IntPtr _pointer;
		public Parameter(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Parameter(IntPtr pointer) => new Parameter(pointer, checkType: true);
		public static explicit operator IntPtr(Parameter value) => value._pointer;
	}
	public ref struct ObjectClass
	{
		private IntPtr _pointer;
		public ObjectClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ObjectClass(IntPtr pointer) => new ObjectClass(pointer, checkType: true);
		public static explicit operator IntPtr(ObjectClass value) => value._pointer;
		public GObject.ParamSpec find_property(string property_name) => GObject.GObjectInterop.g_object_class_find_property(this, property_name);
		public void install_properties(uint n_pspecs, System.IntPtr pspecs) => GObject.GObjectInterop.g_object_class_install_properties(this, n_pspecs, pspecs);
		public void install_property(uint property_id, GObject.ParamSpec pspec) => GObject.GObjectInterop.g_object_class_install_property(this, property_id, pspec);
		public System.IntPtr list_properties(out uint n_properties) => GObject.GObjectInterop.g_object_class_list_properties(this, out n_properties);
		public void override_property(uint property_id, string name) => GObject.GObjectInterop.g_object_class_override_property(this, property_id, name);
	}
	[Flags]
	public enum ParamFlags
	{
		readable = 1,
		writable = 2,
		readwrite = 3,
		construct = 4,
		construct_only = 8,
		lax_validation = 16,
		static_name = 32,
		@private = 32,
		static_nick = 64,
		static_blurb = 128,
		explicit_notify = 1073741824,
		deprecated = unchecked((int)2147483648U),
	}
	public ref struct ParamSpecBoolean
	{
		private IntPtr _pointer;
		public ParamSpecBoolean(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecBoolean(IntPtr pointer) => new ParamSpecBoolean(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecBoolean value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecBoolean value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecBoolean(GObject.ParamSpec value) => new ParamSpecBoolean((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecBoxed
	{
		private IntPtr _pointer;
		public ParamSpecBoxed(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecBoxed(IntPtr pointer) => new ParamSpecBoxed(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecBoxed value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecBoxed value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecBoxed(GObject.ParamSpec value) => new ParamSpecBoxed((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecChar
	{
		private IntPtr _pointer;
		public ParamSpecChar(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecChar(IntPtr pointer) => new ParamSpecChar(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecChar value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecChar value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecChar(GObject.ParamSpec value) => new ParamSpecChar((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecClass
	{
		private IntPtr _pointer;
		public ParamSpecClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecClass(IntPtr pointer) => new ParamSpecClass(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecClass value) => value._pointer;
	}
	public ref struct ParamSpecDouble
	{
		private IntPtr _pointer;
		public ParamSpecDouble(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecDouble(IntPtr pointer) => new ParamSpecDouble(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecDouble value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecDouble value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecDouble(GObject.ParamSpec value) => new ParamSpecDouble((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecEnum
	{
		private IntPtr _pointer;
		public ParamSpecEnum(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecEnum(IntPtr pointer) => new ParamSpecEnum(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecEnum value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecEnum value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecEnum(GObject.ParamSpec value) => new ParamSpecEnum((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecFlags
	{
		private IntPtr _pointer;
		public ParamSpecFlags(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecFlags(IntPtr pointer) => new ParamSpecFlags(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecFlags value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecFlags value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecFlags(GObject.ParamSpec value) => new ParamSpecFlags((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecFloat
	{
		private IntPtr _pointer;
		public ParamSpecFloat(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecFloat(IntPtr pointer) => new ParamSpecFloat(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecFloat value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecFloat value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecFloat(GObject.ParamSpec value) => new ParamSpecFloat((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecGType
	{
		private IntPtr _pointer;
		public ParamSpecGType(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecGType(IntPtr pointer) => new ParamSpecGType(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecGType value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecGType value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecGType(GObject.ParamSpec value) => new ParamSpecGType((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecInt
	{
		private IntPtr _pointer;
		public ParamSpecInt(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecInt(IntPtr pointer) => new ParamSpecInt(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecInt value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecInt value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecInt(GObject.ParamSpec value) => new ParamSpecInt((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecInt64
	{
		private IntPtr _pointer;
		public ParamSpecInt64(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecInt64(IntPtr pointer) => new ParamSpecInt64(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecInt64 value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecInt64 value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecInt64(GObject.ParamSpec value) => new ParamSpecInt64((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecLong
	{
		private IntPtr _pointer;
		public ParamSpecLong(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecLong(IntPtr pointer) => new ParamSpecLong(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecLong value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecLong value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecLong(GObject.ParamSpec value) => new ParamSpecLong((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecObject
	{
		private IntPtr _pointer;
		public ParamSpecObject(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecObject(IntPtr pointer) => new ParamSpecObject(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecObject value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecObject value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecObject(GObject.ParamSpec value) => new ParamSpecObject((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecOverride
	{
		private IntPtr _pointer;
		public ParamSpecOverride(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecOverride(IntPtr pointer) => new ParamSpecOverride(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecOverride value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecOverride value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecOverride(GObject.ParamSpec value) => new ParamSpecOverride((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecParam
	{
		private IntPtr _pointer;
		public ParamSpecParam(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecParam(IntPtr pointer) => new ParamSpecParam(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecParam value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecParam value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecParam(GObject.ParamSpec value) => new ParamSpecParam((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecPointer
	{
		private IntPtr _pointer;
		public ParamSpecPointer(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecPointer(IntPtr pointer) => new ParamSpecPointer(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecPointer value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecPointer value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecPointer(GObject.ParamSpec value) => new ParamSpecPointer((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecPool
	{
		private IntPtr _pointer;
		public ParamSpecPool(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecPool(IntPtr pointer) => new ParamSpecPool(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecPool value) => value._pointer;
		public void insert(GObject.ParamSpec pspec, GLib.GType owner_type) => GObject.GObjectInterop.g_param_spec_pool_insert(this, pspec, owner_type);
		public System.IntPtr list(GLib.GType owner_type, out uint n_pspecs_p) => GObject.GObjectInterop.g_param_spec_pool_list(this, owner_type, out n_pspecs_p);
		public System.IntPtr list_owned(GLib.GType owner_type) => GObject.GObjectInterop.g_param_spec_pool_list_owned(this, owner_type);
		public GObject.ParamSpec lookup(string param_name, GLib.GType owner_type, bool walk_ancestors) => GObject.GObjectInterop.g_param_spec_pool_lookup(this, param_name, owner_type, walk_ancestors);
		public void remove(GObject.ParamSpec pspec) => GObject.GObjectInterop.g_param_spec_pool_remove(this, pspec);
		public static GObject.ParamSpecPool @new(bool type_prefixing) => GObjectInterop.g_param_spec_pool_new(type_prefixing);
	}
	public ref struct ParamSpecString
	{
		private IntPtr _pointer;
		public ParamSpecString(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecString(IntPtr pointer) => new ParamSpecString(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecString value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecString value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecString(GObject.ParamSpec value) => new ParamSpecString((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecTypeInfo
	{
		private IntPtr _pointer;
		public ParamSpecTypeInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecTypeInfo(IntPtr pointer) => new ParamSpecTypeInfo(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecTypeInfo value) => value._pointer;
	}
	public ref struct ParamSpecUChar
	{
		private IntPtr _pointer;
		public ParamSpecUChar(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecUChar(IntPtr pointer) => new ParamSpecUChar(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecUChar value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecUChar value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecUChar(GObject.ParamSpec value) => new ParamSpecUChar((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecUInt
	{
		private IntPtr _pointer;
		public ParamSpecUInt(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecUInt(IntPtr pointer) => new ParamSpecUInt(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecUInt value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecUInt value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecUInt(GObject.ParamSpec value) => new ParamSpecUInt((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecUInt64
	{
		private IntPtr _pointer;
		public ParamSpecUInt64(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecUInt64(IntPtr pointer) => new ParamSpecUInt64(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecUInt64 value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecUInt64 value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecUInt64(GObject.ParamSpec value) => new ParamSpecUInt64((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecULong
	{
		private IntPtr _pointer;
		public ParamSpecULong(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecULong(IntPtr pointer) => new ParamSpecULong(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecULong value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecULong value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecULong(GObject.ParamSpec value) => new ParamSpecULong((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecUnichar
	{
		private IntPtr _pointer;
		public ParamSpecUnichar(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecUnichar(IntPtr pointer) => new ParamSpecUnichar(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecUnichar value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecUnichar value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecUnichar(GObject.ParamSpec value) => new ParamSpecUnichar((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecValueArray
	{
		private IntPtr _pointer;
		public ParamSpecValueArray(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecValueArray(IntPtr pointer) => new ParamSpecValueArray(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecValueArray value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecValueArray value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecValueArray(GObject.ParamSpec value) => new ParamSpecValueArray((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ParamSpecVariant
	{
		private IntPtr _pointer;
		public ParamSpecVariant(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ParamSpecVariant(IntPtr pointer) => new ParamSpecVariant(pointer, checkType: true);
		public static explicit operator IntPtr(ParamSpecVariant value) => value._pointer;
		public static implicit operator GObject.ParamSpec(ParamSpecVariant value) => new GObject.ParamSpec((IntPtr)value, checkType: false);
		public static explicit operator ParamSpecVariant(GObject.ParamSpec value) => new ParamSpecVariant((IntPtr)value, checkType: true);
		public string get_blurb() => GObject.GObjectInterop.g_param_spec_get_blurb(this);
		public string get_name() => GObject.GObjectInterop.g_param_spec_get_name(this);
		public uint get_name_quark() => GObject.GObjectInterop.g_param_spec_get_name_quark(this);
		public string get_nick() => GObject.GObjectInterop.g_param_spec_get_nick(this);
		public System.IntPtr get_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_get_qdata(this, quark);
		public GObject.ParamSpec get_redirect_target() => GObject.GObjectInterop.g_param_spec_get_redirect_target(this);
		public GObject.ParamSpec @ref() => GObject.GObjectInterop.g_param_spec_ref(this);
		public GObject.ParamSpec ref_sink() => GObject.GObjectInterop.g_param_spec_ref_sink(this);
		public void set_qdata(uint quark, System.IntPtr data) => GObject.GObjectInterop.g_param_spec_set_qdata(this, quark, data);
		public void set_qdata_full(uint quark, System.IntPtr data, System.IntPtr destroy) => GObject.GObjectInterop.g_param_spec_set_qdata_full(this, quark, data, destroy);
		public void sink() => GObject.GObjectInterop.g_param_spec_sink(this);
		public System.IntPtr steal_qdata(uint quark) => GObject.GObjectInterop.g_param_spec_steal_qdata(this, quark);
		public void unref() => GObject.GObjectInterop.g_param_spec_unref(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct SignalInvocationHint
	{
		private IntPtr _pointer;
		public SignalInvocationHint(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SignalInvocationHint(IntPtr pointer) => new SignalInvocationHint(pointer, checkType: true);
		public static explicit operator IntPtr(SignalInvocationHint value) => value._pointer;
	}
	[Flags]
	public enum SignalFlags
	{
		run_first = 1,
		run_last = 2,
		run_cleanup = 4,
		no_recurse = 8,
		detailed = 16,
		action = 32,
		no_hooks = 64,
		must_collect = 128,
		deprecated = 256,
	}
	[Flags]
	public enum SignalMatchType
	{
		id = 1,
		detail = 2,
		closure = 4,
		func = 8,
		data = 16,
		unblocked = 32,
	}
	[Flags]
	public enum TypeDebugFlags
	{
		none = 0,
		objects = 1,
		signals = 2,
		instance_count = 4,
		mask = 7,
	}
	[Flags]
	public enum TypeFlags
	{
		@abstract = 16,
		value_abstract = 32,
	}
	[Flags]
	public enum TypeFundamentalFlags
	{
		classed = 1,
		instantiatable = 2,
		derivable = 4,
		deep_derivable = 8,
	}
	public ref struct TypeFundamentalInfo
	{
		private IntPtr _pointer;
		public TypeFundamentalInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeFundamentalInfo(IntPtr pointer) => new TypeFundamentalInfo(pointer, checkType: true);
		public static explicit operator IntPtr(TypeFundamentalInfo value) => value._pointer;
	}
	public ref struct TypeValueTable
	{
		private IntPtr _pointer;
		public TypeValueTable(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeValueTable(IntPtr pointer) => new TypeValueTable(pointer, checkType: true);
		public static explicit operator IntPtr(TypeValueTable value) => value._pointer;
		public static GObject.TypeValueTable peek(GLib.GType type) => GObjectInterop.g_type_value_table_peek(type);
	}
	public ref struct TypePlugin
	{
		private IntPtr _pointer;
		public TypePlugin(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypePlugin(IntPtr pointer) => new TypePlugin(pointer, checkType: true);
		public static explicit operator IntPtr(TypePlugin value) => value._pointer;
		public void complete_interface_info(GLib.GType instance_type, GLib.GType interface_type, GObject.InterfaceInfo info) => GObject.GObjectInterop.g_type_plugin_complete_interface_info(this, instance_type, interface_type, info);
		public void unuse() => GObject.GObjectInterop.g_type_plugin_unuse(this);
		public void use() => GObject.GObjectInterop.g_type_plugin_use(this);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_type_plugin_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct TypeModule
	{
		private IntPtr _pointer;
		public TypeModule(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator TypeModule(IntPtr pointer) => new TypeModule(pointer, checkType: true);
		public static explicit operator IntPtr(TypeModule value) => value._pointer;
		public static implicit operator GObject.Object(TypeModule value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator TypeModule(GObject.Object value) => new TypeModule((IntPtr)value, checkType: true);
		public void add_interface(GLib.GType instance_type, GLib.GType interface_type, GObject.InterfaceInfo interface_info) => GObject.GObjectInterop.g_type_module_add_interface(this, instance_type, interface_type, interface_info);
		public GLib.GType register_enum(string name, GObject.EnumValue const_static_values) => GObject.GObjectInterop.g_type_module_register_enum(this, name, const_static_values);
		public GLib.GType register_flags(string name, GObject.FlagsValue const_static_values) => GObject.GObjectInterop.g_type_module_register_flags(this, name, const_static_values);
		public void set_name(string name) => GObject.GObjectInterop.g_type_module_set_name(this, name);
		public void unuse() => GObject.GObjectInterop.g_type_module_unuse(this);
		public bool use() => GObject.GObjectInterop.g_type_module_use(this);
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
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_type_module_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct TypeModuleClass
	{
		private IntPtr _pointer;
		public TypeModuleClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeModuleClass(IntPtr pointer) => new TypeModuleClass(pointer, checkType: true);
		public static explicit operator IntPtr(TypeModuleClass value) => value._pointer;
	}
	public ref struct TypePluginClass
	{
		private IntPtr _pointer;
		public TypePluginClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypePluginClass(IntPtr pointer) => new TypePluginClass(pointer, checkType: true);
		public static explicit operator IntPtr(TypePluginClass value) => value._pointer;
	}
	public ref struct ValueArray
	{
		private IntPtr _pointer;
		public ValueArray(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ValueArray(IntPtr pointer) => new ValueArray(pointer, checkType: true);
		public static explicit operator IntPtr(ValueArray value) => value._pointer;
		public static GObject.ValueArray @new(uint n_prealloced) => GObjectInterop.g_value_array_new(n_prealloced);
		public GObject.ValueArray copy() => GObject.GObjectInterop.g_value_array_copy(this);
		public void free() => GObject.GObjectInterop.g_value_array_free(this);
		public GObject.ValueArray remove(uint index_) => GObject.GObjectInterop.g_value_array_remove(this, index_);
		public GObject.ValueArray sort(System.IntPtr compare_func) => GObject.GObjectInterop.g_value_array_sort(this, compare_func);
		public GObject.ValueArray sort_with_data(System.IntPtr compare_func, System.IntPtr user_data) => GObject.GObjectInterop.g_value_array_sort_with_data(this, compare_func, user_data);
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_value_array_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public static class GObjectInterop {
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_boxed_copy(GLib.GType boxed_type, System.IntPtr src_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_boxed_free(GLib.GType boxed_type, System.IntPtr boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_boxed_type_register_static(string name, System.IntPtr boxed_copy, System.IntPtr boxed_free);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_clear_object(GObject.Object object_ptr);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.EnumValue g_enum_get_value(GObject.EnumClass enum_class, int value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.EnumValue g_enum_get_value_by_name(GObject.EnumClass enum_class, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.EnumValue g_enum_get_value_by_nick(GObject.EnumClass enum_class, string nick);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_enum_register_static(string name, GObject.EnumValue const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_enum_to_string(GLib.GType g_enum_type, int value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.FlagsValue g_flags_get_first_value(GObject.FlagsClass flags_class, uint value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.FlagsValue g_flags_get_value_by_name(GObject.FlagsClass flags_class, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.FlagsValue g_flags_get_value_by_nick(GObject.FlagsClass flags_class, string nick);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_flags_register_static(string name, GObject.FlagsValue const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_flags_to_string(GLib.GType flags_type, uint value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_gtype_get_type();
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_boolean(string name, string nick, string blurb, bool default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_boxed(string name, string nick, string blurb, GLib.GType boxed_type, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_char(string name, string nick, string blurb, sbyte minimum, sbyte maximum, sbyte default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_double(string name, string nick, string blurb, double minimum, double maximum, double default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_enum(string name, string nick, string blurb, GLib.GType enum_type, int default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_flags(string name, string nick, string blurb, GLib.GType flags_type, uint default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_float(string name, string nick, string blurb, float minimum, float maximum, float default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_gtype(string name, string nick, string blurb, GLib.GType is_a_type, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_int(string name, string nick, string blurb, int minimum, int maximum, int default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_int64(string name, string nick, string blurb, long minimum, long maximum, long default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_long(string name, string nick, string blurb, long minimum, long maximum, long default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_object(string name, string nick, string blurb, GLib.GType object_type, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_override(string name, GObject.ParamSpec overridden);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_param(string name, string nick, string blurb, GLib.GType param_type, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_pointer(string name, string nick, string blurb, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_string(string name, string nick, string blurb, string default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_uchar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_uint(string name, string nick, string blurb, uint minimum, uint maximum, uint default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_uint64(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_ulong(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_unichar(string name, string nick, string blurb, uint default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_value_array(string name, string nick, string blurb, GObject.ParamSpec element_spec, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_variant(string name, string nick, string blurb, GLib.VariantType type, GLib.Variant default_value, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_param_type_register_static(string name, GObject.ParamSpecTypeInfo pspec_info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_pointer_type_register_static(string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_add_emission_hook(uint signal_id, uint detail, System.IntPtr hook_func, System.IntPtr hook_data, System.IntPtr data_destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_closure(GObject.Object instance, string detailed_signal, GObject.Closure closure, bool after);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_closure_by_id(GObject.Object instance, uint signal_id, uint detail, GObject.Closure closure, bool after);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_data(GObject.Object instance, string detailed_signal, System.IntPtr c_handler, System.IntPtr data, System.IntPtr destroy_data, GObject.ConnectFlags connect_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_connect_object(GObject.TypeInstance instance, string detailed_signal, System.IntPtr c_handler, GObject.Object gobject, GObject.ConnectFlags connect_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.SignalInvocationHint g_signal_get_invocation_hint(GObject.Object instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handler_block(GObject.Object instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handler_disconnect(GObject.Object instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_handler_find(GObject.Object instance, GObject.SignalMatchType mask, uint signal_id, uint detail, GObject.Closure closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_signal_handler_is_connected(GObject.Object instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handler_unblock(GObject.Object instance, ulong handler_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_handlers_block_matched(GObject.Object instance, GObject.SignalMatchType mask, uint signal_id, uint detail, GObject.Closure closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_handlers_destroy(GObject.Object instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_handlers_disconnect_matched(GObject.Object instance, GObject.SignalMatchType mask, uint signal_id, uint detail, GObject.Closure closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_handlers_unblock_matched(GObject.Object instance, GObject.SignalMatchType mask, uint signal_id, uint detail, GObject.Closure closure, System.IntPtr func, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_signal_has_handler_pending(GObject.Object instance, uint signal_id, uint detail, bool may_be_blocked);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_signal_list_ids(GLib.GType itype, out uint n_ids);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_lookup(string name, GLib.GType itype);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_signal_name(uint signal_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_signal_newv(string signal_name, GLib.GType itype, GObject.SignalFlags signal_flags, GObject.Closure class_closure, System.IntPtr accumulator, System.IntPtr accu_data, System.IntPtr c_marshaller, GLib.GType return_type, uint n_params, System.IntPtr param_types);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_override_class_closure(uint signal_id, GLib.GType instance_type, GObject.Closure class_closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_override_class_handler(string signal_name, GLib.GType instance_type, System.IntPtr class_handler);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_signal_parse_name(string detailed_signal, GLib.GType itype, out uint signal_id_p, out uint detail_p, bool force_detail_quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_remove_emission_hook(uint signal_id, ulong hook_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_set_va_marshaller(uint signal_id, GLib.GType instance_type, System.IntPtr va_marshaller);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_stop_emission(GObject.Object instance, uint signal_id, uint detail);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_stop_emission_by_name(GObject.Object instance, string detailed_signal);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_signal_type_cclosure_new(GLib.GType itype, uint struct_offset);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_source_set_closure(GLib.Source source, GObject.Closure closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_source_set_dummy_callback(GLib.Source source);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_class_cache_func(System.IntPtr cache_data, System.IntPtr cache_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_class_private(GLib.GType class_type, ulong private_size);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_add_instance_private(GLib.GType class_type, ulong private_size);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_interface_check(System.IntPtr check_data, System.IntPtr check_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_interface_dynamic(GLib.GType instance_type, GLib.GType interface_type, GObject.TypePlugin plugin);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_add_interface_static(GLib.GType instance_type, GLib.GType interface_type, GObject.InterfaceInfo info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeClass g_type_check_class_cast(GObject.TypeClass g_class, GLib.GType is_a_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_check_class_is_a(GObject.TypeClass g_class, GLib.GType is_a_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_check_instance(GObject.TypeInstance instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeInstance g_type_check_instance_cast(GObject.TypeInstance instance, GLib.GType iface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_check_instance_is_a(GObject.TypeInstance instance, GLib.GType iface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_check_instance_is_fundamentally_a(GObject.TypeInstance instance, GLib.GType fundamental_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_check_is_value_type(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_children(GLib.GType type, out uint n_children);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeInstance g_type_create_instance(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeInterface g_type_default_interface_peek(GLib.GType g_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeInterface g_type_default_interface_ref(GLib.GType g_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_default_interface_unref(GObject.TypeInterface g_iface);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_type_depth(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_ensure(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_free_instance(GObject.TypeInstance instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_from_name(string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_fundamental(GLib.GType type_id);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_fundamental_next();
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_get_instance_count(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypePlugin g_type_get_plugin(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_get_qdata(GLib.GType type, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_type_get_type_registration_serial();
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_init();
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_init_with_debug_flags(GObject.TypeDebugFlags debug_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_interfaces(GLib.GType type, out uint n_interfaces);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_is_a(GLib.GType type, GLib.GType is_a_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_type_name(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_type_name_from_class(GObject.TypeClass g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_type_name_from_instance(GObject.TypeInstance instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_next_base(GLib.GType leaf_type, GLib.GType root_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_parent(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_type_qname(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_register_dynamic(GLib.GType parent_type, string type_name, GObject.TypePlugin plugin, GObject.TypeFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_register_static_simple(GLib.GType parent_type, string type_name, uint class_size, System.IntPtr class_init, uint instance_size, System.IntPtr instance_init, GObject.TypeFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_remove_class_cache_func(System.IntPtr cache_data, System.IntPtr cache_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_remove_interface_check(System.IntPtr check_data, System.IntPtr check_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_set_qdata(GLib.GType type, uint quark, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_test_flags(GLib.GType type, uint flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_add_private(GObject.TypeClass g_class, ulong private_size);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_type_class_get_instance_private_offset(GObject.TypeClass g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_class_get_private(GObject.TypeClass klass, GLib.GType private_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeClass g_type_class_peek_parent(GObject.TypeClass g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_unref(GObject.TypeClass g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_unref_uncached(GObject.TypeClass g_class);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_class_adjust_private_offset(System.IntPtr g_class, int private_size_or_offset);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeClass g_type_class_peek(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeClass g_type_class_peek_static(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeClass g_type_class_ref(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.BindingFlags g_binding_get_flags(GObject.Binding binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_binding_get_source(GObject.Binding binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_binding_get_source_property(GObject.Binding binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_binding_get_target(GObject.Binding binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_binding_get_target_property(GObject.Binding binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_binding_unbind(GObject.Binding binding);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_object_new_with_properties(GLib.GType object_type, uint n_properties, System.IntPtr names, System.IntPtr values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_object_newv(GLib.GType object_type, uint n_parameters, System.IntPtr parameters);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_object_compat_control(ulong what, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_object_interface_find_property(GObject.TypeInterface g_iface, string property_name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_interface_install_property(GObject.TypeInterface g_iface, GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_interface_list_properties(GObject.TypeInterface g_iface, out uint n_properties_p);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_add_toggle_ref(GObject.Object @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_add_weak_pointer(GObject.Object @object, ref System.IntPtr weak_pointer_location);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Binding g_object_bind_property(GObject.Object source, string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Binding g_object_bind_property_full(GObject.Object source, string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, System.IntPtr transform_to, System.IntPtr transform_from, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Binding g_object_bind_property_with_closures(GObject.Object source, string source_property, GObject.Object target, string target_property, GObject.BindingFlags flags, GObject.Closure transform_to, GObject.Closure transform_from);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_dup_data(GObject.Object @object, string key, System.IntPtr dup_func, System.IntPtr user_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_dup_qdata(GObject.Object @object, uint quark, System.IntPtr dup_func, System.IntPtr user_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_force_floating(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_freeze_notify(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_get_data(GObject.Object @object, string key);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_get_qdata(GObject.Object @object, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_getv(GObject.Object @object, uint n_properties, System.IntPtr names, System.IntPtr values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_object_is_floating(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_notify(GObject.Object @object, string property_name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_notify_by_pspec(GObject.Object @object, GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_object_ref(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_object_ref_sink(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_remove_toggle_ref(GObject.Object @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_remove_weak_pointer(GObject.Object @object, ref System.IntPtr weak_pointer_location);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_object_replace_data(GObject.Object @object, string key, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_object_replace_qdata(GObject.Object @object, uint quark, System.IntPtr oldval, System.IntPtr newval, System.IntPtr destroy, System.IntPtr old_destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_run_dispose(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_data(GObject.Object @object, string key, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_data_full(GObject.Object @object, string key, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_qdata(GObject.Object @object, uint quark, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_set_qdata_full(GObject.Object @object, uint quark, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_setv(GObject.Object @object, uint n_properties, System.IntPtr names, System.IntPtr values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_steal_data(GObject.Object @object, string key);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_steal_qdata(GObject.Object @object, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_thaw_notify(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_unref(GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_watch_closure(GObject.Object @object, GObject.Closure closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_weak_ref(GObject.Object @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_weak_unref(GObject.Object @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_register_transform_func(GLib.GType src_type, GLib.GType dest_type, System.IntPtr transform_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_value_type_compatible(GLib.GType src_type, GLib.GType dest_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_value_type_transformable(GLib.GType src_type, GLib.GType dest_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_closure_new_object(uint sizeof_closure, GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_closure_new_simple(uint sizeof_closure, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_add_finalize_notifier(GObject.Closure closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_add_invalidate_notifier(GObject.Closure closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_add_marshal_guards(GObject.Closure closure, System.IntPtr pre_marshal_data, System.IntPtr pre_marshal_notify, System.IntPtr post_marshal_data, System.IntPtr post_marshal_notify);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_invalidate(GObject.Closure closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_closure_ref(GObject.Closure closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_remove_finalize_notifier(GObject.Closure closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_remove_invalidate_notifier(GObject.Closure closure, System.IntPtr notify_data, System.IntPtr notify_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_set_marshal(GObject.Closure closure, System.IntPtr marshal);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_set_meta_marshal(GObject.Closure closure, System.IntPtr marshal_data, System.IntPtr meta_marshal);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_sink(GObject.Closure closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_closure_unref(GObject.Closure closure);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_instance_get_private(GObject.TypeInstance instance, GLib.GType private_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_cclosure_new(System.IntPtr callback_func, System.IntPtr user_data, System.IntPtr destroy_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_cclosure_new_object(System.IntPtr callback_func, GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_cclosure_new_object_swap(System.IntPtr callback_func, GObject.Object @object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Closure g_cclosure_new_swap(System.IntPtr callback_func, System.IntPtr user_data, System.IntPtr destroy_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_internal(GLib.GType param_type, string name, string nick, string blurb, GObject.ParamFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_param_spec_get_blurb(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_param_spec_get_name(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_param_spec_get_name_quark(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_param_spec_get_nick(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_get_qdata(GObject.ParamSpec pspec, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_get_redirect_target(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_ref(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_ref_sink(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_set_qdata(GObject.ParamSpec pspec, uint quark, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_set_qdata_full(GObject.ParamSpec pspec, uint quark, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_sink(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_steal_qdata(GObject.ParamSpec pspec, uint quark);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_unref(GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeInterface g_type_interface_peek_parent(GObject.TypeInterface g_iface);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_interface_add_prerequisite(GLib.GType interface_type, GLib.GType prerequisite_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypePlugin g_type_interface_get_plugin(GLib.GType instance_type, GLib.GType interface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeInterface g_type_interface_peek(GObject.TypeClass instance_class, GLib.GType iface_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_interface_prerequisites(GLib.GType interface_type, out uint n_prerequisites);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_object_class_find_property(GObject.ObjectClass oclass, string property_name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_install_properties(GObject.ObjectClass oclass, uint n_pspecs, System.IntPtr pspecs);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_install_property(GObject.ObjectClass oclass, uint property_id, GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_class_list_properties(GObject.ObjectClass oclass, out uint n_properties);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_override_property(GObject.ObjectClass oclass, uint property_id, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_pool_insert(GObject.ParamSpecPool pool, GObject.ParamSpec pspec, GLib.GType owner_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pool_list(GObject.ParamSpecPool pool, GLib.GType owner_type, out uint n_pspecs_p);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pool_list_owned(GObject.ParamSpecPool pool, GLib.GType owner_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_param_spec_pool_lookup(GObject.ParamSpecPool pool, string param_name, GLib.GType owner_type, bool walk_ancestors);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_pool_remove(GObject.ParamSpecPool pool, GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpecPool g_param_spec_pool_new(bool type_prefixing);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.TypeValueTable g_type_value_table_peek(GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_plugin_complete_interface_info(GObject.TypePlugin plugin, GLib.GType instance_type, GLib.GType interface_type, GObject.InterfaceInfo info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_plugin_unuse(GObject.TypePlugin plugin);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_plugin_use(GObject.TypePlugin plugin);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_add_interface(GObject.TypeModule module, GLib.GType instance_type, GLib.GType interface_type, GObject.InterfaceInfo interface_info);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_module_register_enum(GObject.TypeModule module, string name, GObject.EnumValue const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_module_register_flags(GObject.TypeModule module, string name, GObject.FlagsValue const_static_values);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_set_name(GObject.TypeModule module, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_unuse(GObject.TypeModule module);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_module_use(GObject.TypeModule module);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_new(uint n_prealloced);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_copy(GObject.ValueArray value_array);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_array_free(GObject.ValueArray value_array);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_remove(GObject.ValueArray value_array, uint index_);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_sort(GObject.ValueArray value_array, System.IntPtr compare_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_sort_with_data(GObject.ValueArray value_array, System.IntPtr compare_func, System.IntPtr user_data);
	}
}
