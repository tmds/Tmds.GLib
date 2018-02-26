using System;
using System.Runtime.InteropServices;
namespace Gio {
	public ref struct Action
	{
		private IntPtr _pointer;
		public static explicit operator Action(IntPtr pointer) => new Action { _pointer = pointer };
		public static explicit operator IntPtr(Action value) => value._pointer
;	}
	public ref struct SimpleAction
	{
		private IntPtr _pointer;
		public static explicit operator SimpleAction(IntPtr pointer) => new SimpleAction { _pointer = pointer };
		public static explicit operator IntPtr(SimpleAction value) => value._pointer
;		public static implicit operator GObject.Object(SimpleAction value) => (GObject.Object)value._pointer
;		public static explicit operator SimpleAction(GObject.Object value) => (SimpleAction)(IntPtr)value
;	}
	public ref struct ActionEntry
	{
		private IntPtr _pointer;
		public static explicit operator ActionEntry(IntPtr pointer) => new ActionEntry { _pointer = pointer };
		public static explicit operator IntPtr(ActionEntry value) => value._pointer
;	}
	public ref struct ActionGroup
	{
		private IntPtr _pointer;
		public static explicit operator ActionGroup(IntPtr pointer) => new ActionGroup { _pointer = pointer };
		public static explicit operator IntPtr(ActionGroup value) => value._pointer
;	}
	public ref struct ActionGroupInterface
	{
		private IntPtr _pointer;
		public static explicit operator ActionGroupInterface(IntPtr pointer) => new ActionGroupInterface { _pointer = pointer };
		public static explicit operator IntPtr(ActionGroupInterface value) => value._pointer
;	}
	public ref struct ActionInterface
	{
		private IntPtr _pointer;
		public static explicit operator ActionInterface(IntPtr pointer) => new ActionInterface { _pointer = pointer };
		public static explicit operator IntPtr(ActionInterface value) => value._pointer
;	}
	public ref struct ActionMap
	{
		private IntPtr _pointer;
		public static explicit operator ActionMap(IntPtr pointer) => new ActionMap { _pointer = pointer };
		public static explicit operator IntPtr(ActionMap value) => value._pointer
;	}
	public ref struct ActionMapInterface
	{
		private IntPtr _pointer;
		public static explicit operator ActionMapInterface(IntPtr pointer) => new ActionMapInterface { _pointer = pointer };
		public static explicit operator IntPtr(ActionMapInterface value) => value._pointer
;	}
	public ref struct AppInfo
	{
		private IntPtr _pointer;
		public static explicit operator AppInfo(IntPtr pointer) => new AppInfo { _pointer = pointer };
		public static explicit operator IntPtr(AppInfo value) => value._pointer
;	}
	[Flags]
	public enum AppInfoCreateFlags
	{
		none = 0,
		needs_terminal = 1,
		supports_uris = 2,
		supports_startup_notification = 4,
	}
	public ref struct AppLaunchContext
	{
		private IntPtr _pointer;
		public static explicit operator AppLaunchContext(IntPtr pointer) => new AppLaunchContext { _pointer = pointer };
		public static explicit operator IntPtr(AppLaunchContext value) => value._pointer
;		public static implicit operator GObject.Object(AppLaunchContext value) => (GObject.Object)value._pointer
;		public static explicit operator AppLaunchContext(GObject.Object value) => (AppLaunchContext)(IntPtr)value
;	}
	public ref struct Cancellable
	{
		private IntPtr _pointer;
		public static explicit operator Cancellable(IntPtr pointer) => new Cancellable { _pointer = pointer };
		public static explicit operator IntPtr(Cancellable value) => value._pointer
;		public static implicit operator GObject.Object(Cancellable value) => (GObject.Object)value._pointer
;		public static explicit operator Cancellable(GObject.Object value) => (Cancellable)(IntPtr)value
;	}
	public ref struct AsyncResult
	{
		private IntPtr _pointer;
		public static explicit operator AsyncResult(IntPtr pointer) => new AsyncResult { _pointer = pointer };
		public static explicit operator IntPtr(AsyncResult value) => value._pointer
;	}
	public ref struct Icon
	{
		private IntPtr _pointer;
		public static explicit operator Icon(IntPtr pointer) => new Icon { _pointer = pointer };
		public static explicit operator IntPtr(Icon value) => value._pointer
;	}
	public ref struct File
	{
		private IntPtr _pointer;
		public static explicit operator File(IntPtr pointer) => new File { _pointer = pointer };
		public static explicit operator IntPtr(File value) => value._pointer
;	}
	public ref struct AppInfoIface
	{
		private IntPtr _pointer;
		public static explicit operator AppInfoIface(IntPtr pointer) => new AppInfoIface { _pointer = pointer };
		public static explicit operator IntPtr(AppInfoIface value) => value._pointer
;	}
	public ref struct AppInfoMonitor
	{
		private IntPtr _pointer;
		public static explicit operator AppInfoMonitor(IntPtr pointer) => new AppInfoMonitor { _pointer = pointer };
		public static explicit operator IntPtr(AppInfoMonitor value) => value._pointer
;		public static implicit operator GObject.Object(AppInfoMonitor value) => (GObject.Object)value._pointer
;		public static explicit operator AppInfoMonitor(GObject.Object value) => (AppInfoMonitor)(IntPtr)value
;	}
	public ref struct AppLaunchContextPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AppLaunchContextPrivate(IntPtr pointer) => new AppLaunchContextPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AppLaunchContextPrivate value) => value._pointer
;	}
	public ref struct AppLaunchContextClass
	{
		private IntPtr _pointer;
		public static explicit operator AppLaunchContextClass(IntPtr pointer) => new AppLaunchContextClass { _pointer = pointer };
		public static explicit operator IntPtr(AppLaunchContextClass value) => value._pointer
;	}
	public ref struct Application
	{
		private IntPtr _pointer;
		public static explicit operator Application(IntPtr pointer) => new Application { _pointer = pointer };
		public static explicit operator IntPtr(Application value) => value._pointer
;		public static implicit operator GObject.Object(Application value) => (GObject.Object)value._pointer
;		public static explicit operator Application(GObject.Object value) => (Application)(IntPtr)value
;	}
	[Flags]
	public enum ApplicationFlags
	{
		flags_none = 0,
		is_service = 1,
		is_launcher = 2,
		handles_open = 4,
		handles_command_line = 8,
		send_environment = 16,
		non_unique = 32,
		can_override_app_id = 64,
	}
	public ref struct DBusConnection
	{
		private IntPtr _pointer;
		public static explicit operator DBusConnection(IntPtr pointer) => new DBusConnection { _pointer = pointer };
		public static explicit operator IntPtr(DBusConnection value) => value._pointer
;		public static implicit operator GObject.Object(DBusConnection value) => (GObject.Object)value._pointer
;		public static explicit operator DBusConnection(GObject.Object value) => (DBusConnection)(IntPtr)value
;	}
	public ref struct Notification
	{
		private IntPtr _pointer;
		public static explicit operator Notification(IntPtr pointer) => new Notification { _pointer = pointer };
		public static explicit operator IntPtr(Notification value) => value._pointer
;		public static implicit operator GObject.Object(Notification value) => (GObject.Object)value._pointer
;		public static explicit operator Notification(GObject.Object value) => (Notification)(IntPtr)value
;	}
	public ref struct ApplicationPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationPrivate(IntPtr pointer) => new ApplicationPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationPrivate value) => value._pointer
;	}
	public ref struct ApplicationCommandLine
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationCommandLine(IntPtr pointer) => new ApplicationCommandLine { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationCommandLine value) => value._pointer
;		public static implicit operator GObject.Object(ApplicationCommandLine value) => (GObject.Object)value._pointer
;		public static explicit operator ApplicationCommandLine(GObject.Object value) => (ApplicationCommandLine)(IntPtr)value
;	}
	public ref struct ApplicationClass
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationClass(IntPtr pointer) => new ApplicationClass { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationClass value) => value._pointer
;	}
	public ref struct InputStream
	{
		private IntPtr _pointer;
		public static explicit operator InputStream(IntPtr pointer) => new InputStream { _pointer = pointer };
		public static explicit operator IntPtr(InputStream value) => value._pointer
;		public static implicit operator GObject.Object(InputStream value) => (GObject.Object)value._pointer
;		public static explicit operator InputStream(GObject.Object value) => (InputStream)(IntPtr)value
;	}
	public ref struct ApplicationCommandLinePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationCommandLinePrivate(IntPtr pointer) => new ApplicationCommandLinePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationCommandLinePrivate value) => value._pointer
;	}
	public ref struct ApplicationCommandLineClass
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationCommandLineClass(IntPtr pointer) => new ApplicationCommandLineClass { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationCommandLineClass value) => value._pointer
;	}
	[Flags]
	public enum AskPasswordFlags
	{
		need_password = 1,
		need_username = 2,
		need_domain = 4,
		saving_supported = 8,
		anonymous_supported = 16,
	}
	public ref struct AsyncInitable
	{
		private IntPtr _pointer;
		public static explicit operator AsyncInitable(IntPtr pointer) => new AsyncInitable { _pointer = pointer };
		public static explicit operator IntPtr(AsyncInitable value) => value._pointer
;	}
	public ref struct AsyncInitableIface
	{
		private IntPtr _pointer;
		public static explicit operator AsyncInitableIface(IntPtr pointer) => new AsyncInitableIface { _pointer = pointer };
		public static explicit operator IntPtr(AsyncInitableIface value) => value._pointer
;	}
	public ref struct AsyncResultIface
	{
		private IntPtr _pointer;
		public static explicit operator AsyncResultIface(IntPtr pointer) => new AsyncResultIface { _pointer = pointer };
		public static explicit operator IntPtr(AsyncResultIface value) => value._pointer
;	}
	public ref struct Seekable
	{
		private IntPtr _pointer;
		public static explicit operator Seekable(IntPtr pointer) => new Seekable { _pointer = pointer };
		public static explicit operator IntPtr(Seekable value) => value._pointer
;	}
	public ref struct BufferedInputStream
	{
		private IntPtr _pointer;
		public static explicit operator BufferedInputStream(IntPtr pointer) => new BufferedInputStream { _pointer = pointer };
		public static explicit operator IntPtr(BufferedInputStream value) => value._pointer
;		public static implicit operator Gio.FilterInputStream(BufferedInputStream value) => (Gio.FilterInputStream)value._pointer
;		public static explicit operator BufferedInputStream(Gio.FilterInputStream value) => (BufferedInputStream)(IntPtr)value
;		public static implicit operator Gio.InputStream(BufferedInputStream value) => (Gio.InputStream)value._pointer
;		public static explicit operator BufferedInputStream(Gio.InputStream value) => (BufferedInputStream)(IntPtr)value
;		public static implicit operator GObject.Object(BufferedInputStream value) => (GObject.Object)value._pointer
;		public static explicit operator BufferedInputStream(GObject.Object value) => (BufferedInputStream)(IntPtr)value
;	}
	public ref struct FilterInputStream
	{
		private IntPtr _pointer;
		public static explicit operator FilterInputStream(IntPtr pointer) => new FilterInputStream { _pointer = pointer };
		public static explicit operator IntPtr(FilterInputStream value) => value._pointer
;		public static implicit operator Gio.InputStream(FilterInputStream value) => (Gio.InputStream)value._pointer
;		public static explicit operator FilterInputStream(Gio.InputStream value) => (FilterInputStream)(IntPtr)value
;		public static implicit operator GObject.Object(FilterInputStream value) => (GObject.Object)value._pointer
;		public static explicit operator FilterInputStream(GObject.Object value) => (FilterInputStream)(IntPtr)value
;	}
	public ref struct BufferedInputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator BufferedInputStreamPrivate(IntPtr pointer) => new BufferedInputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(BufferedInputStreamPrivate value) => value._pointer
;	}
	public ref struct FilterInputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator FilterInputStreamClass(IntPtr pointer) => new FilterInputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(FilterInputStreamClass value) => value._pointer
;	}
	public ref struct BufferedInputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator BufferedInputStreamClass(IntPtr pointer) => new BufferedInputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(BufferedInputStreamClass value) => value._pointer
;	}
	public ref struct OutputStream
	{
		private IntPtr _pointer;
		public static explicit operator OutputStream(IntPtr pointer) => new OutputStream { _pointer = pointer };
		public static explicit operator IntPtr(OutputStream value) => value._pointer
;		public static implicit operator GObject.Object(OutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator OutputStream(GObject.Object value) => (OutputStream)(IntPtr)value
;	}
	public ref struct BufferedOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator BufferedOutputStream(IntPtr pointer) => new BufferedOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(BufferedOutputStream value) => value._pointer
;		public static implicit operator Gio.FilterOutputStream(BufferedOutputStream value) => (Gio.FilterOutputStream)value._pointer
;		public static explicit operator BufferedOutputStream(Gio.FilterOutputStream value) => (BufferedOutputStream)(IntPtr)value
;		public static implicit operator Gio.OutputStream(BufferedOutputStream value) => (Gio.OutputStream)value._pointer
;		public static explicit operator BufferedOutputStream(Gio.OutputStream value) => (BufferedOutputStream)(IntPtr)value
;		public static implicit operator GObject.Object(BufferedOutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator BufferedOutputStream(GObject.Object value) => (BufferedOutputStream)(IntPtr)value
;	}
	public ref struct FilterOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator FilterOutputStream(IntPtr pointer) => new FilterOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(FilterOutputStream value) => value._pointer
;		public static implicit operator Gio.OutputStream(FilterOutputStream value) => (Gio.OutputStream)value._pointer
;		public static explicit operator FilterOutputStream(Gio.OutputStream value) => (FilterOutputStream)(IntPtr)value
;		public static implicit operator GObject.Object(FilterOutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator FilterOutputStream(GObject.Object value) => (FilterOutputStream)(IntPtr)value
;	}
	public ref struct BufferedOutputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator BufferedOutputStreamPrivate(IntPtr pointer) => new BufferedOutputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(BufferedOutputStreamPrivate value) => value._pointer
;	}
	public ref struct FilterOutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator FilterOutputStreamClass(IntPtr pointer) => new FilterOutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(FilterOutputStreamClass value) => value._pointer
;	}
	public ref struct BufferedOutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator BufferedOutputStreamClass(IntPtr pointer) => new BufferedOutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(BufferedOutputStreamClass value) => value._pointer
;	}
	[Flags]
	public enum BusNameOwnerFlags
	{
		none = 0,
		allow_replacement = 1,
		replace = 2,
		do_not_queue = 4,
	}
	[Flags]
	public enum BusNameWatcherFlags
	{
		none = 0,
		auto_start = 1,
	}
	public enum BusType
	{
		starter = -1,
		none = 0,
		system = 1,
		session = 2,
	}
	public ref struct LoadableIcon
	{
		private IntPtr _pointer;
		public static explicit operator LoadableIcon(IntPtr pointer) => new LoadableIcon { _pointer = pointer };
		public static explicit operator IntPtr(LoadableIcon value) => value._pointer
;	}
	public ref struct BytesIcon
	{
		private IntPtr _pointer;
		public static explicit operator BytesIcon(IntPtr pointer) => new BytesIcon { _pointer = pointer };
		public static explicit operator IntPtr(BytesIcon value) => value._pointer
;		public static implicit operator GObject.Object(BytesIcon value) => (GObject.Object)value._pointer
;		public static explicit operator BytesIcon(GObject.Object value) => (BytesIcon)(IntPtr)value
;	}
	public ref struct CancellablePrivate
	{
		private IntPtr _pointer;
		public static explicit operator CancellablePrivate(IntPtr pointer) => new CancellablePrivate { _pointer = pointer };
		public static explicit operator IntPtr(CancellablePrivate value) => value._pointer
;	}
	public ref struct CancellableClass
	{
		private IntPtr _pointer;
		public static explicit operator CancellableClass(IntPtr pointer) => new CancellableClass { _pointer = pointer };
		public static explicit operator IntPtr(CancellableClass value) => value._pointer
;	}
	public ref struct Converter
	{
		private IntPtr _pointer;
		public static explicit operator Converter(IntPtr pointer) => new Converter { _pointer = pointer };
		public static explicit operator IntPtr(Converter value) => value._pointer
;	}
	public ref struct Initable
	{
		private IntPtr _pointer;
		public static explicit operator Initable(IntPtr pointer) => new Initable { _pointer = pointer };
		public static explicit operator IntPtr(Initable value) => value._pointer
;	}
	public ref struct CharsetConverter
	{
		private IntPtr _pointer;
		public static explicit operator CharsetConverter(IntPtr pointer) => new CharsetConverter { _pointer = pointer };
		public static explicit operator IntPtr(CharsetConverter value) => value._pointer
;		public static implicit operator GObject.Object(CharsetConverter value) => (GObject.Object)value._pointer
;		public static explicit operator CharsetConverter(GObject.Object value) => (CharsetConverter)(IntPtr)value
;	}
	public ref struct CharsetConverterClass
	{
		private IntPtr _pointer;
		public static explicit operator CharsetConverterClass(IntPtr pointer) => new CharsetConverterClass { _pointer = pointer };
		public static explicit operator IntPtr(CharsetConverterClass value) => value._pointer
;	}
	public enum ConverterResult
	{
		error = 0,
		converted = 1,
		finished = 2,
		flushed = 3,
	}
	[Flags]
	public enum ConverterFlags
	{
		none = 0,
		input_at_end = 1,
		flush = 2,
	}
	public ref struct ConverterIface
	{
		private IntPtr _pointer;
		public static explicit operator ConverterIface(IntPtr pointer) => new ConverterIface { _pointer = pointer };
		public static explicit operator IntPtr(ConverterIface value) => value._pointer
;	}
	public ref struct PollableInputStream
	{
		private IntPtr _pointer;
		public static explicit operator PollableInputStream(IntPtr pointer) => new PollableInputStream { _pointer = pointer };
		public static explicit operator IntPtr(PollableInputStream value) => value._pointer
;	}
	public ref struct ConverterInputStream
	{
		private IntPtr _pointer;
		public static explicit operator ConverterInputStream(IntPtr pointer) => new ConverterInputStream { _pointer = pointer };
		public static explicit operator IntPtr(ConverterInputStream value) => value._pointer
;		public static implicit operator Gio.FilterInputStream(ConverterInputStream value) => (Gio.FilterInputStream)value._pointer
;		public static explicit operator ConverterInputStream(Gio.FilterInputStream value) => (ConverterInputStream)(IntPtr)value
;		public static implicit operator Gio.InputStream(ConverterInputStream value) => (Gio.InputStream)value._pointer
;		public static explicit operator ConverterInputStream(Gio.InputStream value) => (ConverterInputStream)(IntPtr)value
;		public static implicit operator GObject.Object(ConverterInputStream value) => (GObject.Object)value._pointer
;		public static explicit operator ConverterInputStream(GObject.Object value) => (ConverterInputStream)(IntPtr)value
;	}
	public ref struct ConverterInputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ConverterInputStreamPrivate(IntPtr pointer) => new ConverterInputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ConverterInputStreamPrivate value) => value._pointer
;	}
	public ref struct ConverterInputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator ConverterInputStreamClass(IntPtr pointer) => new ConverterInputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(ConverterInputStreamClass value) => value._pointer
;	}
	public ref struct PollableOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator PollableOutputStream(IntPtr pointer) => new PollableOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(PollableOutputStream value) => value._pointer
;	}
	public ref struct ConverterOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator ConverterOutputStream(IntPtr pointer) => new ConverterOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(ConverterOutputStream value) => value._pointer
;		public static implicit operator Gio.FilterOutputStream(ConverterOutputStream value) => (Gio.FilterOutputStream)value._pointer
;		public static explicit operator ConverterOutputStream(Gio.FilterOutputStream value) => (ConverterOutputStream)(IntPtr)value
;		public static implicit operator Gio.OutputStream(ConverterOutputStream value) => (Gio.OutputStream)value._pointer
;		public static explicit operator ConverterOutputStream(Gio.OutputStream value) => (ConverterOutputStream)(IntPtr)value
;		public static implicit operator GObject.Object(ConverterOutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator ConverterOutputStream(GObject.Object value) => (ConverterOutputStream)(IntPtr)value
;	}
	public ref struct ConverterOutputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ConverterOutputStreamPrivate(IntPtr pointer) => new ConverterOutputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ConverterOutputStreamPrivate value) => value._pointer
;	}
	public ref struct ConverterOutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator ConverterOutputStreamClass(IntPtr pointer) => new ConverterOutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(ConverterOutputStreamClass value) => value._pointer
;	}
	public ref struct Credentials
	{
		private IntPtr _pointer;
		public static explicit operator Credentials(IntPtr pointer) => new Credentials { _pointer = pointer };
		public static explicit operator IntPtr(Credentials value) => value._pointer
;		public static implicit operator GObject.Object(Credentials value) => (GObject.Object)value._pointer
;		public static explicit operator Credentials(GObject.Object value) => (Credentials)(IntPtr)value
;	}
	public enum CredentialsType
	{
		invalid = 0,
		linux_ucred = 1,
		freebsd_cmsgcred = 2,
		openbsd_sockpeercred = 3,
		solaris_ucred = 4,
		netbsd_unpcbid = 5,
	}
	public ref struct CredentialsClass
	{
		private IntPtr _pointer;
		public static explicit operator CredentialsClass(IntPtr pointer) => new CredentialsClass { _pointer = pointer };
		public static explicit operator IntPtr(CredentialsClass value) => value._pointer
;	}
	public ref struct RemoteActionGroup
	{
		private IntPtr _pointer;
		public static explicit operator RemoteActionGroup(IntPtr pointer) => new RemoteActionGroup { _pointer = pointer };
		public static explicit operator IntPtr(RemoteActionGroup value) => value._pointer
;	}
	public ref struct DBusActionGroup
	{
		private IntPtr _pointer;
		public static explicit operator DBusActionGroup(IntPtr pointer) => new DBusActionGroup { _pointer = pointer };
		public static explicit operator IntPtr(DBusActionGroup value) => value._pointer
;		public static implicit operator GObject.Object(DBusActionGroup value) => (GObject.Object)value._pointer
;		public static explicit operator DBusActionGroup(GObject.Object value) => (DBusActionGroup)(IntPtr)value
;	}
	public ref struct DBusAnnotationInfo
	{
		private IntPtr _pointer;
		public static explicit operator DBusAnnotationInfo(IntPtr pointer) => new DBusAnnotationInfo { _pointer = pointer };
		public static explicit operator IntPtr(DBusAnnotationInfo value) => value._pointer
;	}
	public ref struct DBusArgInfo
	{
		private IntPtr _pointer;
		public static explicit operator DBusArgInfo(IntPtr pointer) => new DBusArgInfo { _pointer = pointer };
		public static explicit operator IntPtr(DBusArgInfo value) => value._pointer
;	}
	public ref struct DBusAuthObserver
	{
		private IntPtr _pointer;
		public static explicit operator DBusAuthObserver(IntPtr pointer) => new DBusAuthObserver { _pointer = pointer };
		public static explicit operator IntPtr(DBusAuthObserver value) => value._pointer
;		public static implicit operator GObject.Object(DBusAuthObserver value) => (GObject.Object)value._pointer
;		public static explicit operator DBusAuthObserver(GObject.Object value) => (DBusAuthObserver)(IntPtr)value
;	}
	public ref struct IOStream
	{
		private IntPtr _pointer;
		public static explicit operator IOStream(IntPtr pointer) => new IOStream { _pointer = pointer };
		public static explicit operator IntPtr(IOStream value) => value._pointer
;		public static implicit operator GObject.Object(IOStream value) => (GObject.Object)value._pointer
;		public static explicit operator IOStream(GObject.Object value) => (IOStream)(IntPtr)value
;	}
	[Flags]
	public enum DBusCallFlags
	{
		none = 0,
		no_auto_start = 1,
		allow_interactive_authorization = 2,
	}
	[Flags]
	public enum DBusCapabilityFlags
	{
		none = 0,
		unix_fd_passing = 1,
	}
	[Flags]
	public enum DBusConnectionFlags
	{
		none = 0,
		authentication_client = 1,
		authentication_server = 2,
		authentication_allow_anonymous = 4,
		message_bus_connection = 8,
		delay_message_processing = 16,
	}
	public ref struct UnixFDList
	{
		private IntPtr _pointer;
		public static explicit operator UnixFDList(IntPtr pointer) => new UnixFDList { _pointer = pointer };
		public static explicit operator IntPtr(UnixFDList value) => value._pointer
;		public static implicit operator GObject.Object(UnixFDList value) => (GObject.Object)value._pointer
;		public static explicit operator UnixFDList(GObject.Object value) => (UnixFDList)(IntPtr)value
;	}
	public ref struct MenuModel
	{
		private IntPtr _pointer;
		public static explicit operator MenuModel(IntPtr pointer) => new MenuModel { _pointer = pointer };
		public static explicit operator IntPtr(MenuModel value) => value._pointer
;		public static implicit operator GObject.Object(MenuModel value) => (GObject.Object)value._pointer
;		public static explicit operator MenuModel(GObject.Object value) => (MenuModel)(IntPtr)value
;	}
	public ref struct DBusInterfaceInfo
	{
		private IntPtr _pointer;
		public static explicit operator DBusInterfaceInfo(IntPtr pointer) => new DBusInterfaceInfo { _pointer = pointer };
		public static explicit operator IntPtr(DBusInterfaceInfo value) => value._pointer
;	}
	public ref struct DBusInterfaceVTable
	{
		private IntPtr _pointer;
		public static explicit operator DBusInterfaceVTable(IntPtr pointer) => new DBusInterfaceVTable { _pointer = pointer };
		public static explicit operator IntPtr(DBusInterfaceVTable value) => value._pointer
;	}
	public ref struct DBusSubtreeVTable
	{
		private IntPtr _pointer;
		public static explicit operator DBusSubtreeVTable(IntPtr pointer) => new DBusSubtreeVTable { _pointer = pointer };
		public static explicit operator IntPtr(DBusSubtreeVTable value) => value._pointer
;	}
	[Flags]
	public enum DBusSubtreeFlags
	{
		none = 0,
		dispatch_to_unenumerated_nodes = 1,
	}
	public ref struct DBusMessage
	{
		private IntPtr _pointer;
		public static explicit operator DBusMessage(IntPtr pointer) => new DBusMessage { _pointer = pointer };
		public static explicit operator IntPtr(DBusMessage value) => value._pointer
;		public static implicit operator GObject.Object(DBusMessage value) => (GObject.Object)value._pointer
;		public static explicit operator DBusMessage(GObject.Object value) => (DBusMessage)(IntPtr)value
;	}
	[Flags]
	public enum DBusSendMessageFlags
	{
		none = 0,
		preserve_serial = 1,
	}
	[Flags]
	public enum DBusSignalFlags
	{
		none = 0,
		no_match_rule = 1,
		match_arg0_namespace = 2,
		match_arg0_path = 4,
	}
	public ref struct DBusErrorEntry
	{
		private IntPtr _pointer;
		public static explicit operator DBusErrorEntry(IntPtr pointer) => new DBusErrorEntry { _pointer = pointer };
		public static explicit operator IntPtr(DBusErrorEntry value) => value._pointer
;	}
	public enum DBusError
	{
		failed = 0,
		no_memory = 1,
		service_unknown = 2,
		name_has_no_owner = 3,
		no_reply = 4,
		io_error = 5,
		bad_address = 6,
		not_supported = 7,
		limits_exceeded = 8,
		access_denied = 9,
		auth_failed = 10,
		no_server = 11,
		timeout = 12,
		no_network = 13,
		address_in_use = 14,
		disconnected = 15,
		invalid_args = 16,
		file_not_found = 17,
		file_exists = 18,
		unknown_method = 19,
		timed_out = 20,
		match_rule_not_found = 21,
		match_rule_invalid = 22,
		spawn_exec_failed = 23,
		spawn_fork_failed = 24,
		spawn_child_exited = 25,
		spawn_child_signaled = 26,
		spawn_failed = 27,
		spawn_setup_failed = 28,
		spawn_config_invalid = 29,
		spawn_service_invalid = 30,
		spawn_service_not_found = 31,
		spawn_permissions_invalid = 32,
		spawn_file_invalid = 33,
		spawn_no_memory = 34,
		unix_process_id_unknown = 35,
		invalid_signature = 36,
		invalid_file_content = 37,
		selinux_security_context_unknown = 38,
		adt_audit_data_unknown = 39,
		object_path_in_use = 40,
		unknown_object = 41,
		unknown_interface = 42,
		unknown_property = 43,
		property_read_only = 44,
	}
	public ref struct DBusObject
	{
		private IntPtr _pointer;
		public static explicit operator DBusObject(IntPtr pointer) => new DBusObject { _pointer = pointer };
		public static explicit operator IntPtr(DBusObject value) => value._pointer
;	}
	public ref struct DBusInterface
	{
		private IntPtr _pointer;
		public static explicit operator DBusInterface(IntPtr pointer) => new DBusInterface { _pointer = pointer };
		public static explicit operator IntPtr(DBusInterface value) => value._pointer
;	}
	public ref struct DBusInterfaceIface
	{
		private IntPtr _pointer;
		public static explicit operator DBusInterfaceIface(IntPtr pointer) => new DBusInterfaceIface { _pointer = pointer };
		public static explicit operator IntPtr(DBusInterfaceIface value) => value._pointer
;	}
	public ref struct DBusMethodInfo
	{
		private IntPtr _pointer;
		public static explicit operator DBusMethodInfo(IntPtr pointer) => new DBusMethodInfo { _pointer = pointer };
		public static explicit operator IntPtr(DBusMethodInfo value) => value._pointer
;	}
	public ref struct DBusSignalInfo
	{
		private IntPtr _pointer;
		public static explicit operator DBusSignalInfo(IntPtr pointer) => new DBusSignalInfo { _pointer = pointer };
		public static explicit operator IntPtr(DBusSignalInfo value) => value._pointer
;	}
	public ref struct DBusPropertyInfo
	{
		private IntPtr _pointer;
		public static explicit operator DBusPropertyInfo(IntPtr pointer) => new DBusPropertyInfo { _pointer = pointer };
		public static explicit operator IntPtr(DBusPropertyInfo value) => value._pointer
;	}
	public ref struct DBusMethodInvocation
	{
		private IntPtr _pointer;
		public static explicit operator DBusMethodInvocation(IntPtr pointer) => new DBusMethodInvocation { _pointer = pointer };
		public static explicit operator IntPtr(DBusMethodInvocation value) => value._pointer
;		public static implicit operator GObject.Object(DBusMethodInvocation value) => (GObject.Object)value._pointer
;		public static explicit operator DBusMethodInvocation(GObject.Object value) => (DBusMethodInvocation)(IntPtr)value
;	}
	public ref struct DBusInterfaceSkeleton
	{
		private IntPtr _pointer;
		public static explicit operator DBusInterfaceSkeleton(IntPtr pointer) => new DBusInterfaceSkeleton { _pointer = pointer };
		public static explicit operator IntPtr(DBusInterfaceSkeleton value) => value._pointer
;		public static implicit operator GObject.Object(DBusInterfaceSkeleton value) => (GObject.Object)value._pointer
;		public static explicit operator DBusInterfaceSkeleton(GObject.Object value) => (DBusInterfaceSkeleton)(IntPtr)value
;	}
	[Flags]
	public enum DBusInterfaceSkeletonFlags
	{
		none = 0,
		handle_method_invocations_in_thread = 1,
	}
	public ref struct DBusInterfaceSkeletonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DBusInterfaceSkeletonPrivate(IntPtr pointer) => new DBusInterfaceSkeletonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DBusInterfaceSkeletonPrivate value) => value._pointer
