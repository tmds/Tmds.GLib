using System;
using System.Runtime.InteropServices;
namespace GLib {
	public ref struct Array
	{
		private IntPtr _pointer;
		public Array(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Array(IntPtr pointer) => new Array(pointer, checkType: true);
		public static explicit operator IntPtr(Array value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_array_get_type")]
		public static extern GLib.GType TypeOf();
	}
	[Flags]
	public enum AsciiType
	{
		alnum = 1,
		alpha = 2,
		cntrl = 4,
		digit = 8,
		graph = 16,
		lower = 32,
		print = 64,
		punct = 128,
		space = 256,
		upper = 512,
		xdigit = 1024,
	}
	public ref struct AsyncQueue
	{
		private IntPtr _pointer;
		public AsyncQueue(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator AsyncQueue(IntPtr pointer) => new AsyncQueue(pointer, checkType: true);
		public static explicit operator IntPtr(AsyncQueue value) => value._pointer;
	}
	public ref struct TimeVal
	{
		private IntPtr _pointer;
		public TimeVal(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TimeVal(IntPtr pointer) => new TimeVal(pointer, checkType: true);
		public static explicit operator IntPtr(TimeVal value) => value._pointer;
	}
	public ref struct BookmarkFile
	{
		private IntPtr _pointer;
		public BookmarkFile(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator BookmarkFile(IntPtr pointer) => new BookmarkFile(pointer, checkType: true);
		public static explicit operator IntPtr(BookmarkFile value) => value._pointer;
	}
	public ref struct Error
	{
		private IntPtr _pointer;
		public Error(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Error(IntPtr pointer) => new Error(pointer, checkType: true);
		public static explicit operator IntPtr(Error value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_error_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum BookmarkFileError
	{
		invalid_uri = 0,
		invalid_value = 1,
		app_not_registered = 2,
		uri_not_found = 3,
		read = 4,
		unknown_encoding = 5,
		write = 6,
		file_not_found = 7,
	}
	public ref struct ByteArray
	{
		private IntPtr _pointer;
		public ByteArray(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ByteArray(IntPtr pointer) => new ByteArray(pointer, checkType: true);
		public static explicit operator IntPtr(ByteArray value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_byte_array_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Bytes
	{
		private IntPtr _pointer;
		public Bytes(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Bytes(IntPtr pointer) => new Bytes(pointer, checkType: true);
		public static explicit operator IntPtr(Bytes value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_bytes_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Checksum
	{
		private IntPtr _pointer;
		public Checksum(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Checksum(IntPtr pointer) => new Checksum(pointer, checkType: true);
		public static explicit operator IntPtr(Checksum value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_checksum_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum ChecksumType
	{
		md5 = 0,
		sha1 = 1,
		sha256 = 2,
		sha512 = 3,
		sha384 = 4,
	}
	public ref struct Cond
	{
		private IntPtr _pointer;
		public Cond(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Cond(IntPtr pointer) => new Cond(pointer, checkType: true);
		public static explicit operator IntPtr(Cond value) => value._pointer;
	}
	public enum ConvertError
	{
		no_conversion = 0,
		illegal_sequence = 1,
		failed = 2,
		partial_input = 3,
		bad_uri = 4,
		not_absolute_path = 5,
		no_memory = 6,
	}
	public ref struct Data
	{
		private IntPtr _pointer;
		public Data(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Data(IntPtr pointer) => new Data(pointer, checkType: true);
		public static explicit operator IntPtr(Data value) => value._pointer;
	}
	public ref struct Date
	{
		private IntPtr _pointer;
		public Date(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Date(IntPtr pointer) => new Date(pointer, checkType: true);
		public static explicit operator IntPtr(Date value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_date_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum DateMonth
	{
		bad_month = 0,
		january = 1,
		february = 2,
		march = 3,
		april = 4,
		may = 5,
		june = 6,
		july = 7,
		august = 8,
		september = 9,
		october = 10,
		november = 11,
		december = 12,
	}
	public enum DateWeekday
	{
		bad_weekday = 0,
		monday = 1,
		tuesday = 2,
		wednesday = 3,
		thursday = 4,
		friday = 5,
		saturday = 6,
		sunday = 7,
	}
	public enum DateDMY
	{
		day = 0,
		month = 1,
		year = 2,
	}
	public ref struct DateTime
	{
		private IntPtr _pointer;
		public DateTime(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator DateTime(IntPtr pointer) => new DateTime(pointer, checkType: true);
		public static explicit operator IntPtr(DateTime value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_date_time_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct TimeZone
	{
		private IntPtr _pointer;
		public TimeZone(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TimeZone(IntPtr pointer) => new TimeZone(pointer, checkType: true);
		public static explicit operator IntPtr(TimeZone value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_time_zone_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct DebugKey
	{
		private IntPtr _pointer;
		public DebugKey(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator DebugKey(IntPtr pointer) => new DebugKey(pointer, checkType: true);
		public static explicit operator IntPtr(DebugKey value) => value._pointer;
	}
	public ref struct Dir
	{
		private IntPtr _pointer;
		public Dir(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Dir(IntPtr pointer) => new Dir(pointer, checkType: true);
		public static explicit operator IntPtr(Dir value) => value._pointer;
	}
	public enum ErrorType
	{
		unknown = 0,
		unexp_eof = 1,
		unexp_eof_in_string = 2,
		unexp_eof_in_comment = 3,
		non_digit_in_const = 4,
		digit_radix = 5,
		float_radix = 6,
		float_malformed = 7,
	}
	public enum FileError
	{
		exist = 0,
		isdir = 1,
		acces = 2,
		nametoolong = 3,
		noent = 4,
		notdir = 5,
		nxio = 6,
		nodev = 7,
		rofs = 8,
		txtbsy = 9,
		fault = 10,
		loop = 11,
		nospc = 12,
		nomem = 13,
		mfile = 14,
		nfile = 15,
		badf = 16,
		inval = 17,
		pipe = 18,
		again = 19,
		intr = 20,
		io = 21,
		perm = 22,
		nosys = 23,
		failed = 24,
	}
	[Flags]
	public enum FileTest
	{
		is_regular = 1,
		is_symlink = 2,
		is_dir = 4,
		is_executable = 8,
		exists = 16,
	}
	[Flags]
	public enum FormatSizeFlags
	{
		@default = 0,
		long_format = 1,
		iec_units = 2,
	}
	public ref struct HashTable
	{
		private IntPtr _pointer;
		public HashTable(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator HashTable(IntPtr pointer) => new HashTable(pointer, checkType: true);
		public static explicit operator IntPtr(HashTable value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_hash_table_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct HashTableIter
	{
		private IntPtr _pointer;
		public HashTableIter(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator HashTableIter(IntPtr pointer) => new HashTableIter(pointer, checkType: true);
		public static explicit operator IntPtr(HashTableIter value) => value._pointer;
	}
	public ref struct Hmac
	{
		private IntPtr _pointer;
		public Hmac(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Hmac(IntPtr pointer) => new Hmac(pointer, checkType: true);
		public static explicit operator IntPtr(Hmac value) => value._pointer;
	}
	public ref struct Hook
	{
		private IntPtr _pointer;
		public Hook(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Hook(IntPtr pointer) => new Hook(pointer, checkType: true);
		public static explicit operator IntPtr(Hook value) => value._pointer;
	}
	public ref struct HookList
	{
		private IntPtr _pointer;
		public HookList(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator HookList(IntPtr pointer) => new HookList(pointer, checkType: true);
		public static explicit operator IntPtr(HookList value) => value._pointer;
	}
	[Flags]
	public enum HookFlagMask
	{
		active = 1,
		in_call = 2,
		mask = 15,
	}
	public ref struct IConv
	{
		private IntPtr _pointer;
		public IConv(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator IConv(IntPtr pointer) => new IConv(pointer, checkType: true);
		public static explicit operator IntPtr(IConv value) => value._pointer;
	}
	public ref struct IOFuncs
	{
		private IntPtr _pointer;
		public IOFuncs(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator IOFuncs(IntPtr pointer) => new IOFuncs(pointer, checkType: true);
		public static explicit operator IntPtr(IOFuncs value) => value._pointer;
	}
	public ref struct String
	{
		private IntPtr _pointer;
		public String(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator String(IntPtr pointer) => new String(pointer, checkType: true);
		public static explicit operator IntPtr(String value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_gstring_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct IOChannel
	{
		private IntPtr _pointer;
		public IOChannel(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator IOChannel(IntPtr pointer) => new IOChannel(pointer, checkType: true);
		public static explicit operator IntPtr(IOChannel value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_io_channel_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum IOStatus
	{
		error = 0,
		normal = 1,
		eof = 2,
		again = 3,
	}
	[Flags]
	public enum IOCondition
	{
		@in = 1,
		@out = 4,
		pri = 2,
		err = 8,
		hup = 16,
		nval = 32,
	}
	[Flags]
	public enum IOFlags
	{
		append = 1,
		nonblock = 2,
		is_readable = 4,
		is_writable = 8,
		is_writeable = 8,
		is_seekable = 16,
		mask = 31,
		get_mask = 31,
		set_mask = 3,
	}
	public enum IOError
	{
		none = 0,
		again = 1,
		inval = 2,
		unknown = 3,
	}
	public enum SeekType
	{
		cur = 0,
		set = 1,
		end = 2,
	}
	public enum IOChannelError
	{
		fbig = 0,
		inval = 1,
		io = 2,
		isdir = 3,
		nospc = 4,
		nxio = 5,
		overflow = 6,
		pipe = 7,
		failed = 8,
	}
	public ref struct Source
	{
		private IntPtr _pointer;
		public Source(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Source(IntPtr pointer) => new Source(pointer, checkType: true);
		public static explicit operator IntPtr(Source value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_source_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct KeyFile
	{
		private IntPtr _pointer;
		public KeyFile(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator KeyFile(IntPtr pointer) => new KeyFile(pointer, checkType: true);
		public static explicit operator IntPtr(KeyFile value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_key_file_get_type")]
		public static extern GLib.GType TypeOf();
	}
	[Flags]
	public enum KeyFileFlags
	{
		none = 0,
		keep_comments = 1,
		keep_translations = 2,
	}
	public enum KeyFileError
	{
		unknown_encoding = 0,
		parse = 1,
		not_found = 2,
		key_not_found = 3,
		group_not_found = 4,
		invalid_value = 5,
	}
	public ref struct List
	{
		private IntPtr _pointer;
		public List(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator List(IntPtr pointer) => new List(pointer, checkType: true);
		public static explicit operator IntPtr(List value) => value._pointer;
	}
	public ref struct LogField
	{
		private IntPtr _pointer;
		public LogField(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator LogField(IntPtr pointer) => new LogField(pointer, checkType: true);
		public static explicit operator IntPtr(LogField value) => value._pointer;
	}
	[Flags]
	public enum LogLevelFlags
	{
		flag_recursion = 1,
		flag_fatal = 2,
		level_error = 4,
		level_critical = 8,
		level_warning = 16,
		level_message = 32,
		level_info = 64,
		level_debug = 128,
		level_mask = -4,
	}
	public enum LogWriterOutput
	{
		handled = 1,
		unhandled = 0,
	}
	public ref struct MainContext
	{
		private IntPtr _pointer;
		public MainContext(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MainContext(IntPtr pointer) => new MainContext(pointer, checkType: true);
		public static explicit operator IntPtr(MainContext value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_main_context_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct PollFD
	{
		private IntPtr _pointer;
		public PollFD(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PollFD(IntPtr pointer) => new PollFD(pointer, checkType: true);
		public static explicit operator IntPtr(PollFD value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_pollfd_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct SourceFuncs
	{
		private IntPtr _pointer;
		public SourceFuncs(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SourceFuncs(IntPtr pointer) => new SourceFuncs(pointer, checkType: true);
		public static explicit operator IntPtr(SourceFuncs value) => value._pointer;
	}
	public ref struct MainLoop
	{
		private IntPtr _pointer;
		public MainLoop(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MainLoop(IntPtr pointer) => new MainLoop(pointer, checkType: true);
		public static explicit operator IntPtr(MainLoop value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_main_loop_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct MappedFile
	{
		private IntPtr _pointer;
		public MappedFile(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MappedFile(IntPtr pointer) => new MappedFile(pointer, checkType: true);
		public static explicit operator IntPtr(MappedFile value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_mapped_file_get_type")]
		public static extern GLib.GType TypeOf();
	}
	[Flags]
	public enum MarkupCollectType
	{
		invalid = 0,
		@string = 1,
		strdup = 2,
		boolean = 3,
		tristate = 4,
		optional = 65536,
	}
	public enum MarkupError
	{
		bad_utf8 = 0,
		empty = 1,
		parse = 2,
		unknown_element = 3,
		unknown_attribute = 4,
		invalid_content = 5,
		missing_attribute = 6,
	}
	public ref struct MarkupParseContext
	{
		private IntPtr _pointer;
		public MarkupParseContext(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MarkupParseContext(IntPtr pointer) => new MarkupParseContext(pointer, checkType: true);
		public static explicit operator IntPtr(MarkupParseContext value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_markup_parse_context_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct MarkupParser
	{
		private IntPtr _pointer;
		public MarkupParser(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MarkupParser(IntPtr pointer) => new MarkupParser(pointer, checkType: true);
		public static explicit operator IntPtr(MarkupParser value) => value._pointer;
	}
	[Flags]
	public enum MarkupParseFlags
	{
		do_not_use_this_unsupported_flag = 1,
		treat_cdata_as_text = 2,
		prefix_error_position = 4,
		ignore_qualified = 8,
	}
	public ref struct MatchInfo
	{
		private IntPtr _pointer;
		public MatchInfo(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MatchInfo(IntPtr pointer) => new MatchInfo(pointer, checkType: true);
		public static explicit operator IntPtr(MatchInfo value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_match_info_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Regex
	{
		private IntPtr _pointer;
		public Regex(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Regex(IntPtr pointer) => new Regex(pointer, checkType: true);
		public static explicit operator IntPtr(Regex value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_regex_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct MemVTable
	{
		private IntPtr _pointer;
		public MemVTable(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator MemVTable(IntPtr pointer) => new MemVTable(pointer, checkType: true);
		public static explicit operator IntPtr(MemVTable value) => value._pointer;
	}
	public ref struct Node
	{
		private IntPtr _pointer;
		public Node(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Node(IntPtr pointer) => new Node(pointer, checkType: true);
		public static explicit operator IntPtr(Node value) => value._pointer;
	}
	[Flags]
	public enum TraverseFlags
	{
		leaves = 1,
		non_leaves = 2,
		all = 3,
		mask = 3,
		leafs = 1,
		non_leafs = 2,
	}
	public enum TraverseType
	{
		in_order = 0,
		pre_order = 1,
		post_order = 2,
		level_order = 3,
	}
	public enum NormalizeMode
	{
		@default = 0,
		nfd = 0,
		default_compose = 1,
		nfc = 1,
		all = 2,
		nfkd = 2,
		all_compose = 3,
		nfkc = 3,
	}
	public enum NumberParserError
	{
		invalid = 0,
		out_of_bounds = 1,
	}
	public enum OnceStatus
	{
		notcalled = 0,
		progress = 1,
		ready = 2,
	}
	public ref struct Once
	{
		private IntPtr _pointer;
		public Once(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Once(IntPtr pointer) => new Once(pointer, checkType: true);
		public static explicit operator IntPtr(Once value) => value._pointer;
	}
	public enum OptionArg
	{
		none = 0,
		@string = 1,
		@int = 2,
		callback = 3,
		filename = 4,
		string_array = 5,
		filename_array = 6,
		@double = 7,
		int64 = 8,
	}
	public ref struct OptionContext
	{
		private IntPtr _pointer;
		public OptionContext(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator OptionContext(IntPtr pointer) => new OptionContext(pointer, checkType: true);
		public static explicit operator IntPtr(OptionContext value) => value._pointer;
	}
	public ref struct OptionGroup
	{
		private IntPtr _pointer;
		public OptionGroup(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator OptionGroup(IntPtr pointer) => new OptionGroup(pointer, checkType: true);
		public static explicit operator IntPtr(OptionGroup value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_option_group_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct OptionEntry
	{
		private IntPtr _pointer;
		public OptionEntry(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator OptionEntry(IntPtr pointer) => new OptionEntry(pointer, checkType: true);
		public static explicit operator IntPtr(OptionEntry value) => value._pointer;
	}
	public enum OptionError
	{
		unknown_option = 0,
		bad_value = 1,
		failed = 2,
	}
	[Flags]
	public enum OptionFlags
	{
		none = 0,
		hidden = 1,
		in_main = 2,
		reverse = 4,
		no_arg = 8,
		filename = 16,
		optional_arg = 32,
		noalias = 64,
	}
	public ref struct PatternSpec
	{
		private IntPtr _pointer;
		public PatternSpec(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PatternSpec(IntPtr pointer) => new PatternSpec(pointer, checkType: true);
		public static explicit operator IntPtr(PatternSpec value) => value._pointer;
	}
	public ref struct Private
	{
		private IntPtr _pointer;
		public Private(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Private(IntPtr pointer) => new Private(pointer, checkType: true);
		public static explicit operator IntPtr(Private value) => value._pointer;
	}
	public ref struct PtrArray
	{
		private IntPtr _pointer;
		public PtrArray(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator PtrArray(IntPtr pointer) => new PtrArray(pointer, checkType: true);
		public static explicit operator IntPtr(PtrArray value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_ptr_array_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct Queue
	{
		private IntPtr _pointer;
		public Queue(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Queue(IntPtr pointer) => new Queue(pointer, checkType: true);
		public static explicit operator IntPtr(Queue value) => value._pointer;
	}
	public ref struct RWLock
	{
		private IntPtr _pointer;
		public RWLock(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RWLock(IntPtr pointer) => new RWLock(pointer, checkType: true);
		public static explicit operator IntPtr(RWLock value) => value._pointer;
	}
	public ref struct Rand
	{
		private IntPtr _pointer;
		public Rand(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Rand(IntPtr pointer) => new Rand(pointer, checkType: true);
		public static explicit operator IntPtr(Rand value) => value._pointer;
	}
	public ref struct RecMutex
	{
		private IntPtr _pointer;
		public RecMutex(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator RecMutex(IntPtr pointer) => new RecMutex(pointer, checkType: true);
		public static explicit operator IntPtr(RecMutex value) => value._pointer;
	}
	[Flags]
	public enum RegexCompileFlags
	{
		caseless = 1,
		multiline = 2,
		dotall = 4,
		extended = 8,
		anchored = 16,
		dollar_endonly = 32,
		ungreedy = 512,
		raw = 2048,
		no_auto_capture = 4096,
		optimize = 8192,
		firstline = 262144,
		dupnames = 524288,
		newline_cr = 1048576,
		newline_lf = 2097152,
		newline_crlf = 3145728,
		newline_anycrlf = 5242880,
		bsr_anycrlf = 8388608,
		javascript_compat = 33554432,
	}
	[Flags]
	public enum RegexMatchFlags
	{
		anchored = 16,
		notbol = 128,
		noteol = 256,
		notempty = 1024,
		partial = 32768,
		newline_cr = 1048576,
		newline_lf = 2097152,
		newline_crlf = 3145728,
		newline_any = 4194304,
		newline_anycrlf = 5242880,
		bsr_anycrlf = 8388608,
		bsr_any = 16777216,
		partial_soft = 32768,
		partial_hard = 134217728,
		notempty_atstart = 268435456,
	}
	public enum RegexError
	{
		compile = 0,
		optimize = 1,
		replace = 2,
		match = 3,
		@internal = 4,
		stray_backslash = 101,
		missing_control_char = 102,
		unrecognized_escape = 103,
		quantifiers_out_of_order = 104,
		quantifier_too_big = 105,
		unterminated_character_class = 106,
		invalid_escape_in_character_class = 107,
		range_out_of_order = 108,
		nothing_to_repeat = 109,
		unrecognized_character = 112,
		posix_named_class_outside_class = 113,
		unmatched_parenthesis = 114,
		inexistent_subpattern_reference = 115,
		unterminated_comment = 118,
		expression_too_large = 120,
		memory_error = 121,
		variable_length_lookbehind = 125,
		malformed_condition = 126,
		too_many_conditional_branches = 127,
		assertion_expected = 128,
		unknown_posix_class_name = 130,
		posix_collating_elements_not_supported = 131,
		hex_code_too_large = 134,
		invalid_condition = 135,
		single_byte_match_in_lookbehind = 136,
		infinite_loop = 140,
		missing_subpattern_name_terminator = 142,
		duplicate_subpattern_name = 143,
		malformed_property = 146,
		unknown_property = 147,
		subpattern_name_too_long = 148,
		too_many_subpatterns = 149,
		invalid_octal_value = 151,
		too_many_branches_in_define = 154,
		define_repetion = 155,
		inconsistent_newline_options = 156,
		missing_back_reference = 157,
		invalid_relative_reference = 158,
		backtracking_control_verb_argument_forbidden = 159,
		unknown_backtracking_control_verb = 160,
		number_too_big = 161,
		missing_subpattern_name = 162,
		missing_digit = 163,
		invalid_data_character = 164,
		extra_subpattern_name = 165,
		backtracking_control_verb_argument_required = 166,
		invalid_control_char = 168,
		missing_name = 169,
		not_supported_in_class = 171,
		too_many_forward_references = 172,
		name_too_long = 175,
		character_value_too_large = 176,
	}
	public ref struct SList
	{
		private IntPtr _pointer;
		public SList(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SList(IntPtr pointer) => new SList(pointer, checkType: true);
		public static explicit operator IntPtr(SList value) => value._pointer;
	}
	public ref struct ScannerConfig
	{
		private IntPtr _pointer;
		public ScannerConfig(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ScannerConfig(IntPtr pointer) => new ScannerConfig(pointer, checkType: true);
		public static explicit operator IntPtr(ScannerConfig value) => value._pointer;
	}
	public enum TokenType
	{
		eof = 0,
		left_paren = 40,
		right_paren = 41,
		left_curly = 123,
		right_curly = 125,
		left_brace = 91,
		right_brace = 93,
		equal_sign = 61,
		comma = 44,
		none = 256,
		error = 257,
		@char = 258,
		binary = 259,
		octal = 260,
		@int = 261,
		hex = 262,
		@float = 263,
		@string = 264,
		symbol = 265,
		identifier = 266,
		identifier_null = 267,
		comment_single = 268,
		comment_multi = 269,
	}
	public ref struct Scanner
	{
		private IntPtr _pointer;
		public Scanner(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Scanner(IntPtr pointer) => new Scanner(pointer, checkType: true);
		public static explicit operator IntPtr(Scanner value) => value._pointer;
	}
	public ref struct SequenceIter
	{
		private IntPtr _pointer;
		public SequenceIter(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SequenceIter(IntPtr pointer) => new SequenceIter(pointer, checkType: true);
		public static explicit operator IntPtr(SequenceIter value) => value._pointer;
	}
	public ref struct Sequence
	{
		private IntPtr _pointer;
		public Sequence(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Sequence(IntPtr pointer) => new Sequence(pointer, checkType: true);
		public static explicit operator IntPtr(Sequence value) => value._pointer;
	}
	public enum ShellError
	{
		bad_quoting = 0,
		empty_string = 1,
		failed = 2,
	}
	public enum SliceConfig
	{
		always_malloc = 1,
		bypass_magazines = 2,
		working_set_msecs = 3,
		color_increment = 4,
		chunk_sizes = 5,
		contention_counter = 6,
	}
	public ref struct SourceCallbackFuncs
	{
		private IntPtr _pointer;
		public SourceCallbackFuncs(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SourceCallbackFuncs(IntPtr pointer) => new SourceCallbackFuncs(pointer, checkType: true);
		public static explicit operator IntPtr(SourceCallbackFuncs value) => value._pointer;
	}
	public ref struct SourcePrivate
	{
		private IntPtr _pointer;
		public SourcePrivate(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator SourcePrivate(IntPtr pointer) => new SourcePrivate(pointer, checkType: true);
		public static explicit operator IntPtr(SourcePrivate value) => value._pointer;
	}
	public enum SpawnError
	{
		fork = 0,
		read = 1,
		chdir = 2,
		acces = 3,
		perm = 4,
		too_big = 5,
		_2big = 5,
		noexec = 6,
		nametoolong = 7,
		noent = 8,
		nomem = 9,
		notdir = 10,
		loop = 11,
		txtbusy = 12,
		io = 13,
		nfile = 14,
		mfile = 15,
		inval = 16,
		isdir = 17,
		libbad = 18,
		failed = 19,
	}
	[Flags]
	public enum SpawnFlags
	{
		@default = 0,
		leave_descriptors_open = 1,
		do_not_reap_child = 2,
		search_path = 4,
		stdout_to_dev_null = 8,
		stderr_to_dev_null = 16,
		child_inherits_stdin = 32,
		file_and_argv_zero = 64,
		search_path_from_envp = 128,
		cloexec_pipes = 256,
	}
	public ref struct StatBuf
	{
		private IntPtr _pointer;
		public StatBuf(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator StatBuf(IntPtr pointer) => new StatBuf(pointer, checkType: true);
		public static explicit operator IntPtr(StatBuf value) => value._pointer;
	}
	public ref struct StringChunk
	{
		private IntPtr _pointer;
		public StringChunk(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator StringChunk(IntPtr pointer) => new StringChunk(pointer, checkType: true);
		public static explicit operator IntPtr(StringChunk value) => value._pointer;
	}
	public ref struct TestCase
	{
		private IntPtr _pointer;
		public TestCase(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TestCase(IntPtr pointer) => new TestCase(pointer, checkType: true);
		public static explicit operator IntPtr(TestCase value) => value._pointer;
	}
	public ref struct TestConfig
	{
		private IntPtr _pointer;
		public TestConfig(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TestConfig(IntPtr pointer) => new TestConfig(pointer, checkType: true);
		public static explicit operator IntPtr(TestConfig value) => value._pointer;
	}
	public enum TestFileType
	{
		dist = 0,
		built = 1,
	}
	public ref struct TestLogBuffer
	{
		private IntPtr _pointer;
		public TestLogBuffer(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TestLogBuffer(IntPtr pointer) => new TestLogBuffer(pointer, checkType: true);
		public static explicit operator IntPtr(TestLogBuffer value) => value._pointer;
	}
	public ref struct TestLogMsg
	{
		private IntPtr _pointer;
		public TestLogMsg(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TestLogMsg(IntPtr pointer) => new TestLogMsg(pointer, checkType: true);
		public static explicit operator IntPtr(TestLogMsg value) => value._pointer;
	}
	public enum TestLogType
	{
		none = 0,
		error = 1,
		start_binary = 2,
		list_case = 3,
		skip_case = 4,
		start_case = 5,
		stop_case = 6,
		min_result = 7,
		max_result = 8,
		message = 9,
		start_suite = 10,
		stop_suite = 11,
	}
	[Flags]
	public enum TestSubprocessFlags
	{
		stdin = 1,
		stdout = 2,
		stderr = 4,
	}
	public ref struct TestSuite
	{
		private IntPtr _pointer;
		public TestSuite(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TestSuite(IntPtr pointer) => new TestSuite(pointer, checkType: true);
		public static explicit operator IntPtr(TestSuite value) => value._pointer;
	}
	[Flags]
	public enum TestTrapFlags
	{
		silence_stdout = 128,
		silence_stderr = 256,
		inherit_stdin = 512,
	}
	public ref struct Thread
	{
		private IntPtr _pointer;
		public Thread(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Thread(IntPtr pointer) => new Thread(pointer, checkType: true);
		public static explicit operator IntPtr(Thread value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_thread_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum ThreadError
	{
		thread_error_again = 0,
	}
	public ref struct ThreadPool
	{
		private IntPtr _pointer;
		public ThreadPool(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator ThreadPool(IntPtr pointer) => new ThreadPool(pointer, checkType: true);
		public static explicit operator IntPtr(ThreadPool value) => value._pointer;
	}
	public enum TimeType
	{
		standard = 0,
		daylight = 1,
		universal = 2,
	}
	public ref struct Timer
	{
		private IntPtr _pointer;
		public Timer(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Timer(IntPtr pointer) => new Timer(pointer, checkType: true);
		public static explicit operator IntPtr(Timer value) => value._pointer;
	}
	public ref struct TrashStack
	{
		private IntPtr _pointer;
		public TrashStack(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator TrashStack(IntPtr pointer) => new TrashStack(pointer, checkType: true);
		public static explicit operator IntPtr(TrashStack value) => value._pointer;
	}
	public ref struct Tree
	{
		private IntPtr _pointer;
		public Tree(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Tree(IntPtr pointer) => new Tree(pointer, checkType: true);
		public static explicit operator IntPtr(Tree value) => value._pointer;
	}
	public enum UnicodeBreakType
	{
		mandatory = 0,
		carriage_return = 1,
		line_feed = 2,
		combining_mark = 3,
		surrogate = 4,
		zero_width_space = 5,
		inseparable = 6,
		non_breaking_glue = 7,
		contingent = 8,
		space = 9,
		after = 10,
		before = 11,
		before_and_after = 12,
		hyphen = 13,
		non_starter = 14,
		open_punctuation = 15,
		close_punctuation = 16,
		quotation = 17,
		exclamation = 18,
		ideographic = 19,
		numeric = 20,
		infix_separator = 21,
		symbol = 22,
		alphabetic = 23,
		prefix = 24,
		postfix = 25,
		complex_context = 26,
		ambiguous = 27,
		unknown = 28,
		next_line = 29,
		word_joiner = 30,
		hangul_l_jamo = 31,
		hangul_v_jamo = 32,
		hangul_t_jamo = 33,
		hangul_lv_syllable = 34,
		hangul_lvt_syllable = 35,
		close_paranthesis = 36,
		conditional_japanese_starter = 37,
		hebrew_letter = 38,
		regional_indicator = 39,
		emoji_base = 40,
		emoji_modifier = 41,
		zero_width_joiner = 42,
	}
	public enum UnicodeScript
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
		avestan = 78,
		bamum = 79,
		egyptian_hieroglyphs = 80,
		imperial_aramaic = 81,
		inscriptional_pahlavi = 82,
		inscriptional_parthian = 83,
		javanese = 84,
		kaithi = 85,
		lisu = 86,
		meetei_mayek = 87,
		old_south_arabian = 88,
		old_turkic = 89,
		samaritan = 90,
		tai_tham = 91,
		tai_viet = 92,
		batak = 93,
		brahmi = 94,
		mandaic = 95,
		chakma = 96,
		meroitic_cursive = 97,
		meroitic_hieroglyphs = 98,
		miao = 99,
		sharada = 100,
		sora_sompeng = 101,
		takri = 102,
		bassa_vah = 103,
		caucasian_albanian = 104,
		duployan = 105,
		elbasan = 106,
		grantha = 107,
		khojki = 108,
		khudawadi = 109,
		linear_a = 110,
		mahajani = 111,
		manichaean = 112,
		mende_kikakui = 113,
		modi = 114,
		mro = 115,
		nabataean = 116,
		old_north_arabian = 117,
		old_permic = 118,
		pahawh_hmong = 119,
		palmyrene = 120,
		pau_cin_hau = 121,
		psalter_pahlavi = 122,
		siddham = 123,
		tirhuta = 124,
		warang_citi = 125,
		ahom = 126,
		anatolian_hieroglyphs = 127,
		hatran = 128,
		multani = 129,
		old_hungarian = 130,
		signwriting = 131,
		adlam = 132,
		bhaiksuki = 133,
		marchen = 134,
		newa = 135,
		osage = 136,
		tangut = 137,
		masaram_gondi = 138,
		nushu = 139,
		soyombo = 140,
		zanabazar_square = 141,
	}
	public enum UnicodeType
	{
		control = 0,
		format = 1,
		unassigned = 2,
		private_use = 3,
		surrogate = 4,
		lowercase_letter = 5,
		modifier_letter = 6,
		other_letter = 7,
		titlecase_letter = 8,
		uppercase_letter = 9,
		spacing_mark = 10,
		enclosing_mark = 11,
		non_spacing_mark = 12,
		decimal_number = 13,
		letter_number = 14,
		other_number = 15,
		connect_punctuation = 16,
		dash_punctuation = 17,
		close_punctuation = 18,
		final_punctuation = 19,
		initial_punctuation = 20,
		other_punctuation = 21,
		open_punctuation = 22,
		currency_symbol = 23,
		modifier_symbol = 24,
		math_symbol = 25,
		other_symbol = 26,
		line_separator = 27,
		paragraph_separator = 28,
		space_separator = 29,
	}
	public enum UserDirectory
	{
		directory_desktop = 0,
		directory_documents = 1,
		directory_download = 2,
		directory_music = 3,
		directory_pictures = 4,
		directory_public_share = 5,
		directory_templates = 6,
		directory_videos = 7,
		n_directories = 8,
	}
	public ref struct Variant
	{
		private IntPtr _pointer;
		public Variant(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator Variant(IntPtr pointer) => new Variant(pointer, checkType: true);
		public static explicit operator IntPtr(Variant value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "intern")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct VariantType
	{
		private IntPtr _pointer;
		public VariantType(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator VariantType(IntPtr pointer) => new VariantType(pointer, checkType: true);
		public static explicit operator IntPtr(VariantType value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_variant_type_get_gtype")]
		public static extern GLib.GType TypeOf();
	}
	public enum VariantClass
	{
		boolean = 98,
		@byte = 121,
		int16 = 110,
		uint16 = 113,
		int32 = 105,
		uint32 = 117,
		int64 = 120,
		uint64 = 116,
		handle = 104,
		@double = 100,
		@string = 115,
		object_path = 111,
		signature = 103,
		variant = 118,
		maybe = 109,
		array = 97,
		tuple = 40,
		dict_entry = 123,
	}
	public ref struct VariantIter
	{
		private IntPtr _pointer;
		public VariantIter(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator VariantIter(IntPtr pointer) => new VariantIter(pointer, checkType: true);
		public static explicit operator IntPtr(VariantIter value) => value._pointer;
	}
	public ref struct VariantBuilder
	{
		private IntPtr _pointer;
		public VariantBuilder(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator VariantBuilder(IntPtr pointer) => new VariantBuilder(pointer, checkType: true);
		public static explicit operator IntPtr(VariantBuilder value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_variant_builder_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public ref struct VariantDict
	{
		private IntPtr _pointer;
		public VariantDict(IntPtr pointer, bool checkType = false)
		{
			_pointer = pointer;
		}
		public static explicit operator VariantDict(IntPtr pointer) => new VariantDict(pointer, checkType: true);
		public static explicit operator IntPtr(VariantDict value) => value._pointer;
		[DllImport("libglib-2.0.so.0", EntryPoint = "g_variant_dict_get_type")]
		public static extern GLib.GType TypeOf();
	}
	public enum VariantParseError
	{
		failed = 0,
		basic_type_expected = 1,
		cannot_infer_type = 2,
		definite_type_expected = 3,
		input_not_at_end = 4,
		invalid_character = 5,
		invalid_format_string = 6,
		invalid_object_path = 7,
		invalid_signature = 8,
		invalid_type_string = 9,
		no_common_type = 10,
		number_out_of_range = 11,
		number_too_big = 12,
		type_error = 13,
		unexpected_token = 14,
		unknown_keyword = 15,
		unterminated_string_constant = 16,
		value_expected = 17,
	}
	public static class GLibInterop {
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
		public static extern bool g_ascii_string_to_signed(string str, uint @base, long min, long max, System.IntPtr out_num, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_ascii_string_to_unsigned(string str, uint @base, ulong min, ulong max, System.IntPtr out_num, out GLib.Error error);
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
		public static extern void g_assertion_message_error(string domain, string file, int line, string func, string expr, GLib.Error error, uint error_domain, int error_code);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_assertion_message_expr(string domain, string file, int line, string func, string expr);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_atexit(System.IntPtr func);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_atomic_int_add(System.IntPtr atomic, int val);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_atomic_int_and(System.IntPtr atomic, uint val);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_atomic_int_compare_and_exchange(System.IntPtr atomic, int oldval, int newval);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_atomic_int_dec_and_test(System.IntPtr atomic);
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
		public static extern bool g_atomic_pointer_compare_and_exchange(System.IntPtr atomic, System.IntPtr oldval, System.IntPtr newval);
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
		public static extern ulong g_base64_encode_close(bool break_lines, System.IntPtr @out, System.IntPtr state, System.IntPtr save);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_base64_encode_step(System.IntPtr @in, ulong len, bool break_lines, System.IntPtr @out, System.IntPtr state, System.IntPtr save);
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
		public static extern bool g_bit_trylock(System.IntPtr address, int lock_bit);
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
		public static extern GLib.Source g_child_watch_source_new(int pid);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_clear_error(out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_clear_pointer(System.IntPtr pp, System.IntPtr destroy);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_close(int fd, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_compute_checksum_for_bytes(GLib.ChecksumType checksum_type, GLib.Bytes data);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_compute_checksum_for_data(GLib.ChecksumType checksum_type, System.IntPtr data, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_compute_checksum_for_string(GLib.ChecksumType checksum_type, string str, long length);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_compute_hmac_for_bytes(GLib.ChecksumType digest_type, GLib.Bytes key, GLib.Bytes data);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_compute_hmac_for_data(GLib.ChecksumType digest_type, System.IntPtr key, ulong key_len, System.IntPtr data, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_compute_hmac_for_string(GLib.ChecksumType digest_type, System.IntPtr key, ulong key_len, string str, long length);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_convert(string str, long len, string to_codeset, string from_codeset, System.IntPtr bytes_read, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_convert_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_convert_with_fallback(string str, long len, string to_codeset, string from_codeset, string fallback, System.IntPtr bytes_read, System.IntPtr bytes_written, out GLib.Error error);
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
		public static extern bool g_direct_equal(System.IntPtr v1, System.IntPtr v2);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_direct_hash(System.IntPtr v);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_dngettext(string domain, string msgid, string msgid_plural, ulong n);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_double_equal(System.IntPtr v1, System.IntPtr v2);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_double_hash(System.IntPtr v);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_dpgettext(string domain, string msgctxtid, ulong msgidoffset);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_dpgettext2(string domain, string context, string msgid);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_environ_getenv(System.IntPtr envp, string variable);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_environ_setenv(System.IntPtr envp, string variable, string value, bool overwrite);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_environ_unsetenv(System.IntPtr envp, string variable);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.FileError g_file_error_from_errno(int err_no);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_file_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_file_get_contents(System.IntPtr filename, System.IntPtr contents, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_file_open_tmp(System.IntPtr tmpl, System.IntPtr name_used, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_file_read_link(System.IntPtr filename, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_file_set_contents(System.IntPtr filename, System.IntPtr contents, long length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_file_test(System.IntPtr filename, GLib.FileTest test);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_filename_display_basename(System.IntPtr filename);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_filename_display_name(System.IntPtr filename);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_filename_from_uri(string uri, string hostname, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_filename_from_utf8(string utf8string, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_filename_to_uri(System.IntPtr filename, string hostname, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_filename_to_utf8(System.IntPtr opsysstring, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_find_program_in_path(System.IntPtr program);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_format_size(ulong size);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_format_size_for_display(long size);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_format_size_full(ulong size, GLib.FormatSizeFlags flags);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_free(System.IntPtr mem);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_get_application_name();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_get_charset(string charset);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_get_codeset();
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_get_current_dir();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_get_current_time(GLib.TimeVal result);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_get_environ();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_get_filename_charsets(string charsets);
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
		public static extern System.IntPtr g_get_user_special_dir(GLib.UserDirectory directory);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_getenv(string variable);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hostname_is_ascii_encoded(string hostname);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hostname_is_ip_address(string hostname);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hostname_is_non_ascii(string hostname);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_hostname_to_ascii(string hostname);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_hostname_to_unicode(string hostname);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_idle_add(System.IntPtr function, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_idle_add_full(int priority, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_idle_remove_by_data(System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_idle_source_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_int64_equal(System.IntPtr v1, System.IntPtr v2);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_int64_hash(System.IntPtr v);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_int_equal(System.IntPtr v1, System.IntPtr v2);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_int_hash(System.IntPtr v);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_intern_static_string(string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_intern_string(string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_io_add_watch(GLib.IOChannel channel, GLib.IOCondition condition, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_io_add_watch_full(GLib.IOChannel channel, int priority, GLib.IOCondition condition, System.IntPtr func, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_io_create_watch(GLib.IOChannel channel, GLib.IOCondition condition);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_listenv();
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_locale_from_utf8(string utf8string, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_locale_to_utf8(string opsysstring, long len, System.IntPtr bytes_read, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_log_default_handler(string log_domain, GLib.LogLevelFlags log_level, string message, System.IntPtr unused_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_log_remove_handler(string log_domain, uint handler_id);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.LogLevelFlags g_log_set_always_fatal(GLib.LogLevelFlags fatal_mask);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_log_set_default_handler(System.IntPtr log_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.LogLevelFlags g_log_set_fatal_mask(string log_domain, GLib.LogLevelFlags fatal_mask);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_log_set_handler(string log_domain, GLib.LogLevelFlags log_levels, System.IntPtr log_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_log_set_handler_full(string log_domain, GLib.LogLevelFlags log_levels, System.IntPtr log_func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_log_set_writer_func(System.IntPtr func, System.IntPtr user_data, System.IntPtr user_data_free);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_log_structured_array(GLib.LogLevelFlags log_level, System.IntPtr fields, ulong n_fields);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_log_variant(string log_domain, GLib.LogLevelFlags log_level, GLib.Variant fields);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.LogWriterOutput g_log_writer_default(GLib.LogLevelFlags log_level, System.IntPtr fields, ulong n_fields, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_log_writer_format_fields(GLib.LogLevelFlags log_level, System.IntPtr fields, ulong n_fields, bool use_color);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_log_writer_is_journald(int output_fd);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.LogWriterOutput g_log_writer_journald(GLib.LogLevelFlags log_level, System.IntPtr fields, ulong n_fields, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.LogWriterOutput g_log_writer_standard_streams(GLib.LogLevelFlags log_level, System.IntPtr fields, ulong n_fields, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_log_writer_supports_color(int output_fd);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_main_current_source();
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
		public static extern bool g_mem_is_system_malloc();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mem_profile();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mem_set_vtable(GLib.MemVTable vtable);
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
		public static extern bool g_path_is_absolute(System.IntPtr file_name);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_path_skip_root(System.IntPtr file_name);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_pattern_match(GLib.PatternSpec pspec, uint string_length, string @string, string string_reversed);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_pattern_match_simple(string pattern, string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_pattern_match_string(GLib.PatternSpec pspec, string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_pointer_bit_lock(System.IntPtr address, int lock_bit);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_pointer_bit_trylock(System.IntPtr address, int lock_bit);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_pointer_bit_unlock(System.IntPtr address, int lock_bit);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_poll(GLib.PollFD fds, uint nfds, int timeout);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_propagate_error(out GLib.Error dest, GLib.Error src);
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
		public static extern void g_set_error_literal(out GLib.Error err, uint domain, int code, string message);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_set_prgname(string prgname);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_set_print_handler(System.IntPtr func);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_set_printerr_handler(System.IntPtr func);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_setenv(string variable, string value, bool overwrite);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_shell_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_shell_parse_argv(string command_line, System.IntPtr argcp, System.IntPtr argvp, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_shell_quote(string unquoted_string);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_shell_unquote(string quoted_string, out GLib.Error error);
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
		public static extern long g_slice_get_config(GLib.SliceConfig ckey);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_slice_get_config_state(GLib.SliceConfig ckey, long address, System.IntPtr n_values);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_slice_set_config(GLib.SliceConfig ckey, long value);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_spaced_primes_closest(uint num);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_spawn_async(System.IntPtr working_directory, System.IntPtr argv, System.IntPtr envp, GLib.SpawnFlags flags, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr child_pid, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_spawn_async_with_pipes(System.IntPtr working_directory, System.IntPtr argv, System.IntPtr envp, GLib.SpawnFlags flags, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr child_pid, System.IntPtr standard_input, System.IntPtr standard_output, System.IntPtr standard_error, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_spawn_check_exit_status(int exit_status, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_spawn_close_pid(int pid);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_spawn_command_line_async(string command_line, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_spawn_command_line_sync(string command_line, System.IntPtr standard_output, System.IntPtr standard_error, System.IntPtr exit_status, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_spawn_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_spawn_exit_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_spawn_sync(System.IntPtr working_directory, System.IntPtr argv, System.IntPtr envp, GLib.SpawnFlags flags, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr standard_output, System.IntPtr standard_error, System.IntPtr exit_status, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_stpcpy(string dest, string src);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_str_equal(System.IntPtr v1, System.IntPtr v2);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_str_has_prefix(string str, string prefix);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_str_has_suffix(string str, string suffix);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_str_hash(System.IntPtr v);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_str_is_ascii(string str);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_str_match_string(string search_term, string potential_hit, bool accept_alternates);
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
		public static extern GLib.String g_string_new(string init);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_new_len(string init, long len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_sized_new(ulong dfl_size);
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
		public static extern bool g_strv_contains(string strv, string str);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.GType g_strv_get_type();
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
		public static extern GLib.TestCase g_test_create_case(string test_name, ulong data_size, System.IntPtr test_data, System.IntPtr data_setup, System.IntPtr data_test, System.IntPtr data_teardown);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TestSuite g_test_create_suite(string suite_name);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_expect_message(string log_domain, GLib.LogLevelFlags log_level, string pattern);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_fail();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_test_failed();
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_test_get_dir(GLib.TestFileType file_type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TestSuite g_test_get_root();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_incomplete(string msg);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_log_set_fatal_handler(System.IntPtr log_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_test_log_type_name(GLib.TestLogType log_type);
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
		public static extern int g_test_run_suite(GLib.TestSuite suite);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_set_nonfatal_assertions();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_skip(string msg);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_test_subprocess();
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_test_timer_elapsed();
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_test_timer_last();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_timer_start();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_trap_assertions(string domain, string file, int line, string func, ulong assertion_flags, string pattern);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_test_trap_fork(ulong usec_timeout, GLib.TestTrapFlags test_trap_flags);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_test_trap_has_passed();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_test_trap_reached_timeout();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_trap_subprocess(string test_path, ulong usec_timeout, GLib.TestSubprocessFlags test_flags);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_timeout_add(uint interval, System.IntPtr function, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_timeout_add_full(int priority, uint interval, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_timeout_add_seconds(uint interval, System.IntPtr function, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_timeout_add_seconds_full(int priority, uint interval, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_timeout_source_new(uint interval);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_timeout_source_new_seconds(uint interval);
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
		public static extern System.IntPtr g_ucs4_to_utf16(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_ucs4_to_utf8(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.UnicodeBreakType g_unichar_break_type(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_unichar_combining_class(uint uc);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_compose(uint a, uint b, System.IntPtr ch);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_decompose(uint ch, System.IntPtr a, System.IntPtr b);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_unichar_digit_value(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_unichar_fully_decompose(uint ch, bool compat, System.IntPtr result, ulong result_len);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_get_mirror_char(uint ch, System.IntPtr mirrored_ch);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.UnicodeScript g_unichar_get_script(uint ch);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isalnum(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isalpha(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_iscntrl(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isdefined(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isdigit(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isgraph(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_islower(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_ismark(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isprint(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_ispunct(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isspace(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_istitle(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isupper(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_iswide(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_iswide_cjk(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_isxdigit(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_iszerowidth(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_unichar_to_utf8(uint c, string outbuf);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unichar_tolower(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unichar_totitle(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unichar_toupper(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.UnicodeType g_unichar_type(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unichar_validate(uint ch);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_unichar_xdigit_value(uint c);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_unicode_canonical_decomposition(uint ch, System.IntPtr result_len);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_unicode_canonical_ordering(System.IntPtr @string, ulong len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.UnicodeScript g_unicode_script_from_iso15924(uint iso15924);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unicode_script_to_iso15924(GLib.UnicodeScript script);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unix_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unix_fd_add(int fd, GLib.IOCondition condition, System.IntPtr function, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unix_fd_add_full(int priority, int fd, GLib.IOCondition condition, System.IntPtr function, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_unix_fd_source_new(int fd, GLib.IOCondition condition);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unix_open_pipe(System.IntPtr fds, int flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_unix_set_fd_nonblocking(int fd, bool nonblock, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unix_signal_add(int signum, System.IntPtr handler, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_unix_signal_add_full(int priority, int signum, System.IntPtr handler, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_unix_signal_source_new(int signum);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_unlink(System.IntPtr filename);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_unsetenv(string variable);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_uri_escape_string(string unescaped, string reserved_chars_allowed, bool allow_utf8);
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
		public static extern System.IntPtr g_utf16_to_ucs4(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_utf16_to_utf8(System.IntPtr str, long len, System.IntPtr items_read, System.IntPtr items_written, out GLib.Error error);
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
		public static extern string g_utf8_normalize(string str, long len, GLib.NormalizeMode mode);
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
		public static extern System.IntPtr g_utf8_to_ucs4(string str, long len, System.IntPtr items_read, System.IntPtr items_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_utf8_to_ucs4_fast(string str, long len, System.IntPtr items_written);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_utf8_to_utf16(string str, long len, System.IntPtr items_read, System.IntPtr items_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_utf8_validate(System.IntPtr str, long max_len, string end);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_uuid_string_is_valid(string str);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_uuid_string_random();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.GType g_variant_get_gtype();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_warn_message(string domain, string file, int line, string func, string warnexpr);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_array_append_vals(System.IntPtr array, System.IntPtr data, uint len);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_array_free(System.IntPtr array, bool free_segment);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_array_get_element_size(System.IntPtr array);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_array_insert_vals(System.IntPtr array, uint index_, System.IntPtr data, uint len);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_array_new(bool zero_terminated, bool clear_, uint element_size);
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
		public static extern System.IntPtr g_array_sized_new(bool zero_terminated, bool clear_, uint element_size, uint reserved_size);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_array_sort(System.IntPtr array, System.IntPtr compare_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_array_sort_with_data(System.IntPtr array, System.IntPtr compare_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_array_unref(System.IntPtr array);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_async_queue_length(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_async_queue_length_unlocked(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_lock(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_pop(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_pop_unlocked(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_push(GLib.AsyncQueue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_push_front(GLib.AsyncQueue queue, System.IntPtr item);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_push_front_unlocked(GLib.AsyncQueue queue, System.IntPtr item);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_push_sorted(GLib.AsyncQueue queue, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_push_sorted_unlocked(GLib.AsyncQueue queue, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_push_unlocked(GLib.AsyncQueue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.AsyncQueue g_async_queue_ref(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_ref_unlocked(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_async_queue_remove(GLib.AsyncQueue queue, System.IntPtr item);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_async_queue_remove_unlocked(GLib.AsyncQueue queue, System.IntPtr item);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_sort(GLib.AsyncQueue queue, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_sort_unlocked(GLib.AsyncQueue queue, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_timed_pop(GLib.AsyncQueue queue, GLib.TimeVal end_time);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_timed_pop_unlocked(GLib.AsyncQueue queue, GLib.TimeVal end_time);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_timeout_pop(GLib.AsyncQueue queue, ulong timeout);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_timeout_pop_unlocked(GLib.AsyncQueue queue, ulong timeout);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_try_pop(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_async_queue_try_pop_unlocked(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_unlock(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_unref(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_async_queue_unref_and_unlock(GLib.AsyncQueue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.AsyncQueue g_async_queue_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.AsyncQueue g_async_queue_new_full(System.IntPtr item_free_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_time_val_add(GLib.TimeVal time_, long microseconds);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_time_val_to_iso8601(GLib.TimeVal time_);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_add_application(GLib.BookmarkFile bookmark, string uri, string name, string exec);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_add_group(GLib.BookmarkFile bookmark, string uri, string group);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_free(GLib.BookmarkFile bookmark);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_bookmark_file_get_added(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_get_app_info(GLib.BookmarkFile bookmark, string uri, string name, string exec, System.IntPtr count, System.IntPtr stamp, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_bookmark_file_get_applications(GLib.BookmarkFile bookmark, string uri, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_bookmark_file_get_description(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_bookmark_file_get_groups(GLib.BookmarkFile bookmark, string uri, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_get_icon(GLib.BookmarkFile bookmark, string uri, string href, string mime_type, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_get_is_private(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_bookmark_file_get_mime_type(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_bookmark_file_get_modified(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_bookmark_file_get_size(GLib.BookmarkFile bookmark);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_bookmark_file_get_title(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_bookmark_file_get_uris(GLib.BookmarkFile bookmark, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_bookmark_file_get_visited(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_has_application(GLib.BookmarkFile bookmark, string uri, string name, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_has_group(GLib.BookmarkFile bookmark, string uri, string group, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_has_item(GLib.BookmarkFile bookmark, string uri);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_load_from_data(GLib.BookmarkFile bookmark, string data, ulong length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_load_from_data_dirs(GLib.BookmarkFile bookmark, System.IntPtr file, System.IntPtr full_path, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_load_from_file(GLib.BookmarkFile bookmark, System.IntPtr filename, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_move_item(GLib.BookmarkFile bookmark, string old_uri, string new_uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_remove_application(GLib.BookmarkFile bookmark, string uri, string name, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_remove_group(GLib.BookmarkFile bookmark, string uri, string group, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_remove_item(GLib.BookmarkFile bookmark, string uri, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_added(GLib.BookmarkFile bookmark, string uri, long added);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_set_app_info(GLib.BookmarkFile bookmark, string uri, string name, string exec, int count, long stamp, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_description(GLib.BookmarkFile bookmark, string uri, string description);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_groups(GLib.BookmarkFile bookmark, string uri, string groups, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_icon(GLib.BookmarkFile bookmark, string uri, string href, string mime_type);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_is_private(GLib.BookmarkFile bookmark, string uri, bool is_private);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_mime_type(GLib.BookmarkFile bookmark, string uri, string mime_type);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_modified(GLib.BookmarkFile bookmark, string uri, long modified);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_title(GLib.BookmarkFile bookmark, string uri, string title);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bookmark_file_set_visited(GLib.BookmarkFile bookmark, string uri, long visited);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_bookmark_file_to_data(GLib.BookmarkFile bookmark, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bookmark_file_to_file(GLib.BookmarkFile bookmark, System.IntPtr filename, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_bookmark_file_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.BookmarkFile g_bookmark_file_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Error g_error_new_literal(uint domain, int code, string message);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Error g_error_copy(GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_error_free(GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_error_matches(GLib.Error error, uint domain, int code);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_append(GLib.ByteArray array, System.IntPtr data, uint len);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_byte_array_free(GLib.ByteArray array, bool free_segment);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_byte_array_free_to_bytes(GLib.ByteArray array);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_new_take(System.IntPtr data, ulong len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_prepend(GLib.ByteArray array, System.IntPtr data, uint len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_ref(GLib.ByteArray array);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_remove_index(GLib.ByteArray array, uint index_);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_remove_index_fast(GLib.ByteArray array, uint index_);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_remove_range(GLib.ByteArray array, uint index_, uint length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_set_size(GLib.ByteArray array, uint length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_byte_array_sized_new(uint reserved_size);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_byte_array_sort(GLib.ByteArray array, System.IntPtr compare_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_byte_array_sort_with_data(GLib.ByteArray array, System.IntPtr compare_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_byte_array_unref(GLib.ByteArray array);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_bytes_new(System.IntPtr data, ulong size);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_bytes_new_static(System.IntPtr data, ulong size);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_bytes_new_take(System.IntPtr data, ulong size);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_bytes_new_with_free_func(System.IntPtr data, ulong size, System.IntPtr free_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_bytes_compare(GLib.Bytes bytes1, GLib.Bytes bytes2);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_bytes_equal(GLib.Bytes bytes1, GLib.Bytes bytes2);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_bytes_get_data(GLib.Bytes bytes, System.IntPtr size);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_bytes_get_size(GLib.Bytes bytes);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_bytes_hash(GLib.Bytes bytes);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_bytes_new_from_bytes(GLib.Bytes bytes, ulong offset, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_bytes_ref(GLib.Bytes bytes);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_bytes_unref(GLib.Bytes bytes);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ByteArray g_bytes_unref_to_array(GLib.Bytes bytes);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_bytes_unref_to_data(GLib.Bytes bytes, System.IntPtr size);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Checksum g_checksum_new(GLib.ChecksumType checksum_type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Checksum g_checksum_copy(GLib.Checksum checksum);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_checksum_free(GLib.Checksum checksum);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_checksum_get_digest(GLib.Checksum checksum, System.IntPtr buffer, System.IntPtr digest_len);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_checksum_get_string(GLib.Checksum checksum);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_checksum_reset(GLib.Checksum checksum);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_checksum_update(GLib.Checksum checksum, System.IntPtr data, long length);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_checksum_type_get_length(GLib.ChecksumType checksum_type);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_cond_broadcast(GLib.Cond cond);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_cond_clear(GLib.Cond cond);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_cond_init(GLib.Cond cond);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_cond_signal(GLib.Cond cond);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_cond_wait(GLib.Cond cond, System.IntPtr mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_cond_wait_until(GLib.Cond cond, System.IntPtr mutex, long end_time);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mutex_clear(System.IntPtr mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mutex_init(System.IntPtr mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mutex_lock(System.IntPtr mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_mutex_trylock(System.IntPtr mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mutex_unlock(System.IntPtr mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Date g_date_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Date g_date_new_dmy(byte day, GLib.DateMonth month, ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Date g_date_new_julian(uint julian_day);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_add_days(GLib.Date date, uint n_days);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_add_months(GLib.Date date, uint n_months);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_add_years(GLib.Date date, uint n_years);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_clamp(GLib.Date date, GLib.Date min_date, GLib.Date max_date);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_clear(GLib.Date date, uint n_dates);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_compare(GLib.Date lhs, GLib.Date rhs);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_days_between(GLib.Date date1, GLib.Date date2);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_free(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern byte g_date_get_day(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_date_get_day_of_year(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_date_get_iso8601_week_of_year(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_date_get_julian(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_date_get_monday_week_of_year(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateMonth g_date_get_month(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_date_get_sunday_week_of_year(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateWeekday g_date_get_weekday(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern ushort g_date_get_year(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_is_first_of_month(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_is_last_of_month(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_order(GLib.Date date1, GLib.Date date2);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_day(GLib.Date date, byte day);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_dmy(GLib.Date date, byte day, GLib.DateMonth month, ushort y);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_julian(GLib.Date date, uint julian_date);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_month(GLib.Date date, GLib.DateMonth month);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_parse(GLib.Date date, string str);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_time(GLib.Date date, int time_);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_time_t(GLib.Date date, long timet);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_time_val(GLib.Date date, GLib.TimeVal timeval);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_set_year(GLib.Date date, ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_subtract_days(GLib.Date date, uint n_days);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_subtract_months(GLib.Date date, uint n_months);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_subtract_years(GLib.Date date, uint n_years);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_to_struct_tm(GLib.Date date, System.IntPtr tm);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_valid(GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern byte g_date_get_days_in_month(GLib.DateMonth month, ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern byte g_date_get_monday_weeks_in_year(ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern byte g_date_get_sunday_weeks_in_year(ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_is_leap_year(ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_date_strftime(string s, ulong slen, string format, GLib.Date date);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_valid_day(byte day);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_valid_dmy(byte day, GLib.DateMonth month, ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_valid_julian(uint julian_date);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_valid_month(GLib.DateMonth month);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_valid_weekday(GLib.DateWeekday weekday);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_valid_year(ushort year);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new(GLib.TimeZone tz, int year, int month, int day, int hour, int minute, double seconds);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_from_timeval_local(GLib.TimeVal tv);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_from_timeval_utc(GLib.TimeVal tv);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_from_unix_local(long t);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_from_unix_utc(long t);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_local(int year, int month, int day, int hour, int minute, double seconds);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_now(GLib.TimeZone tz);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_now_local();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_now_utc();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_new_utc(int year, int month, int day, int hour, int minute, double seconds);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add(GLib.DateTime datetime, long timespan);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_days(GLib.DateTime datetime, int days);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_full(GLib.DateTime datetime, int years, int months, int days, int hours, int minutes, double seconds);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_hours(GLib.DateTime datetime, int hours);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_minutes(GLib.DateTime datetime, int minutes);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_months(GLib.DateTime datetime, int months);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_seconds(GLib.DateTime datetime, double seconds);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_weeks(GLib.DateTime datetime, int weeks);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_add_years(GLib.DateTime datetime, int years);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_date_time_difference(GLib.DateTime end, GLib.DateTime begin);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_date_time_format(GLib.DateTime datetime, string format);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_day_of_month(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_day_of_week(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_day_of_year(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_hour(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_microsecond(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_minute(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_month(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_second(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_date_time_get_seconds(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_date_time_get_timezone_abbreviation(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_date_time_get_utc_offset(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_week_numbering_year(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_week_of_year(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_get_year(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_time_get_ymd(GLib.DateTime datetime, System.IntPtr year, System.IntPtr month, System.IntPtr day);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_time_is_daylight_savings(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_ref(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_to_local(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_time_to_timeval(GLib.DateTime datetime, GLib.TimeVal tv);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_to_timezone(GLib.DateTime datetime, GLib.TimeZone tz);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_date_time_to_unix(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.DateTime g_date_time_to_utc(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_date_time_unref(GLib.DateTime datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_date_time_compare(System.IntPtr dt1, System.IntPtr dt2);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_date_time_equal(System.IntPtr dt1, System.IntPtr dt2);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_date_time_hash(System.IntPtr datetime);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TimeZone g_time_zone_new(string identifier);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TimeZone g_time_zone_new_local();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TimeZone g_time_zone_new_utc();
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_time_zone_adjust_time(GLib.TimeZone tz, GLib.TimeType type, System.IntPtr time_);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_time_zone_find_interval(GLib.TimeZone tz, GLib.TimeType type, long time_);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_time_zone_get_abbreviation(GLib.TimeZone tz, int interval);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_time_zone_get_offset(GLib.TimeZone tz, int interval);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_time_zone_is_dst(GLib.TimeZone tz, int interval);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TimeZone g_time_zone_ref(GLib.TimeZone tz);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_time_zone_unref(GLib.TimeZone tz);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_dir_close(GLib.Dir dir);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_dir_read_name(GLib.Dir dir);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_dir_rewind(GLib.Dir dir);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_dir_make_tmp(System.IntPtr tmpl, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Dir g_dir_open(string path, uint flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hash_table_add(System.IntPtr hash_table, System.IntPtr key);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hash_table_contains(System.IntPtr hash_table, System.IntPtr key);
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
		public static extern bool g_hash_table_insert(System.IntPtr hash_table, System.IntPtr key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_hash_table_lookup(System.IntPtr hash_table, System.IntPtr key);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hash_table_lookup_extended(System.IntPtr hash_table, System.IntPtr lookup_key, System.IntPtr orig_key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_hash_table_new(System.IntPtr hash_func, System.IntPtr key_equal_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_hash_table_new_full(System.IntPtr hash_func, System.IntPtr key_equal_func, System.IntPtr key_destroy_func, System.IntPtr value_destroy_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_hash_table_ref(System.IntPtr hash_table);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hash_table_remove(System.IntPtr hash_table, System.IntPtr key);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hash_table_remove_all(System.IntPtr hash_table);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hash_table_replace(System.IntPtr hash_table, System.IntPtr key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_hash_table_size(System.IntPtr hash_table);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hash_table_steal(System.IntPtr hash_table, System.IntPtr key);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hash_table_steal_all(System.IntPtr hash_table);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hash_table_unref(System.IntPtr hash_table);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_hash_table_iter_get_hash_table(GLib.HashTableIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hash_table_iter_init(GLib.HashTableIter iter, System.IntPtr hash_table);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hash_table_iter_next(GLib.HashTableIter iter, System.IntPtr key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hash_table_iter_remove(GLib.HashTableIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hash_table_iter_replace(GLib.HashTableIter iter, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hash_table_iter_steal(GLib.HashTableIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hmac g_hmac_copy(GLib.Hmac hmac);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hmac_get_digest(GLib.Hmac hmac, System.IntPtr buffer, System.IntPtr digest_len);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_hmac_get_string(GLib.Hmac hmac);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hmac g_hmac_ref(GLib.Hmac hmac);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hmac_unref(GLib.Hmac hmac);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hmac_update(GLib.Hmac hmac, System.IntPtr data, long length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hmac g_hmac_new(GLib.ChecksumType digest_type, System.IntPtr key, ulong key_len);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_hook_compare_ids(GLib.Hook new_hook, GLib.Hook sibling);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_alloc(GLib.HookList hook_list);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_hook_destroy(GLib.HookList hook_list, ulong hook_id);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_destroy_link(GLib.HookList hook_list, GLib.Hook hook);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_find(GLib.HookList hook_list, bool need_valids, System.IntPtr func, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_find_data(GLib.HookList hook_list, bool need_valids, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_find_func(GLib.HookList hook_list, bool need_valids, System.IntPtr func);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_find_func_data(GLib.HookList hook_list, bool need_valids, System.IntPtr func, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_first_valid(GLib.HookList hook_list, bool may_be_in_call);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_free(GLib.HookList hook_list, GLib.Hook hook);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_get(GLib.HookList hook_list, ulong hook_id);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_insert_before(GLib.HookList hook_list, GLib.Hook sibling, GLib.Hook hook);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_insert_sorted(GLib.HookList hook_list, GLib.Hook hook, System.IntPtr func);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_next_valid(GLib.HookList hook_list, GLib.Hook hook, bool may_be_in_call);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_prepend(GLib.HookList hook_list, GLib.Hook hook);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Hook g_hook_ref(GLib.HookList hook_list, GLib.Hook hook);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_unref(GLib.HookList hook_list, GLib.Hook hook);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_list_clear(GLib.HookList hook_list);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_list_init(GLib.HookList hook_list, uint hook_size);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_list_invoke(GLib.HookList hook_list, bool may_recurse);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_list_invoke_check(GLib.HookList hook_list, bool may_recurse);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_list_marshal(GLib.HookList hook_list, bool may_recurse, System.IntPtr marshaller, System.IntPtr marshal_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_hook_list_marshal_check(GLib.HookList hook_list, bool may_recurse, System.IntPtr marshaller, System.IntPtr marshal_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_append(GLib.String @string, string val);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_append_c(GLib.String @string, sbyte c);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_append_len(GLib.String @string, string val, long len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_append_unichar(GLib.String @string, uint wc);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_append_uri_escaped(GLib.String @string, string unescaped, string reserved_chars_allowed, bool allow_utf8);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_ascii_down(GLib.String @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_ascii_up(GLib.String @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_assign(GLib.String @string, string rval);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_down(GLib.String @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_string_equal(GLib.String v, GLib.String v2);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_erase(GLib.String @string, long pos, long len);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_string_free(GLib.String @string, bool free_segment);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_string_free_to_bytes(GLib.String @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_string_hash(GLib.String str);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_insert(GLib.String @string, long pos, string val);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_insert_c(GLib.String @string, long pos, sbyte c);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_insert_len(GLib.String @string, long pos, string val, long len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_insert_unichar(GLib.String @string, long pos, uint wc);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_overwrite(GLib.String @string, ulong pos, string val);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_overwrite_len(GLib.String @string, ulong pos, string val, long len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_prepend(GLib.String @string, string val);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_prepend_c(GLib.String @string, sbyte c);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_prepend_len(GLib.String @string, string val, long len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_prepend_unichar(GLib.String @string, uint wc);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_set_size(GLib.String @string, ulong len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_truncate(GLib.String @string, ulong len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_string_up(GLib.String @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOChannel g_io_channel_new_file(System.IntPtr filename, string mode, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOChannel g_io_channel_unix_new(int fd);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_io_channel_close(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_flush(GLib.IOChannel channel, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOCondition g_io_channel_get_buffer_condition(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_io_channel_get_buffer_size(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_io_channel_get_buffered(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_io_channel_get_close_on_unref(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_io_channel_get_encoding(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOFlags g_io_channel_get_flags(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_io_channel_get_line_term(GLib.IOChannel channel, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_io_channel_init(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOError g_io_channel_read(GLib.IOChannel channel, string buf, ulong count, System.IntPtr bytes_read);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_read_chars(GLib.IOChannel channel, System.IntPtr buf, ulong count, System.IntPtr bytes_read, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_read_line(GLib.IOChannel channel, string str_return, System.IntPtr length, System.IntPtr terminator_pos, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_read_line_string(GLib.IOChannel channel, GLib.String buffer, System.IntPtr terminator_pos, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_read_to_end(GLib.IOChannel channel, System.IntPtr str_return, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_read_unichar(GLib.IOChannel channel, System.IntPtr thechar, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOChannel g_io_channel_ref(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOError g_io_channel_seek(GLib.IOChannel channel, long offset, GLib.SeekType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_seek_position(GLib.IOChannel channel, long offset, GLib.SeekType type, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_io_channel_set_buffer_size(GLib.IOChannel channel, ulong size);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_io_channel_set_buffered(GLib.IOChannel channel, bool buffered);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_io_channel_set_close_on_unref(GLib.IOChannel channel, bool do_close);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_set_encoding(GLib.IOChannel channel, string encoding, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_set_flags(GLib.IOChannel channel, GLib.IOFlags flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_io_channel_set_line_term(GLib.IOChannel channel, string line_term, int length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_shutdown(GLib.IOChannel channel, bool flush, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_io_channel_unix_get_fd(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_io_channel_unref(GLib.IOChannel channel);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOError g_io_channel_write(GLib.IOChannel channel, string buf, ulong count, System.IntPtr bytes_written);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_write_chars(GLib.IOChannel channel, System.IntPtr buf, long count, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOStatus g_io_channel_write_unichar(GLib.IOChannel channel, uint thechar, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOChannelError g_io_channel_error_from_errno(int en);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_io_channel_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_source_new(GLib.SourceFuncs source_funcs, uint struct_size);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_add_child_source(GLib.Source source, GLib.Source child_source);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_add_poll(GLib.Source source, GLib.PollFD fd);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_source_add_unix_fd(GLib.Source source, int fd, GLib.IOCondition events);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_source_attach(GLib.Source source, GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_destroy(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_source_get_can_recurse(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainContext g_source_get_context(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_get_current_time(GLib.Source source, GLib.TimeVal timeval);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_source_get_id(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_source_get_name(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_source_get_priority(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_source_get_ready_time(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_source_get_time(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_source_is_destroyed(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_modify_unix_fd(GLib.Source source, System.IntPtr tag, GLib.IOCondition new_events);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.IOCondition g_source_query_unix_fd(GLib.Source source, System.IntPtr tag);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_source_ref(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_remove_child_source(GLib.Source source, GLib.Source child_source);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_remove_poll(GLib.Source source, GLib.PollFD fd);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_remove_unix_fd(GLib.Source source, System.IntPtr tag);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_callback(GLib.Source source, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_callback_indirect(GLib.Source source, System.IntPtr callback_data, GLib.SourceCallbackFuncs callback_funcs);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_can_recurse(GLib.Source source, bool can_recurse);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_funcs(GLib.Source source, GLib.SourceFuncs funcs);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_name(GLib.Source source, string name);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_priority(GLib.Source source, int priority);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_ready_time(GLib.Source source, long ready_time);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_unref(GLib.Source source);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_source_remove(uint tag);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_source_remove_by_funcs_user_data(GLib.SourceFuncs funcs, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_source_remove_by_user_data(System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_source_set_name_by_id(uint tag, string name);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.KeyFile g_key_file_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_free(GLib.KeyFile key_file);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_get_boolean(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_key_file_get_boolean_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_key_file_get_comment(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_key_file_get_double(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_key_file_get_double_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_key_file_get_groups(GLib.KeyFile key_file, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_key_file_get_int64(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_key_file_get_integer(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_key_file_get_integer_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_key_file_get_keys(GLib.KeyFile key_file, string group_name, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_key_file_get_locale_string(GLib.KeyFile key_file, string group_name, string key, string locale, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_key_file_get_locale_string_list(GLib.KeyFile key_file, string group_name, string key, string locale, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_key_file_get_start_group(GLib.KeyFile key_file);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_key_file_get_string(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_key_file_get_string_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_key_file_get_uint64(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_key_file_get_value(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_has_group(GLib.KeyFile key_file, string group_name);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_has_key(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_load_from_bytes(GLib.KeyFile key_file, GLib.Bytes bytes, GLib.KeyFileFlags flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_load_from_data(GLib.KeyFile key_file, string data, ulong length, GLib.KeyFileFlags flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_load_from_data_dirs(GLib.KeyFile key_file, System.IntPtr file, System.IntPtr full_path, GLib.KeyFileFlags flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_load_from_dirs(GLib.KeyFile key_file, System.IntPtr file, System.IntPtr search_dirs, System.IntPtr full_path, GLib.KeyFileFlags flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_load_from_file(GLib.KeyFile key_file, System.IntPtr file, GLib.KeyFileFlags flags, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.KeyFile g_key_file_ref(GLib.KeyFile key_file);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_remove_comment(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_remove_group(GLib.KeyFile key_file, string group_name, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_remove_key(GLib.KeyFile key_file, string group_name, string key, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_save_to_file(GLib.KeyFile key_file, string filename, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_boolean(GLib.KeyFile key_file, string group_name, string key, bool value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_boolean_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr list, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_key_file_set_comment(GLib.KeyFile key_file, string group_name, string key, string comment, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_double(GLib.KeyFile key_file, string group_name, string key, double value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_double_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr list, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_int64(GLib.KeyFile key_file, string group_name, string key, long value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_integer(GLib.KeyFile key_file, string group_name, string key, int value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_integer_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr list, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_list_separator(GLib.KeyFile key_file, sbyte separator);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_locale_string(GLib.KeyFile key_file, string group_name, string key, string locale, string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_locale_string_list(GLib.KeyFile key_file, string group_name, string key, string locale, System.IntPtr list, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_string(GLib.KeyFile key_file, string group_name, string key, string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_string_list(GLib.KeyFile key_file, string group_name, string key, System.IntPtr list, ulong length);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_uint64(GLib.KeyFile key_file, string group_name, string key, ulong value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_set_value(GLib.KeyFile key_file, string group_name, string key, string value);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_key_file_to_data(GLib.KeyFile key_file, System.IntPtr length, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_key_file_unref(GLib.KeyFile key_file);
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
		public static extern GLib.MainContext g_main_context_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_context_acquire(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_add_poll(GLib.MainContext context, GLib.PollFD fd, int priority);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_context_check(GLib.MainContext context, int max_priority, System.IntPtr fds, int n_fds);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_dispatch(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_main_context_find_source_by_funcs_user_data(GLib.MainContext context, GLib.SourceFuncs funcs, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_main_context_find_source_by_id(GLib.MainContext context, uint source_id);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Source g_main_context_find_source_by_user_data(GLib.MainContext context, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_main_context_get_poll_func(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_invoke(GLib.MainContext context, System.IntPtr function, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_invoke_full(GLib.MainContext context, int priority, System.IntPtr function, System.IntPtr data, System.IntPtr notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_context_is_owner(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_context_iteration(GLib.MainContext context, bool may_block);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_context_pending(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_pop_thread_default(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_context_prepare(GLib.MainContext context, System.IntPtr priority);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_push_thread_default(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_main_context_query(GLib.MainContext context, int max_priority, System.IntPtr timeout_, System.IntPtr fds, int n_fds);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainContext g_main_context_ref(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_release(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_remove_poll(GLib.MainContext context, GLib.PollFD fd);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_set_poll_func(GLib.MainContext context, System.IntPtr func);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_unref(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_context_wait(GLib.MainContext context, GLib.Cond cond, System.IntPtr mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_context_wakeup(GLib.MainContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainContext g_main_context_default();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainContext g_main_context_get_thread_default();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainContext g_main_context_ref_thread_default();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainLoop g_main_loop_new(GLib.MainContext context, bool is_running);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainContext g_main_loop_get_context(GLib.MainLoop loop);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_main_loop_is_running(GLib.MainLoop loop);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_loop_quit(GLib.MainLoop loop);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MainLoop g_main_loop_ref(GLib.MainLoop loop);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_loop_run(GLib.MainLoop loop);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_main_loop_unref(GLib.MainLoop loop);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MappedFile g_mapped_file_new(System.IntPtr filename, bool writable, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MappedFile g_mapped_file_new_from_fd(int fd, bool writable, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mapped_file_free(GLib.MappedFile file);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_mapped_file_get_bytes(GLib.MappedFile file);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_mapped_file_get_contents(GLib.MappedFile file);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_mapped_file_get_length(GLib.MappedFile file);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MappedFile g_mapped_file_ref(GLib.MappedFile file);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_mapped_file_unref(GLib.MappedFile file);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MarkupParseContext g_markup_parse_context_new(GLib.MarkupParser parser, GLib.MarkupParseFlags flags, System.IntPtr user_data, System.IntPtr user_data_dnotify);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_markup_parse_context_end_parse(GLib.MarkupParseContext context, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_markup_parse_context_free(GLib.MarkupParseContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_markup_parse_context_get_element(GLib.MarkupParseContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_markup_parse_context_get_element_stack(GLib.MarkupParseContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_markup_parse_context_get_position(GLib.MarkupParseContext context, System.IntPtr line_number, System.IntPtr char_number);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_markup_parse_context_get_user_data(GLib.MarkupParseContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_markup_parse_context_parse(GLib.MarkupParseContext context, string text, long text_len, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_markup_parse_context_pop(GLib.MarkupParseContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_markup_parse_context_push(GLib.MarkupParseContext context, GLib.MarkupParser parser, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MarkupParseContext g_markup_parse_context_ref(GLib.MarkupParseContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_markup_parse_context_unref(GLib.MarkupParseContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_match_info_expand_references(GLib.MatchInfo match_info, string string_to_expand, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_match_info_fetch(GLib.MatchInfo match_info, int match_num);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_match_info_fetch_all(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_match_info_fetch_named(GLib.MatchInfo match_info, string name);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_match_info_fetch_named_pos(GLib.MatchInfo match_info, string name, System.IntPtr start_pos, System.IntPtr end_pos);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_match_info_fetch_pos(GLib.MatchInfo match_info, int match_num, System.IntPtr start_pos, System.IntPtr end_pos);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_match_info_free(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_match_info_get_match_count(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Regex g_match_info_get_regex(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_match_info_get_string(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_match_info_is_partial_match(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_match_info_matches(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_match_info_next(GLib.MatchInfo match_info, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.MatchInfo g_match_info_ref(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_match_info_unref(GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Regex g_regex_new(string pattern, GLib.RegexCompileFlags compile_options, GLib.RegexMatchFlags match_options, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_regex_get_capture_count(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.RegexCompileFlags g_regex_get_compile_flags(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_regex_get_has_cr_or_lf(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.RegexMatchFlags g_regex_get_match_flags(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_regex_get_max_backref(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_regex_get_max_lookbehind(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_regex_get_pattern(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_regex_get_string_number(GLib.Regex regex, string name);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_regex_match(GLib.Regex regex, string @string, GLib.RegexMatchFlags match_options, out GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_regex_match_all(GLib.Regex regex, string @string, GLib.RegexMatchFlags match_options, out GLib.MatchInfo match_info);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_regex_match_all_full(GLib.Regex regex, System.IntPtr @string, long string_len, int start_position, GLib.RegexMatchFlags match_options, out GLib.MatchInfo match_info, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_regex_match_full(GLib.Regex regex, System.IntPtr @string, long string_len, int start_position, GLib.RegexMatchFlags match_options, out GLib.MatchInfo match_info, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Regex g_regex_ref(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_regex_replace(GLib.Regex regex, System.IntPtr @string, long string_len, int start_position, string replacement, GLib.RegexMatchFlags match_options, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_regex_replace_eval(GLib.Regex regex, System.IntPtr @string, long string_len, int start_position, GLib.RegexMatchFlags match_options, System.IntPtr eval, System.IntPtr user_data, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_regex_replace_literal(GLib.Regex regex, System.IntPtr @string, long string_len, int start_position, string replacement, GLib.RegexMatchFlags match_options, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_regex_split(GLib.Regex regex, string @string, GLib.RegexMatchFlags match_options);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_regex_split_full(GLib.Regex regex, System.IntPtr @string, long string_len, int start_position, GLib.RegexMatchFlags match_options, int max_tokens, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_regex_unref(GLib.Regex regex);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_regex_check_replacement(string replacement, System.IntPtr has_references, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_regex_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_regex_escape_nul(string @string, int length);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_regex_escape_string(System.IntPtr @string, int length);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_regex_match_simple(string pattern, string @string, GLib.RegexCompileFlags compile_options, GLib.RegexMatchFlags match_options);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_regex_split_simple(string pattern, string @string, GLib.RegexCompileFlags compile_options, GLib.RegexMatchFlags match_options);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_node_child_index(GLib.Node node, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_node_child_position(GLib.Node node, GLib.Node child);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_node_children_foreach(GLib.Node node, GLib.TraverseFlags flags, System.IntPtr func, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_copy(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_copy_deep(GLib.Node node, System.IntPtr copy_func, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_node_depth(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_node_destroy(GLib.Node root);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_find(GLib.Node root, GLib.TraverseType order, GLib.TraverseFlags flags, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_find_child(GLib.Node node, GLib.TraverseFlags flags, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_first_sibling(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_get_root(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_insert(GLib.Node parent, int position, GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_insert_after(GLib.Node parent, GLib.Node sibling, GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_insert_before(GLib.Node parent, GLib.Node sibling, GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_node_is_ancestor(GLib.Node node, GLib.Node descendant);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_last_child(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_last_sibling(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_node_max_height(GLib.Node root);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_node_n_children(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_node_n_nodes(GLib.Node root, GLib.TraverseFlags flags);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_nth_child(GLib.Node node, uint n);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_prepend(GLib.Node parent, GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_node_reverse_children(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_node_traverse(GLib.Node root, GLib.TraverseType order, GLib.TraverseFlags flags, int max_depth, System.IntPtr func, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_node_unlink(GLib.Node node);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Node g_node_new(System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_once_impl(GLib.Once once, System.IntPtr func, System.IntPtr arg);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_once_init_enter(System.IntPtr location);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_once_init_leave(System.IntPtr location, ulong result);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_add_group(GLib.OptionContext context, GLib.OptionGroup group);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_add_main_entries(GLib.OptionContext context, GLib.OptionEntry entries, string translation_domain);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_free(GLib.OptionContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_option_context_get_description(GLib.OptionContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_option_context_get_help(GLib.OptionContext context, bool main_help, GLib.OptionGroup group);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_option_context_get_help_enabled(GLib.OptionContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_option_context_get_ignore_unknown_options(GLib.OptionContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.OptionGroup g_option_context_get_main_group(GLib.OptionContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_option_context_get_strict_posix(GLib.OptionContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_option_context_get_summary(GLib.OptionContext context);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_option_context_parse(GLib.OptionContext context, System.IntPtr argc, System.IntPtr argv, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_option_context_parse_strv(GLib.OptionContext context, System.IntPtr arguments, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_description(GLib.OptionContext context, string description);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_help_enabled(GLib.OptionContext context, bool help_enabled);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_ignore_unknown_options(GLib.OptionContext context, bool ignore_unknown);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_main_group(GLib.OptionContext context, GLib.OptionGroup group);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_strict_posix(GLib.OptionContext context, bool strict_posix);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_summary(GLib.OptionContext context, string summary);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_translate_func(GLib.OptionContext context, System.IntPtr func, System.IntPtr data, System.IntPtr destroy_notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_context_set_translation_domain(GLib.OptionContext context, string domain);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.OptionContext g_option_context_new(string parameter_string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.OptionGroup g_option_group_new(string name, string description, string help_description, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_group_add_entries(GLib.OptionGroup group, GLib.OptionEntry entries);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_group_free(GLib.OptionGroup group);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.OptionGroup g_option_group_ref(GLib.OptionGroup group);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_group_set_error_hook(GLib.OptionGroup group, System.IntPtr error_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_group_set_parse_hooks(GLib.OptionGroup group, System.IntPtr pre_parse_func, System.IntPtr post_parse_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_group_set_translate_func(GLib.OptionGroup group, System.IntPtr func, System.IntPtr data, System.IntPtr destroy_notify);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_group_set_translation_domain(GLib.OptionGroup group, string domain);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_option_group_unref(GLib.OptionGroup group);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_pattern_spec_equal(GLib.PatternSpec pspec1, GLib.PatternSpec pspec2);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_pattern_spec_free(GLib.PatternSpec pspec);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.PatternSpec g_pattern_spec_new(string pattern);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_private_get(GLib.Private key);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_private_replace(GLib.Private key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_private_set(GLib.Private key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_ptr_array_add(System.IntPtr array, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_ptr_array_find(System.IntPtr haystack, System.IntPtr needle, System.IntPtr index_);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_ptr_array_find_with_equal_func(System.IntPtr haystack, System.IntPtr needle, System.IntPtr equal_func, System.IntPtr index_);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_ptr_array_foreach(System.IntPtr array, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_ptr_array_free(System.IntPtr array, bool free_seg);
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
		public static extern bool g_ptr_array_remove(System.IntPtr array, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_ptr_array_remove_fast(System.IntPtr array, System.IntPtr data);
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
		public static extern void g_queue_clear(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Queue g_queue_copy(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_delete_link(GLib.Queue queue, System.IntPtr link_);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_find(GLib.Queue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_find_custom(GLib.Queue queue, System.IntPtr data, System.IntPtr func);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_foreach(GLib.Queue queue, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_free(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_free_full(GLib.Queue queue, System.IntPtr free_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_queue_get_length(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_queue_index(GLib.Queue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_init(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_insert_after(GLib.Queue queue, System.IntPtr sibling, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_insert_before(GLib.Queue queue, System.IntPtr sibling, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_insert_sorted(GLib.Queue queue, System.IntPtr data, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_queue_is_empty(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_queue_link_index(GLib.Queue queue, System.IntPtr link_);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_peek_head(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_peek_head_link(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_peek_nth(GLib.Queue queue, uint n);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_peek_nth_link(GLib.Queue queue, uint n);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_peek_tail(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_peek_tail_link(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_pop_head(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_pop_head_link(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_pop_nth(GLib.Queue queue, uint n);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_pop_nth_link(GLib.Queue queue, uint n);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_pop_tail(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_queue_pop_tail_link(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_push_head(GLib.Queue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_push_head_link(GLib.Queue queue, System.IntPtr link_);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_push_nth(GLib.Queue queue, System.IntPtr data, int n);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_push_nth_link(GLib.Queue queue, int n, System.IntPtr link_);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_push_tail(GLib.Queue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_push_tail_link(GLib.Queue queue, System.IntPtr link_);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_queue_remove(GLib.Queue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_queue_remove_all(GLib.Queue queue, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_reverse(GLib.Queue queue);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_sort(GLib.Queue queue, System.IntPtr compare_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_queue_unlink(GLib.Queue queue, System.IntPtr link_);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Queue g_queue_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rw_lock_clear(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rw_lock_init(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rw_lock_reader_lock(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_rw_lock_reader_trylock(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rw_lock_reader_unlock(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rw_lock_writer_lock(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_rw_lock_writer_trylock(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rw_lock_writer_unlock(GLib.RWLock rw_lock);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Rand g_rand_copy(GLib.Rand rand_);
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_rand_double(GLib.Rand rand_);
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_rand_double_range(GLib.Rand rand_, double begin, double end);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rand_free(GLib.Rand rand_);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_rand_int(GLib.Rand rand_);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_rand_int_range(GLib.Rand rand_, int begin, int end);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rand_set_seed(GLib.Rand rand_, uint seed);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rand_set_seed_array(GLib.Rand rand_, System.IntPtr seed, uint seed_length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Rand g_rand_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Rand g_rand_new_with_seed(uint seed);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Rand g_rand_new_with_seed_array(System.IntPtr seed, uint seed_length);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rec_mutex_clear(GLib.RecMutex rec_mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rec_mutex_init(GLib.RecMutex rec_mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rec_mutex_lock(GLib.RecMutex rec_mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_rec_mutex_trylock(GLib.RecMutex rec_mutex);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_rec_mutex_unlock(GLib.RecMutex rec_mutex);
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
		public static extern uint g_scanner_cur_line(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_scanner_cur_position(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TokenType g_scanner_cur_token(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_destroy(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_scanner_eof(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TokenType g_scanner_get_next_token(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_input_file(GLib.Scanner scanner, int input_fd);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_input_text(GLib.Scanner scanner, string text, uint text_len);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_scanner_lookup_symbol(GLib.Scanner scanner, string symbol);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TokenType g_scanner_peek_next_token(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_scope_add_symbol(GLib.Scanner scanner, uint scope_id, string symbol, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_scope_foreach_symbol(GLib.Scanner scanner, uint scope_id, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_scanner_scope_lookup_symbol(GLib.Scanner scanner, uint scope_id, string symbol);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_scope_remove_symbol(GLib.Scanner scanner, uint scope_id, string symbol);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_scanner_set_scope(GLib.Scanner scanner, uint scope_id);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_sync_file_offset(GLib.Scanner scanner);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_scanner_unexp_token(GLib.Scanner scanner, GLib.TokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Scanner g_scanner_new(GLib.ScannerConfig config_templ);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_sequence_iter_compare(GLib.SequenceIter a, GLib.SequenceIter b);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_sequence_iter_get_position(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Sequence g_sequence_iter_get_sequence(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_sequence_iter_is_begin(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_sequence_iter_is_end(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_iter_move(GLib.SequenceIter iter, int delta);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_iter_next(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_iter_prev(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_append(GLib.Sequence seq, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_foreach(GLib.Sequence seq, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_free(GLib.Sequence seq);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_get_begin_iter(GLib.Sequence seq);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_get_end_iter(GLib.Sequence seq);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_get_iter_at_pos(GLib.Sequence seq, int pos);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_sequence_get_length(GLib.Sequence seq);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_insert_sorted(GLib.Sequence seq, System.IntPtr data, System.IntPtr cmp_func, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_insert_sorted_iter(GLib.Sequence seq, System.IntPtr data, System.IntPtr iter_cmp, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_sequence_is_empty(GLib.Sequence seq);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_lookup(GLib.Sequence seq, System.IntPtr data, System.IntPtr cmp_func, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_lookup_iter(GLib.Sequence seq, System.IntPtr data, System.IntPtr iter_cmp, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_prepend(GLib.Sequence seq, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_search(GLib.Sequence seq, System.IntPtr data, System.IntPtr cmp_func, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_search_iter(GLib.Sequence seq, System.IntPtr data, System.IntPtr iter_cmp, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_sort(GLib.Sequence seq, System.IntPtr cmp_func, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_sort_iter(GLib.Sequence seq, System.IntPtr cmp_func, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_foreach_range(GLib.SequenceIter begin, GLib.SequenceIter end, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_sequence_get(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_insert_before(GLib.SequenceIter iter, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_move(GLib.SequenceIter src, GLib.SequenceIter dest);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_move_range(GLib.SequenceIter dest, GLib.SequenceIter begin, GLib.SequenceIter end);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Sequence g_sequence_new(System.IntPtr data_destroy);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.SequenceIter g_sequence_range_get_midpoint(GLib.SequenceIter begin, GLib.SequenceIter end);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_remove(GLib.SequenceIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_remove_range(GLib.SequenceIter begin, GLib.SequenceIter end);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_set(GLib.SequenceIter iter, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_sort_changed(GLib.SequenceIter iter, System.IntPtr cmp_func, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_sort_changed_iter(GLib.SequenceIter iter, System.IntPtr iter_cmp, System.IntPtr cmp_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_sequence_swap(GLib.SequenceIter a, GLib.SequenceIter b);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_string_chunk_clear(GLib.StringChunk chunk);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_string_chunk_free(GLib.StringChunk chunk);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_string_chunk_insert(GLib.StringChunk chunk, string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_string_chunk_insert_const(GLib.StringChunk chunk, string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_string_chunk_insert_len(GLib.StringChunk chunk, string @string, long len);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.StringChunk g_string_chunk_new(ulong size);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_log_buffer_free(GLib.TestLogBuffer tbuffer);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TestLogMsg g_test_log_buffer_pop(GLib.TestLogBuffer tbuffer);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_log_buffer_push(GLib.TestLogBuffer tbuffer, uint n_bytes, System.IntPtr bytes);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.TestLogBuffer g_test_log_buffer_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_log_msg_free(GLib.TestLogMsg tmsg);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_suite_add(GLib.TestSuite suite, GLib.TestCase test_case);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_test_suite_add_suite(GLib.TestSuite suite, GLib.TestSuite nestedsuite);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Thread g_thread_new(string name, System.IntPtr func, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Thread g_thread_try_new(string name, System.IntPtr func, System.IntPtr data, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_thread_join(GLib.Thread thread);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Thread g_thread_ref(GLib.Thread thread);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_unref(GLib.Thread thread);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_thread_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_exit(System.IntPtr retval);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Thread g_thread_self();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_yield();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_pool_free(GLib.ThreadPool pool, bool immediate, bool wait_);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_thread_pool_get_max_threads(GLib.ThreadPool pool);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_thread_pool_get_num_threads(GLib.ThreadPool pool);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_thread_pool_move_to_front(GLib.ThreadPool pool, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_thread_pool_push(GLib.ThreadPool pool, System.IntPtr data, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_thread_pool_set_max_threads(GLib.ThreadPool pool, int max_threads, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_pool_set_sort_function(GLib.ThreadPool pool, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_thread_pool_unprocessed(GLib.ThreadPool pool);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_thread_pool_get_max_idle_time();
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_thread_pool_get_max_unused_threads();
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_thread_pool_get_num_unused_threads();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.ThreadPool g_thread_pool_new(System.IntPtr func, System.IntPtr user_data, int max_threads, bool exclusive, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_pool_set_max_idle_time(uint interval);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_pool_set_max_unused_threads(int max_threads);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_thread_pool_stop_unused_threads();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_timer_continue(GLib.Timer timer);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_timer_destroy(GLib.Timer timer);
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_timer_elapsed(GLib.Timer timer, System.IntPtr microseconds);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_timer_reset(GLib.Timer timer);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_timer_start(GLib.Timer timer);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_timer_stop(GLib.Timer timer);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Timer g_timer_new();
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_tree_destroy(GLib.Tree tree);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_tree_foreach(GLib.Tree tree, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_tree_height(GLib.Tree tree);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_tree_insert(GLib.Tree tree, System.IntPtr key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_tree_lookup(GLib.Tree tree, System.IntPtr key);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_tree_lookup_extended(GLib.Tree tree, System.IntPtr lookup_key, System.IntPtr orig_key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_tree_nnodes(GLib.Tree tree);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Tree g_tree_ref(GLib.Tree tree);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_tree_remove(GLib.Tree tree, System.IntPtr key);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_tree_replace(GLib.Tree tree, System.IntPtr key, System.IntPtr value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_tree_search(GLib.Tree tree, System.IntPtr search_func, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_tree_steal(GLib.Tree tree, System.IntPtr key);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_tree_traverse(GLib.Tree tree, System.IntPtr traverse_func, GLib.TraverseType traverse_type, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_tree_unref(GLib.Tree tree);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Tree g_tree_new(System.IntPtr key_compare_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Tree g_tree_new_full(System.IntPtr key_compare_func, System.IntPtr key_compare_data, System.IntPtr key_destroy_func, System.IntPtr value_destroy_func);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Tree g_tree_new_with_data(System.IntPtr key_compare_func, System.IntPtr key_compare_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_array(GLib.VariantType child_type, System.IntPtr children, ulong n_children);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_boolean(bool value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_byte(byte value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_bytestring(System.IntPtr @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_bytestring_array(System.IntPtr strv, long length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_dict_entry(GLib.Variant key, GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_double(double value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_fixed_array(GLib.VariantType element_type, System.IntPtr elements, ulong n_elements, ulong element_size);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_from_bytes(GLib.VariantType type, GLib.Bytes bytes, bool trusted);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_from_data(GLib.VariantType type, System.IntPtr data, ulong size, bool trusted, System.IntPtr notify, System.IntPtr user_data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_handle(int value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_int16(short value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_int32(int value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_int64(long value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_maybe(GLib.VariantType child_type, GLib.Variant child);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_object_path(string object_path);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_objv(System.IntPtr strv, long length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_parsed_va(string format, System.IntPtr app);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_signature(string signature);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_string(string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_strv(System.IntPtr strv, long length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_take_string(string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_tuple(System.IntPtr children, ulong n_children);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_uint16(ushort value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_uint32(uint value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_uint64(ulong value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_va(string format_string, string endptr, System.IntPtr app);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_new_variant(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_byteswap(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_check_format_string(GLib.Variant value, string format_string, bool copy_only);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantClass g_variant_classify(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_variant_compare(GLib.Variant one, GLib.Variant two);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_dup_bytestring(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_dup_bytestring_array(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_dup_objv(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_variant_dup_string(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_dup_strv(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_equal(GLib.Variant one, GLib.Variant two);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_get_boolean(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern byte g_variant_get_byte(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_get_bytestring(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_get_bytestring_array(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_get_child_value(GLib.Variant value, ulong index_);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_get_data(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Bytes g_variant_get_data_as_bytes(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern double g_variant_get_double(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_get_fixed_array(GLib.Variant value, System.IntPtr n_elements, ulong element_size);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_variant_get_handle(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern short g_variant_get_int16(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern int g_variant_get_int32(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern long g_variant_get_int64(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_get_maybe(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_get_normal_form(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_get_objv(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_variant_get_size(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_variant_get_string(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern System.IntPtr g_variant_get_strv(GLib.Variant value, System.IntPtr length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_get_type(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_variant_get_type_string(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern ushort g_variant_get_uint16(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_variant_get_uint32(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_variant_get_uint64(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_get_va(GLib.Variant value, string format_string, string endptr, System.IntPtr app);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_get_variant(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_variant_hash(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_is_container(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_is_floating(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_is_normal_form(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_is_of_type(GLib.Variant value, GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantIter g_variant_iter_new(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_lookup_value(GLib.Variant dictionary, string key, GLib.VariantType expected_type);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_variant_n_children(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_variant_print(GLib.Variant value, bool type_annotate);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.String g_variant_print_string(GLib.Variant value, GLib.String @string, bool type_annotate);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_ref(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_ref_sink(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_store(GLib.Variant value, System.IntPtr data);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_take_ref(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_unref(GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_is_object_path(string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_is_signature(string @string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_parse(GLib.VariantType type, string text, string limit, string endptr, out GLib.Error error);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_variant_parse_error_print_context(GLib.Error error, string source_str);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_variant_parse_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_variant_parser_get_error_quark();
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_new(string type_string);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_new_array(GLib.VariantType element);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_new_dict_entry(GLib.VariantType key, GLib.VariantType value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_new_maybe(GLib.VariantType element);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_new_tuple(System.IntPtr items, int length);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_copy(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_variant_type_dup_string(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_element(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_equal(GLib.VariantType type1, GLib.VariantType type2);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_first(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_type_free(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_variant_type_get_string_length(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern uint g_variant_type_hash(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_array(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_basic(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_container(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_definite(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_dict_entry(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_maybe(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_subtype_of(GLib.VariantType type, GLib.VariantType supertype);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_tuple(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_is_variant(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_key(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_variant_type_n_items(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_next(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern string g_variant_type_peek_string(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_value(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantType g_variant_type_checked_(string arg0);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_string_is_valid(string type_string);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_type_string_scan(string @string, string limit, string endptr);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantIter g_variant_iter_copy(GLib.VariantIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_iter_free(GLib.VariantIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_variant_iter_init(GLib.VariantIter iter, GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern ulong g_variant_iter_n_children(GLib.VariantIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_iter_next_value(GLib.VariantIter iter);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantBuilder g_variant_builder_new(GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_builder_add_value(GLib.VariantBuilder builder, GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_builder_clear(GLib.VariantBuilder builder);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_builder_close(GLib.VariantBuilder builder);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_builder_end(GLib.VariantBuilder builder);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_builder_init(GLib.VariantBuilder builder, GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_builder_open(GLib.VariantBuilder builder, GLib.VariantType type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantBuilder g_variant_builder_ref(GLib.VariantBuilder builder);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_builder_unref(GLib.VariantBuilder builder);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantDict g_variant_dict_new(GLib.Variant from_asv);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_dict_clear(GLib.VariantDict dict);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_dict_contains(GLib.VariantDict dict, string key);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_dict_end(GLib.VariantDict dict);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_dict_init(GLib.VariantDict dict, GLib.Variant from_asv);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_dict_insert_value(GLib.VariantDict dict, string key, GLib.Variant value);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.Variant g_variant_dict_lookup_value(GLib.VariantDict dict, string key, GLib.VariantType expected_type);
		[DllImport("libglib-2.0.so.0")]
		public static extern GLib.VariantDict g_variant_dict_ref(GLib.VariantDict dict);
		[DllImport("libglib-2.0.so.0")]
		public static extern bool g_variant_dict_remove(GLib.VariantDict dict, string key);
		[DllImport("libglib-2.0.so.0")]
		public static extern void g_variant_dict_unref(GLib.VariantDict dict);
	}
}
