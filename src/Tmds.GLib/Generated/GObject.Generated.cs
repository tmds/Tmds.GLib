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
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_object_get_type")]
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
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_value_get_type")]
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
	public ref struct SignalQuery
	{
		private IntPtr _pointer;
		public SignalQuery(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SignalQuery(IntPtr pointer) => new SignalQuery(pointer, checkType: true);
		public static explicit operator IntPtr(SignalQuery value) => value._pointer;
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
	}
	public ref struct TypeInfo
	{
		private IntPtr _pointer;
		public TypeInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeInfo(IntPtr pointer) => new TypeInfo(pointer, checkType: true);
		public static explicit operator IntPtr(TypeInfo value) => value._pointer;
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
	public ref struct TypeQuery
	{
		private IntPtr _pointer;
		public TypeQuery(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TypeQuery(IntPtr pointer) => new TypeQuery(pointer, checkType: true);
		public static explicit operator IntPtr(TypeQuery value) => value._pointer;
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
		[DllImport("libgobject-2.0.so.0", EntryPoint = "g_value_array_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct WeakRef
	{
		private IntPtr _pointer;
		public WeakRef(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator WeakRef(IntPtr pointer) => new WeakRef(pointer, checkType: true);
		public static explicit operator IntPtr(WeakRef value) => value._pointer;
	}
	public static class GObjectInterop {
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_boxed_copy(GLib.GType boxed_type, System.IntPtr src_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_boxed_free(GLib.GType boxed_type, System.IntPtr boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_boxed_type_register_static(string name, System.IntPtr boxed_copy, System.IntPtr boxed_free);
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
		public static extern bool g_param_value_convert(GObject.ParamSpec pspec, GObject.Value src_value, GObject.Value dest_value, bool strict_validation);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_param_value_defaults(GObject.ParamSpec pspec, GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_value_set_default(GObject.ParamSpec pspec, GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_param_value_validate(GObject.ParamSpec pspec, GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_param_values_cmp(GObject.ParamSpec pspec, GObject.Value value1, GObject.Value value2);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_pointer_type_register_static(string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_signal_accumulator_first_wins(GObject.SignalInvocationHint ihint, GObject.Value return_accu, GObject.Value handler_return, System.IntPtr dummy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_signal_accumulator_true_handled(GObject.SignalInvocationHint ihint, GObject.Value return_accu, GObject.Value handler_return, System.IntPtr dummy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_signal_add_emission_hook(uint signal_id, uint detail, System.IntPtr hook_func, System.IntPtr hook_data, System.IntPtr data_destroy);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_signal_chain_from_overridden(System.IntPtr instance_and_params, GObject.Value return_value);
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
		public static extern System.IntPtr g_signal_list_ids(GLib.GType itype, System.IntPtr n_ids);
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
		public static extern bool g_signal_parse_name(string detailed_signal, GLib.GType itype, System.IntPtr signal_id_p, System.IntPtr detail_p, bool force_detail_quark);
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
		public static extern string g_strdup_value_contents(GObject.Value value);
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
		public static extern bool g_type_check_value(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_check_value_holds(GObject.Value value, GLib.GType type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_type_children(GLib.GType type, System.IntPtr n_children);
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
		public static extern System.IntPtr g_type_interfaces(GLib.GType type, System.IntPtr n_interfaces);
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
		public static extern GLib.GType g_type_register_fundamental(GLib.GType type_id, string type_name, GObject.TypeInfo info, GObject.TypeFundamentalInfo finfo, GObject.TypeFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_type_register_static(GLib.GType parent_type, string type_name, GObject.TypeInfo info, GObject.TypeFlags flags);
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
		public static extern void g_type_class_adjust_private_offset(System.IntPtr g_class, System.IntPtr private_size_or_offset);
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
		public static extern System.IntPtr g_object_interface_list_properties(GObject.TypeInterface g_iface, System.IntPtr n_properties_p);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_add_toggle_ref(GObject.Object @object, System.IntPtr notify, System.IntPtr data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_add_weak_pointer(GObject.Object @object, System.IntPtr weak_pointer_location);
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
		public static extern void g_object_get_property(GObject.Object @object, string property_name, GObject.Value value);
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
		public static extern void g_object_remove_weak_pointer(GObject.Object @object, System.IntPtr weak_pointer_location);
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
		public static extern void g_object_set_property(GObject.Object @object, string property_name, GObject.Value value);
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
		public static extern void g_value_copy(GObject.Value src_value, GObject.Value dest_value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_dup_boxed(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_value_dup_object(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_value_dup_param(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_value_dup_string(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.Variant g_value_dup_variant(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_value_fits_pointer(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_value_get_boolean(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_get_boxed(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern sbyte g_value_get_char(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern double g_value_get_double(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_get_enum(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_value_get_flags(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern float g_value_get_float(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.GType g_value_get_gtype(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern int g_value_get_int(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern long g_value_get_int64(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern long g_value_get_long(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Object g_value_get_object(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_value_get_param(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_get_pointer(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern sbyte g_value_get_schar(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern string g_value_get_string(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern byte g_value_get_uchar(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern uint g_value_get_uint(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_value_get_uint64(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern ulong g_value_get_ulong(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GLib.Variant g_value_get_variant(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Value g_value_init(GObject.Value value, GLib.GType g_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_init_from_instance(GObject.Value value, GObject.TypeInstance instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_value_peek_pointer(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Value g_value_reset(GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_boolean(GObject.Value value, bool v_boolean);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_boxed(GObject.Value value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_boxed_take_ownership(GObject.Value value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_char(GObject.Value value, sbyte v_char);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_double(GObject.Value value, double v_double);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_enum(GObject.Value value, int v_enum);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_flags(GObject.Value value, uint v_flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_float(GObject.Value value, float v_float);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_gtype(GObject.Value value, GLib.GType v_gtype);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_instance(GObject.Value value, System.IntPtr instance);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_int(GObject.Value value, int v_int);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_int64(GObject.Value value, long v_int64);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_long(GObject.Value value, long v_long);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_object(GObject.Value value, GObject.Object v_object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_object_take_ownership(GObject.Value value, System.IntPtr v_object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_param(GObject.Value value, GObject.ParamSpec param);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_param_take_ownership(GObject.Value value, GObject.ParamSpec param);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_pointer(GObject.Value value, System.IntPtr v_pointer);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_schar(GObject.Value value, sbyte v_char);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_static_boxed(GObject.Value value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_static_string(GObject.Value value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_string(GObject.Value value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_string_take_ownership(GObject.Value value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_uchar(GObject.Value value, byte v_uchar);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_uint(GObject.Value value, uint v_uint);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_uint64(GObject.Value value, ulong v_uint64);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_ulong(GObject.Value value, ulong v_ulong);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_set_variant(GObject.Value value, GLib.Variant variant);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_boxed(GObject.Value value, System.IntPtr v_boxed);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_object(GObject.Value value, System.IntPtr v_object);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_param(GObject.Value value, GObject.ParamSpec param);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_string(GObject.Value value, string v_string);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_take_variant(GObject.Value value, GLib.Variant variant);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_value_transform(GObject.Value src_value, GObject.Value dest_value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_unset(GObject.Value value);
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
		public static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXED(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_BOOLEAN__FLAGS(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_STRING__OBJECT_POINTER(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__BOOLEAN(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__BOXED(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__CHAR(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__DOUBLE(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__ENUM(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__FLAGS(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__FLOAT(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__INT(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__LONG(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__OBJECT(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__PARAM(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__POINTER(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__STRING(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__UCHAR(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__UINT(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__UINT_POINTER(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__ULONG(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__VARIANT(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_VOID__VOID(GObject.Closure closure, GObject.Value return_value, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_cclosure_marshal_generic(GObject.Closure closure, GObject.Value return_gvalue, uint n_param_values, GObject.Value param_values, System.IntPtr invocation_hint, System.IntPtr marshal_data);
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
		public static extern GObject.Value g_param_spec_get_default_value(GObject.ParamSpec pspec);
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
		public static extern System.IntPtr g_type_interface_prerequisites(GLib.GType interface_type, System.IntPtr n_prerequisites);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ParamSpec g_object_class_find_property(GObject.ObjectClass oclass, string property_name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_install_properties(GObject.ObjectClass oclass, uint n_pspecs, System.IntPtr pspecs);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_install_property(GObject.ObjectClass oclass, uint property_id, GObject.ParamSpec pspec);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_object_class_list_properties(GObject.ObjectClass oclass, System.IntPtr n_properties);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_object_class_override_property(GObject.ObjectClass oclass, uint property_id, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_param_spec_pool_insert(GObject.ParamSpecPool pool, GObject.ParamSpec pspec, GLib.GType owner_type);
		[DllImport("libgobject-2.0.so.0")]
		public static extern System.IntPtr g_param_spec_pool_list(GObject.ParamSpecPool pool, GLib.GType owner_type, System.IntPtr n_pspecs_p);
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
		public static extern void g_type_plugin_complete_type_info(GObject.TypePlugin plugin, GLib.GType g_type, GObject.TypeInfo info, GObject.TypeValueTable value_table);
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
		public static extern GLib.GType g_type_module_register_type(GObject.TypeModule module, GLib.GType parent_type, string type_name, GObject.TypeInfo type_info, GObject.TypeFlags flags);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_set_name(GObject.TypeModule module, string name);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_type_module_unuse(GObject.TypeModule module);
		[DllImport("libgobject-2.0.so.0")]
		public static extern bool g_type_module_use(GObject.TypeModule module);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_new(uint n_prealloced);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_append(GObject.ValueArray value_array, GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_copy(GObject.ValueArray value_array);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_value_array_free(GObject.ValueArray value_array);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.Value g_value_array_get_nth(GObject.ValueArray value_array, uint index_);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_insert(GObject.ValueArray value_array, uint index_, GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_prepend(GObject.ValueArray value_array, GObject.Value value);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_remove(GObject.ValueArray value_array, uint index_);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_sort(GObject.ValueArray value_array, System.IntPtr compare_func);
		[DllImport("libgobject-2.0.so.0")]
		public static extern GObject.ValueArray g_value_array_sort_with_data(GObject.ValueArray value_array, System.IntPtr compare_func, System.IntPtr user_data);
		[DllImport("libgobject-2.0.so.0")]
		public static extern void g_weak_ref_set(GObject.WeakRef weak_ref, GObject.Object @object);
	}
}