;	}
	public ref struct DBusInterfaceSkeletonClass
	{
		private IntPtr _pointer;
		public static explicit operator DBusInterfaceSkeletonClass(IntPtr pointer) => new DBusInterfaceSkeletonClass { _pointer = pointer };
		public static explicit operator IntPtr(DBusInterfaceSkeletonClass value) => value._pointer
;	}
	public ref struct DBusMenuModel
	{
		private IntPtr _pointer;
		public static explicit operator DBusMenuModel(IntPtr pointer) => new DBusMenuModel { _pointer = pointer };
		public static explicit operator IntPtr(DBusMenuModel value) => value._pointer
;		public static implicit operator Gio.MenuModel(DBusMenuModel value) => (Gio.MenuModel)value._pointer
;		public static explicit operator DBusMenuModel(Gio.MenuModel value) => (DBusMenuModel)(IntPtr)value
;		public static implicit operator GObject.Object(DBusMenuModel value) => (GObject.Object)value._pointer
;		public static explicit operator DBusMenuModel(GObject.Object value) => (DBusMenuModel)(IntPtr)value
;	}
	public enum DBusMessageByteOrder
	{
		big_endian = 66,
		little_endian = 108,
	}
	[Flags]
	public enum DBusMessageFlags
	{
		none = 0,
		no_reply_expected = 1,
		no_auto_start = 2,
		allow_interactive_authorization = 4,
	}
	public enum DBusMessageHeaderField
	{
		invalid = 0,
		path = 1,
		@interface = 2,
		member = 3,
		error_name = 4,
		reply_serial = 5,
		destination = 6,
		sender = 7,
		signature = 8,
		num_unix_fds = 9,
	}
	public enum DBusMessageType
	{
		invalid = 0,
		method_call = 1,
		method_return = 2,
		error = 3,
		signal = 4,
	}
	public ref struct DBusNodeInfo
	{
		private IntPtr _pointer;
		public static explicit operator DBusNodeInfo(IntPtr pointer) => new DBusNodeInfo { _pointer = pointer };
		public static explicit operator IntPtr(DBusNodeInfo value) => value._pointer
;	}
	public ref struct DBusObjectIface
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectIface(IntPtr pointer) => new DBusObjectIface { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectIface value) => value._pointer
;	}
	public ref struct DBusObjectManager
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManager(IntPtr pointer) => new DBusObjectManager { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManager value) => value._pointer
;	}
	public ref struct DBusObjectManagerClient
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManagerClient(IntPtr pointer) => new DBusObjectManagerClient { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManagerClient value) => value._pointer
;		public static implicit operator GObject.Object(DBusObjectManagerClient value) => (GObject.Object)value._pointer
;		public static explicit operator DBusObjectManagerClient(GObject.Object value) => (DBusObjectManagerClient)(IntPtr)value
;	}
	[Flags]
	public enum DBusObjectManagerClientFlags
	{
		none = 0,
		do_not_auto_start = 1,
	}
	public ref struct DBusObjectManagerClientPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManagerClientPrivate(IntPtr pointer) => new DBusObjectManagerClientPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManagerClientPrivate value) => value._pointer
;	}
	public ref struct DBusObjectProxy
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectProxy(IntPtr pointer) => new DBusObjectProxy { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectProxy value) => value._pointer
;		public static implicit operator GObject.Object(DBusObjectProxy value) => (GObject.Object)value._pointer
;		public static explicit operator DBusObjectProxy(GObject.Object value) => (DBusObjectProxy)(IntPtr)value
;	}
	public ref struct DBusProxy
	{
		private IntPtr _pointer;
		public static explicit operator DBusProxy(IntPtr pointer) => new DBusProxy { _pointer = pointer };
		public static explicit operator IntPtr(DBusProxy value) => value._pointer
;		public static implicit operator GObject.Object(DBusProxy value) => (GObject.Object)value._pointer
;		public static explicit operator DBusProxy(GObject.Object value) => (DBusProxy)(IntPtr)value
;	}
	public ref struct DBusObjectManagerClientClass
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManagerClientClass(IntPtr pointer) => new DBusObjectManagerClientClass { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManagerClientClass value) => value._pointer
;	}
	public ref struct DBusObjectManagerIface
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManagerIface(IntPtr pointer) => new DBusObjectManagerIface { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManagerIface value) => value._pointer
;	}
	public ref struct DBusObjectManagerServer
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManagerServer(IntPtr pointer) => new DBusObjectManagerServer { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManagerServer value) => value._pointer
;		public static implicit operator GObject.Object(DBusObjectManagerServer value) => (GObject.Object)value._pointer
;		public static explicit operator DBusObjectManagerServer(GObject.Object value) => (DBusObjectManagerServer)(IntPtr)value
;	}
	public ref struct DBusObjectSkeleton
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectSkeleton(IntPtr pointer) => new DBusObjectSkeleton { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectSkeleton value) => value._pointer
;		public static implicit operator GObject.Object(DBusObjectSkeleton value) => (GObject.Object)value._pointer
;		public static explicit operator DBusObjectSkeleton(GObject.Object value) => (DBusObjectSkeleton)(IntPtr)value
;	}
	public ref struct DBusObjectManagerServerPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManagerServerPrivate(IntPtr pointer) => new DBusObjectManagerServerPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManagerServerPrivate value) => value._pointer
;	}
	public ref struct DBusObjectManagerServerClass
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectManagerServerClass(IntPtr pointer) => new DBusObjectManagerServerClass { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectManagerServerClass value) => value._pointer
;	}
	public ref struct DBusObjectProxyPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectProxyPrivate(IntPtr pointer) => new DBusObjectProxyPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectProxyPrivate value) => value._pointer
;	}
	public ref struct DBusObjectProxyClass
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectProxyClass(IntPtr pointer) => new DBusObjectProxyClass { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectProxyClass value) => value._pointer
;	}
	public ref struct DBusObjectSkeletonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectSkeletonPrivate(IntPtr pointer) => new DBusObjectSkeletonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectSkeletonPrivate value) => value._pointer
;	}
	public ref struct DBusObjectSkeletonClass
	{
		private IntPtr _pointer;
		public static explicit operator DBusObjectSkeletonClass(IntPtr pointer) => new DBusObjectSkeletonClass { _pointer = pointer };
		public static explicit operator IntPtr(DBusObjectSkeletonClass value) => value._pointer
;	}
	[Flags]
	public enum DBusPropertyInfoFlags
	{
		none = 0,
		readable = 1,
		writable = 2,
	}
	[Flags]
	public enum DBusProxyFlags
	{
		none = 0,
		do_not_load_properties = 1,
		do_not_connect_signals = 2,
		do_not_auto_start = 4,
		get_invalidated_properties = 8,
		do_not_auto_start_at_construction = 16,
	}
	public ref struct DBusProxyPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DBusProxyPrivate(IntPtr pointer) => new DBusProxyPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DBusProxyPrivate value) => value._pointer
;	}
	public ref struct DBusProxyClass
	{
		private IntPtr _pointer;
		public static explicit operator DBusProxyClass(IntPtr pointer) => new DBusProxyClass { _pointer = pointer };
		public static explicit operator IntPtr(DBusProxyClass value) => value._pointer
;	}
	public ref struct DBusServer
	{
		private IntPtr _pointer;
		public static explicit operator DBusServer(IntPtr pointer) => new DBusServer { _pointer = pointer };
		public static explicit operator IntPtr(DBusServer value) => value._pointer
;		public static implicit operator GObject.Object(DBusServer value) => (GObject.Object)value._pointer
;		public static explicit operator DBusServer(GObject.Object value) => (DBusServer)(IntPtr)value
;	}
	[Flags]
	public enum DBusServerFlags
	{
		none = 0,
		run_in_thread = 1,
		authentication_allow_anonymous = 2,
	}
	public ref struct DataInputStream
	{
		private IntPtr _pointer;
		public static explicit operator DataInputStream(IntPtr pointer) => new DataInputStream { _pointer = pointer };
		public static explicit operator IntPtr(DataInputStream value) => value._pointer
;		public static implicit operator Gio.BufferedInputStream(DataInputStream value) => (Gio.BufferedInputStream)value._pointer
;		public static explicit operator DataInputStream(Gio.BufferedInputStream value) => (DataInputStream)(IntPtr)value
;		public static implicit operator Gio.FilterInputStream(DataInputStream value) => (Gio.FilterInputStream)value._pointer
;		public static explicit operator DataInputStream(Gio.FilterInputStream value) => (DataInputStream)(IntPtr)value
;		public static implicit operator Gio.InputStream(DataInputStream value) => (Gio.InputStream)value._pointer
;		public static explicit operator DataInputStream(Gio.InputStream value) => (DataInputStream)(IntPtr)value
;		public static implicit operator GObject.Object(DataInputStream value) => (GObject.Object)value._pointer
;		public static explicit operator DataInputStream(GObject.Object value) => (DataInputStream)(IntPtr)value
;	}
	public enum DataStreamByteOrder
	{
		big_endian = 0,
		little_endian = 1,
		host_endian = 2,
	}
	public enum DataStreamNewlineType
	{
		lf = 0,
		cr = 1,
		cr_lf = 2,
		any = 3,
	}
	public ref struct DataInputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DataInputStreamPrivate(IntPtr pointer) => new DataInputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DataInputStreamPrivate value) => value._pointer
;	}
	public ref struct DataInputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator DataInputStreamClass(IntPtr pointer) => new DataInputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(DataInputStreamClass value) => value._pointer
;	}
	public ref struct DataOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator DataOutputStream(IntPtr pointer) => new DataOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(DataOutputStream value) => value._pointer
;		public static implicit operator Gio.FilterOutputStream(DataOutputStream value) => (Gio.FilterOutputStream)value._pointer
;		public static explicit operator DataOutputStream(Gio.FilterOutputStream value) => (DataOutputStream)(IntPtr)value
;		public static implicit operator Gio.OutputStream(DataOutputStream value) => (Gio.OutputStream)value._pointer
;		public static explicit operator DataOutputStream(Gio.OutputStream value) => (DataOutputStream)(IntPtr)value
;		public static implicit operator GObject.Object(DataOutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator DataOutputStream(GObject.Object value) => (DataOutputStream)(IntPtr)value
;	}
	public ref struct DataOutputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DataOutputStreamPrivate(IntPtr pointer) => new DataOutputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DataOutputStreamPrivate value) => value._pointer
;	}
	public ref struct DataOutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator DataOutputStreamClass(IntPtr pointer) => new DataOutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(DataOutputStreamClass value) => value._pointer
;	}
	public ref struct DatagramBased
	{
		private IntPtr _pointer;
		public static explicit operator DatagramBased(IntPtr pointer) => new DatagramBased { _pointer = pointer };
		public static explicit operator IntPtr(DatagramBased value) => value._pointer
;	}
	public ref struct InputMessage
	{
		private IntPtr _pointer;
		public static explicit operator InputMessage(IntPtr pointer) => new InputMessage { _pointer = pointer };
		public static explicit operator IntPtr(InputMessage value) => value._pointer
;	}
	public ref struct OutputMessage
	{
		private IntPtr _pointer;
		public static explicit operator OutputMessage(IntPtr pointer) => new OutputMessage { _pointer = pointer };
		public static explicit operator IntPtr(OutputMessage value) => value._pointer
;	}
	public ref struct DatagramBasedInterface
	{
		private IntPtr _pointer;
		public static explicit operator DatagramBasedInterface(IntPtr pointer) => new DatagramBasedInterface { _pointer = pointer };
		public static explicit operator IntPtr(DatagramBasedInterface value) => value._pointer
;	}
	public ref struct DesktopAppInfo
	{
		private IntPtr _pointer;
		public static explicit operator DesktopAppInfo(IntPtr pointer) => new DesktopAppInfo { _pointer = pointer };
		public static explicit operator IntPtr(DesktopAppInfo value) => value._pointer
;		public static implicit operator GObject.Object(DesktopAppInfo value) => (GObject.Object)value._pointer
;		public static explicit operator DesktopAppInfo(GObject.Object value) => (DesktopAppInfo)(IntPtr)value
;	}
	public ref struct DesktopAppInfoClass
	{
		private IntPtr _pointer;
		public static explicit operator DesktopAppInfoClass(IntPtr pointer) => new DesktopAppInfoClass { _pointer = pointer };
		public static explicit operator IntPtr(DesktopAppInfoClass value) => value._pointer
;	}
	public ref struct DesktopAppInfoLookup
	{
		private IntPtr _pointer;
		public static explicit operator DesktopAppInfoLookup(IntPtr pointer) => new DesktopAppInfoLookup { _pointer = pointer };
		public static explicit operator IntPtr(DesktopAppInfoLookup value) => value._pointer
;	}
	public ref struct DesktopAppInfoLookupIface
	{
		private IntPtr _pointer;
		public static explicit operator DesktopAppInfoLookupIface(IntPtr pointer) => new DesktopAppInfoLookupIface { _pointer = pointer };
		public static explicit operator IntPtr(DesktopAppInfoLookupIface value) => value._pointer
;	}
	public ref struct Drive
	{
		private IntPtr _pointer;
		public static explicit operator Drive(IntPtr pointer) => new Drive { _pointer = pointer };
		public static explicit operator IntPtr(Drive value) => value._pointer
;	}
	[Flags]
	public enum MountUnmountFlags
	{
		none = 0,
		force = 1,
	}
	public ref struct MountOperation
	{
		private IntPtr _pointer;
		public static explicit operator MountOperation(IntPtr pointer) => new MountOperation { _pointer = pointer };
		public static explicit operator IntPtr(MountOperation value) => value._pointer
;		public static implicit operator GObject.Object(MountOperation value) => (GObject.Object)value._pointer
;		public static explicit operator MountOperation(GObject.Object value) => (MountOperation)(IntPtr)value
;	}
	public enum DriveStartStopType
	{
		unknown = 0,
		shutdown = 1,
		network = 2,
		multidisk = 3,
		password = 4,
	}
	public ref struct Volume
	{
		private IntPtr _pointer;
		public static explicit operator Volume(IntPtr pointer) => new Volume { _pointer = pointer };
		public static explicit operator IntPtr(Volume value) => value._pointer
;	}
	[Flags]
	public enum DriveStartFlags
	{
		none = 0,
	}
	public ref struct DriveIface
	{
		private IntPtr _pointer;
		public static explicit operator DriveIface(IntPtr pointer) => new DriveIface { _pointer = pointer };
		public static explicit operator IntPtr(DriveIface value) => value._pointer
;	}
	public ref struct DtlsConnection
	{
		private IntPtr _pointer;
		public static explicit operator DtlsConnection(IntPtr pointer) => new DtlsConnection { _pointer = pointer };
		public static explicit operator IntPtr(DtlsConnection value) => value._pointer
;	}
	public ref struct DtlsClientConnection
	{
		private IntPtr _pointer;
		public static explicit operator DtlsClientConnection(IntPtr pointer) => new DtlsClientConnection { _pointer = pointer };
		public static explicit operator IntPtr(DtlsClientConnection value) => value._pointer
;	}
	public ref struct SocketConnectable
	{
		private IntPtr _pointer;
		public static explicit operator SocketConnectable(IntPtr pointer) => new SocketConnectable { _pointer = pointer };
		public static explicit operator IntPtr(SocketConnectable value) => value._pointer
;	}
	[Flags]
	public enum TlsCertificateFlags
	{
		unknown_ca = 1,
		bad_identity = 2,
		not_activated = 4,
		expired = 8,
		revoked = 16,
		insecure = 32,
		generic_error = 64,
		validate_all = 127,
	}
	public ref struct DtlsClientConnectionInterface
	{
		private IntPtr _pointer;
		public static explicit operator DtlsClientConnectionInterface(IntPtr pointer) => new DtlsClientConnectionInterface { _pointer = pointer };
		public static explicit operator IntPtr(DtlsClientConnectionInterface value) => value._pointer
;	}
	public ref struct TlsCertificate
	{
		private IntPtr _pointer;
		public static explicit operator TlsCertificate(IntPtr pointer) => new TlsCertificate { _pointer = pointer };
		public static explicit operator IntPtr(TlsCertificate value) => value._pointer
;		public static implicit operator GObject.Object(TlsCertificate value) => (GObject.Object)value._pointer
;		public static explicit operator TlsCertificate(GObject.Object value) => (TlsCertificate)(IntPtr)value
;	}
	public ref struct TlsDatabase
	{
		private IntPtr _pointer;
		public static explicit operator TlsDatabase(IntPtr pointer) => new TlsDatabase { _pointer = pointer };
		public static explicit operator IntPtr(TlsDatabase value) => value._pointer
;		public static implicit operator GObject.Object(TlsDatabase value) => (GObject.Object)value._pointer
;		public static explicit operator TlsDatabase(GObject.Object value) => (TlsDatabase)(IntPtr)value
;	}
	public ref struct TlsInteraction
	{
		private IntPtr _pointer;
		public static explicit operator TlsInteraction(IntPtr pointer) => new TlsInteraction { _pointer = pointer };
		public static explicit operator IntPtr(TlsInteraction value) => value._pointer
;		public static implicit operator GObject.Object(TlsInteraction value) => (GObject.Object)value._pointer
;		public static explicit operator TlsInteraction(GObject.Object value) => (TlsInteraction)(IntPtr)value
;	}
	public enum TlsRehandshakeMode
	{
		never = 0,
		safely = 1,
		unsafely = 2,
	}
	public ref struct DtlsConnectionInterface
	{
		private IntPtr _pointer;
		public static explicit operator DtlsConnectionInterface(IntPtr pointer) => new DtlsConnectionInterface { _pointer = pointer };
		public static explicit operator IntPtr(DtlsConnectionInterface value) => value._pointer
;	}
	public ref struct DtlsServerConnection
	{
		private IntPtr _pointer;
		public static explicit operator DtlsServerConnection(IntPtr pointer) => new DtlsServerConnection { _pointer = pointer };
		public static explicit operator IntPtr(DtlsServerConnection value) => value._pointer
;	}
	public enum TlsAuthenticationMode
	{
		none = 0,
		requested = 1,
		required = 2,
	}
	public ref struct DtlsServerConnectionInterface
	{
		private IntPtr _pointer;
		public static explicit operator DtlsServerConnectionInterface(IntPtr pointer) => new DtlsServerConnectionInterface { _pointer = pointer };
		public static explicit operator IntPtr(DtlsServerConnectionInterface value) => value._pointer
;	}
	public ref struct Emblem
	{
		private IntPtr _pointer;
		public static explicit operator Emblem(IntPtr pointer) => new Emblem { _pointer = pointer };
		public static explicit operator IntPtr(Emblem value) => value._pointer
;		public static implicit operator GObject.Object(Emblem value) => (GObject.Object)value._pointer
;		public static explicit operator Emblem(GObject.Object value) => (Emblem)(IntPtr)value
;	}
	public enum EmblemOrigin
	{
		unknown = 0,
		device = 1,
		livemetadata = 2,
		tag = 3,
	}
	public ref struct EmblemClass
	{
		private IntPtr _pointer;
		public static explicit operator EmblemClass(IntPtr pointer) => new EmblemClass { _pointer = pointer };
		public static explicit operator IntPtr(EmblemClass value) => value._pointer
;	}
	public ref struct EmblemedIcon
	{
		private IntPtr _pointer;
		public static explicit operator EmblemedIcon(IntPtr pointer) => new EmblemedIcon { _pointer = pointer };
		public static explicit operator IntPtr(EmblemedIcon value) => value._pointer
;		public static implicit operator GObject.Object(EmblemedIcon value) => (GObject.Object)value._pointer
;		public static explicit operator EmblemedIcon(GObject.Object value) => (EmblemedIcon)(IntPtr)value
;	}
	public ref struct EmblemedIconPrivate
	{
		private IntPtr _pointer;
		public static explicit operator EmblemedIconPrivate(IntPtr pointer) => new EmblemedIconPrivate { _pointer = pointer };
		public static explicit operator IntPtr(EmblemedIconPrivate value) => value._pointer
;	}
	public ref struct EmblemedIconClass
	{
		private IntPtr _pointer;
		public static explicit operator EmblemedIconClass(IntPtr pointer) => new EmblemedIconClass { _pointer = pointer };
		public static explicit operator IntPtr(EmblemedIconClass value) => value._pointer
;	}
	public ref struct FileIOStream
	{
		private IntPtr _pointer;
		public static explicit operator FileIOStream(IntPtr pointer) => new FileIOStream { _pointer = pointer };
		public static explicit operator IntPtr(FileIOStream value) => value._pointer
;		public static implicit operator Gio.IOStream(FileIOStream value) => (Gio.IOStream)value._pointer
;		public static explicit operator FileIOStream(Gio.IOStream value) => (FileIOStream)(IntPtr)value
;		public static implicit operator GObject.Object(FileIOStream value) => (GObject.Object)value._pointer
;		public static explicit operator FileIOStream(GObject.Object value) => (FileIOStream)(IntPtr)value
;	}
	public ref struct FileOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator FileOutputStream(IntPtr pointer) => new FileOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(FileOutputStream value) => value._pointer
;		public static implicit operator Gio.OutputStream(FileOutputStream value) => (Gio.OutputStream)value._pointer
;		public static explicit operator FileOutputStream(Gio.OutputStream value) => (FileOutputStream)(IntPtr)value
;		public static implicit operator GObject.Object(FileOutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator FileOutputStream(GObject.Object value) => (FileOutputStream)(IntPtr)value
;	}
	[Flags]
	public enum FileCreateFlags
	{
		none = 0,
		@private = 1,
		replace_destination = 2,
	}
	[Flags]
	public enum FileCopyFlags
	{
		none = 0,
		overwrite = 1,
		backup = 2,
		nofollow_symlinks = 4,
		all_metadata = 8,
		no_fallback_for_move = 16,
		target_default_perms = 32,
	}
	public ref struct FileEnumerator
	{
		private IntPtr _pointer;
		public static explicit operator FileEnumerator(IntPtr pointer) => new FileEnumerator { _pointer = pointer };
		public static explicit operator IntPtr(FileEnumerator value) => value._pointer
;		public static implicit operator GObject.Object(FileEnumerator value) => (GObject.Object)value._pointer
;		public static explicit operator FileEnumerator(GObject.Object value) => (FileEnumerator)(IntPtr)value
;	}
	[Flags]
	public enum FileQueryInfoFlags
	{
		none = 0,
		nofollow_symlinks = 1,
	}
	public ref struct Mount
	{
		private IntPtr _pointer;
		public static explicit operator Mount(IntPtr pointer) => new Mount { _pointer = pointer };
		public static explicit operator IntPtr(Mount value) => value._pointer
;	}
	[Flags]
	public enum FileMeasureFlags
	{
		none = 0,
		report_any_error = 2,
		apparent_size = 4,
		no_xdev = 8,
	}
	public ref struct FileMonitor
	{
		private IntPtr _pointer;
		public static explicit operator FileMonitor(IntPtr pointer) => new FileMonitor { _pointer = pointer };
		public static explicit operator IntPtr(FileMonitor value) => value._pointer
;		public static implicit operator GObject.Object(FileMonitor value) => (GObject.Object)value._pointer
;		public static explicit operator FileMonitor(GObject.Object value) => (FileMonitor)(IntPtr)value
;	}
	[Flags]
	public enum FileMonitorFlags
	{
		none = 0,
		watch_mounts = 1,
		send_moved = 2,
		watch_hard_links = 4,
		watch_moves = 8,
	}
	[Flags]
	public enum MountMountFlags
	{
		none = 0,
	}
	public enum FileType
	{
		unknown = 0,
		regular = 1,
		directory = 2,
		symbolic_link = 3,
		special = 4,
		shortcut = 5,
		mountable = 6,
	}
	public ref struct FileInfo
	{
		private IntPtr _pointer;
		public static explicit operator FileInfo(IntPtr pointer) => new FileInfo { _pointer = pointer };
		public static explicit operator IntPtr(FileInfo value) => value._pointer
;		public static implicit operator GObject.Object(FileInfo value) => (GObject.Object)value._pointer
;		public static explicit operator FileInfo(GObject.Object value) => (FileInfo)(IntPtr)value
;	}
	public ref struct FileAttributeInfoList
	{
		private IntPtr _pointer;
		public static explicit operator FileAttributeInfoList(IntPtr pointer) => new FileAttributeInfoList { _pointer = pointer };
		public static explicit operator IntPtr(FileAttributeInfoList value) => value._pointer
;	}
	public ref struct FileInputStream
	{
		private IntPtr _pointer;
		public static explicit operator FileInputStream(IntPtr pointer) => new FileInputStream { _pointer = pointer };
		public static explicit operator IntPtr(FileInputStream value) => value._pointer
;		public static implicit operator Gio.InputStream(FileInputStream value) => (Gio.InputStream)value._pointer
;		public static explicit operator FileInputStream(Gio.InputStream value) => (FileInputStream)(IntPtr)value
;		public static implicit operator GObject.Object(FileInputStream value) => (GObject.Object)value._pointer
;		public static explicit operator FileInputStream(GObject.Object value) => (FileInputStream)(IntPtr)value
;	}
	public enum FileAttributeType
	{
		invalid = 0,
		@string = 1,
		byte_string = 2,
		boolean = 3,
		uint32 = 4,
		int32 = 5,
		uint64 = 6,
		int64 = 7,
		@object = 8,
		stringv = 9,
	}
	[Flags]
	public enum FileAttributeInfoFlags
	{
		none = 0,
		copy_with_file = 1,
		copy_when_moved = 2,
	}
	public ref struct FileAttributeInfo
	{
		private IntPtr _pointer;
		public static explicit operator FileAttributeInfo(IntPtr pointer) => new FileAttributeInfo { _pointer = pointer };
		public static explicit operator IntPtr(FileAttributeInfo value) => value._pointer
;	}
	public ref struct FileAttributeMatcher
	{
		private IntPtr _pointer;
		public static explicit operator FileAttributeMatcher(IntPtr pointer) => new FileAttributeMatcher { _pointer = pointer };
		public static explicit operator IntPtr(FileAttributeMatcher value) => value._pointer
;	}
	public enum FileAttributeStatus
	{
		unset = 0,
		set = 1,
		error_setting = 2,
	}
	public ref struct FileDescriptorBased
	{
		private IntPtr _pointer;
		public static explicit operator FileDescriptorBased(IntPtr pointer) => new FileDescriptorBased { _pointer = pointer };
		public static explicit operator IntPtr(FileDescriptorBased value) => value._pointer
;	}
	public ref struct FileDescriptorBasedIface
	{
		private IntPtr _pointer;
		public static explicit operator FileDescriptorBasedIface(IntPtr pointer) => new FileDescriptorBasedIface { _pointer = pointer };
		public static explicit operator IntPtr(FileDescriptorBasedIface value) => value._pointer
;	}
	public ref struct FileEnumeratorPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileEnumeratorPrivate(IntPtr pointer) => new FileEnumeratorPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileEnumeratorPrivate value) => value._pointer
;	}
	public ref struct FileEnumeratorClass
	{
		private IntPtr _pointer;
		public static explicit operator FileEnumeratorClass(IntPtr pointer) => new FileEnumeratorClass { _pointer = pointer };
		public static explicit operator IntPtr(FileEnumeratorClass value) => value._pointer
;	}
	public ref struct FileIOStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileIOStreamPrivate(IntPtr pointer) => new FileIOStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileIOStreamPrivate value) => value._pointer
;	}
	public ref struct IOStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator IOStreamClass(IntPtr pointer) => new IOStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(IOStreamClass value) => value._pointer
;	}
	public ref struct FileIOStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator FileIOStreamClass(IntPtr pointer) => new FileIOStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(FileIOStreamClass value) => value._pointer
;	}
	public ref struct FileIcon
	{
		private IntPtr _pointer;
		public static explicit operator FileIcon(IntPtr pointer) => new FileIcon { _pointer = pointer };
		public static explicit operator IntPtr(FileIcon value) => value._pointer
;		public static implicit operator GObject.Object(FileIcon value) => (GObject.Object)value._pointer
;		public static explicit operator FileIcon(GObject.Object value) => (FileIcon)(IntPtr)value
;	}
	public ref struct FileIconClass
	{
		private IntPtr _pointer;
		public static explicit operator FileIconClass(IntPtr pointer) => new FileIconClass { _pointer = pointer };
		public static explicit operator IntPtr(FileIconClass value) => value._pointer
;	}
	public ref struct FileIface
	{
		private IntPtr _pointer;
		public static explicit operator FileIface(IntPtr pointer) => new FileIface { _pointer = pointer };
		public static explicit operator IntPtr(FileIface value) => value._pointer
;	}
	public ref struct FileInfoClass
	{
		private IntPtr _pointer;
		public static explicit operator FileInfoClass(IntPtr pointer) => new FileInfoClass { _pointer = pointer };
		public static explicit operator IntPtr(FileInfoClass value) => value._pointer
;	}
	public ref struct FileInputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileInputStreamPrivate(IntPtr pointer) => new FileInputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileInputStreamPrivate value) => value._pointer
;	}
	public ref struct InputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator InputStreamClass(IntPtr pointer) => new InputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(InputStreamClass value) => value._pointer
;	}
	public ref struct FileInputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator FileInputStreamClass(IntPtr pointer) => new FileInputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(FileInputStreamClass value) => value._pointer
;	}
	public enum FileMonitorEvent
	{
		changed = 0,
		changes_done_hint = 1,
		deleted = 2,
		created = 3,
		attribute_changed = 4,
		pre_unmount = 5,
		unmounted = 6,
		moved = 7,
		renamed = 8,
		moved_in = 9,
		moved_out = 10,
	}
	public ref struct FileMonitorPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileMonitorPrivate(IntPtr pointer) => new FileMonitorPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileMonitorPrivate value) => value._pointer
;	}
	public ref struct FileMonitorClass
	{
		private IntPtr _pointer;
		public static explicit operator FileMonitorClass(IntPtr pointer) => new FileMonitorClass { _pointer = pointer };
		public static explicit operator IntPtr(FileMonitorClass value) => value._pointer
;	}
	public ref struct FileOutputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileOutputStreamPrivate(IntPtr pointer) => new FileOutputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileOutputStreamPrivate value) => value._pointer
;	}
	public ref struct OutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator OutputStreamClass(IntPtr pointer) => new OutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(OutputStreamClass value) => value._pointer
;	}
	public ref struct FileOutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator FileOutputStreamClass(IntPtr pointer) => new FileOutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(FileOutputStreamClass value) => value._pointer
