using System;
using System.Runtime.InteropServices;
namespace Atk {
	public ref struct Action
	{
		private IntPtr _pointer;
		public Action(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Action(IntPtr pointer) => new Action(pointer, checkType: true);
		public static explicit operator IntPtr(Action value) => value._pointer;
		public bool do_action(int i) => Atk.AtkInterop.atk_action_do_action(this, i);
		public string get_description(int i) => Atk.AtkInterop.atk_action_get_description(this, i);
		public string get_keybinding(int i) => Atk.AtkInterop.atk_action_get_keybinding(this, i);
		public string get_localized_name(int i) => Atk.AtkInterop.atk_action_get_localized_name(this, i);
		public int get_n_actions() => Atk.AtkInterop.atk_action_get_n_actions(this);
		public string get_name(int i) => Atk.AtkInterop.atk_action_get_name(this, i);
		public bool set_description(int i, string desc) => Atk.AtkInterop.atk_action_set_description(this, i, desc);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_action_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ActionIface
	{
		private IntPtr _pointer;
		public ActionIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ActionIface(IntPtr pointer) => new ActionIface(pointer, checkType: true);
		public static explicit operator IntPtr(ActionIface value) => value._pointer;
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
		public static void set_free(GLib.SList attrib_set) => AtkInterop.atk_attribute_set_free(attrib_set);
	}
	public ref struct Component
	{
		private IntPtr _pointer;
		public Component(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Component(IntPtr pointer) => new Component(pointer, checkType: true);
		public static explicit operator IntPtr(Component value) => value._pointer;
		public uint add_focus_handler(System.IntPtr handler) => Atk.AtkInterop.atk_component_add_focus_handler(this, handler);
		public bool contains(int x, int y, Atk.CoordType coord_type) => Atk.AtkInterop.atk_component_contains(this, x, y, coord_type);
		public double get_alpha() => Atk.AtkInterop.atk_component_get_alpha(this);
		public void get_extents(out int x, out int y, out int width, out int height, Atk.CoordType coord_type) => Atk.AtkInterop.atk_component_get_extents(this, out x, out y, out width, out height, coord_type);
		public Atk.Layer get_layer() => Atk.AtkInterop.atk_component_get_layer(this);
		public int get_mdi_zorder() => Atk.AtkInterop.atk_component_get_mdi_zorder(this);
		public void get_position(out int x, out int y, Atk.CoordType coord_type) => Atk.AtkInterop.atk_component_get_position(this, out x, out y, coord_type);
		public void get_size(out int width, out int height) => Atk.AtkInterop.atk_component_get_size(this, out width, out height);
		public bool grab_focus() => Atk.AtkInterop.atk_component_grab_focus(this);
		public Atk.Object ref_accessible_at_point(int x, int y, Atk.CoordType coord_type) => Atk.AtkInterop.atk_component_ref_accessible_at_point(this, x, y, coord_type);
		public void remove_focus_handler(uint handler_id) => Atk.AtkInterop.atk_component_remove_focus_handler(this, handler_id);
		public bool set_extents(int x, int y, int width, int height, Atk.CoordType coord_type) => Atk.AtkInterop.atk_component_set_extents(this, x, y, width, height, coord_type);
		public bool set_position(int x, int y, Atk.CoordType coord_type) => Atk.AtkInterop.atk_component_set_position(this, x, y, coord_type);
		public bool set_size(int width, int height) => Atk.AtkInterop.atk_component_set_size(this, width, height);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_component_get_type")]
		public static extern GLib.GType TypeOf();
	}
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
		public static implicit operator GObject.Object(Object value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Object(GObject.Object value) => new Object((IntPtr)value, checkType: true);
		public bool add_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_add_relationship(this, relationship, target);
		public uint connect_property_change_handler(System.IntPtr handler) => Atk.AtkInterop.atk_object_connect_property_change_handler(this, handler);
		public GLib.SList get_attributes() => Atk.AtkInterop.atk_object_get_attributes(this);
		public string get_description() => Atk.AtkInterop.atk_object_get_description(this);
		public int get_index_in_parent() => Atk.AtkInterop.atk_object_get_index_in_parent(this);
		public Atk.Layer get_layer() => Atk.AtkInterop.atk_object_get_layer(this);
		public int get_mdi_zorder() => Atk.AtkInterop.atk_object_get_mdi_zorder(this);
		public int get_n_accessible_children() => Atk.AtkInterop.atk_object_get_n_accessible_children(this);
		public string get_name() => Atk.AtkInterop.atk_object_get_name(this);
		public string get_object_locale() => Atk.AtkInterop.atk_object_get_object_locale(this);
		public Atk.Object get_parent() => Atk.AtkInterop.atk_object_get_parent(this);
		public Atk.Role get_role() => Atk.AtkInterop.atk_object_get_role(this);
		public void initialize(System.IntPtr data) => Atk.AtkInterop.atk_object_initialize(this, data);
		public void notify_state_change(ulong state, bool value) => Atk.AtkInterop.atk_object_notify_state_change(this, state, value);
		public Atk.Object peek_parent() => Atk.AtkInterop.atk_object_peek_parent(this);
		public Atk.Object ref_accessible_child(int i) => Atk.AtkInterop.atk_object_ref_accessible_child(this, i);
		public Atk.RelationSet ref_relation_set() => Atk.AtkInterop.atk_object_ref_relation_set(this);
		public Atk.StateSet ref_state_set() => Atk.AtkInterop.atk_object_ref_state_set(this);
		public void remove_property_change_handler(uint handler_id) => Atk.AtkInterop.atk_object_remove_property_change_handler(this, handler_id);
		public bool remove_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_remove_relationship(this, relationship, target);
		public void set_description(string description) => Atk.AtkInterop.atk_object_set_description(this, description);
		public void set_name(string name) => Atk.AtkInterop.atk_object_set_name(this, name);
		public void set_parent(Atk.Object parent) => Atk.AtkInterop.atk_object_set_parent(this, parent);
		public void set_role(Atk.Role role) => Atk.AtkInterop.atk_object_set_role(this, role);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_object_get_type")]
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_rectangle_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ComponentIface
	{
		private IntPtr _pointer;
		public ComponentIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ComponentIface(IntPtr pointer) => new ComponentIface(pointer, checkType: true);
		public static explicit operator IntPtr(ComponentIface value) => value._pointer;
	}
	public ref struct Document
	{
		private IntPtr _pointer;
		public Document(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Document(IntPtr pointer) => new Document(pointer, checkType: true);
		public static explicit operator IntPtr(Document value) => value._pointer;
		public string get_attribute_value(string attribute_name) => Atk.AtkInterop.atk_document_get_attribute_value(this, attribute_name);
		public GLib.SList get_attributes() => Atk.AtkInterop.atk_document_get_attributes(this);
		public int get_current_page_number() => Atk.AtkInterop.atk_document_get_current_page_number(this);
		public System.IntPtr get_document() => Atk.AtkInterop.atk_document_get_document(this);
		public string get_document_type() => Atk.AtkInterop.atk_document_get_document_type(this);
		public string get_locale() => Atk.AtkInterop.atk_document_get_locale(this);
		public int get_page_count() => Atk.AtkInterop.atk_document_get_page_count(this);
		public bool set_attribute_value(string attribute_name, string attribute_value) => Atk.AtkInterop.atk_document_set_attribute_value(this, attribute_name, attribute_value);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_document_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct DocumentIface
	{
		private IntPtr _pointer;
		public DocumentIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator DocumentIface(IntPtr pointer) => new DocumentIface(pointer, checkType: true);
		public static explicit operator IntPtr(DocumentIface value) => value._pointer;
	}
	public ref struct EditableText
	{
		private IntPtr _pointer;
		public EditableText(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EditableText(IntPtr pointer) => new EditableText(pointer, checkType: true);
		public static explicit operator IntPtr(EditableText value) => value._pointer;
		public void copy_text(int start_pos, int end_pos) => Atk.AtkInterop.atk_editable_text_copy_text(this, start_pos, end_pos);
		public void cut_text(int start_pos, int end_pos) => Atk.AtkInterop.atk_editable_text_cut_text(this, start_pos, end_pos);
		public void delete_text(int start_pos, int end_pos) => Atk.AtkInterop.atk_editable_text_delete_text(this, start_pos, end_pos);
		public void insert_text(string @string, int length, int position) => Atk.AtkInterop.atk_editable_text_insert_text(this, @string, length, position);
		public void paste_text(int position) => Atk.AtkInterop.atk_editable_text_paste_text(this, position);
		public bool set_run_attributes(GLib.SList attrib_set, int start_offset, int end_offset) => Atk.AtkInterop.atk_editable_text_set_run_attributes(this, attrib_set, start_offset, end_offset);
		public void set_text_contents(string @string) => Atk.AtkInterop.atk_editable_text_set_text_contents(this, @string);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_editable_text_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct EditableTextIface
	{
		private IntPtr _pointer;
		public EditableTextIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator EditableTextIface(IntPtr pointer) => new EditableTextIface(pointer, checkType: true);
		public static explicit operator IntPtr(EditableTextIface value) => value._pointer;
	}
	public ref struct GObjectAccessible
	{
		private IntPtr _pointer;
		public GObjectAccessible(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator GObjectAccessible(IntPtr pointer) => new GObjectAccessible(pointer, checkType: true);
		public static explicit operator IntPtr(GObjectAccessible value) => value._pointer;
		public static implicit operator Atk.Object(GObjectAccessible value) => new Atk.Object((IntPtr)value, checkType: false);
		public static explicit operator GObjectAccessible(Atk.Object value) => new GObjectAccessible((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(GObjectAccessible value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator GObjectAccessible(GObject.Object value) => new GObjectAccessible((IntPtr)value, checkType: true);
		public static Atk.Object for_object(GObject.Object obj) => AtkInterop.atk_gobject_accessible_for_object(obj);
		public GObject.Object get_object() => Atk.AtkInterop.atk_gobject_accessible_get_object(this);
		public bool add_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_add_relationship(this, relationship, target);
		public uint connect_property_change_handler(System.IntPtr handler) => Atk.AtkInterop.atk_object_connect_property_change_handler(this, handler);
		public GLib.SList get_attributes() => Atk.AtkInterop.atk_object_get_attributes(this);
		public string get_description() => Atk.AtkInterop.atk_object_get_description(this);
		public int get_index_in_parent() => Atk.AtkInterop.atk_object_get_index_in_parent(this);
		public Atk.Layer get_layer() => Atk.AtkInterop.atk_object_get_layer(this);
		public int get_mdi_zorder() => Atk.AtkInterop.atk_object_get_mdi_zorder(this);
		public int get_n_accessible_children() => Atk.AtkInterop.atk_object_get_n_accessible_children(this);
		public string get_name() => Atk.AtkInterop.atk_object_get_name(this);
		public string get_object_locale() => Atk.AtkInterop.atk_object_get_object_locale(this);
		public Atk.Object get_parent() => Atk.AtkInterop.atk_object_get_parent(this);
		public Atk.Role get_role() => Atk.AtkInterop.atk_object_get_role(this);
		public void initialize(System.IntPtr data) => Atk.AtkInterop.atk_object_initialize(this, data);
		public void notify_state_change(ulong state, bool value) => Atk.AtkInterop.atk_object_notify_state_change(this, state, value);
		public Atk.Object peek_parent() => Atk.AtkInterop.atk_object_peek_parent(this);
		public Atk.Object ref_accessible_child(int i) => Atk.AtkInterop.atk_object_ref_accessible_child(this, i);
		public Atk.RelationSet ref_relation_set() => Atk.AtkInterop.atk_object_ref_relation_set(this);
		public Atk.StateSet ref_state_set() => Atk.AtkInterop.atk_object_ref_state_set(this);
		public void remove_property_change_handler(uint handler_id) => Atk.AtkInterop.atk_object_remove_property_change_handler(this, handler_id);
		public bool remove_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_remove_relationship(this, relationship, target);
		public void set_description(string description) => Atk.AtkInterop.atk_object_set_description(this, description);
		public void set_name(string name) => Atk.AtkInterop.atk_object_set_name(this, name);
		public void set_parent(Atk.Object parent) => Atk.AtkInterop.atk_object_set_parent(this, parent);
		public void set_role(Atk.Role role) => Atk.AtkInterop.atk_object_set_role(this, role);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_gobject_accessible_get_type")]
		public static extern GLib.GType TypeOf();
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
	}
	public ref struct GObjectAccessibleClass
	{
		private IntPtr _pointer;
		public GObjectAccessibleClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator GObjectAccessibleClass(IntPtr pointer) => new GObjectAccessibleClass(pointer, checkType: true);
		public static explicit operator IntPtr(GObjectAccessibleClass value) => value._pointer;
	}
	public ref struct Hyperlink
	{
		private IntPtr _pointer;
		public Hyperlink(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Hyperlink(IntPtr pointer) => new Hyperlink(pointer, checkType: true);
		public static explicit operator IntPtr(Hyperlink value) => value._pointer;
		public static implicit operator GObject.Object(Hyperlink value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Hyperlink(GObject.Object value) => new Hyperlink((IntPtr)value, checkType: true);
		public int get_end_index() => Atk.AtkInterop.atk_hyperlink_get_end_index(this);
		public int get_n_anchors() => Atk.AtkInterop.atk_hyperlink_get_n_anchors(this);
		public Atk.Object get_object(int i) => Atk.AtkInterop.atk_hyperlink_get_object(this, i);
		public int get_start_index() => Atk.AtkInterop.atk_hyperlink_get_start_index(this);
		public string get_uri(int i) => Atk.AtkInterop.atk_hyperlink_get_uri(this, i);
		public bool is_inline() => Atk.AtkInterop.atk_hyperlink_is_inline(this);
		public bool is_selected_link() => Atk.AtkInterop.atk_hyperlink_is_selected_link(this);
		public bool is_valid() => Atk.AtkInterop.atk_hyperlink_is_valid(this);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_hyperlink_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct HyperlinkClass
	{
		private IntPtr _pointer;
		public HyperlinkClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator HyperlinkClass(IntPtr pointer) => new HyperlinkClass(pointer, checkType: true);
		public static explicit operator IntPtr(HyperlinkClass value) => value._pointer;
	}
	public ref struct HyperlinkImpl
	{
		private IntPtr _pointer;
		public HyperlinkImpl(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator HyperlinkImpl(IntPtr pointer) => new HyperlinkImpl(pointer, checkType: true);
		public static explicit operator IntPtr(HyperlinkImpl value) => value._pointer;
		public Atk.Hyperlink get_hyperlink() => Atk.AtkInterop.atk_hyperlink_impl_get_hyperlink(this);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_hyperlink_impl_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct HyperlinkImplIface
	{
		private IntPtr _pointer;
		public HyperlinkImplIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator HyperlinkImplIface(IntPtr pointer) => new HyperlinkImplIface(pointer, checkType: true);
		public static explicit operator IntPtr(HyperlinkImplIface value) => value._pointer;
	}
	[Flags]
	public enum HyperlinkStateFlags
	{
		inline = 1,
	}
	public ref struct Hypertext
	{
		private IntPtr _pointer;
		public Hypertext(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Hypertext(IntPtr pointer) => new Hypertext(pointer, checkType: true);
		public static explicit operator IntPtr(Hypertext value) => value._pointer;
		public Atk.Hyperlink get_link(int link_index) => Atk.AtkInterop.atk_hypertext_get_link(this, link_index);
		public int get_link_index(int char_index) => Atk.AtkInterop.atk_hypertext_get_link_index(this, char_index);
		public int get_n_links() => Atk.AtkInterop.atk_hypertext_get_n_links(this);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_hypertext_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct HypertextIface
	{
		private IntPtr _pointer;
		public HypertextIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator HypertextIface(IntPtr pointer) => new HypertextIface(pointer, checkType: true);
		public static explicit operator IntPtr(HypertextIface value) => value._pointer;
	}
	public ref struct Image
	{
		private IntPtr _pointer;
		public Image(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Image(IntPtr pointer) => new Image(pointer, checkType: true);
		public static explicit operator IntPtr(Image value) => value._pointer;
		public string get_image_description() => Atk.AtkInterop.atk_image_get_image_description(this);
		public string get_image_locale() => Atk.AtkInterop.atk_image_get_image_locale(this);
		public void get_image_position(out int x, out int y, Atk.CoordType coord_type) => Atk.AtkInterop.atk_image_get_image_position(this, out x, out y, coord_type);
		public void get_image_size(out int width, out int height) => Atk.AtkInterop.atk_image_get_image_size(this, out width, out height);
		public bool set_image_description(string description) => Atk.AtkInterop.atk_image_set_image_description(this, description);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_image_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ImageIface
	{
		private IntPtr _pointer;
		public ImageIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ImageIface(IntPtr pointer) => new ImageIface(pointer, checkType: true);
		public static explicit operator IntPtr(ImageIface value) => value._pointer;
	}
	public ref struct Implementor
	{
		private IntPtr _pointer;
		public Implementor(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Implementor(IntPtr pointer) => new Implementor(pointer, checkType: true);
		public static explicit operator IntPtr(Implementor value) => value._pointer;
		public Atk.Object ref_accessible() => Atk.AtkInterop.atk_implementor_ref_accessible(this);
	}
	public ref struct ImplementorIface
	{
		private IntPtr _pointer;
		public ImplementorIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ImplementorIface(IntPtr pointer) => new ImplementorIface(pointer, checkType: true);
		public static explicit operator IntPtr(ImplementorIface value) => value._pointer;
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_implementor_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct KeyEventStruct
	{
		private IntPtr _pointer;
		public KeyEventStruct(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator KeyEventStruct(IntPtr pointer) => new KeyEventStruct(pointer, checkType: true);
		public static explicit operator IntPtr(KeyEventStruct value) => value._pointer;
	}
	public enum KeyEventType
	{
		press = 0,
		release = 1,
		last_defined = 2,
	}
	public ref struct Misc
	{
		private IntPtr _pointer;
		public Misc(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Misc(IntPtr pointer) => new Misc(pointer, checkType: true);
		public static explicit operator IntPtr(Misc value) => value._pointer;
		public static implicit operator GObject.Object(Misc value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Misc(GObject.Object value) => new Misc((IntPtr)value, checkType: true);
		public static Atk.Misc get_instance() => AtkInterop.atk_misc_get_instance();
		public void threads_enter() => Atk.AtkInterop.atk_misc_threads_enter(this);
		public void threads_leave() => Atk.AtkInterop.atk_misc_threads_leave(this);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_misc_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct MiscClass
	{
		private IntPtr _pointer;
		public MiscClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MiscClass(IntPtr pointer) => new MiscClass(pointer, checkType: true);
		public static explicit operator IntPtr(MiscClass value) => value._pointer;
	}
	public ref struct Selection
	{
		private IntPtr _pointer;
		public Selection(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Selection(IntPtr pointer) => new Selection(pointer, checkType: true);
		public static explicit operator IntPtr(Selection value) => value._pointer;
		public bool add_selection(int i) => Atk.AtkInterop.atk_selection_add_selection(this, i);
		public bool clear_selection() => Atk.AtkInterop.atk_selection_clear_selection(this);
		public int get_selection_count() => Atk.AtkInterop.atk_selection_get_selection_count(this);
		public bool is_child_selected(int i) => Atk.AtkInterop.atk_selection_is_child_selected(this, i);
		public Atk.Object ref_selection(int i) => Atk.AtkInterop.atk_selection_ref_selection(this, i);
		public bool remove_selection(int i) => Atk.AtkInterop.atk_selection_remove_selection(this, i);
		public bool select_all_selection() => Atk.AtkInterop.atk_selection_select_all_selection(this);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_selection_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Table
	{
		private IntPtr _pointer;
		public Table(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Table(IntPtr pointer) => new Table(pointer, checkType: true);
		public static explicit operator IntPtr(Table value) => value._pointer;
		public bool add_column_selection(int column) => Atk.AtkInterop.atk_table_add_column_selection(this, column);
		public bool add_row_selection(int row) => Atk.AtkInterop.atk_table_add_row_selection(this, row);
		public Atk.Object get_caption() => Atk.AtkInterop.atk_table_get_caption(this);
		public int get_column_at_index(int index_) => Atk.AtkInterop.atk_table_get_column_at_index(this, index_);
		public string get_column_description(int column) => Atk.AtkInterop.atk_table_get_column_description(this, column);
		public int get_column_extent_at(int row, int column) => Atk.AtkInterop.atk_table_get_column_extent_at(this, row, column);
		public Atk.Object get_column_header(int column) => Atk.AtkInterop.atk_table_get_column_header(this, column);
		public int get_index_at(int row, int column) => Atk.AtkInterop.atk_table_get_index_at(this, row, column);
		public int get_n_columns() => Atk.AtkInterop.atk_table_get_n_columns(this);
		public int get_n_rows() => Atk.AtkInterop.atk_table_get_n_rows(this);
		public int get_row_at_index(int index_) => Atk.AtkInterop.atk_table_get_row_at_index(this, index_);
		public string get_row_description(int row) => Atk.AtkInterop.atk_table_get_row_description(this, row);
		public int get_row_extent_at(int row, int column) => Atk.AtkInterop.atk_table_get_row_extent_at(this, row, column);
		public Atk.Object get_row_header(int row) => Atk.AtkInterop.atk_table_get_row_header(this, row);
		public Atk.Object get_summary() => Atk.AtkInterop.atk_table_get_summary(this);
		public bool is_column_selected(int column) => Atk.AtkInterop.atk_table_is_column_selected(this, column);
		public bool is_row_selected(int row) => Atk.AtkInterop.atk_table_is_row_selected(this, row);
		public bool is_selected(int row, int column) => Atk.AtkInterop.atk_table_is_selected(this, row, column);
		public Atk.Object ref_at(int row, int column) => Atk.AtkInterop.atk_table_ref_at(this, row, column);
		public bool remove_column_selection(int column) => Atk.AtkInterop.atk_table_remove_column_selection(this, column);
		public bool remove_row_selection(int row) => Atk.AtkInterop.atk_table_remove_row_selection(this, row);
		public void set_caption(Atk.Object caption) => Atk.AtkInterop.atk_table_set_caption(this, caption);
		public void set_column_description(int column, string description) => Atk.AtkInterop.atk_table_set_column_description(this, column, description);
		public void set_column_header(int column, Atk.Object header) => Atk.AtkInterop.atk_table_set_column_header(this, column, header);
		public void set_row_description(int row, string description) => Atk.AtkInterop.atk_table_set_row_description(this, row, description);
		public void set_row_header(int row, Atk.Object header) => Atk.AtkInterop.atk_table_set_row_header(this, row, header);
		public void set_summary(Atk.Object accessible) => Atk.AtkInterop.atk_table_set_summary(this, accessible);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_table_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct TableCell
	{
		private IntPtr _pointer;
		public TableCell(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TableCell(IntPtr pointer) => new TableCell(pointer, checkType: true);
		public static explicit operator IntPtr(TableCell value) => value._pointer;
		public System.IntPtr get_column_header_cells() => Atk.AtkInterop.atk_table_cell_get_column_header_cells(this);
		public int get_column_span() => Atk.AtkInterop.atk_table_cell_get_column_span(this);
		public bool get_position(out int row, out int column) => Atk.AtkInterop.atk_table_cell_get_position(this, out row, out column);
		public bool get_row_column_span(out int row, out int column, out int row_span, out int column_span) => Atk.AtkInterop.atk_table_cell_get_row_column_span(this, out row, out column, out row_span, out column_span);
		public System.IntPtr get_row_header_cells() => Atk.AtkInterop.atk_table_cell_get_row_header_cells(this);
		public int get_row_span() => Atk.AtkInterop.atk_table_cell_get_row_span(this);
		public Atk.Object get_table() => Atk.AtkInterop.atk_table_cell_get_table(this);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_table_cell_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Text
	{
		private IntPtr _pointer;
		public Text(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Text(IntPtr pointer) => new Text(pointer, checkType: true);
		public static explicit operator IntPtr(Text value) => value._pointer;
		public static void free_ranges(System.IntPtr ranges) => AtkInterop.atk_text_free_ranges(ranges);
		public bool add_selection(int start_offset, int end_offset) => Atk.AtkInterop.atk_text_add_selection(this, start_offset, end_offset);
		public int get_caret_offset() => Atk.AtkInterop.atk_text_get_caret_offset(this);
		public uint get_character_at_offset(int offset) => Atk.AtkInterop.atk_text_get_character_at_offset(this, offset);
		public int get_character_count() => Atk.AtkInterop.atk_text_get_character_count(this);
		public void get_character_extents(int offset, out int x, out int y, out int width, out int height, Atk.CoordType coords) => Atk.AtkInterop.atk_text_get_character_extents(this, offset, out x, out y, out width, out height, coords);
		public GLib.SList get_default_attributes() => Atk.AtkInterop.atk_text_get_default_attributes(this);
		public int get_n_selections() => Atk.AtkInterop.atk_text_get_n_selections(this);
		public int get_offset_at_point(int x, int y, Atk.CoordType coords) => Atk.AtkInterop.atk_text_get_offset_at_point(this, x, y, coords);
		public GLib.SList get_run_attributes(int offset, out int start_offset, out int end_offset) => Atk.AtkInterop.atk_text_get_run_attributes(this, offset, out start_offset, out end_offset);
		public string get_selection(int selection_num, out int start_offset, out int end_offset) => Atk.AtkInterop.atk_text_get_selection(this, selection_num, out start_offset, out end_offset);
		public string get_string_at_offset(int offset, Atk.TextGranularity granularity, out int start_offset, out int end_offset) => Atk.AtkInterop.atk_text_get_string_at_offset(this, offset, granularity, out start_offset, out end_offset);
		public string get_text(int start_offset, int end_offset) => Atk.AtkInterop.atk_text_get_text(this, start_offset, end_offset);
		public string get_text_after_offset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset) => Atk.AtkInterop.atk_text_get_text_after_offset(this, offset, boundary_type, out start_offset, out end_offset);
		public string get_text_at_offset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset) => Atk.AtkInterop.atk_text_get_text_at_offset(this, offset, boundary_type, out start_offset, out end_offset);
		public string get_text_before_offset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset) => Atk.AtkInterop.atk_text_get_text_before_offset(this, offset, boundary_type, out start_offset, out end_offset);
		public bool remove_selection(int selection_num) => Atk.AtkInterop.atk_text_remove_selection(this, selection_num);
		public bool set_caret_offset(int offset) => Atk.AtkInterop.atk_text_set_caret_offset(this, offset);
		public bool set_selection(int selection_num, int start_offset, int end_offset) => Atk.AtkInterop.atk_text_set_selection(this, selection_num, start_offset, end_offset);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_text_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Value
	{
		private IntPtr _pointer;
		public Value(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Value(IntPtr pointer) => new Value(pointer, checkType: true);
		public static explicit operator IntPtr(Value value) => value._pointer;
		public double get_increment() => Atk.AtkInterop.atk_value_get_increment(this);
		public Atk.Range get_range() => Atk.AtkInterop.atk_value_get_range(this);
		public System.IntPtr get_sub_ranges() => Atk.AtkInterop.atk_value_get_sub_ranges(this);
		public void get_value_and_text(out double value, out string text) => Atk.AtkInterop.atk_value_get_value_and_text(this, out value, out text);
		public void set_value(double new_value) => Atk.AtkInterop.atk_value_set_value(this, new_value);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_value_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Window
	{
		private IntPtr _pointer;
		public Window(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Window(IntPtr pointer) => new Window(pointer, checkType: true);
		public static explicit operator IntPtr(Window value) => value._pointer;
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_window_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct NoOpObject
	{
		private IntPtr _pointer;
		public NoOpObject(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator NoOpObject(IntPtr pointer) => new NoOpObject(pointer, checkType: true);
		public static explicit operator IntPtr(NoOpObject value) => value._pointer;
		public static implicit operator Atk.Object(NoOpObject value) => new Atk.Object((IntPtr)value, checkType: false);
		public static explicit operator NoOpObject(Atk.Object value) => new NoOpObject((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(NoOpObject value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator NoOpObject(GObject.Object value) => new NoOpObject((IntPtr)value, checkType: true);
		public static Atk.Object @new(GObject.Object obj) => AtkInterop.atk_no_op_object_new(obj);
		public bool add_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_add_relationship(this, relationship, target);
		public uint connect_property_change_handler(System.IntPtr handler) => Atk.AtkInterop.atk_object_connect_property_change_handler(this, handler);
		public GLib.SList get_attributes() => Atk.AtkInterop.atk_object_get_attributes(this);
		public string get_description() => Atk.AtkInterop.atk_object_get_description(this);
		public int get_index_in_parent() => Atk.AtkInterop.atk_object_get_index_in_parent(this);
		public Atk.Layer get_layer() => Atk.AtkInterop.atk_object_get_layer(this);
		public int get_mdi_zorder() => Atk.AtkInterop.atk_object_get_mdi_zorder(this);
		public int get_n_accessible_children() => Atk.AtkInterop.atk_object_get_n_accessible_children(this);
		public string get_name() => Atk.AtkInterop.atk_object_get_name(this);
		public string get_object_locale() => Atk.AtkInterop.atk_object_get_object_locale(this);
		public Atk.Object get_parent() => Atk.AtkInterop.atk_object_get_parent(this);
		public Atk.Role get_role() => Atk.AtkInterop.atk_object_get_role(this);
		public void initialize(System.IntPtr data) => Atk.AtkInterop.atk_object_initialize(this, data);
		public void notify_state_change(ulong state, bool value) => Atk.AtkInterop.atk_object_notify_state_change(this, state, value);
		public Atk.Object peek_parent() => Atk.AtkInterop.atk_object_peek_parent(this);
		public Atk.Object ref_accessible_child(int i) => Atk.AtkInterop.atk_object_ref_accessible_child(this, i);
		public Atk.RelationSet ref_relation_set() => Atk.AtkInterop.atk_object_ref_relation_set(this);
		public Atk.StateSet ref_state_set() => Atk.AtkInterop.atk_object_ref_state_set(this);
		public void remove_property_change_handler(uint handler_id) => Atk.AtkInterop.atk_object_remove_property_change_handler(this, handler_id);
		public bool remove_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_remove_relationship(this, relationship, target);
		public void set_description(string description) => Atk.AtkInterop.atk_object_set_description(this, description);
		public void set_name(string name) => Atk.AtkInterop.atk_object_set_name(this, name);
		public void set_parent(Atk.Object parent) => Atk.AtkInterop.atk_object_set_parent(this, parent);
		public void set_role(Atk.Role role) => Atk.AtkInterop.atk_object_set_role(this, role);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_no_op_object_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct NoOpObjectClass
	{
		private IntPtr _pointer;
		public NoOpObjectClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator NoOpObjectClass(IntPtr pointer) => new NoOpObjectClass(pointer, checkType: true);
		public static explicit operator IntPtr(NoOpObjectClass value) => value._pointer;
	}
	public ref struct ObjectFactory
	{
		private IntPtr _pointer;
		public ObjectFactory(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator ObjectFactory(IntPtr pointer) => new ObjectFactory(pointer, checkType: true);
		public static explicit operator IntPtr(ObjectFactory value) => value._pointer;
		public static implicit operator GObject.Object(ObjectFactory value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator ObjectFactory(GObject.Object value) => new ObjectFactory((IntPtr)value, checkType: true);
		public Atk.Object create_accessible(GObject.Object obj) => Atk.AtkInterop.atk_object_factory_create_accessible(this, obj);
		public GLib.GType get_accessible_type() => Atk.AtkInterop.atk_object_factory_get_accessible_type(this);
		public void invalidate() => Atk.AtkInterop.atk_object_factory_invalidate(this);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_object_factory_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct NoOpObjectFactory
	{
		private IntPtr _pointer;
		public NoOpObjectFactory(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator NoOpObjectFactory(IntPtr pointer) => new NoOpObjectFactory(pointer, checkType: true);
		public static explicit operator IntPtr(NoOpObjectFactory value) => value._pointer;
		public static implicit operator Atk.ObjectFactory(NoOpObjectFactory value) => new Atk.ObjectFactory((IntPtr)value, checkType: false);
		public static explicit operator NoOpObjectFactory(Atk.ObjectFactory value) => new NoOpObjectFactory((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(NoOpObjectFactory value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator NoOpObjectFactory(GObject.Object value) => new NoOpObjectFactory((IntPtr)value, checkType: true);
		public static Atk.ObjectFactory @new() => AtkInterop.atk_no_op_object_factory_new();
		public Atk.Object create_accessible(GObject.Object obj) => Atk.AtkInterop.atk_object_factory_create_accessible(this, obj);
		public GLib.GType get_accessible_type() => Atk.AtkInterop.atk_object_factory_get_accessible_type(this);
		public void invalidate() => Atk.AtkInterop.atk_object_factory_invalidate(this);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_no_op_object_factory_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct ObjectFactoryClass
	{
		private IntPtr _pointer;
		public ObjectFactoryClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ObjectFactoryClass(IntPtr pointer) => new ObjectFactoryClass(pointer, checkType: true);
		public static explicit operator IntPtr(ObjectFactoryClass value) => value._pointer;
	}
	public ref struct NoOpObjectFactoryClass
	{
		private IntPtr _pointer;
		public NoOpObjectFactoryClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator NoOpObjectFactoryClass(IntPtr pointer) => new NoOpObjectFactoryClass(pointer, checkType: true);
		public static explicit operator IntPtr(NoOpObjectFactoryClass value) => value._pointer;
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
	public ref struct RelationSet
	{
		private IntPtr _pointer;
		public RelationSet(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator RelationSet(IntPtr pointer) => new RelationSet(pointer, checkType: true);
		public static explicit operator IntPtr(RelationSet value) => value._pointer;
		public static implicit operator GObject.Object(RelationSet value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator RelationSet(GObject.Object value) => new RelationSet((IntPtr)value, checkType: true);
		public static Atk.RelationSet @new() => AtkInterop.atk_relation_set_new();
		public void add(Atk.Relation relation) => Atk.AtkInterop.atk_relation_set_add(this, relation);
		public void add_relation_by_type(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_relation_set_add_relation_by_type(this, relationship, target);
		public bool contains(Atk.RelationType relationship) => Atk.AtkInterop.atk_relation_set_contains(this, relationship);
		public bool contains_target(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_relation_set_contains_target(this, relationship, target);
		public int get_n_relations() => Atk.AtkInterop.atk_relation_set_get_n_relations(this);
		public Atk.Relation get_relation(int i) => Atk.AtkInterop.atk_relation_set_get_relation(this, i);
		public Atk.Relation get_relation_by_type(Atk.RelationType relationship) => Atk.AtkInterop.atk_relation_set_get_relation_by_type(this, relationship);
		public void remove(Atk.Relation relation) => Atk.AtkInterop.atk_relation_set_remove(this, relation);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_relation_set_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct StateSet
	{
		private IntPtr _pointer;
		public StateSet(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator StateSet(IntPtr pointer) => new StateSet(pointer, checkType: true);
		public static explicit operator IntPtr(StateSet value) => value._pointer;
		public static implicit operator GObject.Object(StateSet value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator StateSet(GObject.Object value) => new StateSet((IntPtr)value, checkType: true);
		public static Atk.StateSet @new() => AtkInterop.atk_state_set_new();
		public bool add_state(Atk.StateType type) => Atk.AtkInterop.atk_state_set_add_state(this, type);
		public void add_states(System.IntPtr types, int n_types) => Atk.AtkInterop.atk_state_set_add_states(this, types, n_types);
		public Atk.StateSet and_sets(Atk.StateSet compare_set) => Atk.AtkInterop.atk_state_set_and_sets(this, compare_set);
		public void clear_states() => Atk.AtkInterop.atk_state_set_clear_states(this);
		public bool contains_state(Atk.StateType type) => Atk.AtkInterop.atk_state_set_contains_state(this, type);
		public bool contains_states(System.IntPtr types, int n_types) => Atk.AtkInterop.atk_state_set_contains_states(this, types, n_types);
		public bool is_empty() => Atk.AtkInterop.atk_state_set_is_empty(this);
		public Atk.StateSet or_sets(Atk.StateSet compare_set) => Atk.AtkInterop.atk_state_set_or_sets(this, compare_set);
		public bool remove_state(Atk.StateType type) => Atk.AtkInterop.atk_state_set_remove_state(this, type);
		public Atk.StateSet xor_sets(Atk.StateSet compare_set) => Atk.AtkInterop.atk_state_set_xor_sets(this, compare_set);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_state_set_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct PropertyValues
	{
		private IntPtr _pointer;
		public PropertyValues(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PropertyValues(IntPtr pointer) => new PropertyValues(pointer, checkType: true);
		public static explicit operator IntPtr(PropertyValues value) => value._pointer;
	}
	public ref struct Plug
	{
		private IntPtr _pointer;
		public Plug(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Plug(IntPtr pointer) => new Plug(pointer, checkType: true);
		public static explicit operator IntPtr(Plug value) => value._pointer;
		public static implicit operator Atk.Object(Plug value) => new Atk.Object((IntPtr)value, checkType: false);
		public static explicit operator Plug(Atk.Object value) => new Plug((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(Plug value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Plug(GObject.Object value) => new Plug((IntPtr)value, checkType: true);
		public static Atk.Object @new() => AtkInterop.atk_plug_new();
		public string get_id() => Atk.AtkInterop.atk_plug_get_id(this);
		public bool add_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_add_relationship(this, relationship, target);
		public uint connect_property_change_handler(System.IntPtr handler) => Atk.AtkInterop.atk_object_connect_property_change_handler(this, handler);
		public GLib.SList get_attributes() => Atk.AtkInterop.atk_object_get_attributes(this);
		public string get_description() => Atk.AtkInterop.atk_object_get_description(this);
		public int get_index_in_parent() => Atk.AtkInterop.atk_object_get_index_in_parent(this);
		public Atk.Layer get_layer() => Atk.AtkInterop.atk_object_get_layer(this);
		public int get_mdi_zorder() => Atk.AtkInterop.atk_object_get_mdi_zorder(this);
		public int get_n_accessible_children() => Atk.AtkInterop.atk_object_get_n_accessible_children(this);
		public string get_name() => Atk.AtkInterop.atk_object_get_name(this);
		public string get_object_locale() => Atk.AtkInterop.atk_object_get_object_locale(this);
		public Atk.Object get_parent() => Atk.AtkInterop.atk_object_get_parent(this);
		public Atk.Role get_role() => Atk.AtkInterop.atk_object_get_role(this);
		public void initialize(System.IntPtr data) => Atk.AtkInterop.atk_object_initialize(this, data);
		public void notify_state_change(ulong state, bool value) => Atk.AtkInterop.atk_object_notify_state_change(this, state, value);
		public Atk.Object peek_parent() => Atk.AtkInterop.atk_object_peek_parent(this);
		public Atk.Object ref_accessible_child(int i) => Atk.AtkInterop.atk_object_ref_accessible_child(this, i);
		public Atk.RelationSet ref_relation_set() => Atk.AtkInterop.atk_object_ref_relation_set(this);
		public Atk.StateSet ref_state_set() => Atk.AtkInterop.atk_object_ref_state_set(this);
		public void remove_property_change_handler(uint handler_id) => Atk.AtkInterop.atk_object_remove_property_change_handler(this, handler_id);
		public bool remove_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_remove_relationship(this, relationship, target);
		public void set_description(string description) => Atk.AtkInterop.atk_object_set_description(this, description);
		public void set_name(string name) => Atk.AtkInterop.atk_object_set_name(this, name);
		public void set_parent(Atk.Object parent) => Atk.AtkInterop.atk_object_set_parent(this, parent);
		public void set_role(Atk.Role role) => Atk.AtkInterop.atk_object_set_role(this, role);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_plug_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct PlugClass
	{
		private IntPtr _pointer;
		public PlugClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PlugClass(IntPtr pointer) => new PlugClass(pointer, checkType: true);
		public static explicit operator IntPtr(PlugClass value) => value._pointer;
	}
	public ref struct Range
	{
		private IntPtr _pointer;
		public Range(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Range(IntPtr pointer) => new Range(pointer, checkType: true);
		public static explicit operator IntPtr(Range value) => value._pointer;
		public static Atk.Range @new(double lower_limit, double upper_limit, string description) => AtkInterop.atk_range_new(lower_limit, upper_limit, description);
		public Atk.Range copy() => Atk.AtkInterop.atk_range_copy(this);
		public void free() => Atk.AtkInterop.atk_range_free(this);
		public string get_description() => Atk.AtkInterop.atk_range_get_description(this);
		public double get_lower_limit() => Atk.AtkInterop.atk_range_get_lower_limit(this);
		public double get_upper_limit() => Atk.AtkInterop.atk_range_get_upper_limit(this);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_range_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Registry
	{
		private IntPtr _pointer;
		public Registry(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Registry(IntPtr pointer) => new Registry(pointer, checkType: true);
		public static explicit operator IntPtr(Registry value) => value._pointer;
		public static implicit operator GObject.Object(Registry value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Registry(GObject.Object value) => new Registry((IntPtr)value, checkType: true);
		public Atk.ObjectFactory get_factory(GLib.GType type) => Atk.AtkInterop.atk_registry_get_factory(this, type);
		public GLib.GType get_factory_type(GLib.GType type) => Atk.AtkInterop.atk_registry_get_factory_type(this, type);
		public void set_factory_type(GLib.GType type, GLib.GType factory_type) => Atk.AtkInterop.atk_registry_set_factory_type(this, type, factory_type);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_registry_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct RegistryClass
	{
		private IntPtr _pointer;
		public RegistryClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RegistryClass(IntPtr pointer) => new RegistryClass(pointer, checkType: true);
		public static explicit operator IntPtr(RegistryClass value) => value._pointer;
	}
	public ref struct Relation
	{
		private IntPtr _pointer;
		public Relation(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Relation(IntPtr pointer) => new Relation(pointer, checkType: true);
		public static explicit operator IntPtr(Relation value) => value._pointer;
		public static implicit operator GObject.Object(Relation value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Relation(GObject.Object value) => new Relation((IntPtr)value, checkType: true);
		public static Atk.Relation @new(System.IntPtr targets, int n_targets, Atk.RelationType relationship) => AtkInterop.atk_relation_new(targets, n_targets, relationship);
		public void add_target(Atk.Object target) => Atk.AtkInterop.atk_relation_add_target(this, target);
		public Atk.RelationType get_relation_type() => Atk.AtkInterop.atk_relation_get_relation_type(this);
		public System.IntPtr get_target() => Atk.AtkInterop.atk_relation_get_target(this);
		public bool remove_target(Atk.Object target) => Atk.AtkInterop.atk_relation_remove_target(this, target);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_relation_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct RelationClass
	{
		private IntPtr _pointer;
		public RelationClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RelationClass(IntPtr pointer) => new RelationClass(pointer, checkType: true);
		public static explicit operator IntPtr(RelationClass value) => value._pointer;
	}
	public ref struct RelationSetClass
	{
		private IntPtr _pointer;
		public RelationSetClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RelationSetClass(IntPtr pointer) => new RelationSetClass(pointer, checkType: true);
		public static explicit operator IntPtr(RelationSetClass value) => value._pointer;
	}
	public ref struct SelectionIface
	{
		private IntPtr _pointer;
		public SelectionIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SelectionIface(IntPtr pointer) => new SelectionIface(pointer, checkType: true);
		public static explicit operator IntPtr(SelectionIface value) => value._pointer;
	}
	public ref struct Socket
	{
		private IntPtr _pointer;
		public Socket(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Socket(IntPtr pointer) => new Socket(pointer, checkType: true);
		public static explicit operator IntPtr(Socket value) => value._pointer;
		public static implicit operator Atk.Object(Socket value) => new Atk.Object((IntPtr)value, checkType: false);
		public static explicit operator Socket(Atk.Object value) => new Socket((IntPtr)value, checkType: true);
		public static implicit operator GObject.Object(Socket value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Socket(GObject.Object value) => new Socket((IntPtr)value, checkType: true);
		public static Atk.Object @new() => AtkInterop.atk_socket_new();
		public void embed(string plug_id) => Atk.AtkInterop.atk_socket_embed(this, plug_id);
		public bool is_occupied() => Atk.AtkInterop.atk_socket_is_occupied(this);
		public bool add_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_add_relationship(this, relationship, target);
		public uint connect_property_change_handler(System.IntPtr handler) => Atk.AtkInterop.atk_object_connect_property_change_handler(this, handler);
		public GLib.SList get_attributes() => Atk.AtkInterop.atk_object_get_attributes(this);
		public string get_description() => Atk.AtkInterop.atk_object_get_description(this);
		public int get_index_in_parent() => Atk.AtkInterop.atk_object_get_index_in_parent(this);
		public Atk.Layer get_layer() => Atk.AtkInterop.atk_object_get_layer(this);
		public int get_mdi_zorder() => Atk.AtkInterop.atk_object_get_mdi_zorder(this);
		public int get_n_accessible_children() => Atk.AtkInterop.atk_object_get_n_accessible_children(this);
		public string get_name() => Atk.AtkInterop.atk_object_get_name(this);
		public string get_object_locale() => Atk.AtkInterop.atk_object_get_object_locale(this);
		public Atk.Object get_parent() => Atk.AtkInterop.atk_object_get_parent(this);
		public Atk.Role get_role() => Atk.AtkInterop.atk_object_get_role(this);
		public void initialize(System.IntPtr data) => Atk.AtkInterop.atk_object_initialize(this, data);
		public void notify_state_change(ulong state, bool value) => Atk.AtkInterop.atk_object_notify_state_change(this, state, value);
		public Atk.Object peek_parent() => Atk.AtkInterop.atk_object_peek_parent(this);
		public Atk.Object ref_accessible_child(int i) => Atk.AtkInterop.atk_object_ref_accessible_child(this, i);
		public Atk.RelationSet ref_relation_set() => Atk.AtkInterop.atk_object_ref_relation_set(this);
		public Atk.StateSet ref_state_set() => Atk.AtkInterop.atk_object_ref_state_set(this);
		public void remove_property_change_handler(uint handler_id) => Atk.AtkInterop.atk_object_remove_property_change_handler(this, handler_id);
		public bool remove_relationship(Atk.RelationType relationship, Atk.Object target) => Atk.AtkInterop.atk_object_remove_relationship(this, relationship, target);
		public void set_description(string description) => Atk.AtkInterop.atk_object_set_description(this, description);
		public void set_name(string name) => Atk.AtkInterop.atk_object_set_name(this, name);
		public void set_parent(Atk.Object parent) => Atk.AtkInterop.atk_object_set_parent(this, parent);
		public void set_role(Atk.Role role) => Atk.AtkInterop.atk_object_set_role(this, role);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_socket_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct SocketClass
	{
		private IntPtr _pointer;
		public SocketClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SocketClass(IntPtr pointer) => new SocketClass(pointer, checkType: true);
		public static explicit operator IntPtr(SocketClass value) => value._pointer;
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
	public ref struct StateSetClass
	{
		private IntPtr _pointer;
		public StateSetClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator StateSetClass(IntPtr pointer) => new StateSetClass(pointer, checkType: true);
		public static explicit operator IntPtr(StateSetClass value) => value._pointer;
	}
	public ref struct StreamableContent
	{
		private IntPtr _pointer;
		public StreamableContent(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator StreamableContent(IntPtr pointer) => new StreamableContent(pointer, checkType: true);
		public static explicit operator IntPtr(StreamableContent value) => value._pointer;
		public string get_mime_type(int i) => Atk.AtkInterop.atk_streamable_content_get_mime_type(this, i);
		public int get_n_mime_types() => Atk.AtkInterop.atk_streamable_content_get_n_mime_types(this);
		public GLib.IOChannel get_stream(string mime_type) => Atk.AtkInterop.atk_streamable_content_get_stream(this, mime_type);
		public string get_uri(string mime_type) => Atk.AtkInterop.atk_streamable_content_get_uri(this, mime_type);
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_streamable_content_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct StreamableContentIface
	{
		private IntPtr _pointer;
		public StreamableContentIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator StreamableContentIface(IntPtr pointer) => new StreamableContentIface(pointer, checkType: true);
		public static explicit operator IntPtr(StreamableContentIface value) => value._pointer;
	}
	public ref struct TableCellIface
	{
		private IntPtr _pointer;
		public TableCellIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TableCellIface(IntPtr pointer) => new TableCellIface(pointer, checkType: true);
		public static explicit operator IntPtr(TableCellIface value) => value._pointer;
	}
	public ref struct TableIface
	{
		private IntPtr _pointer;
		public TableIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TableIface(IntPtr pointer) => new TableIface(pointer, checkType: true);
		public static explicit operator IntPtr(TableIface value) => value._pointer;
	}
	public ref struct TextRange
	{
		private IntPtr _pointer;
		public TextRange(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TextRange(IntPtr pointer) => new TextRange(pointer, checkType: true);
		public static explicit operator IntPtr(TextRange value) => value._pointer;
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_text_range_get_type")]
		public static extern GLib.GType TypeOf();
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
	public ref struct TextIface
	{
		private IntPtr _pointer;
		public TextIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TextIface(IntPtr pointer) => new TextIface(pointer, checkType: true);
		public static explicit operator IntPtr(TextIface value) => value._pointer;
	}
	public ref struct Util
	{
		private IntPtr _pointer;
		public Util(IntPtr pointer, bool checkType = false)
		{
			if (checkType)
			{
				GObject.ObjectType.CheckInstanceIsA(pointer, TypeOf());
			}
			_pointer = pointer;
		}
		public static explicit operator Util(IntPtr pointer) => new Util(pointer, checkType: true);
		public static explicit operator IntPtr(Util value) => value._pointer;
		public static implicit operator GObject.Object(Util value) => new GObject.Object((IntPtr)value, checkType: false);
		public static explicit operator Util(GObject.Object value) => new Util((IntPtr)value, checkType: true);
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
		[DllImport("libatk-1.0.so.0", EntryPoint = "atk_util_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct UtilClass
	{
		private IntPtr _pointer;
		public UtilClass(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator UtilClass(IntPtr pointer) => new UtilClass(pointer, checkType: true);
		public static explicit operator IntPtr(UtilClass value) => value._pointer;
	}
	public ref struct ValueIface
	{
		private IntPtr _pointer;
		public ValueIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ValueIface(IntPtr pointer) => new ValueIface(pointer, checkType: true);
		public static explicit operator IntPtr(ValueIface value) => value._pointer;
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
	public ref struct WindowIface
	{
		private IntPtr _pointer;
		public WindowIface(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator WindowIface(IntPtr pointer) => new WindowIface(pointer, checkType: true);
		public static explicit operator IntPtr(WindowIface value) => value._pointer;
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
		public static extern void atk_focus_tracker_notify(Atk.Object @object);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_binary_age();
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Registry atk_get_default_registry();
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_get_focus_object();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_interface_age();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_major_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_micro_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_get_minor_version();
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_get_root();
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
		public static extern bool atk_action_do_action(Atk.Action action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_description(Atk.Action action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_keybinding(Atk.Action action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_localized_name(Atk.Action action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_action_get_n_actions(Atk.Action action);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_action_get_name(Atk.Action action, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_action_set_description(Atk.Action action, int i, string desc);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_attribute_set_free(GLib.SList attrib_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_component_add_focus_handler(Atk.Component component, System.IntPtr handler);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_component_contains(Atk.Component component, int x, int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_component_get_alpha(Atk.Component component);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_get_extents(Atk.Component component, out int x, out int y, out int width, out int height, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Layer atk_component_get_layer(Atk.Component component);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_component_get_mdi_zorder(Atk.Component component);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_get_position(Atk.Component component, out int x, out int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_get_size(Atk.Component component, out int width, out int height);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_component_grab_focus(Atk.Component component);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_component_ref_accessible_at_point(Atk.Component component, int x, int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_component_remove_focus_handler(Atk.Component component, uint handler_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_component_set_extents(Atk.Component component, int x, int y, int width, int height, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_component_set_position(Atk.Component component, int x, int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_component_set_size(Atk.Component component, int width, int height);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_object_add_relationship(Atk.Object @object, Atk.RelationType relationship, Atk.Object target);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_object_connect_property_change_handler(Atk.Object accessible, System.IntPtr handler);
		[DllImport("libatk-1.0.so.0")]
		public static extern GLib.SList atk_object_get_attributes(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_object_get_description(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_get_index_in_parent(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Layer atk_object_get_layer(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_get_mdi_zorder(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_object_get_n_accessible_children(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_object_get_name(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_object_get_object_locale(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_object_get_parent(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Role atk_object_get_role(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_initialize(Atk.Object accessible, System.IntPtr data);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_notify_state_change(Atk.Object accessible, ulong state, bool value);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_object_peek_parent(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_object_ref_accessible_child(Atk.Object accessible, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.RelationSet atk_object_ref_relation_set(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateSet atk_object_ref_state_set(Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_remove_property_change_handler(Atk.Object accessible, uint handler_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_object_remove_relationship(Atk.Object @object, Atk.RelationType relationship, Atk.Object target);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_description(Atk.Object accessible, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_name(Atk.Object accessible, string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_parent(Atk.Object accessible, Atk.Object parent);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_set_role(Atk.Object accessible, Atk.Role role);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_document_get_attribute_value(Atk.Document document, string attribute_name);
		[DllImport("libatk-1.0.so.0")]
		public static extern GLib.SList atk_document_get_attributes(Atk.Document document);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_document_get_current_page_number(Atk.Document document);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_document_get_document(Atk.Document document);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_document_get_document_type(Atk.Document document);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_document_get_locale(Atk.Document document);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_document_get_page_count(Atk.Document document);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_document_set_attribute_value(Atk.Document document, string attribute_name, string attribute_value);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_copy_text(Atk.EditableText text, int start_pos, int end_pos);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_cut_text(Atk.EditableText text, int start_pos, int end_pos);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_delete_text(Atk.EditableText text, int start_pos, int end_pos);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_insert_text(Atk.EditableText text, string @string, int length, int position);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_paste_text(Atk.EditableText text, int position);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_editable_text_set_run_attributes(Atk.EditableText text, GLib.SList attrib_set, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_editable_text_set_text_contents(Atk.EditableText text, string @string);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_gobject_accessible_for_object(GObject.Object obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern GObject.Object atk_gobject_accessible_get_object(Atk.GObjectAccessible obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_get_end_index(Atk.Hyperlink link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_get_n_anchors(Atk.Hyperlink link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_hyperlink_get_object(Atk.Hyperlink link_, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hyperlink_get_start_index(Atk.Hyperlink link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_hyperlink_get_uri(Atk.Hyperlink link_, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_hyperlink_is_inline(Atk.Hyperlink link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_hyperlink_is_selected_link(Atk.Hyperlink link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_hyperlink_is_valid(Atk.Hyperlink link_);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Hyperlink atk_hyperlink_impl_get_hyperlink(Atk.HyperlinkImpl impl);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Hyperlink atk_hypertext_get_link(Atk.Hypertext hypertext, int link_index);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hypertext_get_link_index(Atk.Hypertext hypertext, int char_index);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_hypertext_get_n_links(Atk.Hypertext hypertext);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_image_get_image_description(Atk.Image image);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_image_get_image_locale(Atk.Image image);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_image_get_image_position(Atk.Image image, out int x, out int y, Atk.CoordType coord_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_image_get_image_size(Atk.Image image, out int width, out int height);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_image_set_image_description(Atk.Image image, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_implementor_ref_accessible(Atk.Implementor implementor);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Misc atk_misc_get_instance();
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_misc_threads_enter(Atk.Misc misc);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_misc_threads_leave(Atk.Misc misc);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_selection_add_selection(Atk.Selection selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_selection_clear_selection(Atk.Selection selection);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_selection_get_selection_count(Atk.Selection selection);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_selection_is_child_selected(Atk.Selection selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_selection_ref_selection(Atk.Selection selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_selection_remove_selection(Atk.Selection selection, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_selection_select_all_selection(Atk.Selection selection);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_add_column_selection(Atk.Table table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_add_row_selection(Atk.Table table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_table_get_caption(Atk.Table table);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_column_at_index(Atk.Table table, int index_);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_table_get_column_description(Atk.Table table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_column_extent_at(Atk.Table table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_table_get_column_header(Atk.Table table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_index_at(Atk.Table table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_n_columns(Atk.Table table);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_n_rows(Atk.Table table);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_row_at_index(Atk.Table table, int index_);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_table_get_row_description(Atk.Table table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_get_row_extent_at(Atk.Table table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_table_get_row_header(Atk.Table table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_table_get_summary(Atk.Table table);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_is_column_selected(Atk.Table table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_is_row_selected(Atk.Table table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_is_selected(Atk.Table table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_table_ref_at(Atk.Table table, int row, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_remove_column_selection(Atk.Table table, int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_remove_row_selection(Atk.Table table, int row);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_caption(Atk.Table table, Atk.Object caption);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_column_description(Atk.Table table, int column, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_column_header(Atk.Table table, int column, Atk.Object header);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_row_description(Atk.Table table, int row, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_row_header(Atk.Table table, int row, Atk.Object header);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_table_set_summary(Atk.Table table, Atk.Object accessible);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_cell_get_column_header_cells(Atk.TableCell cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_cell_get_column_span(Atk.TableCell cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_cell_get_position(Atk.TableCell cell, out int row, out int column);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_table_cell_get_row_column_span(Atk.TableCell cell, out int row, out int column, out int row_span, out int column_span);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_table_cell_get_row_header_cells(Atk.TableCell cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_table_cell_get_row_span(Atk.TableCell cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_table_cell_get_table(Atk.TableCell cell);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_text_free_ranges(System.IntPtr ranges);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_text_add_selection(Atk.Text text, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_caret_offset(Atk.Text text);
		[DllImport("libatk-1.0.so.0")]
		public static extern uint atk_text_get_character_at_offset(Atk.Text text, int offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_character_count(Atk.Text text);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_text_get_character_extents(Atk.Text text, int offset, out int x, out int y, out int width, out int height, Atk.CoordType coords);
		[DllImport("libatk-1.0.so.0")]
		public static extern GLib.SList atk_text_get_default_attributes(Atk.Text text);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_n_selections(Atk.Text text);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_text_get_offset_at_point(Atk.Text text, int x, int y, Atk.CoordType coords);
		[DllImport("libatk-1.0.so.0")]
		public static extern GLib.SList atk_text_get_run_attributes(Atk.Text text, int offset, out int start_offset, out int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_selection(Atk.Text text, int selection_num, out int start_offset, out int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_string_at_offset(Atk.Text text, int offset, Atk.TextGranularity granularity, out int start_offset, out int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text(Atk.Text text, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text_after_offset(Atk.Text text, int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text_at_offset(Atk.Text text, int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_text_get_text_before_offset(Atk.Text text, int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_text_remove_selection(Atk.Text text, int selection_num);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_text_set_caret_offset(Atk.Text text, int offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_text_set_selection(Atk.Text text, int selection_num, int start_offset, int end_offset);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_value_get_increment(Atk.Value obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Range atk_value_get_range(Atk.Value obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_value_get_sub_ranges(Atk.Value obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_get_value_and_text(Atk.Value obj, out double value, out string text);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_value_set_value(Atk.Value obj, double new_value);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_no_op_object_new(GObject.Object obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_object_factory_create_accessible(Atk.ObjectFactory factory, GObject.Object obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern GLib.GType atk_object_factory_get_accessible_type(Atk.ObjectFactory factory);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_object_factory_invalidate(Atk.ObjectFactory factory);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.ObjectFactory atk_no_op_object_factory_new();
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
		public static extern Atk.RelationSet atk_relation_set_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_set_add(Atk.RelationSet set, Atk.Relation relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_set_add_relation_by_type(Atk.RelationSet set, Atk.RelationType relationship, Atk.Object target);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_relation_set_contains(Atk.RelationSet set, Atk.RelationType relationship);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_relation_set_contains_target(Atk.RelationSet set, Atk.RelationType relationship, Atk.Object target);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_relation_set_get_n_relations(Atk.RelationSet set);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Relation atk_relation_set_get_relation(Atk.RelationSet set, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Relation atk_relation_set_get_relation_by_type(Atk.RelationSet set, Atk.RelationType relationship);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_set_remove(Atk.RelationSet set, Atk.Relation relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateSet atk_state_set_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_state_set_add_state(Atk.StateSet set, Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_state_set_add_states(Atk.StateSet set, System.IntPtr types, int n_types);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateSet atk_state_set_and_sets(Atk.StateSet set, Atk.StateSet compare_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_state_set_clear_states(Atk.StateSet set);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_state_set_contains_state(Atk.StateSet set, Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_state_set_contains_states(Atk.StateSet set, System.IntPtr types, int n_types);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_state_set_is_empty(Atk.StateSet set);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateSet atk_state_set_or_sets(Atk.StateSet set, Atk.StateSet compare_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_state_set_remove_state(Atk.StateSet set, Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateSet atk_state_set_xor_sets(Atk.StateSet set, Atk.StateSet compare_set);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_plug_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_plug_get_id(Atk.Plug plug);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Range atk_range_new(double lower_limit, double upper_limit, string description);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Range atk_range_copy(Atk.Range src);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_range_free(Atk.Range range);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_range_get_description(Atk.Range range);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_range_get_lower_limit(Atk.Range range);
		[DllImport("libatk-1.0.so.0")]
		public static extern double atk_range_get_upper_limit(Atk.Range range);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.ObjectFactory atk_registry_get_factory(Atk.Registry registry, GLib.GType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern GLib.GType atk_registry_get_factory_type(Atk.Registry registry, GLib.GType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_registry_set_factory_type(Atk.Registry registry, GLib.GType type, GLib.GType factory_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Relation atk_relation_new(System.IntPtr targets, int n_targets, Atk.RelationType relationship);
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_relation_add_target(Atk.Relation relation, Atk.Object target);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.RelationType atk_relation_get_relation_type(Atk.Relation relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern System.IntPtr atk_relation_get_target(Atk.Relation relation);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_relation_remove_target(Atk.Relation relation, Atk.Object target);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.Object atk_socket_new();
		[DllImport("libatk-1.0.so.0")]
		public static extern void atk_socket_embed(Atk.Socket obj, string plug_id);
		[DllImport("libatk-1.0.so.0")]
		public static extern bool atk_socket_is_occupied(Atk.Socket obj);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateType atk_state_type_for_name(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_state_type_get_name(Atk.StateType type);
		[DllImport("libatk-1.0.so.0")]
		public static extern Atk.StateType atk_state_type_register(string name);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_streamable_content_get_mime_type(Atk.StreamableContent streamable, int i);
		[DllImport("libatk-1.0.so.0")]
		public static extern int atk_streamable_content_get_n_mime_types(Atk.StreamableContent streamable);
		[DllImport("libatk-1.0.so.0")]
		public static extern GLib.IOChannel atk_streamable_content_get_stream(Atk.StreamableContent streamable, string mime_type);
		[DllImport("libatk-1.0.so.0")]
		public static extern string atk_streamable_content_get_uri(Atk.StreamableContent streamable, string mime_type);
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