;	}
	public ref struct FilenameCompleter
	{
		private IntPtr _pointer;
		public static explicit operator FilenameCompleter(IntPtr pointer) => new FilenameCompleter { _pointer = pointer };
		public static explicit operator IntPtr(FilenameCompleter value) => value._pointer
;		public static implicit operator GObject.Object(FilenameCompleter value) => (GObject.Object)value._pointer
;		public static explicit operator FilenameCompleter(GObject.Object value) => (FilenameCompleter)(IntPtr)value
;	}
	public ref struct FilenameCompleterClass
	{
		private IntPtr _pointer;
		public static explicit operator FilenameCompleterClass(IntPtr pointer) => new FilenameCompleterClass { _pointer = pointer };
		public static explicit operator IntPtr(FilenameCompleterClass value) => value._pointer
;	}
	public enum FilesystemPreviewType
	{
		if_always = 0,
		if_local = 1,
		never = 2,
	}
	public enum IOErrorEnum
	{
		failed = 0,
		not_found = 1,
		exists = 2,
		is_directory = 3,
		not_directory = 4,
		not_empty = 5,
		not_regular_file = 6,
		not_symbolic_link = 7,
		not_mountable_file = 8,
		filename_too_long = 9,
		invalid_filename = 10,
		too_many_links = 11,
		no_space = 12,
		invalid_argument = 13,
		permission_denied = 14,
		not_supported = 15,
		not_mounted = 16,
		already_mounted = 17,
		closed = 18,
		cancelled = 19,
		pending = 20,
		read_only = 21,
		cant_create_backup = 22,
		wrong_etag = 23,
		timed_out = 24,
		would_recurse = 25,
		busy = 26,
		would_block = 27,
		host_not_found = 28,
		would_merge = 29,
		failed_handled = 30,
		too_many_open_files = 31,
		not_initialized = 32,
		address_in_use = 33,
		partial_input = 34,
		invalid_data = 35,
		dbus_error = 36,
		host_unreachable = 37,
		network_unreachable = 38,
		connection_refused = 39,
		proxy_failed = 40,
		proxy_auth_failed = 41,
		proxy_need_auth = 42,
		proxy_not_allowed = 43,
		broken_pipe = 44,
		connection_closed = 44,
		not_connected = 45,
		message_too_large = 46,
	}
	public ref struct IOExtension
	{
		private IntPtr _pointer;
		public static explicit operator IOExtension(IntPtr pointer) => new IOExtension { _pointer = pointer };
		public static explicit operator IntPtr(IOExtension value) => value._pointer
;	}
	public ref struct IOExtensionPoint
	{
		private IntPtr _pointer;
		public static explicit operator IOExtensionPoint(IntPtr pointer) => new IOExtensionPoint { _pointer = pointer };
		public static explicit operator IntPtr(IOExtensionPoint value) => value._pointer
;	}
	public ref struct IOModule
	{
		private IntPtr _pointer;
		public static explicit operator IOModule(IntPtr pointer) => new IOModule { _pointer = pointer };
		public static explicit operator IntPtr(IOModule value) => value._pointer
;		public static implicit operator GObject.TypeModule(IOModule value) => (GObject.TypeModule)value._pointer
;		public static explicit operator IOModule(GObject.TypeModule value) => (IOModule)(IntPtr)value
;		public static implicit operator GObject.Object(IOModule value) => (GObject.Object)value._pointer
;		public static explicit operator IOModule(GObject.Object value) => (IOModule)(IntPtr)value
;	}
	public ref struct IOModuleClass
	{
		private IntPtr _pointer;
		public static explicit operator IOModuleClass(IntPtr pointer) => new IOModuleClass { _pointer = pointer };
		public static explicit operator IntPtr(IOModuleClass value) => value._pointer
;	}
	public ref struct IOModuleScope
	{
		private IntPtr _pointer;
		public static explicit operator IOModuleScope(IntPtr pointer) => new IOModuleScope { _pointer = pointer };
		public static explicit operator IntPtr(IOModuleScope value) => value._pointer
;	}
	public enum IOModuleScopeFlags
	{
		none = 0,
		block_duplicates = 1,
	}
	public ref struct IOSchedulerJob
	{
		private IntPtr _pointer;
		public static explicit operator IOSchedulerJob(IntPtr pointer) => new IOSchedulerJob { _pointer = pointer };
		public static explicit operator IntPtr(IOSchedulerJob value) => value._pointer
;	}
	[Flags]
	public enum IOStreamSpliceFlags
	{
		none = 0,
		close_stream1 = 1,
		close_stream2 = 2,
		wait_for_both = 4,
	}
	public ref struct IOStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator IOStreamPrivate(IntPtr pointer) => new IOStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(IOStreamPrivate value) => value._pointer
;	}
	public ref struct IOStreamAdapter
	{
		private IntPtr _pointer;
		public static explicit operator IOStreamAdapter(IntPtr pointer) => new IOStreamAdapter { _pointer = pointer };
		public static explicit operator IntPtr(IOStreamAdapter value) => value._pointer
;	}
	public ref struct IconIface
	{
		private IntPtr _pointer;
		public static explicit operator IconIface(IntPtr pointer) => new IconIface { _pointer = pointer };
		public static explicit operator IntPtr(IconIface value) => value._pointer
;	}
	public ref struct InetAddress
	{
		private IntPtr _pointer;
		public static explicit operator InetAddress(IntPtr pointer) => new InetAddress { _pointer = pointer };
		public static explicit operator IntPtr(InetAddress value) => value._pointer
;		public static implicit operator GObject.Object(InetAddress value) => (GObject.Object)value._pointer
;		public static explicit operator InetAddress(GObject.Object value) => (InetAddress)(IntPtr)value
;	}
	public enum SocketFamily
	{
		invalid = 0,
		unix = 1,
		ipv4 = 2,
		ipv6 = 10,
	}
	public ref struct InetAddressPrivate
	{
		private IntPtr _pointer;
		public static explicit operator InetAddressPrivate(IntPtr pointer) => new InetAddressPrivate { _pointer = pointer };
		public static explicit operator IntPtr(InetAddressPrivate value) => value._pointer
;	}
	public ref struct InetAddressClass
	{
		private IntPtr _pointer;
		public static explicit operator InetAddressClass(IntPtr pointer) => new InetAddressClass { _pointer = pointer };
		public static explicit operator IntPtr(InetAddressClass value) => value._pointer
;	}
	public ref struct InetAddressMask
	{
		private IntPtr _pointer;
		public static explicit operator InetAddressMask(IntPtr pointer) => new InetAddressMask { _pointer = pointer };
		public static explicit operator IntPtr(InetAddressMask value) => value._pointer
;		public static implicit operator GObject.Object(InetAddressMask value) => (GObject.Object)value._pointer
;		public static explicit operator InetAddressMask(GObject.Object value) => (InetAddressMask)(IntPtr)value
;	}
	public ref struct InetAddressMaskPrivate
	{
		private IntPtr _pointer;
		public static explicit operator InetAddressMaskPrivate(IntPtr pointer) => new InetAddressMaskPrivate { _pointer = pointer };
		public static explicit operator IntPtr(InetAddressMaskPrivate value) => value._pointer
;	}
	public ref struct InetAddressMaskClass
	{
		private IntPtr _pointer;
		public static explicit operator InetAddressMaskClass(IntPtr pointer) => new InetAddressMaskClass { _pointer = pointer };
		public static explicit operator IntPtr(InetAddressMaskClass value) => value._pointer
;	}
	public ref struct SocketAddress
	{
		private IntPtr _pointer;
		public static explicit operator SocketAddress(IntPtr pointer) => new SocketAddress { _pointer = pointer };
		public static explicit operator IntPtr(SocketAddress value) => value._pointer
;		public static implicit operator GObject.Object(SocketAddress value) => (GObject.Object)value._pointer
;		public static explicit operator SocketAddress(GObject.Object value) => (SocketAddress)(IntPtr)value
;	}
	public ref struct InetSocketAddress
	{
		private IntPtr _pointer;
		public static explicit operator InetSocketAddress(IntPtr pointer) => new InetSocketAddress { _pointer = pointer };
		public static explicit operator IntPtr(InetSocketAddress value) => value._pointer
;		public static implicit operator Gio.SocketAddress(InetSocketAddress value) => (Gio.SocketAddress)value._pointer
;		public static explicit operator InetSocketAddress(Gio.SocketAddress value) => (InetSocketAddress)(IntPtr)value
;		public static implicit operator GObject.Object(InetSocketAddress value) => (GObject.Object)value._pointer
;		public static explicit operator InetSocketAddress(GObject.Object value) => (InetSocketAddress)(IntPtr)value
;	}
	public ref struct InetSocketAddressPrivate
	{
		private IntPtr _pointer;
		public static explicit operator InetSocketAddressPrivate(IntPtr pointer) => new InetSocketAddressPrivate { _pointer = pointer };
		public static explicit operator IntPtr(InetSocketAddressPrivate value) => value._pointer
;	}
	public ref struct SocketAddressClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketAddressClass(IntPtr pointer) => new SocketAddressClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketAddressClass value) => value._pointer
;	}
	public ref struct InetSocketAddressClass
	{
		private IntPtr _pointer;
		public static explicit operator InetSocketAddressClass(IntPtr pointer) => new InetSocketAddressClass { _pointer = pointer };
		public static explicit operator IntPtr(InetSocketAddressClass value) => value._pointer
;	}
	public ref struct InitableIface
	{
		private IntPtr _pointer;
		public static explicit operator InitableIface(IntPtr pointer) => new InitableIface { _pointer = pointer };
		public static explicit operator IntPtr(InitableIface value) => value._pointer
;	}
	public ref struct InputVector
	{
		private IntPtr _pointer;
		public static explicit operator InputVector(IntPtr pointer) => new InputVector { _pointer = pointer };
		public static explicit operator IntPtr(InputVector value) => value._pointer
;	}
	public ref struct SocketControlMessage
	{
		private IntPtr _pointer;
		public static explicit operator SocketControlMessage(IntPtr pointer) => new SocketControlMessage { _pointer = pointer };
		public static explicit operator IntPtr(SocketControlMessage value) => value._pointer
;		public static implicit operator GObject.Object(SocketControlMessage value) => (GObject.Object)value._pointer
;		public static explicit operator SocketControlMessage(GObject.Object value) => (SocketControlMessage)(IntPtr)value
;	}
	public ref struct InputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator InputStreamPrivate(IntPtr pointer) => new InputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(InputStreamPrivate value) => value._pointer
;	}
	public ref struct ListModel
	{
		private IntPtr _pointer;
		public static explicit operator ListModel(IntPtr pointer) => new ListModel { _pointer = pointer };
		public static explicit operator IntPtr(ListModel value) => value._pointer
;	}
	public ref struct ListModelInterface
	{
		private IntPtr _pointer;
		public static explicit operator ListModelInterface(IntPtr pointer) => new ListModelInterface { _pointer = pointer };
		public static explicit operator IntPtr(ListModelInterface value) => value._pointer
;	}
	public ref struct ListStore
	{
		private IntPtr _pointer;
		public static explicit operator ListStore(IntPtr pointer) => new ListStore { _pointer = pointer };
		public static explicit operator IntPtr(ListStore value) => value._pointer
;		public static implicit operator GObject.Object(ListStore value) => (GObject.Object)value._pointer
;		public static explicit operator ListStore(GObject.Object value) => (ListStore)(IntPtr)value
;	}
	public ref struct ListStoreClass
	{
		private IntPtr _pointer;
		public static explicit operator ListStoreClass(IntPtr pointer) => new ListStoreClass { _pointer = pointer };
		public static explicit operator IntPtr(ListStoreClass value) => value._pointer
;	}
	public ref struct LoadableIconIface
	{
		private IntPtr _pointer;
		public static explicit operator LoadableIconIface(IntPtr pointer) => new LoadableIconIface { _pointer = pointer };
		public static explicit operator IntPtr(LoadableIconIface value) => value._pointer
;	}
	public ref struct MemoryInputStream
	{
		private IntPtr _pointer;
		public static explicit operator MemoryInputStream(IntPtr pointer) => new MemoryInputStream { _pointer = pointer };
		public static explicit operator IntPtr(MemoryInputStream value) => value._pointer
;		public static implicit operator Gio.InputStream(MemoryInputStream value) => (Gio.InputStream)value._pointer
;		public static explicit operator MemoryInputStream(Gio.InputStream value) => (MemoryInputStream)(IntPtr)value
;		public static implicit operator GObject.Object(MemoryInputStream value) => (GObject.Object)value._pointer
;		public static explicit operator MemoryInputStream(GObject.Object value) => (MemoryInputStream)(IntPtr)value
;	}
	public ref struct MemoryInputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MemoryInputStreamPrivate(IntPtr pointer) => new MemoryInputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MemoryInputStreamPrivate value) => value._pointer
;	}
	public ref struct MemoryInputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator MemoryInputStreamClass(IntPtr pointer) => new MemoryInputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(MemoryInputStreamClass value) => value._pointer
;	}
	public ref struct MemoryOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator MemoryOutputStream(IntPtr pointer) => new MemoryOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(MemoryOutputStream value) => value._pointer
;		public static implicit operator Gio.OutputStream(MemoryOutputStream value) => (Gio.OutputStream)value._pointer
;		public static explicit operator MemoryOutputStream(Gio.OutputStream value) => (MemoryOutputStream)(IntPtr)value
;		public static implicit operator GObject.Object(MemoryOutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator MemoryOutputStream(GObject.Object value) => (MemoryOutputStream)(IntPtr)value
;	}
	public ref struct MemoryOutputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MemoryOutputStreamPrivate(IntPtr pointer) => new MemoryOutputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MemoryOutputStreamPrivate value) => value._pointer
;	}
	public ref struct MemoryOutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator MemoryOutputStreamClass(IntPtr pointer) => new MemoryOutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(MemoryOutputStreamClass value) => value._pointer
;	}
	public ref struct Menu
	{
		private IntPtr _pointer;
		public static explicit operator Menu(IntPtr pointer) => new Menu { _pointer = pointer };
		public static explicit operator IntPtr(Menu value) => value._pointer
;		public static implicit operator Gio.MenuModel(Menu value) => (Gio.MenuModel)value._pointer
;		public static explicit operator Menu(Gio.MenuModel value) => (Menu)(IntPtr)value
;		public static implicit operator GObject.Object(Menu value) => (GObject.Object)value._pointer
;		public static explicit operator Menu(GObject.Object value) => (Menu)(IntPtr)value
;	}
	public ref struct MenuItem
	{
		private IntPtr _pointer;
		public static explicit operator MenuItem(IntPtr pointer) => new MenuItem { _pointer = pointer };
		public static explicit operator IntPtr(MenuItem value) => value._pointer
;		public static implicit operator GObject.Object(MenuItem value) => (GObject.Object)value._pointer
;		public static explicit operator MenuItem(GObject.Object value) => (MenuItem)(IntPtr)value
;	}
	public ref struct MenuAttributeIter
	{
		private IntPtr _pointer;
		public static explicit operator MenuAttributeIter(IntPtr pointer) => new MenuAttributeIter { _pointer = pointer };
		public static explicit operator IntPtr(MenuAttributeIter value) => value._pointer
;		public static implicit operator GObject.Object(MenuAttributeIter value) => (GObject.Object)value._pointer
;		public static explicit operator MenuAttributeIter(GObject.Object value) => (MenuAttributeIter)(IntPtr)value
;	}
	public ref struct MenuAttributeIterPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuAttributeIterPrivate(IntPtr pointer) => new MenuAttributeIterPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuAttributeIterPrivate value) => value._pointer
;	}
	public ref struct MenuAttributeIterClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuAttributeIterClass(IntPtr pointer) => new MenuAttributeIterClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuAttributeIterClass value) => value._pointer
;	}
	public ref struct MenuLinkIter
	{
		private IntPtr _pointer;
		public static explicit operator MenuLinkIter(IntPtr pointer) => new MenuLinkIter { _pointer = pointer };
		public static explicit operator IntPtr(MenuLinkIter value) => value._pointer
;		public static implicit operator GObject.Object(MenuLinkIter value) => (GObject.Object)value._pointer
;		public static explicit operator MenuLinkIter(GObject.Object value) => (MenuLinkIter)(IntPtr)value
;	}
	public ref struct MenuLinkIterPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuLinkIterPrivate(IntPtr pointer) => new MenuLinkIterPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuLinkIterPrivate value) => value._pointer
;	}
	public ref struct MenuLinkIterClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuLinkIterClass(IntPtr pointer) => new MenuLinkIterClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuLinkIterClass value) => value._pointer
;	}
	public ref struct MenuModelPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuModelPrivate(IntPtr pointer) => new MenuModelPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuModelPrivate value) => value._pointer
;	}
	public ref struct MenuModelClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuModelClass(IntPtr pointer) => new MenuModelClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuModelClass value) => value._pointer
;	}
	public ref struct MountIface
	{
		private IntPtr _pointer;
		public static explicit operator MountIface(IntPtr pointer) => new MountIface { _pointer = pointer };
		public static explicit operator IntPtr(MountIface value) => value._pointer
;	}
	public enum PasswordSave
	{
		never = 0,
		for_session = 1,
		permanently = 2,
	}
	public enum MountOperationResult
	{
		handled = 0,
		aborted = 1,
		unhandled = 2,
	}
	public ref struct MountOperationPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MountOperationPrivate(IntPtr pointer) => new MountOperationPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MountOperationPrivate value) => value._pointer
;	}
	public ref struct MountOperationClass
	{
		private IntPtr _pointer;
		public static explicit operator MountOperationClass(IntPtr pointer) => new MountOperationClass { _pointer = pointer };
		public static explicit operator IntPtr(MountOperationClass value) => value._pointer
;	}
	public ref struct NativeSocketAddress
	{
		private IntPtr _pointer;
		public static explicit operator NativeSocketAddress(IntPtr pointer) => new NativeSocketAddress { _pointer = pointer };
		public static explicit operator IntPtr(NativeSocketAddress value) => value._pointer
;	}
	public ref struct VolumeMonitor
	{
		private IntPtr _pointer;
		public static explicit operator VolumeMonitor(IntPtr pointer) => new VolumeMonitor { _pointer = pointer };
		public static explicit operator IntPtr(VolumeMonitor value) => value._pointer
;		public static implicit operator GObject.Object(VolumeMonitor value) => (GObject.Object)value._pointer
;		public static explicit operator VolumeMonitor(GObject.Object value) => (VolumeMonitor)(IntPtr)value
;	}
	public ref struct NativeVolumeMonitor
	{
		private IntPtr _pointer;
		public static explicit operator NativeVolumeMonitor(IntPtr pointer) => new NativeVolumeMonitor { _pointer = pointer };
		public static explicit operator IntPtr(NativeVolumeMonitor value) => value._pointer
;		public static implicit operator Gio.VolumeMonitor(NativeVolumeMonitor value) => (Gio.VolumeMonitor)value._pointer
;		public static explicit operator NativeVolumeMonitor(Gio.VolumeMonitor value) => (NativeVolumeMonitor)(IntPtr)value
;		public static implicit operator GObject.Object(NativeVolumeMonitor value) => (GObject.Object)value._pointer
;		public static explicit operator NativeVolumeMonitor(GObject.Object value) => (NativeVolumeMonitor)(IntPtr)value
;	}
	public ref struct VolumeMonitorClass
	{
		private IntPtr _pointer;
		public static explicit operator VolumeMonitorClass(IntPtr pointer) => new VolumeMonitorClass { _pointer = pointer };
		public static explicit operator IntPtr(VolumeMonitorClass value) => value._pointer
;	}
	public ref struct NativeVolumeMonitorClass
	{
		private IntPtr _pointer;
		public static explicit operator NativeVolumeMonitorClass(IntPtr pointer) => new NativeVolumeMonitorClass { _pointer = pointer };
		public static explicit operator IntPtr(NativeVolumeMonitorClass value) => value._pointer
;	}
	public ref struct NetworkAddress
	{
		private IntPtr _pointer;
		public static explicit operator NetworkAddress(IntPtr pointer) => new NetworkAddress { _pointer = pointer };
		public static explicit operator IntPtr(NetworkAddress value) => value._pointer
;		public static implicit operator GObject.Object(NetworkAddress value) => (GObject.Object)value._pointer
;		public static explicit operator NetworkAddress(GObject.Object value) => (NetworkAddress)(IntPtr)value
;	}
	public ref struct NetworkAddressPrivate
	{
		private IntPtr _pointer;
		public static explicit operator NetworkAddressPrivate(IntPtr pointer) => new NetworkAddressPrivate { _pointer = pointer };
		public static explicit operator IntPtr(NetworkAddressPrivate value) => value._pointer
;	}
	public ref struct NetworkAddressClass
	{
		private IntPtr _pointer;
		public static explicit operator NetworkAddressClass(IntPtr pointer) => new NetworkAddressClass { _pointer = pointer };
		public static explicit operator IntPtr(NetworkAddressClass value) => value._pointer
;	}
	public enum NetworkConnectivity
	{
		local = 1,
		limited = 2,
		portal = 3,
		full = 4,
	}
	public ref struct NetworkMonitor
	{
		private IntPtr _pointer;
		public static explicit operator NetworkMonitor(IntPtr pointer) => new NetworkMonitor { _pointer = pointer };
		public static explicit operator IntPtr(NetworkMonitor value) => value._pointer
;	}
	public ref struct NetworkMonitorInterface
	{
		private IntPtr _pointer;
		public static explicit operator NetworkMonitorInterface(IntPtr pointer) => new NetworkMonitorInterface { _pointer = pointer };
		public static explicit operator IntPtr(NetworkMonitorInterface value) => value._pointer
;	}
	public ref struct NetworkService
	{
		private IntPtr _pointer;
		public static explicit operator NetworkService(IntPtr pointer) => new NetworkService { _pointer = pointer };
		public static explicit operator IntPtr(NetworkService value) => value._pointer
;		public static implicit operator GObject.Object(NetworkService value) => (GObject.Object)value._pointer
;		public static explicit operator NetworkService(GObject.Object value) => (NetworkService)(IntPtr)value
;	}
	public ref struct NetworkServicePrivate
	{
		private IntPtr _pointer;
		public static explicit operator NetworkServicePrivate(IntPtr pointer) => new NetworkServicePrivate { _pointer = pointer };
		public static explicit operator IntPtr(NetworkServicePrivate value) => value._pointer
;	}
	public ref struct NetworkServiceClass
	{
		private IntPtr _pointer;
		public static explicit operator NetworkServiceClass(IntPtr pointer) => new NetworkServiceClass { _pointer = pointer };
		public static explicit operator IntPtr(NetworkServiceClass value) => value._pointer
;	}
	public enum NotificationPriority
	{
		normal = 0,
		low = 1,
		high = 2,
		urgent = 3,
	}
	public ref struct OutputVector
	{
		private IntPtr _pointer;
		public static explicit operator OutputVector(IntPtr pointer) => new OutputVector { _pointer = pointer };
		public static explicit operator IntPtr(OutputVector value) => value._pointer
;	}
	[Flags]
	public enum OutputStreamSpliceFlags
	{
		none = 0,
		close_source = 1,
		close_target = 2,
	}
	public ref struct OutputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator OutputStreamPrivate(IntPtr pointer) => new OutputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(OutputStreamPrivate value) => value._pointer
;	}
	public ref struct Permission
	{
		private IntPtr _pointer;
		public static explicit operator Permission(IntPtr pointer) => new Permission { _pointer = pointer };
		public static explicit operator IntPtr(Permission value) => value._pointer
;		public static implicit operator GObject.Object(Permission value) => (GObject.Object)value._pointer
;		public static explicit operator Permission(GObject.Object value) => (Permission)(IntPtr)value
;	}
	public ref struct PermissionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator PermissionPrivate(IntPtr pointer) => new PermissionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(PermissionPrivate value) => value._pointer
;	}
	public ref struct PermissionClass
	{
		private IntPtr _pointer;
		public static explicit operator PermissionClass(IntPtr pointer) => new PermissionClass { _pointer = pointer };
		public static explicit operator IntPtr(PermissionClass value) => value._pointer
;	}
	public ref struct PollableInputStreamInterface
	{
		private IntPtr _pointer;
		public static explicit operator PollableInputStreamInterface(IntPtr pointer) => new PollableInputStreamInterface { _pointer = pointer };
		public static explicit operator IntPtr(PollableInputStreamInterface value) => value._pointer
;	}
	public ref struct PollableOutputStreamInterface
	{
		private IntPtr _pointer;
		public static explicit operator PollableOutputStreamInterface(IntPtr pointer) => new PollableOutputStreamInterface { _pointer = pointer };
		public static explicit operator IntPtr(PollableOutputStreamInterface value) => value._pointer
;	}
	public ref struct PropertyAction
	{
		private IntPtr _pointer;
		public static explicit operator PropertyAction(IntPtr pointer) => new PropertyAction { _pointer = pointer };
		public static explicit operator IntPtr(PropertyAction value) => value._pointer
;		public static implicit operator GObject.Object(PropertyAction value) => (GObject.Object)value._pointer
;		public static explicit operator PropertyAction(GObject.Object value) => (PropertyAction)(IntPtr)value
;	}
	public ref struct Proxy
	{
		private IntPtr _pointer;
		public static explicit operator Proxy(IntPtr pointer) => new Proxy { _pointer = pointer };
		public static explicit operator IntPtr(Proxy value) => value._pointer
;	}
	public ref struct ProxyAddress
	{
		private IntPtr _pointer;
		public static explicit operator ProxyAddress(IntPtr pointer) => new ProxyAddress { _pointer = pointer };
		public static explicit operator IntPtr(ProxyAddress value) => value._pointer
;		public static implicit operator Gio.InetSocketAddress(ProxyAddress value) => (Gio.InetSocketAddress)value._pointer
;		public static explicit operator ProxyAddress(Gio.InetSocketAddress value) => (ProxyAddress)(IntPtr)value
;		public static implicit operator Gio.SocketAddress(ProxyAddress value) => (Gio.SocketAddress)value._pointer
;		public static explicit operator ProxyAddress(Gio.SocketAddress value) => (ProxyAddress)(IntPtr)value
;		public static implicit operator GObject.Object(ProxyAddress value) => (GObject.Object)value._pointer
;		public static explicit operator ProxyAddress(GObject.Object value) => (ProxyAddress)(IntPtr)value
;	}
	public ref struct ProxyAddressPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ProxyAddressPrivate(IntPtr pointer) => new ProxyAddressPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ProxyAddressPrivate value) => value._pointer
;	}
	public ref struct ProxyAddressClass
	{
		private IntPtr _pointer;
		public static explicit operator ProxyAddressClass(IntPtr pointer) => new ProxyAddressClass { _pointer = pointer };
		public static explicit operator IntPtr(ProxyAddressClass value) => value._pointer
;	}
	public ref struct ProxyResolver
	{
		private IntPtr _pointer;
		public static explicit operator ProxyResolver(IntPtr pointer) => new ProxyResolver { _pointer = pointer };
		public static explicit operator IntPtr(ProxyResolver value) => value._pointer
;	}
	public ref struct SocketAddressEnumerator
	{
		private IntPtr _pointer;
		public static explicit operator SocketAddressEnumerator(IntPtr pointer) => new SocketAddressEnumerator { _pointer = pointer };
		public static explicit operator IntPtr(SocketAddressEnumerator value) => value._pointer
;		public static implicit operator GObject.Object(SocketAddressEnumerator value) => (GObject.Object)value._pointer
;		public static explicit operator SocketAddressEnumerator(GObject.Object value) => (SocketAddressEnumerator)(IntPtr)value
;	}
	public ref struct ProxyAddressEnumeratorPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ProxyAddressEnumeratorPrivate(IntPtr pointer) => new ProxyAddressEnumeratorPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ProxyAddressEnumeratorPrivate value) => value._pointer
;	}
	public ref struct ProxyAddressEnumerator
	{
		private IntPtr _pointer;
		public static explicit operator ProxyAddressEnumerator(IntPtr pointer) => new ProxyAddressEnumerator { _pointer = pointer };
		public static explicit operator IntPtr(ProxyAddressEnumerator value) => value._pointer
;		public static implicit operator Gio.SocketAddressEnumerator(ProxyAddressEnumerator value) => (Gio.SocketAddressEnumerator)value._pointer
;		public static explicit operator ProxyAddressEnumerator(Gio.SocketAddressEnumerator value) => (ProxyAddressEnumerator)(IntPtr)value
;		public static implicit operator GObject.Object(ProxyAddressEnumerator value) => (GObject.Object)value._pointer
;		public static explicit operator ProxyAddressEnumerator(GObject.Object value) => (ProxyAddressEnumerator)(IntPtr)value
;	}
	public ref struct SocketAddressEnumeratorClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketAddressEnumeratorClass(IntPtr pointer) => new SocketAddressEnumeratorClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketAddressEnumeratorClass value) => value._pointer
;	}
	public ref struct ProxyAddressEnumeratorClass
	{
		private IntPtr _pointer;
		public static explicit operator ProxyAddressEnumeratorClass(IntPtr pointer) => new ProxyAddressEnumeratorClass { _pointer = pointer };
		public static explicit operator IntPtr(ProxyAddressEnumeratorClass value) => value._pointer
;	}
	public ref struct ProxyInterface
	{
		private IntPtr _pointer;
		public static explicit operator ProxyInterface(IntPtr pointer) => new ProxyInterface { _pointer = pointer };
		public static explicit operator IntPtr(ProxyInterface value) => value._pointer
;	}
	public ref struct ProxyResolverInterface
	{
		private IntPtr _pointer;
		public static explicit operator ProxyResolverInterface(IntPtr pointer) => new ProxyResolverInterface { _pointer = pointer };
		public static explicit operator IntPtr(ProxyResolverInterface value) => value._pointer
;	}
	public ref struct RemoteActionGroupInterface
	{
		private IntPtr _pointer;
		public static explicit operator RemoteActionGroupInterface(IntPtr pointer) => new RemoteActionGroupInterface { _pointer = pointer };
		public static explicit operator IntPtr(RemoteActionGroupInterface value) => value._pointer
;	}
	public ref struct Resolver
	{
		private IntPtr _pointer;
		public static explicit operator Resolver(IntPtr pointer) => new Resolver { _pointer = pointer };
		public static explicit operator IntPtr(Resolver value) => value._pointer
;		public static implicit operator GObject.Object(Resolver value) => (GObject.Object)value._pointer
;		public static explicit operator Resolver(GObject.Object value) => (Resolver)(IntPtr)value
;	}
	public enum ResolverRecordType
	{
		srv = 1,
		mx = 2,
		txt = 3,
		soa = 4,
		ns = 5,
	}
	public ref struct SrvTarget
	{
		private IntPtr _pointer;
		public static explicit operator SrvTarget(IntPtr pointer) => new SrvTarget { _pointer = pointer };
		public static explicit operator IntPtr(SrvTarget value) => value._pointer
;	}
	public ref struct ResolverPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ResolverPrivate(IntPtr pointer) => new ResolverPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ResolverPrivate value) => value._pointer
;	}
	public ref struct ResolverClass
	{
		private IntPtr _pointer;
		public static explicit operator ResolverClass(IntPtr pointer) => new ResolverClass { _pointer = pointer };
		public static explicit operator IntPtr(ResolverClass value) => value._pointer
;	}
	public enum ResolverError
	{
		not_found = 0,
		temporary_failure = 1,
		@internal = 2,
	}
	public ref struct Resource
	{
		private IntPtr _pointer;
		public static explicit operator Resource(IntPtr pointer) => new Resource { _pointer = pointer };
		public static explicit operator IntPtr(Resource value) => value._pointer
;	}
	[Flags]
	public enum ResourceLookupFlags
	{
		none = 0,
	}
	public enum ResourceError
	{
		not_found = 0,
		@internal = 1,
	}
	[Flags]
	public enum ResourceFlags
	{
		none = 0,
		compressed = 1,
	}
	public ref struct SeekableIface
	{
		private IntPtr _pointer;
		public static explicit operator SeekableIface(IntPtr pointer) => new SeekableIface { _pointer = pointer };
		public static explicit operator IntPtr(SeekableIface value) => value._pointer
;	}
	public ref struct Settings
	{
		private IntPtr _pointer;
		public static explicit operator Settings(IntPtr pointer) => new Settings { _pointer = pointer };
		public static explicit operator IntPtr(Settings value) => value._pointer
;		public static implicit operator GObject.Object(Settings value) => (GObject.Object)value._pointer
;		public static explicit operator Settings(GObject.Object value) => (Settings)(IntPtr)value
;	}
	public ref struct SettingsSchema
	{
		private IntPtr _pointer;
		public static explicit operator SettingsSchema(IntPtr pointer) => new SettingsSchema { _pointer = pointer };
		public static explicit operator IntPtr(SettingsSchema value) => value._pointer
;	}
	public ref struct SettingsBackend
	{
		private IntPtr _pointer;
		public static explicit operator SettingsBackend(IntPtr pointer) => new SettingsBackend { _pointer = pointer };
		public static explicit operator IntPtr(SettingsBackend value) => value._pointer
;		public static implicit operator GObject.Object(SettingsBackend value) => (GObject.Object)value._pointer
;		public static explicit operator SettingsBackend(GObject.Object value) => (SettingsBackend)(IntPtr)value
;	}
	[Flags]
	public enum SettingsBindFlags
	{
		@default = 0,
		get = 1,
		set = 2,
		no_sensitivity = 4,
		get_no_changes = 8,
		invert_boolean = 16,
	}
	public ref struct SettingsPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SettingsPrivate(IntPtr pointer) => new SettingsPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SettingsPrivate value) => value._pointer
;	}
	public ref struct SettingsBackendPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SettingsBackendPrivate(IntPtr pointer) => new SettingsBackendPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SettingsBackendPrivate value) => value._pointer
;	}
	public ref struct SettingsBackendClass
	{
		private IntPtr _pointer;
		public static explicit operator SettingsBackendClass(IntPtr pointer) => new SettingsBackendClass { _pointer = pointer };
		public static explicit operator IntPtr(SettingsBackendClass value) => value._pointer
;	}
	public ref struct SettingsClass
	{
		private IntPtr _pointer;
		public static explicit operator SettingsClass(IntPtr pointer) => new SettingsClass { _pointer = pointer };
		public static explicit operator IntPtr(SettingsClass value) => value._pointer
;	}
	public ref struct SettingsSchemaKey
	{
		private IntPtr _pointer;
		public static explicit operator SettingsSchemaKey(IntPtr pointer) => new SettingsSchemaKey { _pointer = pointer };
		public static explicit operator IntPtr(SettingsSchemaKey value) => value._pointer
;	}
	public ref struct SettingsSchemaSource
	{
		private IntPtr _pointer;
		public static explicit operator SettingsSchemaSource(IntPtr pointer) => new SettingsSchemaSource { _pointer = pointer };
		public static explicit operator IntPtr(SettingsSchemaSource value) => value._pointer
;	}
	public ref struct SimpleActionGroup
	{
		private IntPtr _pointer;
		public static explicit operator SimpleActionGroup(IntPtr pointer) => new SimpleActionGroup { _pointer = pointer };
		public static explicit operator IntPtr(SimpleActionGroup value) => value._pointer
;		public static implicit operator GObject.Object(SimpleActionGroup value) => (GObject.Object)value._pointer
;		public static explicit operator SimpleActionGroup(GObject.Object value) => (SimpleActionGroup)(IntPtr)value
;	}
	public ref struct SimpleActionGroupPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SimpleActionGroupPrivate(IntPtr pointer) => new SimpleActionGroupPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SimpleActionGroupPrivate value) => value._pointer
;	}
	public ref struct SimpleActionGroupClass
	{
		private IntPtr _pointer;
		public static explicit operator SimpleActionGroupClass(IntPtr pointer) => new SimpleActionGroupClass { _pointer = pointer };
		public static explicit operator IntPtr(SimpleActionGroupClass value) => value._pointer
;	}
	public ref struct SimpleAsyncResult
	{
		private IntPtr _pointer;
		public static explicit operator SimpleAsyncResult(IntPtr pointer) => new SimpleAsyncResult { _pointer = pointer };
		public static explicit operator IntPtr(SimpleAsyncResult value) => value._pointer
;		public static implicit operator GObject.Object(SimpleAsyncResult value) => (GObject.Object)value._pointer
;		public static explicit operator SimpleAsyncResult(GObject.Object value) => (SimpleAsyncResult)(IntPtr)value
;	}
	public ref struct SimpleAsyncResultClass
	{
		private IntPtr _pointer;
		public static explicit operator SimpleAsyncResultClass(IntPtr pointer) => new SimpleAsyncResultClass { _pointer = pointer };
		public static explicit operator IntPtr(SimpleAsyncResultClass value) => value._pointer
;	}
	public ref struct SimpleIOStream
	{
		private IntPtr _pointer;
		public static explicit operator SimpleIOStream(IntPtr pointer) => new SimpleIOStream { _pointer = pointer };
		public static explicit operator IntPtr(SimpleIOStream value) => value._pointer
;		public static implicit operator Gio.IOStream(SimpleIOStream value) => (Gio.IOStream)value._pointer
;		public static explicit operator SimpleIOStream(Gio.IOStream value) => (SimpleIOStream)(IntPtr)value
;		public static implicit operator GObject.Object(SimpleIOStream value) => (GObject.Object)value._pointer
;		public static explicit operator SimpleIOStream(GObject.Object value) => (SimpleIOStream)(IntPtr)value
;	}
	public ref struct SimplePermission
	{
		private IntPtr _pointer;
		public static explicit operator SimplePermission(IntPtr pointer) => new SimplePermission { _pointer = pointer };
		public static explicit operator IntPtr(SimplePermission value) => value._pointer
;		public static implicit operator Gio.Permission(SimplePermission value) => (Gio.Permission)value._pointer
;		public static explicit operator SimplePermission(Gio.Permission value) => (SimplePermission)(IntPtr)value
;		public static implicit operator GObject.Object(SimplePermission value) => (GObject.Object)value._pointer
;		public static explicit operator SimplePermission(GObject.Object value) => (SimplePermission)(IntPtr)value
;	}
	public ref struct SimpleProxyResolver
	{
		private IntPtr _pointer;
		public static explicit operator SimpleProxyResolver(IntPtr pointer) => new SimpleProxyResolver { _pointer = pointer };
		public static explicit operator IntPtr(SimpleProxyResolver value) => value._pointer
;		public static implicit operator GObject.Object(SimpleProxyResolver value) => (GObject.Object)value._pointer
;		public static explicit operator SimpleProxyResolver(GObject.Object value) => (SimpleProxyResolver)(IntPtr)value
;	}
	public ref struct SimpleProxyResolverPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SimpleProxyResolverPrivate(IntPtr pointer) => new SimpleProxyResolverPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SimpleProxyResolverPrivate value) => value._pointer
;	}
	public ref struct SimpleProxyResolverClass
	{
		private IntPtr _pointer;
		public static explicit operator SimpleProxyResolverClass(IntPtr pointer) => new SimpleProxyResolverClass { _pointer = pointer };
		public static explicit operator IntPtr(SimpleProxyResolverClass value) => value._pointer
;	}
	public ref struct Socket
	{
		private IntPtr _pointer;
		public static explicit operator Socket(IntPtr pointer) => new Socket { _pointer = pointer };
		public static explicit operator IntPtr(Socket value) => value._pointer
;		public static implicit operator GObject.Object(Socket value) => (GObject.Object)value._pointer
;		public static explicit operator Socket(GObject.Object value) => (Socket)(IntPtr)value
;	}
	public enum SocketType
	{
		invalid = 0,
		stream = 1,
		datagram = 2,
		seqpacket = 3,
	}
	public enum SocketProtocol
	{
		unknown = -1,
		@default = 0,
		tcp = 6,
		udp = 17,
		sctp = 132,
	}
	public ref struct SocketConnection
	{
		private IntPtr _pointer;
		public static explicit operator SocketConnection(IntPtr pointer) => new SocketConnection { _pointer = pointer };
		public static explicit operator IntPtr(SocketConnection value) => value._pointer
;		public static implicit operator Gio.IOStream(SocketConnection value) => (Gio.IOStream)value._pointer
;		public static explicit operator SocketConnection(Gio.IOStream value) => (SocketConnection)(IntPtr)value
;		public static implicit operator GObject.Object(SocketConnection value) => (GObject.Object)value._pointer
;		public static explicit operator SocketConnection(GObject.Object value) => (SocketConnection)(IntPtr)value
;	}
	public ref struct SocketPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SocketPrivate(IntPtr pointer) => new SocketPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SocketPrivate value) => value._pointer
;	}
	public ref struct SocketClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketClass(IntPtr pointer) => new SocketClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketClass value) => value._pointer
;	}
	public ref struct SocketClient
	{
		private IntPtr _pointer;
		public static explicit operator SocketClient(IntPtr pointer) => new SocketClient { _pointer = pointer };
		public static explicit operator IntPtr(SocketClient value) => value._pointer
;		public static implicit operator GObject.Object(SocketClient value) => (GObject.Object)value._pointer
;		public static explicit operator SocketClient(GObject.Object value) => (SocketClient)(IntPtr)value
;	}
	public ref struct SocketClientPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SocketClientPrivate(IntPtr pointer) => new SocketClientPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SocketClientPrivate value) => value._pointer
;	}
	public enum SocketClientEvent
	{
		resolving = 0,
		resolved = 1,
		connecting = 2,
		connected = 3,
		proxy_negotiating = 4,
		proxy_negotiated = 5,
		tls_handshaking = 6,
		tls_handshaked = 7,
		complete = 8,
	}
	public ref struct SocketClientClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketClientClass(IntPtr pointer) => new SocketClientClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketClientClass value) => value._pointer
;	}
	public ref struct SocketConnectableIface
	{
		private IntPtr _pointer;
		public static explicit operator SocketConnectableIface(IntPtr pointer) => new SocketConnectableIface { _pointer = pointer };
		public static explicit operator IntPtr(SocketConnectableIface value) => value._pointer
;	}
	public ref struct SocketConnectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SocketConnectionPrivate(IntPtr pointer) => new SocketConnectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SocketConnectionPrivate value) => value._pointer
;	}
	public ref struct SocketConnectionClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketConnectionClass(IntPtr pointer) => new SocketConnectionClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketConnectionClass value) => value._pointer
;	}
	public ref struct SocketControlMessagePrivate
	{
		private IntPtr _pointer;
		public static explicit operator SocketControlMessagePrivate(IntPtr pointer) => new SocketControlMessagePrivate { _pointer = pointer };
		public static explicit operator IntPtr(SocketControlMessagePrivate value) => value._pointer
;	}
	public ref struct SocketControlMessageClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketControlMessageClass(IntPtr pointer) => new SocketControlMessageClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketControlMessageClass value) => value._pointer
;	}
	public ref struct SocketListener
	{
		private IntPtr _pointer;
		public static explicit operator SocketListener(IntPtr pointer) => new SocketListener { _pointer = pointer };
		public static explicit operator IntPtr(SocketListener value) => value._pointer
;		public static implicit operator GObject.Object(SocketListener value) => (GObject.Object)value._pointer
;		public static explicit operator SocketListener(GObject.Object value) => (SocketListener)(IntPtr)value
;	}
	public ref struct SocketListenerPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SocketListenerPrivate(IntPtr pointer) => new SocketListenerPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SocketListenerPrivate value) => value._pointer
;	}
	public enum SocketListenerEvent
	{
		binding = 0,
		bound = 1,
		listening = 2,
		listened = 3,
	}
	public ref struct SocketListenerClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketListenerClass(IntPtr pointer) => new SocketListenerClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketListenerClass value) => value._pointer
;	}
	[Flags]
	public enum SocketMsgFlags
	{
		none = 0,
		oob = 1,
		peek = 2,
		dontroute = 4,
	}
	public ref struct SocketService
	{
		private IntPtr _pointer;
		public static explicit operator SocketService(IntPtr pointer) => new SocketService { _pointer = pointer };
		public static explicit operator IntPtr(SocketService value) => value._pointer
;		public static implicit operator Gio.SocketListener(SocketService value) => (Gio.SocketListener)value._pointer
;		public static explicit operator SocketService(Gio.SocketListener value) => (SocketService)(IntPtr)value
;		public static implicit operator GObject.Object(SocketService value) => (GObject.Object)value._pointer
;		public static explicit operator SocketService(GObject.Object value) => (SocketService)(IntPtr)value
;	}
	public ref struct SocketServicePrivate
	{
		private IntPtr _pointer;
		public static explicit operator SocketServicePrivate(IntPtr pointer) => new SocketServicePrivate { _pointer = pointer };
		public static explicit operator IntPtr(SocketServicePrivate value) => value._pointer
;	}
	public ref struct SocketServiceClass
	{
		private IntPtr _pointer;
		public static explicit operator SocketServiceClass(IntPtr pointer) => new SocketServiceClass { _pointer = pointer };
		public static explicit operator IntPtr(SocketServiceClass value) => value._pointer
;	}
	public ref struct StaticResource
	{
		private IntPtr _pointer;
		public static explicit operator StaticResource(IntPtr pointer) => new StaticResource { _pointer = pointer };
		public static explicit operator IntPtr(StaticResource value) => value._pointer
;	}
	public ref struct Subprocess
	{
		private IntPtr _pointer;
		public static explicit operator Subprocess(IntPtr pointer) => new Subprocess { _pointer = pointer };
		public static explicit operator IntPtr(Subprocess value) => value._pointer
;		public static implicit operator GObject.Object(Subprocess value) => (GObject.Object)value._pointer
;		public static explicit operator Subprocess(GObject.Object value) => (Subprocess)(IntPtr)value
;	}
	[Flags]
	public enum SubprocessFlags
	{
		none = 0,
		stdin_pipe = 1,
		stdin_inherit = 2,
		stdout_pipe = 4,
		stdout_silence = 8,
		stderr_pipe = 16,
		stderr_silence = 32,
		stderr_merge = 64,
		inherit_fds = 128,
	}
	public ref struct SubprocessLauncher
	{
		private IntPtr _pointer;
		public static explicit operator SubprocessLauncher(IntPtr pointer) => new SubprocessLauncher { _pointer = pointer };
		public static explicit operator IntPtr(SubprocessLauncher value) => value._pointer
;		public static implicit operator GObject.Object(SubprocessLauncher value) => (GObject.Object)value._pointer
;		public static explicit operator SubprocessLauncher(GObject.Object value) => (SubprocessLauncher)(IntPtr)value
;	}
	public ref struct Task
	{
		private IntPtr _pointer;
		public static explicit operator Task(IntPtr pointer) => new Task { _pointer = pointer };
		public static explicit operator IntPtr(Task value) => value._pointer
;		public static implicit operator GObject.Object(Task value) => (GObject.Object)value._pointer
;		public static explicit operator Task(GObject.Object value) => (Task)(IntPtr)value
;	}
	public ref struct TaskClass
	{
		private IntPtr _pointer;
		public static explicit operator TaskClass(IntPtr pointer) => new TaskClass { _pointer = pointer };
		public static explicit operator IntPtr(TaskClass value) => value._pointer
;	}
	public ref struct TcpConnection
	{
		private IntPtr _pointer;
		public static explicit operator TcpConnection(IntPtr pointer) => new TcpConnection { _pointer = pointer };
		public static explicit operator IntPtr(TcpConnection value) => value._pointer
;		public static implicit operator Gio.SocketConnection(TcpConnection value) => (Gio.SocketConnection)value._pointer
;		public static explicit operator TcpConnection(Gio.SocketConnection value) => (TcpConnection)(IntPtr)value
;		public static implicit operator Gio.IOStream(TcpConnection value) => (Gio.IOStream)value._pointer
;		public static explicit operator TcpConnection(Gio.IOStream value) => (TcpConnection)(IntPtr)value
;		public static implicit operator GObject.Object(TcpConnection value) => (GObject.Object)value._pointer
;		public static explicit operator TcpConnection(GObject.Object value) => (TcpConnection)(IntPtr)value
;	}
	public ref struct TcpConnectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TcpConnectionPrivate(IntPtr pointer) => new TcpConnectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TcpConnectionPrivate value) => value._pointer
;	}
	public ref struct TcpConnectionClass
	{
		private IntPtr _pointer;
		public static explicit operator TcpConnectionClass(IntPtr pointer) => new TcpConnectionClass { _pointer = pointer };
		public static explicit operator IntPtr(TcpConnectionClass value) => value._pointer
;	}
	public ref struct TcpWrapperConnection
	{
		private IntPtr _pointer;
		public static explicit operator TcpWrapperConnection(IntPtr pointer) => new TcpWrapperConnection { _pointer = pointer };
		public static explicit operator IntPtr(TcpWrapperConnection value) => value._pointer
;		public static implicit operator Gio.TcpConnection(TcpWrapperConnection value) => (Gio.TcpConnection)value._pointer
;		public static explicit operator TcpWrapperConnection(Gio.TcpConnection value) => (TcpWrapperConnection)(IntPtr)value
;		public static implicit operator Gio.SocketConnection(TcpWrapperConnection value) => (Gio.SocketConnection)value._pointer
;		public static explicit operator TcpWrapperConnection(Gio.SocketConnection value) => (TcpWrapperConnection)(IntPtr)value
;		public static implicit operator Gio.IOStream(TcpWrapperConnection value) => (Gio.IOStream)value._pointer
;		public static explicit operator TcpWrapperConnection(Gio.IOStream value) => (TcpWrapperConnection)(IntPtr)value
;		public static implicit operator GObject.Object(TcpWrapperConnection value) => (GObject.Object)value._pointer
;		public static explicit operator TcpWrapperConnection(GObject.Object value) => (TcpWrapperConnection)(IntPtr)value
;	}
	public ref struct TcpWrapperConnectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TcpWrapperConnectionPrivate(IntPtr pointer) => new TcpWrapperConnectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TcpWrapperConnectionPrivate value) => value._pointer
;	}
	public ref struct TcpWrapperConnectionClass
	{
		private IntPtr _pointer;
		public static explicit operator TcpWrapperConnectionClass(IntPtr pointer) => new TcpWrapperConnectionClass { _pointer = pointer };
		public static explicit operator IntPtr(TcpWrapperConnectionClass value) => value._pointer
;	}
	public ref struct TestDBus
	{
		private IntPtr _pointer;
		public static explicit operator TestDBus(IntPtr pointer) => new TestDBus { _pointer = pointer };
		public static explicit operator IntPtr(TestDBus value) => value._pointer
;		public static implicit operator GObject.Object(TestDBus value) => (GObject.Object)value._pointer
;		public static explicit operator TestDBus(GObject.Object value) => (TestDBus)(IntPtr)value
;	}
	[Flags]
	public enum TestDBusFlags
	{
		none = 0,
	}
	public ref struct ThemedIcon
	{
		private IntPtr _pointer;
		public static explicit operator ThemedIcon(IntPtr pointer) => new ThemedIcon { _pointer = pointer };
		public static explicit operator IntPtr(ThemedIcon value) => value._pointer
;		public static implicit operator GObject.Object(ThemedIcon value) => (GObject.Object)value._pointer
;		public static explicit operator ThemedIcon(GObject.Object value) => (ThemedIcon)(IntPtr)value
;	}
	public ref struct ThemedIconClass
	{
		private IntPtr _pointer;
		public static explicit operator ThemedIconClass(IntPtr pointer) => new ThemedIconClass { _pointer = pointer };
		public static explicit operator IntPtr(ThemedIconClass value) => value._pointer
;	}
	public ref struct ThreadedSocketServicePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ThreadedSocketServicePrivate(IntPtr pointer) => new ThreadedSocketServicePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ThreadedSocketServicePrivate value) => value._pointer
;	}
	public ref struct ThreadedSocketService
	{
		private IntPtr _pointer;
		public static explicit operator ThreadedSocketService(IntPtr pointer) => new ThreadedSocketService { _pointer = pointer };
		public static explicit operator IntPtr(ThreadedSocketService value) => value._pointer
;		public static implicit operator Gio.SocketService(ThreadedSocketService value) => (Gio.SocketService)value._pointer
;		public static explicit operator ThreadedSocketService(Gio.SocketService value) => (ThreadedSocketService)(IntPtr)value
;		public static implicit operator Gio.SocketListener(ThreadedSocketService value) => (Gio.SocketListener)value._pointer
;		public static explicit operator ThreadedSocketService(Gio.SocketListener value) => (ThreadedSocketService)(IntPtr)value
;		public static implicit operator GObject.Object(ThreadedSocketService value) => (GObject.Object)value._pointer
;		public static explicit operator ThreadedSocketService(GObject.Object value) => (ThreadedSocketService)(IntPtr)value
;	}
	public ref struct ThreadedSocketServiceClass
	{
		private IntPtr _pointer;
		public static explicit operator ThreadedSocketServiceClass(IntPtr pointer) => new ThreadedSocketServiceClass { _pointer = pointer };
		public static explicit operator IntPtr(ThreadedSocketServiceClass value) => value._pointer
;	}
	public ref struct TlsBackend
	{
		private IntPtr _pointer;
		public static explicit operator TlsBackend(IntPtr pointer) => new TlsBackend { _pointer = pointer };
		public static explicit operator IntPtr(TlsBackend value) => value._pointer
;	}
	public ref struct TlsBackendInterface
	{
		private IntPtr _pointer;
		public static explicit operator TlsBackendInterface(IntPtr pointer) => new TlsBackendInterface { _pointer = pointer };
		public static explicit operator IntPtr(TlsBackendInterface value) => value._pointer
;	}
	public ref struct TlsCertificatePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TlsCertificatePrivate(IntPtr pointer) => new TlsCertificatePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TlsCertificatePrivate value) => value._pointer
;	}
	public ref struct TlsCertificateClass
	{
		private IntPtr _pointer;
		public static explicit operator TlsCertificateClass(IntPtr pointer) => new TlsCertificateClass { _pointer = pointer };
		public static explicit operator IntPtr(TlsCertificateClass value) => value._pointer
;	}
	public enum TlsCertificateRequestFlags
	{
		none = 0,
	}
	public ref struct TlsConnection
	{
		private IntPtr _pointer;
		public static explicit operator TlsConnection(IntPtr pointer) => new TlsConnection { _pointer = pointer };
		public static explicit operator IntPtr(TlsConnection value) => value._pointer
;		public static implicit operator Gio.IOStream(TlsConnection value) => (Gio.IOStream)value._pointer
;		public static explicit operator TlsConnection(Gio.IOStream value) => (TlsConnection)(IntPtr)value
;		public static implicit operator GObject.Object(TlsConnection value) => (GObject.Object)value._pointer
;		public static explicit operator TlsConnection(GObject.Object value) => (TlsConnection)(IntPtr)value
;	}
	public ref struct TlsClientConnection
	{
		private IntPtr _pointer;
		public static explicit operator TlsClientConnection(IntPtr pointer) => new TlsClientConnection { _pointer = pointer };
		public static explicit operator IntPtr(TlsClientConnection value) => value._pointer
;	}
	public ref struct TlsClientConnectionInterface
	{
		private IntPtr _pointer;
		public static explicit operator TlsClientConnectionInterface(IntPtr pointer) => new TlsClientConnectionInterface { _pointer = pointer };
		public static explicit operator IntPtr(TlsClientConnectionInterface value) => value._pointer
;	}
	public ref struct TlsConnectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TlsConnectionPrivate(IntPtr pointer) => new TlsConnectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TlsConnectionPrivate value) => value._pointer
;	}
	public ref struct TlsConnectionClass
	{
		private IntPtr _pointer;
		public static explicit operator TlsConnectionClass(IntPtr pointer) => new TlsConnectionClass { _pointer = pointer };
		public static explicit operator IntPtr(TlsConnectionClass value) => value._pointer
;	}
	public enum TlsDatabaseLookupFlags
	{
		none = 0,
		keypair = 1,
	}
	[Flags]
	public enum TlsDatabaseVerifyFlags
	{
		none = 0,
	}
	public ref struct TlsDatabasePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TlsDatabasePrivate(IntPtr pointer) => new TlsDatabasePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TlsDatabasePrivate value) => value._pointer
;	}
	public ref struct TlsDatabaseClass
	{
		private IntPtr _pointer;
		public static explicit operator TlsDatabaseClass(IntPtr pointer) => new TlsDatabaseClass { _pointer = pointer };
		public static explicit operator IntPtr(TlsDatabaseClass value) => value._pointer
;	}
	public enum TlsError
	{
		unavailable = 0,
		misc = 1,
		bad_certificate = 2,
		not_tls = 3,
		handshake = 4,
		certificate_required = 5,
		eof = 6,
	}
	public ref struct TlsFileDatabase
	{
		private IntPtr _pointer;
		public static explicit operator TlsFileDatabase(IntPtr pointer) => new TlsFileDatabase { _pointer = pointer };
		public static explicit operator IntPtr(TlsFileDatabase value) => value._pointer
;	}
	public ref struct TlsFileDatabaseInterface
	{
		private IntPtr _pointer;
		public static explicit operator TlsFileDatabaseInterface(IntPtr pointer) => new TlsFileDatabaseInterface { _pointer = pointer };
		public static explicit operator IntPtr(TlsFileDatabaseInterface value) => value._pointer
;	}
	public enum TlsInteractionResult
	{
		unhandled = 0,
		handled = 1,
		failed = 2,
	}
	public ref struct TlsPassword
	{
		private IntPtr _pointer;
		public static explicit operator TlsPassword(IntPtr pointer) => new TlsPassword { _pointer = pointer };
		public static explicit operator IntPtr(TlsPassword value) => value._pointer
;		public static implicit operator GObject.Object(TlsPassword value) => (GObject.Object)value._pointer
;		public static explicit operator TlsPassword(GObject.Object value) => (TlsPassword)(IntPtr)value
;	}
	public ref struct TlsInteractionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TlsInteractionPrivate(IntPtr pointer) => new TlsInteractionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TlsInteractionPrivate value) => value._pointer
;	}
	public ref struct TlsInteractionClass
	{
		private IntPtr _pointer;
		public static explicit operator TlsInteractionClass(IntPtr pointer) => new TlsInteractionClass { _pointer = pointer };
		public static explicit operator IntPtr(TlsInteractionClass value) => value._pointer
;	}
	[Flags]
	public enum TlsPasswordFlags
	{
		none = 0,
		retry = 2,
		many_tries = 4,
		final_try = 8,
	}
	public ref struct TlsPasswordPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TlsPasswordPrivate(IntPtr pointer) => new TlsPasswordPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TlsPasswordPrivate value) => value._pointer
;	}
	public ref struct TlsPasswordClass
	{
		private IntPtr _pointer;
		public static explicit operator TlsPasswordClass(IntPtr pointer) => new TlsPasswordClass { _pointer = pointer };
		public static explicit operator IntPtr(TlsPasswordClass value) => value._pointer
;	}
	public ref struct TlsServerConnection
	{
		private IntPtr _pointer;
		public static explicit operator TlsServerConnection(IntPtr pointer) => new TlsServerConnection { _pointer = pointer };
		public static explicit operator IntPtr(TlsServerConnection value) => value._pointer
;	}
	public ref struct TlsServerConnectionInterface
	{
		private IntPtr _pointer;
		public static explicit operator TlsServerConnectionInterface(IntPtr pointer) => new TlsServerConnectionInterface { _pointer = pointer };
		public static explicit operator IntPtr(TlsServerConnectionInterface value) => value._pointer
;	}
	public ref struct UnixConnection
	{
		private IntPtr _pointer;
		public static explicit operator UnixConnection(IntPtr pointer) => new UnixConnection { _pointer = pointer };
		public static explicit operator IntPtr(UnixConnection value) => value._pointer
;		public static implicit operator Gio.SocketConnection(UnixConnection value) => (Gio.SocketConnection)value._pointer
;		public static explicit operator UnixConnection(Gio.SocketConnection value) => (UnixConnection)(IntPtr)value
;		public static implicit operator Gio.IOStream(UnixConnection value) => (Gio.IOStream)value._pointer
;		public static explicit operator UnixConnection(Gio.IOStream value) => (UnixConnection)(IntPtr)value
;		public static implicit operator GObject.Object(UnixConnection value) => (GObject.Object)value._pointer
;		public static explicit operator UnixConnection(GObject.Object value) => (UnixConnection)(IntPtr)value
;	}
	public ref struct UnixConnectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator UnixConnectionPrivate(IntPtr pointer) => new UnixConnectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(UnixConnectionPrivate value) => value._pointer
;	}
	public ref struct UnixConnectionClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixConnectionClass(IntPtr pointer) => new UnixConnectionClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixConnectionClass value) => value._pointer
;	}
	public ref struct UnixCredentialsMessage
	{
		private IntPtr _pointer;
		public static explicit operator UnixCredentialsMessage(IntPtr pointer) => new UnixCredentialsMessage { _pointer = pointer };
		public static explicit operator IntPtr(UnixCredentialsMessage value) => value._pointer
;		public static implicit operator Gio.SocketControlMessage(UnixCredentialsMessage value) => (Gio.SocketControlMessage)value._pointer
;		public static explicit operator UnixCredentialsMessage(Gio.SocketControlMessage value) => (UnixCredentialsMessage)(IntPtr)value
;		public static implicit operator GObject.Object(UnixCredentialsMessage value) => (GObject.Object)value._pointer
;		public static explicit operator UnixCredentialsMessage(GObject.Object value) => (UnixCredentialsMessage)(IntPtr)value
;	}
	public ref struct UnixCredentialsMessagePrivate
	{
		private IntPtr _pointer;
		public static explicit operator UnixCredentialsMessagePrivate(IntPtr pointer) => new UnixCredentialsMessagePrivate { _pointer = pointer };
		public static explicit operator IntPtr(UnixCredentialsMessagePrivate value) => value._pointer
;	}
	public ref struct UnixCredentialsMessageClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixCredentialsMessageClass(IntPtr pointer) => new UnixCredentialsMessageClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixCredentialsMessageClass value) => value._pointer
;	}
	public ref struct UnixFDListPrivate
	{
		private IntPtr _pointer;
		public static explicit operator UnixFDListPrivate(IntPtr pointer) => new UnixFDListPrivate { _pointer = pointer };
		public static explicit operator IntPtr(UnixFDListPrivate value) => value._pointer
;	}
	public ref struct UnixFDListClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixFDListClass(IntPtr pointer) => new UnixFDListClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixFDListClass value) => value._pointer
;	}
	public ref struct UnixFDMessage
	{
		private IntPtr _pointer;
		public static explicit operator UnixFDMessage(IntPtr pointer) => new UnixFDMessage { _pointer = pointer };
		public static explicit operator IntPtr(UnixFDMessage value) => value._pointer
;		public static implicit operator Gio.SocketControlMessage(UnixFDMessage value) => (Gio.SocketControlMessage)value._pointer
;		public static explicit operator UnixFDMessage(Gio.SocketControlMessage value) => (UnixFDMessage)(IntPtr)value
;		public static implicit operator GObject.Object(UnixFDMessage value) => (GObject.Object)value._pointer
;		public static explicit operator UnixFDMessage(GObject.Object value) => (UnixFDMessage)(IntPtr)value
;	}
	public ref struct UnixFDMessagePrivate
	{
		private IntPtr _pointer;
		public static explicit operator UnixFDMessagePrivate(IntPtr pointer) => new UnixFDMessagePrivate { _pointer = pointer };
		public static explicit operator IntPtr(UnixFDMessagePrivate value) => value._pointer
;	}
	public ref struct UnixFDMessageClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixFDMessageClass(IntPtr pointer) => new UnixFDMessageClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixFDMessageClass value) => value._pointer
;	}
	public ref struct UnixInputStream
	{
		private IntPtr _pointer;
		public static explicit operator UnixInputStream(IntPtr pointer) => new UnixInputStream { _pointer = pointer };
		public static explicit operator IntPtr(UnixInputStream value) => value._pointer
;		public static implicit operator Gio.InputStream(UnixInputStream value) => (Gio.InputStream)value._pointer
;		public static explicit operator UnixInputStream(Gio.InputStream value) => (UnixInputStream)(IntPtr)value
;		public static implicit operator GObject.Object(UnixInputStream value) => (GObject.Object)value._pointer
;		public static explicit operator UnixInputStream(GObject.Object value) => (UnixInputStream)(IntPtr)value
;	}
	public ref struct UnixInputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator UnixInputStreamPrivate(IntPtr pointer) => new UnixInputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(UnixInputStreamPrivate value) => value._pointer
;	}
	public ref struct UnixInputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixInputStreamClass(IntPtr pointer) => new UnixInputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixInputStreamClass value) => value._pointer
;	}
	public ref struct UnixMountEntry
	{
		private IntPtr _pointer;
		public static explicit operator UnixMountEntry(IntPtr pointer) => new UnixMountEntry { _pointer = pointer };
		public static explicit operator IntPtr(UnixMountEntry value) => value._pointer
;	}
	public ref struct UnixMountMonitor
	{
		private IntPtr _pointer;
		public static explicit operator UnixMountMonitor(IntPtr pointer) => new UnixMountMonitor { _pointer = pointer };
		public static explicit operator IntPtr(UnixMountMonitor value) => value._pointer
;		public static implicit operator GObject.Object(UnixMountMonitor value) => (GObject.Object)value._pointer
;		public static explicit operator UnixMountMonitor(GObject.Object value) => (UnixMountMonitor)(IntPtr)value
;	}
	public ref struct UnixMountMonitorClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixMountMonitorClass(IntPtr pointer) => new UnixMountMonitorClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixMountMonitorClass value) => value._pointer
;	}
	public ref struct UnixMountPoint
	{
		private IntPtr _pointer;
		public static explicit operator UnixMountPoint(IntPtr pointer) => new UnixMountPoint { _pointer = pointer };
		public static explicit operator IntPtr(UnixMountPoint value) => value._pointer
;	}
	public ref struct UnixOutputStream
	{
		private IntPtr _pointer;
		public static explicit operator UnixOutputStream(IntPtr pointer) => new UnixOutputStream { _pointer = pointer };
		public static explicit operator IntPtr(UnixOutputStream value) => value._pointer
;		public static implicit operator Gio.OutputStream(UnixOutputStream value) => (Gio.OutputStream)value._pointer
;		public static explicit operator UnixOutputStream(Gio.OutputStream value) => (UnixOutputStream)(IntPtr)value
;		public static implicit operator GObject.Object(UnixOutputStream value) => (GObject.Object)value._pointer
;		public static explicit operator UnixOutputStream(GObject.Object value) => (UnixOutputStream)(IntPtr)value
;	}
	public ref struct UnixOutputStreamPrivate
	{
		private IntPtr _pointer;
		public static explicit operator UnixOutputStreamPrivate(IntPtr pointer) => new UnixOutputStreamPrivate { _pointer = pointer };
		public static explicit operator IntPtr(UnixOutputStreamPrivate value) => value._pointer
;	}
	public ref struct UnixOutputStreamClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixOutputStreamClass(IntPtr pointer) => new UnixOutputStreamClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixOutputStreamClass value) => value._pointer
;	}
	public enum UnixSocketAddressType
	{
		invalid = 0,
		anonymous = 1,
		path = 2,
		@abstract = 3,
		abstract_padded = 4,
	}
	public ref struct UnixSocketAddress
	{
		private IntPtr _pointer;
		public static explicit operator UnixSocketAddress(IntPtr pointer) => new UnixSocketAddress { _pointer = pointer };
		public static explicit operator IntPtr(UnixSocketAddress value) => value._pointer
;		public static implicit operator Gio.SocketAddress(UnixSocketAddress value) => (Gio.SocketAddress)value._pointer
;		public static explicit operator UnixSocketAddress(Gio.SocketAddress value) => (UnixSocketAddress)(IntPtr)value
;		public static implicit operator GObject.Object(UnixSocketAddress value) => (GObject.Object)value._pointer
;		public static explicit operator UnixSocketAddress(GObject.Object value) => (UnixSocketAddress)(IntPtr)value
;	}
	public ref struct UnixSocketAddressPrivate
	{
		private IntPtr _pointer;
		public static explicit operator UnixSocketAddressPrivate(IntPtr pointer) => new UnixSocketAddressPrivate { _pointer = pointer };
		public static explicit operator IntPtr(UnixSocketAddressPrivate value) => value._pointer
;	}
	public ref struct UnixSocketAddressClass
	{
		private IntPtr _pointer;
		public static explicit operator UnixSocketAddressClass(IntPtr pointer) => new UnixSocketAddressClass { _pointer = pointer };
		public static explicit operator IntPtr(UnixSocketAddressClass value) => value._pointer
;	}
	public ref struct Vfs
	{
		private IntPtr _pointer;
		public static explicit operator Vfs(IntPtr pointer) => new Vfs { _pointer = pointer };
		public static explicit operator IntPtr(Vfs value) => value._pointer
;		public static implicit operator GObject.Object(Vfs value) => (GObject.Object)value._pointer
;		public static explicit operator Vfs(GObject.Object value) => (Vfs)(IntPtr)value
;	}
	public ref struct VfsClass
	{
		private IntPtr _pointer;
		public static explicit operator VfsClass(IntPtr pointer) => new VfsClass { _pointer = pointer };
		public static explicit operator IntPtr(VfsClass value) => value._pointer
;	}
	public ref struct VolumeIface
	{
		private IntPtr _pointer;
		public static explicit operator VolumeIface(IntPtr pointer) => new VolumeIface { _pointer = pointer };
		public static explicit operator IntPtr(VolumeIface value) => value._pointer
;	}
	public ref struct ZlibCompressor
	{
		private IntPtr _pointer;
		public static explicit operator ZlibCompressor(IntPtr pointer) => new ZlibCompressor { _pointer = pointer };
		public static explicit operator IntPtr(ZlibCompressor value) => value._pointer
;		public static implicit operator GObject.Object(ZlibCompressor value) => (GObject.Object)value._pointer
;		public static explicit operator ZlibCompressor(GObject.Object value) => (ZlibCompressor)(IntPtr)value
;	}
	public enum ZlibCompressorFormat
	{
		zlib = 0,
		gzip = 1,
		raw = 2,
	}
	public ref struct ZlibCompressorClass
	{
		private IntPtr _pointer;
		public static explicit operator ZlibCompressorClass(IntPtr pointer) => new ZlibCompressorClass { _pointer = pointer };
		public static explicit operator IntPtr(ZlibCompressorClass value) => value._pointer
;	}
	public ref struct ZlibDecompressor
	{
		private IntPtr _pointer;
		public static explicit operator ZlibDecompressor(IntPtr pointer) => new ZlibDecompressor { _pointer = pointer };
		public static explicit operator IntPtr(ZlibDecompressor value) => value._pointer
;		public static implicit operator GObject.Object(ZlibDecompressor value) => (GObject.Object)value._pointer
;		public static explicit operator ZlibDecompressor(GObject.Object value) => (ZlibDecompressor)(IntPtr)value
;	}
	public ref struct ZlibDecompressorClass
	{
		private IntPtr _pointer;
		public static explicit operator ZlibDecompressorClass(IntPtr pointer) => new ZlibDecompressorClass { _pointer = pointer };
		public static explicit operator IntPtr(ZlibDecompressorClass value) => value._pointer
;	}
	public static class GioInterop {
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_bus_get(Gio.BusType bus_type, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_bus_get_finish(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_bus_get_sync(Gio.BusType bus_type, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_own_name(Gio.BusType bus_type, string name, Gio.BusNameOwnerFlags flags, System.IntPtr bus_acquired_handler, System.IntPtr name_acquired_handler, System.IntPtr name_lost_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_own_name_on_connection(Gio.DBusConnection connection, string name, Gio.BusNameOwnerFlags flags, System.IntPtr name_acquired_handler, System.IntPtr name_lost_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_own_name_on_connection_with_closures(Gio.DBusConnection connection, string name, Gio.BusNameOwnerFlags flags, GObject.Closure name_acquired_closure, GObject.Closure name_lost_closure);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_own_name_with_closures(Gio.BusType bus_type, string name, Gio.BusNameOwnerFlags flags, GObject.Closure bus_acquired_closure, GObject.Closure name_acquired_closure, GObject.Closure name_lost_closure);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_bus_unown_name(uint owner_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_bus_unwatch_name(uint watcher_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_watch_name(Gio.BusType bus_type, string name, Gio.BusNameWatcherFlags flags, System.IntPtr name_appeared_handler, System.IntPtr name_vanished_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_watch_name_on_connection(Gio.DBusConnection connection, string name, Gio.BusNameWatcherFlags flags, System.IntPtr name_appeared_handler, System.IntPtr name_vanished_handler, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_watch_name_on_connection_with_closures(Gio.DBusConnection connection, string name, Gio.BusNameWatcherFlags flags, GObject.Closure name_appeared_closure, GObject.Closure name_vanished_closure);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_bus_watch_name_with_closures(Gio.BusType bus_type, string name, Gio.BusNameWatcherFlags flags, GObject.Closure name_appeared_closure, GObject.Closure name_vanished_closure);
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
		public static extern Gio.Icon g_content_type_get_icon(string type);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_content_type_get_mime_type(string type);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_content_type_get_symbolic_icon(string type);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_content_type_guess(string filename, System.IntPtr data, ulong data_size, System.IntPtr result_uncertain);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_content_type_guess_for_tree(Gio.File root);
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
		public static extern string g_dbus_address_get_for_bus_sync(Gio.BusType bus_type, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_address_get_stream(string address, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOStream g_dbus_address_get_stream_finish(Gio.AsyncResult res, string out_guid, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOStream g_dbus_address_get_stream_sync(string address, string out_guid, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_generate_guid();
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_gvalue_to_gvariant(GObject.Value gvalue, GLib.VariantType type);
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
		public static extern int g_dbus_is_supported_address(string @string, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_is_unique_name(string @string);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOErrorEnum g_io_error_from_errno(int err_no);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_io_error_quark();
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_io_modules_load_all_in_directory(System.IntPtr dirname);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_io_modules_load_all_in_directory_with_scope(System.IntPtr dirname, Gio.IOModuleScope scope);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_modules_scan_all_in_directory(System.IntPtr dirname);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_modules_scan_all_in_directory_with_scope(System.IntPtr dirname, Gio.IOModuleScope scope);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_scheduler_cancel_all_jobs();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_scheduler_push_job(System.IntPtr job_func, System.IntPtr user_data, System.IntPtr notify, int io_priority, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsBackend g_keyfile_settings_backend_new(string filename, string root_path, string root_group);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsBackend g_memory_settings_backend_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_networking_init();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsBackend g_null_settings_backend_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Source g_pollable_source_new(GObject.Object pollable_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Source g_pollable_source_new_full(GObject.Object pollable_stream, GLib.Source child_source, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_pollable_stream_read(Gio.InputStream stream, System.IntPtr buffer, ulong count, int blocking, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_pollable_stream_write(Gio.OutputStream stream, System.IntPtr buffer, ulong count, int blocking, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_pollable_stream_write_all(Gio.OutputStream stream, System.IntPtr buffer, ulong count, int blocking, System.IntPtr bytes_written, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resources_enumerate_children(string path, Gio.ResourceLookupFlags lookup_flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_resources_get_info(string path, Gio.ResourceLookupFlags lookup_flags, System.IntPtr size, System.IntPtr flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Bytes g_resources_lookup_data(string path, Gio.ResourceLookupFlags lookup_flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_resources_open_stream(string path, Gio.ResourceLookupFlags lookup_flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resources_register(Gio.Resource resource);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resources_unregister(Gio.Resource resource);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_report_gerror_in_idle(GObject.Object @object, System.IntPtr callback, System.IntPtr user_data, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_report_take_gerror_in_idle(GObject.Object @object, System.IntPtr callback, System.IntPtr user_data, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_is_mount_path_system_internal(System.IntPtr mount_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixMountEntry g_unix_mount_at(System.IntPtr mount_path, System.IntPtr time_read);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_compare(Gio.UnixMountEntry mount1, Gio.UnixMountEntry mount2);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixMountEntry g_unix_mount_copy(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixMountEntry g_unix_mount_for(System.IntPtr file_path, System.IntPtr time_read);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_unix_mount_free(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_unix_mount_get_device_path(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_unix_mount_get_fs_type(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_unix_mount_get_mount_path(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_guess_can_eject(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_unix_mount_guess_icon(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_unix_mount_guess_name(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_guess_should_display(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_unix_mount_guess_symbolic_icon(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_is_readonly(Gio.UnixMountEntry mount_entry);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_is_system_internal(Gio.UnixMountEntry mount_entry);
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
		public static extern int g_action_parse_detailed_name(string detailed_name, string action_name, out GLib.Variant target_value, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_action_print_detailed_name(string action_name, GLib.Variant target_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_activate(Gio.Action action, GLib.Variant parameter);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_change_state(Gio.Action action, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_action_get_enabled(Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_action_get_name(Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.VariantType g_action_get_parameter_type(Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_action_get_state(Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_action_get_state_hint(Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.VariantType g_action_get_state_type(Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SimpleAction g_simple_action_new(string name, GLib.VariantType parameter_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SimpleAction g_simple_action_new_stateful(string name, GLib.VariantType parameter_type, GLib.Variant state);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_action_set_enabled(Gio.SimpleAction simple, int enabled);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_action_set_state(Gio.SimpleAction simple, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_action_set_state_hint(Gio.SimpleAction simple, GLib.Variant state_hint);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_group_action_added(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_group_action_enabled_changed(Gio.ActionGroup action_group, string action_name, int enabled);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_group_action_removed(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_group_action_state_changed(Gio.ActionGroup action_group, string action_name, GLib.Variant state);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_group_activate_action(Gio.ActionGroup action_group, string action_name, GLib.Variant parameter);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_group_change_action_state(Gio.ActionGroup action_group, string action_name, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_action_group_get_action_enabled(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.VariantType g_action_group_get_action_parameter_type(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_action_group_get_action_state(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_action_group_get_action_state_hint(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.VariantType g_action_group_get_action_state_type(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_action_group_has_action(Gio.ActionGroup action_group, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_action_group_list_actions(Gio.ActionGroup action_group);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_action_group_query_action(Gio.ActionGroup action_group, string action_name, System.IntPtr enabled, out GLib.VariantType parameter_type, out GLib.VariantType state_type, out GLib.Variant state_hint, out GLib.Variant state);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_map_add_action(Gio.ActionMap action_map, Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_map_add_action_entries(Gio.ActionMap action_map, System.IntPtr entries, int n_entries, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Action g_action_map_lookup_action(Gio.ActionMap action_map, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_action_map_remove_action(Gio.ActionMap action_map, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppInfo g_app_info_create_from_commandline(string commandline, string application_name, Gio.AppInfoCreateFlags flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_info_get_all();
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_info_get_all_for_type(string content_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppInfo g_app_info_get_default_for_type(string content_type, int must_support_uris);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppInfo g_app_info_get_default_for_uri_scheme(string uri_scheme);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_info_get_fallback_for_type(string content_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_info_get_recommended_for_type(string content_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_launch_default_for_uri(string uri, Gio.AppLaunchContext launch_context, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_app_info_launch_default_for_uri_async(string uri, Gio.AppLaunchContext launch_context, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_launch_default_for_uri_finish(Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_app_info_reset_type_associations(string content_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_add_supports_type(Gio.AppInfo appinfo, string content_type, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_can_delete(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_can_remove_supports_type(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_delete(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppInfo g_app_info_dup(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_equal(Gio.AppInfo appinfo1, Gio.AppInfo appinfo2);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_info_get_commandline(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_app_info_get_description(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_app_info_get_display_name(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_info_get_executable(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_app_info_get_icon(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_app_info_get_id(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_app_info_get_name(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_info_get_supported_types(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_launch(Gio.AppInfo appinfo, System.IntPtr files, Gio.AppLaunchContext launch_context, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_launch_uris(Gio.AppInfo appinfo, System.IntPtr uris, Gio.AppLaunchContext launch_context, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_remove_supports_type(Gio.AppInfo appinfo, string content_type, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_set_as_default_for_extension(Gio.AppInfo appinfo, System.IntPtr extension, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_set_as_default_for_type(Gio.AppInfo appinfo, string content_type, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_set_as_last_used_for_type(Gio.AppInfo appinfo, string content_type, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_should_show(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_supports_files(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_app_info_supports_uris(Gio.AppInfo appinfo);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppLaunchContext g_app_launch_context_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_app_launch_context_get_display(Gio.AppLaunchContext context, Gio.AppInfo info, System.IntPtr files);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_app_launch_context_get_environment(Gio.AppLaunchContext context);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_app_launch_context_get_startup_notify_id(Gio.AppLaunchContext context, Gio.AppInfo info, System.IntPtr files);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_app_launch_context_launch_failed(Gio.AppLaunchContext context, string startup_notify_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_app_launch_context_setenv(Gio.AppLaunchContext context, string variable, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_app_launch_context_unsetenv(Gio.AppLaunchContext context, string variable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Cancellable g_cancellable_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Cancellable g_cancellable_get_current();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_cancellable_cancel(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_cancellable_connect(Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr data, System.IntPtr data_destroy_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_cancellable_disconnect(Gio.Cancellable cancellable, ulong handler_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_cancellable_get_fd(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_cancellable_is_cancelled(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_cancellable_make_pollfd(Gio.Cancellable cancellable, GLib.PollFD pollfd);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_cancellable_pop_current(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_cancellable_push_current(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_cancellable_release_fd(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_cancellable_reset(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_cancellable_set_error_if_cancelled(Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Source g_cancellable_source_new(Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.Object g_async_result_get_source_object(Gio.AsyncResult res);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_async_result_get_user_data(Gio.AsyncResult res);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_async_result_is_tagged(Gio.AsyncResult res, System.IntPtr source_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_async_result_legacy_propagate_error(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_icon_deserialize(GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_icon_hash(System.IntPtr icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_icon_new_for_string(string str, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_icon_equal(Gio.Icon icon1, Gio.Icon icon2);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_icon_serialize(Gio.Icon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_icon_to_string(Gio.Icon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_new_for_commandline_arg(string arg);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_new_for_commandline_arg_and_cwd(string arg, System.IntPtr cwd);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_new_for_path(System.IntPtr path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_new_for_uri(string uri);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_new_tmp(System.IntPtr tmpl, out Gio.FileIOStream iostream, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_parse_name(string parse_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileOutputStream g_file_append_to(Gio.File file, Gio.FileCreateFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_append_to_async(Gio.File file, Gio.FileCreateFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileOutputStream g_file_append_to_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_copy(Gio.File source, Gio.File destination, Gio.FileCopyFlags flags, Gio.Cancellable cancellable, System.IntPtr progress_callback, System.IntPtr progress_callback_data, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_copy_async(Gio.File source, Gio.File destination, Gio.FileCopyFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr progress_callback, System.IntPtr progress_callback_data, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_copy_attributes(Gio.File source, Gio.File destination, Gio.FileCopyFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_copy_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileOutputStream g_file_create(Gio.File file, Gio.FileCreateFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_create_async(Gio.File file, Gio.FileCreateFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileOutputStream g_file_create_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileIOStream g_file_create_readwrite(Gio.File file, Gio.FileCreateFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_create_readwrite_async(Gio.File file, Gio.FileCreateFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileIOStream g_file_create_readwrite_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_delete(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_delete_async(Gio.File file, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_delete_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_dup(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_eject_mountable(Gio.File file, Gio.MountUnmountFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_eject_mountable_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_eject_mountable_with_operation(Gio.File file, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_eject_mountable_with_operation_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileEnumerator g_file_enumerate_children(Gio.File file, string attributes, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_enumerate_children_async(Gio.File file, string attributes, Gio.FileQueryInfoFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileEnumerator g_file_enumerate_children_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_equal(Gio.File file1, Gio.File file2);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Mount g_file_find_enclosing_mount(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_find_enclosing_mount_async(Gio.File file, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Mount g_file_find_enclosing_mount_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_file_get_basename(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_get_child(Gio.File file, System.IntPtr name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_get_child_for_display_name(Gio.File file, string display_name, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_get_parent(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_get_parse_name(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_file_get_path(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_file_get_relative_path(Gio.File parent, Gio.File descendant);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_get_uri(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_get_uri_scheme(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_has_parent(Gio.File file, Gio.File parent);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_has_prefix(Gio.File file, Gio.File prefix);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_has_uri_scheme(Gio.File file, string uri_scheme);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_file_hash(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_is_native(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_load_contents(Gio.File file, Gio.Cancellable cancellable, System.IntPtr contents, System.IntPtr length, string etag_out, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_load_contents_async(Gio.File file, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_load_contents_finish(Gio.File file, Gio.AsyncResult res, System.IntPtr contents, System.IntPtr length, string etag_out, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_load_partial_contents_async(Gio.File file, Gio.Cancellable cancellable, System.IntPtr read_more_callback, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_load_partial_contents_finish(Gio.File file, Gio.AsyncResult res, System.IntPtr contents, System.IntPtr length, string etag_out, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_make_directory(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_make_directory_async(Gio.File file, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_make_directory_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_make_directory_with_parents(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_make_symbolic_link(Gio.File file, System.IntPtr symlink_value, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_measure_disk_usage(Gio.File file, Gio.FileMeasureFlags flags, Gio.Cancellable cancellable, System.IntPtr progress_callback, System.IntPtr progress_data, System.IntPtr disk_usage, System.IntPtr num_dirs, System.IntPtr num_files, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_measure_disk_usage_async(Gio.File file, Gio.FileMeasureFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr progress_callback, System.IntPtr progress_data, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_measure_disk_usage_finish(Gio.File file, Gio.AsyncResult result, System.IntPtr disk_usage, System.IntPtr num_dirs, System.IntPtr num_files, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileMonitor g_file_monitor(Gio.File file, Gio.FileMonitorFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileMonitor g_file_monitor_directory(Gio.File file, Gio.FileMonitorFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileMonitor g_file_monitor_file(Gio.File file, Gio.FileMonitorFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_mount_enclosing_volume(Gio.File location, Gio.MountMountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_mount_enclosing_volume_finish(Gio.File location, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_mount_mountable(Gio.File file, Gio.MountMountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_mount_mountable_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_move(Gio.File source, Gio.File destination, Gio.FileCopyFlags flags, Gio.Cancellable cancellable, System.IntPtr progress_callback, System.IntPtr progress_callback_data, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileIOStream g_file_open_readwrite(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_open_readwrite_async(Gio.File file, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileIOStream g_file_open_readwrite_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_poll_mountable(Gio.File file, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_poll_mountable_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppInfo g_file_query_default_handler(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_query_exists(Gio.File file, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileType g_file_query_file_type(Gio.File file, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_query_filesystem_info(Gio.File file, string attributes, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_query_filesystem_info_async(Gio.File file, string attributes, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_query_filesystem_info_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_query_info(Gio.File file, string attributes, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_query_info_async(Gio.File file, string attributes, Gio.FileQueryInfoFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_query_info_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeInfoList g_file_query_settable_attributes(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeInfoList g_file_query_writable_namespaces(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInputStream g_file_read(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_read_async(Gio.File file, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInputStream g_file_read_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileOutputStream g_file_replace(Gio.File file, string etag, int make_backup, Gio.FileCreateFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_replace_async(Gio.File file, string etag, int make_backup, Gio.FileCreateFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_replace_contents(Gio.File file, System.IntPtr contents, ulong length, string etag, int make_backup, Gio.FileCreateFlags flags, string new_etag, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_replace_contents_async(Gio.File file, System.IntPtr contents, ulong length, string etag, int make_backup, Gio.FileCreateFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_replace_contents_bytes_async(Gio.File file, GLib.Bytes contents, string etag, int make_backup, Gio.FileCreateFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_replace_contents_finish(Gio.File file, Gio.AsyncResult res, string new_etag, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileOutputStream g_file_replace_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileIOStream g_file_replace_readwrite(Gio.File file, string etag, int make_backup, Gio.FileCreateFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_replace_readwrite_async(Gio.File file, string etag, int make_backup, Gio.FileCreateFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileIOStream g_file_replace_readwrite_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_resolve_relative_path(Gio.File file, System.IntPtr relative_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attribute(Gio.File file, string attribute, Gio.FileAttributeType type, System.IntPtr value_p, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attribute_byte_string(Gio.File file, string attribute, string value, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attribute_int32(Gio.File file, string attribute, int value, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attribute_int64(Gio.File file, string attribute, long value, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attribute_string(Gio.File file, string attribute, string value, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attribute_uint32(Gio.File file, string attribute, uint value, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attribute_uint64(Gio.File file, string attribute, ulong value, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_set_attributes_async(Gio.File file, Gio.FileInfo info, Gio.FileQueryInfoFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attributes_finish(Gio.File file, Gio.AsyncResult result, out Gio.FileInfo info, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_set_attributes_from_info(Gio.File file, Gio.FileInfo info, Gio.FileQueryInfoFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_set_display_name(Gio.File file, string display_name, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_set_display_name_async(Gio.File file, string display_name, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_set_display_name_finish(Gio.File file, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_start_mountable(Gio.File file, Gio.DriveStartFlags flags, Gio.MountOperation start_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_start_mountable_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_stop_mountable(Gio.File file, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_stop_mountable_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_supports_thread_contexts(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_trash(Gio.File file, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_trash_async(Gio.File file, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_trash_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_unmount_mountable(Gio.File file, Gio.MountUnmountFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_unmount_mountable_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_unmount_mountable_with_operation(Gio.File file, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_unmount_mountable_with_operation_finish(Gio.File file, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppInfoMonitor g_app_info_monitor_get();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Application g_application_new(string application_id, Gio.ApplicationFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Application g_application_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_id_is_valid(string application_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_activate(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_add_main_option(Gio.Application application, string long_name, sbyte short_name, GLib.OptionFlags flags, GLib.OptionArg arg, string description, string arg_description);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_add_main_option_entries(Gio.Application application, System.IntPtr entries);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_add_option_group(Gio.Application application, GLib.OptionGroup group);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_bind_busy_property(Gio.Application application, GObject.Object @object, string property);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_application_get_application_id(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_application_get_dbus_connection(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_application_get_dbus_object_path(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ApplicationFlags g_application_get_flags(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_application_get_inactivity_timeout(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_get_is_busy(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_get_is_registered(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_get_is_remote(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_application_get_resource_base_path(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_hold(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_mark_busy(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_open(Gio.Application application, System.IntPtr files, int n_files, string hint);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_quit(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_register(Gio.Application application, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_release(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_run(Gio.Application application, int argc, System.IntPtr argv);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_send_notification(Gio.Application application, string id, Gio.Notification notification);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_set_action_group(Gio.Application application, Gio.ActionGroup action_group);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_set_application_id(Gio.Application application, string application_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_set_default(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_set_flags(Gio.Application application, Gio.ApplicationFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_set_inactivity_timeout(Gio.Application application, uint inactivity_timeout);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_set_resource_base_path(Gio.Application application, string resource_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_unbind_busy_property(Gio.Application application, GObject.Object @object, string property);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_unmark_busy(Gio.Application application);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_withdraw_notification(Gio.Application application, string id);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_connection_new_finish(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_connection_new_for_address_finish(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_connection_new_for_address_sync(string address, Gio.DBusConnectionFlags flags, Gio.DBusAuthObserver observer, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_connection_new_sync(Gio.IOStream stream, string guid, Gio.DBusConnectionFlags flags, Gio.DBusAuthObserver observer, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_new(Gio.IOStream stream, string guid, Gio.DBusConnectionFlags flags, Gio.DBusAuthObserver observer, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_new_for_address(string address, Gio.DBusConnectionFlags flags, Gio.DBusAuthObserver observer, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_add_filter(Gio.DBusConnection connection, System.IntPtr filter_function, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_call(Gio.DBusConnection connection, string bus_name, string object_path, string interface_name, string method_name, GLib.Variant parameters, GLib.VariantType reply_type, Gio.DBusCallFlags flags, int timeout_msec, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_connection_call_finish(Gio.DBusConnection connection, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_connection_call_sync(Gio.DBusConnection connection, string bus_name, string object_path, string interface_name, string method_name, GLib.Variant parameters, GLib.VariantType reply_type, Gio.DBusCallFlags flags, int timeout_msec, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_call_with_unix_fd_list(Gio.DBusConnection connection, string bus_name, string object_path, string interface_name, string method_name, GLib.Variant parameters, GLib.VariantType reply_type, Gio.DBusCallFlags flags, int timeout_msec, Gio.UnixFDList fd_list, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_connection_call_with_unix_fd_list_finish(Gio.DBusConnection connection, out Gio.UnixFDList out_fd_list, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_connection_call_with_unix_fd_list_sync(Gio.DBusConnection connection, string bus_name, string object_path, string interface_name, string method_name, GLib.Variant parameters, GLib.VariantType reply_type, Gio.DBusCallFlags flags, int timeout_msec, Gio.UnixFDList fd_list, out Gio.UnixFDList out_fd_list, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_close(Gio.DBusConnection connection, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_close_finish(Gio.DBusConnection connection, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_close_sync(Gio.DBusConnection connection, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_emit_signal(Gio.DBusConnection connection, string destination_bus_name, string object_path, string interface_name, string signal_name, GLib.Variant parameters, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_export_action_group(Gio.DBusConnection connection, string object_path, Gio.ActionGroup action_group, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_export_menu_model(Gio.DBusConnection connection, string object_path, Gio.MenuModel menu, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_flush(Gio.DBusConnection connection, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_flush_finish(Gio.DBusConnection connection, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_flush_sync(Gio.DBusConnection connection, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusCapabilityFlags g_dbus_connection_get_capabilities(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_get_exit_on_close(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_connection_get_guid(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_get_last_serial(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Credentials g_dbus_connection_get_peer_credentials(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOStream g_dbus_connection_get_stream(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_connection_get_unique_name(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_is_closed(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_register_object(Gio.DBusConnection connection, string object_path, Gio.DBusInterfaceInfo interface_info, Gio.DBusInterfaceVTable vtable, System.IntPtr user_data, System.IntPtr user_data_free_func, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_register_object_with_closures(Gio.DBusConnection connection, string object_path, Gio.DBusInterfaceInfo interface_info, GObject.Closure method_call_closure, GObject.Closure get_property_closure, GObject.Closure set_property_closure, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_register_subtree(Gio.DBusConnection connection, string object_path, Gio.DBusSubtreeVTable vtable, Gio.DBusSubtreeFlags flags, System.IntPtr user_data, System.IntPtr user_data_free_func, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_remove_filter(Gio.DBusConnection connection, uint filter_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_send_message(Gio.DBusConnection connection, Gio.DBusMessage message, Gio.DBusSendMessageFlags flags, System.IntPtr out_serial, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_send_message_with_reply(Gio.DBusConnection connection, Gio.DBusMessage message, Gio.DBusSendMessageFlags flags, int timeout_msec, System.IntPtr out_serial, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_connection_send_message_with_reply_finish(Gio.DBusConnection connection, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_connection_send_message_with_reply_sync(Gio.DBusConnection connection, Gio.DBusMessage message, Gio.DBusSendMessageFlags flags, int timeout_msec, System.IntPtr out_serial, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_set_exit_on_close(Gio.DBusConnection connection, int exit_on_close);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_connection_signal_subscribe(Gio.DBusConnection connection, string sender, string interface_name, string member, string object_path, string arg0, Gio.DBusSignalFlags flags, System.IntPtr callback, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_signal_unsubscribe(Gio.DBusConnection connection, uint subscription_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_start_message_processing(Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_unexport_action_group(Gio.DBusConnection connection, uint export_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_connection_unexport_menu_model(Gio.DBusConnection connection, uint export_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_unregister_object(Gio.DBusConnection connection, uint registration_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_connection_unregister_subtree(Gio.DBusConnection connection, uint registration_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Notification g_notification_new(string title);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_add_button(Gio.Notification notification, string label, string detailed_action);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_add_button_with_target_value(Gio.Notification notification, string label, string action, GLib.Variant target);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_set_body(Gio.Notification notification, string body);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_set_default_action(Gio.Notification notification, string detailed_action);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_set_default_action_and_target_value(Gio.Notification notification, string action, GLib.Variant target);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_set_icon(Gio.Notification notification, Gio.Icon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_set_priority(Gio.Notification notification, Gio.NotificationPriority priority);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_set_title(Gio.Notification notification, string title);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_notification_set_urgent(Gio.Notification notification, int urgent);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_application_command_line_create_file_for_arg(Gio.ApplicationCommandLine cmdline, string arg);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_application_command_line_get_arguments(Gio.ApplicationCommandLine cmdline, System.IntPtr argc);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_application_command_line_get_cwd(Gio.ApplicationCommandLine cmdline);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_application_command_line_get_environ(Gio.ApplicationCommandLine cmdline);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_command_line_get_exit_status(Gio.ApplicationCommandLine cmdline);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_application_command_line_get_is_remote(Gio.ApplicationCommandLine cmdline);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.VariantDict g_application_command_line_get_options_dict(Gio.ApplicationCommandLine cmdline);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_application_command_line_get_platform_data(Gio.ApplicationCommandLine cmdline);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_application_command_line_get_stdin(Gio.ApplicationCommandLine cmdline);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_application_command_line_getenv(Gio.ApplicationCommandLine cmdline, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_application_command_line_set_exit_status(Gio.ApplicationCommandLine cmdline, int exit_status);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_input_stream_clear_pending(Gio.InputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_input_stream_close(Gio.InputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_input_stream_close_async(Gio.InputStream stream, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_input_stream_close_finish(Gio.InputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_input_stream_has_pending(Gio.InputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_input_stream_is_closed(Gio.InputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_input_stream_read(Gio.InputStream stream, System.IntPtr buffer, ulong count, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_input_stream_read_all(Gio.InputStream stream, System.IntPtr buffer, ulong count, System.IntPtr bytes_read, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_input_stream_read_all_async(Gio.InputStream stream, System.IntPtr buffer, ulong count, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_input_stream_read_all_finish(Gio.InputStream stream, Gio.AsyncResult result, System.IntPtr bytes_read, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_input_stream_read_async(Gio.InputStream stream, System.IntPtr buffer, ulong count, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Bytes g_input_stream_read_bytes(Gio.InputStream stream, ulong count, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_input_stream_read_bytes_async(Gio.InputStream stream, ulong count, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Bytes g_input_stream_read_bytes_finish(Gio.InputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_input_stream_read_finish(Gio.InputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_input_stream_set_pending(Gio.InputStream stream, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_input_stream_skip(Gio.InputStream stream, ulong count, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_input_stream_skip_async(Gio.InputStream stream, ulong count, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_input_stream_skip_finish(Gio.InputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_async_initable_newv_async(ulong object_type, uint n_parameters, GObject.Parameter parameters, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_async_initable_init_async(Gio.AsyncInitable initable, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_async_initable_init_finish(Gio.AsyncInitable initable, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.Object g_async_initable_new_finish(Gio.AsyncInitable initable, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_seekable_can_seek(Gio.Seekable seekable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_seekable_can_truncate(Gio.Seekable seekable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_seekable_seek(Gio.Seekable seekable, long offset, GLib.SeekType type, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_seekable_tell(Gio.Seekable seekable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_seekable_truncate(Gio.Seekable seekable, long offset, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_buffered_input_stream_new(Gio.InputStream base_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_buffered_input_stream_new_sized(Gio.InputStream base_stream, ulong size);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_buffered_input_stream_fill(Gio.BufferedInputStream stream, long count, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_buffered_input_stream_fill_async(Gio.BufferedInputStream stream, long count, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_buffered_input_stream_fill_finish(Gio.BufferedInputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_buffered_input_stream_get_available(Gio.BufferedInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_buffered_input_stream_get_buffer_size(Gio.BufferedInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_buffered_input_stream_peek(Gio.BufferedInputStream stream, System.IntPtr buffer, ulong offset, ulong count);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_buffered_input_stream_peek_buffer(Gio.BufferedInputStream stream, System.IntPtr count);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_buffered_input_stream_read_byte(Gio.BufferedInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_buffered_input_stream_set_buffer_size(Gio.BufferedInputStream stream, ulong size);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_filter_input_stream_get_base_stream(Gio.FilterInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_filter_input_stream_get_close_base_stream(Gio.FilterInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_filter_input_stream_set_close_base_stream(Gio.FilterInputStream stream, int close_base);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_output_stream_clear_pending(Gio.OutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_close(Gio.OutputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_output_stream_close_async(Gio.OutputStream stream, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_close_finish(Gio.OutputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_flush(Gio.OutputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_output_stream_flush_async(Gio.OutputStream stream, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_flush_finish(Gio.OutputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_has_pending(Gio.OutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_is_closed(Gio.OutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_is_closing(Gio.OutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_set_pending(Gio.OutputStream stream, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_output_stream_splice(Gio.OutputStream stream, Gio.InputStream source, Gio.OutputStreamSpliceFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_output_stream_splice_async(Gio.OutputStream stream, Gio.InputStream source, Gio.OutputStreamSpliceFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_output_stream_splice_finish(Gio.OutputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_output_stream_write(Gio.OutputStream stream, System.IntPtr buffer, ulong count, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_write_all(Gio.OutputStream stream, System.IntPtr buffer, ulong count, System.IntPtr bytes_written, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_output_stream_write_all_async(Gio.OutputStream stream, System.IntPtr buffer, ulong count, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_output_stream_write_all_finish(Gio.OutputStream stream, Gio.AsyncResult result, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_output_stream_write_async(Gio.OutputStream stream, System.IntPtr buffer, ulong count, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_output_stream_write_bytes(Gio.OutputStream stream, GLib.Bytes bytes, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_output_stream_write_bytes_async(Gio.OutputStream stream, GLib.Bytes bytes, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_output_stream_write_bytes_finish(Gio.OutputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_output_stream_write_finish(Gio.OutputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_buffered_output_stream_new(Gio.OutputStream base_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_buffered_output_stream_new_sized(Gio.OutputStream base_stream, ulong size);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_buffered_output_stream_get_auto_grow(Gio.BufferedOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_buffered_output_stream_get_buffer_size(Gio.BufferedOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_buffered_output_stream_set_auto_grow(Gio.BufferedOutputStream stream, int auto_grow);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_buffered_output_stream_set_buffer_size(Gio.BufferedOutputStream stream, ulong size);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_filter_output_stream_get_base_stream(Gio.FilterOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_filter_output_stream_get_close_base_stream(Gio.FilterOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_filter_output_stream_set_close_base_stream(Gio.FilterOutputStream stream, int close_base);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_loadable_icon_load(Gio.LoadableIcon icon, int size, string type, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_loadable_icon_load_async(Gio.LoadableIcon icon, int size, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_loadable_icon_load_finish(Gio.LoadableIcon icon, Gio.AsyncResult res, string type, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.BytesIcon g_bytes_icon_new(GLib.Bytes bytes);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Bytes g_bytes_icon_get_bytes(Gio.BytesIcon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ConverterResult g_converter_convert(Gio.Converter converter, System.IntPtr inbuf, ulong inbuf_size, System.IntPtr outbuf, ulong outbuf_size, Gio.ConverterFlags flags, System.IntPtr bytes_read, System.IntPtr bytes_written, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_converter_reset(Gio.Converter converter);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.Object g_initable_newv(ulong object_type, uint n_parameters, System.IntPtr parameters, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_initable_init(Gio.Initable initable, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.CharsetConverter g_charset_converter_new(string to_charset, string from_charset, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_charset_converter_get_num_fallbacks(Gio.CharsetConverter converter);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_charset_converter_get_use_fallback(Gio.CharsetConverter converter);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_charset_converter_set_use_fallback(Gio.CharsetConverter converter, int use_fallback);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_pollable_input_stream_can_poll(Gio.PollableInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Source g_pollable_input_stream_create_source(Gio.PollableInputStream stream, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_pollable_input_stream_is_readable(Gio.PollableInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_pollable_input_stream_read_nonblocking(Gio.PollableInputStream stream, System.IntPtr buffer, ulong count, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_converter_input_stream_new(Gio.InputStream base_stream, Gio.Converter converter);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Converter g_converter_input_stream_get_converter(Gio.ConverterInputStream converter_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_pollable_output_stream_can_poll(Gio.PollableOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Source g_pollable_output_stream_create_source(Gio.PollableOutputStream stream, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_pollable_output_stream_is_writable(Gio.PollableOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_pollable_output_stream_write_nonblocking(Gio.PollableOutputStream stream, System.IntPtr buffer, ulong count, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_converter_output_stream_new(Gio.OutputStream base_stream, Gio.Converter converter);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Converter g_converter_output_stream_get_converter(Gio.ConverterOutputStream converter_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Credentials g_credentials_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_credentials_get_native(Gio.Credentials credentials, Gio.CredentialsType native_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_credentials_get_unix_pid(Gio.Credentials credentials, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_credentials_get_unix_user(Gio.Credentials credentials, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_credentials_is_same_user(Gio.Credentials credentials, Gio.Credentials other_credentials, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_credentials_set_native(Gio.Credentials credentials, Gio.CredentialsType native_type, System.IntPtr native);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_credentials_set_unix_user(Gio.Credentials credentials, uint uid, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_credentials_to_string(Gio.Credentials credentials);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_remote_action_group_activate_action_full(Gio.RemoteActionGroup remote, string action_name, GLib.Variant parameter, GLib.Variant platform_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_remote_action_group_change_action_state_full(Gio.RemoteActionGroup remote, string action_name, GLib.Variant value, GLib.Variant platform_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusActionGroup g_dbus_action_group_get(Gio.DBusConnection connection, string bus_name, string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusAnnotationInfo g_dbus_annotation_info_ref(Gio.DBusAnnotationInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_annotation_info_unref(Gio.DBusAnnotationInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_annotation_info_lookup(System.IntPtr annotations, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusArgInfo g_dbus_arg_info_ref(Gio.DBusArgInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_arg_info_unref(Gio.DBusArgInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusAuthObserver g_dbus_auth_observer_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_auth_observer_allow_mechanism(Gio.DBusAuthObserver observer, string mechanism);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_auth_observer_authorize_authenticated_peer(Gio.DBusAuthObserver observer, Gio.IOStream stream, Gio.Credentials credentials);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_stream_splice_finish(Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_stream_clear_pending(Gio.IOStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_stream_close(Gio.IOStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_stream_close_async(Gio.IOStream stream, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_stream_close_finish(Gio.IOStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_io_stream_get_input_stream(Gio.IOStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_io_stream_get_output_stream(Gio.IOStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_stream_has_pending(Gio.IOStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_stream_is_closed(Gio.IOStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_stream_set_pending(Gio.IOStream stream, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_stream_splice_async(Gio.IOStream stream1, Gio.IOStream stream2, Gio.IOStreamSpliceFlags flags, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixFDList g_unix_fd_list_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixFDList g_unix_fd_list_new_from_array(System.IntPtr fds, int n_fds);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_fd_list_append(Gio.UnixFDList list, int fd, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_fd_list_get(Gio.UnixFDList list, int index_, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_fd_list_get_length(Gio.UnixFDList list);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_unix_fd_list_peek_fds(Gio.UnixFDList list, System.IntPtr length);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_unix_fd_list_steal_fds(Gio.UnixFDList list, System.IntPtr length);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_menu_model_get_item_attribute_value(Gio.MenuModel model, int item_index, string attribute, GLib.VariantType expected_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuModel g_menu_model_get_item_link(Gio.MenuModel model, int item_index, string link);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_menu_model_get_n_items(Gio.MenuModel model);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_menu_model_is_mutable(Gio.MenuModel model);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_model_items_changed(Gio.MenuModel model, int position, int removed, int added);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuAttributeIter g_menu_model_iterate_item_attributes(Gio.MenuModel model, int item_index);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuLinkIter g_menu_model_iterate_item_links(Gio.MenuModel model, int item_index);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_info_cache_build(Gio.DBusInterfaceInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_info_cache_release(Gio.DBusInterfaceInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_info_generate_xml(Gio.DBusInterfaceInfo info, uint indent, GLib.String string_builder);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMethodInfo g_dbus_interface_info_lookup_method(Gio.DBusInterfaceInfo info, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusPropertyInfo g_dbus_interface_info_lookup_property(Gio.DBusInterfaceInfo info, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusSignalInfo g_dbus_interface_info_lookup_signal(Gio.DBusInterfaceInfo info, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterfaceInfo g_dbus_interface_info_ref(Gio.DBusInterfaceInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_info_unref(Gio.DBusInterfaceInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_message_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_message_new_from_blob(System.IntPtr blob, ulong blob_len, Gio.DBusCapabilityFlags capabilities, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_message_new_method_call(string name, string path, string interface_, string method);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_message_new_signal(string path, string interface_, string signal);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_dbus_message_bytes_needed(System.IntPtr blob, ulong blob_len, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_message_copy(Gio.DBusMessage message, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_arg0(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_message_get_body(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessageByteOrder g_dbus_message_get_byte_order(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_destination(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_error_name(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessageFlags g_dbus_message_get_flags(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_message_get_header(Gio.DBusMessage message, Gio.DBusMessageHeaderField header_field);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dbus_message_get_header_fields(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_interface(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_message_get_locked(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_member(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessageType g_dbus_message_get_message_type(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_message_get_num_unix_fds(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_path(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_message_get_reply_serial(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_sender(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_message_get_serial(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_get_signature(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixFDList g_dbus_message_get_unix_fd_list(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_lock(Gio.DBusMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_message_new_method_error_literal(Gio.DBusMessage method_call_message, string error_name, string error_message);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_message_new_method_reply(Gio.DBusMessage method_call_message);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_message_print(Gio.DBusMessage message, uint indent);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_body(Gio.DBusMessage message, GLib.Variant body);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_byte_order(Gio.DBusMessage message, Gio.DBusMessageByteOrder byte_order);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_destination(Gio.DBusMessage message, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_error_name(Gio.DBusMessage message, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_flags(Gio.DBusMessage message, Gio.DBusMessageFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_header(Gio.DBusMessage message, Gio.DBusMessageHeaderField header_field, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_interface(Gio.DBusMessage message, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_member(Gio.DBusMessage message, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_message_type(Gio.DBusMessage message, Gio.DBusMessageType type);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_num_unix_fds(Gio.DBusMessage message, uint value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_path(Gio.DBusMessage message, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_reply_serial(Gio.DBusMessage message, uint value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_sender(Gio.DBusMessage message, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_serial(Gio.DBusMessage message, uint serial);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_signature(Gio.DBusMessage message, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_message_set_unix_fd_list(Gio.DBusMessage message, Gio.UnixFDList fd_list);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dbus_message_to_blob(Gio.DBusMessage message, System.IntPtr out_size, Gio.DBusCapabilityFlags capabilities, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_message_to_gerror(Gio.DBusMessage message, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_error_encode_gerror(GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_error_get_remote_error(GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_error_is_remote_error(GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Error g_dbus_error_new_for_dbus_error(string dbus_error_name, string dbus_error_message);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_dbus_error_quark();
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_error_register_error(uint error_domain, int error_code, string dbus_error_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_error_register_error_domain(string error_domain_quark_name, System.IntPtr quark_volatile, Gio.DBusErrorEntry entries, uint num_entries);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_error_strip_remote_error(GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_error_unregister_error(uint error_domain, int error_code, string dbus_error_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterface g_dbus_object_get_interface(Gio.DBusObject @object, string interface_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dbus_object_get_interfaces(Gio.DBusObject @object);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_object_get_object_path(Gio.DBusObject @object);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObject g_dbus_interface_dup_object(Gio.DBusInterface interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterfaceInfo g_dbus_interface_get_info(Gio.DBusInterface interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObject g_dbus_interface_get_object(Gio.DBusInterface interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_set_object(Gio.DBusInterface interface_, Gio.DBusObject @object);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMethodInfo g_dbus_method_info_ref(Gio.DBusMethodInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_method_info_unref(Gio.DBusMethodInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusSignalInfo g_dbus_signal_info_ref(Gio.DBusSignalInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_signal_info_unref(Gio.DBusSignalInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusPropertyInfo g_dbus_property_info_ref(Gio.DBusPropertyInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_property_info_unref(Gio.DBusPropertyInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_method_invocation_get_connection(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_method_invocation_get_interface_name(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMessage g_dbus_method_invocation_get_message(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMethodInfo g_dbus_method_invocation_get_method_info(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_method_invocation_get_method_name(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_method_invocation_get_object_path(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_method_invocation_get_parameters(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusPropertyInfo g_dbus_method_invocation_get_property_info(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_method_invocation_get_sender(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dbus_method_invocation_get_user_data(Gio.DBusMethodInvocation invocation);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_method_invocation_return_dbus_error(Gio.DBusMethodInvocation invocation, string error_name, string error_message);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_method_invocation_return_error_literal(Gio.DBusMethodInvocation invocation, uint domain, int code, string message);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_method_invocation_return_gerror(Gio.DBusMethodInvocation invocation, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_method_invocation_return_value(Gio.DBusMethodInvocation invocation, GLib.Variant parameters);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_method_invocation_return_value_with_unix_fd_list(Gio.DBusMethodInvocation invocation, GLib.Variant parameters, Gio.UnixFDList fd_list);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_method_invocation_take_error(Gio.DBusMethodInvocation invocation, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_interface_skeleton_export(Gio.DBusInterfaceSkeleton interface_, Gio.DBusConnection connection, string object_path, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_skeleton_flush(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_interface_skeleton_get_connection(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dbus_interface_skeleton_get_connections(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterfaceSkeletonFlags g_dbus_interface_skeleton_get_flags(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterfaceInfo g_dbus_interface_skeleton_get_info(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_interface_skeleton_get_object_path(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_interface_skeleton_get_properties(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterfaceVTable g_dbus_interface_skeleton_get_vtable(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_interface_skeleton_has_connection(Gio.DBusInterfaceSkeleton interface_, Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_skeleton_set_flags(Gio.DBusInterfaceSkeleton interface_, Gio.DBusInterfaceSkeletonFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_skeleton_unexport(Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_interface_skeleton_unexport_from_connection(Gio.DBusInterfaceSkeleton interface_, Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusMenuModel g_dbus_menu_model_get(Gio.DBusConnection connection, string bus_name, string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusNodeInfo g_dbus_node_info_new_for_xml(string xml_data, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_node_info_generate_xml(Gio.DBusNodeInfo info, uint indent, GLib.String string_builder);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterfaceInfo g_dbus_node_info_lookup_interface(Gio.DBusNodeInfo info, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusNodeInfo g_dbus_node_info_ref(Gio.DBusNodeInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_node_info_unref(Gio.DBusNodeInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterface g_dbus_object_manager_get_interface(Gio.DBusObjectManager manager, string object_path, string interface_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObject g_dbus_object_manager_get_object(Gio.DBusObjectManager manager, string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_object_manager_get_object_path(Gio.DBusObjectManager manager);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dbus_object_manager_get_objects(Gio.DBusObjectManager manager);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectManagerClient g_dbus_object_manager_client_new_finish(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectManagerClient g_dbus_object_manager_client_new_for_bus_finish(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectManagerClient g_dbus_object_manager_client_new_for_bus_sync(Gio.BusType bus_type, Gio.DBusObjectManagerClientFlags flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectManagerClient g_dbus_object_manager_client_new_sync(Gio.DBusConnection connection, Gio.DBusObjectManagerClientFlags flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_manager_client_new(Gio.DBusConnection connection, Gio.DBusObjectManagerClientFlags flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_manager_client_new_for_bus(Gio.BusType bus_type, Gio.DBusObjectManagerClientFlags flags, string name, string object_path, System.IntPtr get_proxy_type_func, System.IntPtr get_proxy_type_user_data, System.IntPtr get_proxy_type_destroy_notify, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_object_manager_client_get_connection(Gio.DBusObjectManagerClient manager);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectManagerClientFlags g_dbus_object_manager_client_get_flags(Gio.DBusObjectManagerClient manager);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_object_manager_client_get_name(Gio.DBusObjectManagerClient manager);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_object_manager_client_get_name_owner(Gio.DBusObjectManagerClient manager);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectProxy g_dbus_object_proxy_new(Gio.DBusConnection connection, string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_object_proxy_get_connection(Gio.DBusObjectProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusProxy g_dbus_proxy_new_finish(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusProxy g_dbus_proxy_new_for_bus_finish(Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusProxy g_dbus_proxy_new_for_bus_sync(Gio.BusType bus_type, Gio.DBusProxyFlags flags, Gio.DBusInterfaceInfo info, string name, string object_path, string interface_name, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusProxy g_dbus_proxy_new_sync(Gio.DBusConnection connection, Gio.DBusProxyFlags flags, Gio.DBusInterfaceInfo info, string name, string object_path, string interface_name, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_proxy_new(Gio.DBusConnection connection, Gio.DBusProxyFlags flags, Gio.DBusInterfaceInfo info, string name, string object_path, string interface_name, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_proxy_new_for_bus(Gio.BusType bus_type, Gio.DBusProxyFlags flags, Gio.DBusInterfaceInfo info, string name, string object_path, string interface_name, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_proxy_call(Gio.DBusProxy proxy, string method_name, GLib.Variant parameters, Gio.DBusCallFlags flags, int timeout_msec, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_proxy_call_finish(Gio.DBusProxy proxy, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_proxy_call_sync(Gio.DBusProxy proxy, string method_name, GLib.Variant parameters, Gio.DBusCallFlags flags, int timeout_msec, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_proxy_call_with_unix_fd_list(Gio.DBusProxy proxy, string method_name, GLib.Variant parameters, Gio.DBusCallFlags flags, int timeout_msec, Gio.UnixFDList fd_list, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_proxy_call_with_unix_fd_list_finish(Gio.DBusProxy proxy, out Gio.UnixFDList out_fd_list, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_proxy_call_with_unix_fd_list_sync(Gio.DBusProxy proxy, string method_name, GLib.Variant parameters, Gio.DBusCallFlags flags, int timeout_msec, Gio.UnixFDList fd_list, out Gio.UnixFDList out_fd_list, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_dbus_proxy_get_cached_property(Gio.DBusProxy proxy, string property_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dbus_proxy_get_cached_property_names(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_proxy_get_connection(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_proxy_get_default_timeout(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusProxyFlags g_dbus_proxy_get_flags(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusInterfaceInfo g_dbus_proxy_get_interface_info(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_proxy_get_interface_name(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_proxy_get_name(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_proxy_get_name_owner(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_proxy_get_object_path(Gio.DBusProxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_proxy_set_cached_property(Gio.DBusProxy proxy, string property_name, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_proxy_set_default_timeout(Gio.DBusProxy proxy, int timeout_msec);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_proxy_set_interface_info(Gio.DBusProxy proxy, Gio.DBusInterfaceInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectManagerServer g_dbus_object_manager_server_new(string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_manager_server_export(Gio.DBusObjectManagerServer manager, Gio.DBusObjectSkeleton @object);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_manager_server_export_uniquely(Gio.DBusObjectManagerServer manager, Gio.DBusObjectSkeleton @object);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusConnection g_dbus_object_manager_server_get_connection(Gio.DBusObjectManagerServer manager);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_object_manager_server_is_exported(Gio.DBusObjectManagerServer manager, Gio.DBusObjectSkeleton @object);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_manager_server_set_connection(Gio.DBusObjectManagerServer manager, Gio.DBusConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_object_manager_server_unexport(Gio.DBusObjectManagerServer manager, string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusObjectSkeleton g_dbus_object_skeleton_new(string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_skeleton_add_interface(Gio.DBusObjectSkeleton @object, Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_skeleton_flush(Gio.DBusObjectSkeleton @object);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_skeleton_remove_interface(Gio.DBusObjectSkeleton @object, Gio.DBusInterfaceSkeleton interface_);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_skeleton_remove_interface_by_name(Gio.DBusObjectSkeleton @object, string interface_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_object_skeleton_set_object_path(Gio.DBusObjectSkeleton @object, string object_path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusServer g_dbus_server_new_sync(string address, Gio.DBusServerFlags flags, string guid, Gio.DBusAuthObserver observer, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_server_get_client_address(Gio.DBusServer server);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DBusServerFlags g_dbus_server_get_flags(Gio.DBusServer server);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_dbus_server_get_guid(Gio.DBusServer server);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dbus_server_is_active(Gio.DBusServer server);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_server_start(Gio.DBusServer server);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dbus_server_stop(Gio.DBusServer server);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DataInputStream g_data_input_stream_new(Gio.InputStream base_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DataStreamByteOrder g_data_input_stream_get_byte_order(Gio.DataInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DataStreamNewlineType g_data_input_stream_get_newline_type(Gio.DataInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern byte g_data_input_stream_read_byte(Gio.DataInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern short g_data_input_stream_read_int16(Gio.DataInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_input_stream_read_int32(Gio.DataInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_data_input_stream_read_int64(Gio.DataInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_data_input_stream_read_line(Gio.DataInputStream stream, System.IntPtr length, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_data_input_stream_read_line_async(Gio.DataInputStream stream, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_data_input_stream_read_line_finish(Gio.DataInputStream stream, Gio.AsyncResult result, System.IntPtr length, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_data_input_stream_read_line_finish_utf8(Gio.DataInputStream stream, Gio.AsyncResult result, System.IntPtr length, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_data_input_stream_read_line_utf8(Gio.DataInputStream stream, System.IntPtr length, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_data_input_stream_read_uint16(Gio.DataInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_data_input_stream_read_uint32(Gio.DataInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_data_input_stream_read_uint64(Gio.DataInputStream stream, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_data_input_stream_read_until(Gio.DataInputStream stream, string stop_chars, System.IntPtr length, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_data_input_stream_read_until_async(Gio.DataInputStream stream, string stop_chars, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_data_input_stream_read_until_finish(Gio.DataInputStream stream, Gio.AsyncResult result, System.IntPtr length, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_data_input_stream_read_upto(Gio.DataInputStream stream, string stop_chars, long stop_chars_len, System.IntPtr length, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_data_input_stream_read_upto_async(Gio.DataInputStream stream, string stop_chars, long stop_chars_len, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_data_input_stream_read_upto_finish(Gio.DataInputStream stream, Gio.AsyncResult result, System.IntPtr length, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_data_input_stream_set_byte_order(Gio.DataInputStream stream, Gio.DataStreamByteOrder order);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_data_input_stream_set_newline_type(Gio.DataInputStream stream, Gio.DataStreamNewlineType type);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DataOutputStream g_data_output_stream_new(Gio.OutputStream base_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DataStreamByteOrder g_data_output_stream_get_byte_order(Gio.DataOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_byte(Gio.DataOutputStream stream, byte data, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_int16(Gio.DataOutputStream stream, short data, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_int32(Gio.DataOutputStream stream, int data, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_int64(Gio.DataOutputStream stream, long data, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_string(Gio.DataOutputStream stream, string str, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_uint16(Gio.DataOutputStream stream, ushort data, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_uint32(Gio.DataOutputStream stream, uint data, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_data_output_stream_put_uint64(Gio.DataOutputStream stream, ulong data, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_data_output_stream_set_byte_order(Gio.DataOutputStream stream, Gio.DataStreamByteOrder order);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.IOCondition g_datagram_based_condition_check(Gio.DatagramBased datagram_based, GLib.IOCondition condition);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_datagram_based_condition_wait(Gio.DatagramBased datagram_based, GLib.IOCondition condition, long timeout, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Source g_datagram_based_create_source(Gio.DatagramBased datagram_based, GLib.IOCondition condition, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_datagram_based_receive_messages(Gio.DatagramBased datagram_based, System.IntPtr messages, uint num_messages, int flags, long timeout, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_datagram_based_send_messages(Gio.DatagramBased datagram_based, System.IntPtr messages, uint num_messages, int flags, long timeout, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DesktopAppInfo g_desktop_app_info_new(string desktop_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DesktopAppInfo g_desktop_app_info_new_from_filename(System.IntPtr filename);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DesktopAppInfo g_desktop_app_info_new_from_keyfile(GLib.KeyFile key_file);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_desktop_app_info_get_implementations(string @interface);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_desktop_app_info_search(string search_string);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_desktop_app_info_set_desktop_env(string desktop_env);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_desktop_app_info_get_action_name(Gio.DesktopAppInfo info, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_desktop_app_info_get_boolean(Gio.DesktopAppInfo info, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_desktop_app_info_get_categories(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_desktop_app_info_get_filename(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_desktop_app_info_get_generic_name(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_desktop_app_info_get_is_hidden(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_desktop_app_info_get_keywords(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_desktop_app_info_get_nodisplay(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_desktop_app_info_get_show_in(Gio.DesktopAppInfo info, string desktop_env);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_desktop_app_info_get_startup_wm_class(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_desktop_app_info_get_string(Gio.DesktopAppInfo info, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_desktop_app_info_has_key(Gio.DesktopAppInfo info, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_desktop_app_info_launch_action(Gio.DesktopAppInfo info, string action_name, Gio.AppLaunchContext launch_context);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_desktop_app_info_launch_uris_as_manager(Gio.DesktopAppInfo appinfo, System.IntPtr uris, Gio.AppLaunchContext launch_context, GLib.SpawnFlags spawn_flags, System.IntPtr user_setup, System.IntPtr user_setup_data, System.IntPtr pid_callback, System.IntPtr pid_callback_data, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_desktop_app_info_list_actions(Gio.DesktopAppInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.AppInfo g_desktop_app_info_lookup_get_default_for_uri_scheme(Gio.DesktopAppInfoLookup lookup, string uri_scheme);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_can_eject(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_can_poll_for_media(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_can_start(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_can_start_degraded(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_can_stop(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_drive_eject(Gio.Drive drive, Gio.MountUnmountFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_eject_finish(Gio.Drive drive, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_drive_eject_with_operation(Gio.Drive drive, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_eject_with_operation_finish(Gio.Drive drive, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_drive_enumerate_identifiers(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_drive_get_icon(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_drive_get_identifier(Gio.Drive drive, string kind);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_drive_get_name(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_drive_get_sort_key(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DriveStartStopType g_drive_get_start_stop_type(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_drive_get_symbolic_icon(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_drive_get_volumes(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_has_media(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_has_volumes(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_is_media_check_automatic(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_is_media_removable(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_is_removable(Gio.Drive drive);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_drive_poll_for_media(Gio.Drive drive, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_poll_for_media_finish(Gio.Drive drive, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_drive_start(Gio.Drive drive, Gio.DriveStartFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_start_finish(Gio.Drive drive, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_drive_stop(Gio.Drive drive, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_drive_stop_finish(Gio.Drive drive, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MountOperation g_mount_operation_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_operation_get_anonymous(Gio.MountOperation op);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_operation_get_choice(Gio.MountOperation op);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_mount_operation_get_domain(Gio.MountOperation op);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_mount_operation_get_password(Gio.MountOperation op);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.PasswordSave g_mount_operation_get_password_save(Gio.MountOperation op);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_mount_operation_get_username(Gio.MountOperation op);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_operation_reply(Gio.MountOperation op, Gio.MountOperationResult result);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_operation_set_anonymous(Gio.MountOperation op, int anonymous);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_operation_set_choice(Gio.MountOperation op, int choice);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_operation_set_domain(Gio.MountOperation op, string domain);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_operation_set_password(Gio.MountOperation op, string password);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_operation_set_password_save(Gio.MountOperation op, Gio.PasswordSave save);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_operation_set_username(Gio.MountOperation op, string username);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_volume_can_eject(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_volume_can_mount(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_volume_eject(Gio.Volume volume, Gio.MountUnmountFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_volume_eject_finish(Gio.Volume volume, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_volume_eject_with_operation(Gio.Volume volume, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_volume_eject_with_operation_finish(Gio.Volume volume, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_volume_enumerate_identifiers(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_volume_get_activation_root(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Drive g_volume_get_drive(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_volume_get_icon(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_volume_get_identifier(Gio.Volume volume, string kind);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Mount g_volume_get_mount(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_volume_get_name(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_volume_get_sort_key(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_volume_get_symbolic_icon(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_volume_get_uuid(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_volume_mount(Gio.Volume volume, Gio.MountMountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_volume_mount_finish(Gio.Volume volume, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_volume_should_automount(Gio.Volume volume);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_close(Gio.DtlsConnection conn, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_close_async(Gio.DtlsConnection conn, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_close_finish(Gio.DtlsConnection conn, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_emit_accept_certificate(Gio.DtlsConnection conn, Gio.TlsCertificate peer_cert, Gio.TlsCertificateFlags errors);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_dtls_connection_get_certificate(Gio.DtlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsDatabase g_dtls_connection_get_database(Gio.DtlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteraction g_dtls_connection_get_interaction(Gio.DtlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_dtls_connection_get_peer_certificate(Gio.DtlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_dtls_connection_get_peer_certificate_errors(Gio.DtlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsRehandshakeMode g_dtls_connection_get_rehandshake_mode(Gio.DtlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_get_require_close_notify(Gio.DtlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_handshake(Gio.DtlsConnection conn, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_handshake_async(Gio.DtlsConnection conn, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_handshake_finish(Gio.DtlsConnection conn, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_set_certificate(Gio.DtlsConnection conn, Gio.TlsCertificate certificate);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_set_database(Gio.DtlsConnection conn, Gio.TlsDatabase database);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_set_interaction(Gio.DtlsConnection conn, Gio.TlsInteraction interaction);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_set_rehandshake_mode(Gio.DtlsConnection conn, Gio.TlsRehandshakeMode mode);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_set_require_close_notify(Gio.DtlsConnection conn, int require_close_notify);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_shutdown(Gio.DtlsConnection conn, int shutdown_read, int shutdown_write, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_connection_shutdown_async(Gio.DtlsConnection conn, int shutdown_read, int shutdown_write, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_dtls_connection_shutdown_finish(Gio.DtlsConnection conn, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DtlsClientConnection g_dtls_client_connection_new(Gio.DatagramBased base_socket, Gio.SocketConnectable server_identity, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_dtls_client_connection_get_accepted_cas(Gio.DtlsClientConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnectable g_dtls_client_connection_get_server_identity(Gio.DtlsClientConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_dtls_client_connection_get_validation_flags(Gio.DtlsClientConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_client_connection_set_server_identity(Gio.DtlsClientConnection conn, Gio.SocketConnectable identity);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_dtls_client_connection_set_validation_flags(Gio.DtlsClientConnection conn, Gio.TlsCertificateFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddressEnumerator g_socket_connectable_enumerate(Gio.SocketConnectable connectable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddressEnumerator g_socket_connectable_proxy_enumerate(Gio.SocketConnectable connectable);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_socket_connectable_to_string(Gio.SocketConnectable connectable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_certificate_new_from_file(System.IntPtr file, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_certificate_new_from_files(System.IntPtr cert_file, System.IntPtr key_file, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_certificate_new_from_pem(string data, long length, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_tls_certificate_list_new_from_file(System.IntPtr file, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_certificate_get_issuer(Gio.TlsCertificate cert);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_certificate_is_same(Gio.TlsCertificate cert_one, Gio.TlsCertificate cert_two);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_tls_certificate_verify(Gio.TlsCertificate cert, Gio.SocketConnectable identity, Gio.TlsCertificate trusted_ca);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_tls_database_create_certificate_handle(Gio.TlsDatabase self, Gio.TlsCertificate certificate);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_database_lookup_certificate_for_handle(Gio.TlsDatabase self, string handle, Gio.TlsInteraction interaction, Gio.TlsDatabaseLookupFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_database_lookup_certificate_for_handle_async(Gio.TlsDatabase self, string handle, Gio.TlsInteraction interaction, Gio.TlsDatabaseLookupFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_database_lookup_certificate_for_handle_finish(Gio.TlsDatabase self, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_database_lookup_certificate_issuer(Gio.TlsDatabase self, Gio.TlsCertificate certificate, Gio.TlsInteraction interaction, Gio.TlsDatabaseLookupFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_database_lookup_certificate_issuer_async(Gio.TlsDatabase self, Gio.TlsCertificate certificate, Gio.TlsInteraction interaction, Gio.TlsDatabaseLookupFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_database_lookup_certificate_issuer_finish(Gio.TlsDatabase self, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_tls_database_lookup_certificates_issued_by(Gio.TlsDatabase self, GLib.ByteArray issuer_raw_dn, Gio.TlsInteraction interaction, Gio.TlsDatabaseLookupFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_database_lookup_certificates_issued_by_async(Gio.TlsDatabase self, GLib.ByteArray issuer_raw_dn, Gio.TlsInteraction interaction, Gio.TlsDatabaseLookupFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_tls_database_lookup_certificates_issued_by_finish(Gio.TlsDatabase self, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_tls_database_verify_chain(Gio.TlsDatabase self, Gio.TlsCertificate chain, string purpose, Gio.SocketConnectable identity, Gio.TlsInteraction interaction, Gio.TlsDatabaseVerifyFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_database_verify_chain_async(Gio.TlsDatabase self, Gio.TlsCertificate chain, string purpose, Gio.SocketConnectable identity, Gio.TlsInteraction interaction, Gio.TlsDatabaseVerifyFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_tls_database_verify_chain_finish(Gio.TlsDatabase self, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteractionResult g_tls_interaction_ask_password(Gio.TlsInteraction interaction, Gio.TlsPassword password, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_interaction_ask_password_async(Gio.TlsInteraction interaction, Gio.TlsPassword password, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteractionResult g_tls_interaction_ask_password_finish(Gio.TlsInteraction interaction, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteractionResult g_tls_interaction_invoke_ask_password(Gio.TlsInteraction interaction, Gio.TlsPassword password, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteractionResult g_tls_interaction_invoke_request_certificate(Gio.TlsInteraction interaction, Gio.TlsConnection connection, Gio.TlsCertificateRequestFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteractionResult g_tls_interaction_request_certificate(Gio.TlsInteraction interaction, Gio.TlsConnection connection, Gio.TlsCertificateRequestFlags flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_interaction_request_certificate_async(Gio.TlsInteraction interaction, Gio.TlsConnection connection, Gio.TlsCertificateRequestFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteractionResult g_tls_interaction_request_certificate_finish(Gio.TlsInteraction interaction, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.DtlsServerConnection g_dtls_server_connection_new(Gio.DatagramBased base_socket, Gio.TlsCertificate certificate, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Emblem g_emblem_new(Gio.Icon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Emblem g_emblem_new_with_origin(Gio.Icon icon, Gio.EmblemOrigin origin);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_emblem_get_icon(Gio.Emblem emblem);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.EmblemOrigin g_emblem_get_origin(Gio.Emblem emblem);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.EmblemedIcon g_emblemed_icon_new(Gio.Icon icon, Gio.Emblem emblem);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_emblemed_icon_add_emblem(Gio.EmblemedIcon emblemed, Gio.Emblem emblem);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_emblemed_icon_clear_emblems(Gio.EmblemedIcon emblemed);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_emblemed_icon_get_emblems(Gio.EmblemedIcon emblemed);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_emblemed_icon_get_icon(Gio.EmblemedIcon emblemed);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_io_stream_get_etag(Gio.FileIOStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_io_stream_query_info(Gio.FileIOStream stream, string attributes, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_io_stream_query_info_async(Gio.FileIOStream stream, string attributes, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_io_stream_query_info_finish(Gio.FileIOStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_output_stream_get_etag(Gio.FileOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_output_stream_query_info(Gio.FileOutputStream stream, string attributes, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_output_stream_query_info_async(Gio.FileOutputStream stream, string attributes, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_output_stream_query_info_finish(Gio.FileOutputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_enumerator_close(Gio.FileEnumerator enumerator, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_enumerator_close_async(Gio.FileEnumerator enumerator, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_enumerator_close_finish(Gio.FileEnumerator enumerator, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_enumerator_get_child(Gio.FileEnumerator enumerator, Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_enumerator_get_container(Gio.FileEnumerator enumerator);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_enumerator_has_pending(Gio.FileEnumerator enumerator);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_enumerator_is_closed(Gio.FileEnumerator enumerator);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_enumerator_iterate(Gio.FileEnumerator direnum, out Gio.FileInfo out_info, out Gio.File out_child, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_enumerator_next_file(Gio.FileEnumerator enumerator, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_enumerator_next_files_async(Gio.FileEnumerator enumerator, int num_files, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_file_enumerator_next_files_finish(Gio.FileEnumerator enumerator, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_enumerator_set_pending(Gio.FileEnumerator enumerator, int pending);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_can_eject(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_can_unmount(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_eject(Gio.Mount mount, Gio.MountUnmountFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_eject_finish(Gio.Mount mount, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_eject_with_operation(Gio.Mount mount, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_eject_with_operation_finish(Gio.Mount mount, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_mount_get_default_location(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Drive g_mount_get_drive(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_mount_get_icon(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_mount_get_name(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_mount_get_root(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_mount_get_sort_key(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_mount_get_symbolic_icon(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_mount_get_uuid(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Volume g_mount_get_volume(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_guess_content_type(Gio.Mount mount, int force_rescan, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_mount_guess_content_type_finish(Gio.Mount mount, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_mount_guess_content_type_sync(Gio.Mount mount, int force_rescan, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_is_shadowed(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_remount(Gio.Mount mount, Gio.MountMountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_remount_finish(Gio.Mount mount, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_shadow(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_unmount(Gio.Mount mount, Gio.MountUnmountFlags flags, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_unmount_finish(Gio.Mount mount, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_unmount_with_operation(Gio.Mount mount, Gio.MountUnmountFlags flags, Gio.MountOperation mount_operation, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_mount_unmount_with_operation_finish(Gio.Mount mount, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_mount_unshadow(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_monitor_cancel(Gio.FileMonitor monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_monitor_emit_event(Gio.FileMonitor monitor, Gio.File child, Gio.File other_file, Gio.FileMonitorEvent event_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_monitor_is_cancelled(Gio.FileMonitor monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_monitor_set_rate_limit(Gio.FileMonitor monitor, int limit_msecs);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_info_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_clear_status(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_copy_into(Gio.FileInfo src_info, Gio.FileInfo dest_info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_info_dup(Gio.FileInfo other);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_attribute_as_string(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_get_attribute_boolean(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_attribute_byte_string(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_get_attribute_data(Gio.FileInfo info, string attribute, out Gio.FileAttributeType type, System.IntPtr value_pp, out Gio.FileAttributeStatus status);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_get_attribute_int32(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_file_info_get_attribute_int64(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.Object g_file_info_get_attribute_object(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeStatus g_file_info_get_attribute_status(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_attribute_string(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_file_info_get_attribute_stringv(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeType g_file_info_get_attribute_type(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_file_info_get_attribute_uint32(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_file_info_get_attribute_uint64(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_content_type(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.DateTime g_file_info_get_deletion_date(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_display_name(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_edit_name(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_etag(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileType g_file_info_get_file_type(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_file_info_get_icon(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_get_is_backup(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_get_is_hidden(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_get_is_symlink(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_file_info_get_name(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_file_info_get_size(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_get_sort_order(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_file_info_get_symbolic_icon(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_info_get_symlink_target(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_has_attribute(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_has_namespace(Gio.FileInfo info, string name_space);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_file_info_list_attributes(Gio.FileInfo info, string name_space);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_remove_attribute(Gio.FileInfo info, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute(Gio.FileInfo info, string attribute, Gio.FileAttributeType type, System.IntPtr value_p);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_boolean(Gio.FileInfo info, string attribute, int attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_byte_string(Gio.FileInfo info, string attribute, string attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_int32(Gio.FileInfo info, string attribute, int attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_int64(Gio.FileInfo info, string attribute, long attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_mask(Gio.FileInfo info, Gio.FileAttributeMatcher mask);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_object(Gio.FileInfo info, string attribute, GObject.Object attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_info_set_attribute_status(Gio.FileInfo info, string attribute, Gio.FileAttributeStatus status);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_string(Gio.FileInfo info, string attribute, string attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_stringv(Gio.FileInfo info, string attribute, System.IntPtr attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_uint32(Gio.FileInfo info, string attribute, uint attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_attribute_uint64(Gio.FileInfo info, string attribute, ulong attr_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_content_type(Gio.FileInfo info, string content_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_display_name(Gio.FileInfo info, string display_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_edit_name(Gio.FileInfo info, string edit_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_file_type(Gio.FileInfo info, Gio.FileType type);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_icon(Gio.FileInfo info, Gio.Icon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_is_hidden(Gio.FileInfo info, int is_hidden);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_is_symlink(Gio.FileInfo info, int is_symlink);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_modification_time(Gio.FileInfo info, GLib.TimeVal mtime);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_name(Gio.FileInfo info, System.IntPtr name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_size(Gio.FileInfo info, long size);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_sort_order(Gio.FileInfo info, int sort_order);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_symbolic_icon(Gio.FileInfo info, Gio.Icon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_set_symlink_target(Gio.FileInfo info, string symlink_target);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_info_unset_attribute_mask(Gio.FileInfo info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeInfoList g_file_attribute_info_list_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_attribute_info_list_add(Gio.FileAttributeInfoList list, string name, Gio.FileAttributeType type, Gio.FileAttributeInfoFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeInfoList g_file_attribute_info_list_dup(Gio.FileAttributeInfoList list);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeInfo g_file_attribute_info_list_lookup(Gio.FileAttributeInfoList list, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeInfoList g_file_attribute_info_list_ref(Gio.FileAttributeInfoList list);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_attribute_info_list_unref(Gio.FileAttributeInfoList list);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_input_stream_query_info(Gio.FileInputStream stream, string attributes, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_input_stream_query_info_async(Gio.FileInputStream stream, string attributes, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_file_input_stream_query_info_finish(Gio.FileInputStream stream, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeMatcher g_file_attribute_matcher_new(string attributes);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_attribute_matcher_enumerate_namespace(Gio.FileAttributeMatcher matcher, string ns);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_attribute_matcher_enumerate_next(Gio.FileAttributeMatcher matcher);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_attribute_matcher_matches(Gio.FileAttributeMatcher matcher, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_attribute_matcher_matches_only(Gio.FileAttributeMatcher matcher, string attribute);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeMatcher g_file_attribute_matcher_ref(Gio.FileAttributeMatcher matcher);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileAttributeMatcher g_file_attribute_matcher_subtract(Gio.FileAttributeMatcher matcher, Gio.FileAttributeMatcher subtract);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_file_attribute_matcher_to_string(Gio.FileAttributeMatcher matcher);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_file_attribute_matcher_unref(Gio.FileAttributeMatcher matcher);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_file_descriptor_based_get_fd(Gio.FileDescriptorBased fd_based);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileIcon g_file_icon_new(Gio.File file);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_file_icon_get_file(Gio.FileIcon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FilenameCompleter g_filename_completer_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_filename_completer_get_completion_suffix(Gio.FilenameCompleter completer, string initial_text);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_filename_completer_get_completions(Gio.FilenameCompleter completer, string initial_text);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_filename_completer_set_dirs_only(Gio.FilenameCompleter completer, int dirs_only);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_io_extension_get_name(Gio.IOExtension extension);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_extension_get_priority(Gio.IOExtension extension);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_io_extension_get_type(Gio.IOExtension extension);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.TypeClass g_io_extension_ref_class(Gio.IOExtension extension);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOExtension g_io_extension_point_get_extension_by_name(Gio.IOExtensionPoint extension_point, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_io_extension_point_get_extensions(Gio.IOExtensionPoint extension_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_io_extension_point_get_required_type(Gio.IOExtensionPoint extension_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_extension_point_set_required_type(Gio.IOExtensionPoint extension_point, ulong type);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOExtension g_io_extension_point_implement(string extension_point_name, ulong type, string extension_name, int priority);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOExtensionPoint g_io_extension_point_lookup(string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOExtensionPoint g_io_extension_point_register(string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOModule g_io_module_new(System.IntPtr filename);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_io_module_query();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_module_load(Gio.IOModule module);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_module_unload(Gio.IOModule module);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_module_scope_block(Gio.IOModuleScope scope, string basename);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_module_scope_free(Gio.IOModuleScope scope);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOModuleScope g_io_module_scope_new(Gio.IOModuleScopeFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_io_scheduler_job_send_to_mainloop(Gio.IOSchedulerJob job, System.IntPtr func, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_io_scheduler_job_send_to_mainloop_async(Gio.IOSchedulerJob job, System.IntPtr func, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddress g_inet_address_new_any(Gio.SocketFamily family);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddress g_inet_address_new_from_bytes(System.IntPtr bytes, Gio.SocketFamily family);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddress g_inet_address_new_from_string(string @string);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddress g_inet_address_new_loopback(Gio.SocketFamily family);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_equal(Gio.InetAddress address, Gio.InetAddress other_address);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketFamily g_inet_address_get_family(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_any(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_link_local(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_loopback(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_mc_global(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_mc_link_local(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_mc_node_local(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_mc_org_local(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_mc_site_local(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_multicast(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_get_is_site_local(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_inet_address_get_native_size(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_inet_address_to_bytes(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_inet_address_to_string(Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddressMask g_inet_address_mask_new(Gio.InetAddress addr, uint length, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddressMask g_inet_address_mask_new_from_string(string mask_string, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_mask_equal(Gio.InetAddressMask mask, Gio.InetAddressMask mask2);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddress g_inet_address_mask_get_address(Gio.InetAddressMask mask);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketFamily g_inet_address_mask_get_family(Gio.InetAddressMask mask);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_inet_address_mask_get_length(Gio.InetAddressMask mask);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_inet_address_mask_matches(Gio.InetAddressMask mask, Gio.InetAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_inet_address_mask_to_string(Gio.InetAddressMask mask);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_address_new_from_native(System.IntPtr native, ulong len);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketFamily g_socket_address_get_family(Gio.SocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_address_get_native_size(Gio.SocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_address_to_native(Gio.SocketAddress address, System.IntPtr dest, ulong destlen, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_inet_socket_address_new(Gio.InetAddress address, ushort port);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_inet_socket_address_new_from_string(string address, uint port);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InetAddress g_inet_socket_address_get_address(Gio.InetSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_inet_socket_address_get_flowinfo(Gio.InetSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_inet_socket_address_get_port(Gio.InetSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_inet_socket_address_get_scope_id(Gio.InetSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketControlMessage g_socket_control_message_deserialize(int level, int type, ulong size, System.IntPtr data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_control_message_get_level(Gio.SocketControlMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_control_message_get_msg_type(Gio.SocketControlMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_socket_control_message_get_size(Gio.SocketControlMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_control_message_serialize(Gio.SocketControlMessage message, System.IntPtr data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.Object g_list_model_get_item(Gio.ListModel list, uint position);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_list_model_get_item_type(Gio.ListModel list);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_list_model_get_n_items(Gio.ListModel list);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.Object g_list_model_get_object(Gio.ListModel list, uint position);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_list_model_items_changed(Gio.ListModel list, uint position, uint removed, uint added);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ListStore g_list_store_new(ulong item_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_list_store_append(Gio.ListStore store, GObject.Object item);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_list_store_insert(Gio.ListStore store, uint position, GObject.Object item);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_list_store_insert_sorted(Gio.ListStore store, GObject.Object item, System.IntPtr compare_func, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_list_store_remove(Gio.ListStore store, uint position);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_list_store_remove_all(Gio.ListStore store);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_list_store_sort(Gio.ListStore store, System.IntPtr compare_func, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_list_store_splice(Gio.ListStore store, uint position, uint n_removals, System.IntPtr additions, uint n_additions);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_memory_input_stream_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_memory_input_stream_new_from_bytes(GLib.Bytes bytes);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_memory_input_stream_new_from_data(System.IntPtr data, long len, System.IntPtr destroy);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_memory_input_stream_add_bytes(Gio.MemoryInputStream stream, GLib.Bytes bytes);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_memory_input_stream_add_data(Gio.MemoryInputStream stream, System.IntPtr data, long len, System.IntPtr destroy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_memory_output_stream_new(System.IntPtr data, ulong size, System.IntPtr realloc_function, System.IntPtr destroy_function);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_memory_output_stream_new_resizable();
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_memory_output_stream_get_data(Gio.MemoryOutputStream ostream);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_memory_output_stream_get_data_size(Gio.MemoryOutputStream ostream);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_memory_output_stream_get_size(Gio.MemoryOutputStream ostream);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Bytes g_memory_output_stream_steal_as_bytes(Gio.MemoryOutputStream ostream);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_memory_output_stream_steal_data(Gio.MemoryOutputStream ostream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Menu g_menu_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_append(Gio.Menu menu, string label, string detailed_action);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_append_item(Gio.Menu menu, Gio.MenuItem item);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_append_section(Gio.Menu menu, string label, Gio.MenuModel section);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_append_submenu(Gio.Menu menu, string label, Gio.MenuModel submenu);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_freeze(Gio.Menu menu);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_insert(Gio.Menu menu, int position, string label, string detailed_action);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_insert_item(Gio.Menu menu, int position, Gio.MenuItem item);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_insert_section(Gio.Menu menu, int position, string label, Gio.MenuModel section);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_insert_submenu(Gio.Menu menu, int position, string label, Gio.MenuModel submenu);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_prepend(Gio.Menu menu, string label, string detailed_action);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_prepend_item(Gio.Menu menu, Gio.MenuItem item);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_prepend_section(Gio.Menu menu, string label, Gio.MenuModel section);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_prepend_submenu(Gio.Menu menu, string label, Gio.MenuModel submenu);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_remove(Gio.Menu menu, int position);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_remove_all(Gio.Menu menu);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuItem g_menu_item_new(string label, string detailed_action);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuItem g_menu_item_new_from_model(Gio.MenuModel model, int item_index);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuItem g_menu_item_new_section(string label, Gio.MenuModel section);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuItem g_menu_item_new_submenu(string label, Gio.MenuModel submenu);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_menu_item_get_attribute_value(Gio.MenuItem menu_item, string attribute, GLib.VariantType expected_type);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuModel g_menu_item_get_link(Gio.MenuItem menu_item, string link);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_action_and_target_value(Gio.MenuItem menu_item, string action, GLib.Variant target_value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_attribute_value(Gio.MenuItem menu_item, string attribute, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_detailed_action(Gio.MenuItem menu_item, string detailed_action);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_icon(Gio.MenuItem menu_item, Gio.Icon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_label(Gio.MenuItem menu_item, string label);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_link(Gio.MenuItem menu_item, string link, Gio.MenuModel model);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_section(Gio.MenuItem menu_item, Gio.MenuModel section);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_menu_item_set_submenu(Gio.MenuItem menu_item, Gio.MenuModel submenu);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_menu_attribute_iter_get_name(Gio.MenuAttributeIter iter);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_menu_attribute_iter_get_next(Gio.MenuAttributeIter iter, string out_name, out GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_menu_attribute_iter_get_value(Gio.MenuAttributeIter iter);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_menu_attribute_iter_next(Gio.MenuAttributeIter iter);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_menu_link_iter_get_name(Gio.MenuLinkIter iter);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_menu_link_iter_get_next(Gio.MenuLinkIter iter, string out_link, out Gio.MenuModel value);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.MenuModel g_menu_link_iter_get_value(Gio.MenuLinkIter iter);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_menu_link_iter_next(Gio.MenuLinkIter iter);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Volume g_volume_monitor_adopt_orphan_mount(Gio.Mount mount);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.VolumeMonitor g_volume_monitor_get();
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_volume_monitor_get_connected_drives(Gio.VolumeMonitor volume_monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Mount g_volume_monitor_get_mount_for_uuid(Gio.VolumeMonitor volume_monitor, string uuid);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_volume_monitor_get_mounts(Gio.VolumeMonitor volume_monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Volume g_volume_monitor_get_volume_for_uuid(Gio.VolumeMonitor volume_monitor, string uuid);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_volume_monitor_get_volumes(Gio.VolumeMonitor volume_monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.NetworkAddress g_network_address_new(string hostname, ushort port);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.NetworkAddress g_network_address_new_loopback(ushort port);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.NetworkAddress g_network_address_parse(string host_and_port, ushort default_port, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.NetworkAddress g_network_address_parse_uri(string uri, ushort default_port, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_network_address_get_hostname(Gio.NetworkAddress addr);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_network_address_get_port(Gio.NetworkAddress addr);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_network_address_get_scheme(Gio.NetworkAddress addr);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.NetworkMonitor g_network_monitor_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_network_monitor_can_reach(Gio.NetworkMonitor monitor, Gio.SocketConnectable connectable, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_network_monitor_can_reach_async(Gio.NetworkMonitor monitor, Gio.SocketConnectable connectable, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_network_monitor_can_reach_finish(Gio.NetworkMonitor monitor, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.NetworkConnectivity g_network_monitor_get_connectivity(Gio.NetworkMonitor monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_network_monitor_get_network_available(Gio.NetworkMonitor monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_network_monitor_get_network_metered(Gio.NetworkMonitor monitor);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.NetworkService g_network_service_new(string service, string protocol, string domain);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_network_service_get_domain(Gio.NetworkService srv);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_network_service_get_protocol(Gio.NetworkService srv);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_network_service_get_scheme(Gio.NetworkService srv);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_network_service_get_service(Gio.NetworkService srv);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_network_service_set_scheme(Gio.NetworkService srv, string scheme);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_permission_acquire(Gio.Permission permission, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_permission_acquire_async(Gio.Permission permission, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_permission_acquire_finish(Gio.Permission permission, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_permission_get_allowed(Gio.Permission permission);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_permission_get_can_acquire(Gio.Permission permission);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_permission_get_can_release(Gio.Permission permission);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_permission_impl_update(Gio.Permission permission, int allowed, int can_acquire, int can_release);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_permission_release(Gio.Permission permission, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_permission_release_async(Gio.Permission permission, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_permission_release_finish(Gio.Permission permission, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.PropertyAction g_property_action_new(string name, GObject.Object @object, string property_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Proxy g_proxy_get_default_for_protocol(string protocol);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOStream g_proxy_connect(Gio.Proxy proxy, Gio.IOStream connection, Gio.ProxyAddress proxy_address, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_proxy_connect_async(Gio.Proxy proxy, Gio.IOStream connection, Gio.ProxyAddress proxy_address, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOStream g_proxy_connect_finish(Gio.Proxy proxy, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_proxy_supports_hostname(Gio.Proxy proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_proxy_address_new(Gio.InetAddress inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_proxy_address_get_destination_hostname(Gio.ProxyAddress proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_proxy_address_get_destination_port(Gio.ProxyAddress proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_proxy_address_get_destination_protocol(Gio.ProxyAddress proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_proxy_address_get_password(Gio.ProxyAddress proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_proxy_address_get_protocol(Gio.ProxyAddress proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_proxy_address_get_uri(Gio.ProxyAddress proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_proxy_address_get_username(Gio.ProxyAddress proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ProxyResolver g_proxy_resolver_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_proxy_resolver_is_supported(Gio.ProxyResolver resolver);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_proxy_resolver_lookup(Gio.ProxyResolver resolver, string uri, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_proxy_resolver_lookup_async(Gio.ProxyResolver resolver, string uri, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_proxy_resolver_lookup_finish(Gio.ProxyResolver resolver, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_address_enumerator_next(Gio.SocketAddressEnumerator enumerator, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_address_enumerator_next_async(Gio.SocketAddressEnumerator enumerator, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_address_enumerator_next_finish(Gio.SocketAddressEnumerator enumerator, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resolver_free_addresses(System.IntPtr addresses);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resolver_free_targets(System.IntPtr targets);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Resolver g_resolver_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_resolver_lookup_by_address(Gio.Resolver resolver, Gio.InetAddress address, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resolver_lookup_by_address_async(Gio.Resolver resolver, Gio.InetAddress address, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_resolver_lookup_by_address_finish(Gio.Resolver resolver, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resolver_lookup_by_name(Gio.Resolver resolver, string hostname, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resolver_lookup_by_name_async(Gio.Resolver resolver, string hostname, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resolver_lookup_by_name_finish(Gio.Resolver resolver, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resolver_lookup_records(Gio.Resolver resolver, string rrname, Gio.ResolverRecordType record_type, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resolver_lookup_records_async(Gio.Resolver resolver, string rrname, Gio.ResolverRecordType record_type, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resolver_lookup_records_finish(Gio.Resolver resolver, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resolver_lookup_service(Gio.Resolver resolver, string service, string protocol, string domain, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resolver_lookup_service_async(Gio.Resolver resolver, string service, string protocol, string domain, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resolver_lookup_service_finish(Gio.Resolver resolver, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resolver_set_default(Gio.Resolver resolver);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SrvTarget g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SrvTarget g_srv_target_copy(Gio.SrvTarget target);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_srv_target_free(Gio.SrvTarget target);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_srv_target_get_hostname(Gio.SrvTarget target);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_srv_target_get_port(Gio.SrvTarget target);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_srv_target_get_priority(Gio.SrvTarget target);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_srv_target_get_weight(Gio.SrvTarget target);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_srv_target_list_sort(System.IntPtr targets);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_resolver_error_quark();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Resource g_resource_new_from_data(GLib.Bytes data, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_resource_enumerate_children(Gio.Resource resource, string path, Gio.ResourceLookupFlags lookup_flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_resource_get_info(Gio.Resource resource, string path, Gio.ResourceLookupFlags lookup_flags, System.IntPtr size, System.IntPtr flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Bytes g_resource_lookup_data(Gio.Resource resource, string path, Gio.ResourceLookupFlags lookup_flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_resource_open_stream(Gio.Resource resource, string path, Gio.ResourceLookupFlags lookup_flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Resource g_resource_ref(Gio.Resource resource);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_resource_unref(Gio.Resource resource);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Resource g_resource_load(System.IntPtr filename, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_resource_error_quark();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Settings g_settings_new(string schema_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Settings g_settings_new_full(Gio.SettingsSchema schema, Gio.SettingsBackend backend, string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Settings g_settings_new_with_backend(string schema_id, Gio.SettingsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Settings g_settings_new_with_backend_and_path(string schema_id, Gio.SettingsBackend backend, string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Settings g_settings_new_with_path(string schema_id, string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_list_relocatable_schemas();
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_list_schemas();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_sync();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_unbind(GObject.Object @object, string property);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_apply(Gio.Settings settings);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_bind(Gio.Settings settings, string key, GObject.Object @object, string property, Gio.SettingsBindFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_bind_with_mapping(Gio.Settings settings, string key, GObject.Object @object, string property, Gio.SettingsBindFlags flags, System.IntPtr get_mapping, System.IntPtr set_mapping, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_bind_writable(Gio.Settings settings, string key, GObject.Object @object, string property, int inverted);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Action g_settings_create_action(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_delay(Gio.Settings settings);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_get_boolean(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Settings g_settings_get_child(Gio.Settings settings, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_settings_get_default_value(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern double g_settings_get_double(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_get_enum(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_settings_get_flags(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_get_has_unapplied(Gio.Settings settings);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_get_int(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_settings_get_int64(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_get_mapped(Gio.Settings settings, string key, System.IntPtr mapping, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_settings_get_range(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_settings_get_string(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_get_strv(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_settings_get_uint(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_settings_get_uint64(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_settings_get_user_value(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_settings_get_value(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_is_writable(Gio.Settings settings, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_list_children(Gio.Settings settings);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_list_keys(Gio.Settings settings);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_range_check(Gio.Settings settings, string key, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_reset(Gio.Settings settings, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_revert(Gio.Settings settings);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_boolean(Gio.Settings settings, string key, int value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_double(Gio.Settings settings, string key, double value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_enum(Gio.Settings settings, string key, int value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_flags(Gio.Settings settings, string key, uint value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_int(Gio.Settings settings, string key, int value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_int64(Gio.Settings settings, string key, long value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_string(Gio.Settings settings, string key, string value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_strv(Gio.Settings settings, string key, System.IntPtr value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_uint(Gio.Settings settings, string key, uint value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_uint64(Gio.Settings settings, string key, ulong value);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_set_value(Gio.Settings settings, string key, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_settings_schema_get_id(Gio.SettingsSchema schema);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsSchemaKey g_settings_schema_get_key(Gio.SettingsSchema schema, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_settings_schema_get_path(Gio.SettingsSchema schema);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_schema_has_key(Gio.SettingsSchema schema, string name);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_schema_list_children(Gio.SettingsSchema schema);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_settings_schema_list_keys(Gio.SettingsSchema schema);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsSchema g_settings_schema_ref(Gio.SettingsSchema schema);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_schema_unref(Gio.SettingsSchema schema);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_backend_flatten_tree(GLib.Tree tree, string path, System.IntPtr keys, System.IntPtr values);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsBackend g_settings_backend_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_backend_changed(Gio.SettingsBackend backend, string key, System.IntPtr origin_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_backend_changed_tree(Gio.SettingsBackend backend, GLib.Tree tree, System.IntPtr origin_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_backend_keys_changed(Gio.SettingsBackend backend, string path, System.IntPtr items, System.IntPtr origin_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_backend_path_changed(Gio.SettingsBackend backend, string path, System.IntPtr origin_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_backend_path_writable_changed(Gio.SettingsBackend backend, string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_backend_writable_changed(Gio.SettingsBackend backend, string key);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_settings_schema_key_get_default_value(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_settings_schema_key_get_description(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_settings_schema_key_get_name(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Variant g_settings_schema_key_get_range(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_settings_schema_key_get_summary(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.VariantType g_settings_schema_key_get_value_type(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_settings_schema_key_range_check(Gio.SettingsSchemaKey key, GLib.Variant value);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsSchemaKey g_settings_schema_key_ref(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_schema_key_unref(Gio.SettingsSchemaKey key);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsSchemaSource g_settings_schema_source_new_from_directory(System.IntPtr directory, Gio.SettingsSchemaSource parent, int trusted, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_schema_source_list_schemas(Gio.SettingsSchemaSource source, int recursive, System.IntPtr non_relocatable, System.IntPtr relocatable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsSchema g_settings_schema_source_lookup(Gio.SettingsSchemaSource source, string schema_id, int recursive);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsSchemaSource g_settings_schema_source_ref(Gio.SettingsSchemaSource source);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_settings_schema_source_unref(Gio.SettingsSchemaSource source);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SettingsSchemaSource g_settings_schema_source_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SimpleActionGroup g_simple_action_group_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_action_group_add_entries(Gio.SimpleActionGroup simple, System.IntPtr entries, int n_entries, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_action_group_insert(Gio.SimpleActionGroup simple, Gio.Action action);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Action g_simple_action_group_lookup(Gio.SimpleActionGroup simple, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_action_group_remove(Gio.SimpleActionGroup simple, string action_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SimpleAsyncResult g_simple_async_result_new(GObject.Object source_object, System.IntPtr callback, System.IntPtr user_data, System.IntPtr source_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SimpleAsyncResult g_simple_async_result_new_from_error(GObject.Object source_object, System.IntPtr callback, System.IntPtr user_data, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SimpleAsyncResult g_simple_async_result_new_take_error(GObject.Object source_object, System.IntPtr callback, System.IntPtr user_data, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_simple_async_result_is_valid(Gio.AsyncResult result, GObject.Object source, System.IntPtr source_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_complete(Gio.SimpleAsyncResult simple);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_complete_in_idle(Gio.SimpleAsyncResult simple);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_simple_async_result_get_op_res_gboolean(Gio.SimpleAsyncResult simple);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_simple_async_result_get_op_res_gpointer(Gio.SimpleAsyncResult simple);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_simple_async_result_get_op_res_gssize(Gio.SimpleAsyncResult simple);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_simple_async_result_get_source_tag(Gio.SimpleAsyncResult simple);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_simple_async_result_propagate_error(Gio.SimpleAsyncResult simple, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_run_in_thread(Gio.SimpleAsyncResult simple, System.IntPtr func, int io_priority, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_set_check_cancellable(Gio.SimpleAsyncResult simple, Gio.Cancellable check_cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_set_from_error(Gio.SimpleAsyncResult simple, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_set_handle_cancellation(Gio.SimpleAsyncResult simple, int handle_cancellation);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_set_op_res_gboolean(Gio.SimpleAsyncResult simple, int op_res);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_set_op_res_gpointer(Gio.SimpleAsyncResult simple, System.IntPtr op_res, System.IntPtr destroy_op_res);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_set_op_res_gssize(Gio.SimpleAsyncResult simple, long op_res);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_async_result_take_error(Gio.SimpleAsyncResult simple, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOStream g_simple_io_stream_new(Gio.InputStream input_stream, Gio.OutputStream output_stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Permission g_simple_permission_new(int allowed);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ProxyResolver g_simple_proxy_resolver_new(string default_proxy, string ignore_hosts);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_proxy_resolver_set_default_proxy(Gio.SimpleProxyResolver resolver, string default_proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_proxy_resolver_set_ignore_hosts(Gio.SimpleProxyResolver resolver, string ignore_hosts);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_simple_proxy_resolver_set_uri_proxy(Gio.SimpleProxyResolver resolver, string uri_scheme, string proxy);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Socket g_socket_new(Gio.SocketFamily family, Gio.SocketType type, Gio.SocketProtocol protocol, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Socket g_socket_new_from_fd(int fd, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Socket g_socket_accept(Gio.Socket socket, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_bind(Gio.Socket socket, Gio.SocketAddress address, int allow_reuse, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_check_connect_result(Gio.Socket socket, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_close(Gio.Socket socket, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.IOCondition g_socket_condition_check(Gio.Socket socket, GLib.IOCondition condition);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_condition_timed_wait(Gio.Socket socket, GLib.IOCondition condition, long timeout, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_condition_wait(Gio.Socket socket, GLib.IOCondition condition, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_connect(Gio.Socket socket, Gio.SocketAddress address, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_connection_factory_create_connection(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.Source g_socket_create_source(Gio.Socket socket, GLib.IOCondition condition, Gio.Cancellable cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_get_available_bytes(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_get_blocking(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_get_broadcast(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Credentials g_socket_get_credentials(Gio.Socket socket, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketFamily g_socket_get_family(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_get_fd(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_get_keepalive(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_get_listen_backlog(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_get_local_address(Gio.Socket socket, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_get_multicast_loopback(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_socket_get_multicast_ttl(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_get_option(Gio.Socket socket, int level, int optname, System.IntPtr value, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketProtocol g_socket_get_protocol(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_get_remote_address(Gio.Socket socket, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketType g_socket_get_socket_type(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_socket_get_timeout(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_socket_get_ttl(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_is_closed(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_is_connected(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_join_multicast_group(Gio.Socket socket, Gio.InetAddress group, int source_specific, string iface, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_leave_multicast_group(Gio.Socket socket, Gio.InetAddress group, int source_specific, string iface, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_listen(Gio.Socket socket, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_receive(Gio.Socket socket, System.IntPtr buffer, ulong size, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_receive_from(Gio.Socket socket, out Gio.SocketAddress address, System.IntPtr buffer, ulong size, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_receive_message(Gio.Socket socket, out Gio.SocketAddress address, System.IntPtr vectors, int num_vectors, System.IntPtr messages, System.IntPtr num_messages, System.IntPtr flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_receive_messages(Gio.Socket socket, System.IntPtr messages, uint num_messages, int flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_receive_with_blocking(Gio.Socket socket, System.IntPtr buffer, ulong size, int blocking, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_send(Gio.Socket socket, System.IntPtr buffer, ulong size, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_send_message(Gio.Socket socket, Gio.SocketAddress address, System.IntPtr vectors, int num_vectors, System.IntPtr messages, int num_messages, int flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_send_messages(Gio.Socket socket, System.IntPtr messages, uint num_messages, int flags, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_send_to(Gio.Socket socket, Gio.SocketAddress address, System.IntPtr buffer, ulong size, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_socket_send_with_blocking(Gio.Socket socket, System.IntPtr buffer, ulong size, int blocking, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_blocking(Gio.Socket socket, int blocking);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_broadcast(Gio.Socket socket, int broadcast);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_keepalive(Gio.Socket socket, int keepalive);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_listen_backlog(Gio.Socket socket, int backlog);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_multicast_loopback(Gio.Socket socket, int loopback);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_multicast_ttl(Gio.Socket socket, uint ttl);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_set_option(Gio.Socket socket, int level, int optname, int value, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_timeout(Gio.Socket socket, uint timeout);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_set_ttl(Gio.Socket socket, uint ttl);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_shutdown(Gio.Socket socket, int shutdown_read, int shutdown_write, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_speaks_ipv4(Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_socket_connection_factory_lookup_type(Gio.SocketFamily family, Gio.SocketType type, int protocol_id);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_connection_factory_register_type(ulong g_type, Gio.SocketFamily family, Gio.SocketType type, int protocol);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_connection_connect(Gio.SocketConnection connection, Gio.SocketAddress address, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_connection_connect_async(Gio.SocketConnection connection, Gio.SocketAddress address, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_connection_connect_finish(Gio.SocketConnection connection, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_connection_get_local_address(Gio.SocketConnection connection, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_connection_get_remote_address(Gio.SocketConnection connection, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Socket g_socket_connection_get_socket(Gio.SocketConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_connection_is_connected(Gio.SocketConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketClient g_socket_client_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_add_application_proxy(Gio.SocketClient client, string protocol);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect(Gio.SocketClient client, Gio.SocketConnectable connectable, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_connect_async(Gio.SocketClient client, Gio.SocketConnectable connectable, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect_finish(Gio.SocketClient client, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect_to_host(Gio.SocketClient client, string host_and_port, ushort default_port, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_connect_to_host_async(Gio.SocketClient client, string host_and_port, ushort default_port, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect_to_host_finish(Gio.SocketClient client, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect_to_service(Gio.SocketClient client, string domain, string service, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_connect_to_service_async(Gio.SocketClient client, string domain, string service, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect_to_service_finish(Gio.SocketClient client, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect_to_uri(Gio.SocketClient client, string uri, ushort default_port, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_connect_to_uri_async(Gio.SocketClient client, string uri, ushort default_port, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_client_connect_to_uri_finish(Gio.SocketClient client, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_client_get_enable_proxy(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketFamily g_socket_client_get_family(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_socket_client_get_local_address(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketProtocol g_socket_client_get_protocol(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ProxyResolver g_socket_client_get_proxy_resolver(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketType g_socket_client_get_socket_type(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_socket_client_get_timeout(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_client_get_tls(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_socket_client_get_tls_validation_flags(Gio.SocketClient client);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_enable_proxy(Gio.SocketClient client, int enable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_family(Gio.SocketClient client, Gio.SocketFamily family);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_local_address(Gio.SocketClient client, Gio.SocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_protocol(Gio.SocketClient client, Gio.SocketProtocol protocol);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_proxy_resolver(Gio.SocketClient client, Gio.ProxyResolver proxy_resolver);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_socket_type(Gio.SocketClient client, Gio.SocketType type);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_timeout(Gio.SocketClient client, uint timeout);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_tls(Gio.SocketClient client, int tls);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_client_set_tls_validation_flags(Gio.SocketClient client, Gio.TlsCertificateFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketListener g_socket_listener_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_listener_accept(Gio.SocketListener listener, out GObject.Object source_object, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_listener_accept_async(Gio.SocketListener listener, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_socket_listener_accept_finish(Gio.SocketListener listener, Gio.AsyncResult result, out GObject.Object source_object, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Socket g_socket_listener_accept_socket(Gio.SocketListener listener, out GObject.Object source_object, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_listener_accept_socket_async(Gio.SocketListener listener, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Socket g_socket_listener_accept_socket_finish(Gio.SocketListener listener, Gio.AsyncResult result, out GObject.Object source_object, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_listener_add_address(Gio.SocketListener listener, Gio.SocketAddress address, Gio.SocketType type, Gio.SocketProtocol protocol, GObject.Object source_object, out Gio.SocketAddress effective_address, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern ushort g_socket_listener_add_any_inet_port(Gio.SocketListener listener, GObject.Object source_object, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_listener_add_inet_port(Gio.SocketListener listener, ushort port, GObject.Object source_object, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_listener_add_socket(Gio.SocketListener listener, Gio.Socket socket, GObject.Object source_object, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_listener_close(Gio.SocketListener listener);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_listener_set_backlog(Gio.SocketListener listener, int listen_backlog);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketService g_socket_service_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_socket_service_is_active(Gio.SocketService service);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_service_start(Gio.SocketService service);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_socket_service_stop(Gio.SocketService service);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_static_resource_fini(Gio.StaticResource static_resource);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Resource g_static_resource_get_resource(Gio.StaticResource static_resource);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_static_resource_init(Gio.StaticResource static_resource);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Subprocess g_subprocess_newv(System.IntPtr argv, Gio.SubprocessFlags flags, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_communicate(Gio.Subprocess subprocess, GLib.Bytes stdin_buf, Gio.Cancellable cancellable, out GLib.Bytes stdout_buf, out GLib.Bytes stderr_buf, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_communicate_async(Gio.Subprocess subprocess, GLib.Bytes stdin_buf, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_communicate_finish(Gio.Subprocess subprocess, Gio.AsyncResult result, out GLib.Bytes stdout_buf, out GLib.Bytes stderr_buf, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_communicate_utf8(Gio.Subprocess subprocess, string stdin_buf, Gio.Cancellable cancellable, string stdout_buf, string stderr_buf, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_communicate_utf8_async(Gio.Subprocess subprocess, string stdin_buf, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_communicate_utf8_finish(Gio.Subprocess subprocess, Gio.AsyncResult result, string stdout_buf, string stderr_buf, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_force_exit(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_get_exit_status(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_subprocess_get_identifier(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_get_if_exited(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_get_if_signaled(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_get_status(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_subprocess_get_stderr_pipe(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_subprocess_get_stdin_pipe(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_subprocess_get_stdout_pipe(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_get_successful(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_get_term_sig(Gio.Subprocess subprocess);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_send_signal(Gio.Subprocess subprocess, int signal_num);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_wait(Gio.Subprocess subprocess, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_wait_async(Gio.Subprocess subprocess, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_wait_check(Gio.Subprocess subprocess, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_wait_check_async(Gio.Subprocess subprocess, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_wait_check_finish(Gio.Subprocess subprocess, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_subprocess_wait_finish(Gio.Subprocess subprocess, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SubprocessLauncher g_subprocess_launcher_new(Gio.SubprocessFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_subprocess_launcher_getenv(Gio.SubprocessLauncher self, string variable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_set_child_setup(Gio.SubprocessLauncher self, System.IntPtr child_setup, System.IntPtr user_data, System.IntPtr destroy_notify);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_set_cwd(Gio.SubprocessLauncher self, System.IntPtr cwd);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_set_environ(Gio.SubprocessLauncher self, System.IntPtr env);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_set_flags(Gio.SubprocessLauncher self, Gio.SubprocessFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_set_stderr_file_path(Gio.SubprocessLauncher self, System.IntPtr path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_set_stdin_file_path(Gio.SubprocessLauncher self, string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_set_stdout_file_path(Gio.SubprocessLauncher self, System.IntPtr path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_setenv(Gio.SubprocessLauncher self, string variable, string value, int overwrite);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Subprocess g_subprocess_launcher_spawnv(Gio.SubprocessLauncher self, System.IntPtr argv, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_take_fd(Gio.SubprocessLauncher self, int source_fd, int target_fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_take_stderr_fd(Gio.SubprocessLauncher self, int fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_take_stdin_fd(Gio.SubprocessLauncher self, int fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_take_stdout_fd(Gio.SubprocessLauncher self, int fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_subprocess_launcher_unsetenv(Gio.SubprocessLauncher self, string variable);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Task g_task_new(GObject.Object source_object, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr callback_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_is_valid(Gio.AsyncResult result, GObject.Object source_object);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_report_error(GObject.Object source_object, System.IntPtr callback, System.IntPtr callback_data, System.IntPtr source_tag, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_attach_source(Gio.Task task, GLib.Source source, System.IntPtr callback);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Cancellable g_task_get_cancellable(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_get_check_cancellable(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_get_completed(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern GLib.MainContext g_task_get_context(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_get_priority(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_get_return_on_cancel(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern GObject.Object g_task_get_source_object(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_task_get_source_tag(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_task_get_task_data(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_had_error(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_propagate_boolean(Gio.Task task, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern long g_task_propagate_int(Gio.Task task, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_task_propagate_pointer(Gio.Task task, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_return_boolean(Gio.Task task, int result);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_return_error(Gio.Task task, GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_return_error_if_cancelled(Gio.Task task);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_return_int(Gio.Task task, long result);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_return_pointer(Gio.Task task, System.IntPtr result, System.IntPtr result_destroy);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_run_in_thread(Gio.Task task, System.IntPtr task_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_run_in_thread_sync(Gio.Task task, System.IntPtr task_func);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_set_check_cancellable(Gio.Task task, int check_cancellable);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_set_priority(Gio.Task task, int priority);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_task_set_return_on_cancel(Gio.Task task, int return_on_cancel);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_set_source_tag(Gio.Task task, System.IntPtr source_tag);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_task_set_task_data(Gio.Task task, System.IntPtr task_data, System.IntPtr task_data_destroy);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tcp_connection_get_graceful_disconnect(Gio.TcpConnection connection);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tcp_connection_set_graceful_disconnect(Gio.TcpConnection connection, int graceful_disconnect);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnection g_tcp_wrapper_connection_new(Gio.IOStream base_io_stream, Gio.Socket socket);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.IOStream g_tcp_wrapper_connection_get_base_io_stream(Gio.TcpWrapperConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TestDBus g_test_dbus_new(Gio.TestDBusFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_test_dbus_unset();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_test_dbus_add_service_dir(Gio.TestDBus self, string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_test_dbus_down(Gio.TestDBus self);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_test_dbus_get_bus_address(Gio.TestDBus self);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TestDBusFlags g_test_dbus_get_flags(Gio.TestDBus self);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_test_dbus_stop(Gio.TestDBus self);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_test_dbus_up(Gio.TestDBus self);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ThemedIcon g_themed_icon_new(string iconname);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ThemedIcon g_themed_icon_new_from_names(System.IntPtr iconnames, int len);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ThemedIcon g_themed_icon_new_with_default_fallbacks(string iconname);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_themed_icon_append_name(Gio.ThemedIcon icon, string iconname);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_themed_icon_get_names(Gio.ThemedIcon icon);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_themed_icon_prepend_name(Gio.ThemedIcon icon, string iconname);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketService g_threaded_socket_service_new(int max_threads);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsBackend g_tls_backend_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_tls_backend_get_certificate_type(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_tls_backend_get_client_connection_type(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsDatabase g_tls_backend_get_default_database(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_tls_backend_get_dtls_client_connection_type(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_tls_backend_get_dtls_server_connection_type(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_tls_backend_get_file_database_type(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_tls_backend_get_server_connection_type(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_backend_supports_dtls(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_backend_supports_tls(Gio.TlsBackend backend);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_connection_emit_accept_certificate(Gio.TlsConnection conn, Gio.TlsCertificate peer_cert, Gio.TlsCertificateFlags errors);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_connection_get_certificate(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsDatabase g_tls_connection_get_database(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsInteraction g_tls_connection_get_interaction(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificate g_tls_connection_get_peer_certificate(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_tls_connection_get_peer_certificate_errors(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsRehandshakeMode g_tls_connection_get_rehandshake_mode(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_connection_get_require_close_notify(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_connection_get_use_system_certdb(Gio.TlsConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_connection_handshake(Gio.TlsConnection conn, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_connection_handshake_async(Gio.TlsConnection conn, int io_priority, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_connection_handshake_finish(Gio.TlsConnection conn, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_connection_set_certificate(Gio.TlsConnection conn, Gio.TlsCertificate certificate);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_connection_set_database(Gio.TlsConnection conn, Gio.TlsDatabase database);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_connection_set_interaction(Gio.TlsConnection conn, Gio.TlsInteraction interaction);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_connection_set_rehandshake_mode(Gio.TlsConnection conn, Gio.TlsRehandshakeMode mode);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_connection_set_require_close_notify(Gio.TlsConnection conn, int require_close_notify);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_connection_set_use_system_certdb(Gio.TlsConnection conn, int use_system_certdb);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsClientConnection g_tls_client_connection_new(Gio.IOStream base_io_stream, Gio.SocketConnectable server_identity, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_client_connection_copy_session_state(Gio.TlsClientConnection conn, Gio.TlsClientConnection source);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_tls_client_connection_get_accepted_cas(Gio.TlsClientConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketConnectable g_tls_client_connection_get_server_identity(Gio.TlsClientConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_tls_client_connection_get_use_ssl3(Gio.TlsClientConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsCertificateFlags g_tls_client_connection_get_validation_flags(Gio.TlsClientConnection conn);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_client_connection_set_server_identity(Gio.TlsClientConnection conn, Gio.SocketConnectable identity);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_client_connection_set_use_ssl3(Gio.TlsClientConnection conn, int use_ssl3);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_client_connection_set_validation_flags(Gio.TlsClientConnection conn, Gio.TlsCertificateFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern uint g_tls_error_quark();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsFileDatabase g_tls_file_database_new(System.IntPtr anchors, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsPassword g_tls_password_new(Gio.TlsPasswordFlags flags, string description);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_tls_password_get_description(Gio.TlsPassword password);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsPasswordFlags g_tls_password_get_flags(Gio.TlsPassword password);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_tls_password_get_value(Gio.TlsPassword password, System.IntPtr length);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_tls_password_get_warning(Gio.TlsPassword password);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_password_set_description(Gio.TlsPassword password, string description);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_password_set_flags(Gio.TlsPassword password, Gio.TlsPasswordFlags flags);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_password_set_value(Gio.TlsPassword password, System.IntPtr value, long length);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_password_set_value_full(Gio.TlsPassword password, System.IntPtr value, long length, System.IntPtr destroy);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_tls_password_set_warning(Gio.TlsPassword password, string warning);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.TlsServerConnection g_tls_server_connection_new(Gio.IOStream base_io_stream, Gio.TlsCertificate certificate, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Credentials g_unix_connection_receive_credentials(Gio.UnixConnection connection, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_unix_connection_receive_credentials_async(Gio.UnixConnection connection, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Credentials g_unix_connection_receive_credentials_finish(Gio.UnixConnection connection, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_connection_receive_fd(Gio.UnixConnection connection, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_connection_send_credentials(Gio.UnixConnection connection, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_unix_connection_send_credentials_async(Gio.UnixConnection connection, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_connection_send_credentials_finish(Gio.UnixConnection connection, Gio.AsyncResult result, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_connection_send_fd(Gio.UnixConnection connection, int fd, Gio.Cancellable cancellable, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketControlMessage g_unix_credentials_message_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketControlMessage g_unix_credentials_message_new_with_credentials(Gio.Credentials credentials);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_credentials_message_is_supported();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Credentials g_unix_credentials_message_get_credentials(Gio.UnixCredentialsMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketControlMessage g_unix_fd_message_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketControlMessage g_unix_fd_message_new_with_fd_list(Gio.UnixFDList fd_list);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_fd_message_append_fd(Gio.UnixFDMessage message, int fd, out GLib.Error error);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixFDList g_unix_fd_message_get_fd_list(Gio.UnixFDMessage message);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_unix_fd_message_steal_fds(Gio.UnixFDMessage message, System.IntPtr length);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.InputStream g_unix_input_stream_new(int fd, int close_fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_input_stream_get_close_fd(Gio.UnixInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_input_stream_get_fd(Gio.UnixInputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_unix_input_stream_set_close_fd(Gio.UnixInputStream stream, int close_fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixMountMonitor g_unix_mount_monitor_new();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixMountMonitor g_unix_mount_monitor_get();
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_unix_mount_monitor_set_rate_limit(Gio.UnixMountMonitor mount_monitor, int limit_msec);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_point_compare(Gio.UnixMountPoint mount1, Gio.UnixMountPoint mount2);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixMountPoint g_unix_mount_point_copy(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_unix_mount_point_free(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_unix_mount_point_get_device_path(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_unix_mount_point_get_fs_type(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_unix_mount_point_get_mount_path(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_unix_mount_point_get_options(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_point_guess_can_eject(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_unix_mount_point_guess_icon(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_unix_mount_point_guess_name(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Icon g_unix_mount_point_guess_symbolic_icon(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_point_is_loopback(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_point_is_readonly(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_mount_point_is_user_mountable(Gio.UnixMountPoint mount_point);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.OutputStream g_unix_output_stream_new(int fd, int close_fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_output_stream_get_close_fd(Gio.UnixOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_output_stream_get_fd(Gio.UnixOutputStream stream);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_unix_output_stream_set_close_fd(Gio.UnixOutputStream stream, int close_fd);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_unix_socket_address_new(string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_unix_socket_address_new_abstract(System.IntPtr path, int path_len);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.SocketAddress g_unix_socket_address_new_with_type(System.IntPtr path, int path_len, Gio.UnixSocketAddressType type);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_socket_address_abstract_names_supported();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.UnixSocketAddressType g_unix_socket_address_get_address_type(Gio.UnixSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_unix_socket_address_get_is_abstract(Gio.UnixSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern string g_unix_socket_address_get_path(Gio.UnixSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern ulong g_unix_socket_address_get_path_len(Gio.UnixSocketAddress address);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Vfs g_vfs_get_default();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.Vfs g_vfs_get_local();
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_vfs_get_file_for_path(Gio.Vfs vfs, string path);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_vfs_get_file_for_uri(Gio.Vfs vfs, string uri);
		[DllImport("libgio-2.0.so.0")]
		public static extern System.IntPtr g_vfs_get_supported_uri_schemes(Gio.Vfs vfs);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_vfs_is_active(Gio.Vfs vfs);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.File g_vfs_parse_name(Gio.Vfs vfs, string parse_name);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_vfs_register_uri_scheme(Gio.Vfs vfs, string scheme, System.IntPtr uri_func, System.IntPtr uri_data, System.IntPtr uri_destroy, System.IntPtr parse_name_func, System.IntPtr parse_name_data, System.IntPtr parse_name_destroy);
		[DllImport("libgio-2.0.so.0")]
		public static extern int g_vfs_unregister_uri_scheme(Gio.Vfs vfs, string scheme);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ZlibCompressor g_zlib_compressor_new(Gio.ZlibCompressorFormat format, int level);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_zlib_compressor_get_file_info(Gio.ZlibCompressor compressor);
		[DllImport("libgio-2.0.so.0")]
		public static extern void g_zlib_compressor_set_file_info(Gio.ZlibCompressor compressor, Gio.FileInfo file_info);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.ZlibDecompressor g_zlib_decompressor_new(Gio.ZlibCompressorFormat format);
		[DllImport("libgio-2.0.so.0")]
		public static extern Gio.FileInfo g_zlib_decompressor_get_file_info(Gio.ZlibDecompressor decompressor);
	}
}
