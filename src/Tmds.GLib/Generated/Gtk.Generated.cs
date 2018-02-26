using System;
using System.Runtime.InteropServices;
namespace Gtk {
	public ref struct Buildable
	{
		private IntPtr _pointer;
		public static explicit operator Buildable(IntPtr pointer) => new Buildable { _pointer = pointer };
		public static explicit operator IntPtr(Buildable value) => value._pointer
;	}
	public ref struct Widget
	{
		private IntPtr _pointer;
		public static explicit operator Widget(IntPtr pointer) => new Widget { _pointer = pointer };
		public static explicit operator IntPtr(Widget value) => value._pointer
;		public static implicit operator GObject.InitiallyUnowned(Widget value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Widget(GObject.InitiallyUnowned value) => (Widget)(IntPtr)value
;		public static implicit operator GObject.Object(Widget value) => (GObject.Object)value._pointer
;		public static explicit operator Widget(GObject.Object value) => (Widget)(IntPtr)value
;	}
	public ref struct AboutDialog
	{
		private IntPtr _pointer;
		public static explicit operator AboutDialog(IntPtr pointer) => new AboutDialog { _pointer = pointer };
		public static explicit operator IntPtr(AboutDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(AboutDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator AboutDialog(Gtk.Dialog value) => (AboutDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(AboutDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator AboutDialog(Gtk.Window value) => (AboutDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(AboutDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator AboutDialog(Gtk.Bin value) => (AboutDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(AboutDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator AboutDialog(Gtk.Container value) => (AboutDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(AboutDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator AboutDialog(Gtk.Widget value) => (AboutDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(AboutDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator AboutDialog(GObject.InitiallyUnowned value) => (AboutDialog)(IntPtr)value
;		public static implicit operator GObject.Object(AboutDialog value) => (GObject.Object)value._pointer
;		public static explicit operator AboutDialog(GObject.Object value) => (AboutDialog)(IntPtr)value
;	}
	public enum License
	{
		unknown = 0,
		custom = 1,
		gpl_2_0 = 2,
		gpl_3_0 = 3,
		lgpl_2_1 = 4,
		lgpl_3_0 = 5,
		bsd = 6,
		mit_x11 = 7,
		artistic = 8,
		gpl_2_0_only = 9,
		gpl_3_0_only = 10,
		lgpl_2_1_only = 11,
		lgpl_3_0_only = 12,
		agpl_3_0 = 13,
	}
	public ref struct Dialog
	{
		private IntPtr _pointer;
		public static explicit operator Dialog(IntPtr pointer) => new Dialog { _pointer = pointer };
		public static explicit operator IntPtr(Dialog value) => value._pointer
;		public static implicit operator Gtk.Window(Dialog value) => (Gtk.Window)value._pointer
;		public static explicit operator Dialog(Gtk.Window value) => (Dialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(Dialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator Dialog(Gtk.Bin value) => (Dialog)(IntPtr)value
;		public static implicit operator Gtk.Container(Dialog value) => (Gtk.Container)value._pointer
;		public static explicit operator Dialog(Gtk.Container value) => (Dialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(Dialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator Dialog(Gtk.Widget value) => (Dialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Dialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Dialog(GObject.InitiallyUnowned value) => (Dialog)(IntPtr)value
;		public static implicit operator GObject.Object(Dialog value) => (GObject.Object)value._pointer
;		public static explicit operator Dialog(GObject.Object value) => (Dialog)(IntPtr)value
;	}
	public ref struct AboutDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AboutDialogPrivate(IntPtr pointer) => new AboutDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AboutDialogPrivate value) => value._pointer
;	}
	public ref struct DialogClass
	{
		private IntPtr _pointer;
		public static explicit operator DialogClass(IntPtr pointer) => new DialogClass { _pointer = pointer };
		public static explicit operator IntPtr(DialogClass value) => value._pointer
;	}
	public ref struct AboutDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator AboutDialogClass(IntPtr pointer) => new AboutDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(AboutDialogClass value) => value._pointer
;	}
	[Flags]
	public enum AccelFlags
	{
		visible = 1,
		locked = 2,
		mask = 7,
	}
	public ref struct AccelGroup
	{
		private IntPtr _pointer;
		public static explicit operator AccelGroup(IntPtr pointer) => new AccelGroup { _pointer = pointer };
		public static explicit operator IntPtr(AccelGroup value) => value._pointer
;		public static implicit operator GObject.Object(AccelGroup value) => (GObject.Object)value._pointer
;		public static explicit operator AccelGroup(GObject.Object value) => (AccelGroup)(IntPtr)value
;	}
	public ref struct AccelKey
	{
		private IntPtr _pointer;
		public static explicit operator AccelKey(IntPtr pointer) => new AccelKey { _pointer = pointer };
		public static explicit operator IntPtr(AccelKey value) => value._pointer
;	}
	public ref struct AccelGroupEntry
	{
		private IntPtr _pointer;
		public static explicit operator AccelGroupEntry(IntPtr pointer) => new AccelGroupEntry { _pointer = pointer };
		public static explicit operator IntPtr(AccelGroupEntry value) => value._pointer
;	}
	public ref struct AccelGroupPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AccelGroupPrivate(IntPtr pointer) => new AccelGroupPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AccelGroupPrivate value) => value._pointer
;	}
	public ref struct AccelGroupClass
	{
		private IntPtr _pointer;
		public static explicit operator AccelGroupClass(IntPtr pointer) => new AccelGroupClass { _pointer = pointer };
		public static explicit operator IntPtr(AccelGroupClass value) => value._pointer
;	}
	public ref struct AccelLabel
	{
		private IntPtr _pointer;
		public static explicit operator AccelLabel(IntPtr pointer) => new AccelLabel { _pointer = pointer };
		public static explicit operator IntPtr(AccelLabel value) => value._pointer
;		public static implicit operator Gtk.Label(AccelLabel value) => (Gtk.Label)value._pointer
;		public static explicit operator AccelLabel(Gtk.Label value) => (AccelLabel)(IntPtr)value
;		public static implicit operator Gtk.Misc(AccelLabel value) => (Gtk.Misc)value._pointer
;		public static explicit operator AccelLabel(Gtk.Misc value) => (AccelLabel)(IntPtr)value
;		public static implicit operator Gtk.Widget(AccelLabel value) => (Gtk.Widget)value._pointer
;		public static explicit operator AccelLabel(Gtk.Widget value) => (AccelLabel)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(AccelLabel value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator AccelLabel(GObject.InitiallyUnowned value) => (AccelLabel)(IntPtr)value
;		public static implicit operator GObject.Object(AccelLabel value) => (GObject.Object)value._pointer
;		public static explicit operator AccelLabel(GObject.Object value) => (AccelLabel)(IntPtr)value
;	}
	public ref struct Label
	{
		private IntPtr _pointer;
		public static explicit operator Label(IntPtr pointer) => new Label { _pointer = pointer };
		public static explicit operator IntPtr(Label value) => value._pointer
;		public static implicit operator Gtk.Misc(Label value) => (Gtk.Misc)value._pointer
;		public static explicit operator Label(Gtk.Misc value) => (Label)(IntPtr)value
;		public static implicit operator Gtk.Widget(Label value) => (Gtk.Widget)value._pointer
;		public static explicit operator Label(Gtk.Widget value) => (Label)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Label value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Label(GObject.InitiallyUnowned value) => (Label)(IntPtr)value
;		public static implicit operator GObject.Object(Label value) => (GObject.Object)value._pointer
;		public static explicit operator Label(GObject.Object value) => (Label)(IntPtr)value
;	}
	public ref struct AccelLabelPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AccelLabelPrivate(IntPtr pointer) => new AccelLabelPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AccelLabelPrivate value) => value._pointer
;	}
	public ref struct LabelClass
	{
		private IntPtr _pointer;
		public static explicit operator LabelClass(IntPtr pointer) => new LabelClass { _pointer = pointer };
		public static explicit operator IntPtr(LabelClass value) => value._pointer
;	}
	public ref struct AccelLabelClass
	{
		private IntPtr _pointer;
		public static explicit operator AccelLabelClass(IntPtr pointer) => new AccelLabelClass { _pointer = pointer };
		public static explicit operator IntPtr(AccelLabelClass value) => value._pointer
;	}
	public ref struct AccelMap
	{
		private IntPtr _pointer;
		public static explicit operator AccelMap(IntPtr pointer) => new AccelMap { _pointer = pointer };
		public static explicit operator IntPtr(AccelMap value) => value._pointer
;		public static implicit operator GObject.Object(AccelMap value) => (GObject.Object)value._pointer
;		public static explicit operator AccelMap(GObject.Object value) => (AccelMap)(IntPtr)value
;	}
	public ref struct AccelMapClass
	{
		private IntPtr _pointer;
		public static explicit operator AccelMapClass(IntPtr pointer) => new AccelMapClass { _pointer = pointer };
		public static explicit operator IntPtr(AccelMapClass value) => value._pointer
;	}
	public ref struct Accessible
	{
		private IntPtr _pointer;
		public static explicit operator Accessible(IntPtr pointer) => new Accessible { _pointer = pointer };
		public static explicit operator IntPtr(Accessible value) => value._pointer
;		public static implicit operator Atk.Object(Accessible value) => (Atk.Object)value._pointer
;		public static explicit operator Accessible(Atk.Object value) => (Accessible)(IntPtr)value
;		public static implicit operator GObject.Object(Accessible value) => (GObject.Object)value._pointer
;		public static explicit operator Accessible(GObject.Object value) => (Accessible)(IntPtr)value
;	}
	public ref struct AccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator AccessiblePrivate(IntPtr pointer) => new AccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(AccessiblePrivate value) => value._pointer
;	}
	public ref struct AccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator AccessibleClass(IntPtr pointer) => new AccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(AccessibleClass value) => value._pointer
;	}
	public ref struct Action
	{
		private IntPtr _pointer;
		public static explicit operator Action(IntPtr pointer) => new Action { _pointer = pointer };
		public static explicit operator IntPtr(Action value) => value._pointer
;		public static implicit operator GObject.Object(Action value) => (GObject.Object)value._pointer
;		public static explicit operator Action(GObject.Object value) => (Action)(IntPtr)value
;	}
	public ref struct ActionGroup
	{
		private IntPtr _pointer;
		public static explicit operator ActionGroup(IntPtr pointer) => new ActionGroup { _pointer = pointer };
		public static explicit operator IntPtr(ActionGroup value) => value._pointer
;		public static implicit operator GObject.Object(ActionGroup value) => (GObject.Object)value._pointer
;		public static explicit operator ActionGroup(GObject.Object value) => (ActionGroup)(IntPtr)value
;	}
	public ref struct ActionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ActionPrivate(IntPtr pointer) => new ActionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ActionPrivate value) => value._pointer
;	}
	public ref struct ActionBar
	{
		private IntPtr _pointer;
		public static explicit operator ActionBar(IntPtr pointer) => new ActionBar { _pointer = pointer };
		public static explicit operator IntPtr(ActionBar value) => value._pointer
;		public static implicit operator Gtk.Bin(ActionBar value) => (Gtk.Bin)value._pointer
;		public static explicit operator ActionBar(Gtk.Bin value) => (ActionBar)(IntPtr)value
;		public static implicit operator Gtk.Container(ActionBar value) => (Gtk.Container)value._pointer
;		public static explicit operator ActionBar(Gtk.Container value) => (ActionBar)(IntPtr)value
;		public static implicit operator Gtk.Widget(ActionBar value) => (Gtk.Widget)value._pointer
;		public static explicit operator ActionBar(Gtk.Widget value) => (ActionBar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ActionBar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ActionBar(GObject.InitiallyUnowned value) => (ActionBar)(IntPtr)value
;		public static implicit operator GObject.Object(ActionBar value) => (GObject.Object)value._pointer
;		public static explicit operator ActionBar(GObject.Object value) => (ActionBar)(IntPtr)value
;	}
	public ref struct Bin
	{
		private IntPtr _pointer;
		public static explicit operator Bin(IntPtr pointer) => new Bin { _pointer = pointer };
		public static explicit operator IntPtr(Bin value) => value._pointer
;		public static implicit operator Gtk.Container(Bin value) => (Gtk.Container)value._pointer
;		public static explicit operator Bin(Gtk.Container value) => (Bin)(IntPtr)value
;		public static implicit operator Gtk.Widget(Bin value) => (Gtk.Widget)value._pointer
;		public static explicit operator Bin(Gtk.Widget value) => (Bin)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Bin value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Bin(GObject.InitiallyUnowned value) => (Bin)(IntPtr)value
;		public static implicit operator GObject.Object(Bin value) => (GObject.Object)value._pointer
;		public static explicit operator Bin(GObject.Object value) => (Bin)(IntPtr)value
;	}
	public ref struct BinClass
	{
		private IntPtr _pointer;
		public static explicit operator BinClass(IntPtr pointer) => new BinClass { _pointer = pointer };
		public static explicit operator IntPtr(BinClass value) => value._pointer
;	}
	public ref struct ActionBarClass
	{
		private IntPtr _pointer;
		public static explicit operator ActionBarClass(IntPtr pointer) => new ActionBarClass { _pointer = pointer };
		public static explicit operator IntPtr(ActionBarClass value) => value._pointer
;	}
	public ref struct ActionBarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ActionBarPrivate(IntPtr pointer) => new ActionBarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ActionBarPrivate value) => value._pointer
;	}
	public ref struct ActionClass
	{
		private IntPtr _pointer;
		public static explicit operator ActionClass(IntPtr pointer) => new ActionClass { _pointer = pointer };
		public static explicit operator IntPtr(ActionClass value) => value._pointer
;	}
	public ref struct ActionEntry
	{
		private IntPtr _pointer;
		public static explicit operator ActionEntry(IntPtr pointer) => new ActionEntry { _pointer = pointer };
		public static explicit operator IntPtr(ActionEntry value) => value._pointer
;	}
	public ref struct RadioActionEntry
	{
		private IntPtr _pointer;
		public static explicit operator RadioActionEntry(IntPtr pointer) => new RadioActionEntry { _pointer = pointer };
		public static explicit operator IntPtr(RadioActionEntry value) => value._pointer
;	}
	public ref struct ToggleActionEntry
	{
		private IntPtr _pointer;
		public static explicit operator ToggleActionEntry(IntPtr pointer) => new ToggleActionEntry { _pointer = pointer };
		public static explicit operator IntPtr(ToggleActionEntry value) => value._pointer
;	}
	public ref struct ActionGroupPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ActionGroupPrivate(IntPtr pointer) => new ActionGroupPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ActionGroupPrivate value) => value._pointer
;	}
	public ref struct ActionGroupClass
	{
		private IntPtr _pointer;
		public static explicit operator ActionGroupClass(IntPtr pointer) => new ActionGroupClass { _pointer = pointer };
		public static explicit operator IntPtr(ActionGroupClass value) => value._pointer
;	}
	public ref struct Actionable
	{
		private IntPtr _pointer;
		public static explicit operator Actionable(IntPtr pointer) => new Actionable { _pointer = pointer };
		public static explicit operator IntPtr(Actionable value) => value._pointer
;	}
	public ref struct ActionableInterface
	{
		private IntPtr _pointer;
		public static explicit operator ActionableInterface(IntPtr pointer) => new ActionableInterface { _pointer = pointer };
		public static explicit operator IntPtr(ActionableInterface value) => value._pointer
;	}
	public ref struct Activatable
	{
		private IntPtr _pointer;
		public static explicit operator Activatable(IntPtr pointer) => new Activatable { _pointer = pointer };
		public static explicit operator IntPtr(Activatable value) => value._pointer
;	}
	public ref struct ActivatableIface
	{
		private IntPtr _pointer;
		public static explicit operator ActivatableIface(IntPtr pointer) => new ActivatableIface { _pointer = pointer };
		public static explicit operator IntPtr(ActivatableIface value) => value._pointer
;	}
	public ref struct Adjustment
	{
		private IntPtr _pointer;
		public static explicit operator Adjustment(IntPtr pointer) => new Adjustment { _pointer = pointer };
		public static explicit operator IntPtr(Adjustment value) => value._pointer
;		public static implicit operator GObject.InitiallyUnowned(Adjustment value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Adjustment(GObject.InitiallyUnowned value) => (Adjustment)(IntPtr)value
;		public static implicit operator GObject.Object(Adjustment value) => (GObject.Object)value._pointer
;		public static explicit operator Adjustment(GObject.Object value) => (Adjustment)(IntPtr)value
;	}
	public ref struct AdjustmentPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AdjustmentPrivate(IntPtr pointer) => new AdjustmentPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AdjustmentPrivate value) => value._pointer
;	}
	public ref struct AdjustmentClass
	{
		private IntPtr _pointer;
		public static explicit operator AdjustmentClass(IntPtr pointer) => new AdjustmentClass { _pointer = pointer };
		public static explicit operator IntPtr(AdjustmentClass value) => value._pointer
;	}
	public enum Align
	{
		fill = 0,
		start = 1,
		end = 2,
		center = 3,
		baseline = 4,
	}
	public ref struct Alignment
	{
		private IntPtr _pointer;
		public static explicit operator Alignment(IntPtr pointer) => new Alignment { _pointer = pointer };
		public static explicit operator IntPtr(Alignment value) => value._pointer
;		public static implicit operator Gtk.Bin(Alignment value) => (Gtk.Bin)value._pointer
;		public static explicit operator Alignment(Gtk.Bin value) => (Alignment)(IntPtr)value
;		public static implicit operator Gtk.Container(Alignment value) => (Gtk.Container)value._pointer
;		public static explicit operator Alignment(Gtk.Container value) => (Alignment)(IntPtr)value
;		public static implicit operator Gtk.Widget(Alignment value) => (Gtk.Widget)value._pointer
;		public static explicit operator Alignment(Gtk.Widget value) => (Alignment)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Alignment value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Alignment(GObject.InitiallyUnowned value) => (Alignment)(IntPtr)value
;		public static implicit operator GObject.Object(Alignment value) => (GObject.Object)value._pointer
;		public static explicit operator Alignment(GObject.Object value) => (Alignment)(IntPtr)value
;	}
	public ref struct AlignmentPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AlignmentPrivate(IntPtr pointer) => new AlignmentPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AlignmentPrivate value) => value._pointer
;	}
	public ref struct AlignmentClass
	{
		private IntPtr _pointer;
		public static explicit operator AlignmentClass(IntPtr pointer) => new AlignmentClass { _pointer = pointer };
		public static explicit operator IntPtr(AlignmentClass value) => value._pointer
;	}
	public ref struct AppChooser
	{
		private IntPtr _pointer;
		public static explicit operator AppChooser(IntPtr pointer) => new AppChooser { _pointer = pointer };
		public static explicit operator IntPtr(AppChooser value) => value._pointer
;	}
	public ref struct CellEditable
	{
		private IntPtr _pointer;
		public static explicit operator CellEditable(IntPtr pointer) => new CellEditable { _pointer = pointer };
		public static explicit operator IntPtr(CellEditable value) => value._pointer
;	}
	public ref struct CellLayout
	{
		private IntPtr _pointer;
		public static explicit operator CellLayout(IntPtr pointer) => new CellLayout { _pointer = pointer };
		public static explicit operator IntPtr(CellLayout value) => value._pointer
;	}
	public ref struct AppChooserButton
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserButton(IntPtr pointer) => new AppChooserButton { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserButton value) => value._pointer
;		public static implicit operator Gtk.ComboBox(AppChooserButton value) => (Gtk.ComboBox)value._pointer
;		public static explicit operator AppChooserButton(Gtk.ComboBox value) => (AppChooserButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(AppChooserButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator AppChooserButton(Gtk.Bin value) => (AppChooserButton)(IntPtr)value
;		public static implicit operator Gtk.Container(AppChooserButton value) => (Gtk.Container)value._pointer
;		public static explicit operator AppChooserButton(Gtk.Container value) => (AppChooserButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(AppChooserButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator AppChooserButton(Gtk.Widget value) => (AppChooserButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(AppChooserButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator AppChooserButton(GObject.InitiallyUnowned value) => (AppChooserButton)(IntPtr)value
;		public static implicit operator GObject.Object(AppChooserButton value) => (GObject.Object)value._pointer
;		public static explicit operator AppChooserButton(GObject.Object value) => (AppChooserButton)(IntPtr)value
;	}
	public ref struct ComboBox
	{
		private IntPtr _pointer;
		public static explicit operator ComboBox(IntPtr pointer) => new ComboBox { _pointer = pointer };
		public static explicit operator IntPtr(ComboBox value) => value._pointer
;		public static implicit operator Gtk.Bin(ComboBox value) => (Gtk.Bin)value._pointer
;		public static explicit operator ComboBox(Gtk.Bin value) => (ComboBox)(IntPtr)value
;		public static implicit operator Gtk.Container(ComboBox value) => (Gtk.Container)value._pointer
;		public static explicit operator ComboBox(Gtk.Container value) => (ComboBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(ComboBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator ComboBox(Gtk.Widget value) => (ComboBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ComboBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ComboBox(GObject.InitiallyUnowned value) => (ComboBox)(IntPtr)value
;		public static implicit operator GObject.Object(ComboBox value) => (GObject.Object)value._pointer
;		public static explicit operator ComboBox(GObject.Object value) => (ComboBox)(IntPtr)value
;	}
	public ref struct AppChooserButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserButtonPrivate(IntPtr pointer) => new AppChooserButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserButtonPrivate value) => value._pointer
;	}
	public ref struct ComboBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxClass(IntPtr pointer) => new ComboBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxClass value) => value._pointer
;	}
	public ref struct AppChooserButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserButtonClass(IntPtr pointer) => new AppChooserButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserButtonClass value) => value._pointer
;	}
	public ref struct Window
	{
		private IntPtr _pointer;
		public static explicit operator Window(IntPtr pointer) => new Window { _pointer = pointer };
		public static explicit operator IntPtr(Window value) => value._pointer
;		public static implicit operator Gtk.Bin(Window value) => (Gtk.Bin)value._pointer
;		public static explicit operator Window(Gtk.Bin value) => (Window)(IntPtr)value
;		public static implicit operator Gtk.Container(Window value) => (Gtk.Container)value._pointer
;		public static explicit operator Window(Gtk.Container value) => (Window)(IntPtr)value
;		public static implicit operator Gtk.Widget(Window value) => (Gtk.Widget)value._pointer
;		public static explicit operator Window(Gtk.Widget value) => (Window)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Window value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Window(GObject.InitiallyUnowned value) => (Window)(IntPtr)value
;		public static implicit operator GObject.Object(Window value) => (GObject.Object)value._pointer
;		public static explicit operator Window(GObject.Object value) => (Window)(IntPtr)value
;	}
	[Flags]
	public enum DialogFlags
	{
		modal = 1,
		destroy_with_parent = 2,
		use_header_bar = 4,
	}
	public ref struct AppChooserDialog
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserDialog(IntPtr pointer) => new AppChooserDialog { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(AppChooserDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator AppChooserDialog(Gtk.Dialog value) => (AppChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(AppChooserDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator AppChooserDialog(Gtk.Window value) => (AppChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(AppChooserDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator AppChooserDialog(Gtk.Bin value) => (AppChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(AppChooserDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator AppChooserDialog(Gtk.Container value) => (AppChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(AppChooserDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator AppChooserDialog(Gtk.Widget value) => (AppChooserDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(AppChooserDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator AppChooserDialog(GObject.InitiallyUnowned value) => (AppChooserDialog)(IntPtr)value
;		public static implicit operator GObject.Object(AppChooserDialog value) => (GObject.Object)value._pointer
;		public static explicit operator AppChooserDialog(GObject.Object value) => (AppChooserDialog)(IntPtr)value
;	}
	public ref struct AppChooserDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserDialogPrivate(IntPtr pointer) => new AppChooserDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserDialogPrivate value) => value._pointer
;	}
	public ref struct AppChooserDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserDialogClass(IntPtr pointer) => new AppChooserDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserDialogClass value) => value._pointer
;	}
	public ref struct Orientable
	{
		private IntPtr _pointer;
		public static explicit operator Orientable(IntPtr pointer) => new Orientable { _pointer = pointer };
		public static explicit operator IntPtr(Orientable value) => value._pointer
;	}
	public ref struct AppChooserWidget
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserWidget(IntPtr pointer) => new AppChooserWidget { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserWidget value) => value._pointer
;		public static implicit operator Gtk.Box(AppChooserWidget value) => (Gtk.Box)value._pointer
;		public static explicit operator AppChooserWidget(Gtk.Box value) => (AppChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Container(AppChooserWidget value) => (Gtk.Container)value._pointer
;		public static explicit operator AppChooserWidget(Gtk.Container value) => (AppChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Widget(AppChooserWidget value) => (Gtk.Widget)value._pointer
;		public static explicit operator AppChooserWidget(Gtk.Widget value) => (AppChooserWidget)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(AppChooserWidget value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator AppChooserWidget(GObject.InitiallyUnowned value) => (AppChooserWidget)(IntPtr)value
;		public static implicit operator GObject.Object(AppChooserWidget value) => (GObject.Object)value._pointer
;		public static explicit operator AppChooserWidget(GObject.Object value) => (AppChooserWidget)(IntPtr)value
;	}
	public ref struct Box
	{
		private IntPtr _pointer;
		public static explicit operator Box(IntPtr pointer) => new Box { _pointer = pointer };
		public static explicit operator IntPtr(Box value) => value._pointer
;		public static implicit operator Gtk.Container(Box value) => (Gtk.Container)value._pointer
;		public static explicit operator Box(Gtk.Container value) => (Box)(IntPtr)value
;		public static implicit operator Gtk.Widget(Box value) => (Gtk.Widget)value._pointer
;		public static explicit operator Box(Gtk.Widget value) => (Box)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Box value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Box(GObject.InitiallyUnowned value) => (Box)(IntPtr)value
;		public static implicit operator GObject.Object(Box value) => (GObject.Object)value._pointer
;		public static explicit operator Box(GObject.Object value) => (Box)(IntPtr)value
;	}
	public ref struct AppChooserWidgetPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserWidgetPrivate(IntPtr pointer) => new AppChooserWidgetPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserWidgetPrivate value) => value._pointer
;	}
	public ref struct BoxClass
	{
		private IntPtr _pointer;
		public static explicit operator BoxClass(IntPtr pointer) => new BoxClass { _pointer = pointer };
		public static explicit operator IntPtr(BoxClass value) => value._pointer
;	}
	public ref struct Menu
	{
		private IntPtr _pointer;
		public static explicit operator Menu(IntPtr pointer) => new Menu { _pointer = pointer };
		public static explicit operator IntPtr(Menu value) => value._pointer
;		public static implicit operator Gtk.MenuShell(Menu value) => (Gtk.MenuShell)value._pointer
;		public static explicit operator Menu(Gtk.MenuShell value) => (Menu)(IntPtr)value
;		public static implicit operator Gtk.Container(Menu value) => (Gtk.Container)value._pointer
;		public static explicit operator Menu(Gtk.Container value) => (Menu)(IntPtr)value
;		public static implicit operator Gtk.Widget(Menu value) => (Gtk.Widget)value._pointer
;		public static explicit operator Menu(Gtk.Widget value) => (Menu)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Menu value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Menu(GObject.InitiallyUnowned value) => (Menu)(IntPtr)value
;		public static implicit operator GObject.Object(Menu value) => (GObject.Object)value._pointer
;		public static explicit operator Menu(GObject.Object value) => (Menu)(IntPtr)value
;	}
	public ref struct AppChooserWidgetClass
	{
		private IntPtr _pointer;
		public static explicit operator AppChooserWidgetClass(IntPtr pointer) => new AppChooserWidgetClass { _pointer = pointer };
		public static explicit operator IntPtr(AppChooserWidgetClass value) => value._pointer
;	}
	public ref struct Application
	{
		private IntPtr _pointer;
		public static explicit operator Application(IntPtr pointer) => new Application { _pointer = pointer };
		public static explicit operator IntPtr(Application value) => value._pointer
;		public static implicit operator Gio.Application(Application value) => (Gio.Application)value._pointer
;		public static explicit operator Application(Gio.Application value) => (Application)(IntPtr)value
;		public static implicit operator GObject.Object(Application value) => (GObject.Object)value._pointer
;		public static explicit operator Application(GObject.Object value) => (Application)(IntPtr)value
;	}
	[Flags]
	public enum ApplicationInhibitFlags
	{
		logout = 1,
		@switch = 2,
		suspend = 4,
		idle = 8,
	}
	public ref struct ApplicationPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationPrivate(IntPtr pointer) => new ApplicationPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationPrivate value) => value._pointer
;	}
	public ref struct ApplicationClass
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationClass(IntPtr pointer) => new ApplicationClass { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationClass value) => value._pointer
;	}
	public ref struct ShortcutsWindow
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsWindow(IntPtr pointer) => new ShortcutsWindow { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsWindow value) => value._pointer
;		public static implicit operator Gtk.Window(ShortcutsWindow value) => (Gtk.Window)value._pointer
;		public static explicit operator ShortcutsWindow(Gtk.Window value) => (ShortcutsWindow)(IntPtr)value
;		public static implicit operator Gtk.Bin(ShortcutsWindow value) => (Gtk.Bin)value._pointer
;		public static explicit operator ShortcutsWindow(Gtk.Bin value) => (ShortcutsWindow)(IntPtr)value
;		public static implicit operator Gtk.Container(ShortcutsWindow value) => (Gtk.Container)value._pointer
;		public static explicit operator ShortcutsWindow(Gtk.Container value) => (ShortcutsWindow)(IntPtr)value
;		public static implicit operator Gtk.Widget(ShortcutsWindow value) => (Gtk.Widget)value._pointer
;		public static explicit operator ShortcutsWindow(Gtk.Widget value) => (ShortcutsWindow)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ShortcutsWindow value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ShortcutsWindow(GObject.InitiallyUnowned value) => (ShortcutsWindow)(IntPtr)value
;		public static implicit operator GObject.Object(ShortcutsWindow value) => (GObject.Object)value._pointer
;		public static explicit operator ShortcutsWindow(GObject.Object value) => (ShortcutsWindow)(IntPtr)value
;	}
	public ref struct ApplicationWindow
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationWindow(IntPtr pointer) => new ApplicationWindow { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationWindow value) => value._pointer
;		public static implicit operator Gtk.Window(ApplicationWindow value) => (Gtk.Window)value._pointer
;		public static explicit operator ApplicationWindow(Gtk.Window value) => (ApplicationWindow)(IntPtr)value
;		public static implicit operator Gtk.Bin(ApplicationWindow value) => (Gtk.Bin)value._pointer
;		public static explicit operator ApplicationWindow(Gtk.Bin value) => (ApplicationWindow)(IntPtr)value
;		public static implicit operator Gtk.Container(ApplicationWindow value) => (Gtk.Container)value._pointer
;		public static explicit operator ApplicationWindow(Gtk.Container value) => (ApplicationWindow)(IntPtr)value
;		public static implicit operator Gtk.Widget(ApplicationWindow value) => (Gtk.Widget)value._pointer
;		public static explicit operator ApplicationWindow(Gtk.Widget value) => (ApplicationWindow)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ApplicationWindow value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ApplicationWindow(GObject.InitiallyUnowned value) => (ApplicationWindow)(IntPtr)value
;		public static implicit operator GObject.Object(ApplicationWindow value) => (GObject.Object)value._pointer
;		public static explicit operator ApplicationWindow(GObject.Object value) => (ApplicationWindow)(IntPtr)value
;	}
	public ref struct ApplicationWindowPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationWindowPrivate(IntPtr pointer) => new ApplicationWindowPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationWindowPrivate value) => value._pointer
;	}
	public ref struct WindowClass
	{
		private IntPtr _pointer;
		public static explicit operator WindowClass(IntPtr pointer) => new WindowClass { _pointer = pointer };
		public static explicit operator IntPtr(WindowClass value) => value._pointer
;	}
	public ref struct ApplicationWindowClass
	{
		private IntPtr _pointer;
		public static explicit operator ApplicationWindowClass(IntPtr pointer) => new ApplicationWindowClass { _pointer = pointer };
		public static explicit operator IntPtr(ApplicationWindowClass value) => value._pointer
;	}
	public enum ArrowType
	{
		up = 0,
		down = 1,
		left = 2,
		right = 3,
		none = 4,
	}
	public enum ShadowType
	{
		none = 0,
		@in = 1,
		@out = 2,
		etched_in = 3,
		etched_out = 4,
	}
	public ref struct Arrow
	{
		private IntPtr _pointer;
		public static explicit operator Arrow(IntPtr pointer) => new Arrow { _pointer = pointer };
		public static explicit operator IntPtr(Arrow value) => value._pointer
;		public static implicit operator Gtk.Misc(Arrow value) => (Gtk.Misc)value._pointer
;		public static explicit operator Arrow(Gtk.Misc value) => (Arrow)(IntPtr)value
;		public static implicit operator Gtk.Widget(Arrow value) => (Gtk.Widget)value._pointer
;		public static explicit operator Arrow(Gtk.Widget value) => (Arrow)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Arrow value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Arrow(GObject.InitiallyUnowned value) => (Arrow)(IntPtr)value
;		public static implicit operator GObject.Object(Arrow value) => (GObject.Object)value._pointer
;		public static explicit operator Arrow(GObject.Object value) => (Arrow)(IntPtr)value
;	}
	public ref struct Misc
	{
		private IntPtr _pointer;
		public static explicit operator Misc(IntPtr pointer) => new Misc { _pointer = pointer };
		public static explicit operator IntPtr(Misc value) => value._pointer
;		public static implicit operator Gtk.Widget(Misc value) => (Gtk.Widget)value._pointer
;		public static explicit operator Misc(Gtk.Widget value) => (Misc)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Misc value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Misc(GObject.InitiallyUnowned value) => (Misc)(IntPtr)value
;		public static implicit operator GObject.Object(Misc value) => (GObject.Object)value._pointer
;		public static explicit operator Misc(GObject.Object value) => (Misc)(IntPtr)value
;	}
	public ref struct ArrowPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ArrowPrivate(IntPtr pointer) => new ArrowPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ArrowPrivate value) => value._pointer
;	}
	public ref struct WidgetAccessible
	{
		private IntPtr _pointer;
		public static explicit operator WidgetAccessible(IntPtr pointer) => new WidgetAccessible { _pointer = pointer };
		public static explicit operator IntPtr(WidgetAccessible value) => value._pointer
;		public static implicit operator Gtk.Accessible(WidgetAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator WidgetAccessible(Gtk.Accessible value) => (WidgetAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(WidgetAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator WidgetAccessible(Atk.Object value) => (WidgetAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(WidgetAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator WidgetAccessible(GObject.Object value) => (WidgetAccessible)(IntPtr)value
;	}
	public ref struct ArrowAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ArrowAccessiblePrivate(IntPtr pointer) => new ArrowAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ArrowAccessiblePrivate value) => value._pointer
;	}
	public ref struct ArrowAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ArrowAccessible(IntPtr pointer) => new ArrowAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ArrowAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(ArrowAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ArrowAccessible(Gtk.WidgetAccessible value) => (ArrowAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ArrowAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ArrowAccessible(Gtk.Accessible value) => (ArrowAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ArrowAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ArrowAccessible(Atk.Object value) => (ArrowAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ArrowAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ArrowAccessible(GObject.Object value) => (ArrowAccessible)(IntPtr)value
;	}
	public ref struct WidgetAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator WidgetAccessibleClass(IntPtr pointer) => new WidgetAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(WidgetAccessibleClass value) => value._pointer
;	}
	public ref struct ArrowAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ArrowAccessibleClass(IntPtr pointer) => new ArrowAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ArrowAccessibleClass value) => value._pointer
;	}
	public ref struct MiscClass
	{
		private IntPtr _pointer;
		public static explicit operator MiscClass(IntPtr pointer) => new MiscClass { _pointer = pointer };
		public static explicit operator IntPtr(MiscClass value) => value._pointer
;	}
	public ref struct ArrowClass
	{
		private IntPtr _pointer;
		public static explicit operator ArrowClass(IntPtr pointer) => new ArrowClass { _pointer = pointer };
		public static explicit operator IntPtr(ArrowClass value) => value._pointer
;	}
	public enum ArrowPlacement
	{
		both = 0,
		start = 1,
		end = 2,
	}
	public ref struct AspectFrame
	{
		private IntPtr _pointer;
		public static explicit operator AspectFrame(IntPtr pointer) => new AspectFrame { _pointer = pointer };
		public static explicit operator IntPtr(AspectFrame value) => value._pointer
;		public static implicit operator Gtk.Frame(AspectFrame value) => (Gtk.Frame)value._pointer
;		public static explicit operator AspectFrame(Gtk.Frame value) => (AspectFrame)(IntPtr)value
;		public static implicit operator Gtk.Bin(AspectFrame value) => (Gtk.Bin)value._pointer
;		public static explicit operator AspectFrame(Gtk.Bin value) => (AspectFrame)(IntPtr)value
;		public static implicit operator Gtk.Container(AspectFrame value) => (Gtk.Container)value._pointer
;		public static explicit operator AspectFrame(Gtk.Container value) => (AspectFrame)(IntPtr)value
;		public static implicit operator Gtk.Widget(AspectFrame value) => (Gtk.Widget)value._pointer
;		public static explicit operator AspectFrame(Gtk.Widget value) => (AspectFrame)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(AspectFrame value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator AspectFrame(GObject.InitiallyUnowned value) => (AspectFrame)(IntPtr)value
;		public static implicit operator GObject.Object(AspectFrame value) => (GObject.Object)value._pointer
;		public static explicit operator AspectFrame(GObject.Object value) => (AspectFrame)(IntPtr)value
;	}
	public ref struct Frame
	{
		private IntPtr _pointer;
		public static explicit operator Frame(IntPtr pointer) => new Frame { _pointer = pointer };
		public static explicit operator IntPtr(Frame value) => value._pointer
;		public static implicit operator Gtk.Bin(Frame value) => (Gtk.Bin)value._pointer
;		public static explicit operator Frame(Gtk.Bin value) => (Frame)(IntPtr)value
;		public static implicit operator Gtk.Container(Frame value) => (Gtk.Container)value._pointer
;		public static explicit operator Frame(Gtk.Container value) => (Frame)(IntPtr)value
;		public static implicit operator Gtk.Widget(Frame value) => (Gtk.Widget)value._pointer
;		public static explicit operator Frame(Gtk.Widget value) => (Frame)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Frame value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Frame(GObject.InitiallyUnowned value) => (Frame)(IntPtr)value
;		public static implicit operator GObject.Object(Frame value) => (GObject.Object)value._pointer
;		public static explicit operator Frame(GObject.Object value) => (Frame)(IntPtr)value
;	}
	public ref struct AspectFramePrivate
	{
		private IntPtr _pointer;
		public static explicit operator AspectFramePrivate(IntPtr pointer) => new AspectFramePrivate { _pointer = pointer };
		public static explicit operator IntPtr(AspectFramePrivate value) => value._pointer
;	}
	public ref struct FrameClass
	{
		private IntPtr _pointer;
		public static explicit operator FrameClass(IntPtr pointer) => new FrameClass { _pointer = pointer };
		public static explicit operator IntPtr(FrameClass value) => value._pointer
;	}
	public ref struct AspectFrameClass
	{
		private IntPtr _pointer;
		public static explicit operator AspectFrameClass(IntPtr pointer) => new AspectFrameClass { _pointer = pointer };
		public static explicit operator IntPtr(AspectFrameClass value) => value._pointer
;	}
	public ref struct Assistant
	{
		private IntPtr _pointer;
		public static explicit operator Assistant(IntPtr pointer) => new Assistant { _pointer = pointer };
		public static explicit operator IntPtr(Assistant value) => value._pointer
;		public static implicit operator Gtk.Window(Assistant value) => (Gtk.Window)value._pointer
;		public static explicit operator Assistant(Gtk.Window value) => (Assistant)(IntPtr)value
;		public static implicit operator Gtk.Bin(Assistant value) => (Gtk.Bin)value._pointer
;		public static explicit operator Assistant(Gtk.Bin value) => (Assistant)(IntPtr)value
;		public static implicit operator Gtk.Container(Assistant value) => (Gtk.Container)value._pointer
;		public static explicit operator Assistant(Gtk.Container value) => (Assistant)(IntPtr)value
;		public static implicit operator Gtk.Widget(Assistant value) => (Gtk.Widget)value._pointer
;		public static explicit operator Assistant(Gtk.Widget value) => (Assistant)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Assistant value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Assistant(GObject.InitiallyUnowned value) => (Assistant)(IntPtr)value
;		public static implicit operator GObject.Object(Assistant value) => (GObject.Object)value._pointer
;		public static explicit operator Assistant(GObject.Object value) => (Assistant)(IntPtr)value
;	}
	public enum AssistantPageType
	{
		content = 0,
		intro = 1,
		confirm = 2,
		summary = 3,
		progress = 4,
		custom = 5,
	}
	public ref struct AssistantPrivate
	{
		private IntPtr _pointer;
		public static explicit operator AssistantPrivate(IntPtr pointer) => new AssistantPrivate { _pointer = pointer };
		public static explicit operator IntPtr(AssistantPrivate value) => value._pointer
;	}
	public ref struct AssistantClass
	{
		private IntPtr _pointer;
		public static explicit operator AssistantClass(IntPtr pointer) => new AssistantClass { _pointer = pointer };
		public static explicit operator IntPtr(AssistantClass value) => value._pointer
;	}
	[Flags]
	public enum AttachOptions
	{
		expand = 1,
		shrink = 2,
		fill = 4,
	}
	public enum BaselinePosition
	{
		top = 0,
		center = 1,
		bottom = 2,
	}
	public ref struct Container
	{
		private IntPtr _pointer;
		public static explicit operator Container(IntPtr pointer) => new Container { _pointer = pointer };
		public static explicit operator IntPtr(Container value) => value._pointer
;		public static implicit operator Gtk.Widget(Container value) => (Gtk.Widget)value._pointer
;		public static explicit operator Container(Gtk.Widget value) => (Container)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Container value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Container(GObject.InitiallyUnowned value) => (Container)(IntPtr)value
;		public static implicit operator GObject.Object(Container value) => (GObject.Object)value._pointer
;		public static explicit operator Container(GObject.Object value) => (Container)(IntPtr)value
;	}
	public ref struct BinPrivate
	{
		private IntPtr _pointer;
		public static explicit operator BinPrivate(IntPtr pointer) => new BinPrivate { _pointer = pointer };
		public static explicit operator IntPtr(BinPrivate value) => value._pointer
;	}
	public ref struct ContainerClass
	{
		private IntPtr _pointer;
		public static explicit operator ContainerClass(IntPtr pointer) => new ContainerClass { _pointer = pointer };
		public static explicit operator IntPtr(ContainerClass value) => value._pointer
;	}
	public ref struct BindingArg
	{
		private IntPtr _pointer;
		public static explicit operator BindingArg(IntPtr pointer) => new BindingArg { _pointer = pointer };
		public static explicit operator IntPtr(BindingArg value) => value._pointer
;	}
	public ref struct BindingSet
	{
		private IntPtr _pointer;
		public static explicit operator BindingSet(IntPtr pointer) => new BindingSet { _pointer = pointer };
		public static explicit operator IntPtr(BindingSet value) => value._pointer
;	}
	public ref struct BindingEntry
	{
		private IntPtr _pointer;
		public static explicit operator BindingEntry(IntPtr pointer) => new BindingEntry { _pointer = pointer };
		public static explicit operator IntPtr(BindingEntry value) => value._pointer
;	}
	public ref struct BindingSignal
	{
		private IntPtr _pointer;
		public static explicit operator BindingSignal(IntPtr pointer) => new BindingSignal { _pointer = pointer };
		public static explicit operator IntPtr(BindingSignal value) => value._pointer
;	}
	public enum PathType
	{
		widget = 0,
		widget_class = 1,
		@class = 2,
	}
	public enum PathPriorityType
	{
		lowest = 0,
		gtk = 4,
		application = 8,
		theme = 10,
		rc = 12,
		highest = 15,
	}
	public ref struct RendererCellAccessible
	{
		private IntPtr _pointer;
		public static explicit operator RendererCellAccessible(IntPtr pointer) => new RendererCellAccessible { _pointer = pointer };
		public static explicit operator IntPtr(RendererCellAccessible value) => value._pointer
;		public static implicit operator Gtk.CellAccessible(RendererCellAccessible value) => (Gtk.CellAccessible)value._pointer
;		public static explicit operator RendererCellAccessible(Gtk.CellAccessible value) => (RendererCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(RendererCellAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator RendererCellAccessible(Gtk.Accessible value) => (RendererCellAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(RendererCellAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator RendererCellAccessible(Atk.Object value) => (RendererCellAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(RendererCellAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator RendererCellAccessible(GObject.Object value) => (RendererCellAccessible)(IntPtr)value
;	}
	public ref struct BooleanCellAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator BooleanCellAccessiblePrivate(IntPtr pointer) => new BooleanCellAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(BooleanCellAccessiblePrivate value) => value._pointer
;	}
	public ref struct BooleanCellAccessible
	{
		private IntPtr _pointer;
		public static explicit operator BooleanCellAccessible(IntPtr pointer) => new BooleanCellAccessible { _pointer = pointer };
		public static explicit operator IntPtr(BooleanCellAccessible value) => value._pointer
;		public static implicit operator Gtk.RendererCellAccessible(BooleanCellAccessible value) => (Gtk.RendererCellAccessible)value._pointer
;		public static explicit operator BooleanCellAccessible(Gtk.RendererCellAccessible value) => (BooleanCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.CellAccessible(BooleanCellAccessible value) => (Gtk.CellAccessible)value._pointer
;		public static explicit operator BooleanCellAccessible(Gtk.CellAccessible value) => (BooleanCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(BooleanCellAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator BooleanCellAccessible(Gtk.Accessible value) => (BooleanCellAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(BooleanCellAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator BooleanCellAccessible(Atk.Object value) => (BooleanCellAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(BooleanCellAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator BooleanCellAccessible(GObject.Object value) => (BooleanCellAccessible)(IntPtr)value
;	}
	public ref struct RendererCellAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator RendererCellAccessibleClass(IntPtr pointer) => new RendererCellAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(RendererCellAccessibleClass value) => value._pointer
;	}
	public ref struct BooleanCellAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator BooleanCellAccessibleClass(IntPtr pointer) => new BooleanCellAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(BooleanCellAccessibleClass value) => value._pointer
;	}
	public ref struct Border
	{
		private IntPtr _pointer;
		public static explicit operator Border(IntPtr pointer) => new Border { _pointer = pointer };
		public static explicit operator IntPtr(Border value) => value._pointer
;	}
	public enum BorderStyle
	{
		none = 0,
		solid = 1,
		inset = 2,
		outset = 3,
		hidden = 4,
		dotted = 5,
		dashed = 6,
		@double = 7,
		groove = 8,
		ridge = 9,
	}
	public enum Orientation
	{
		horizontal = 0,
		vertical = 1,
	}
	public enum PackType
	{
		start = 0,
		end = 1,
	}
	public ref struct BoxPrivate
	{
		private IntPtr _pointer;
		public static explicit operator BoxPrivate(IntPtr pointer) => new BoxPrivate { _pointer = pointer };
		public static explicit operator IntPtr(BoxPrivate value) => value._pointer
;	}
	public ref struct Builder
	{
		private IntPtr _pointer;
		public static explicit operator Builder(IntPtr pointer) => new Builder { _pointer = pointer };
		public static explicit operator IntPtr(Builder value) => value._pointer
;		public static implicit operator GObject.Object(Builder value) => (GObject.Object)value._pointer
;		public static explicit operator Builder(GObject.Object value) => (Builder)(IntPtr)value
;	}
	public ref struct BuildableIface
	{
		private IntPtr _pointer;
		public static explicit operator BuildableIface(IntPtr pointer) => new BuildableIface { _pointer = pointer };
		public static explicit operator IntPtr(BuildableIface value) => value._pointer
;	}
	public ref struct BuilderPrivate
	{
		private IntPtr _pointer;
		public static explicit operator BuilderPrivate(IntPtr pointer) => new BuilderPrivate { _pointer = pointer };
		public static explicit operator IntPtr(BuilderPrivate value) => value._pointer
;	}
	public ref struct BuilderClass
	{
		private IntPtr _pointer;
		public static explicit operator BuilderClass(IntPtr pointer) => new BuilderClass { _pointer = pointer };
		public static explicit operator IntPtr(BuilderClass value) => value._pointer
;	}
	public enum BuilderError
	{
		invalid_type_function = 0,
		unhandled_tag = 1,
		missing_attribute = 2,
		invalid_attribute = 3,
		invalid_tag = 4,
		missing_property_value = 5,
		invalid_value = 6,
		version_mismatch = 7,
		duplicate_id = 8,
		object_type_refused = 9,
		template_mismatch = 10,
		invalid_property = 11,
		invalid_signal = 12,
		invalid_id = 13,
	}
	public ref struct Button
	{
		private IntPtr _pointer;
		public static explicit operator Button(IntPtr pointer) => new Button { _pointer = pointer };
		public static explicit operator IntPtr(Button value) => value._pointer
;		public static implicit operator Gtk.Bin(Button value) => (Gtk.Bin)value._pointer
;		public static explicit operator Button(Gtk.Bin value) => (Button)(IntPtr)value
;		public static implicit operator Gtk.Container(Button value) => (Gtk.Container)value._pointer
;		public static explicit operator Button(Gtk.Container value) => (Button)(IntPtr)value
;		public static implicit operator Gtk.Widget(Button value) => (Gtk.Widget)value._pointer
;		public static explicit operator Button(Gtk.Widget value) => (Button)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Button value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Button(GObject.InitiallyUnowned value) => (Button)(IntPtr)value
;		public static implicit operator GObject.Object(Button value) => (GObject.Object)value._pointer
;		public static explicit operator Button(GObject.Object value) => (Button)(IntPtr)value
;	}
	public enum PositionType
	{
		left = 0,
		right = 1,
		top = 2,
		bottom = 3,
	}
	public enum ReliefStyle
	{
		normal = 0,
		half = 1,
		none = 2,
	}
	public ref struct ButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ButtonPrivate(IntPtr pointer) => new ButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ButtonPrivate value) => value._pointer
;	}
	public ref struct ContainerAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ContainerAccessible(IntPtr pointer) => new ContainerAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ContainerAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(ContainerAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ContainerAccessible(Gtk.WidgetAccessible value) => (ContainerAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ContainerAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ContainerAccessible(Gtk.Accessible value) => (ContainerAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ContainerAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ContainerAccessible(Atk.Object value) => (ContainerAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ContainerAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ContainerAccessible(GObject.Object value) => (ContainerAccessible)(IntPtr)value
;	}
	public ref struct ButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ButtonAccessiblePrivate(IntPtr pointer) => new ButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct ButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ButtonAccessible(IntPtr pointer) => new ButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(ButtonAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ButtonAccessible(Gtk.ContainerAccessible value) => (ButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ButtonAccessible(Gtk.WidgetAccessible value) => (ButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ButtonAccessible(Gtk.Accessible value) => (ButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ButtonAccessible(Atk.Object value) => (ButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ButtonAccessible(GObject.Object value) => (ButtonAccessible)(IntPtr)value
;	}
	public ref struct ContainerAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ContainerAccessibleClass(IntPtr pointer) => new ContainerAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ContainerAccessibleClass value) => value._pointer
;	}
	public ref struct ButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ButtonAccessibleClass(IntPtr pointer) => new ButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ButtonAccessibleClass value) => value._pointer
;	}
	public ref struct ButtonBox
	{
		private IntPtr _pointer;
		public static explicit operator ButtonBox(IntPtr pointer) => new ButtonBox { _pointer = pointer };
		public static explicit operator IntPtr(ButtonBox value) => value._pointer
;		public static implicit operator Gtk.Box(ButtonBox value) => (Gtk.Box)value._pointer
;		public static explicit operator ButtonBox(Gtk.Box value) => (ButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Container(ButtonBox value) => (Gtk.Container)value._pointer
;		public static explicit operator ButtonBox(Gtk.Container value) => (ButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(ButtonBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator ButtonBox(Gtk.Widget value) => (ButtonBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ButtonBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ButtonBox(GObject.InitiallyUnowned value) => (ButtonBox)(IntPtr)value
;		public static implicit operator GObject.Object(ButtonBox value) => (GObject.Object)value._pointer
;		public static explicit operator ButtonBox(GObject.Object value) => (ButtonBox)(IntPtr)value
;	}
	public enum ButtonBoxStyle
	{
		spread = 1,
		edge = 2,
		start = 3,
		end = 4,
		center = 5,
		expand = 6,
	}
	public ref struct ButtonBoxPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ButtonBoxPrivate(IntPtr pointer) => new ButtonBoxPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ButtonBoxPrivate value) => value._pointer
;	}
	public ref struct ButtonBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator ButtonBoxClass(IntPtr pointer) => new ButtonBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(ButtonBoxClass value) => value._pointer
;	}
	public ref struct ButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator ButtonClass(IntPtr pointer) => new ButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(ButtonClass value) => value._pointer
;	}
	public enum ButtonRole
	{
		normal = 0,
		check = 1,
		radio = 2,
	}
	public enum ButtonsType
	{
		none = 0,
		ok = 1,
		close = 2,
		cancel = 3,
		yes_no = 4,
		ok_cancel = 5,
	}
	public ref struct Calendar
	{
		private IntPtr _pointer;
		public static explicit operator Calendar(IntPtr pointer) => new Calendar { _pointer = pointer };
		public static explicit operator IntPtr(Calendar value) => value._pointer
;		public static implicit operator Gtk.Widget(Calendar value) => (Gtk.Widget)value._pointer
;		public static explicit operator Calendar(Gtk.Widget value) => (Calendar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Calendar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Calendar(GObject.InitiallyUnowned value) => (Calendar)(IntPtr)value
;		public static implicit operator GObject.Object(Calendar value) => (GObject.Object)value._pointer
;		public static explicit operator Calendar(GObject.Object value) => (Calendar)(IntPtr)value
;	}
	[Flags]
	public enum CalendarDisplayOptions
	{
		show_heading = 1,
		show_day_names = 2,
		no_month_change = 4,
		show_week_numbers = 8,
		show_details = 32,
	}
	public ref struct CalendarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CalendarPrivate(IntPtr pointer) => new CalendarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CalendarPrivate value) => value._pointer
;	}
	public ref struct WidgetClass
	{
		private IntPtr _pointer;
		public static explicit operator WidgetClass(IntPtr pointer) => new WidgetClass { _pointer = pointer };
		public static explicit operator IntPtr(WidgetClass value) => value._pointer
;	}
	public ref struct CalendarClass
	{
		private IntPtr _pointer;
		public static explicit operator CalendarClass(IntPtr pointer) => new CalendarClass { _pointer = pointer };
		public static explicit operator IntPtr(CalendarClass value) => value._pointer
;	}
	public ref struct CellAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellAccessiblePrivate(IntPtr pointer) => new CellAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellAccessiblePrivate value) => value._pointer
;	}
	public ref struct CellAccessible
	{
		private IntPtr _pointer;
		public static explicit operator CellAccessible(IntPtr pointer) => new CellAccessible { _pointer = pointer };
		public static explicit operator IntPtr(CellAccessible value) => value._pointer
;		public static implicit operator Gtk.Accessible(CellAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator CellAccessible(Gtk.Accessible value) => (CellAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(CellAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator CellAccessible(Atk.Object value) => (CellAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(CellAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator CellAccessible(GObject.Object value) => (CellAccessible)(IntPtr)value
;	}
	public ref struct CellAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator CellAccessibleClass(IntPtr pointer) => new CellAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(CellAccessibleClass value) => value._pointer
;	}
	public ref struct CellAccessibleParent
	{
		private IntPtr _pointer;
		public static explicit operator CellAccessibleParent(IntPtr pointer) => new CellAccessibleParent { _pointer = pointer };
		public static explicit operator IntPtr(CellAccessibleParent value) => value._pointer
;	}
	[Flags]
	public enum CellRendererState
	{
		selected = 1,
		prelit = 2,
		insensitive = 4,
		sorted = 8,
		focused = 16,
		expandable = 32,
		expanded = 64,
	}
	public ref struct CellAccessibleParentIface
	{
		private IntPtr _pointer;
		public static explicit operator CellAccessibleParentIface(IntPtr pointer) => new CellAccessibleParentIface { _pointer = pointer };
		public static explicit operator IntPtr(CellAccessibleParentIface value) => value._pointer
;	}
	public ref struct CellRenderer
	{
		private IntPtr _pointer;
		public static explicit operator CellRenderer(IntPtr pointer) => new CellRenderer { _pointer = pointer };
		public static explicit operator IntPtr(CellRenderer value) => value._pointer
;		public static implicit operator GObject.InitiallyUnowned(CellRenderer value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRenderer(GObject.InitiallyUnowned value) => (CellRenderer)(IntPtr)value
;		public static implicit operator GObject.Object(CellRenderer value) => (GObject.Object)value._pointer
;		public static explicit operator CellRenderer(GObject.Object value) => (CellRenderer)(IntPtr)value
;	}
	public ref struct CellArea
	{
		private IntPtr _pointer;
		public static explicit operator CellArea(IntPtr pointer) => new CellArea { _pointer = pointer };
		public static explicit operator IntPtr(CellArea value) => value._pointer
;		public static implicit operator GObject.InitiallyUnowned(CellArea value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellArea(GObject.InitiallyUnowned value) => (CellArea)(IntPtr)value
;		public static implicit operator GObject.Object(CellArea value) => (GObject.Object)value._pointer
;		public static explicit operator CellArea(GObject.Object value) => (CellArea)(IntPtr)value
;	}
	public ref struct CellAreaContext
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaContext(IntPtr pointer) => new CellAreaContext { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaContext value) => value._pointer
;		public static implicit operator GObject.Object(CellAreaContext value) => (GObject.Object)value._pointer
;		public static explicit operator CellAreaContext(GObject.Object value) => (CellAreaContext)(IntPtr)value
;	}
	public ref struct TreeModel
	{
		private IntPtr _pointer;
		public static explicit operator TreeModel(IntPtr pointer) => new TreeModel { _pointer = pointer };
		public static explicit operator IntPtr(TreeModel value) => value._pointer
;	}
	public ref struct TreeIter
	{
		private IntPtr _pointer;
		public static explicit operator TreeIter(IntPtr pointer) => new TreeIter { _pointer = pointer };
		public static explicit operator IntPtr(TreeIter value) => value._pointer
;	}
	public enum DirectionType
	{
		tab_forward = 0,
		tab_backward = 1,
		up = 2,
		down = 3,
		left = 4,
		right = 5,
	}
	public enum SizeRequestMode
	{
		height_for_width = 0,
		width_for_height = 1,
		constant_size = 2,
	}
	public ref struct CellAreaPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaPrivate(IntPtr pointer) => new CellAreaPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaPrivate value) => value._pointer
;	}
	public ref struct CellAreaBox
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaBox(IntPtr pointer) => new CellAreaBox { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaBox value) => value._pointer
;		public static implicit operator Gtk.CellArea(CellAreaBox value) => (Gtk.CellArea)value._pointer
;		public static explicit operator CellAreaBox(Gtk.CellArea value) => (CellAreaBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellAreaBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellAreaBox(GObject.InitiallyUnowned value) => (CellAreaBox)(IntPtr)value
;		public static implicit operator GObject.Object(CellAreaBox value) => (GObject.Object)value._pointer
;		public static explicit operator CellAreaBox(GObject.Object value) => (CellAreaBox)(IntPtr)value
;	}
	public ref struct CellAreaBoxPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaBoxPrivate(IntPtr pointer) => new CellAreaBoxPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaBoxPrivate value) => value._pointer
;	}
	public ref struct CellAreaClass
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaClass(IntPtr pointer) => new CellAreaClass { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaClass value) => value._pointer
;	}
	public ref struct CellAreaBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaBoxClass(IntPtr pointer) => new CellAreaBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaBoxClass value) => value._pointer
;	}
	public ref struct CellAreaContextPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaContextPrivate(IntPtr pointer) => new CellAreaContextPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaContextPrivate value) => value._pointer
;	}
	public ref struct CellAreaContextClass
	{
		private IntPtr _pointer;
		public static explicit operator CellAreaContextClass(IntPtr pointer) => new CellAreaContextClass { _pointer = pointer };
		public static explicit operator IntPtr(CellAreaContextClass value) => value._pointer
;	}
	public ref struct CellEditableIface
	{
		private IntPtr _pointer;
		public static explicit operator CellEditableIface(IntPtr pointer) => new CellEditableIface { _pointer = pointer };
		public static explicit operator IntPtr(CellEditableIface value) => value._pointer
;	}
	public ref struct CellLayoutIface
	{
		private IntPtr _pointer;
		public static explicit operator CellLayoutIface(IntPtr pointer) => new CellLayoutIface { _pointer = pointer };
		public static explicit operator IntPtr(CellLayoutIface value) => value._pointer
;	}
	public ref struct Requisition
	{
		private IntPtr _pointer;
		public static explicit operator Requisition(IntPtr pointer) => new Requisition { _pointer = pointer };
		public static explicit operator IntPtr(Requisition value) => value._pointer
;	}
	[Flags]
	public enum StateFlags
	{
		normal = 0,
		active = 1,
		prelight = 2,
		selected = 4,
		insensitive = 8,
		inconsistent = 16,
		focused = 32,
		backdrop = 64,
		dir_ltr = 128,
		dir_rtl = 256,
		link = 512,
		visited = 1024,
		@checked = 2048,
		drop_active = 4096,
	}
	public enum CellRendererMode
	{
		inert = 0,
		activatable = 1,
		editable = 2,
	}
	public ref struct CellRendererPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererPrivate(IntPtr pointer) => new CellRendererPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererPrivate value) => value._pointer
;	}
	public enum CellRendererAccelMode
	{
		gtk = 0,
		other = 1,
		modifier_tap = 2,
	}
	public ref struct CellRendererText
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererText(IntPtr pointer) => new CellRendererText { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererText value) => value._pointer
;		public static implicit operator Gtk.CellRenderer(CellRendererText value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererText(Gtk.CellRenderer value) => (CellRendererText)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererText value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererText(GObject.InitiallyUnowned value) => (CellRendererText)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererText value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererText(GObject.Object value) => (CellRendererText)(IntPtr)value
;	}
	public ref struct CellRendererAccelPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererAccelPrivate(IntPtr pointer) => new CellRendererAccelPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererAccelPrivate value) => value._pointer
;	}
	public ref struct CellRendererAccel
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererAccel(IntPtr pointer) => new CellRendererAccel { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererAccel value) => value._pointer
;		public static implicit operator Gtk.CellRendererText(CellRendererAccel value) => (Gtk.CellRendererText)value._pointer
;		public static explicit operator CellRendererAccel(Gtk.CellRendererText value) => (CellRendererAccel)(IntPtr)value
;		public static implicit operator Gtk.CellRenderer(CellRendererAccel value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererAccel(Gtk.CellRenderer value) => (CellRendererAccel)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererAccel value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererAccel(GObject.InitiallyUnowned value) => (CellRendererAccel)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererAccel value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererAccel(GObject.Object value) => (CellRendererAccel)(IntPtr)value
;	}
	public ref struct CellRendererTextClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererTextClass(IntPtr pointer) => new CellRendererTextClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererTextClass value) => value._pointer
;	}
	public ref struct CellRendererAccelClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererAccelClass(IntPtr pointer) => new CellRendererAccelClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererAccelClass value) => value._pointer
;	}
	public ref struct CellRendererClassPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererClassPrivate(IntPtr pointer) => new CellRendererClassPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererClassPrivate value) => value._pointer
;	}
	public ref struct CellRendererClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererClass(IntPtr pointer) => new CellRendererClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererClass value) => value._pointer
;	}
	public ref struct CellRendererComboPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererComboPrivate(IntPtr pointer) => new CellRendererComboPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererComboPrivate value) => value._pointer
;	}
	public ref struct CellRendererCombo
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererCombo(IntPtr pointer) => new CellRendererCombo { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererCombo value) => value._pointer
;		public static implicit operator Gtk.CellRendererText(CellRendererCombo value) => (Gtk.CellRendererText)value._pointer
;		public static explicit operator CellRendererCombo(Gtk.CellRendererText value) => (CellRendererCombo)(IntPtr)value
;		public static implicit operator Gtk.CellRenderer(CellRendererCombo value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererCombo(Gtk.CellRenderer value) => (CellRendererCombo)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererCombo value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererCombo(GObject.InitiallyUnowned value) => (CellRendererCombo)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererCombo value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererCombo(GObject.Object value) => (CellRendererCombo)(IntPtr)value
;	}
	public ref struct CellRendererComboClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererComboClass(IntPtr pointer) => new CellRendererComboClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererComboClass value) => value._pointer
;	}
	public ref struct CellRendererPixbufPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererPixbufPrivate(IntPtr pointer) => new CellRendererPixbufPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererPixbufPrivate value) => value._pointer
;	}
	public ref struct CellRendererPixbuf
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererPixbuf(IntPtr pointer) => new CellRendererPixbuf { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererPixbuf value) => value._pointer
;		public static implicit operator Gtk.CellRenderer(CellRendererPixbuf value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererPixbuf(Gtk.CellRenderer value) => (CellRendererPixbuf)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererPixbuf value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererPixbuf(GObject.InitiallyUnowned value) => (CellRendererPixbuf)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererPixbuf value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererPixbuf(GObject.Object value) => (CellRendererPixbuf)(IntPtr)value
;	}
	public ref struct CellRendererPixbufClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererPixbufClass(IntPtr pointer) => new CellRendererPixbufClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererPixbufClass value) => value._pointer
;	}
	public ref struct CellRendererProgressPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererProgressPrivate(IntPtr pointer) => new CellRendererProgressPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererProgressPrivate value) => value._pointer
;	}
	public ref struct CellRendererProgress
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererProgress(IntPtr pointer) => new CellRendererProgress { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererProgress value) => value._pointer
;		public static implicit operator Gtk.CellRenderer(CellRendererProgress value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererProgress(Gtk.CellRenderer value) => (CellRendererProgress)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererProgress value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererProgress(GObject.InitiallyUnowned value) => (CellRendererProgress)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererProgress value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererProgress(GObject.Object value) => (CellRendererProgress)(IntPtr)value
;	}
	public ref struct CellRendererProgressClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererProgressClass(IntPtr pointer) => new CellRendererProgressClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererProgressClass value) => value._pointer
;	}
	public ref struct CellRendererSpinPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererSpinPrivate(IntPtr pointer) => new CellRendererSpinPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererSpinPrivate value) => value._pointer
;	}
	public ref struct CellRendererSpin
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererSpin(IntPtr pointer) => new CellRendererSpin { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererSpin value) => value._pointer
;		public static implicit operator Gtk.CellRendererText(CellRendererSpin value) => (Gtk.CellRendererText)value._pointer
;		public static explicit operator CellRendererSpin(Gtk.CellRendererText value) => (CellRendererSpin)(IntPtr)value
;		public static implicit operator Gtk.CellRenderer(CellRendererSpin value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererSpin(Gtk.CellRenderer value) => (CellRendererSpin)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererSpin value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererSpin(GObject.InitiallyUnowned value) => (CellRendererSpin)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererSpin value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererSpin(GObject.Object value) => (CellRendererSpin)(IntPtr)value
;	}
	public ref struct CellRendererSpinClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererSpinClass(IntPtr pointer) => new CellRendererSpinClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererSpinClass value) => value._pointer
;	}
	public enum IconSize
	{
		invalid = 0,
		menu = 1,
		small_toolbar = 2,
		large_toolbar = 3,
		button = 4,
		dnd = 5,
		dialog = 6,
	}
	public ref struct CellRendererSpinnerPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererSpinnerPrivate(IntPtr pointer) => new CellRendererSpinnerPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererSpinnerPrivate value) => value._pointer
;	}
	public ref struct CellRendererSpinner
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererSpinner(IntPtr pointer) => new CellRendererSpinner { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererSpinner value) => value._pointer
;		public static implicit operator Gtk.CellRenderer(CellRendererSpinner value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererSpinner(Gtk.CellRenderer value) => (CellRendererSpinner)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererSpinner value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererSpinner(GObject.InitiallyUnowned value) => (CellRendererSpinner)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererSpinner value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererSpinner(GObject.Object value) => (CellRendererSpinner)(IntPtr)value
;	}
	public ref struct CellRendererSpinnerClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererSpinnerClass(IntPtr pointer) => new CellRendererSpinnerClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererSpinnerClass value) => value._pointer
;	}
	public ref struct CellRendererTextPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererTextPrivate(IntPtr pointer) => new CellRendererTextPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererTextPrivate value) => value._pointer
;	}
	public ref struct CellRendererToggle
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererToggle(IntPtr pointer) => new CellRendererToggle { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererToggle value) => value._pointer
;		public static implicit operator Gtk.CellRenderer(CellRendererToggle value) => (Gtk.CellRenderer)value._pointer
;		public static explicit operator CellRendererToggle(Gtk.CellRenderer value) => (CellRendererToggle)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellRendererToggle value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellRendererToggle(GObject.InitiallyUnowned value) => (CellRendererToggle)(IntPtr)value
;		public static implicit operator GObject.Object(CellRendererToggle value) => (GObject.Object)value._pointer
;		public static explicit operator CellRendererToggle(GObject.Object value) => (CellRendererToggle)(IntPtr)value
;	}
	public ref struct CellRendererTogglePrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererTogglePrivate(IntPtr pointer) => new CellRendererTogglePrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererTogglePrivate value) => value._pointer
;	}
	public ref struct CellRendererToggleClass
	{
		private IntPtr _pointer;
		public static explicit operator CellRendererToggleClass(IntPtr pointer) => new CellRendererToggleClass { _pointer = pointer };
		public static explicit operator IntPtr(CellRendererToggleClass value) => value._pointer
;	}
	public ref struct TreePath
	{
		private IntPtr _pointer;
		public static explicit operator TreePath(IntPtr pointer) => new TreePath { _pointer = pointer };
		public static explicit operator IntPtr(TreePath value) => value._pointer
;	}
	public ref struct CellView
	{
		private IntPtr _pointer;
		public static explicit operator CellView(IntPtr pointer) => new CellView { _pointer = pointer };
		public static explicit operator IntPtr(CellView value) => value._pointer
;		public static implicit operator Gtk.Widget(CellView value) => (Gtk.Widget)value._pointer
;		public static explicit operator CellView(Gtk.Widget value) => (CellView)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CellView value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CellView(GObject.InitiallyUnowned value) => (CellView)(IntPtr)value
;		public static implicit operator GObject.Object(CellView value) => (GObject.Object)value._pointer
;		public static explicit operator CellView(GObject.Object value) => (CellView)(IntPtr)value
;	}
	public ref struct CellViewPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CellViewPrivate(IntPtr pointer) => new CellViewPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CellViewPrivate value) => value._pointer
;	}
	public ref struct CellViewClass
	{
		private IntPtr _pointer;
		public static explicit operator CellViewClass(IntPtr pointer) => new CellViewClass { _pointer = pointer };
		public static explicit operator IntPtr(CellViewClass value) => value._pointer
;	}
	public ref struct ToggleButton
	{
		private IntPtr _pointer;
		public static explicit operator ToggleButton(IntPtr pointer) => new ToggleButton { _pointer = pointer };
		public static explicit operator IntPtr(ToggleButton value) => value._pointer
;		public static implicit operator Gtk.Button(ToggleButton value) => (Gtk.Button)value._pointer
;		public static explicit operator ToggleButton(Gtk.Button value) => (ToggleButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(ToggleButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator ToggleButton(Gtk.Bin value) => (ToggleButton)(IntPtr)value
;		public static implicit operator Gtk.Container(ToggleButton value) => (Gtk.Container)value._pointer
;		public static explicit operator ToggleButton(Gtk.Container value) => (ToggleButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(ToggleButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator ToggleButton(Gtk.Widget value) => (ToggleButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ToggleButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ToggleButton(GObject.InitiallyUnowned value) => (ToggleButton)(IntPtr)value
;		public static implicit operator GObject.Object(ToggleButton value) => (GObject.Object)value._pointer
;		public static explicit operator ToggleButton(GObject.Object value) => (ToggleButton)(IntPtr)value
;	}
	public ref struct CheckButton
	{
		private IntPtr _pointer;
		public static explicit operator CheckButton(IntPtr pointer) => new CheckButton { _pointer = pointer };
		public static explicit operator IntPtr(CheckButton value) => value._pointer
;		public static implicit operator Gtk.ToggleButton(CheckButton value) => (Gtk.ToggleButton)value._pointer
;		public static explicit operator CheckButton(Gtk.ToggleButton value) => (CheckButton)(IntPtr)value
;		public static implicit operator Gtk.Button(CheckButton value) => (Gtk.Button)value._pointer
;		public static explicit operator CheckButton(Gtk.Button value) => (CheckButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(CheckButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator CheckButton(Gtk.Bin value) => (CheckButton)(IntPtr)value
;		public static implicit operator Gtk.Container(CheckButton value) => (Gtk.Container)value._pointer
;		public static explicit operator CheckButton(Gtk.Container value) => (CheckButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(CheckButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator CheckButton(Gtk.Widget value) => (CheckButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CheckButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CheckButton(GObject.InitiallyUnowned value) => (CheckButton)(IntPtr)value
;		public static implicit operator GObject.Object(CheckButton value) => (GObject.Object)value._pointer
;		public static explicit operator CheckButton(GObject.Object value) => (CheckButton)(IntPtr)value
;	}
	public ref struct ToggleButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator ToggleButtonClass(IntPtr pointer) => new ToggleButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(ToggleButtonClass value) => value._pointer
;	}
	public ref struct CheckButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator CheckButtonClass(IntPtr pointer) => new CheckButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(CheckButtonClass value) => value._pointer
;	}
	public ref struct CheckMenuItem
	{
		private IntPtr _pointer;
		public static explicit operator CheckMenuItem(IntPtr pointer) => new CheckMenuItem { _pointer = pointer };
		public static explicit operator IntPtr(CheckMenuItem value) => value._pointer
;		public static implicit operator Gtk.MenuItem(CheckMenuItem value) => (Gtk.MenuItem)value._pointer
;		public static explicit operator CheckMenuItem(Gtk.MenuItem value) => (CheckMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Bin(CheckMenuItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator CheckMenuItem(Gtk.Bin value) => (CheckMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Container(CheckMenuItem value) => (Gtk.Container)value._pointer
;		public static explicit operator CheckMenuItem(Gtk.Container value) => (CheckMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(CheckMenuItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator CheckMenuItem(Gtk.Widget value) => (CheckMenuItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(CheckMenuItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator CheckMenuItem(GObject.InitiallyUnowned value) => (CheckMenuItem)(IntPtr)value
;		public static implicit operator GObject.Object(CheckMenuItem value) => (GObject.Object)value._pointer
;		public static explicit operator CheckMenuItem(GObject.Object value) => (CheckMenuItem)(IntPtr)value
;	}
	public ref struct MenuItem
	{
		private IntPtr _pointer;
		public static explicit operator MenuItem(IntPtr pointer) => new MenuItem { _pointer = pointer };
		public static explicit operator IntPtr(MenuItem value) => value._pointer
;		public static implicit operator Gtk.Bin(MenuItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator MenuItem(Gtk.Bin value) => (MenuItem)(IntPtr)value
;		public static implicit operator Gtk.Container(MenuItem value) => (Gtk.Container)value._pointer
;		public static explicit operator MenuItem(Gtk.Container value) => (MenuItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(MenuItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator MenuItem(Gtk.Widget value) => (MenuItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(MenuItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator MenuItem(GObject.InitiallyUnowned value) => (MenuItem)(IntPtr)value
;		public static implicit operator GObject.Object(MenuItem value) => (GObject.Object)value._pointer
;		public static explicit operator MenuItem(GObject.Object value) => (MenuItem)(IntPtr)value
;	}
	public ref struct CheckMenuItemPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CheckMenuItemPrivate(IntPtr pointer) => new CheckMenuItemPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CheckMenuItemPrivate value) => value._pointer
;	}
	public ref struct MenuItemAccessible
	{
		private IntPtr _pointer;
		public static explicit operator MenuItemAccessible(IntPtr pointer) => new MenuItemAccessible { _pointer = pointer };
		public static explicit operator IntPtr(MenuItemAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(MenuItemAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator MenuItemAccessible(Gtk.ContainerAccessible value) => (MenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(MenuItemAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator MenuItemAccessible(Gtk.WidgetAccessible value) => (MenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(MenuItemAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator MenuItemAccessible(Gtk.Accessible value) => (MenuItemAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(MenuItemAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator MenuItemAccessible(Atk.Object value) => (MenuItemAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(MenuItemAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator MenuItemAccessible(GObject.Object value) => (MenuItemAccessible)(IntPtr)value
;	}
	public ref struct CheckMenuItemAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator CheckMenuItemAccessiblePrivate(IntPtr pointer) => new CheckMenuItemAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(CheckMenuItemAccessiblePrivate value) => value._pointer
;	}
	public ref struct CheckMenuItemAccessible
	{
		private IntPtr _pointer;
		public static explicit operator CheckMenuItemAccessible(IntPtr pointer) => new CheckMenuItemAccessible { _pointer = pointer };
		public static explicit operator IntPtr(CheckMenuItemAccessible value) => value._pointer
;		public static implicit operator Gtk.MenuItemAccessible(CheckMenuItemAccessible value) => (Gtk.MenuItemAccessible)value._pointer
;		public static explicit operator CheckMenuItemAccessible(Gtk.MenuItemAccessible value) => (CheckMenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(CheckMenuItemAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator CheckMenuItemAccessible(Gtk.ContainerAccessible value) => (CheckMenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(CheckMenuItemAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator CheckMenuItemAccessible(Gtk.WidgetAccessible value) => (CheckMenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(CheckMenuItemAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator CheckMenuItemAccessible(Gtk.Accessible value) => (CheckMenuItemAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(CheckMenuItemAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator CheckMenuItemAccessible(Atk.Object value) => (CheckMenuItemAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(CheckMenuItemAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator CheckMenuItemAccessible(GObject.Object value) => (CheckMenuItemAccessible)(IntPtr)value
;	}
	public ref struct MenuItemAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuItemAccessibleClass(IntPtr pointer) => new MenuItemAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuItemAccessibleClass value) => value._pointer
;	}
	public ref struct CheckMenuItemAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator CheckMenuItemAccessibleClass(IntPtr pointer) => new CheckMenuItemAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(CheckMenuItemAccessibleClass value) => value._pointer
;	}
	public ref struct MenuItemClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuItemClass(IntPtr pointer) => new MenuItemClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuItemClass value) => value._pointer
;	}
	public ref struct CheckMenuItemClass
	{
		private IntPtr _pointer;
		public static explicit operator CheckMenuItemClass(IntPtr pointer) => new CheckMenuItemClass { _pointer = pointer };
		public static explicit operator IntPtr(CheckMenuItemClass value) => value._pointer
;	}
	public ref struct Clipboard
	{
		private IntPtr _pointer;
		public static explicit operator Clipboard(IntPtr pointer) => new Clipboard { _pointer = pointer };
		public static explicit operator IntPtr(Clipboard value) => value._pointer
;		public static implicit operator GObject.Object(Clipboard value) => (GObject.Object)value._pointer
;		public static explicit operator Clipboard(GObject.Object value) => (Clipboard)(IntPtr)value
;	}
	public ref struct TextBuffer
	{
		private IntPtr _pointer;
		public static explicit operator TextBuffer(IntPtr pointer) => new TextBuffer { _pointer = pointer };
		public static explicit operator IntPtr(TextBuffer value) => value._pointer
;		public static implicit operator GObject.Object(TextBuffer value) => (GObject.Object)value._pointer
;		public static explicit operator TextBuffer(GObject.Object value) => (TextBuffer)(IntPtr)value
;	}
	public ref struct TargetEntry
	{
		private IntPtr _pointer;
		public static explicit operator TargetEntry(IntPtr pointer) => new TargetEntry { _pointer = pointer };
		public static explicit operator IntPtr(TargetEntry value) => value._pointer
;	}
	public ref struct SelectionData
	{
		private IntPtr _pointer;
		public static explicit operator SelectionData(IntPtr pointer) => new SelectionData { _pointer = pointer };
		public static explicit operator IntPtr(SelectionData value) => value._pointer
;	}
	public ref struct ColorChooser
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooser(IntPtr pointer) => new ColorChooser { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooser value) => value._pointer
;	}
	public ref struct ColorButton
	{
		private IntPtr _pointer;
		public static explicit operator ColorButton(IntPtr pointer) => new ColorButton { _pointer = pointer };
		public static explicit operator IntPtr(ColorButton value) => value._pointer
;		public static implicit operator Gtk.Button(ColorButton value) => (Gtk.Button)value._pointer
;		public static explicit operator ColorButton(Gtk.Button value) => (ColorButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(ColorButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator ColorButton(Gtk.Bin value) => (ColorButton)(IntPtr)value
;		public static implicit operator Gtk.Container(ColorButton value) => (Gtk.Container)value._pointer
;		public static explicit operator ColorButton(Gtk.Container value) => (ColorButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(ColorButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator ColorButton(Gtk.Widget value) => (ColorButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ColorButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ColorButton(GObject.InitiallyUnowned value) => (ColorButton)(IntPtr)value
;		public static implicit operator GObject.Object(ColorButton value) => (GObject.Object)value._pointer
;		public static explicit operator ColorButton(GObject.Object value) => (ColorButton)(IntPtr)value
;	}
	public ref struct ColorButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ColorButtonPrivate(IntPtr pointer) => new ColorButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ColorButtonPrivate value) => value._pointer
;	}
	public ref struct ColorButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator ColorButtonClass(IntPtr pointer) => new ColorButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(ColorButtonClass value) => value._pointer
;	}
	public ref struct ColorChooserDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooserDialogPrivate(IntPtr pointer) => new ColorChooserDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooserDialogPrivate value) => value._pointer
;	}
	public ref struct ColorChooserDialog
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooserDialog(IntPtr pointer) => new ColorChooserDialog { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooserDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(ColorChooserDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator ColorChooserDialog(Gtk.Dialog value) => (ColorChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(ColorChooserDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator ColorChooserDialog(Gtk.Window value) => (ColorChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(ColorChooserDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator ColorChooserDialog(Gtk.Bin value) => (ColorChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(ColorChooserDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator ColorChooserDialog(Gtk.Container value) => (ColorChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(ColorChooserDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator ColorChooserDialog(Gtk.Widget value) => (ColorChooserDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ColorChooserDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ColorChooserDialog(GObject.InitiallyUnowned value) => (ColorChooserDialog)(IntPtr)value
;		public static implicit operator GObject.Object(ColorChooserDialog value) => (GObject.Object)value._pointer
;		public static explicit operator ColorChooserDialog(GObject.Object value) => (ColorChooserDialog)(IntPtr)value
;	}
	public ref struct ColorChooserDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooserDialogClass(IntPtr pointer) => new ColorChooserDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooserDialogClass value) => value._pointer
;	}
	public ref struct ColorChooserInterface
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooserInterface(IntPtr pointer) => new ColorChooserInterface { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooserInterface value) => value._pointer
;	}
	public ref struct ColorChooserWidgetPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooserWidgetPrivate(IntPtr pointer) => new ColorChooserWidgetPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooserWidgetPrivate value) => value._pointer
;	}
	public ref struct ColorChooserWidget
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooserWidget(IntPtr pointer) => new ColorChooserWidget { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooserWidget value) => value._pointer
;		public static implicit operator Gtk.Box(ColorChooserWidget value) => (Gtk.Box)value._pointer
;		public static explicit operator ColorChooserWidget(Gtk.Box value) => (ColorChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Container(ColorChooserWidget value) => (Gtk.Container)value._pointer
;		public static explicit operator ColorChooserWidget(Gtk.Container value) => (ColorChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Widget(ColorChooserWidget value) => (Gtk.Widget)value._pointer
;		public static explicit operator ColorChooserWidget(Gtk.Widget value) => (ColorChooserWidget)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ColorChooserWidget value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ColorChooserWidget(GObject.InitiallyUnowned value) => (ColorChooserWidget)(IntPtr)value
;		public static implicit operator GObject.Object(ColorChooserWidget value) => (GObject.Object)value._pointer
;		public static explicit operator ColorChooserWidget(GObject.Object value) => (ColorChooserWidget)(IntPtr)value
;	}
	public ref struct ColorChooserWidgetClass
	{
		private IntPtr _pointer;
		public static explicit operator ColorChooserWidgetClass(IntPtr pointer) => new ColorChooserWidgetClass { _pointer = pointer };
		public static explicit operator IntPtr(ColorChooserWidgetClass value) => value._pointer
;	}
	public ref struct ColorSelection
	{
		private IntPtr _pointer;
		public static explicit operator ColorSelection(IntPtr pointer) => new ColorSelection { _pointer = pointer };
		public static explicit operator IntPtr(ColorSelection value) => value._pointer
;		public static implicit operator Gtk.Box(ColorSelection value) => (Gtk.Box)value._pointer
;		public static explicit operator ColorSelection(Gtk.Box value) => (ColorSelection)(IntPtr)value
;		public static implicit operator Gtk.Container(ColorSelection value) => (Gtk.Container)value._pointer
;		public static explicit operator ColorSelection(Gtk.Container value) => (ColorSelection)(IntPtr)value
;		public static implicit operator Gtk.Widget(ColorSelection value) => (Gtk.Widget)value._pointer
;		public static explicit operator ColorSelection(Gtk.Widget value) => (ColorSelection)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ColorSelection value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ColorSelection(GObject.InitiallyUnowned value) => (ColorSelection)(IntPtr)value
;		public static implicit operator GObject.Object(ColorSelection value) => (GObject.Object)value._pointer
;		public static explicit operator ColorSelection(GObject.Object value) => (ColorSelection)(IntPtr)value
;	}
	public ref struct ColorSelectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ColorSelectionPrivate(IntPtr pointer) => new ColorSelectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ColorSelectionPrivate value) => value._pointer
;	}
	public ref struct ColorSelectionClass
	{
		private IntPtr _pointer;
		public static explicit operator ColorSelectionClass(IntPtr pointer) => new ColorSelectionClass { _pointer = pointer };
		public static explicit operator IntPtr(ColorSelectionClass value) => value._pointer
;	}
	public ref struct ColorSelectionDialog
	{
		private IntPtr _pointer;
		public static explicit operator ColorSelectionDialog(IntPtr pointer) => new ColorSelectionDialog { _pointer = pointer };
		public static explicit operator IntPtr(ColorSelectionDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(ColorSelectionDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator ColorSelectionDialog(Gtk.Dialog value) => (ColorSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(ColorSelectionDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator ColorSelectionDialog(Gtk.Window value) => (ColorSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(ColorSelectionDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator ColorSelectionDialog(Gtk.Bin value) => (ColorSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(ColorSelectionDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator ColorSelectionDialog(Gtk.Container value) => (ColorSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(ColorSelectionDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator ColorSelectionDialog(Gtk.Widget value) => (ColorSelectionDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ColorSelectionDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ColorSelectionDialog(GObject.InitiallyUnowned value) => (ColorSelectionDialog)(IntPtr)value
;		public static implicit operator GObject.Object(ColorSelectionDialog value) => (GObject.Object)value._pointer
;		public static explicit operator ColorSelectionDialog(GObject.Object value) => (ColorSelectionDialog)(IntPtr)value
;	}
	public ref struct ColorSelectionDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ColorSelectionDialogPrivate(IntPtr pointer) => new ColorSelectionDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ColorSelectionDialogPrivate value) => value._pointer
;	}
	public ref struct ColorSelectionDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator ColorSelectionDialogClass(IntPtr pointer) => new ColorSelectionDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(ColorSelectionDialogClass value) => value._pointer
;	}
	public enum SensitivityType
	{
		auto = 0,
		on = 1,
		off = 2,
	}
	public ref struct ComboBoxPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxPrivate(IntPtr pointer) => new ComboBoxPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxPrivate value) => value._pointer
;	}
	public ref struct ComboBoxAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxAccessiblePrivate(IntPtr pointer) => new ComboBoxAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxAccessiblePrivate value) => value._pointer
;	}
	public ref struct ComboBoxAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxAccessible(IntPtr pointer) => new ComboBoxAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(ComboBoxAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ComboBoxAccessible(Gtk.ContainerAccessible value) => (ComboBoxAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ComboBoxAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ComboBoxAccessible(Gtk.WidgetAccessible value) => (ComboBoxAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ComboBoxAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ComboBoxAccessible(Gtk.Accessible value) => (ComboBoxAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ComboBoxAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ComboBoxAccessible(Atk.Object value) => (ComboBoxAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ComboBoxAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ComboBoxAccessible(GObject.Object value) => (ComboBoxAccessible)(IntPtr)value
;	}
	public ref struct ComboBoxAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxAccessibleClass(IntPtr pointer) => new ComboBoxAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxAccessibleClass value) => value._pointer
;	}
	public ref struct ComboBoxText
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxText(IntPtr pointer) => new ComboBoxText { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxText value) => value._pointer
;		public static implicit operator Gtk.ComboBox(ComboBoxText value) => (Gtk.ComboBox)value._pointer
;		public static explicit operator ComboBoxText(Gtk.ComboBox value) => (ComboBoxText)(IntPtr)value
;		public static implicit operator Gtk.Bin(ComboBoxText value) => (Gtk.Bin)value._pointer
;		public static explicit operator ComboBoxText(Gtk.Bin value) => (ComboBoxText)(IntPtr)value
;		public static implicit operator Gtk.Container(ComboBoxText value) => (Gtk.Container)value._pointer
;		public static explicit operator ComboBoxText(Gtk.Container value) => (ComboBoxText)(IntPtr)value
;		public static implicit operator Gtk.Widget(ComboBoxText value) => (Gtk.Widget)value._pointer
;		public static explicit operator ComboBoxText(Gtk.Widget value) => (ComboBoxText)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ComboBoxText value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ComboBoxText(GObject.InitiallyUnowned value) => (ComboBoxText)(IntPtr)value
;		public static implicit operator GObject.Object(ComboBoxText value) => (GObject.Object)value._pointer
;		public static explicit operator ComboBoxText(GObject.Object value) => (ComboBoxText)(IntPtr)value
;	}
	public ref struct ComboBoxTextPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxTextPrivate(IntPtr pointer) => new ComboBoxTextPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxTextPrivate value) => value._pointer
;	}
	public ref struct ComboBoxTextClass
	{
		private IntPtr _pointer;
		public static explicit operator ComboBoxTextClass(IntPtr pointer) => new ComboBoxTextClass { _pointer = pointer };
		public static explicit operator IntPtr(ComboBoxTextClass value) => value._pointer
;	}
	public ref struct WidgetPath
	{
		private IntPtr _pointer;
		public static explicit operator WidgetPath(IntPtr pointer) => new WidgetPath { _pointer = pointer };
		public static explicit operator IntPtr(WidgetPath value) => value._pointer
;	}
	public enum ResizeMode
	{
		parent = 0,
		queue = 1,
		immediate = 2,
	}
	public ref struct ContainerPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ContainerPrivate(IntPtr pointer) => new ContainerPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ContainerPrivate value) => value._pointer
;	}
	public ref struct ContainerAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ContainerAccessiblePrivate(IntPtr pointer) => new ContainerAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ContainerAccessiblePrivate value) => value._pointer
;	}
	public ref struct ContainerCellAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ContainerCellAccessible(IntPtr pointer) => new ContainerCellAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ContainerCellAccessible value) => value._pointer
;		public static implicit operator Gtk.CellAccessible(ContainerCellAccessible value) => (Gtk.CellAccessible)value._pointer
;		public static explicit operator ContainerCellAccessible(Gtk.CellAccessible value) => (ContainerCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ContainerCellAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ContainerCellAccessible(Gtk.Accessible value) => (ContainerCellAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ContainerCellAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ContainerCellAccessible(Atk.Object value) => (ContainerCellAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ContainerCellAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ContainerCellAccessible(GObject.Object value) => (ContainerCellAccessible)(IntPtr)value
;	}
	public ref struct ContainerCellAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ContainerCellAccessiblePrivate(IntPtr pointer) => new ContainerCellAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ContainerCellAccessiblePrivate value) => value._pointer
;	}
	public ref struct ContainerCellAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ContainerCellAccessibleClass(IntPtr pointer) => new ContainerCellAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ContainerCellAccessibleClass value) => value._pointer
;	}
	public enum CornerType
	{
		top_left = 0,
		bottom_left = 1,
		top_right = 2,
		bottom_right = 3,
	}
	public ref struct StyleProvider
	{
		private IntPtr _pointer;
		public static explicit operator StyleProvider(IntPtr pointer) => new StyleProvider { _pointer = pointer };
		public static explicit operator IntPtr(StyleProvider value) => value._pointer
;	}
	public ref struct CssProvider
	{
		private IntPtr _pointer;
		public static explicit operator CssProvider(IntPtr pointer) => new CssProvider { _pointer = pointer };
		public static explicit operator IntPtr(CssProvider value) => value._pointer
;		public static implicit operator GObject.Object(CssProvider value) => (GObject.Object)value._pointer
;		public static explicit operator CssProvider(GObject.Object value) => (CssProvider)(IntPtr)value
;	}
	public ref struct CssProviderPrivate
	{
		private IntPtr _pointer;
		public static explicit operator CssProviderPrivate(IntPtr pointer) => new CssProviderPrivate { _pointer = pointer };
		public static explicit operator IntPtr(CssProviderPrivate value) => value._pointer
;	}
	public ref struct CssSection
	{
		private IntPtr _pointer;
		public static explicit operator CssSection(IntPtr pointer) => new CssSection { _pointer = pointer };
		public static explicit operator IntPtr(CssSection value) => value._pointer
;	}
	public ref struct CssProviderClass
	{
		private IntPtr _pointer;
		public static explicit operator CssProviderClass(IntPtr pointer) => new CssProviderClass { _pointer = pointer };
		public static explicit operator IntPtr(CssProviderClass value) => value._pointer
;	}
	public enum CssProviderError
	{
		failed = 0,
		syntax = 1,
		import = 2,
		name = 3,
		deprecated = 4,
		unknown_value = 5,
	}
	public enum CssSectionType
	{
		document = 0,
		import = 1,
		color_definition = 2,
		binding_set = 3,
		ruleset = 4,
		selector = 5,
		declaration = 6,
		value = 7,
		keyframes = 8,
	}
	[Flags]
	public enum DebugFlag
	{
		misc = 1,
		plugsocket = 2,
		text = 4,
		tree = 8,
		updates = 16,
		keybindings = 32,
		multihead = 64,
		modules = 128,
		geometry = 256,
		icontheme = 512,
		printing = 1024,
		builder = 2048,
		size_request = 4096,
		no_css_cache = 8192,
		baselines = 16384,
		pixel_cache = 32768,
		no_pixel_cache = 65536,
		interactive = 131072,
		touchscreen = 262144,
		actions = 524288,
		resize = 1048576,
		layout = 2097152,
	}
	public enum DeleteType
	{
		chars = 0,
		word_ends = 1,
		words = 2,
		display_lines = 3,
		display_line_ends = 4,
		paragraph_ends = 5,
		paragraphs = 6,
		whitespace = 7,
	}
	[Flags]
	public enum DestDefaults
	{
		motion = 1,
		highlight = 2,
		drop = 4,
		all = 7,
	}
	public ref struct DialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator DialogPrivate(IntPtr pointer) => new DialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(DialogPrivate value) => value._pointer
;	}
	public enum DragResult
	{
		success = 0,
		no_target = 1,
		user_cancelled = 2,
		timeout_expired = 3,
		grab_broken = 4,
		error = 5,
	}
	public ref struct DrawingArea
	{
		private IntPtr _pointer;
		public static explicit operator DrawingArea(IntPtr pointer) => new DrawingArea { _pointer = pointer };
		public static explicit operator IntPtr(DrawingArea value) => value._pointer
;		public static implicit operator Gtk.Widget(DrawingArea value) => (Gtk.Widget)value._pointer
;		public static explicit operator DrawingArea(Gtk.Widget value) => (DrawingArea)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(DrawingArea value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator DrawingArea(GObject.InitiallyUnowned value) => (DrawingArea)(IntPtr)value
;		public static implicit operator GObject.Object(DrawingArea value) => (GObject.Object)value._pointer
;		public static explicit operator DrawingArea(GObject.Object value) => (DrawingArea)(IntPtr)value
;	}
	public ref struct DrawingAreaClass
	{
		private IntPtr _pointer;
		public static explicit operator DrawingAreaClass(IntPtr pointer) => new DrawingAreaClass { _pointer = pointer };
		public static explicit operator IntPtr(DrawingAreaClass value) => value._pointer
;	}
	public ref struct Editable
	{
		private IntPtr _pointer;
		public static explicit operator Editable(IntPtr pointer) => new Editable { _pointer = pointer };
		public static explicit operator IntPtr(Editable value) => value._pointer
;	}
	public ref struct EditableInterface
	{
		private IntPtr _pointer;
		public static explicit operator EditableInterface(IntPtr pointer) => new EditableInterface { _pointer = pointer };
		public static explicit operator IntPtr(EditableInterface value) => value._pointer
;	}
	public ref struct EntryBuffer
	{
		private IntPtr _pointer;
		public static explicit operator EntryBuffer(IntPtr pointer) => new EntryBuffer { _pointer = pointer };
		public static explicit operator IntPtr(EntryBuffer value) => value._pointer
;		public static implicit operator GObject.Object(EntryBuffer value) => (GObject.Object)value._pointer
;		public static explicit operator EntryBuffer(GObject.Object value) => (EntryBuffer)(IntPtr)value
;	}
	public ref struct Entry
	{
		private IntPtr _pointer;
		public static explicit operator Entry(IntPtr pointer) => new Entry { _pointer = pointer };
		public static explicit operator IntPtr(Entry value) => value._pointer
;		public static implicit operator Gtk.Widget(Entry value) => (Gtk.Widget)value._pointer
;		public static explicit operator Entry(Gtk.Widget value) => (Entry)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Entry value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Entry(GObject.InitiallyUnowned value) => (Entry)(IntPtr)value
;		public static implicit operator GObject.Object(Entry value) => (GObject.Object)value._pointer
;		public static explicit operator Entry(GObject.Object value) => (Entry)(IntPtr)value
;	}
	public ref struct EntryCompletion
	{
		private IntPtr _pointer;
		public static explicit operator EntryCompletion(IntPtr pointer) => new EntryCompletion { _pointer = pointer };
		public static explicit operator IntPtr(EntryCompletion value) => value._pointer
;		public static implicit operator GObject.Object(EntryCompletion value) => (GObject.Object)value._pointer
;		public static explicit operator EntryCompletion(GObject.Object value) => (EntryCompletion)(IntPtr)value
;	}
	public enum EntryIconPosition
	{
		primary = 0,
		secondary = 1,
	}
	public enum ImageType
	{
		empty = 0,
		pixbuf = 1,
		stock = 2,
		icon_set = 3,
		animation = 4,
		icon_name = 5,
		gicon = 6,
		surface = 7,
	}
	[Flags]
	public enum InputHints
	{
		none = 0,
		spellcheck = 1,
		no_spellcheck = 2,
		word_completion = 4,
		lowercase = 8,
		uppercase_chars = 16,
		uppercase_words = 32,
		uppercase_sentences = 64,
		inhibit_osk = 128,
		vertical_writing = 256,
		emoji = 512,
		no_emoji = 1024,
	}
	public enum InputPurpose
	{
		free_form = 0,
		alpha = 1,
		digits = 2,
		number = 3,
		phone = 4,
		url = 5,
		email = 6,
		name = 7,
		password = 8,
		pin = 9,
	}
	public ref struct TargetList
	{
		private IntPtr _pointer;
		public static explicit operator TargetList(IntPtr pointer) => new TargetList { _pointer = pointer };
		public static explicit operator IntPtr(TargetList value) => value._pointer
;	}
	public ref struct EntryPrivate
	{
		private IntPtr _pointer;
		public static explicit operator EntryPrivate(IntPtr pointer) => new EntryPrivate { _pointer = pointer };
		public static explicit operator IntPtr(EntryPrivate value) => value._pointer
;	}
	public ref struct EntryAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator EntryAccessiblePrivate(IntPtr pointer) => new EntryAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(EntryAccessiblePrivate value) => value._pointer
;	}
	public ref struct EntryAccessible
	{
		private IntPtr _pointer;
		public static explicit operator EntryAccessible(IntPtr pointer) => new EntryAccessible { _pointer = pointer };
		public static explicit operator IntPtr(EntryAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(EntryAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator EntryAccessible(Gtk.WidgetAccessible value) => (EntryAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(EntryAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator EntryAccessible(Gtk.Accessible value) => (EntryAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(EntryAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator EntryAccessible(Atk.Object value) => (EntryAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(EntryAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator EntryAccessible(GObject.Object value) => (EntryAccessible)(IntPtr)value
;	}
	public ref struct EntryAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator EntryAccessibleClass(IntPtr pointer) => new EntryAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(EntryAccessibleClass value) => value._pointer
;	}
	public ref struct EntryBufferPrivate
	{
		private IntPtr _pointer;
		public static explicit operator EntryBufferPrivate(IntPtr pointer) => new EntryBufferPrivate { _pointer = pointer };
		public static explicit operator IntPtr(EntryBufferPrivate value) => value._pointer
;	}
	public ref struct EntryBufferClass
	{
		private IntPtr _pointer;
		public static explicit operator EntryBufferClass(IntPtr pointer) => new EntryBufferClass { _pointer = pointer };
		public static explicit operator IntPtr(EntryBufferClass value) => value._pointer
;	}
	public enum MovementStep
	{
		logical_positions = 0,
		visual_positions = 1,
		words = 2,
		display_lines = 3,
		display_line_ends = 4,
		paragraphs = 5,
		paragraph_ends = 6,
		pages = 7,
		buffer_ends = 8,
		horizontal_pages = 9,
	}
	public ref struct EntryClass
	{
		private IntPtr _pointer;
		public static explicit operator EntryClass(IntPtr pointer) => new EntryClass { _pointer = pointer };
		public static explicit operator IntPtr(EntryClass value) => value._pointer
;	}
	public ref struct EntryCompletionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator EntryCompletionPrivate(IntPtr pointer) => new EntryCompletionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(EntryCompletionPrivate value) => value._pointer
;	}
	public ref struct EntryCompletionClass
	{
		private IntPtr _pointer;
		public static explicit operator EntryCompletionClass(IntPtr pointer) => new EntryCompletionClass { _pointer = pointer };
		public static explicit operator IntPtr(EntryCompletionClass value) => value._pointer
;	}
	public ref struct EntryIconAccessible
	{
		private IntPtr _pointer;
		public static explicit operator EntryIconAccessible(IntPtr pointer) => new EntryIconAccessible { _pointer = pointer };
		public static explicit operator IntPtr(EntryIconAccessible value) => value._pointer
;		public static implicit operator Atk.Object(EntryIconAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator EntryIconAccessible(Atk.Object value) => (EntryIconAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(EntryIconAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator EntryIconAccessible(GObject.Object value) => (EntryIconAccessible)(IntPtr)value
;	}
	public ref struct EventBox
	{
		private IntPtr _pointer;
		public static explicit operator EventBox(IntPtr pointer) => new EventBox { _pointer = pointer };
		public static explicit operator IntPtr(EventBox value) => value._pointer
;		public static implicit operator Gtk.Bin(EventBox value) => (Gtk.Bin)value._pointer
;		public static explicit operator EventBox(Gtk.Bin value) => (EventBox)(IntPtr)value
;		public static implicit operator Gtk.Container(EventBox value) => (Gtk.Container)value._pointer
;		public static explicit operator EventBox(Gtk.Container value) => (EventBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(EventBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator EventBox(Gtk.Widget value) => (EventBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(EventBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator EventBox(GObject.InitiallyUnowned value) => (EventBox)(IntPtr)value
;		public static implicit operator GObject.Object(EventBox value) => (GObject.Object)value._pointer
;		public static explicit operator EventBox(GObject.Object value) => (EventBox)(IntPtr)value
;	}
	public ref struct EventBoxPrivate
	{
		private IntPtr _pointer;
		public static explicit operator EventBoxPrivate(IntPtr pointer) => new EventBoxPrivate { _pointer = pointer };
		public static explicit operator IntPtr(EventBoxPrivate value) => value._pointer
;	}
	public ref struct EventBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator EventBoxClass(IntPtr pointer) => new EventBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(EventBoxClass value) => value._pointer
;	}
	public enum PropagationPhase
	{
		none = 0,
		capture = 1,
		bubble = 2,
		target = 3,
	}
	public ref struct EventController
	{
		private IntPtr _pointer;
		public static explicit operator EventController(IntPtr pointer) => new EventController { _pointer = pointer };
		public static explicit operator IntPtr(EventController value) => value._pointer
;		public static implicit operator GObject.Object(EventController value) => (GObject.Object)value._pointer
;		public static explicit operator EventController(GObject.Object value) => (EventController)(IntPtr)value
;	}
	public ref struct EventControllerClass
	{
		private IntPtr _pointer;
		public static explicit operator EventControllerClass(IntPtr pointer) => new EventControllerClass { _pointer = pointer };
		public static explicit operator IntPtr(EventControllerClass value) => value._pointer
;	}
	public enum EventSequenceState
	{
		none = 0,
		claimed = 1,
		denied = 2,
	}
	public ref struct Expander
	{
		private IntPtr _pointer;
		public static explicit operator Expander(IntPtr pointer) => new Expander { _pointer = pointer };
		public static explicit operator IntPtr(Expander value) => value._pointer
;		public static implicit operator Gtk.Bin(Expander value) => (Gtk.Bin)value._pointer
;		public static explicit operator Expander(Gtk.Bin value) => (Expander)(IntPtr)value
;		public static implicit operator Gtk.Container(Expander value) => (Gtk.Container)value._pointer
;		public static explicit operator Expander(Gtk.Container value) => (Expander)(IntPtr)value
;		public static implicit operator Gtk.Widget(Expander value) => (Gtk.Widget)value._pointer
;		public static explicit operator Expander(Gtk.Widget value) => (Expander)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Expander value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Expander(GObject.InitiallyUnowned value) => (Expander)(IntPtr)value
;		public static implicit operator GObject.Object(Expander value) => (GObject.Object)value._pointer
;		public static explicit operator Expander(GObject.Object value) => (Expander)(IntPtr)value
;	}
	public ref struct ExpanderPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ExpanderPrivate(IntPtr pointer) => new ExpanderPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ExpanderPrivate value) => value._pointer
;	}
	public ref struct ExpanderAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ExpanderAccessiblePrivate(IntPtr pointer) => new ExpanderAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ExpanderAccessiblePrivate value) => value._pointer
;	}
	public ref struct ExpanderAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ExpanderAccessible(IntPtr pointer) => new ExpanderAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ExpanderAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(ExpanderAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ExpanderAccessible(Gtk.ContainerAccessible value) => (ExpanderAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ExpanderAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ExpanderAccessible(Gtk.WidgetAccessible value) => (ExpanderAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ExpanderAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ExpanderAccessible(Gtk.Accessible value) => (ExpanderAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ExpanderAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ExpanderAccessible(Atk.Object value) => (ExpanderAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ExpanderAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ExpanderAccessible(GObject.Object value) => (ExpanderAccessible)(IntPtr)value
;	}
	public ref struct ExpanderAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ExpanderAccessibleClass(IntPtr pointer) => new ExpanderAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ExpanderAccessibleClass value) => value._pointer
;	}
	public ref struct ExpanderClass
	{
		private IntPtr _pointer;
		public static explicit operator ExpanderClass(IntPtr pointer) => new ExpanderClass { _pointer = pointer };
		public static explicit operator IntPtr(ExpanderClass value) => value._pointer
;	}
	public enum ExpanderStyle
	{
		collapsed = 0,
		semi_collapsed = 1,
		semi_expanded = 2,
		expanded = 3,
	}
	public ref struct FileChooser
	{
		private IntPtr _pointer;
		public static explicit operator FileChooser(IntPtr pointer) => new FileChooser { _pointer = pointer };
		public static explicit operator IntPtr(FileChooser value) => value._pointer
;	}
	public ref struct FileFilter
	{
		private IntPtr _pointer;
		public static explicit operator FileFilter(IntPtr pointer) => new FileFilter { _pointer = pointer };
		public static explicit operator IntPtr(FileFilter value) => value._pointer
;		public static implicit operator GObject.InitiallyUnowned(FileFilter value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FileFilter(GObject.InitiallyUnowned value) => (FileFilter)(IntPtr)value
;		public static implicit operator GObject.Object(FileFilter value) => (GObject.Object)value._pointer
;		public static explicit operator FileFilter(GObject.Object value) => (FileFilter)(IntPtr)value
;	}
	public enum FileChooserAction
	{
		open = 0,
		save = 1,
		select_folder = 2,
		create_folder = 3,
	}
	public ref struct FileChooserButton
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserButton(IntPtr pointer) => new FileChooserButton { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserButton value) => value._pointer
;		public static implicit operator Gtk.Box(FileChooserButton value) => (Gtk.Box)value._pointer
;		public static explicit operator FileChooserButton(Gtk.Box value) => (FileChooserButton)(IntPtr)value
;		public static implicit operator Gtk.Container(FileChooserButton value) => (Gtk.Container)value._pointer
;		public static explicit operator FileChooserButton(Gtk.Container value) => (FileChooserButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(FileChooserButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator FileChooserButton(Gtk.Widget value) => (FileChooserButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FileChooserButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FileChooserButton(GObject.InitiallyUnowned value) => (FileChooserButton)(IntPtr)value
;		public static implicit operator GObject.Object(FileChooserButton value) => (GObject.Object)value._pointer
;		public static explicit operator FileChooserButton(GObject.Object value) => (FileChooserButton)(IntPtr)value
;	}
	public ref struct FileChooserButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserButtonPrivate(IntPtr pointer) => new FileChooserButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserButtonPrivate value) => value._pointer
;	}
	public ref struct FileChooserButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserButtonClass(IntPtr pointer) => new FileChooserButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserButtonClass value) => value._pointer
;	}
	public enum FileChooserConfirmation
	{
		confirm = 0,
		accept_filename = 1,
		select_again = 2,
	}
	public ref struct FileChooserDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserDialogPrivate(IntPtr pointer) => new FileChooserDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserDialogPrivate value) => value._pointer
;	}
	public ref struct FileChooserDialog
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserDialog(IntPtr pointer) => new FileChooserDialog { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(FileChooserDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator FileChooserDialog(Gtk.Dialog value) => (FileChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(FileChooserDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator FileChooserDialog(Gtk.Window value) => (FileChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(FileChooserDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator FileChooserDialog(Gtk.Bin value) => (FileChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(FileChooserDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator FileChooserDialog(Gtk.Container value) => (FileChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(FileChooserDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator FileChooserDialog(Gtk.Widget value) => (FileChooserDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FileChooserDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FileChooserDialog(GObject.InitiallyUnowned value) => (FileChooserDialog)(IntPtr)value
;		public static implicit operator GObject.Object(FileChooserDialog value) => (GObject.Object)value._pointer
;		public static explicit operator FileChooserDialog(GObject.Object value) => (FileChooserDialog)(IntPtr)value
;	}
	public ref struct FileChooserDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserDialogClass(IntPtr pointer) => new FileChooserDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserDialogClass value) => value._pointer
;	}
	public enum FileChooserError
	{
		nonexistent = 0,
		bad_filename = 1,
		already_exists = 2,
		incomplete_hostname = 3,
	}
	public ref struct FileChooserNative
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserNative(IntPtr pointer) => new FileChooserNative { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserNative value) => value._pointer
;		public static implicit operator Gtk.NativeDialog(FileChooserNative value) => (Gtk.NativeDialog)value._pointer
;		public static explicit operator FileChooserNative(Gtk.NativeDialog value) => (FileChooserNative)(IntPtr)value
;		public static implicit operator GObject.Object(FileChooserNative value) => (GObject.Object)value._pointer
;		public static explicit operator FileChooserNative(GObject.Object value) => (FileChooserNative)(IntPtr)value
;	}
	public ref struct NativeDialog
	{
		private IntPtr _pointer;
		public static explicit operator NativeDialog(IntPtr pointer) => new NativeDialog { _pointer = pointer };
		public static explicit operator IntPtr(NativeDialog value) => value._pointer
;		public static implicit operator GObject.Object(NativeDialog value) => (GObject.Object)value._pointer
;		public static explicit operator NativeDialog(GObject.Object value) => (NativeDialog)(IntPtr)value
;	}
	public ref struct NativeDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator NativeDialogClass(IntPtr pointer) => new NativeDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(NativeDialogClass value) => value._pointer
;	}
	public ref struct FileChooserNativeClass
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserNativeClass(IntPtr pointer) => new FileChooserNativeClass { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserNativeClass value) => value._pointer
;	}
	public ref struct FileChooserWidgetPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserWidgetPrivate(IntPtr pointer) => new FileChooserWidgetPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserWidgetPrivate value) => value._pointer
;	}
	public ref struct FileChooserWidget
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserWidget(IntPtr pointer) => new FileChooserWidget { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserWidget value) => value._pointer
;		public static implicit operator Gtk.Box(FileChooserWidget value) => (Gtk.Box)value._pointer
;		public static explicit operator FileChooserWidget(Gtk.Box value) => (FileChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Container(FileChooserWidget value) => (Gtk.Container)value._pointer
;		public static explicit operator FileChooserWidget(Gtk.Container value) => (FileChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Widget(FileChooserWidget value) => (Gtk.Widget)value._pointer
;		public static explicit operator FileChooserWidget(Gtk.Widget value) => (FileChooserWidget)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FileChooserWidget value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FileChooserWidget(GObject.InitiallyUnowned value) => (FileChooserWidget)(IntPtr)value
;		public static implicit operator GObject.Object(FileChooserWidget value) => (GObject.Object)value._pointer
;		public static explicit operator FileChooserWidget(GObject.Object value) => (FileChooserWidget)(IntPtr)value
;	}
	public ref struct FileChooserWidgetClass
	{
		private IntPtr _pointer;
		public static explicit operator FileChooserWidgetClass(IntPtr pointer) => new FileChooserWidgetClass { _pointer = pointer };
		public static explicit operator IntPtr(FileChooserWidgetClass value) => value._pointer
;	}
	[Flags]
	public enum FileFilterFlags
	{
		filename = 1,
		uri = 2,
		display_name = 4,
		mime_type = 8,
	}
	public ref struct FileFilterInfo
	{
		private IntPtr _pointer;
		public static explicit operator FileFilterInfo(IntPtr pointer) => new FileFilterInfo { _pointer = pointer };
		public static explicit operator IntPtr(FileFilterInfo value) => value._pointer
;	}
	public ref struct Fixed
	{
		private IntPtr _pointer;
		public static explicit operator Fixed(IntPtr pointer) => new Fixed { _pointer = pointer };
		public static explicit operator IntPtr(Fixed value) => value._pointer
;		public static implicit operator Gtk.Container(Fixed value) => (Gtk.Container)value._pointer
;		public static explicit operator Fixed(Gtk.Container value) => (Fixed)(IntPtr)value
;		public static implicit operator Gtk.Widget(Fixed value) => (Gtk.Widget)value._pointer
;		public static explicit operator Fixed(Gtk.Widget value) => (Fixed)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Fixed value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Fixed(GObject.InitiallyUnowned value) => (Fixed)(IntPtr)value
;		public static implicit operator GObject.Object(Fixed value) => (GObject.Object)value._pointer
;		public static explicit operator Fixed(GObject.Object value) => (Fixed)(IntPtr)value
;	}
	public ref struct FixedPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FixedPrivate(IntPtr pointer) => new FixedPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FixedPrivate value) => value._pointer
;	}
	public ref struct FixedChild
	{
		private IntPtr _pointer;
		public static explicit operator FixedChild(IntPtr pointer) => new FixedChild { _pointer = pointer };
		public static explicit operator IntPtr(FixedChild value) => value._pointer
;	}
	public ref struct FixedClass
	{
		private IntPtr _pointer;
		public static explicit operator FixedClass(IntPtr pointer) => new FixedClass { _pointer = pointer };
		public static explicit operator IntPtr(FixedClass value) => value._pointer
;	}
	public ref struct FlowBox
	{
		private IntPtr _pointer;
		public static explicit operator FlowBox(IntPtr pointer) => new FlowBox { _pointer = pointer };
		public static explicit operator IntPtr(FlowBox value) => value._pointer
;		public static implicit operator Gtk.Container(FlowBox value) => (Gtk.Container)value._pointer
;		public static explicit operator FlowBox(Gtk.Container value) => (FlowBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(FlowBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator FlowBox(Gtk.Widget value) => (FlowBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FlowBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FlowBox(GObject.InitiallyUnowned value) => (FlowBox)(IntPtr)value
;		public static implicit operator GObject.Object(FlowBox value) => (GObject.Object)value._pointer
;		public static explicit operator FlowBox(GObject.Object value) => (FlowBox)(IntPtr)value
;	}
	public ref struct FlowBoxChild
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxChild(IntPtr pointer) => new FlowBoxChild { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxChild value) => value._pointer
;		public static implicit operator Gtk.Bin(FlowBoxChild value) => (Gtk.Bin)value._pointer
;		public static explicit operator FlowBoxChild(Gtk.Bin value) => (FlowBoxChild)(IntPtr)value
;		public static implicit operator Gtk.Container(FlowBoxChild value) => (Gtk.Container)value._pointer
;		public static explicit operator FlowBoxChild(Gtk.Container value) => (FlowBoxChild)(IntPtr)value
;		public static implicit operator Gtk.Widget(FlowBoxChild value) => (Gtk.Widget)value._pointer
;		public static explicit operator FlowBoxChild(Gtk.Widget value) => (FlowBoxChild)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FlowBoxChild value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FlowBoxChild(GObject.InitiallyUnowned value) => (FlowBoxChild)(IntPtr)value
;		public static implicit operator GObject.Object(FlowBoxChild value) => (GObject.Object)value._pointer
;		public static explicit operator FlowBoxChild(GObject.Object value) => (FlowBoxChild)(IntPtr)value
;	}
	public enum SelectionMode
	{
		none = 0,
		single = 1,
		browse = 2,
		multiple = 3,
	}
	public ref struct FlowBoxAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxAccessiblePrivate(IntPtr pointer) => new FlowBoxAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxAccessiblePrivate value) => value._pointer
;	}
	public ref struct FlowBoxAccessible
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxAccessible(IntPtr pointer) => new FlowBoxAccessible { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(FlowBoxAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator FlowBoxAccessible(Gtk.ContainerAccessible value) => (FlowBoxAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(FlowBoxAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator FlowBoxAccessible(Gtk.WidgetAccessible value) => (FlowBoxAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(FlowBoxAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator FlowBoxAccessible(Gtk.Accessible value) => (FlowBoxAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(FlowBoxAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator FlowBoxAccessible(Atk.Object value) => (FlowBoxAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(FlowBoxAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator FlowBoxAccessible(GObject.Object value) => (FlowBoxAccessible)(IntPtr)value
;	}
	public ref struct FlowBoxAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxAccessibleClass(IntPtr pointer) => new FlowBoxAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxAccessibleClass value) => value._pointer
;	}
	public ref struct FlowBoxChildAccessible
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxChildAccessible(IntPtr pointer) => new FlowBoxChildAccessible { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxChildAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(FlowBoxChildAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator FlowBoxChildAccessible(Gtk.ContainerAccessible value) => (FlowBoxChildAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(FlowBoxChildAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator FlowBoxChildAccessible(Gtk.WidgetAccessible value) => (FlowBoxChildAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(FlowBoxChildAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator FlowBoxChildAccessible(Gtk.Accessible value) => (FlowBoxChildAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(FlowBoxChildAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator FlowBoxChildAccessible(Atk.Object value) => (FlowBoxChildAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(FlowBoxChildAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator FlowBoxChildAccessible(GObject.Object value) => (FlowBoxChildAccessible)(IntPtr)value
;	}
	public ref struct FlowBoxChildAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxChildAccessibleClass(IntPtr pointer) => new FlowBoxChildAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxChildAccessibleClass value) => value._pointer
;	}
	public ref struct FlowBoxChildClass
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxChildClass(IntPtr pointer) => new FlowBoxChildClass { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxChildClass value) => value._pointer
;	}
	public ref struct FlowBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator FlowBoxClass(IntPtr pointer) => new FlowBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(FlowBoxClass value) => value._pointer
;	}
	public ref struct FontChooser
	{
		private IntPtr _pointer;
		public static explicit operator FontChooser(IntPtr pointer) => new FontChooser { _pointer = pointer };
		public static explicit operator IntPtr(FontChooser value) => value._pointer
;	}
	public ref struct FontButton
	{
		private IntPtr _pointer;
		public static explicit operator FontButton(IntPtr pointer) => new FontButton { _pointer = pointer };
		public static explicit operator IntPtr(FontButton value) => value._pointer
;		public static implicit operator Gtk.Button(FontButton value) => (Gtk.Button)value._pointer
;		public static explicit operator FontButton(Gtk.Button value) => (FontButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(FontButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator FontButton(Gtk.Bin value) => (FontButton)(IntPtr)value
;		public static implicit operator Gtk.Container(FontButton value) => (Gtk.Container)value._pointer
;		public static explicit operator FontButton(Gtk.Container value) => (FontButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(FontButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator FontButton(Gtk.Widget value) => (FontButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FontButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FontButton(GObject.InitiallyUnowned value) => (FontButton)(IntPtr)value
;		public static implicit operator GObject.Object(FontButton value) => (GObject.Object)value._pointer
;		public static explicit operator FontButton(GObject.Object value) => (FontButton)(IntPtr)value
;	}
	public ref struct FontButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FontButtonPrivate(IntPtr pointer) => new FontButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FontButtonPrivate value) => value._pointer
;	}
	public ref struct FontButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator FontButtonClass(IntPtr pointer) => new FontButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(FontButtonClass value) => value._pointer
;	}
	public ref struct FontChooserDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FontChooserDialogPrivate(IntPtr pointer) => new FontChooserDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FontChooserDialogPrivate value) => value._pointer
;	}
	public ref struct FontChooserDialog
	{
		private IntPtr _pointer;
		public static explicit operator FontChooserDialog(IntPtr pointer) => new FontChooserDialog { _pointer = pointer };
		public static explicit operator IntPtr(FontChooserDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(FontChooserDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator FontChooserDialog(Gtk.Dialog value) => (FontChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(FontChooserDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator FontChooserDialog(Gtk.Window value) => (FontChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(FontChooserDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator FontChooserDialog(Gtk.Bin value) => (FontChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(FontChooserDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator FontChooserDialog(Gtk.Container value) => (FontChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(FontChooserDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator FontChooserDialog(Gtk.Widget value) => (FontChooserDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FontChooserDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FontChooserDialog(GObject.InitiallyUnowned value) => (FontChooserDialog)(IntPtr)value
;		public static implicit operator GObject.Object(FontChooserDialog value) => (GObject.Object)value._pointer
;		public static explicit operator FontChooserDialog(GObject.Object value) => (FontChooserDialog)(IntPtr)value
;	}
	public ref struct FontChooserDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator FontChooserDialogClass(IntPtr pointer) => new FontChooserDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(FontChooserDialogClass value) => value._pointer
;	}
	public ref struct FontChooserIface
	{
		private IntPtr _pointer;
		public static explicit operator FontChooserIface(IntPtr pointer) => new FontChooserIface { _pointer = pointer };
		public static explicit operator IntPtr(FontChooserIface value) => value._pointer
;	}
	public ref struct FontChooserWidgetPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FontChooserWidgetPrivate(IntPtr pointer) => new FontChooserWidgetPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FontChooserWidgetPrivate value) => value._pointer
;	}
	public ref struct FontChooserWidget
	{
		private IntPtr _pointer;
		public static explicit operator FontChooserWidget(IntPtr pointer) => new FontChooserWidget { _pointer = pointer };
		public static explicit operator IntPtr(FontChooserWidget value) => value._pointer
;		public static implicit operator Gtk.Box(FontChooserWidget value) => (Gtk.Box)value._pointer
;		public static explicit operator FontChooserWidget(Gtk.Box value) => (FontChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Container(FontChooserWidget value) => (Gtk.Container)value._pointer
;		public static explicit operator FontChooserWidget(Gtk.Container value) => (FontChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Widget(FontChooserWidget value) => (Gtk.Widget)value._pointer
;		public static explicit operator FontChooserWidget(Gtk.Widget value) => (FontChooserWidget)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FontChooserWidget value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FontChooserWidget(GObject.InitiallyUnowned value) => (FontChooserWidget)(IntPtr)value
;		public static implicit operator GObject.Object(FontChooserWidget value) => (GObject.Object)value._pointer
;		public static explicit operator FontChooserWidget(GObject.Object value) => (FontChooserWidget)(IntPtr)value
;	}
	public ref struct FontChooserWidgetClass
	{
		private IntPtr _pointer;
		public static explicit operator FontChooserWidgetClass(IntPtr pointer) => new FontChooserWidgetClass { _pointer = pointer };
		public static explicit operator IntPtr(FontChooserWidgetClass value) => value._pointer
;	}
	public ref struct FontSelection
	{
		private IntPtr _pointer;
		public static explicit operator FontSelection(IntPtr pointer) => new FontSelection { _pointer = pointer };
		public static explicit operator IntPtr(FontSelection value) => value._pointer
;		public static implicit operator Gtk.Box(FontSelection value) => (Gtk.Box)value._pointer
;		public static explicit operator FontSelection(Gtk.Box value) => (FontSelection)(IntPtr)value
;		public static implicit operator Gtk.Container(FontSelection value) => (Gtk.Container)value._pointer
;		public static explicit operator FontSelection(Gtk.Container value) => (FontSelection)(IntPtr)value
;		public static implicit operator Gtk.Widget(FontSelection value) => (Gtk.Widget)value._pointer
;		public static explicit operator FontSelection(Gtk.Widget value) => (FontSelection)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FontSelection value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FontSelection(GObject.InitiallyUnowned value) => (FontSelection)(IntPtr)value
;		public static implicit operator GObject.Object(FontSelection value) => (GObject.Object)value._pointer
;		public static explicit operator FontSelection(GObject.Object value) => (FontSelection)(IntPtr)value
;	}
	public ref struct FontSelectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FontSelectionPrivate(IntPtr pointer) => new FontSelectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FontSelectionPrivate value) => value._pointer
;	}
	public ref struct FontSelectionClass
	{
		private IntPtr _pointer;
		public static explicit operator FontSelectionClass(IntPtr pointer) => new FontSelectionClass { _pointer = pointer };
		public static explicit operator IntPtr(FontSelectionClass value) => value._pointer
;	}
	public ref struct FontSelectionDialog
	{
		private IntPtr _pointer;
		public static explicit operator FontSelectionDialog(IntPtr pointer) => new FontSelectionDialog { _pointer = pointer };
		public static explicit operator IntPtr(FontSelectionDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(FontSelectionDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator FontSelectionDialog(Gtk.Dialog value) => (FontSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(FontSelectionDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator FontSelectionDialog(Gtk.Window value) => (FontSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(FontSelectionDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator FontSelectionDialog(Gtk.Bin value) => (FontSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(FontSelectionDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator FontSelectionDialog(Gtk.Container value) => (FontSelectionDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(FontSelectionDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator FontSelectionDialog(Gtk.Widget value) => (FontSelectionDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(FontSelectionDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator FontSelectionDialog(GObject.InitiallyUnowned value) => (FontSelectionDialog)(IntPtr)value
;		public static implicit operator GObject.Object(FontSelectionDialog value) => (GObject.Object)value._pointer
;		public static explicit operator FontSelectionDialog(GObject.Object value) => (FontSelectionDialog)(IntPtr)value
;	}
	public ref struct FontSelectionDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator FontSelectionDialogPrivate(IntPtr pointer) => new FontSelectionDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(FontSelectionDialogPrivate value) => value._pointer
;	}
	public ref struct FontSelectionDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator FontSelectionDialogClass(IntPtr pointer) => new FontSelectionDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(FontSelectionDialogClass value) => value._pointer
;	}
	public ref struct FramePrivate
	{
		private IntPtr _pointer;
		public static explicit operator FramePrivate(IntPtr pointer) => new FramePrivate { _pointer = pointer };
		public static explicit operator IntPtr(FramePrivate value) => value._pointer
;	}
	public ref struct FrameAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator FrameAccessiblePrivate(IntPtr pointer) => new FrameAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(FrameAccessiblePrivate value) => value._pointer
;	}
	public ref struct FrameAccessible
	{
		private IntPtr _pointer;
		public static explicit operator FrameAccessible(IntPtr pointer) => new FrameAccessible { _pointer = pointer };
		public static explicit operator IntPtr(FrameAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(FrameAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator FrameAccessible(Gtk.ContainerAccessible value) => (FrameAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(FrameAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator FrameAccessible(Gtk.WidgetAccessible value) => (FrameAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(FrameAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator FrameAccessible(Gtk.Accessible value) => (FrameAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(FrameAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator FrameAccessible(Atk.Object value) => (FrameAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(FrameAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator FrameAccessible(GObject.Object value) => (FrameAccessible)(IntPtr)value
;	}
	public ref struct FrameAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator FrameAccessibleClass(IntPtr pointer) => new FrameAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(FrameAccessibleClass value) => value._pointer
;	}
	public ref struct GLArea
	{
		private IntPtr _pointer;
		public static explicit operator GLArea(IntPtr pointer) => new GLArea { _pointer = pointer };
		public static explicit operator IntPtr(GLArea value) => value._pointer
;		public static implicit operator Gtk.Widget(GLArea value) => (Gtk.Widget)value._pointer
;		public static explicit operator GLArea(Gtk.Widget value) => (GLArea)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(GLArea value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator GLArea(GObject.InitiallyUnowned value) => (GLArea)(IntPtr)value
;		public static implicit operator GObject.Object(GLArea value) => (GObject.Object)value._pointer
;		public static explicit operator GLArea(GObject.Object value) => (GLArea)(IntPtr)value
;	}
	public ref struct GLAreaClass
	{
		private IntPtr _pointer;
		public static explicit operator GLAreaClass(IntPtr pointer) => new GLAreaClass { _pointer = pointer };
		public static explicit operator IntPtr(GLAreaClass value) => value._pointer
;	}
	public ref struct Gesture
	{
		private IntPtr _pointer;
		public static explicit operator Gesture(IntPtr pointer) => new Gesture { _pointer = pointer };
		public static explicit operator IntPtr(Gesture value) => value._pointer
;		public static implicit operator Gtk.EventController(Gesture value) => (Gtk.EventController)value._pointer
;		public static explicit operator Gesture(Gtk.EventController value) => (Gesture)(IntPtr)value
;		public static implicit operator GObject.Object(Gesture value) => (GObject.Object)value._pointer
;		public static explicit operator Gesture(GObject.Object value) => (Gesture)(IntPtr)value
;	}
	public ref struct GestureClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureClass(IntPtr pointer) => new GestureClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureClass value) => value._pointer
;	}
	public ref struct GestureDrag
	{
		private IntPtr _pointer;
		public static explicit operator GestureDrag(IntPtr pointer) => new GestureDrag { _pointer = pointer };
		public static explicit operator IntPtr(GestureDrag value) => value._pointer
;		public static implicit operator Gtk.GestureSingle(GestureDrag value) => (Gtk.GestureSingle)value._pointer
;		public static explicit operator GestureDrag(Gtk.GestureSingle value) => (GestureDrag)(IntPtr)value
;		public static implicit operator Gtk.Gesture(GestureDrag value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GestureDrag(Gtk.Gesture value) => (GestureDrag)(IntPtr)value
;		public static implicit operator Gtk.EventController(GestureDrag value) => (Gtk.EventController)value._pointer
;		public static explicit operator GestureDrag(Gtk.EventController value) => (GestureDrag)(IntPtr)value
;		public static implicit operator GObject.Object(GestureDrag value) => (GObject.Object)value._pointer
;		public static explicit operator GestureDrag(GObject.Object value) => (GestureDrag)(IntPtr)value
;	}
	public ref struct GestureSingle
	{
		private IntPtr _pointer;
		public static explicit operator GestureSingle(IntPtr pointer) => new GestureSingle { _pointer = pointer };
		public static explicit operator IntPtr(GestureSingle value) => value._pointer
;		public static implicit operator Gtk.Gesture(GestureSingle value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GestureSingle(Gtk.Gesture value) => (GestureSingle)(IntPtr)value
;		public static implicit operator Gtk.EventController(GestureSingle value) => (Gtk.EventController)value._pointer
;		public static explicit operator GestureSingle(Gtk.EventController value) => (GestureSingle)(IntPtr)value
;		public static implicit operator GObject.Object(GestureSingle value) => (GObject.Object)value._pointer
;		public static explicit operator GestureSingle(GObject.Object value) => (GestureSingle)(IntPtr)value
;	}
	public ref struct GestureDragClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureDragClass(IntPtr pointer) => new GestureDragClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureDragClass value) => value._pointer
;	}
	public ref struct GestureLongPress
	{
		private IntPtr _pointer;
		public static explicit operator GestureLongPress(IntPtr pointer) => new GestureLongPress { _pointer = pointer };
		public static explicit operator IntPtr(GestureLongPress value) => value._pointer
;		public static implicit operator Gtk.GestureSingle(GestureLongPress value) => (Gtk.GestureSingle)value._pointer
;		public static explicit operator GestureLongPress(Gtk.GestureSingle value) => (GestureLongPress)(IntPtr)value
;		public static implicit operator Gtk.Gesture(GestureLongPress value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GestureLongPress(Gtk.Gesture value) => (GestureLongPress)(IntPtr)value
;		public static implicit operator Gtk.EventController(GestureLongPress value) => (Gtk.EventController)value._pointer
;		public static explicit operator GestureLongPress(Gtk.EventController value) => (GestureLongPress)(IntPtr)value
;		public static implicit operator GObject.Object(GestureLongPress value) => (GObject.Object)value._pointer
;		public static explicit operator GestureLongPress(GObject.Object value) => (GestureLongPress)(IntPtr)value
;	}
	public ref struct GestureLongPressClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureLongPressClass(IntPtr pointer) => new GestureLongPressClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureLongPressClass value) => value._pointer
;	}
	public ref struct GestureMultiPress
	{
		private IntPtr _pointer;
		public static explicit operator GestureMultiPress(IntPtr pointer) => new GestureMultiPress { _pointer = pointer };
		public static explicit operator IntPtr(GestureMultiPress value) => value._pointer
;		public static implicit operator Gtk.GestureSingle(GestureMultiPress value) => (Gtk.GestureSingle)value._pointer
;		public static explicit operator GestureMultiPress(Gtk.GestureSingle value) => (GestureMultiPress)(IntPtr)value
;		public static implicit operator Gtk.Gesture(GestureMultiPress value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GestureMultiPress(Gtk.Gesture value) => (GestureMultiPress)(IntPtr)value
;		public static implicit operator Gtk.EventController(GestureMultiPress value) => (Gtk.EventController)value._pointer
;		public static explicit operator GestureMultiPress(Gtk.EventController value) => (GestureMultiPress)(IntPtr)value
;		public static implicit operator GObject.Object(GestureMultiPress value) => (GObject.Object)value._pointer
;		public static explicit operator GestureMultiPress(GObject.Object value) => (GestureMultiPress)(IntPtr)value
;	}
	public ref struct GestureMultiPressClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureMultiPressClass(IntPtr pointer) => new GestureMultiPressClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureMultiPressClass value) => value._pointer
;	}
	public ref struct GesturePan
	{
		private IntPtr _pointer;
		public static explicit operator GesturePan(IntPtr pointer) => new GesturePan { _pointer = pointer };
		public static explicit operator IntPtr(GesturePan value) => value._pointer
;		public static implicit operator Gtk.GestureDrag(GesturePan value) => (Gtk.GestureDrag)value._pointer
;		public static explicit operator GesturePan(Gtk.GestureDrag value) => (GesturePan)(IntPtr)value
;		public static implicit operator Gtk.GestureSingle(GesturePan value) => (Gtk.GestureSingle)value._pointer
;		public static explicit operator GesturePan(Gtk.GestureSingle value) => (GesturePan)(IntPtr)value
;		public static implicit operator Gtk.Gesture(GesturePan value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GesturePan(Gtk.Gesture value) => (GesturePan)(IntPtr)value
;		public static implicit operator Gtk.EventController(GesturePan value) => (Gtk.EventController)value._pointer
;		public static explicit operator GesturePan(Gtk.EventController value) => (GesturePan)(IntPtr)value
;		public static implicit operator GObject.Object(GesturePan value) => (GObject.Object)value._pointer
;		public static explicit operator GesturePan(GObject.Object value) => (GesturePan)(IntPtr)value
;	}
	public ref struct GesturePanClass
	{
		private IntPtr _pointer;
		public static explicit operator GesturePanClass(IntPtr pointer) => new GesturePanClass { _pointer = pointer };
		public static explicit operator IntPtr(GesturePanClass value) => value._pointer
;	}
	public ref struct GestureRotate
	{
		private IntPtr _pointer;
		public static explicit operator GestureRotate(IntPtr pointer) => new GestureRotate { _pointer = pointer };
		public static explicit operator IntPtr(GestureRotate value) => value._pointer
;		public static implicit operator Gtk.Gesture(GestureRotate value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GestureRotate(Gtk.Gesture value) => (GestureRotate)(IntPtr)value
;		public static implicit operator Gtk.EventController(GestureRotate value) => (Gtk.EventController)value._pointer
;		public static explicit operator GestureRotate(Gtk.EventController value) => (GestureRotate)(IntPtr)value
;		public static implicit operator GObject.Object(GestureRotate value) => (GObject.Object)value._pointer
;		public static explicit operator GestureRotate(GObject.Object value) => (GestureRotate)(IntPtr)value
;	}
	public ref struct GestureRotateClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureRotateClass(IntPtr pointer) => new GestureRotateClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureRotateClass value) => value._pointer
;	}
	public ref struct GestureSingleClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureSingleClass(IntPtr pointer) => new GestureSingleClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureSingleClass value) => value._pointer
;	}
	public ref struct GestureSwipe
	{
		private IntPtr _pointer;
		public static explicit operator GestureSwipe(IntPtr pointer) => new GestureSwipe { _pointer = pointer };
		public static explicit operator IntPtr(GestureSwipe value) => value._pointer
;		public static implicit operator Gtk.GestureSingle(GestureSwipe value) => (Gtk.GestureSingle)value._pointer
;		public static explicit operator GestureSwipe(Gtk.GestureSingle value) => (GestureSwipe)(IntPtr)value
;		public static implicit operator Gtk.Gesture(GestureSwipe value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GestureSwipe(Gtk.Gesture value) => (GestureSwipe)(IntPtr)value
;		public static implicit operator Gtk.EventController(GestureSwipe value) => (Gtk.EventController)value._pointer
;		public static explicit operator GestureSwipe(Gtk.EventController value) => (GestureSwipe)(IntPtr)value
;		public static implicit operator GObject.Object(GestureSwipe value) => (GObject.Object)value._pointer
;		public static explicit operator GestureSwipe(GObject.Object value) => (GestureSwipe)(IntPtr)value
;	}
	public ref struct GestureSwipeClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureSwipeClass(IntPtr pointer) => new GestureSwipeClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureSwipeClass value) => value._pointer
;	}
	public ref struct GestureZoom
	{
		private IntPtr _pointer;
		public static explicit operator GestureZoom(IntPtr pointer) => new GestureZoom { _pointer = pointer };
		public static explicit operator IntPtr(GestureZoom value) => value._pointer
;		public static implicit operator Gtk.Gesture(GestureZoom value) => (Gtk.Gesture)value._pointer
;		public static explicit operator GestureZoom(Gtk.Gesture value) => (GestureZoom)(IntPtr)value
;		public static implicit operator Gtk.EventController(GestureZoom value) => (Gtk.EventController)value._pointer
;		public static explicit operator GestureZoom(Gtk.EventController value) => (GestureZoom)(IntPtr)value
;		public static implicit operator GObject.Object(GestureZoom value) => (GObject.Object)value._pointer
;		public static explicit operator GestureZoom(GObject.Object value) => (GestureZoom)(IntPtr)value
;	}
	public ref struct GestureZoomClass
	{
		private IntPtr _pointer;
		public static explicit operator GestureZoomClass(IntPtr pointer) => new GestureZoomClass { _pointer = pointer };
		public static explicit operator IntPtr(GestureZoomClass value) => value._pointer
;	}
	public ref struct Gradient
	{
		private IntPtr _pointer;
		public static explicit operator Gradient(IntPtr pointer) => new Gradient { _pointer = pointer };
		public static explicit operator IntPtr(Gradient value) => value._pointer
;	}
	public ref struct SymbolicColor
	{
		private IntPtr _pointer;
		public static explicit operator SymbolicColor(IntPtr pointer) => new SymbolicColor { _pointer = pointer };
		public static explicit operator IntPtr(SymbolicColor value) => value._pointer
;	}
	public ref struct StyleProperties
	{
		private IntPtr _pointer;
		public static explicit operator StyleProperties(IntPtr pointer) => new StyleProperties { _pointer = pointer };
		public static explicit operator IntPtr(StyleProperties value) => value._pointer
;		public static implicit operator GObject.Object(StyleProperties value) => (GObject.Object)value._pointer
;		public static explicit operator StyleProperties(GObject.Object value) => (StyleProperties)(IntPtr)value
;	}
	public ref struct StyleContext
	{
		private IntPtr _pointer;
		public static explicit operator StyleContext(IntPtr pointer) => new StyleContext { _pointer = pointer };
		public static explicit operator IntPtr(StyleContext value) => value._pointer
;		public static implicit operator GObject.Object(StyleContext value) => (GObject.Object)value._pointer
;		public static explicit operator StyleContext(GObject.Object value) => (StyleContext)(IntPtr)value
;	}
	public ref struct Grid
	{
		private IntPtr _pointer;
		public static explicit operator Grid(IntPtr pointer) => new Grid { _pointer = pointer };
		public static explicit operator IntPtr(Grid value) => value._pointer
;		public static implicit operator Gtk.Container(Grid value) => (Gtk.Container)value._pointer
;		public static explicit operator Grid(Gtk.Container value) => (Grid)(IntPtr)value
;		public static implicit operator Gtk.Widget(Grid value) => (Gtk.Widget)value._pointer
;		public static explicit operator Grid(Gtk.Widget value) => (Grid)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Grid value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Grid(GObject.InitiallyUnowned value) => (Grid)(IntPtr)value
;		public static implicit operator GObject.Object(Grid value) => (GObject.Object)value._pointer
;		public static explicit operator Grid(GObject.Object value) => (Grid)(IntPtr)value
;	}
	public ref struct GridPrivate
	{
		private IntPtr _pointer;
		public static explicit operator GridPrivate(IntPtr pointer) => new GridPrivate { _pointer = pointer };
		public static explicit operator IntPtr(GridPrivate value) => value._pointer
;	}
	public ref struct GridClass
	{
		private IntPtr _pointer;
		public static explicit operator GridClass(IntPtr pointer) => new GridClass { _pointer = pointer };
		public static explicit operator IntPtr(GridClass value) => value._pointer
;	}
	public ref struct HBox
	{
		private IntPtr _pointer;
		public static explicit operator HBox(IntPtr pointer) => new HBox { _pointer = pointer };
		public static explicit operator IntPtr(HBox value) => value._pointer
;		public static implicit operator Gtk.Box(HBox value) => (Gtk.Box)value._pointer
;		public static explicit operator HBox(Gtk.Box value) => (HBox)(IntPtr)value
;		public static implicit operator Gtk.Container(HBox value) => (Gtk.Container)value._pointer
;		public static explicit operator HBox(Gtk.Container value) => (HBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(HBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator HBox(Gtk.Widget value) => (HBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HBox(GObject.InitiallyUnowned value) => (HBox)(IntPtr)value
;		public static implicit operator GObject.Object(HBox value) => (GObject.Object)value._pointer
;		public static explicit operator HBox(GObject.Object value) => (HBox)(IntPtr)value
;	}
	public ref struct HBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator HBoxClass(IntPtr pointer) => new HBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(HBoxClass value) => value._pointer
;	}
	public ref struct HButtonBox
	{
		private IntPtr _pointer;
		public static explicit operator HButtonBox(IntPtr pointer) => new HButtonBox { _pointer = pointer };
		public static explicit operator IntPtr(HButtonBox value) => value._pointer
;		public static implicit operator Gtk.ButtonBox(HButtonBox value) => (Gtk.ButtonBox)value._pointer
;		public static explicit operator HButtonBox(Gtk.ButtonBox value) => (HButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Box(HButtonBox value) => (Gtk.Box)value._pointer
;		public static explicit operator HButtonBox(Gtk.Box value) => (HButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Container(HButtonBox value) => (Gtk.Container)value._pointer
;		public static explicit operator HButtonBox(Gtk.Container value) => (HButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(HButtonBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator HButtonBox(Gtk.Widget value) => (HButtonBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HButtonBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HButtonBox(GObject.InitiallyUnowned value) => (HButtonBox)(IntPtr)value
;		public static implicit operator GObject.Object(HButtonBox value) => (GObject.Object)value._pointer
;		public static explicit operator HButtonBox(GObject.Object value) => (HButtonBox)(IntPtr)value
;	}
	public ref struct HButtonBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator HButtonBoxClass(IntPtr pointer) => new HButtonBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(HButtonBoxClass value) => value._pointer
;	}
	public ref struct Paned
	{
		private IntPtr _pointer;
		public static explicit operator Paned(IntPtr pointer) => new Paned { _pointer = pointer };
		public static explicit operator IntPtr(Paned value) => value._pointer
;		public static implicit operator Gtk.Container(Paned value) => (Gtk.Container)value._pointer
;		public static explicit operator Paned(Gtk.Container value) => (Paned)(IntPtr)value
;		public static implicit operator Gtk.Widget(Paned value) => (Gtk.Widget)value._pointer
;		public static explicit operator Paned(Gtk.Widget value) => (Paned)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Paned value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Paned(GObject.InitiallyUnowned value) => (Paned)(IntPtr)value
;		public static implicit operator GObject.Object(Paned value) => (GObject.Object)value._pointer
;		public static explicit operator Paned(GObject.Object value) => (Paned)(IntPtr)value
;	}
	public ref struct HPaned
	{
		private IntPtr _pointer;
		public static explicit operator HPaned(IntPtr pointer) => new HPaned { _pointer = pointer };
		public static explicit operator IntPtr(HPaned value) => value._pointer
;		public static implicit operator Gtk.Paned(HPaned value) => (Gtk.Paned)value._pointer
;		public static explicit operator HPaned(Gtk.Paned value) => (HPaned)(IntPtr)value
;		public static implicit operator Gtk.Container(HPaned value) => (Gtk.Container)value._pointer
;		public static explicit operator HPaned(Gtk.Container value) => (HPaned)(IntPtr)value
;		public static implicit operator Gtk.Widget(HPaned value) => (Gtk.Widget)value._pointer
;		public static explicit operator HPaned(Gtk.Widget value) => (HPaned)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HPaned value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HPaned(GObject.InitiallyUnowned value) => (HPaned)(IntPtr)value
;		public static implicit operator GObject.Object(HPaned value) => (GObject.Object)value._pointer
;		public static explicit operator HPaned(GObject.Object value) => (HPaned)(IntPtr)value
;	}
	public ref struct PanedClass
	{
		private IntPtr _pointer;
		public static explicit operator PanedClass(IntPtr pointer) => new PanedClass { _pointer = pointer };
		public static explicit operator IntPtr(PanedClass value) => value._pointer
;	}
	public ref struct HPanedClass
	{
		private IntPtr _pointer;
		public static explicit operator HPanedClass(IntPtr pointer) => new HPanedClass { _pointer = pointer };
		public static explicit operator IntPtr(HPanedClass value) => value._pointer
;	}
	public ref struct HSV
	{
		private IntPtr _pointer;
		public static explicit operator HSV(IntPtr pointer) => new HSV { _pointer = pointer };
		public static explicit operator IntPtr(HSV value) => value._pointer
;		public static implicit operator Gtk.Widget(HSV value) => (Gtk.Widget)value._pointer
;		public static explicit operator HSV(Gtk.Widget value) => (HSV)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HSV value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HSV(GObject.InitiallyUnowned value) => (HSV)(IntPtr)value
;		public static implicit operator GObject.Object(HSV value) => (GObject.Object)value._pointer
;		public static explicit operator HSV(GObject.Object value) => (HSV)(IntPtr)value
;	}
	public ref struct HSVPrivate
	{
		private IntPtr _pointer;
		public static explicit operator HSVPrivate(IntPtr pointer) => new HSVPrivate { _pointer = pointer };
		public static explicit operator IntPtr(HSVPrivate value) => value._pointer
;	}
	public ref struct HSVClass
	{
		private IntPtr _pointer;
		public static explicit operator HSVClass(IntPtr pointer) => new HSVClass { _pointer = pointer };
		public static explicit operator IntPtr(HSVClass value) => value._pointer
;	}
	public ref struct Scale
	{
		private IntPtr _pointer;
		public static explicit operator Scale(IntPtr pointer) => new Scale { _pointer = pointer };
		public static explicit operator IntPtr(Scale value) => value._pointer
;		public static implicit operator Gtk.Range(Scale value) => (Gtk.Range)value._pointer
;		public static explicit operator Scale(Gtk.Range value) => (Scale)(IntPtr)value
;		public static implicit operator Gtk.Widget(Scale value) => (Gtk.Widget)value._pointer
;		public static explicit operator Scale(Gtk.Widget value) => (Scale)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Scale value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Scale(GObject.InitiallyUnowned value) => (Scale)(IntPtr)value
;		public static implicit operator GObject.Object(Scale value) => (GObject.Object)value._pointer
;		public static explicit operator Scale(GObject.Object value) => (Scale)(IntPtr)value
;	}
	public ref struct HScale
	{
		private IntPtr _pointer;
		public static explicit operator HScale(IntPtr pointer) => new HScale { _pointer = pointer };
		public static explicit operator IntPtr(HScale value) => value._pointer
;		public static implicit operator Gtk.Scale(HScale value) => (Gtk.Scale)value._pointer
;		public static explicit operator HScale(Gtk.Scale value) => (HScale)(IntPtr)value
;		public static implicit operator Gtk.Range(HScale value) => (Gtk.Range)value._pointer
;		public static explicit operator HScale(Gtk.Range value) => (HScale)(IntPtr)value
;		public static implicit operator Gtk.Widget(HScale value) => (Gtk.Widget)value._pointer
;		public static explicit operator HScale(Gtk.Widget value) => (HScale)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HScale value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HScale(GObject.InitiallyUnowned value) => (HScale)(IntPtr)value
;		public static implicit operator GObject.Object(HScale value) => (GObject.Object)value._pointer
;		public static explicit operator HScale(GObject.Object value) => (HScale)(IntPtr)value
;	}
	public ref struct ScaleClass
	{
		private IntPtr _pointer;
		public static explicit operator ScaleClass(IntPtr pointer) => new ScaleClass { _pointer = pointer };
		public static explicit operator IntPtr(ScaleClass value) => value._pointer
;	}
	public ref struct HScaleClass
	{
		private IntPtr _pointer;
		public static explicit operator HScaleClass(IntPtr pointer) => new HScaleClass { _pointer = pointer };
		public static explicit operator IntPtr(HScaleClass value) => value._pointer
;	}
	public ref struct Scrollbar
	{
		private IntPtr _pointer;
		public static explicit operator Scrollbar(IntPtr pointer) => new Scrollbar { _pointer = pointer };
		public static explicit operator IntPtr(Scrollbar value) => value._pointer
;		public static implicit operator Gtk.Range(Scrollbar value) => (Gtk.Range)value._pointer
;		public static explicit operator Scrollbar(Gtk.Range value) => (Scrollbar)(IntPtr)value
;		public static implicit operator Gtk.Widget(Scrollbar value) => (Gtk.Widget)value._pointer
;		public static explicit operator Scrollbar(Gtk.Widget value) => (Scrollbar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Scrollbar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Scrollbar(GObject.InitiallyUnowned value) => (Scrollbar)(IntPtr)value
;		public static implicit operator GObject.Object(Scrollbar value) => (GObject.Object)value._pointer
;		public static explicit operator Scrollbar(GObject.Object value) => (Scrollbar)(IntPtr)value
;	}
	public ref struct HScrollbar
	{
		private IntPtr _pointer;
		public static explicit operator HScrollbar(IntPtr pointer) => new HScrollbar { _pointer = pointer };
		public static explicit operator IntPtr(HScrollbar value) => value._pointer
;		public static implicit operator Gtk.Scrollbar(HScrollbar value) => (Gtk.Scrollbar)value._pointer
;		public static explicit operator HScrollbar(Gtk.Scrollbar value) => (HScrollbar)(IntPtr)value
;		public static implicit operator Gtk.Range(HScrollbar value) => (Gtk.Range)value._pointer
;		public static explicit operator HScrollbar(Gtk.Range value) => (HScrollbar)(IntPtr)value
;		public static implicit operator Gtk.Widget(HScrollbar value) => (Gtk.Widget)value._pointer
;		public static explicit operator HScrollbar(Gtk.Widget value) => (HScrollbar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HScrollbar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HScrollbar(GObject.InitiallyUnowned value) => (HScrollbar)(IntPtr)value
;		public static implicit operator GObject.Object(HScrollbar value) => (GObject.Object)value._pointer
;		public static explicit operator HScrollbar(GObject.Object value) => (HScrollbar)(IntPtr)value
;	}
	public ref struct ScrollbarClass
	{
		private IntPtr _pointer;
		public static explicit operator ScrollbarClass(IntPtr pointer) => new ScrollbarClass { _pointer = pointer };
		public static explicit operator IntPtr(ScrollbarClass value) => value._pointer
;	}
	public ref struct HScrollbarClass
	{
		private IntPtr _pointer;
		public static explicit operator HScrollbarClass(IntPtr pointer) => new HScrollbarClass { _pointer = pointer };
		public static explicit operator IntPtr(HScrollbarClass value) => value._pointer
;	}
	public ref struct Separator
	{
		private IntPtr _pointer;
		public static explicit operator Separator(IntPtr pointer) => new Separator { _pointer = pointer };
		public static explicit operator IntPtr(Separator value) => value._pointer
;		public static implicit operator Gtk.Widget(Separator value) => (Gtk.Widget)value._pointer
;		public static explicit operator Separator(Gtk.Widget value) => (Separator)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Separator value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Separator(GObject.InitiallyUnowned value) => (Separator)(IntPtr)value
;		public static implicit operator GObject.Object(Separator value) => (GObject.Object)value._pointer
;		public static explicit operator Separator(GObject.Object value) => (Separator)(IntPtr)value
;	}
	public ref struct HSeparator
	{
		private IntPtr _pointer;
		public static explicit operator HSeparator(IntPtr pointer) => new HSeparator { _pointer = pointer };
		public static explicit operator IntPtr(HSeparator value) => value._pointer
;		public static implicit operator Gtk.Separator(HSeparator value) => (Gtk.Separator)value._pointer
;		public static explicit operator HSeparator(Gtk.Separator value) => (HSeparator)(IntPtr)value
;		public static implicit operator Gtk.Widget(HSeparator value) => (Gtk.Widget)value._pointer
;		public static explicit operator HSeparator(Gtk.Widget value) => (HSeparator)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HSeparator value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HSeparator(GObject.InitiallyUnowned value) => (HSeparator)(IntPtr)value
;		public static implicit operator GObject.Object(HSeparator value) => (GObject.Object)value._pointer
;		public static explicit operator HSeparator(GObject.Object value) => (HSeparator)(IntPtr)value
;	}
	public ref struct SeparatorClass
	{
		private IntPtr _pointer;
		public static explicit operator SeparatorClass(IntPtr pointer) => new SeparatorClass { _pointer = pointer };
		public static explicit operator IntPtr(SeparatorClass value) => value._pointer
;	}
	public ref struct HSeparatorClass
	{
		private IntPtr _pointer;
		public static explicit operator HSeparatorClass(IntPtr pointer) => new HSeparatorClass { _pointer = pointer };
		public static explicit operator IntPtr(HSeparatorClass value) => value._pointer
;	}
	public ref struct HandleBox
	{
		private IntPtr _pointer;
		public static explicit operator HandleBox(IntPtr pointer) => new HandleBox { _pointer = pointer };
		public static explicit operator IntPtr(HandleBox value) => value._pointer
;		public static implicit operator Gtk.Bin(HandleBox value) => (Gtk.Bin)value._pointer
;		public static explicit operator HandleBox(Gtk.Bin value) => (HandleBox)(IntPtr)value
;		public static implicit operator Gtk.Container(HandleBox value) => (Gtk.Container)value._pointer
;		public static explicit operator HandleBox(Gtk.Container value) => (HandleBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(HandleBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator HandleBox(Gtk.Widget value) => (HandleBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HandleBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HandleBox(GObject.InitiallyUnowned value) => (HandleBox)(IntPtr)value
;		public static implicit operator GObject.Object(HandleBox value) => (GObject.Object)value._pointer
;		public static explicit operator HandleBox(GObject.Object value) => (HandleBox)(IntPtr)value
;	}
	public ref struct HandleBoxPrivate
	{
		private IntPtr _pointer;
		public static explicit operator HandleBoxPrivate(IntPtr pointer) => new HandleBoxPrivate { _pointer = pointer };
		public static explicit operator IntPtr(HandleBoxPrivate value) => value._pointer
;	}
	public ref struct HandleBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator HandleBoxClass(IntPtr pointer) => new HandleBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(HandleBoxClass value) => value._pointer
;	}
	public ref struct HeaderBar
	{
		private IntPtr _pointer;
		public static explicit operator HeaderBar(IntPtr pointer) => new HeaderBar { _pointer = pointer };
		public static explicit operator IntPtr(HeaderBar value) => value._pointer
;		public static implicit operator Gtk.Container(HeaderBar value) => (Gtk.Container)value._pointer
;		public static explicit operator HeaderBar(Gtk.Container value) => (HeaderBar)(IntPtr)value
;		public static implicit operator Gtk.Widget(HeaderBar value) => (Gtk.Widget)value._pointer
;		public static explicit operator HeaderBar(Gtk.Widget value) => (HeaderBar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(HeaderBar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator HeaderBar(GObject.InitiallyUnowned value) => (HeaderBar)(IntPtr)value
;		public static implicit operator GObject.Object(HeaderBar value) => (GObject.Object)value._pointer
;		public static explicit operator HeaderBar(GObject.Object value) => (HeaderBar)(IntPtr)value
;	}
	public ref struct HeaderBarClass
	{
		private IntPtr _pointer;
		public static explicit operator HeaderBarClass(IntPtr pointer) => new HeaderBarClass { _pointer = pointer };
		public static explicit operator IntPtr(HeaderBarClass value) => value._pointer
;	}
	public ref struct HeaderBarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator HeaderBarPrivate(IntPtr pointer) => new HeaderBarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(HeaderBarPrivate value) => value._pointer
;	}
	public ref struct IMContext
	{
		private IntPtr _pointer;
		public static explicit operator IMContext(IntPtr pointer) => new IMContext { _pointer = pointer };
		public static explicit operator IntPtr(IMContext value) => value._pointer
;		public static implicit operator GObject.Object(IMContext value) => (GObject.Object)value._pointer
;		public static explicit operator IMContext(GObject.Object value) => (IMContext)(IntPtr)value
;	}
	public ref struct IMContextClass
	{
		private IntPtr _pointer;
		public static explicit operator IMContextClass(IntPtr pointer) => new IMContextClass { _pointer = pointer };
		public static explicit operator IntPtr(IMContextClass value) => value._pointer
;	}
	public ref struct IMContextInfo
	{
		private IntPtr _pointer;
		public static explicit operator IMContextInfo(IntPtr pointer) => new IMContextInfo { _pointer = pointer };
		public static explicit operator IntPtr(IMContextInfo value) => value._pointer
;	}
	public ref struct IMContextSimple
	{
		private IntPtr _pointer;
		public static explicit operator IMContextSimple(IntPtr pointer) => new IMContextSimple { _pointer = pointer };
		public static explicit operator IntPtr(IMContextSimple value) => value._pointer
;		public static implicit operator Gtk.IMContext(IMContextSimple value) => (Gtk.IMContext)value._pointer
;		public static explicit operator IMContextSimple(Gtk.IMContext value) => (IMContextSimple)(IntPtr)value
;		public static implicit operator GObject.Object(IMContextSimple value) => (GObject.Object)value._pointer
;		public static explicit operator IMContextSimple(GObject.Object value) => (IMContextSimple)(IntPtr)value
;	}
	public ref struct IMContextSimplePrivate
	{
		private IntPtr _pointer;
		public static explicit operator IMContextSimplePrivate(IntPtr pointer) => new IMContextSimplePrivate { _pointer = pointer };
		public static explicit operator IntPtr(IMContextSimplePrivate value) => value._pointer
;	}
	public ref struct IMContextSimpleClass
	{
		private IntPtr _pointer;
		public static explicit operator IMContextSimpleClass(IntPtr pointer) => new IMContextSimpleClass { _pointer = pointer };
		public static explicit operator IntPtr(IMContextSimpleClass value) => value._pointer
;	}
	public ref struct IMMulticontext
	{
		private IntPtr _pointer;
		public static explicit operator IMMulticontext(IntPtr pointer) => new IMMulticontext { _pointer = pointer };
		public static explicit operator IntPtr(IMMulticontext value) => value._pointer
;		public static implicit operator Gtk.IMContext(IMMulticontext value) => (Gtk.IMContext)value._pointer
;		public static explicit operator IMMulticontext(Gtk.IMContext value) => (IMMulticontext)(IntPtr)value
;		public static implicit operator GObject.Object(IMMulticontext value) => (GObject.Object)value._pointer
;		public static explicit operator IMMulticontext(GObject.Object value) => (IMMulticontext)(IntPtr)value
;	}
	public ref struct MenuShell
	{
		private IntPtr _pointer;
		public static explicit operator MenuShell(IntPtr pointer) => new MenuShell { _pointer = pointer };
		public static explicit operator IntPtr(MenuShell value) => value._pointer
;		public static implicit operator Gtk.Container(MenuShell value) => (Gtk.Container)value._pointer
;		public static explicit operator MenuShell(Gtk.Container value) => (MenuShell)(IntPtr)value
;		public static implicit operator Gtk.Widget(MenuShell value) => (Gtk.Widget)value._pointer
;		public static explicit operator MenuShell(Gtk.Widget value) => (MenuShell)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(MenuShell value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator MenuShell(GObject.InitiallyUnowned value) => (MenuShell)(IntPtr)value
;		public static implicit operator GObject.Object(MenuShell value) => (GObject.Object)value._pointer
;		public static explicit operator MenuShell(GObject.Object value) => (MenuShell)(IntPtr)value
;	}
	public ref struct IMMulticontextPrivate
	{
		private IntPtr _pointer;
		public static explicit operator IMMulticontextPrivate(IntPtr pointer) => new IMMulticontextPrivate { _pointer = pointer };
		public static explicit operator IntPtr(IMMulticontextPrivate value) => value._pointer
;	}
	public ref struct IMMulticontextClass
	{
		private IntPtr _pointer;
		public static explicit operator IMMulticontextClass(IntPtr pointer) => new IMMulticontextClass { _pointer = pointer };
		public static explicit operator IntPtr(IMMulticontextClass value) => value._pointer
;	}
	public enum IMPreeditStyle
	{
		nothing = 0,
		callback = 1,
		none = 2,
	}
	public enum IMStatusStyle
	{
		nothing = 0,
		callback = 1,
		none = 2,
	}
	public ref struct IconFactory
	{
		private IntPtr _pointer;
		public static explicit operator IconFactory(IntPtr pointer) => new IconFactory { _pointer = pointer };
		public static explicit operator IntPtr(IconFactory value) => value._pointer
;		public static implicit operator GObject.Object(IconFactory value) => (GObject.Object)value._pointer
;		public static explicit operator IconFactory(GObject.Object value) => (IconFactory)(IntPtr)value
;	}
	public ref struct IconSet
	{
		private IntPtr _pointer;
		public static explicit operator IconSet(IntPtr pointer) => new IconSet { _pointer = pointer };
		public static explicit operator IntPtr(IconSet value) => value._pointer
;	}
	public ref struct IconFactoryPrivate
	{
		private IntPtr _pointer;
		public static explicit operator IconFactoryPrivate(IntPtr pointer) => new IconFactoryPrivate { _pointer = pointer };
		public static explicit operator IntPtr(IconFactoryPrivate value) => value._pointer
;	}
	public ref struct IconFactoryClass
	{
		private IntPtr _pointer;
		public static explicit operator IconFactoryClass(IntPtr pointer) => new IconFactoryClass { _pointer = pointer };
		public static explicit operator IntPtr(IconFactoryClass value) => value._pointer
;	}
	public ref struct IconInfo
	{
		private IntPtr _pointer;
		public static explicit operator IconInfo(IntPtr pointer) => new IconInfo { _pointer = pointer };
		public static explicit operator IntPtr(IconInfo value) => value._pointer
;		public static implicit operator GObject.Object(IconInfo value) => (GObject.Object)value._pointer
;		public static explicit operator IconInfo(GObject.Object value) => (IconInfo)(IntPtr)value
;	}
	public ref struct IconTheme
	{
		private IntPtr _pointer;
		public static explicit operator IconTheme(IntPtr pointer) => new IconTheme { _pointer = pointer };
		public static explicit operator IntPtr(IconTheme value) => value._pointer
;		public static implicit operator GObject.Object(IconTheme value) => (GObject.Object)value._pointer
;		public static explicit operator IconTheme(GObject.Object value) => (IconTheme)(IntPtr)value
;	}
	public ref struct Style
	{
		private IntPtr _pointer;
		public static explicit operator Style(IntPtr pointer) => new Style { _pointer = pointer };
		public static explicit operator IntPtr(Style value) => value._pointer
;		public static implicit operator GObject.Object(Style value) => (GObject.Object)value._pointer
;		public static explicit operator Style(GObject.Object value) => (Style)(IntPtr)value
;	}
	public enum StateType
	{
		normal = 0,
		active = 1,
		prelight = 2,
		selected = 3,
		insensitive = 4,
		inconsistent = 5,
		focused = 6,
	}
	public ref struct IconInfoClass
	{
		private IntPtr _pointer;
		public static explicit operator IconInfoClass(IntPtr pointer) => new IconInfoClass { _pointer = pointer };
		public static explicit operator IntPtr(IconInfoClass value) => value._pointer
;	}
	[Flags]
	public enum IconLookupFlags
	{
		no_svg = 1,
		force_svg = 2,
		use_builtin = 4,
		generic_fallback = 8,
		force_size = 16,
		force_regular = 32,
		force_symbolic = 64,
		dir_ltr = 128,
		dir_rtl = 256,
	}
	public ref struct IconSource
	{
		private IntPtr _pointer;
		public static explicit operator IconSource(IntPtr pointer) => new IconSource { _pointer = pointer };
		public static explicit operator IntPtr(IconSource value) => value._pointer
;	}
	public enum TextDirection
	{
		none = 0,
		ltr = 1,
		rtl = 2,
	}
	public ref struct Settings
	{
		private IntPtr _pointer;
		public static explicit operator Settings(IntPtr pointer) => new Settings { _pointer = pointer };
		public static explicit operator IntPtr(Settings value) => value._pointer
;		public static implicit operator GObject.Object(Settings value) => (GObject.Object)value._pointer
;		public static explicit operator Settings(GObject.Object value) => (Settings)(IntPtr)value
;	}
	public ref struct IconThemePrivate
	{
		private IntPtr _pointer;
		public static explicit operator IconThemePrivate(IntPtr pointer) => new IconThemePrivate { _pointer = pointer };
		public static explicit operator IntPtr(IconThemePrivate value) => value._pointer
;	}
	public ref struct IconThemeClass
	{
		private IntPtr _pointer;
		public static explicit operator IconThemeClass(IntPtr pointer) => new IconThemeClass { _pointer = pointer };
		public static explicit operator IntPtr(IconThemeClass value) => value._pointer
;	}
	public enum IconThemeError
	{
		not_found = 0,
		failed = 1,
	}
	public ref struct Scrollable
	{
		private IntPtr _pointer;
		public static explicit operator Scrollable(IntPtr pointer) => new Scrollable { _pointer = pointer };
		public static explicit operator IntPtr(Scrollable value) => value._pointer
;	}
	public ref struct IconView
	{
		private IntPtr _pointer;
		public static explicit operator IconView(IntPtr pointer) => new IconView { _pointer = pointer };
		public static explicit operator IntPtr(IconView value) => value._pointer
;		public static implicit operator Gtk.Container(IconView value) => (Gtk.Container)value._pointer
;		public static explicit operator IconView(Gtk.Container value) => (IconView)(IntPtr)value
;		public static implicit operator Gtk.Widget(IconView value) => (Gtk.Widget)value._pointer
;		public static explicit operator IconView(Gtk.Widget value) => (IconView)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(IconView value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator IconView(GObject.InitiallyUnowned value) => (IconView)(IntPtr)value
;		public static implicit operator GObject.Object(IconView value) => (GObject.Object)value._pointer
;		public static explicit operator IconView(GObject.Object value) => (IconView)(IntPtr)value
;	}
	public enum IconViewDropPosition
	{
		no_drop = 0,
		drop_into = 1,
		drop_left = 2,
		drop_right = 3,
		drop_above = 4,
		drop_below = 5,
	}
	public ref struct Tooltip
	{
		private IntPtr _pointer;
		public static explicit operator Tooltip(IntPtr pointer) => new Tooltip { _pointer = pointer };
		public static explicit operator IntPtr(Tooltip value) => value._pointer
;		public static implicit operator GObject.Object(Tooltip value) => (GObject.Object)value._pointer
;		public static explicit operator Tooltip(GObject.Object value) => (Tooltip)(IntPtr)value
;	}
	public ref struct IconViewPrivate
	{
		private IntPtr _pointer;
		public static explicit operator IconViewPrivate(IntPtr pointer) => new IconViewPrivate { _pointer = pointer };
		public static explicit operator IntPtr(IconViewPrivate value) => value._pointer
;	}
	public ref struct IconViewAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator IconViewAccessiblePrivate(IntPtr pointer) => new IconViewAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(IconViewAccessiblePrivate value) => value._pointer
;	}
	public ref struct IconViewAccessible
	{
		private IntPtr _pointer;
		public static explicit operator IconViewAccessible(IntPtr pointer) => new IconViewAccessible { _pointer = pointer };
		public static explicit operator IntPtr(IconViewAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(IconViewAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator IconViewAccessible(Gtk.ContainerAccessible value) => (IconViewAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(IconViewAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator IconViewAccessible(Gtk.WidgetAccessible value) => (IconViewAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(IconViewAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator IconViewAccessible(Gtk.Accessible value) => (IconViewAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(IconViewAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator IconViewAccessible(Atk.Object value) => (IconViewAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(IconViewAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator IconViewAccessible(GObject.Object value) => (IconViewAccessible)(IntPtr)value
;	}
	public ref struct IconViewAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator IconViewAccessibleClass(IntPtr pointer) => new IconViewAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(IconViewAccessibleClass value) => value._pointer
;	}
	public ref struct IconViewClass
	{
		private IntPtr _pointer;
		public static explicit operator IconViewClass(IntPtr pointer) => new IconViewClass { _pointer = pointer };
		public static explicit operator IntPtr(IconViewClass value) => value._pointer
;	}
	public ref struct Image
	{
		private IntPtr _pointer;
		public static explicit operator Image(IntPtr pointer) => new Image { _pointer = pointer };
		public static explicit operator IntPtr(Image value) => value._pointer
;		public static implicit operator Gtk.Misc(Image value) => (Gtk.Misc)value._pointer
;		public static explicit operator Image(Gtk.Misc value) => (Image)(IntPtr)value
;		public static implicit operator Gtk.Widget(Image value) => (Gtk.Widget)value._pointer
;		public static explicit operator Image(Gtk.Widget value) => (Image)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Image value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Image(GObject.InitiallyUnowned value) => (Image)(IntPtr)value
;		public static implicit operator GObject.Object(Image value) => (GObject.Object)value._pointer
;		public static explicit operator Image(GObject.Object value) => (Image)(IntPtr)value
;	}
	public ref struct ImagePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ImagePrivate(IntPtr pointer) => new ImagePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ImagePrivate value) => value._pointer
;	}
	public ref struct ImageAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ImageAccessiblePrivate(IntPtr pointer) => new ImageAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ImageAccessiblePrivate value) => value._pointer
;	}
	public ref struct ImageAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ImageAccessible(IntPtr pointer) => new ImageAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ImageAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(ImageAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ImageAccessible(Gtk.WidgetAccessible value) => (ImageAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ImageAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ImageAccessible(Gtk.Accessible value) => (ImageAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ImageAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ImageAccessible(Atk.Object value) => (ImageAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ImageAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ImageAccessible(GObject.Object value) => (ImageAccessible)(IntPtr)value
;	}
	public ref struct ImageAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ImageAccessibleClass(IntPtr pointer) => new ImageAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ImageAccessibleClass value) => value._pointer
;	}
	public ref struct ImageCellAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ImageCellAccessiblePrivate(IntPtr pointer) => new ImageCellAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ImageCellAccessiblePrivate value) => value._pointer
;	}
	public ref struct ImageCellAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ImageCellAccessible(IntPtr pointer) => new ImageCellAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ImageCellAccessible value) => value._pointer
;		public static implicit operator Gtk.RendererCellAccessible(ImageCellAccessible value) => (Gtk.RendererCellAccessible)value._pointer
;		public static explicit operator ImageCellAccessible(Gtk.RendererCellAccessible value) => (ImageCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.CellAccessible(ImageCellAccessible value) => (Gtk.CellAccessible)value._pointer
;		public static explicit operator ImageCellAccessible(Gtk.CellAccessible value) => (ImageCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ImageCellAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ImageCellAccessible(Gtk.Accessible value) => (ImageCellAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ImageCellAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ImageCellAccessible(Atk.Object value) => (ImageCellAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ImageCellAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ImageCellAccessible(GObject.Object value) => (ImageCellAccessible)(IntPtr)value
;	}
	public ref struct ImageCellAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ImageCellAccessibleClass(IntPtr pointer) => new ImageCellAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ImageCellAccessibleClass value) => value._pointer
;	}
	public ref struct ImageClass
	{
		private IntPtr _pointer;
		public static explicit operator ImageClass(IntPtr pointer) => new ImageClass { _pointer = pointer };
		public static explicit operator IntPtr(ImageClass value) => value._pointer
;	}
	public ref struct ImageMenuItem
	{
		private IntPtr _pointer;
		public static explicit operator ImageMenuItem(IntPtr pointer) => new ImageMenuItem { _pointer = pointer };
		public static explicit operator IntPtr(ImageMenuItem value) => value._pointer
;		public static implicit operator Gtk.MenuItem(ImageMenuItem value) => (Gtk.MenuItem)value._pointer
;		public static explicit operator ImageMenuItem(Gtk.MenuItem value) => (ImageMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Bin(ImageMenuItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator ImageMenuItem(Gtk.Bin value) => (ImageMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Container(ImageMenuItem value) => (Gtk.Container)value._pointer
;		public static explicit operator ImageMenuItem(Gtk.Container value) => (ImageMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(ImageMenuItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator ImageMenuItem(Gtk.Widget value) => (ImageMenuItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ImageMenuItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ImageMenuItem(GObject.InitiallyUnowned value) => (ImageMenuItem)(IntPtr)value
;		public static implicit operator GObject.Object(ImageMenuItem value) => (GObject.Object)value._pointer
;		public static explicit operator ImageMenuItem(GObject.Object value) => (ImageMenuItem)(IntPtr)value
;	}
	public ref struct ImageMenuItemPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ImageMenuItemPrivate(IntPtr pointer) => new ImageMenuItemPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ImageMenuItemPrivate value) => value._pointer
;	}
	public ref struct ImageMenuItemClass
	{
		private IntPtr _pointer;
		public static explicit operator ImageMenuItemClass(IntPtr pointer) => new ImageMenuItemClass { _pointer = pointer };
		public static explicit operator IntPtr(ImageMenuItemClass value) => value._pointer
;	}
	public ref struct InfoBar
	{
		private IntPtr _pointer;
		public static explicit operator InfoBar(IntPtr pointer) => new InfoBar { _pointer = pointer };
		public static explicit operator IntPtr(InfoBar value) => value._pointer
;		public static implicit operator Gtk.Box(InfoBar value) => (Gtk.Box)value._pointer
;		public static explicit operator InfoBar(Gtk.Box value) => (InfoBar)(IntPtr)value
;		public static implicit operator Gtk.Container(InfoBar value) => (Gtk.Container)value._pointer
;		public static explicit operator InfoBar(Gtk.Container value) => (InfoBar)(IntPtr)value
;		public static implicit operator Gtk.Widget(InfoBar value) => (Gtk.Widget)value._pointer
;		public static explicit operator InfoBar(Gtk.Widget value) => (InfoBar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(InfoBar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator InfoBar(GObject.InitiallyUnowned value) => (InfoBar)(IntPtr)value
;		public static implicit operator GObject.Object(InfoBar value) => (GObject.Object)value._pointer
;		public static explicit operator InfoBar(GObject.Object value) => (InfoBar)(IntPtr)value
;	}
	public enum MessageType
	{
		info = 0,
		warning = 1,
		question = 2,
		error = 3,
		other = 4,
	}
	public ref struct InfoBarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator InfoBarPrivate(IntPtr pointer) => new InfoBarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(InfoBarPrivate value) => value._pointer
;	}
	public ref struct InfoBarClass
	{
		private IntPtr _pointer;
		public static explicit operator InfoBarClass(IntPtr pointer) => new InfoBarClass { _pointer = pointer };
		public static explicit operator IntPtr(InfoBarClass value) => value._pointer
;	}
	public ref struct Invisible
	{
		private IntPtr _pointer;
		public static explicit operator Invisible(IntPtr pointer) => new Invisible { _pointer = pointer };
		public static explicit operator IntPtr(Invisible value) => value._pointer
;		public static implicit operator Gtk.Widget(Invisible value) => (Gtk.Widget)value._pointer
;		public static explicit operator Invisible(Gtk.Widget value) => (Invisible)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Invisible value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Invisible(GObject.InitiallyUnowned value) => (Invisible)(IntPtr)value
;		public static implicit operator GObject.Object(Invisible value) => (GObject.Object)value._pointer
;		public static explicit operator Invisible(GObject.Object value) => (Invisible)(IntPtr)value
;	}
	public ref struct InvisiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator InvisiblePrivate(IntPtr pointer) => new InvisiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(InvisiblePrivate value) => value._pointer
;	}
	public ref struct InvisibleClass
	{
		private IntPtr _pointer;
		public static explicit operator InvisibleClass(IntPtr pointer) => new InvisibleClass { _pointer = pointer };
		public static explicit operator IntPtr(InvisibleClass value) => value._pointer
;	}
	[Flags]
	public enum JunctionSides
	{
		none = 0,
		corner_topleft = 1,
		corner_topright = 2,
		corner_bottomleft = 4,
		corner_bottomright = 8,
		top = 3,
		bottom = 12,
		left = 5,
		right = 10,
	}
	public enum Justification
	{
		left = 0,
		right = 1,
		center = 2,
		fill = 3,
	}
	public ref struct LabelPrivate
	{
		private IntPtr _pointer;
		public static explicit operator LabelPrivate(IntPtr pointer) => new LabelPrivate { _pointer = pointer };
		public static explicit operator IntPtr(LabelPrivate value) => value._pointer
;	}
	public ref struct LabelAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator LabelAccessiblePrivate(IntPtr pointer) => new LabelAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(LabelAccessiblePrivate value) => value._pointer
;	}
	public ref struct LabelAccessible
	{
		private IntPtr _pointer;
		public static explicit operator LabelAccessible(IntPtr pointer) => new LabelAccessible { _pointer = pointer };
		public static explicit operator IntPtr(LabelAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(LabelAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator LabelAccessible(Gtk.WidgetAccessible value) => (LabelAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(LabelAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator LabelAccessible(Gtk.Accessible value) => (LabelAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(LabelAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator LabelAccessible(Atk.Object value) => (LabelAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(LabelAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator LabelAccessible(GObject.Object value) => (LabelAccessible)(IntPtr)value
;	}
	public ref struct LabelAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator LabelAccessibleClass(IntPtr pointer) => new LabelAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(LabelAccessibleClass value) => value._pointer
;	}
	public ref struct LabelSelectionInfo
	{
		private IntPtr _pointer;
		public static explicit operator LabelSelectionInfo(IntPtr pointer) => new LabelSelectionInfo { _pointer = pointer };
		public static explicit operator IntPtr(LabelSelectionInfo value) => value._pointer
;	}
	public ref struct Layout
	{
		private IntPtr _pointer;
		public static explicit operator Layout(IntPtr pointer) => new Layout { _pointer = pointer };
		public static explicit operator IntPtr(Layout value) => value._pointer
;		public static implicit operator Gtk.Container(Layout value) => (Gtk.Container)value._pointer
;		public static explicit operator Layout(Gtk.Container value) => (Layout)(IntPtr)value
;		public static implicit operator Gtk.Widget(Layout value) => (Gtk.Widget)value._pointer
;		public static explicit operator Layout(Gtk.Widget value) => (Layout)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Layout value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Layout(GObject.InitiallyUnowned value) => (Layout)(IntPtr)value
;		public static implicit operator GObject.Object(Layout value) => (GObject.Object)value._pointer
;		public static explicit operator Layout(GObject.Object value) => (Layout)(IntPtr)value
;	}
	public ref struct LayoutPrivate
	{
		private IntPtr _pointer;
		public static explicit operator LayoutPrivate(IntPtr pointer) => new LayoutPrivate { _pointer = pointer };
		public static explicit operator IntPtr(LayoutPrivate value) => value._pointer
;	}
	public ref struct LayoutClass
	{
		private IntPtr _pointer;
		public static explicit operator LayoutClass(IntPtr pointer) => new LayoutClass { _pointer = pointer };
		public static explicit operator IntPtr(LayoutClass value) => value._pointer
;	}
	public ref struct LevelBar
	{
		private IntPtr _pointer;
		public static explicit operator LevelBar(IntPtr pointer) => new LevelBar { _pointer = pointer };
		public static explicit operator IntPtr(LevelBar value) => value._pointer
;		public static implicit operator Gtk.Widget(LevelBar value) => (Gtk.Widget)value._pointer
;		public static explicit operator LevelBar(Gtk.Widget value) => (LevelBar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(LevelBar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator LevelBar(GObject.InitiallyUnowned value) => (LevelBar)(IntPtr)value
;		public static implicit operator GObject.Object(LevelBar value) => (GObject.Object)value._pointer
;		public static explicit operator LevelBar(GObject.Object value) => (LevelBar)(IntPtr)value
;	}
	public enum LevelBarMode
	{
		continuous = 0,
		discrete = 1,
	}
	public ref struct LevelBarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator LevelBarPrivate(IntPtr pointer) => new LevelBarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(LevelBarPrivate value) => value._pointer
;	}
	public ref struct LevelBarAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator LevelBarAccessiblePrivate(IntPtr pointer) => new LevelBarAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(LevelBarAccessiblePrivate value) => value._pointer
;	}
	public ref struct LevelBarAccessible
	{
		private IntPtr _pointer;
		public static explicit operator LevelBarAccessible(IntPtr pointer) => new LevelBarAccessible { _pointer = pointer };
		public static explicit operator IntPtr(LevelBarAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(LevelBarAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator LevelBarAccessible(Gtk.WidgetAccessible value) => (LevelBarAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(LevelBarAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator LevelBarAccessible(Gtk.Accessible value) => (LevelBarAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(LevelBarAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator LevelBarAccessible(Atk.Object value) => (LevelBarAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(LevelBarAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator LevelBarAccessible(GObject.Object value) => (LevelBarAccessible)(IntPtr)value
;	}
	public ref struct LevelBarAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator LevelBarAccessibleClass(IntPtr pointer) => new LevelBarAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(LevelBarAccessibleClass value) => value._pointer
;	}
	public ref struct LevelBarClass
	{
		private IntPtr _pointer;
		public static explicit operator LevelBarClass(IntPtr pointer) => new LevelBarClass { _pointer = pointer };
		public static explicit operator IntPtr(LevelBarClass value) => value._pointer
;	}
	public ref struct LinkButton
	{
		private IntPtr _pointer;
		public static explicit operator LinkButton(IntPtr pointer) => new LinkButton { _pointer = pointer };
		public static explicit operator IntPtr(LinkButton value) => value._pointer
;		public static implicit operator Gtk.Button(LinkButton value) => (Gtk.Button)value._pointer
;		public static explicit operator LinkButton(Gtk.Button value) => (LinkButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(LinkButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator LinkButton(Gtk.Bin value) => (LinkButton)(IntPtr)value
;		public static implicit operator Gtk.Container(LinkButton value) => (Gtk.Container)value._pointer
;		public static explicit operator LinkButton(Gtk.Container value) => (LinkButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(LinkButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator LinkButton(Gtk.Widget value) => (LinkButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(LinkButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator LinkButton(GObject.InitiallyUnowned value) => (LinkButton)(IntPtr)value
;		public static implicit operator GObject.Object(LinkButton value) => (GObject.Object)value._pointer
;		public static explicit operator LinkButton(GObject.Object value) => (LinkButton)(IntPtr)value
;	}
	public ref struct LinkButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator LinkButtonPrivate(IntPtr pointer) => new LinkButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(LinkButtonPrivate value) => value._pointer
;	}
	public ref struct LinkButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator LinkButtonAccessiblePrivate(IntPtr pointer) => new LinkButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(LinkButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct LinkButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator LinkButtonAccessible(IntPtr pointer) => new LinkButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(LinkButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.ButtonAccessible(LinkButtonAccessible value) => (Gtk.ButtonAccessible)value._pointer
;		public static explicit operator LinkButtonAccessible(Gtk.ButtonAccessible value) => (LinkButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(LinkButtonAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator LinkButtonAccessible(Gtk.ContainerAccessible value) => (LinkButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(LinkButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator LinkButtonAccessible(Gtk.WidgetAccessible value) => (LinkButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(LinkButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator LinkButtonAccessible(Gtk.Accessible value) => (LinkButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(LinkButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator LinkButtonAccessible(Atk.Object value) => (LinkButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(LinkButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator LinkButtonAccessible(GObject.Object value) => (LinkButtonAccessible)(IntPtr)value
;	}
	public ref struct LinkButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator LinkButtonAccessibleClass(IntPtr pointer) => new LinkButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(LinkButtonAccessibleClass value) => value._pointer
;	}
	public ref struct LinkButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator LinkButtonClass(IntPtr pointer) => new LinkButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(LinkButtonClass value) => value._pointer
;	}
	public ref struct ListBox
	{
		private IntPtr _pointer;
		public static explicit operator ListBox(IntPtr pointer) => new ListBox { _pointer = pointer };
		public static explicit operator IntPtr(ListBox value) => value._pointer
;		public static implicit operator Gtk.Container(ListBox value) => (Gtk.Container)value._pointer
;		public static explicit operator ListBox(Gtk.Container value) => (ListBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(ListBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator ListBox(Gtk.Widget value) => (ListBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ListBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ListBox(GObject.InitiallyUnowned value) => (ListBox)(IntPtr)value
;		public static implicit operator GObject.Object(ListBox value) => (GObject.Object)value._pointer
;		public static explicit operator ListBox(GObject.Object value) => (ListBox)(IntPtr)value
;	}
	public ref struct ListBoxRow
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxRow(IntPtr pointer) => new ListBoxRow { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxRow value) => value._pointer
;		public static implicit operator Gtk.Bin(ListBoxRow value) => (Gtk.Bin)value._pointer
;		public static explicit operator ListBoxRow(Gtk.Bin value) => (ListBoxRow)(IntPtr)value
;		public static implicit operator Gtk.Container(ListBoxRow value) => (Gtk.Container)value._pointer
;		public static explicit operator ListBoxRow(Gtk.Container value) => (ListBoxRow)(IntPtr)value
;		public static implicit operator Gtk.Widget(ListBoxRow value) => (Gtk.Widget)value._pointer
;		public static explicit operator ListBoxRow(Gtk.Widget value) => (ListBoxRow)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ListBoxRow value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ListBoxRow(GObject.InitiallyUnowned value) => (ListBoxRow)(IntPtr)value
;		public static implicit operator GObject.Object(ListBoxRow value) => (GObject.Object)value._pointer
;		public static explicit operator ListBoxRow(GObject.Object value) => (ListBoxRow)(IntPtr)value
;	}
	public ref struct ListBoxAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxAccessiblePrivate(IntPtr pointer) => new ListBoxAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxAccessiblePrivate value) => value._pointer
;	}
	public ref struct ListBoxAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxAccessible(IntPtr pointer) => new ListBoxAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(ListBoxAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ListBoxAccessible(Gtk.ContainerAccessible value) => (ListBoxAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ListBoxAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ListBoxAccessible(Gtk.WidgetAccessible value) => (ListBoxAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ListBoxAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ListBoxAccessible(Gtk.Accessible value) => (ListBoxAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ListBoxAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ListBoxAccessible(Atk.Object value) => (ListBoxAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ListBoxAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ListBoxAccessible(GObject.Object value) => (ListBoxAccessible)(IntPtr)value
;	}
	public ref struct ListBoxAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxAccessibleClass(IntPtr pointer) => new ListBoxAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxAccessibleClass value) => value._pointer
;	}
	public ref struct ListBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxClass(IntPtr pointer) => new ListBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxClass value) => value._pointer
;	}
	public ref struct ListBoxRowAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxRowAccessible(IntPtr pointer) => new ListBoxRowAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxRowAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(ListBoxRowAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ListBoxRowAccessible(Gtk.ContainerAccessible value) => (ListBoxRowAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ListBoxRowAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ListBoxRowAccessible(Gtk.WidgetAccessible value) => (ListBoxRowAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ListBoxRowAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ListBoxRowAccessible(Gtk.Accessible value) => (ListBoxRowAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ListBoxRowAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ListBoxRowAccessible(Atk.Object value) => (ListBoxRowAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ListBoxRowAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ListBoxRowAccessible(GObject.Object value) => (ListBoxRowAccessible)(IntPtr)value
;	}
	public ref struct ListBoxRowAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxRowAccessibleClass(IntPtr pointer) => new ListBoxRowAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxRowAccessibleClass value) => value._pointer
;	}
	public ref struct ListBoxRowClass
	{
		private IntPtr _pointer;
		public static explicit operator ListBoxRowClass(IntPtr pointer) => new ListBoxRowClass { _pointer = pointer };
		public static explicit operator IntPtr(ListBoxRowClass value) => value._pointer
;	}
	public ref struct TreeDragDest
	{
		private IntPtr _pointer;
		public static explicit operator TreeDragDest(IntPtr pointer) => new TreeDragDest { _pointer = pointer };
		public static explicit operator IntPtr(TreeDragDest value) => value._pointer
;	}
	public ref struct TreeDragSource
	{
		private IntPtr _pointer;
		public static explicit operator TreeDragSource(IntPtr pointer) => new TreeDragSource { _pointer = pointer };
		public static explicit operator IntPtr(TreeDragSource value) => value._pointer
;	}
	public ref struct TreeSortable
	{
		private IntPtr _pointer;
		public static explicit operator TreeSortable(IntPtr pointer) => new TreeSortable { _pointer = pointer };
		public static explicit operator IntPtr(TreeSortable value) => value._pointer
;	}
	public ref struct ListStore
	{
		private IntPtr _pointer;
		public static explicit operator ListStore(IntPtr pointer) => new ListStore { _pointer = pointer };
		public static explicit operator IntPtr(ListStore value) => value._pointer
;		public static implicit operator GObject.Object(ListStore value) => (GObject.Object)value._pointer
;		public static explicit operator ListStore(GObject.Object value) => (ListStore)(IntPtr)value
;	}
	public ref struct ListStorePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ListStorePrivate(IntPtr pointer) => new ListStorePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ListStorePrivate value) => value._pointer
;	}
	public ref struct ListStoreClass
	{
		private IntPtr _pointer;
		public static explicit operator ListStoreClass(IntPtr pointer) => new ListStoreClass { _pointer = pointer };
		public static explicit operator IntPtr(ListStoreClass value) => value._pointer
;	}
	public ref struct LockButton
	{
		private IntPtr _pointer;
		public static explicit operator LockButton(IntPtr pointer) => new LockButton { _pointer = pointer };
		public static explicit operator IntPtr(LockButton value) => value._pointer
;		public static implicit operator Gtk.Button(LockButton value) => (Gtk.Button)value._pointer
;		public static explicit operator LockButton(Gtk.Button value) => (LockButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(LockButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator LockButton(Gtk.Bin value) => (LockButton)(IntPtr)value
;		public static implicit operator Gtk.Container(LockButton value) => (Gtk.Container)value._pointer
;		public static explicit operator LockButton(Gtk.Container value) => (LockButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(LockButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator LockButton(Gtk.Widget value) => (LockButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(LockButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator LockButton(GObject.InitiallyUnowned value) => (LockButton)(IntPtr)value
;		public static implicit operator GObject.Object(LockButton value) => (GObject.Object)value._pointer
;		public static explicit operator LockButton(GObject.Object value) => (LockButton)(IntPtr)value
;	}
	public ref struct LockButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator LockButtonPrivate(IntPtr pointer) => new LockButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(LockButtonPrivate value) => value._pointer
;	}
	public ref struct LockButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator LockButtonAccessiblePrivate(IntPtr pointer) => new LockButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(LockButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct LockButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator LockButtonAccessible(IntPtr pointer) => new LockButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(LockButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.ButtonAccessible(LockButtonAccessible value) => (Gtk.ButtonAccessible)value._pointer
;		public static explicit operator LockButtonAccessible(Gtk.ButtonAccessible value) => (LockButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(LockButtonAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator LockButtonAccessible(Gtk.ContainerAccessible value) => (LockButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(LockButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator LockButtonAccessible(Gtk.WidgetAccessible value) => (LockButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(LockButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator LockButtonAccessible(Gtk.Accessible value) => (LockButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(LockButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator LockButtonAccessible(Atk.Object value) => (LockButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(LockButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator LockButtonAccessible(GObject.Object value) => (LockButtonAccessible)(IntPtr)value
;	}
	public ref struct LockButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator LockButtonAccessibleClass(IntPtr pointer) => new LockButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(LockButtonAccessibleClass value) => value._pointer
;	}
	public ref struct LockButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator LockButtonClass(IntPtr pointer) => new LockButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(LockButtonClass value) => value._pointer
;	}
	public ref struct MenuPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuPrivate(IntPtr pointer) => new MenuPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuPrivate value) => value._pointer
;	}
	public ref struct MenuShellAccessible
	{
		private IntPtr _pointer;
		public static explicit operator MenuShellAccessible(IntPtr pointer) => new MenuShellAccessible { _pointer = pointer };
		public static explicit operator IntPtr(MenuShellAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(MenuShellAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator MenuShellAccessible(Gtk.ContainerAccessible value) => (MenuShellAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(MenuShellAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator MenuShellAccessible(Gtk.WidgetAccessible value) => (MenuShellAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(MenuShellAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator MenuShellAccessible(Gtk.Accessible value) => (MenuShellAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(MenuShellAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator MenuShellAccessible(Atk.Object value) => (MenuShellAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(MenuShellAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator MenuShellAccessible(GObject.Object value) => (MenuShellAccessible)(IntPtr)value
;	}
	public ref struct MenuAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuAccessiblePrivate(IntPtr pointer) => new MenuAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuAccessiblePrivate value) => value._pointer
;	}
	public ref struct MenuAccessible
	{
		private IntPtr _pointer;
		public static explicit operator MenuAccessible(IntPtr pointer) => new MenuAccessible { _pointer = pointer };
		public static explicit operator IntPtr(MenuAccessible value) => value._pointer
;		public static implicit operator Gtk.MenuShellAccessible(MenuAccessible value) => (Gtk.MenuShellAccessible)value._pointer
;		public static explicit operator MenuAccessible(Gtk.MenuShellAccessible value) => (MenuAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(MenuAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator MenuAccessible(Gtk.ContainerAccessible value) => (MenuAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(MenuAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator MenuAccessible(Gtk.WidgetAccessible value) => (MenuAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(MenuAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator MenuAccessible(Gtk.Accessible value) => (MenuAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(MenuAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator MenuAccessible(Atk.Object value) => (MenuAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(MenuAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator MenuAccessible(GObject.Object value) => (MenuAccessible)(IntPtr)value
;	}
	public ref struct MenuShellAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuShellAccessibleClass(IntPtr pointer) => new MenuShellAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuShellAccessibleClass value) => value._pointer
;	}
	public ref struct MenuAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuAccessibleClass(IntPtr pointer) => new MenuAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuAccessibleClass value) => value._pointer
;	}
	public enum PackDirection
	{
		ltr = 0,
		rtl = 1,
		ttb = 2,
		btt = 3,
	}
	public ref struct MenuBar
	{
		private IntPtr _pointer;
		public static explicit operator MenuBar(IntPtr pointer) => new MenuBar { _pointer = pointer };
		public static explicit operator IntPtr(MenuBar value) => value._pointer
;		public static implicit operator Gtk.MenuShell(MenuBar value) => (Gtk.MenuShell)value._pointer
;		public static explicit operator MenuBar(Gtk.MenuShell value) => (MenuBar)(IntPtr)value
;		public static implicit operator Gtk.Container(MenuBar value) => (Gtk.Container)value._pointer
;		public static explicit operator MenuBar(Gtk.Container value) => (MenuBar)(IntPtr)value
;		public static implicit operator Gtk.Widget(MenuBar value) => (Gtk.Widget)value._pointer
;		public static explicit operator MenuBar(Gtk.Widget value) => (MenuBar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(MenuBar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator MenuBar(GObject.InitiallyUnowned value) => (MenuBar)(IntPtr)value
;		public static implicit operator GObject.Object(MenuBar value) => (GObject.Object)value._pointer
;		public static explicit operator MenuBar(GObject.Object value) => (MenuBar)(IntPtr)value
;	}
	public ref struct MenuBarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuBarPrivate(IntPtr pointer) => new MenuBarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuBarPrivate value) => value._pointer
;	}
	public ref struct MenuShellClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuShellClass(IntPtr pointer) => new MenuShellClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuShellClass value) => value._pointer
;	}
	public ref struct MenuBarClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuBarClass(IntPtr pointer) => new MenuBarClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuBarClass value) => value._pointer
;	}
	public ref struct MenuButton
	{
		private IntPtr _pointer;
		public static explicit operator MenuButton(IntPtr pointer) => new MenuButton { _pointer = pointer };
		public static explicit operator IntPtr(MenuButton value) => value._pointer
;		public static implicit operator Gtk.ToggleButton(MenuButton value) => (Gtk.ToggleButton)value._pointer
;		public static explicit operator MenuButton(Gtk.ToggleButton value) => (MenuButton)(IntPtr)value
;		public static implicit operator Gtk.Button(MenuButton value) => (Gtk.Button)value._pointer
;		public static explicit operator MenuButton(Gtk.Button value) => (MenuButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(MenuButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator MenuButton(Gtk.Bin value) => (MenuButton)(IntPtr)value
;		public static implicit operator Gtk.Container(MenuButton value) => (Gtk.Container)value._pointer
;		public static explicit operator MenuButton(Gtk.Container value) => (MenuButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(MenuButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator MenuButton(Gtk.Widget value) => (MenuButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(MenuButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator MenuButton(GObject.InitiallyUnowned value) => (MenuButton)(IntPtr)value
;		public static implicit operator GObject.Object(MenuButton value) => (GObject.Object)value._pointer
;		public static explicit operator MenuButton(GObject.Object value) => (MenuButton)(IntPtr)value
;	}
	public ref struct Popover
	{
		private IntPtr _pointer;
		public static explicit operator Popover(IntPtr pointer) => new Popover { _pointer = pointer };
		public static explicit operator IntPtr(Popover value) => value._pointer
;		public static implicit operator Gtk.Bin(Popover value) => (Gtk.Bin)value._pointer
;		public static explicit operator Popover(Gtk.Bin value) => (Popover)(IntPtr)value
;		public static implicit operator Gtk.Container(Popover value) => (Gtk.Container)value._pointer
;		public static explicit operator Popover(Gtk.Container value) => (Popover)(IntPtr)value
;		public static implicit operator Gtk.Widget(Popover value) => (Gtk.Widget)value._pointer
;		public static explicit operator Popover(Gtk.Widget value) => (Popover)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Popover value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Popover(GObject.InitiallyUnowned value) => (Popover)(IntPtr)value
;		public static implicit operator GObject.Object(Popover value) => (GObject.Object)value._pointer
;		public static explicit operator Popover(GObject.Object value) => (Popover)(IntPtr)value
;	}
	public ref struct MenuButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuButtonPrivate(IntPtr pointer) => new MenuButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuButtonPrivate value) => value._pointer
;	}
	public ref struct ToggleButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ToggleButtonAccessible(IntPtr pointer) => new ToggleButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ToggleButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.ButtonAccessible(ToggleButtonAccessible value) => (Gtk.ButtonAccessible)value._pointer
;		public static explicit operator ToggleButtonAccessible(Gtk.ButtonAccessible value) => (ToggleButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(ToggleButtonAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ToggleButtonAccessible(Gtk.ContainerAccessible value) => (ToggleButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ToggleButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ToggleButtonAccessible(Gtk.WidgetAccessible value) => (ToggleButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ToggleButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ToggleButtonAccessible(Gtk.Accessible value) => (ToggleButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ToggleButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ToggleButtonAccessible(Atk.Object value) => (ToggleButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ToggleButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ToggleButtonAccessible(GObject.Object value) => (ToggleButtonAccessible)(IntPtr)value
;	}
	public ref struct MenuButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuButtonAccessiblePrivate(IntPtr pointer) => new MenuButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct MenuButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator MenuButtonAccessible(IntPtr pointer) => new MenuButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(MenuButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.ToggleButtonAccessible(MenuButtonAccessible value) => (Gtk.ToggleButtonAccessible)value._pointer
;		public static explicit operator MenuButtonAccessible(Gtk.ToggleButtonAccessible value) => (MenuButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ButtonAccessible(MenuButtonAccessible value) => (Gtk.ButtonAccessible)value._pointer
;		public static explicit operator MenuButtonAccessible(Gtk.ButtonAccessible value) => (MenuButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(MenuButtonAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator MenuButtonAccessible(Gtk.ContainerAccessible value) => (MenuButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(MenuButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator MenuButtonAccessible(Gtk.WidgetAccessible value) => (MenuButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(MenuButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator MenuButtonAccessible(Gtk.Accessible value) => (MenuButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(MenuButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator MenuButtonAccessible(Atk.Object value) => (MenuButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(MenuButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator MenuButtonAccessible(GObject.Object value) => (MenuButtonAccessible)(IntPtr)value
;	}
	public ref struct ToggleButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ToggleButtonAccessibleClass(IntPtr pointer) => new ToggleButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ToggleButtonAccessibleClass value) => value._pointer
;	}
	public ref struct MenuButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuButtonAccessibleClass(IntPtr pointer) => new MenuButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuButtonAccessibleClass value) => value._pointer
;	}
	public ref struct MenuButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuButtonClass(IntPtr pointer) => new MenuButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuButtonClass value) => value._pointer
;	}
	public ref struct MenuClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuClass(IntPtr pointer) => new MenuClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuClass value) => value._pointer
;	}
	public enum MenuDirectionType
	{
		parent = 0,
		child = 1,
		next = 2,
		prev = 3,
	}
	public ref struct MenuItemPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuItemPrivate(IntPtr pointer) => new MenuItemPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuItemPrivate value) => value._pointer
;	}
	public ref struct MenuItemAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuItemAccessiblePrivate(IntPtr pointer) => new MenuItemAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuItemAccessiblePrivate value) => value._pointer
;	}
	public ref struct MenuShellPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuShellPrivate(IntPtr pointer) => new MenuShellPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuShellPrivate value) => value._pointer
;	}
	public ref struct MenuShellAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuShellAccessiblePrivate(IntPtr pointer) => new MenuShellAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuShellAccessiblePrivate value) => value._pointer
;	}
	public ref struct ToolItem
	{
		private IntPtr _pointer;
		public static explicit operator ToolItem(IntPtr pointer) => new ToolItem { _pointer = pointer };
		public static explicit operator IntPtr(ToolItem value) => value._pointer
;		public static implicit operator Gtk.Bin(ToolItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator ToolItem(Gtk.Bin value) => (ToolItem)(IntPtr)value
;		public static implicit operator Gtk.Container(ToolItem value) => (Gtk.Container)value._pointer
;		public static explicit operator ToolItem(Gtk.Container value) => (ToolItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(ToolItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator ToolItem(Gtk.Widget value) => (ToolItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ToolItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ToolItem(GObject.InitiallyUnowned value) => (ToolItem)(IntPtr)value
;		public static implicit operator GObject.Object(ToolItem value) => (GObject.Object)value._pointer
;		public static explicit operator ToolItem(GObject.Object value) => (ToolItem)(IntPtr)value
;	}
	public ref struct MenuToolButton
	{
		private IntPtr _pointer;
		public static explicit operator MenuToolButton(IntPtr pointer) => new MenuToolButton { _pointer = pointer };
		public static explicit operator IntPtr(MenuToolButton value) => value._pointer
;		public static implicit operator Gtk.ToolButton(MenuToolButton value) => (Gtk.ToolButton)value._pointer
;		public static explicit operator MenuToolButton(Gtk.ToolButton value) => (MenuToolButton)(IntPtr)value
;		public static implicit operator Gtk.ToolItem(MenuToolButton value) => (Gtk.ToolItem)value._pointer
;		public static explicit operator MenuToolButton(Gtk.ToolItem value) => (MenuToolButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(MenuToolButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator MenuToolButton(Gtk.Bin value) => (MenuToolButton)(IntPtr)value
;		public static implicit operator Gtk.Container(MenuToolButton value) => (Gtk.Container)value._pointer
;		public static explicit operator MenuToolButton(Gtk.Container value) => (MenuToolButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(MenuToolButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator MenuToolButton(Gtk.Widget value) => (MenuToolButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(MenuToolButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator MenuToolButton(GObject.InitiallyUnowned value) => (MenuToolButton)(IntPtr)value
;		public static implicit operator GObject.Object(MenuToolButton value) => (GObject.Object)value._pointer
;		public static explicit operator MenuToolButton(GObject.Object value) => (MenuToolButton)(IntPtr)value
;	}
	public ref struct ToolButton
	{
		private IntPtr _pointer;
		public static explicit operator ToolButton(IntPtr pointer) => new ToolButton { _pointer = pointer };
		public static explicit operator IntPtr(ToolButton value) => value._pointer
;		public static implicit operator Gtk.ToolItem(ToolButton value) => (Gtk.ToolItem)value._pointer
;		public static explicit operator ToolButton(Gtk.ToolItem value) => (ToolButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(ToolButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator ToolButton(Gtk.Bin value) => (ToolButton)(IntPtr)value
;		public static implicit operator Gtk.Container(ToolButton value) => (Gtk.Container)value._pointer
;		public static explicit operator ToolButton(Gtk.Container value) => (ToolButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(ToolButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator ToolButton(Gtk.Widget value) => (ToolButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ToolButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ToolButton(GObject.InitiallyUnowned value) => (ToolButton)(IntPtr)value
;		public static implicit operator GObject.Object(ToolButton value) => (GObject.Object)value._pointer
;		public static explicit operator ToolButton(GObject.Object value) => (ToolButton)(IntPtr)value
;	}
	public ref struct MenuToolButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MenuToolButtonPrivate(IntPtr pointer) => new MenuToolButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MenuToolButtonPrivate value) => value._pointer
;	}
	public ref struct ToolButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator ToolButtonClass(IntPtr pointer) => new ToolButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(ToolButtonClass value) => value._pointer
;	}
	public ref struct MenuToolButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator MenuToolButtonClass(IntPtr pointer) => new MenuToolButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(MenuToolButtonClass value) => value._pointer
;	}
	public ref struct MessageDialog
	{
		private IntPtr _pointer;
		public static explicit operator MessageDialog(IntPtr pointer) => new MessageDialog { _pointer = pointer };
		public static explicit operator IntPtr(MessageDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(MessageDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator MessageDialog(Gtk.Dialog value) => (MessageDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(MessageDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator MessageDialog(Gtk.Window value) => (MessageDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(MessageDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator MessageDialog(Gtk.Bin value) => (MessageDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(MessageDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator MessageDialog(Gtk.Container value) => (MessageDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(MessageDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator MessageDialog(Gtk.Widget value) => (MessageDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(MessageDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator MessageDialog(GObject.InitiallyUnowned value) => (MessageDialog)(IntPtr)value
;		public static implicit operator GObject.Object(MessageDialog value) => (GObject.Object)value._pointer
;		public static explicit operator MessageDialog(GObject.Object value) => (MessageDialog)(IntPtr)value
;	}
	public ref struct MessageDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MessageDialogPrivate(IntPtr pointer) => new MessageDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MessageDialogPrivate value) => value._pointer
;	}
	public ref struct MessageDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator MessageDialogClass(IntPtr pointer) => new MessageDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(MessageDialogClass value) => value._pointer
;	}
	public ref struct MiscPrivate
	{
		private IntPtr _pointer;
		public static explicit operator MiscPrivate(IntPtr pointer) => new MiscPrivate { _pointer = pointer };
		public static explicit operator IntPtr(MiscPrivate value) => value._pointer
;	}
	public ref struct ModelButton
	{
		private IntPtr _pointer;
		public static explicit operator ModelButton(IntPtr pointer) => new ModelButton { _pointer = pointer };
		public static explicit operator IntPtr(ModelButton value) => value._pointer
;		public static implicit operator Gtk.Button(ModelButton value) => (Gtk.Button)value._pointer
;		public static explicit operator ModelButton(Gtk.Button value) => (ModelButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(ModelButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator ModelButton(Gtk.Bin value) => (ModelButton)(IntPtr)value
;		public static implicit operator Gtk.Container(ModelButton value) => (Gtk.Container)value._pointer
;		public static explicit operator ModelButton(Gtk.Container value) => (ModelButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(ModelButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator ModelButton(Gtk.Widget value) => (ModelButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ModelButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ModelButton(GObject.InitiallyUnowned value) => (ModelButton)(IntPtr)value
;		public static implicit operator GObject.Object(ModelButton value) => (GObject.Object)value._pointer
;		public static explicit operator ModelButton(GObject.Object value) => (ModelButton)(IntPtr)value
;	}
	public ref struct MountOperation
	{
		private IntPtr _pointer;
		public static explicit operator MountOperation(IntPtr pointer) => new MountOperation { _pointer = pointer };
		public static explicit operator IntPtr(MountOperation value) => value._pointer
;		public static implicit operator Gio.MountOperation(MountOperation value) => (Gio.MountOperation)value._pointer
;		public static explicit operator MountOperation(Gio.MountOperation value) => (MountOperation)(IntPtr)value
;		public static implicit operator GObject.Object(MountOperation value) => (GObject.Object)value._pointer
;		public static explicit operator MountOperation(GObject.Object value) => (MountOperation)(IntPtr)value
;	}
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
	public ref struct Notebook
	{
		private IntPtr _pointer;
		public static explicit operator Notebook(IntPtr pointer) => new Notebook { _pointer = pointer };
		public static explicit operator IntPtr(Notebook value) => value._pointer
;		public static implicit operator Gtk.Container(Notebook value) => (Gtk.Container)value._pointer
;		public static explicit operator Notebook(Gtk.Container value) => (Notebook)(IntPtr)value
;		public static implicit operator Gtk.Widget(Notebook value) => (Gtk.Widget)value._pointer
;		public static explicit operator Notebook(Gtk.Widget value) => (Notebook)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Notebook value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Notebook(GObject.InitiallyUnowned value) => (Notebook)(IntPtr)value
;		public static implicit operator GObject.Object(Notebook value) => (GObject.Object)value._pointer
;		public static explicit operator Notebook(GObject.Object value) => (Notebook)(IntPtr)value
;	}
	public ref struct NotebookPrivate
	{
		private IntPtr _pointer;
		public static explicit operator NotebookPrivate(IntPtr pointer) => new NotebookPrivate { _pointer = pointer };
		public static explicit operator IntPtr(NotebookPrivate value) => value._pointer
;	}
	public ref struct NotebookAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator NotebookAccessiblePrivate(IntPtr pointer) => new NotebookAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(NotebookAccessiblePrivate value) => value._pointer
;	}
	public ref struct NotebookAccessible
	{
		private IntPtr _pointer;
		public static explicit operator NotebookAccessible(IntPtr pointer) => new NotebookAccessible { _pointer = pointer };
		public static explicit operator IntPtr(NotebookAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(NotebookAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator NotebookAccessible(Gtk.ContainerAccessible value) => (NotebookAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(NotebookAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator NotebookAccessible(Gtk.WidgetAccessible value) => (NotebookAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(NotebookAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator NotebookAccessible(Gtk.Accessible value) => (NotebookAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(NotebookAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator NotebookAccessible(Atk.Object value) => (NotebookAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(NotebookAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator NotebookAccessible(GObject.Object value) => (NotebookAccessible)(IntPtr)value
;	}
	public ref struct NotebookAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator NotebookAccessibleClass(IntPtr pointer) => new NotebookAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(NotebookAccessibleClass value) => value._pointer
;	}
	public enum NotebookTab
	{
		first = 0,
		last = 1,
	}
	public ref struct NotebookClass
	{
		private IntPtr _pointer;
		public static explicit operator NotebookClass(IntPtr pointer) => new NotebookClass { _pointer = pointer };
		public static explicit operator IntPtr(NotebookClass value) => value._pointer
;	}
	public ref struct NotebookPageAccessible
	{
		private IntPtr _pointer;
		public static explicit operator NotebookPageAccessible(IntPtr pointer) => new NotebookPageAccessible { _pointer = pointer };
		public static explicit operator IntPtr(NotebookPageAccessible value) => value._pointer
;		public static implicit operator Atk.Object(NotebookPageAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator NotebookPageAccessible(Atk.Object value) => (NotebookPageAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(NotebookPageAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator NotebookPageAccessible(GObject.Object value) => (NotebookPageAccessible)(IntPtr)value
;	}
	public ref struct NotebookPageAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator NotebookPageAccessiblePrivate(IntPtr pointer) => new NotebookPageAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(NotebookPageAccessiblePrivate value) => value._pointer
;	}
	public ref struct NotebookPageAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator NotebookPageAccessibleClass(IntPtr pointer) => new NotebookPageAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(NotebookPageAccessibleClass value) => value._pointer
;	}
	public enum NumberUpLayout
	{
		lrtb = 0,
		lrbt = 1,
		rltb = 2,
		rlbt = 3,
		tblr = 4,
		tbrl = 5,
		btlr = 6,
		btrl = 7,
	}
	public ref struct NumerableIcon
	{
		private IntPtr _pointer;
		public static explicit operator NumerableIcon(IntPtr pointer) => new NumerableIcon { _pointer = pointer };
		public static explicit operator IntPtr(NumerableIcon value) => value._pointer
;		public static implicit operator Gio.EmblemedIcon(NumerableIcon value) => (Gio.EmblemedIcon)value._pointer
;		public static explicit operator NumerableIcon(Gio.EmblemedIcon value) => (NumerableIcon)(IntPtr)value
;		public static implicit operator GObject.Object(NumerableIcon value) => (GObject.Object)value._pointer
;		public static explicit operator NumerableIcon(GObject.Object value) => (NumerableIcon)(IntPtr)value
;	}
	public ref struct NumerableIconPrivate
	{
		private IntPtr _pointer;
		public static explicit operator NumerableIconPrivate(IntPtr pointer) => new NumerableIconPrivate { _pointer = pointer };
		public static explicit operator IntPtr(NumerableIconPrivate value) => value._pointer
;	}
	public ref struct NumerableIconClass
	{
		private IntPtr _pointer;
		public static explicit operator NumerableIconClass(IntPtr pointer) => new NumerableIconClass { _pointer = pointer };
		public static explicit operator IntPtr(NumerableIconClass value) => value._pointer
;	}
	public ref struct OffscreenWindow
	{
		private IntPtr _pointer;
		public static explicit operator OffscreenWindow(IntPtr pointer) => new OffscreenWindow { _pointer = pointer };
		public static explicit operator IntPtr(OffscreenWindow value) => value._pointer
;		public static implicit operator Gtk.Window(OffscreenWindow value) => (Gtk.Window)value._pointer
;		public static explicit operator OffscreenWindow(Gtk.Window value) => (OffscreenWindow)(IntPtr)value
;		public static implicit operator Gtk.Bin(OffscreenWindow value) => (Gtk.Bin)value._pointer
;		public static explicit operator OffscreenWindow(Gtk.Bin value) => (OffscreenWindow)(IntPtr)value
;		public static implicit operator Gtk.Container(OffscreenWindow value) => (Gtk.Container)value._pointer
;		public static explicit operator OffscreenWindow(Gtk.Container value) => (OffscreenWindow)(IntPtr)value
;		public static implicit operator Gtk.Widget(OffscreenWindow value) => (Gtk.Widget)value._pointer
;		public static explicit operator OffscreenWindow(Gtk.Widget value) => (OffscreenWindow)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(OffscreenWindow value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator OffscreenWindow(GObject.InitiallyUnowned value) => (OffscreenWindow)(IntPtr)value
;		public static implicit operator GObject.Object(OffscreenWindow value) => (GObject.Object)value._pointer
;		public static explicit operator OffscreenWindow(GObject.Object value) => (OffscreenWindow)(IntPtr)value
;	}
	public ref struct OffscreenWindowClass
	{
		private IntPtr _pointer;
		public static explicit operator OffscreenWindowClass(IntPtr pointer) => new OffscreenWindowClass { _pointer = pointer };
		public static explicit operator IntPtr(OffscreenWindowClass value) => value._pointer
;	}
	public ref struct OrientableIface
	{
		private IntPtr _pointer;
		public static explicit operator OrientableIface(IntPtr pointer) => new OrientableIface { _pointer = pointer };
		public static explicit operator IntPtr(OrientableIface value) => value._pointer
;	}
	public ref struct Overlay
	{
		private IntPtr _pointer;
		public static explicit operator Overlay(IntPtr pointer) => new Overlay { _pointer = pointer };
		public static explicit operator IntPtr(Overlay value) => value._pointer
;		public static implicit operator Gtk.Bin(Overlay value) => (Gtk.Bin)value._pointer
;		public static explicit operator Overlay(Gtk.Bin value) => (Overlay)(IntPtr)value
;		public static implicit operator Gtk.Container(Overlay value) => (Gtk.Container)value._pointer
;		public static explicit operator Overlay(Gtk.Container value) => (Overlay)(IntPtr)value
;		public static implicit operator Gtk.Widget(Overlay value) => (Gtk.Widget)value._pointer
;		public static explicit operator Overlay(Gtk.Widget value) => (Overlay)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Overlay value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Overlay(GObject.InitiallyUnowned value) => (Overlay)(IntPtr)value
;		public static implicit operator GObject.Object(Overlay value) => (GObject.Object)value._pointer
;		public static explicit operator Overlay(GObject.Object value) => (Overlay)(IntPtr)value
;	}
	public ref struct OverlayPrivate
	{
		private IntPtr _pointer;
		public static explicit operator OverlayPrivate(IntPtr pointer) => new OverlayPrivate { _pointer = pointer };
		public static explicit operator IntPtr(OverlayPrivate value) => value._pointer
;	}
	public ref struct OverlayClass
	{
		private IntPtr _pointer;
		public static explicit operator OverlayClass(IntPtr pointer) => new OverlayClass { _pointer = pointer };
		public static explicit operator IntPtr(OverlayClass value) => value._pointer
;	}
	public enum PadActionType
	{
		button = 0,
		ring = 1,
		strip = 2,
	}
	public ref struct PadActionEntry
	{
		private IntPtr _pointer;
		public static explicit operator PadActionEntry(IntPtr pointer) => new PadActionEntry { _pointer = pointer };
		public static explicit operator IntPtr(PadActionEntry value) => value._pointer
;	}
	public ref struct PadController
	{
		private IntPtr _pointer;
		public static explicit operator PadController(IntPtr pointer) => new PadController { _pointer = pointer };
		public static explicit operator IntPtr(PadController value) => value._pointer
;		public static implicit operator Gtk.EventController(PadController value) => (Gtk.EventController)value._pointer
;		public static explicit operator PadController(Gtk.EventController value) => (PadController)(IntPtr)value
;		public static implicit operator GObject.Object(PadController value) => (GObject.Object)value._pointer
;		public static explicit operator PadController(GObject.Object value) => (PadController)(IntPtr)value
;	}
	public ref struct PadControllerClass
	{
		private IntPtr _pointer;
		public static explicit operator PadControllerClass(IntPtr pointer) => new PadControllerClass { _pointer = pointer };
		public static explicit operator IntPtr(PadControllerClass value) => value._pointer
;	}
	public enum PageOrientation
	{
		portrait = 0,
		landscape = 1,
		reverse_portrait = 2,
		reverse_landscape = 3,
	}
	public ref struct PageRange
	{
		private IntPtr _pointer;
		public static explicit operator PageRange(IntPtr pointer) => new PageRange { _pointer = pointer };
		public static explicit operator IntPtr(PageRange value) => value._pointer
;	}
	public enum PageSet
	{
		all = 0,
		even = 1,
		odd = 2,
	}
	public ref struct PageSetup
	{
		private IntPtr _pointer;
		public static explicit operator PageSetup(IntPtr pointer) => new PageSetup { _pointer = pointer };
		public static explicit operator IntPtr(PageSetup value) => value._pointer
;		public static implicit operator GObject.Object(PageSetup value) => (GObject.Object)value._pointer
;		public static explicit operator PageSetup(GObject.Object value) => (PageSetup)(IntPtr)value
;	}
	public enum Unit
	{
		none = 0,
		points = 1,
		inch = 2,
		mm = 3,
	}
	public ref struct PaperSize
	{
		private IntPtr _pointer;
		public static explicit operator PaperSize(IntPtr pointer) => new PaperSize { _pointer = pointer };
		public static explicit operator IntPtr(PaperSize value) => value._pointer
;	}
	public enum PanDirection
	{
		left = 0,
		right = 1,
		up = 2,
		down = 3,
	}
	public ref struct PanedPrivate
	{
		private IntPtr _pointer;
		public static explicit operator PanedPrivate(IntPtr pointer) => new PanedPrivate { _pointer = pointer };
		public static explicit operator IntPtr(PanedPrivate value) => value._pointer
;	}
	public ref struct PanedAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator PanedAccessiblePrivate(IntPtr pointer) => new PanedAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(PanedAccessiblePrivate value) => value._pointer
;	}
	public ref struct PanedAccessible
	{
		private IntPtr _pointer;
		public static explicit operator PanedAccessible(IntPtr pointer) => new PanedAccessible { _pointer = pointer };
		public static explicit operator IntPtr(PanedAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(PanedAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator PanedAccessible(Gtk.ContainerAccessible value) => (PanedAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(PanedAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator PanedAccessible(Gtk.WidgetAccessible value) => (PanedAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(PanedAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator PanedAccessible(Gtk.Accessible value) => (PanedAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(PanedAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator PanedAccessible(Atk.Object value) => (PanedAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(PanedAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator PanedAccessible(GObject.Object value) => (PanedAccessible)(IntPtr)value
;	}
	public ref struct PanedAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator PanedAccessibleClass(IntPtr pointer) => new PanedAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(PanedAccessibleClass value) => value._pointer
;	}
	public enum ScrollType
	{
		none = 0,
		jump = 1,
		step_backward = 2,
		step_forward = 3,
		page_backward = 4,
		page_forward = 5,
		step_up = 6,
		step_down = 7,
		page_up = 8,
		page_down = 9,
		step_left = 10,
		step_right = 11,
		page_left = 12,
		page_right = 13,
		start = 14,
		end = 15,
	}
	[Flags]
	public enum PlacesOpenFlags
	{
		normal = 1,
		new_tab = 2,
		new_window = 4,
	}
	public ref struct PlacesSidebar
	{
		private IntPtr _pointer;
		public static explicit operator PlacesSidebar(IntPtr pointer) => new PlacesSidebar { _pointer = pointer };
		public static explicit operator IntPtr(PlacesSidebar value) => value._pointer
;		public static implicit operator Gtk.ScrolledWindow(PlacesSidebar value) => (Gtk.ScrolledWindow)value._pointer
;		public static explicit operator PlacesSidebar(Gtk.ScrolledWindow value) => (PlacesSidebar)(IntPtr)value
;		public static implicit operator Gtk.Bin(PlacesSidebar value) => (Gtk.Bin)value._pointer
;		public static explicit operator PlacesSidebar(Gtk.Bin value) => (PlacesSidebar)(IntPtr)value
;		public static implicit operator Gtk.Container(PlacesSidebar value) => (Gtk.Container)value._pointer
;		public static explicit operator PlacesSidebar(Gtk.Container value) => (PlacesSidebar)(IntPtr)value
;		public static implicit operator Gtk.Widget(PlacesSidebar value) => (Gtk.Widget)value._pointer
;		public static explicit operator PlacesSidebar(Gtk.Widget value) => (PlacesSidebar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(PlacesSidebar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator PlacesSidebar(GObject.InitiallyUnowned value) => (PlacesSidebar)(IntPtr)value
;		public static implicit operator GObject.Object(PlacesSidebar value) => (GObject.Object)value._pointer
;		public static explicit operator PlacesSidebar(GObject.Object value) => (PlacesSidebar)(IntPtr)value
;	}
	public ref struct ScrolledWindow
	{
		private IntPtr _pointer;
		public static explicit operator ScrolledWindow(IntPtr pointer) => new ScrolledWindow { _pointer = pointer };
		public static explicit operator IntPtr(ScrolledWindow value) => value._pointer
;		public static implicit operator Gtk.Bin(ScrolledWindow value) => (Gtk.Bin)value._pointer
;		public static explicit operator ScrolledWindow(Gtk.Bin value) => (ScrolledWindow)(IntPtr)value
;		public static implicit operator Gtk.Container(ScrolledWindow value) => (Gtk.Container)value._pointer
;		public static explicit operator ScrolledWindow(Gtk.Container value) => (ScrolledWindow)(IntPtr)value
;		public static implicit operator Gtk.Widget(ScrolledWindow value) => (Gtk.Widget)value._pointer
;		public static explicit operator ScrolledWindow(Gtk.Widget value) => (ScrolledWindow)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ScrolledWindow value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ScrolledWindow(GObject.InitiallyUnowned value) => (ScrolledWindow)(IntPtr)value
;		public static implicit operator GObject.Object(ScrolledWindow value) => (GObject.Object)value._pointer
;		public static explicit operator ScrolledWindow(GObject.Object value) => (ScrolledWindow)(IntPtr)value
;	}
	public ref struct PlacesSidebarClass
	{
		private IntPtr _pointer;
		public static explicit operator PlacesSidebarClass(IntPtr pointer) => new PlacesSidebarClass { _pointer = pointer };
		public static explicit operator IntPtr(PlacesSidebarClass value) => value._pointer
;	}
	public ref struct Plug
	{
		private IntPtr _pointer;
		public static explicit operator Plug(IntPtr pointer) => new Plug { _pointer = pointer };
		public static explicit operator IntPtr(Plug value) => value._pointer
;		public static implicit operator Gtk.Window(Plug value) => (Gtk.Window)value._pointer
;		public static explicit operator Plug(Gtk.Window value) => (Plug)(IntPtr)value
;		public static implicit operator Gtk.Bin(Plug value) => (Gtk.Bin)value._pointer
;		public static explicit operator Plug(Gtk.Bin value) => (Plug)(IntPtr)value
;		public static implicit operator Gtk.Container(Plug value) => (Gtk.Container)value._pointer
;		public static explicit operator Plug(Gtk.Container value) => (Plug)(IntPtr)value
;		public static implicit operator Gtk.Widget(Plug value) => (Gtk.Widget)value._pointer
;		public static explicit operator Plug(Gtk.Widget value) => (Plug)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Plug value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Plug(GObject.InitiallyUnowned value) => (Plug)(IntPtr)value
;		public static implicit operator GObject.Object(Plug value) => (GObject.Object)value._pointer
;		public static explicit operator Plug(GObject.Object value) => (Plug)(IntPtr)value
;	}
	public ref struct PlugPrivate
	{
		private IntPtr _pointer;
		public static explicit operator PlugPrivate(IntPtr pointer) => new PlugPrivate { _pointer = pointer };
		public static explicit operator IntPtr(PlugPrivate value) => value._pointer
;	}
	public ref struct PlugClass
	{
		private IntPtr _pointer;
		public static explicit operator PlugClass(IntPtr pointer) => new PlugClass { _pointer = pointer };
		public static explicit operator IntPtr(PlugClass value) => value._pointer
;	}
	public enum PolicyType
	{
		always = 0,
		automatic = 1,
		never = 2,
		external = 3,
	}
	public enum PopoverConstraint
	{
		none = 0,
		window = 1,
	}
	public ref struct PopoverPrivate
	{
		private IntPtr _pointer;
		public static explicit operator PopoverPrivate(IntPtr pointer) => new PopoverPrivate { _pointer = pointer };
		public static explicit operator IntPtr(PopoverPrivate value) => value._pointer
;	}
	public ref struct PopoverAccessible
	{
		private IntPtr _pointer;
		public static explicit operator PopoverAccessible(IntPtr pointer) => new PopoverAccessible { _pointer = pointer };
		public static explicit operator IntPtr(PopoverAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(PopoverAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator PopoverAccessible(Gtk.ContainerAccessible value) => (PopoverAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(PopoverAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator PopoverAccessible(Gtk.WidgetAccessible value) => (PopoverAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(PopoverAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator PopoverAccessible(Gtk.Accessible value) => (PopoverAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(PopoverAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator PopoverAccessible(Atk.Object value) => (PopoverAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(PopoverAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator PopoverAccessible(GObject.Object value) => (PopoverAccessible)(IntPtr)value
;	}
	public ref struct PopoverAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator PopoverAccessibleClass(IntPtr pointer) => new PopoverAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(PopoverAccessibleClass value) => value._pointer
;	}
	public ref struct PopoverClass
	{
		private IntPtr _pointer;
		public static explicit operator PopoverClass(IntPtr pointer) => new PopoverClass { _pointer = pointer };
		public static explicit operator IntPtr(PopoverClass value) => value._pointer
;	}
	public ref struct PopoverMenu
	{
		private IntPtr _pointer;
		public static explicit operator PopoverMenu(IntPtr pointer) => new PopoverMenu { _pointer = pointer };
		public static explicit operator IntPtr(PopoverMenu value) => value._pointer
;		public static implicit operator Gtk.Popover(PopoverMenu value) => (Gtk.Popover)value._pointer
;		public static explicit operator PopoverMenu(Gtk.Popover value) => (PopoverMenu)(IntPtr)value
;		public static implicit operator Gtk.Bin(PopoverMenu value) => (Gtk.Bin)value._pointer
;		public static explicit operator PopoverMenu(Gtk.Bin value) => (PopoverMenu)(IntPtr)value
;		public static implicit operator Gtk.Container(PopoverMenu value) => (Gtk.Container)value._pointer
;		public static explicit operator PopoverMenu(Gtk.Container value) => (PopoverMenu)(IntPtr)value
;		public static implicit operator Gtk.Widget(PopoverMenu value) => (Gtk.Widget)value._pointer
;		public static explicit operator PopoverMenu(Gtk.Widget value) => (PopoverMenu)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(PopoverMenu value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator PopoverMenu(GObject.InitiallyUnowned value) => (PopoverMenu)(IntPtr)value
;		public static implicit operator GObject.Object(PopoverMenu value) => (GObject.Object)value._pointer
;		public static explicit operator PopoverMenu(GObject.Object value) => (PopoverMenu)(IntPtr)value
;	}
	public ref struct PopoverMenuClass
	{
		private IntPtr _pointer;
		public static explicit operator PopoverMenuClass(IntPtr pointer) => new PopoverMenuClass { _pointer = pointer };
		public static explicit operator IntPtr(PopoverMenuClass value) => value._pointer
;	}
	public ref struct PrintContext
	{
		private IntPtr _pointer;
		public static explicit operator PrintContext(IntPtr pointer) => new PrintContext { _pointer = pointer };
		public static explicit operator IntPtr(PrintContext value) => value._pointer
;		public static implicit operator GObject.Object(PrintContext value) => (GObject.Object)value._pointer
;		public static explicit operator PrintContext(GObject.Object value) => (PrintContext)(IntPtr)value
;	}
	public enum PrintDuplex
	{
		simplex = 0,
		horizontal = 1,
		vertical = 2,
	}
	public enum PrintError
	{
		general = 0,
		internal_error = 1,
		nomem = 2,
		invalid_file = 3,
	}
	public ref struct PrintOperationPreview
	{
		private IntPtr _pointer;
		public static explicit operator PrintOperationPreview(IntPtr pointer) => new PrintOperationPreview { _pointer = pointer };
		public static explicit operator IntPtr(PrintOperationPreview value) => value._pointer
;	}
	public ref struct PrintOperation
	{
		private IntPtr _pointer;
		public static explicit operator PrintOperation(IntPtr pointer) => new PrintOperation { _pointer = pointer };
		public static explicit operator IntPtr(PrintOperation value) => value._pointer
;		public static implicit operator GObject.Object(PrintOperation value) => (GObject.Object)value._pointer
;		public static explicit operator PrintOperation(GObject.Object value) => (PrintOperation)(IntPtr)value
;	}
	public ref struct PrintSettings
	{
		private IntPtr _pointer;
		public static explicit operator PrintSettings(IntPtr pointer) => new PrintSettings { _pointer = pointer };
		public static explicit operator IntPtr(PrintSettings value) => value._pointer
;		public static implicit operator GObject.Object(PrintSettings value) => (GObject.Object)value._pointer
;		public static explicit operator PrintSettings(GObject.Object value) => (PrintSettings)(IntPtr)value
;	}
	public enum PrintStatus
	{
		initial = 0,
		preparing = 1,
		generating_data = 2,
		sending_data = 3,
		pending = 4,
		pending_issue = 5,
		printing = 6,
		finished = 7,
		finished_aborted = 8,
	}
	public enum PrintOperationResult
	{
		error = 0,
		apply = 1,
		cancel = 2,
		in_progress = 3,
	}
	public enum PrintOperationAction
	{
		print_dialog = 0,
		print = 1,
		preview = 2,
		export = 3,
	}
	public ref struct PrintOperationPrivate
	{
		private IntPtr _pointer;
		public static explicit operator PrintOperationPrivate(IntPtr pointer) => new PrintOperationPrivate { _pointer = pointer };
		public static explicit operator IntPtr(PrintOperationPrivate value) => value._pointer
;	}
	public ref struct PrintOperationClass
	{
		private IntPtr _pointer;
		public static explicit operator PrintOperationClass(IntPtr pointer) => new PrintOperationClass { _pointer = pointer };
		public static explicit operator IntPtr(PrintOperationClass value) => value._pointer
;	}
	public ref struct PrintOperationPreviewIface
	{
		private IntPtr _pointer;
		public static explicit operator PrintOperationPreviewIface(IntPtr pointer) => new PrintOperationPreviewIface { _pointer = pointer };
		public static explicit operator IntPtr(PrintOperationPreviewIface value) => value._pointer
;	}
	public enum PrintPages
	{
		all = 0,
		current = 1,
		ranges = 2,
		selection = 3,
	}
	public enum PrintQuality
	{
		low = 0,
		normal = 1,
		high = 2,
		draft = 3,
	}
	public ref struct ProgressBar
	{
		private IntPtr _pointer;
		public static explicit operator ProgressBar(IntPtr pointer) => new ProgressBar { _pointer = pointer };
		public static explicit operator IntPtr(ProgressBar value) => value._pointer
;		public static implicit operator Gtk.Widget(ProgressBar value) => (Gtk.Widget)value._pointer
;		public static explicit operator ProgressBar(Gtk.Widget value) => (ProgressBar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ProgressBar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ProgressBar(GObject.InitiallyUnowned value) => (ProgressBar)(IntPtr)value
;		public static implicit operator GObject.Object(ProgressBar value) => (GObject.Object)value._pointer
;		public static explicit operator ProgressBar(GObject.Object value) => (ProgressBar)(IntPtr)value
;	}
	public ref struct ProgressBarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ProgressBarPrivate(IntPtr pointer) => new ProgressBarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ProgressBarPrivate value) => value._pointer
;	}
	public ref struct ProgressBarAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ProgressBarAccessiblePrivate(IntPtr pointer) => new ProgressBarAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ProgressBarAccessiblePrivate value) => value._pointer
;	}
	public ref struct ProgressBarAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ProgressBarAccessible(IntPtr pointer) => new ProgressBarAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ProgressBarAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(ProgressBarAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ProgressBarAccessible(Gtk.WidgetAccessible value) => (ProgressBarAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ProgressBarAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ProgressBarAccessible(Gtk.Accessible value) => (ProgressBarAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ProgressBarAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ProgressBarAccessible(Atk.Object value) => (ProgressBarAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ProgressBarAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ProgressBarAccessible(GObject.Object value) => (ProgressBarAccessible)(IntPtr)value
;	}
	public ref struct ProgressBarAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ProgressBarAccessibleClass(IntPtr pointer) => new ProgressBarAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ProgressBarAccessibleClass value) => value._pointer
;	}
	public ref struct ProgressBarClass
	{
		private IntPtr _pointer;
		public static explicit operator ProgressBarClass(IntPtr pointer) => new ProgressBarClass { _pointer = pointer };
		public static explicit operator IntPtr(ProgressBarClass value) => value._pointer
;	}
	public ref struct RadioAction
	{
		private IntPtr _pointer;
		public static explicit operator RadioAction(IntPtr pointer) => new RadioAction { _pointer = pointer };
		public static explicit operator IntPtr(RadioAction value) => value._pointer
;		public static implicit operator Gtk.ToggleAction(RadioAction value) => (Gtk.ToggleAction)value._pointer
;		public static explicit operator RadioAction(Gtk.ToggleAction value) => (RadioAction)(IntPtr)value
;		public static implicit operator Gtk.Action(RadioAction value) => (Gtk.Action)value._pointer
;		public static explicit operator RadioAction(Gtk.Action value) => (RadioAction)(IntPtr)value
;		public static implicit operator GObject.Object(RadioAction value) => (GObject.Object)value._pointer
;		public static explicit operator RadioAction(GObject.Object value) => (RadioAction)(IntPtr)value
;	}
	public ref struct ToggleAction
	{
		private IntPtr _pointer;
		public static explicit operator ToggleAction(IntPtr pointer) => new ToggleAction { _pointer = pointer };
		public static explicit operator IntPtr(ToggleAction value) => value._pointer
;		public static implicit operator Gtk.Action(ToggleAction value) => (Gtk.Action)value._pointer
;		public static explicit operator ToggleAction(Gtk.Action value) => (ToggleAction)(IntPtr)value
;		public static implicit operator GObject.Object(ToggleAction value) => (GObject.Object)value._pointer
;		public static explicit operator ToggleAction(GObject.Object value) => (ToggleAction)(IntPtr)value
;	}
	public ref struct RadioActionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RadioActionPrivate(IntPtr pointer) => new RadioActionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RadioActionPrivate value) => value._pointer
;	}
	public ref struct ToggleActionClass
	{
		private IntPtr _pointer;
		public static explicit operator ToggleActionClass(IntPtr pointer) => new ToggleActionClass { _pointer = pointer };
		public static explicit operator IntPtr(ToggleActionClass value) => value._pointer
;	}
	public ref struct RadioActionClass
	{
		private IntPtr _pointer;
		public static explicit operator RadioActionClass(IntPtr pointer) => new RadioActionClass { _pointer = pointer };
		public static explicit operator IntPtr(RadioActionClass value) => value._pointer
;	}
	public ref struct RadioButton
	{
		private IntPtr _pointer;
		public static explicit operator RadioButton(IntPtr pointer) => new RadioButton { _pointer = pointer };
		public static explicit operator IntPtr(RadioButton value) => value._pointer
;		public static implicit operator Gtk.CheckButton(RadioButton value) => (Gtk.CheckButton)value._pointer
;		public static explicit operator RadioButton(Gtk.CheckButton value) => (RadioButton)(IntPtr)value
;		public static implicit operator Gtk.ToggleButton(RadioButton value) => (Gtk.ToggleButton)value._pointer
;		public static explicit operator RadioButton(Gtk.ToggleButton value) => (RadioButton)(IntPtr)value
;		public static implicit operator Gtk.Button(RadioButton value) => (Gtk.Button)value._pointer
;		public static explicit operator RadioButton(Gtk.Button value) => (RadioButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(RadioButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator RadioButton(Gtk.Bin value) => (RadioButton)(IntPtr)value
;		public static implicit operator Gtk.Container(RadioButton value) => (Gtk.Container)value._pointer
;		public static explicit operator RadioButton(Gtk.Container value) => (RadioButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(RadioButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator RadioButton(Gtk.Widget value) => (RadioButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(RadioButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator RadioButton(GObject.InitiallyUnowned value) => (RadioButton)(IntPtr)value
;		public static implicit operator GObject.Object(RadioButton value) => (GObject.Object)value._pointer
;		public static explicit operator RadioButton(GObject.Object value) => (RadioButton)(IntPtr)value
;	}
	public ref struct RadioButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RadioButtonPrivate(IntPtr pointer) => new RadioButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RadioButtonPrivate value) => value._pointer
;	}
	public ref struct RadioButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator RadioButtonAccessiblePrivate(IntPtr pointer) => new RadioButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(RadioButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct RadioButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator RadioButtonAccessible(IntPtr pointer) => new RadioButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(RadioButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.ToggleButtonAccessible(RadioButtonAccessible value) => (Gtk.ToggleButtonAccessible)value._pointer
;		public static explicit operator RadioButtonAccessible(Gtk.ToggleButtonAccessible value) => (RadioButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ButtonAccessible(RadioButtonAccessible value) => (Gtk.ButtonAccessible)value._pointer
;		public static explicit operator RadioButtonAccessible(Gtk.ButtonAccessible value) => (RadioButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(RadioButtonAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator RadioButtonAccessible(Gtk.ContainerAccessible value) => (RadioButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(RadioButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator RadioButtonAccessible(Gtk.WidgetAccessible value) => (RadioButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(RadioButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator RadioButtonAccessible(Gtk.Accessible value) => (RadioButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(RadioButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator RadioButtonAccessible(Atk.Object value) => (RadioButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(RadioButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator RadioButtonAccessible(GObject.Object value) => (RadioButtonAccessible)(IntPtr)value
;	}
	public ref struct RadioButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator RadioButtonAccessibleClass(IntPtr pointer) => new RadioButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(RadioButtonAccessibleClass value) => value._pointer
;	}
	public ref struct RadioButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator RadioButtonClass(IntPtr pointer) => new RadioButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(RadioButtonClass value) => value._pointer
;	}
	public ref struct RadioMenuItem
	{
		private IntPtr _pointer;
		public static explicit operator RadioMenuItem(IntPtr pointer) => new RadioMenuItem { _pointer = pointer };
		public static explicit operator IntPtr(RadioMenuItem value) => value._pointer
;		public static implicit operator Gtk.CheckMenuItem(RadioMenuItem value) => (Gtk.CheckMenuItem)value._pointer
;		public static explicit operator RadioMenuItem(Gtk.CheckMenuItem value) => (RadioMenuItem)(IntPtr)value
;		public static implicit operator Gtk.MenuItem(RadioMenuItem value) => (Gtk.MenuItem)value._pointer
;		public static explicit operator RadioMenuItem(Gtk.MenuItem value) => (RadioMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Bin(RadioMenuItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator RadioMenuItem(Gtk.Bin value) => (RadioMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Container(RadioMenuItem value) => (Gtk.Container)value._pointer
;		public static explicit operator RadioMenuItem(Gtk.Container value) => (RadioMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(RadioMenuItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator RadioMenuItem(Gtk.Widget value) => (RadioMenuItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(RadioMenuItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator RadioMenuItem(GObject.InitiallyUnowned value) => (RadioMenuItem)(IntPtr)value
;		public static implicit operator GObject.Object(RadioMenuItem value) => (GObject.Object)value._pointer
;		public static explicit operator RadioMenuItem(GObject.Object value) => (RadioMenuItem)(IntPtr)value
;	}
	public ref struct RadioMenuItemPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RadioMenuItemPrivate(IntPtr pointer) => new RadioMenuItemPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RadioMenuItemPrivate value) => value._pointer
;	}
	public ref struct RadioMenuItemAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator RadioMenuItemAccessiblePrivate(IntPtr pointer) => new RadioMenuItemAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(RadioMenuItemAccessiblePrivate value) => value._pointer
;	}
	public ref struct RadioMenuItemAccessible
	{
		private IntPtr _pointer;
		public static explicit operator RadioMenuItemAccessible(IntPtr pointer) => new RadioMenuItemAccessible { _pointer = pointer };
		public static explicit operator IntPtr(RadioMenuItemAccessible value) => value._pointer
;		public static implicit operator Gtk.CheckMenuItemAccessible(RadioMenuItemAccessible value) => (Gtk.CheckMenuItemAccessible)value._pointer
;		public static explicit operator RadioMenuItemAccessible(Gtk.CheckMenuItemAccessible value) => (RadioMenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.MenuItemAccessible(RadioMenuItemAccessible value) => (Gtk.MenuItemAccessible)value._pointer
;		public static explicit operator RadioMenuItemAccessible(Gtk.MenuItemAccessible value) => (RadioMenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(RadioMenuItemAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator RadioMenuItemAccessible(Gtk.ContainerAccessible value) => (RadioMenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(RadioMenuItemAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator RadioMenuItemAccessible(Gtk.WidgetAccessible value) => (RadioMenuItemAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(RadioMenuItemAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator RadioMenuItemAccessible(Gtk.Accessible value) => (RadioMenuItemAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(RadioMenuItemAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator RadioMenuItemAccessible(Atk.Object value) => (RadioMenuItemAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(RadioMenuItemAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator RadioMenuItemAccessible(GObject.Object value) => (RadioMenuItemAccessible)(IntPtr)value
;	}
	public ref struct RadioMenuItemAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator RadioMenuItemAccessibleClass(IntPtr pointer) => new RadioMenuItemAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(RadioMenuItemAccessibleClass value) => value._pointer
;	}
	public ref struct RadioMenuItemClass
	{
		private IntPtr _pointer;
		public static explicit operator RadioMenuItemClass(IntPtr pointer) => new RadioMenuItemClass { _pointer = pointer };
		public static explicit operator IntPtr(RadioMenuItemClass value) => value._pointer
;	}
	public ref struct RadioToolButton
	{
		private IntPtr _pointer;
		public static explicit operator RadioToolButton(IntPtr pointer) => new RadioToolButton { _pointer = pointer };
		public static explicit operator IntPtr(RadioToolButton value) => value._pointer
;		public static implicit operator Gtk.ToggleToolButton(RadioToolButton value) => (Gtk.ToggleToolButton)value._pointer
;		public static explicit operator RadioToolButton(Gtk.ToggleToolButton value) => (RadioToolButton)(IntPtr)value
;		public static implicit operator Gtk.ToolButton(RadioToolButton value) => (Gtk.ToolButton)value._pointer
;		public static explicit operator RadioToolButton(Gtk.ToolButton value) => (RadioToolButton)(IntPtr)value
;		public static implicit operator Gtk.ToolItem(RadioToolButton value) => (Gtk.ToolItem)value._pointer
;		public static explicit operator RadioToolButton(Gtk.ToolItem value) => (RadioToolButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(RadioToolButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator RadioToolButton(Gtk.Bin value) => (RadioToolButton)(IntPtr)value
;		public static implicit operator Gtk.Container(RadioToolButton value) => (Gtk.Container)value._pointer
;		public static explicit operator RadioToolButton(Gtk.Container value) => (RadioToolButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(RadioToolButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator RadioToolButton(Gtk.Widget value) => (RadioToolButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(RadioToolButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator RadioToolButton(GObject.InitiallyUnowned value) => (RadioToolButton)(IntPtr)value
;		public static implicit operator GObject.Object(RadioToolButton value) => (GObject.Object)value._pointer
;		public static explicit operator RadioToolButton(GObject.Object value) => (RadioToolButton)(IntPtr)value
;	}
	public ref struct ToggleToolButton
	{
		private IntPtr _pointer;
		public static explicit operator ToggleToolButton(IntPtr pointer) => new ToggleToolButton { _pointer = pointer };
		public static explicit operator IntPtr(ToggleToolButton value) => value._pointer
;		public static implicit operator Gtk.ToolButton(ToggleToolButton value) => (Gtk.ToolButton)value._pointer
;		public static explicit operator ToggleToolButton(Gtk.ToolButton value) => (ToggleToolButton)(IntPtr)value
;		public static implicit operator Gtk.ToolItem(ToggleToolButton value) => (Gtk.ToolItem)value._pointer
;		public static explicit operator ToggleToolButton(Gtk.ToolItem value) => (ToggleToolButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(ToggleToolButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator ToggleToolButton(Gtk.Bin value) => (ToggleToolButton)(IntPtr)value
;		public static implicit operator Gtk.Container(ToggleToolButton value) => (Gtk.Container)value._pointer
;		public static explicit operator ToggleToolButton(Gtk.Container value) => (ToggleToolButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(ToggleToolButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator ToggleToolButton(Gtk.Widget value) => (ToggleToolButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ToggleToolButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ToggleToolButton(GObject.InitiallyUnowned value) => (ToggleToolButton)(IntPtr)value
;		public static implicit operator GObject.Object(ToggleToolButton value) => (GObject.Object)value._pointer
;		public static explicit operator ToggleToolButton(GObject.Object value) => (ToggleToolButton)(IntPtr)value
;	}
	public ref struct ToggleToolButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator ToggleToolButtonClass(IntPtr pointer) => new ToggleToolButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(ToggleToolButtonClass value) => value._pointer
;	}
	public ref struct RadioToolButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator RadioToolButtonClass(IntPtr pointer) => new RadioToolButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(RadioToolButtonClass value) => value._pointer
;	}
	public ref struct Range
	{
		private IntPtr _pointer;
		public static explicit operator Range(IntPtr pointer) => new Range { _pointer = pointer };
		public static explicit operator IntPtr(Range value) => value._pointer
;		public static implicit operator Gtk.Widget(Range value) => (Gtk.Widget)value._pointer
;		public static explicit operator Range(Gtk.Widget value) => (Range)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Range value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Range(GObject.InitiallyUnowned value) => (Range)(IntPtr)value
;		public static implicit operator GObject.Object(Range value) => (GObject.Object)value._pointer
;		public static explicit operator Range(GObject.Object value) => (Range)(IntPtr)value
;	}
	public ref struct RangePrivate
	{
		private IntPtr _pointer;
		public static explicit operator RangePrivate(IntPtr pointer) => new RangePrivate { _pointer = pointer };
		public static explicit operator IntPtr(RangePrivate value) => value._pointer
;	}
	public ref struct RangeAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator RangeAccessiblePrivate(IntPtr pointer) => new RangeAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(RangeAccessiblePrivate value) => value._pointer
;	}
	public ref struct RangeAccessible
	{
		private IntPtr _pointer;
		public static explicit operator RangeAccessible(IntPtr pointer) => new RangeAccessible { _pointer = pointer };
		public static explicit operator IntPtr(RangeAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(RangeAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator RangeAccessible(Gtk.WidgetAccessible value) => (RangeAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(RangeAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator RangeAccessible(Gtk.Accessible value) => (RangeAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(RangeAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator RangeAccessible(Atk.Object value) => (RangeAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(RangeAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator RangeAccessible(GObject.Object value) => (RangeAccessible)(IntPtr)value
;	}
	public ref struct RangeAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator RangeAccessibleClass(IntPtr pointer) => new RangeAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(RangeAccessibleClass value) => value._pointer
;	}
	public ref struct RangeClass
	{
		private IntPtr _pointer;
		public static explicit operator RangeClass(IntPtr pointer) => new RangeClass { _pointer = pointer };
		public static explicit operator IntPtr(RangeClass value) => value._pointer
;	}
	public ref struct RcContext
	{
		private IntPtr _pointer;
		public static explicit operator RcContext(IntPtr pointer) => new RcContext { _pointer = pointer };
		public static explicit operator IntPtr(RcContext value) => value._pointer
;	}
	[Flags]
	public enum RcFlags
	{
		fg = 1,
		bg = 2,
		text = 4,
		@base = 8,
	}
	public ref struct RcProperty
	{
		private IntPtr _pointer;
		public static explicit operator RcProperty(IntPtr pointer) => new RcProperty { _pointer = pointer };
		public static explicit operator IntPtr(RcProperty value) => value._pointer
;	}
	public ref struct RcStyle
	{
		private IntPtr _pointer;
		public static explicit operator RcStyle(IntPtr pointer) => new RcStyle { _pointer = pointer };
		public static explicit operator IntPtr(RcStyle value) => value._pointer
;		public static implicit operator GObject.Object(RcStyle value) => (GObject.Object)value._pointer
;		public static explicit operator RcStyle(GObject.Object value) => (RcStyle)(IntPtr)value
;	}
	public ref struct RcStyleClass
	{
		private IntPtr _pointer;
		public static explicit operator RcStyleClass(IntPtr pointer) => new RcStyleClass { _pointer = pointer };
		public static explicit operator IntPtr(RcStyleClass value) => value._pointer
;	}
	public enum RcTokenType
	{
		invalid = 270,
		include = 271,
		normal = 272,
		active = 273,
		prelight = 274,
		selected = 275,
		insensitive = 276,
		fg = 277,
		bg = 278,
		text = 279,
		@base = 280,
		xthickness = 281,
		ythickness = 282,
		font = 283,
		fontset = 284,
		font_name = 285,
		bg_pixmap = 286,
		pixmap_path = 287,
		style = 288,
		binding = 289,
		bind = 290,
		widget = 291,
		widget_class = 292,
		@class = 293,
		lowest = 294,
		gtk = 295,
		application = 296,
		theme = 297,
		rc = 298,
		highest = 299,
		engine = 300,
		module_path = 301,
		im_module_path = 302,
		im_module_file = 303,
		stock = 304,
		ltr = 305,
		rtl = 306,
		color = 307,
		unbind = 308,
		last = 309,
	}
	public ref struct RecentChooser
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooser(IntPtr pointer) => new RecentChooser { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooser value) => value._pointer
;	}
	public ref struct RecentManager
	{
		private IntPtr _pointer;
		public static explicit operator RecentManager(IntPtr pointer) => new RecentManager { _pointer = pointer };
		public static explicit operator IntPtr(RecentManager value) => value._pointer
;		public static implicit operator GObject.Object(RecentManager value) => (GObject.Object)value._pointer
;		public static explicit operator RecentManager(GObject.Object value) => (RecentManager)(IntPtr)value
;	}
	public ref struct RecentAction
	{
		private IntPtr _pointer;
		public static explicit operator RecentAction(IntPtr pointer) => new RecentAction { _pointer = pointer };
		public static explicit operator IntPtr(RecentAction value) => value._pointer
;		public static implicit operator Gtk.Action(RecentAction value) => (Gtk.Action)value._pointer
;		public static explicit operator RecentAction(Gtk.Action value) => (RecentAction)(IntPtr)value
;		public static implicit operator GObject.Object(RecentAction value) => (GObject.Object)value._pointer
;		public static explicit operator RecentAction(GObject.Object value) => (RecentAction)(IntPtr)value
;	}
	public ref struct RecentActionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RecentActionPrivate(IntPtr pointer) => new RecentActionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RecentActionPrivate value) => value._pointer
;	}
	public ref struct RecentActionClass
	{
		private IntPtr _pointer;
		public static explicit operator RecentActionClass(IntPtr pointer) => new RecentActionClass { _pointer = pointer };
		public static explicit operator IntPtr(RecentActionClass value) => value._pointer
;	}
	public ref struct RecentFilter
	{
		private IntPtr _pointer;
		public static explicit operator RecentFilter(IntPtr pointer) => new RecentFilter { _pointer = pointer };
		public static explicit operator IntPtr(RecentFilter value) => value._pointer
;		public static implicit operator GObject.InitiallyUnowned(RecentFilter value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator RecentFilter(GObject.InitiallyUnowned value) => (RecentFilter)(IntPtr)value
;		public static implicit operator GObject.Object(RecentFilter value) => (GObject.Object)value._pointer
;		public static explicit operator RecentFilter(GObject.Object value) => (RecentFilter)(IntPtr)value
;	}
	public ref struct RecentInfo
	{
		private IntPtr _pointer;
		public static explicit operator RecentInfo(IntPtr pointer) => new RecentInfo { _pointer = pointer };
		public static explicit operator IntPtr(RecentInfo value) => value._pointer
;	}
	public enum RecentSortType
	{
		none = 0,
		mru = 1,
		lru = 2,
		custom = 3,
	}
	public ref struct RecentChooserDialogPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserDialogPrivate(IntPtr pointer) => new RecentChooserDialogPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserDialogPrivate value) => value._pointer
;	}
	public ref struct RecentChooserDialog
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserDialog(IntPtr pointer) => new RecentChooserDialog { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserDialog value) => value._pointer
;		public static implicit operator Gtk.Dialog(RecentChooserDialog value) => (Gtk.Dialog)value._pointer
;		public static explicit operator RecentChooserDialog(Gtk.Dialog value) => (RecentChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Window(RecentChooserDialog value) => (Gtk.Window)value._pointer
;		public static explicit operator RecentChooserDialog(Gtk.Window value) => (RecentChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Bin(RecentChooserDialog value) => (Gtk.Bin)value._pointer
;		public static explicit operator RecentChooserDialog(Gtk.Bin value) => (RecentChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Container(RecentChooserDialog value) => (Gtk.Container)value._pointer
;		public static explicit operator RecentChooserDialog(Gtk.Container value) => (RecentChooserDialog)(IntPtr)value
;		public static implicit operator Gtk.Widget(RecentChooserDialog value) => (Gtk.Widget)value._pointer
;		public static explicit operator RecentChooserDialog(Gtk.Widget value) => (RecentChooserDialog)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(RecentChooserDialog value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator RecentChooserDialog(GObject.InitiallyUnowned value) => (RecentChooserDialog)(IntPtr)value
;		public static implicit operator GObject.Object(RecentChooserDialog value) => (GObject.Object)value._pointer
;		public static explicit operator RecentChooserDialog(GObject.Object value) => (RecentChooserDialog)(IntPtr)value
;	}
	public ref struct RecentChooserDialogClass
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserDialogClass(IntPtr pointer) => new RecentChooserDialogClass { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserDialogClass value) => value._pointer
;	}
	public enum RecentChooserError
	{
		not_found = 0,
		invalid_uri = 1,
	}
	public ref struct RecentChooserIface
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserIface(IntPtr pointer) => new RecentChooserIface { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserIface value) => value._pointer
;	}
	public ref struct RecentChooserMenu
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserMenu(IntPtr pointer) => new RecentChooserMenu { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserMenu value) => value._pointer
;		public static implicit operator Gtk.Menu(RecentChooserMenu value) => (Gtk.Menu)value._pointer
;		public static explicit operator RecentChooserMenu(Gtk.Menu value) => (RecentChooserMenu)(IntPtr)value
;		public static implicit operator Gtk.MenuShell(RecentChooserMenu value) => (Gtk.MenuShell)value._pointer
;		public static explicit operator RecentChooserMenu(Gtk.MenuShell value) => (RecentChooserMenu)(IntPtr)value
;		public static implicit operator Gtk.Container(RecentChooserMenu value) => (Gtk.Container)value._pointer
;		public static explicit operator RecentChooserMenu(Gtk.Container value) => (RecentChooserMenu)(IntPtr)value
;		public static implicit operator Gtk.Widget(RecentChooserMenu value) => (Gtk.Widget)value._pointer
;		public static explicit operator RecentChooserMenu(Gtk.Widget value) => (RecentChooserMenu)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(RecentChooserMenu value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator RecentChooserMenu(GObject.InitiallyUnowned value) => (RecentChooserMenu)(IntPtr)value
;		public static implicit operator GObject.Object(RecentChooserMenu value) => (GObject.Object)value._pointer
;		public static explicit operator RecentChooserMenu(GObject.Object value) => (RecentChooserMenu)(IntPtr)value
;	}
	public ref struct RecentChooserMenuPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserMenuPrivate(IntPtr pointer) => new RecentChooserMenuPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserMenuPrivate value) => value._pointer
;	}
	public ref struct RecentChooserMenuClass
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserMenuClass(IntPtr pointer) => new RecentChooserMenuClass { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserMenuClass value) => value._pointer
;	}
	public ref struct RecentChooserWidgetPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserWidgetPrivate(IntPtr pointer) => new RecentChooserWidgetPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserWidgetPrivate value) => value._pointer
;	}
	public ref struct RecentChooserWidget
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserWidget(IntPtr pointer) => new RecentChooserWidget { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserWidget value) => value._pointer
;		public static implicit operator Gtk.Box(RecentChooserWidget value) => (Gtk.Box)value._pointer
;		public static explicit operator RecentChooserWidget(Gtk.Box value) => (RecentChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Container(RecentChooserWidget value) => (Gtk.Container)value._pointer
;		public static explicit operator RecentChooserWidget(Gtk.Container value) => (RecentChooserWidget)(IntPtr)value
;		public static implicit operator Gtk.Widget(RecentChooserWidget value) => (Gtk.Widget)value._pointer
;		public static explicit operator RecentChooserWidget(Gtk.Widget value) => (RecentChooserWidget)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(RecentChooserWidget value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator RecentChooserWidget(GObject.InitiallyUnowned value) => (RecentChooserWidget)(IntPtr)value
;		public static implicit operator GObject.Object(RecentChooserWidget value) => (GObject.Object)value._pointer
;		public static explicit operator RecentChooserWidget(GObject.Object value) => (RecentChooserWidget)(IntPtr)value
;	}
	public ref struct RecentChooserWidgetClass
	{
		private IntPtr _pointer;
		public static explicit operator RecentChooserWidgetClass(IntPtr pointer) => new RecentChooserWidgetClass { _pointer = pointer };
		public static explicit operator IntPtr(RecentChooserWidgetClass value) => value._pointer
;	}
	public ref struct RecentData
	{
		private IntPtr _pointer;
		public static explicit operator RecentData(IntPtr pointer) => new RecentData { _pointer = pointer };
		public static explicit operator IntPtr(RecentData value) => value._pointer
;	}
	[Flags]
	public enum RecentFilterFlags
	{
		uri = 1,
		display_name = 2,
		mime_type = 4,
		application = 8,
		group = 16,
		age = 32,
	}
	public ref struct RecentFilterInfo
	{
		private IntPtr _pointer;
		public static explicit operator RecentFilterInfo(IntPtr pointer) => new RecentFilterInfo { _pointer = pointer };
		public static explicit operator IntPtr(RecentFilterInfo value) => value._pointer
;	}
	public ref struct RecentManagerPrivate
	{
		private IntPtr _pointer;
		public static explicit operator RecentManagerPrivate(IntPtr pointer) => new RecentManagerPrivate { _pointer = pointer };
		public static explicit operator IntPtr(RecentManagerPrivate value) => value._pointer
;	}
	public ref struct RecentManagerClass
	{
		private IntPtr _pointer;
		public static explicit operator RecentManagerClass(IntPtr pointer) => new RecentManagerClass { _pointer = pointer };
		public static explicit operator IntPtr(RecentManagerClass value) => value._pointer
;	}
	public enum RecentManagerError
	{
		not_found = 0,
		invalid_uri = 1,
		invalid_encoding = 2,
		not_registered = 3,
		read = 4,
		write = 5,
		unknown = 6,
	}
	[Flags]
	public enum RegionFlags
	{
		even = 1,
		odd = 2,
		first = 4,
		last = 8,
		only = 16,
		sorted = 32,
	}
	public ref struct RendererCellAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator RendererCellAccessiblePrivate(IntPtr pointer) => new RendererCellAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(RendererCellAccessiblePrivate value) => value._pointer
;	}
	public ref struct RequestedSize
	{
		private IntPtr _pointer;
		public static explicit operator RequestedSize(IntPtr pointer) => new RequestedSize { _pointer = pointer };
		public static explicit operator IntPtr(RequestedSize value) => value._pointer
;	}
	public enum ResponseType
	{
		none = -1,
		reject = -2,
		accept = -3,
		delete_event = -4,
		ok = -5,
		cancel = -6,
		close = -7,
		yes = -8,
		no = -9,
		apply = -10,
		help = -11,
	}
	public ref struct Revealer
	{
		private IntPtr _pointer;
		public static explicit operator Revealer(IntPtr pointer) => new Revealer { _pointer = pointer };
		public static explicit operator IntPtr(Revealer value) => value._pointer
;		public static implicit operator Gtk.Bin(Revealer value) => (Gtk.Bin)value._pointer
;		public static explicit operator Revealer(Gtk.Bin value) => (Revealer)(IntPtr)value
;		public static implicit operator Gtk.Container(Revealer value) => (Gtk.Container)value._pointer
;		public static explicit operator Revealer(Gtk.Container value) => (Revealer)(IntPtr)value
;		public static implicit operator Gtk.Widget(Revealer value) => (Gtk.Widget)value._pointer
;		public static explicit operator Revealer(Gtk.Widget value) => (Revealer)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Revealer value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Revealer(GObject.InitiallyUnowned value) => (Revealer)(IntPtr)value
;		public static implicit operator GObject.Object(Revealer value) => (GObject.Object)value._pointer
;		public static explicit operator Revealer(GObject.Object value) => (Revealer)(IntPtr)value
;	}
	public enum RevealerTransitionType
	{
		none = 0,
		crossfade = 1,
		slide_right = 2,
		slide_left = 3,
		slide_up = 4,
		slide_down = 5,
	}
	public ref struct RevealerClass
	{
		private IntPtr _pointer;
		public static explicit operator RevealerClass(IntPtr pointer) => new RevealerClass { _pointer = pointer };
		public static explicit operator IntPtr(RevealerClass value) => value._pointer
;	}
	public ref struct ScalePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ScalePrivate(IntPtr pointer) => new ScalePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ScalePrivate value) => value._pointer
;	}
	public ref struct ScaleAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ScaleAccessiblePrivate(IntPtr pointer) => new ScaleAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ScaleAccessiblePrivate value) => value._pointer
;	}
	public ref struct ScaleAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ScaleAccessible(IntPtr pointer) => new ScaleAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ScaleAccessible value) => value._pointer
;		public static implicit operator Gtk.RangeAccessible(ScaleAccessible value) => (Gtk.RangeAccessible)value._pointer
;		public static explicit operator ScaleAccessible(Gtk.RangeAccessible value) => (ScaleAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ScaleAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ScaleAccessible(Gtk.WidgetAccessible value) => (ScaleAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ScaleAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ScaleAccessible(Gtk.Accessible value) => (ScaleAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ScaleAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ScaleAccessible(Atk.Object value) => (ScaleAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ScaleAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ScaleAccessible(GObject.Object value) => (ScaleAccessible)(IntPtr)value
;	}
	public ref struct ScaleAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ScaleAccessibleClass(IntPtr pointer) => new ScaleAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ScaleAccessibleClass value) => value._pointer
;	}
	public ref struct ScaleButton
	{
		private IntPtr _pointer;
		public static explicit operator ScaleButton(IntPtr pointer) => new ScaleButton { _pointer = pointer };
		public static explicit operator IntPtr(ScaleButton value) => value._pointer
;		public static implicit operator Gtk.Button(ScaleButton value) => (Gtk.Button)value._pointer
;		public static explicit operator ScaleButton(Gtk.Button value) => (ScaleButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(ScaleButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator ScaleButton(Gtk.Bin value) => (ScaleButton)(IntPtr)value
;		public static implicit operator Gtk.Container(ScaleButton value) => (Gtk.Container)value._pointer
;		public static explicit operator ScaleButton(Gtk.Container value) => (ScaleButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(ScaleButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator ScaleButton(Gtk.Widget value) => (ScaleButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ScaleButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ScaleButton(GObject.InitiallyUnowned value) => (ScaleButton)(IntPtr)value
;		public static implicit operator GObject.Object(ScaleButton value) => (GObject.Object)value._pointer
;		public static explicit operator ScaleButton(GObject.Object value) => (ScaleButton)(IntPtr)value
;	}
	public ref struct ScaleButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ScaleButtonPrivate(IntPtr pointer) => new ScaleButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ScaleButtonPrivate value) => value._pointer
;	}
	public ref struct ScaleButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ScaleButtonAccessiblePrivate(IntPtr pointer) => new ScaleButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ScaleButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct ScaleButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ScaleButtonAccessible(IntPtr pointer) => new ScaleButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ScaleButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.ButtonAccessible(ScaleButtonAccessible value) => (Gtk.ButtonAccessible)value._pointer
;		public static explicit operator ScaleButtonAccessible(Gtk.ButtonAccessible value) => (ScaleButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.ContainerAccessible(ScaleButtonAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ScaleButtonAccessible(Gtk.ContainerAccessible value) => (ScaleButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ScaleButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ScaleButtonAccessible(Gtk.WidgetAccessible value) => (ScaleButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ScaleButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ScaleButtonAccessible(Gtk.Accessible value) => (ScaleButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ScaleButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ScaleButtonAccessible(Atk.Object value) => (ScaleButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ScaleButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ScaleButtonAccessible(GObject.Object value) => (ScaleButtonAccessible)(IntPtr)value
;	}
	public ref struct ScaleButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ScaleButtonAccessibleClass(IntPtr pointer) => new ScaleButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ScaleButtonAccessibleClass value) => value._pointer
;	}
	public ref struct ScaleButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator ScaleButtonClass(IntPtr pointer) => new ScaleButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(ScaleButtonClass value) => value._pointer
;	}
	public enum ScrollStep
	{
		steps = 0,
		pages = 1,
		ends = 2,
		horizontal_steps = 3,
		horizontal_pages = 4,
		horizontal_ends = 5,
	}
	public enum ScrollablePolicy
	{
		minimum = 0,
		natural = 1,
	}
	public ref struct ScrollableInterface
	{
		private IntPtr _pointer;
		public static explicit operator ScrollableInterface(IntPtr pointer) => new ScrollableInterface { _pointer = pointer };
		public static explicit operator IntPtr(ScrollableInterface value) => value._pointer
;	}
	public ref struct ScrolledWindowPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ScrolledWindowPrivate(IntPtr pointer) => new ScrolledWindowPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ScrolledWindowPrivate value) => value._pointer
;	}
	public ref struct ScrolledWindowAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ScrolledWindowAccessiblePrivate(IntPtr pointer) => new ScrolledWindowAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ScrolledWindowAccessiblePrivate value) => value._pointer
;	}
	public ref struct ScrolledWindowAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ScrolledWindowAccessible(IntPtr pointer) => new ScrolledWindowAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ScrolledWindowAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(ScrolledWindowAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator ScrolledWindowAccessible(Gtk.ContainerAccessible value) => (ScrolledWindowAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(ScrolledWindowAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator ScrolledWindowAccessible(Gtk.WidgetAccessible value) => (ScrolledWindowAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(ScrolledWindowAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator ScrolledWindowAccessible(Gtk.Accessible value) => (ScrolledWindowAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(ScrolledWindowAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ScrolledWindowAccessible(Atk.Object value) => (ScrolledWindowAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ScrolledWindowAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ScrolledWindowAccessible(GObject.Object value) => (ScrolledWindowAccessible)(IntPtr)value
;	}
	public ref struct ScrolledWindowAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ScrolledWindowAccessibleClass(IntPtr pointer) => new ScrolledWindowAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ScrolledWindowAccessibleClass value) => value._pointer
;	}
	public ref struct ScrolledWindowClass
	{
		private IntPtr _pointer;
		public static explicit operator ScrolledWindowClass(IntPtr pointer) => new ScrolledWindowClass { _pointer = pointer };
		public static explicit operator IntPtr(ScrolledWindowClass value) => value._pointer
;	}
	public ref struct SearchBar
	{
		private IntPtr _pointer;
		public static explicit operator SearchBar(IntPtr pointer) => new SearchBar { _pointer = pointer };
		public static explicit operator IntPtr(SearchBar value) => value._pointer
;		public static implicit operator Gtk.Bin(SearchBar value) => (Gtk.Bin)value._pointer
;		public static explicit operator SearchBar(Gtk.Bin value) => (SearchBar)(IntPtr)value
;		public static implicit operator Gtk.Container(SearchBar value) => (Gtk.Container)value._pointer
;		public static explicit operator SearchBar(Gtk.Container value) => (SearchBar)(IntPtr)value
;		public static implicit operator Gtk.Widget(SearchBar value) => (Gtk.Widget)value._pointer
;		public static explicit operator SearchBar(Gtk.Widget value) => (SearchBar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(SearchBar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator SearchBar(GObject.InitiallyUnowned value) => (SearchBar)(IntPtr)value
;		public static implicit operator GObject.Object(SearchBar value) => (GObject.Object)value._pointer
;		public static explicit operator SearchBar(GObject.Object value) => (SearchBar)(IntPtr)value
;	}
	public ref struct SearchBarClass
	{
		private IntPtr _pointer;
		public static explicit operator SearchBarClass(IntPtr pointer) => new SearchBarClass { _pointer = pointer };
		public static explicit operator IntPtr(SearchBarClass value) => value._pointer
;	}
	public ref struct SearchEntry
	{
		private IntPtr _pointer;
		public static explicit operator SearchEntry(IntPtr pointer) => new SearchEntry { _pointer = pointer };
		public static explicit operator IntPtr(SearchEntry value) => value._pointer
;		public static implicit operator Gtk.Entry(SearchEntry value) => (Gtk.Entry)value._pointer
;		public static explicit operator SearchEntry(Gtk.Entry value) => (SearchEntry)(IntPtr)value
;		public static implicit operator Gtk.Widget(SearchEntry value) => (Gtk.Widget)value._pointer
;		public static explicit operator SearchEntry(Gtk.Widget value) => (SearchEntry)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(SearchEntry value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator SearchEntry(GObject.InitiallyUnowned value) => (SearchEntry)(IntPtr)value
;		public static implicit operator GObject.Object(SearchEntry value) => (GObject.Object)value._pointer
;		public static explicit operator SearchEntry(GObject.Object value) => (SearchEntry)(IntPtr)value
;	}
	public ref struct SearchEntryClass
	{
		private IntPtr _pointer;
		public static explicit operator SearchEntryClass(IntPtr pointer) => new SearchEntryClass { _pointer = pointer };
		public static explicit operator IntPtr(SearchEntryClass value) => value._pointer
;	}
	public ref struct SeparatorPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SeparatorPrivate(IntPtr pointer) => new SeparatorPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SeparatorPrivate value) => value._pointer
;	}
	public ref struct SeparatorMenuItem
	{
		private IntPtr _pointer;
		public static explicit operator SeparatorMenuItem(IntPtr pointer) => new SeparatorMenuItem { _pointer = pointer };
		public static explicit operator IntPtr(SeparatorMenuItem value) => value._pointer
;		public static implicit operator Gtk.MenuItem(SeparatorMenuItem value) => (Gtk.MenuItem)value._pointer
;		public static explicit operator SeparatorMenuItem(Gtk.MenuItem value) => (SeparatorMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Bin(SeparatorMenuItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator SeparatorMenuItem(Gtk.Bin value) => (SeparatorMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Container(SeparatorMenuItem value) => (Gtk.Container)value._pointer
;		public static explicit operator SeparatorMenuItem(Gtk.Container value) => (SeparatorMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(SeparatorMenuItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator SeparatorMenuItem(Gtk.Widget value) => (SeparatorMenuItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(SeparatorMenuItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator SeparatorMenuItem(GObject.InitiallyUnowned value) => (SeparatorMenuItem)(IntPtr)value
;		public static implicit operator GObject.Object(SeparatorMenuItem value) => (GObject.Object)value._pointer
;		public static explicit operator SeparatorMenuItem(GObject.Object value) => (SeparatorMenuItem)(IntPtr)value
;	}
	public ref struct SeparatorMenuItemClass
	{
		private IntPtr _pointer;
		public static explicit operator SeparatorMenuItemClass(IntPtr pointer) => new SeparatorMenuItemClass { _pointer = pointer };
		public static explicit operator IntPtr(SeparatorMenuItemClass value) => value._pointer
;	}
	public ref struct SeparatorToolItem
	{
		private IntPtr _pointer;
		public static explicit operator SeparatorToolItem(IntPtr pointer) => new SeparatorToolItem { _pointer = pointer };
		public static explicit operator IntPtr(SeparatorToolItem value) => value._pointer
;		public static implicit operator Gtk.ToolItem(SeparatorToolItem value) => (Gtk.ToolItem)value._pointer
;		public static explicit operator SeparatorToolItem(Gtk.ToolItem value) => (SeparatorToolItem)(IntPtr)value
;		public static implicit operator Gtk.Bin(SeparatorToolItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator SeparatorToolItem(Gtk.Bin value) => (SeparatorToolItem)(IntPtr)value
;		public static implicit operator Gtk.Container(SeparatorToolItem value) => (Gtk.Container)value._pointer
;		public static explicit operator SeparatorToolItem(Gtk.Container value) => (SeparatorToolItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(SeparatorToolItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator SeparatorToolItem(Gtk.Widget value) => (SeparatorToolItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(SeparatorToolItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator SeparatorToolItem(GObject.InitiallyUnowned value) => (SeparatorToolItem)(IntPtr)value
;		public static implicit operator GObject.Object(SeparatorToolItem value) => (GObject.Object)value._pointer
;		public static explicit operator SeparatorToolItem(GObject.Object value) => (SeparatorToolItem)(IntPtr)value
;	}
	public ref struct SeparatorToolItemPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SeparatorToolItemPrivate(IntPtr pointer) => new SeparatorToolItemPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SeparatorToolItemPrivate value) => value._pointer
;	}
	public ref struct ToolItemClass
	{
		private IntPtr _pointer;
		public static explicit operator ToolItemClass(IntPtr pointer) => new ToolItemClass { _pointer = pointer };
		public static explicit operator IntPtr(ToolItemClass value) => value._pointer
;	}
	public ref struct SeparatorToolItemClass
	{
		private IntPtr _pointer;
		public static explicit operator SeparatorToolItemClass(IntPtr pointer) => new SeparatorToolItemClass { _pointer = pointer };
		public static explicit operator IntPtr(SeparatorToolItemClass value) => value._pointer
;	}
	public ref struct SettingsValue
	{
		private IntPtr _pointer;
		public static explicit operator SettingsValue(IntPtr pointer) => new SettingsValue { _pointer = pointer };
		public static explicit operator IntPtr(SettingsValue value) => value._pointer
;	}
	public enum ToolbarStyle
	{
		icons = 0,
		text = 1,
		both = 2,
		both_horiz = 3,
	}
	public ref struct SettingsPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SettingsPrivate(IntPtr pointer) => new SettingsPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SettingsPrivate value) => value._pointer
;	}
	public ref struct SettingsClass
	{
		private IntPtr _pointer;
		public static explicit operator SettingsClass(IntPtr pointer) => new SettingsClass { _pointer = pointer };
		public static explicit operator IntPtr(SettingsClass value) => value._pointer
;	}
	public ref struct ShortcutLabel
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutLabel(IntPtr pointer) => new ShortcutLabel { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutLabel value) => value._pointer
;		public static implicit operator Gtk.Box(ShortcutLabel value) => (Gtk.Box)value._pointer
;		public static explicit operator ShortcutLabel(Gtk.Box value) => (ShortcutLabel)(IntPtr)value
;		public static implicit operator Gtk.Container(ShortcutLabel value) => (Gtk.Container)value._pointer
;		public static explicit operator ShortcutLabel(Gtk.Container value) => (ShortcutLabel)(IntPtr)value
;		public static implicit operator Gtk.Widget(ShortcutLabel value) => (Gtk.Widget)value._pointer
;		public static explicit operator ShortcutLabel(Gtk.Widget value) => (ShortcutLabel)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ShortcutLabel value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ShortcutLabel(GObject.InitiallyUnowned value) => (ShortcutLabel)(IntPtr)value
;		public static implicit operator GObject.Object(ShortcutLabel value) => (GObject.Object)value._pointer
;		public static explicit operator ShortcutLabel(GObject.Object value) => (ShortcutLabel)(IntPtr)value
;	}
	public ref struct ShortcutLabelClass
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutLabelClass(IntPtr pointer) => new ShortcutLabelClass { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutLabelClass value) => value._pointer
;	}
	public enum ShortcutType
	{
		accelerator = 0,
		gesture_pinch = 1,
		gesture_stretch = 2,
		gesture_rotate_clockwise = 3,
		gesture_rotate_counterclockwise = 4,
		gesture_two_finger_swipe_left = 5,
		gesture_two_finger_swipe_right = 6,
		gesture = 7,
	}
	public ref struct SizeGroup
	{
		private IntPtr _pointer;
		public static explicit operator SizeGroup(IntPtr pointer) => new SizeGroup { _pointer = pointer };
		public static explicit operator IntPtr(SizeGroup value) => value._pointer
;		public static implicit operator GObject.Object(SizeGroup value) => (GObject.Object)value._pointer
;		public static explicit operator SizeGroup(GObject.Object value) => (SizeGroup)(IntPtr)value
;	}
	public ref struct ShortcutsGroup
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsGroup(IntPtr pointer) => new ShortcutsGroup { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsGroup value) => value._pointer
;		public static implicit operator Gtk.Box(ShortcutsGroup value) => (Gtk.Box)value._pointer
;		public static explicit operator ShortcutsGroup(Gtk.Box value) => (ShortcutsGroup)(IntPtr)value
;		public static implicit operator Gtk.Container(ShortcutsGroup value) => (Gtk.Container)value._pointer
;		public static explicit operator ShortcutsGroup(Gtk.Container value) => (ShortcutsGroup)(IntPtr)value
;		public static implicit operator Gtk.Widget(ShortcutsGroup value) => (Gtk.Widget)value._pointer
;		public static explicit operator ShortcutsGroup(Gtk.Widget value) => (ShortcutsGroup)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ShortcutsGroup value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ShortcutsGroup(GObject.InitiallyUnowned value) => (ShortcutsGroup)(IntPtr)value
;		public static implicit operator GObject.Object(ShortcutsGroup value) => (GObject.Object)value._pointer
;		public static explicit operator ShortcutsGroup(GObject.Object value) => (ShortcutsGroup)(IntPtr)value
;	}
	public ref struct ShortcutsGroupClass
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsGroupClass(IntPtr pointer) => new ShortcutsGroupClass { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsGroupClass value) => value._pointer
;	}
	public ref struct ShortcutsSection
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsSection(IntPtr pointer) => new ShortcutsSection { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsSection value) => value._pointer
;		public static implicit operator Gtk.Box(ShortcutsSection value) => (Gtk.Box)value._pointer
;		public static explicit operator ShortcutsSection(Gtk.Box value) => (ShortcutsSection)(IntPtr)value
;		public static implicit operator Gtk.Container(ShortcutsSection value) => (Gtk.Container)value._pointer
;		public static explicit operator ShortcutsSection(Gtk.Container value) => (ShortcutsSection)(IntPtr)value
;		public static implicit operator Gtk.Widget(ShortcutsSection value) => (Gtk.Widget)value._pointer
;		public static explicit operator ShortcutsSection(Gtk.Widget value) => (ShortcutsSection)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ShortcutsSection value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ShortcutsSection(GObject.InitiallyUnowned value) => (ShortcutsSection)(IntPtr)value
;		public static implicit operator GObject.Object(ShortcutsSection value) => (GObject.Object)value._pointer
;		public static explicit operator ShortcutsSection(GObject.Object value) => (ShortcutsSection)(IntPtr)value
;	}
	public ref struct ShortcutsSectionClass
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsSectionClass(IntPtr pointer) => new ShortcutsSectionClass { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsSectionClass value) => value._pointer
;	}
	public ref struct ShortcutsShortcut
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsShortcut(IntPtr pointer) => new ShortcutsShortcut { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsShortcut value) => value._pointer
;		public static implicit operator Gtk.Box(ShortcutsShortcut value) => (Gtk.Box)value._pointer
;		public static explicit operator ShortcutsShortcut(Gtk.Box value) => (ShortcutsShortcut)(IntPtr)value
;		public static implicit operator Gtk.Container(ShortcutsShortcut value) => (Gtk.Container)value._pointer
;		public static explicit operator ShortcutsShortcut(Gtk.Container value) => (ShortcutsShortcut)(IntPtr)value
;		public static implicit operator Gtk.Widget(ShortcutsShortcut value) => (Gtk.Widget)value._pointer
;		public static explicit operator ShortcutsShortcut(Gtk.Widget value) => (ShortcutsShortcut)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ShortcutsShortcut value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ShortcutsShortcut(GObject.InitiallyUnowned value) => (ShortcutsShortcut)(IntPtr)value
;		public static implicit operator GObject.Object(ShortcutsShortcut value) => (GObject.Object)value._pointer
;		public static explicit operator ShortcutsShortcut(GObject.Object value) => (ShortcutsShortcut)(IntPtr)value
;	}
	public ref struct ShortcutsShortcutClass
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsShortcutClass(IntPtr pointer) => new ShortcutsShortcutClass { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsShortcutClass value) => value._pointer
;	}
	public ref struct ShortcutsWindowClass
	{
		private IntPtr _pointer;
		public static explicit operator ShortcutsWindowClass(IntPtr pointer) => new ShortcutsWindowClass { _pointer = pointer };
		public static explicit operator IntPtr(ShortcutsWindowClass value) => value._pointer
;	}
	public enum SizeGroupMode
	{
		none = 0,
		horizontal = 1,
		vertical = 2,
		both = 3,
	}
	public ref struct SizeGroupPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SizeGroupPrivate(IntPtr pointer) => new SizeGroupPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SizeGroupPrivate value) => value._pointer
;	}
	public ref struct SizeGroupClass
	{
		private IntPtr _pointer;
		public static explicit operator SizeGroupClass(IntPtr pointer) => new SizeGroupClass { _pointer = pointer };
		public static explicit operator IntPtr(SizeGroupClass value) => value._pointer
;	}
	public ref struct Socket
	{
		private IntPtr _pointer;
		public static explicit operator Socket(IntPtr pointer) => new Socket { _pointer = pointer };
		public static explicit operator IntPtr(Socket value) => value._pointer
;		public static implicit operator Gtk.Container(Socket value) => (Gtk.Container)value._pointer
;		public static explicit operator Socket(Gtk.Container value) => (Socket)(IntPtr)value
;		public static implicit operator Gtk.Widget(Socket value) => (Gtk.Widget)value._pointer
;		public static explicit operator Socket(Gtk.Widget value) => (Socket)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Socket value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Socket(GObject.InitiallyUnowned value) => (Socket)(IntPtr)value
;		public static implicit operator GObject.Object(Socket value) => (GObject.Object)value._pointer
;		public static explicit operator Socket(GObject.Object value) => (Socket)(IntPtr)value
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
	public enum SortType
	{
		ascending = 0,
		descending = 1,
	}
	public ref struct SpinButton
	{
		private IntPtr _pointer;
		public static explicit operator SpinButton(IntPtr pointer) => new SpinButton { _pointer = pointer };
		public static explicit operator IntPtr(SpinButton value) => value._pointer
;		public static implicit operator Gtk.Entry(SpinButton value) => (Gtk.Entry)value._pointer
;		public static explicit operator SpinButton(Gtk.Entry value) => (SpinButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(SpinButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator SpinButton(Gtk.Widget value) => (SpinButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(SpinButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator SpinButton(GObject.InitiallyUnowned value) => (SpinButton)(IntPtr)value
;		public static implicit operator GObject.Object(SpinButton value) => (GObject.Object)value._pointer
;		public static explicit operator SpinButton(GObject.Object value) => (SpinButton)(IntPtr)value
;	}
	public enum SpinButtonUpdatePolicy
	{
		always = 0,
		if_valid = 1,
	}
	public enum SpinType
	{
		step_forward = 0,
		step_backward = 1,
		page_forward = 2,
		page_backward = 3,
		home = 4,
		end = 5,
		user_defined = 6,
	}
	public ref struct SpinButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SpinButtonPrivate(IntPtr pointer) => new SpinButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SpinButtonPrivate value) => value._pointer
;	}
	public ref struct SpinButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator SpinButtonAccessiblePrivate(IntPtr pointer) => new SpinButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(SpinButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct SpinButtonAccessible
	{
		private IntPtr _pointer;
		public static explicit operator SpinButtonAccessible(IntPtr pointer) => new SpinButtonAccessible { _pointer = pointer };
		public static explicit operator IntPtr(SpinButtonAccessible value) => value._pointer
;		public static implicit operator Gtk.EntryAccessible(SpinButtonAccessible value) => (Gtk.EntryAccessible)value._pointer
;		public static explicit operator SpinButtonAccessible(Gtk.EntryAccessible value) => (SpinButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(SpinButtonAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator SpinButtonAccessible(Gtk.WidgetAccessible value) => (SpinButtonAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(SpinButtonAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator SpinButtonAccessible(Gtk.Accessible value) => (SpinButtonAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(SpinButtonAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator SpinButtonAccessible(Atk.Object value) => (SpinButtonAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(SpinButtonAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator SpinButtonAccessible(GObject.Object value) => (SpinButtonAccessible)(IntPtr)value
;	}
	public ref struct SpinButtonAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator SpinButtonAccessibleClass(IntPtr pointer) => new SpinButtonAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(SpinButtonAccessibleClass value) => value._pointer
;	}
	public ref struct SpinButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator SpinButtonClass(IntPtr pointer) => new SpinButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(SpinButtonClass value) => value._pointer
;	}
	public ref struct Spinner
	{
		private IntPtr _pointer;
		public static explicit operator Spinner(IntPtr pointer) => new Spinner { _pointer = pointer };
		public static explicit operator IntPtr(Spinner value) => value._pointer
;		public static implicit operator Gtk.Widget(Spinner value) => (Gtk.Widget)value._pointer
;		public static explicit operator Spinner(Gtk.Widget value) => (Spinner)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Spinner value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Spinner(GObject.InitiallyUnowned value) => (Spinner)(IntPtr)value
;		public static implicit operator GObject.Object(Spinner value) => (GObject.Object)value._pointer
;		public static explicit operator Spinner(GObject.Object value) => (Spinner)(IntPtr)value
;	}
	public ref struct SpinnerPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SpinnerPrivate(IntPtr pointer) => new SpinnerPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SpinnerPrivate value) => value._pointer
;	}
	public ref struct SpinnerAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator SpinnerAccessiblePrivate(IntPtr pointer) => new SpinnerAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(SpinnerAccessiblePrivate value) => value._pointer
;	}
	public ref struct SpinnerAccessible
	{
		private IntPtr _pointer;
		public static explicit operator SpinnerAccessible(IntPtr pointer) => new SpinnerAccessible { _pointer = pointer };
		public static explicit operator IntPtr(SpinnerAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(SpinnerAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator SpinnerAccessible(Gtk.WidgetAccessible value) => (SpinnerAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(SpinnerAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator SpinnerAccessible(Gtk.Accessible value) => (SpinnerAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(SpinnerAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator SpinnerAccessible(Atk.Object value) => (SpinnerAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(SpinnerAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator SpinnerAccessible(GObject.Object value) => (SpinnerAccessible)(IntPtr)value
;	}
	public ref struct SpinnerAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator SpinnerAccessibleClass(IntPtr pointer) => new SpinnerAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(SpinnerAccessibleClass value) => value._pointer
;	}
	public ref struct SpinnerClass
	{
		private IntPtr _pointer;
		public static explicit operator SpinnerClass(IntPtr pointer) => new SpinnerClass { _pointer = pointer };
		public static explicit operator IntPtr(SpinnerClass value) => value._pointer
;	}
	public ref struct Stack
	{
		private IntPtr _pointer;
		public static explicit operator Stack(IntPtr pointer) => new Stack { _pointer = pointer };
		public static explicit operator IntPtr(Stack value) => value._pointer
;		public static implicit operator Gtk.Container(Stack value) => (Gtk.Container)value._pointer
;		public static explicit operator Stack(Gtk.Container value) => (Stack)(IntPtr)value
;		public static implicit operator Gtk.Widget(Stack value) => (Gtk.Widget)value._pointer
;		public static explicit operator Stack(Gtk.Widget value) => (Stack)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Stack value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Stack(GObject.InitiallyUnowned value) => (Stack)(IntPtr)value
;		public static implicit operator GObject.Object(Stack value) => (GObject.Object)value._pointer
;		public static explicit operator Stack(GObject.Object value) => (Stack)(IntPtr)value
;	}
	public enum StackTransitionType
	{
		none = 0,
		crossfade = 1,
		slide_right = 2,
		slide_left = 3,
		slide_up = 4,
		slide_down = 5,
		slide_left_right = 6,
		slide_up_down = 7,
		over_up = 8,
		over_down = 9,
		over_left = 10,
		over_right = 11,
		under_up = 12,
		under_down = 13,
		under_left = 14,
		under_right = 15,
		over_up_down = 16,
		over_down_up = 17,
		over_left_right = 18,
		over_right_left = 19,
	}
	public ref struct StackAccessible
	{
		private IntPtr _pointer;
		public static explicit operator StackAccessible(IntPtr pointer) => new StackAccessible { _pointer = pointer };
		public static explicit operator IntPtr(StackAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(StackAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator StackAccessible(Gtk.ContainerAccessible value) => (StackAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(StackAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator StackAccessible(Gtk.WidgetAccessible value) => (StackAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(StackAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator StackAccessible(Gtk.Accessible value) => (StackAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(StackAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator StackAccessible(Atk.Object value) => (StackAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(StackAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator StackAccessible(GObject.Object value) => (StackAccessible)(IntPtr)value
;	}
	public ref struct StackAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator StackAccessibleClass(IntPtr pointer) => new StackAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(StackAccessibleClass value) => value._pointer
;	}
	public ref struct StackClass
	{
		private IntPtr _pointer;
		public static explicit operator StackClass(IntPtr pointer) => new StackClass { _pointer = pointer };
		public static explicit operator IntPtr(StackClass value) => value._pointer
;	}
	public ref struct StackSidebar
	{
		private IntPtr _pointer;
		public static explicit operator StackSidebar(IntPtr pointer) => new StackSidebar { _pointer = pointer };
		public static explicit operator IntPtr(StackSidebar value) => value._pointer
;		public static implicit operator Gtk.Bin(StackSidebar value) => (Gtk.Bin)value._pointer
;		public static explicit operator StackSidebar(Gtk.Bin value) => (StackSidebar)(IntPtr)value
;		public static implicit operator Gtk.Container(StackSidebar value) => (Gtk.Container)value._pointer
;		public static explicit operator StackSidebar(Gtk.Container value) => (StackSidebar)(IntPtr)value
;		public static implicit operator Gtk.Widget(StackSidebar value) => (Gtk.Widget)value._pointer
;		public static explicit operator StackSidebar(Gtk.Widget value) => (StackSidebar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(StackSidebar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator StackSidebar(GObject.InitiallyUnowned value) => (StackSidebar)(IntPtr)value
;		public static implicit operator GObject.Object(StackSidebar value) => (GObject.Object)value._pointer
;		public static explicit operator StackSidebar(GObject.Object value) => (StackSidebar)(IntPtr)value
;	}
	public ref struct StackSidebarClass
	{
		private IntPtr _pointer;
		public static explicit operator StackSidebarClass(IntPtr pointer) => new StackSidebarClass { _pointer = pointer };
		public static explicit operator IntPtr(StackSidebarClass value) => value._pointer
;	}
	public ref struct StackSidebarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator StackSidebarPrivate(IntPtr pointer) => new StackSidebarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(StackSidebarPrivate value) => value._pointer
;	}
	public ref struct StackSwitcher
	{
		private IntPtr _pointer;
		public static explicit operator StackSwitcher(IntPtr pointer) => new StackSwitcher { _pointer = pointer };
		public static explicit operator IntPtr(StackSwitcher value) => value._pointer
;		public static implicit operator Gtk.Box(StackSwitcher value) => (Gtk.Box)value._pointer
;		public static explicit operator StackSwitcher(Gtk.Box value) => (StackSwitcher)(IntPtr)value
;		public static implicit operator Gtk.Container(StackSwitcher value) => (Gtk.Container)value._pointer
;		public static explicit operator StackSwitcher(Gtk.Container value) => (StackSwitcher)(IntPtr)value
;		public static implicit operator Gtk.Widget(StackSwitcher value) => (Gtk.Widget)value._pointer
;		public static explicit operator StackSwitcher(Gtk.Widget value) => (StackSwitcher)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(StackSwitcher value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator StackSwitcher(GObject.InitiallyUnowned value) => (StackSwitcher)(IntPtr)value
;		public static implicit operator GObject.Object(StackSwitcher value) => (GObject.Object)value._pointer
;		public static explicit operator StackSwitcher(GObject.Object value) => (StackSwitcher)(IntPtr)value
;	}
	public ref struct StackSwitcherClass
	{
		private IntPtr _pointer;
		public static explicit operator StackSwitcherClass(IntPtr pointer) => new StackSwitcherClass { _pointer = pointer };
		public static explicit operator IntPtr(StackSwitcherClass value) => value._pointer
;	}
	public ref struct StatusIcon
	{
		private IntPtr _pointer;
		public static explicit operator StatusIcon(IntPtr pointer) => new StatusIcon { _pointer = pointer };
		public static explicit operator IntPtr(StatusIcon value) => value._pointer
;		public static implicit operator GObject.Object(StatusIcon value) => (GObject.Object)value._pointer
;		public static explicit operator StatusIcon(GObject.Object value) => (StatusIcon)(IntPtr)value
;	}
	public ref struct StatusIconPrivate
	{
		private IntPtr _pointer;
		public static explicit operator StatusIconPrivate(IntPtr pointer) => new StatusIconPrivate { _pointer = pointer };
		public static explicit operator IntPtr(StatusIconPrivate value) => value._pointer
;	}
	public ref struct StatusIconClass
	{
		private IntPtr _pointer;
		public static explicit operator StatusIconClass(IntPtr pointer) => new StatusIconClass { _pointer = pointer };
		public static explicit operator IntPtr(StatusIconClass value) => value._pointer
;	}
	public ref struct Statusbar
	{
		private IntPtr _pointer;
		public static explicit operator Statusbar(IntPtr pointer) => new Statusbar { _pointer = pointer };
		public static explicit operator IntPtr(Statusbar value) => value._pointer
;		public static implicit operator Gtk.Box(Statusbar value) => (Gtk.Box)value._pointer
;		public static explicit operator Statusbar(Gtk.Box value) => (Statusbar)(IntPtr)value
;		public static implicit operator Gtk.Container(Statusbar value) => (Gtk.Container)value._pointer
;		public static explicit operator Statusbar(Gtk.Container value) => (Statusbar)(IntPtr)value
;		public static implicit operator Gtk.Widget(Statusbar value) => (Gtk.Widget)value._pointer
;		public static explicit operator Statusbar(Gtk.Widget value) => (Statusbar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Statusbar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Statusbar(GObject.InitiallyUnowned value) => (Statusbar)(IntPtr)value
;		public static implicit operator GObject.Object(Statusbar value) => (GObject.Object)value._pointer
;		public static explicit operator Statusbar(GObject.Object value) => (Statusbar)(IntPtr)value
;	}
	public ref struct StatusbarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator StatusbarPrivate(IntPtr pointer) => new StatusbarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(StatusbarPrivate value) => value._pointer
;	}
	public ref struct StatusbarAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator StatusbarAccessiblePrivate(IntPtr pointer) => new StatusbarAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(StatusbarAccessiblePrivate value) => value._pointer
;	}
	public ref struct StatusbarAccessible
	{
		private IntPtr _pointer;
		public static explicit operator StatusbarAccessible(IntPtr pointer) => new StatusbarAccessible { _pointer = pointer };
		public static explicit operator IntPtr(StatusbarAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(StatusbarAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator StatusbarAccessible(Gtk.ContainerAccessible value) => (StatusbarAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(StatusbarAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator StatusbarAccessible(Gtk.WidgetAccessible value) => (StatusbarAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(StatusbarAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator StatusbarAccessible(Gtk.Accessible value) => (StatusbarAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(StatusbarAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator StatusbarAccessible(Atk.Object value) => (StatusbarAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(StatusbarAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator StatusbarAccessible(GObject.Object value) => (StatusbarAccessible)(IntPtr)value
;	}
	public ref struct StatusbarAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator StatusbarAccessibleClass(IntPtr pointer) => new StatusbarAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(StatusbarAccessibleClass value) => value._pointer
;	}
	public ref struct StatusbarClass
	{
		private IntPtr _pointer;
		public static explicit operator StatusbarClass(IntPtr pointer) => new StatusbarClass { _pointer = pointer };
		public static explicit operator IntPtr(StatusbarClass value) => value._pointer
;	}
	public ref struct StockItem
	{
		private IntPtr _pointer;
		public static explicit operator StockItem(IntPtr pointer) => new StockItem { _pointer = pointer };
		public static explicit operator IntPtr(StockItem value) => value._pointer
;	}
	public ref struct StyleClass
	{
		private IntPtr _pointer;
		public static explicit operator StyleClass(IntPtr pointer) => new StyleClass { _pointer = pointer };
		public static explicit operator IntPtr(StyleClass value) => value._pointer
;	}
	[Flags]
	public enum StyleContextPrintFlags
	{
		none = 0,
		recurse = 1,
		show_style = 2,
	}
	public ref struct StyleContextPrivate
	{
		private IntPtr _pointer;
		public static explicit operator StyleContextPrivate(IntPtr pointer) => new StyleContextPrivate { _pointer = pointer };
		public static explicit operator IntPtr(StyleContextPrivate value) => value._pointer
;	}
	public ref struct StyleContextClass
	{
		private IntPtr _pointer;
		public static explicit operator StyleContextClass(IntPtr pointer) => new StyleContextClass { _pointer = pointer };
		public static explicit operator IntPtr(StyleContextClass value) => value._pointer
;	}
	public ref struct StylePropertiesPrivate
	{
		private IntPtr _pointer;
		public static explicit operator StylePropertiesPrivate(IntPtr pointer) => new StylePropertiesPrivate { _pointer = pointer };
		public static explicit operator IntPtr(StylePropertiesPrivate value) => value._pointer
;	}
	public ref struct StylePropertiesClass
	{
		private IntPtr _pointer;
		public static explicit operator StylePropertiesClass(IntPtr pointer) => new StylePropertiesClass { _pointer = pointer };
		public static explicit operator IntPtr(StylePropertiesClass value) => value._pointer
;	}
	public ref struct StyleProviderIface
	{
		private IntPtr _pointer;
		public static explicit operator StyleProviderIface(IntPtr pointer) => new StyleProviderIface { _pointer = pointer };
		public static explicit operator IntPtr(StyleProviderIface value) => value._pointer
;	}
	public ref struct Switch
	{
		private IntPtr _pointer;
		public static explicit operator Switch(IntPtr pointer) => new Switch { _pointer = pointer };
		public static explicit operator IntPtr(Switch value) => value._pointer
;		public static implicit operator Gtk.Widget(Switch value) => (Gtk.Widget)value._pointer
;		public static explicit operator Switch(Gtk.Widget value) => (Switch)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Switch value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Switch(GObject.InitiallyUnowned value) => (Switch)(IntPtr)value
;		public static implicit operator GObject.Object(Switch value) => (GObject.Object)value._pointer
;		public static explicit operator Switch(GObject.Object value) => (Switch)(IntPtr)value
;	}
	public ref struct SwitchPrivate
	{
		private IntPtr _pointer;
		public static explicit operator SwitchPrivate(IntPtr pointer) => new SwitchPrivate { _pointer = pointer };
		public static explicit operator IntPtr(SwitchPrivate value) => value._pointer
;	}
	public ref struct SwitchAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator SwitchAccessiblePrivate(IntPtr pointer) => new SwitchAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(SwitchAccessiblePrivate value) => value._pointer
;	}
	public ref struct SwitchAccessible
	{
		private IntPtr _pointer;
		public static explicit operator SwitchAccessible(IntPtr pointer) => new SwitchAccessible { _pointer = pointer };
		public static explicit operator IntPtr(SwitchAccessible value) => value._pointer
;		public static implicit operator Gtk.WidgetAccessible(SwitchAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator SwitchAccessible(Gtk.WidgetAccessible value) => (SwitchAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(SwitchAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator SwitchAccessible(Gtk.Accessible value) => (SwitchAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(SwitchAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator SwitchAccessible(Atk.Object value) => (SwitchAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(SwitchAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator SwitchAccessible(GObject.Object value) => (SwitchAccessible)(IntPtr)value
;	}
	public ref struct SwitchAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator SwitchAccessibleClass(IntPtr pointer) => new SwitchAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(SwitchAccessibleClass value) => value._pointer
;	}
	public ref struct SwitchClass
	{
		private IntPtr _pointer;
		public static explicit operator SwitchClass(IntPtr pointer) => new SwitchClass { _pointer = pointer };
		public static explicit operator IntPtr(SwitchClass value) => value._pointer
;	}
	public ref struct Table
	{
		private IntPtr _pointer;
		public static explicit operator Table(IntPtr pointer) => new Table { _pointer = pointer };
		public static explicit operator IntPtr(Table value) => value._pointer
;		public static implicit operator Gtk.Container(Table value) => (Gtk.Container)value._pointer
;		public static explicit operator Table(Gtk.Container value) => (Table)(IntPtr)value
;		public static implicit operator Gtk.Widget(Table value) => (Gtk.Widget)value._pointer
;		public static explicit operator Table(Gtk.Widget value) => (Table)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Table value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Table(GObject.InitiallyUnowned value) => (Table)(IntPtr)value
;		public static implicit operator GObject.Object(Table value) => (GObject.Object)value._pointer
;		public static explicit operator Table(GObject.Object value) => (Table)(IntPtr)value
;	}
	public ref struct TablePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TablePrivate(IntPtr pointer) => new TablePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TablePrivate value) => value._pointer
;	}
	public ref struct TableChild
	{
		private IntPtr _pointer;
		public static explicit operator TableChild(IntPtr pointer) => new TableChild { _pointer = pointer };
		public static explicit operator IntPtr(TableChild value) => value._pointer
;	}
	public ref struct TableClass
	{
		private IntPtr _pointer;
		public static explicit operator TableClass(IntPtr pointer) => new TableClass { _pointer = pointer };
		public static explicit operator IntPtr(TableClass value) => value._pointer
;	}
	public ref struct TableRowCol
	{
		private IntPtr _pointer;
		public static explicit operator TableRowCol(IntPtr pointer) => new TableRowCol { _pointer = pointer };
		public static explicit operator IntPtr(TableRowCol value) => value._pointer
;	}
	[Flags]
	public enum TargetFlags
	{
		same_app = 1,
		same_widget = 2,
		other_app = 4,
		other_widget = 8,
	}
	public ref struct TargetPair
	{
		private IntPtr _pointer;
		public static explicit operator TargetPair(IntPtr pointer) => new TargetPair { _pointer = pointer };
		public static explicit operator IntPtr(TargetPair value) => value._pointer
;	}
	public ref struct TearoffMenuItemPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TearoffMenuItemPrivate(IntPtr pointer) => new TearoffMenuItemPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TearoffMenuItemPrivate value) => value._pointer
;	}
	public ref struct TearoffMenuItem
	{
		private IntPtr _pointer;
		public static explicit operator TearoffMenuItem(IntPtr pointer) => new TearoffMenuItem { _pointer = pointer };
		public static explicit operator IntPtr(TearoffMenuItem value) => value._pointer
;		public static implicit operator Gtk.MenuItem(TearoffMenuItem value) => (Gtk.MenuItem)value._pointer
;		public static explicit operator TearoffMenuItem(Gtk.MenuItem value) => (TearoffMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Bin(TearoffMenuItem value) => (Gtk.Bin)value._pointer
;		public static explicit operator TearoffMenuItem(Gtk.Bin value) => (TearoffMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Container(TearoffMenuItem value) => (Gtk.Container)value._pointer
;		public static explicit operator TearoffMenuItem(Gtk.Container value) => (TearoffMenuItem)(IntPtr)value
;		public static implicit operator Gtk.Widget(TearoffMenuItem value) => (Gtk.Widget)value._pointer
;		public static explicit operator TearoffMenuItem(Gtk.Widget value) => (TearoffMenuItem)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(TearoffMenuItem value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator TearoffMenuItem(GObject.InitiallyUnowned value) => (TearoffMenuItem)(IntPtr)value
;		public static implicit operator GObject.Object(TearoffMenuItem value) => (GObject.Object)value._pointer
;		public static explicit operator TearoffMenuItem(GObject.Object value) => (TearoffMenuItem)(IntPtr)value
;	}
	public ref struct TearoffMenuItemClass
	{
		private IntPtr _pointer;
		public static explicit operator TearoffMenuItemClass(IntPtr pointer) => new TearoffMenuItemClass { _pointer = pointer };
		public static explicit operator IntPtr(TearoffMenuItemClass value) => value._pointer
;	}
	public ref struct TextAppearance
	{
		private IntPtr _pointer;
		public static explicit operator TextAppearance(IntPtr pointer) => new TextAppearance { _pointer = pointer };
		public static explicit operator IntPtr(TextAppearance value) => value._pointer
;	}
	public enum WrapMode
	{
		none = 0,
		@char = 1,
		word = 2,
		word_char = 3,
	}
	public ref struct TextAttributes
	{
		private IntPtr _pointer;
		public static explicit operator TextAttributes(IntPtr pointer) => new TextAttributes { _pointer = pointer };
		public static explicit operator IntPtr(TextAttributes value) => value._pointer
;	}
	public ref struct TextBTree
	{
		private IntPtr _pointer;
		public static explicit operator TextBTree(IntPtr pointer) => new TextBTree { _pointer = pointer };
		public static explicit operator IntPtr(TextBTree value) => value._pointer
;	}
	public ref struct TextTagTable
	{
		private IntPtr _pointer;
		public static explicit operator TextTagTable(IntPtr pointer) => new TextTagTable { _pointer = pointer };
		public static explicit operator IntPtr(TextTagTable value) => value._pointer
;		public static implicit operator GObject.Object(TextTagTable value) => (GObject.Object)value._pointer
;		public static explicit operator TextTagTable(GObject.Object value) => (TextTagTable)(IntPtr)value
;	}
	public ref struct TextMark
	{
		private IntPtr _pointer;
		public static explicit operator TextMark(IntPtr pointer) => new TextMark { _pointer = pointer };
		public static explicit operator IntPtr(TextMark value) => value._pointer
;		public static implicit operator GObject.Object(TextMark value) => (GObject.Object)value._pointer
;		public static explicit operator TextMark(GObject.Object value) => (TextMark)(IntPtr)value
;	}
	public ref struct TextIter
	{
		private IntPtr _pointer;
		public static explicit operator TextIter(IntPtr pointer) => new TextIter { _pointer = pointer };
		public static explicit operator IntPtr(TextIter value) => value._pointer
;	}
	public ref struct TextTag
	{
		private IntPtr _pointer;
		public static explicit operator TextTag(IntPtr pointer) => new TextTag { _pointer = pointer };
		public static explicit operator IntPtr(TextTag value) => value._pointer
;		public static implicit operator GObject.Object(TextTag value) => (GObject.Object)value._pointer
;		public static explicit operator TextTag(GObject.Object value) => (TextTag)(IntPtr)value
;	}
	public ref struct TextChildAnchor
	{
		private IntPtr _pointer;
		public static explicit operator TextChildAnchor(IntPtr pointer) => new TextChildAnchor { _pointer = pointer };
		public static explicit operator IntPtr(TextChildAnchor value) => value._pointer
;		public static implicit operator GObject.Object(TextChildAnchor value) => (GObject.Object)value._pointer
;		public static explicit operator TextChildAnchor(GObject.Object value) => (TextChildAnchor)(IntPtr)value
;	}
	public ref struct TextBufferPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TextBufferPrivate(IntPtr pointer) => new TextBufferPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TextBufferPrivate value) => value._pointer
;	}
	public ref struct TextBufferClass
	{
		private IntPtr _pointer;
		public static explicit operator TextBufferClass(IntPtr pointer) => new TextBufferClass { _pointer = pointer };
		public static explicit operator IntPtr(TextBufferClass value) => value._pointer
;	}
	public enum TextBufferTargetInfo
	{
		buffer_contents = -1,
		rich_text = -2,
		text = -3,
	}
	public ref struct TextCellAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TextCellAccessiblePrivate(IntPtr pointer) => new TextCellAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TextCellAccessiblePrivate value) => value._pointer
;	}
	public ref struct TextCellAccessible
	{
		private IntPtr _pointer;
		public static explicit operator TextCellAccessible(IntPtr pointer) => new TextCellAccessible { _pointer = pointer };
		public static explicit operator IntPtr(TextCellAccessible value) => value._pointer
;		public static implicit operator Gtk.RendererCellAccessible(TextCellAccessible value) => (Gtk.RendererCellAccessible)value._pointer
;		public static explicit operator TextCellAccessible(Gtk.RendererCellAccessible value) => (TextCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.CellAccessible(TextCellAccessible value) => (Gtk.CellAccessible)value._pointer
;		public static explicit operator TextCellAccessible(Gtk.CellAccessible value) => (TextCellAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(TextCellAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator TextCellAccessible(Gtk.Accessible value) => (TextCellAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(TextCellAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator TextCellAccessible(Atk.Object value) => (TextCellAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(TextCellAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator TextCellAccessible(GObject.Object value) => (TextCellAccessible)(IntPtr)value
;	}
	public ref struct TextCellAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator TextCellAccessibleClass(IntPtr pointer) => new TextCellAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(TextCellAccessibleClass value) => value._pointer
;	}
	public ref struct TextChildAnchorClass
	{
		private IntPtr _pointer;
		public static explicit operator TextChildAnchorClass(IntPtr pointer) => new TextChildAnchorClass { _pointer = pointer };
		public static explicit operator IntPtr(TextChildAnchorClass value) => value._pointer
;	}
	public enum TextExtendSelection
	{
		word = 0,
		line = 1,
	}
	[Flags]
	public enum TextSearchFlags
	{
		visible_only = 1,
		text_only = 2,
		case_insensitive = 4,
	}
	public ref struct TextMarkClass
	{
		private IntPtr _pointer;
		public static explicit operator TextMarkClass(IntPtr pointer) => new TextMarkClass { _pointer = pointer };
		public static explicit operator IntPtr(TextMarkClass value) => value._pointer
;	}
	public ref struct TextTagPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TextTagPrivate(IntPtr pointer) => new TextTagPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TextTagPrivate value) => value._pointer
;	}
	public ref struct TextTagClass
	{
		private IntPtr _pointer;
		public static explicit operator TextTagClass(IntPtr pointer) => new TextTagClass { _pointer = pointer };
		public static explicit operator IntPtr(TextTagClass value) => value._pointer
;	}
	public ref struct TextTagTablePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TextTagTablePrivate(IntPtr pointer) => new TextTagTablePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TextTagTablePrivate value) => value._pointer
;	}
	public ref struct TextTagTableClass
	{
		private IntPtr _pointer;
		public static explicit operator TextTagTableClass(IntPtr pointer) => new TextTagTableClass { _pointer = pointer };
		public static explicit operator IntPtr(TextTagTableClass value) => value._pointer
;	}
	public ref struct TextView
	{
		private IntPtr _pointer;
		public static explicit operator TextView(IntPtr pointer) => new TextView { _pointer = pointer };
		public static explicit operator IntPtr(TextView value) => value._pointer
;		public static implicit operator Gtk.Container(TextView value) => (Gtk.Container)value._pointer
;		public static explicit operator TextView(Gtk.Container value) => (TextView)(IntPtr)value
;		public static implicit operator Gtk.Widget(TextView value) => (Gtk.Widget)value._pointer
;		public static explicit operator TextView(Gtk.Widget value) => (TextView)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(TextView value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator TextView(GObject.InitiallyUnowned value) => (TextView)(IntPtr)value
;		public static implicit operator GObject.Object(TextView value) => (GObject.Object)value._pointer
;		public static explicit operator TextView(GObject.Object value) => (TextView)(IntPtr)value
;	}
	public enum TextWindowType
	{
		@private = 0,
		widget = 1,
		text = 2,
		left = 3,
		right = 4,
		top = 5,
		bottom = 6,
	}
	public ref struct TextViewPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TextViewPrivate(IntPtr pointer) => new TextViewPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TextViewPrivate value) => value._pointer
;	}
	public ref struct TextViewAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TextViewAccessiblePrivate(IntPtr pointer) => new TextViewAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TextViewAccessiblePrivate value) => value._pointer
;	}
	public ref struct TextViewAccessible
	{
		private IntPtr _pointer;
		public static explicit operator TextViewAccessible(IntPtr pointer) => new TextViewAccessible { _pointer = pointer };
		public static explicit operator IntPtr(TextViewAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(TextViewAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator TextViewAccessible(Gtk.ContainerAccessible value) => (TextViewAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(TextViewAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator TextViewAccessible(Gtk.WidgetAccessible value) => (TextViewAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(TextViewAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator TextViewAccessible(Gtk.Accessible value) => (TextViewAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(TextViewAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator TextViewAccessible(Atk.Object value) => (TextViewAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(TextViewAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator TextViewAccessible(GObject.Object value) => (TextViewAccessible)(IntPtr)value
;	}
	public ref struct TextViewAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator TextViewAccessibleClass(IntPtr pointer) => new TextViewAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(TextViewAccessibleClass value) => value._pointer
;	}
	public enum TextViewLayer
	{
		below = 0,
		above = 1,
		below_text = 2,
		above_text = 3,
	}
	public ref struct TextViewClass
	{
		private IntPtr _pointer;
		public static explicit operator TextViewClass(IntPtr pointer) => new TextViewClass { _pointer = pointer };
		public static explicit operator IntPtr(TextViewClass value) => value._pointer
;	}
	public ref struct ThemeEngine
	{
		private IntPtr _pointer;
		public static explicit operator ThemeEngine(IntPtr pointer) => new ThemeEngine { _pointer = pointer };
		public static explicit operator IntPtr(ThemeEngine value) => value._pointer
;	}
	public ref struct ThemingEngine
	{
		private IntPtr _pointer;
		public static explicit operator ThemingEngine(IntPtr pointer) => new ThemingEngine { _pointer = pointer };
		public static explicit operator IntPtr(ThemingEngine value) => value._pointer
;		public static implicit operator GObject.Object(ThemingEngine value) => (GObject.Object)value._pointer
;		public static explicit operator ThemingEngine(GObject.Object value) => (ThemingEngine)(IntPtr)value
;	}
	public ref struct ThemingEnginePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ThemingEnginePrivate(IntPtr pointer) => new ThemingEnginePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ThemingEnginePrivate value) => value._pointer
;	}
	public ref struct ThemingEngineClass
	{
		private IntPtr _pointer;
		public static explicit operator ThemingEngineClass(IntPtr pointer) => new ThemingEngineClass { _pointer = pointer };
		public static explicit operator IntPtr(ThemingEngineClass value) => value._pointer
;	}
	public ref struct ToggleActionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToggleActionPrivate(IntPtr pointer) => new ToggleActionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToggleActionPrivate value) => value._pointer
;	}
	public ref struct ToggleButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToggleButtonPrivate(IntPtr pointer) => new ToggleButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToggleButtonPrivate value) => value._pointer
;	}
	public ref struct ToggleButtonAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToggleButtonAccessiblePrivate(IntPtr pointer) => new ToggleButtonAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToggleButtonAccessiblePrivate value) => value._pointer
;	}
	public ref struct ToggleToolButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToggleToolButtonPrivate(IntPtr pointer) => new ToggleToolButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToggleToolButtonPrivate value) => value._pointer
;	}
	public ref struct ToolButtonPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToolButtonPrivate(IntPtr pointer) => new ToolButtonPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToolButtonPrivate value) => value._pointer
;	}
	public ref struct ToolItemPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToolItemPrivate(IntPtr pointer) => new ToolItemPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToolItemPrivate value) => value._pointer
;	}
	public ref struct ToolShell
	{
		private IntPtr _pointer;
		public static explicit operator ToolShell(IntPtr pointer) => new ToolShell { _pointer = pointer };
		public static explicit operator IntPtr(ToolShell value) => value._pointer
;	}
	public ref struct ToolItemGroup
	{
		private IntPtr _pointer;
		public static explicit operator ToolItemGroup(IntPtr pointer) => new ToolItemGroup { _pointer = pointer };
		public static explicit operator IntPtr(ToolItemGroup value) => value._pointer
;		public static implicit operator Gtk.Container(ToolItemGroup value) => (Gtk.Container)value._pointer
;		public static explicit operator ToolItemGroup(Gtk.Container value) => (ToolItemGroup)(IntPtr)value
;		public static implicit operator Gtk.Widget(ToolItemGroup value) => (Gtk.Widget)value._pointer
;		public static explicit operator ToolItemGroup(Gtk.Widget value) => (ToolItemGroup)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ToolItemGroup value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ToolItemGroup(GObject.InitiallyUnowned value) => (ToolItemGroup)(IntPtr)value
;		public static implicit operator GObject.Object(ToolItemGroup value) => (GObject.Object)value._pointer
;		public static explicit operator ToolItemGroup(GObject.Object value) => (ToolItemGroup)(IntPtr)value
;	}
	public ref struct ToolItemGroupPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToolItemGroupPrivate(IntPtr pointer) => new ToolItemGroupPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToolItemGroupPrivate value) => value._pointer
;	}
	public ref struct ToolItemGroupClass
	{
		private IntPtr _pointer;
		public static explicit operator ToolItemGroupClass(IntPtr pointer) => new ToolItemGroupClass { _pointer = pointer };
		public static explicit operator IntPtr(ToolItemGroupClass value) => value._pointer
;	}
	public ref struct ToolPalette
	{
		private IntPtr _pointer;
		public static explicit operator ToolPalette(IntPtr pointer) => new ToolPalette { _pointer = pointer };
		public static explicit operator IntPtr(ToolPalette value) => value._pointer
;		public static implicit operator Gtk.Container(ToolPalette value) => (Gtk.Container)value._pointer
;		public static explicit operator ToolPalette(Gtk.Container value) => (ToolPalette)(IntPtr)value
;		public static implicit operator Gtk.Widget(ToolPalette value) => (Gtk.Widget)value._pointer
;		public static explicit operator ToolPalette(Gtk.Widget value) => (ToolPalette)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(ToolPalette value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator ToolPalette(GObject.InitiallyUnowned value) => (ToolPalette)(IntPtr)value
;		public static implicit operator GObject.Object(ToolPalette value) => (GObject.Object)value._pointer
;		public static explicit operator ToolPalette(GObject.Object value) => (ToolPalette)(IntPtr)value
;	}
	[Flags]
	public enum ToolPaletteDragTargets
	{
		items = 1,
		groups = 2,
	}
	public ref struct ToolPalettePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToolPalettePrivate(IntPtr pointer) => new ToolPalettePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToolPalettePrivate value) => value._pointer
;	}
	public ref struct ToolPaletteClass
	{
		private IntPtr _pointer;
		public static explicit operator ToolPaletteClass(IntPtr pointer) => new ToolPaletteClass { _pointer = pointer };
		public static explicit operator IntPtr(ToolPaletteClass value) => value._pointer
;	}
	public ref struct ToolShellIface
	{
		private IntPtr _pointer;
		public static explicit operator ToolShellIface(IntPtr pointer) => new ToolShellIface { _pointer = pointer };
		public static explicit operator IntPtr(ToolShellIface value) => value._pointer
;	}
	public ref struct Toolbar
	{
		private IntPtr _pointer;
		public static explicit operator Toolbar(IntPtr pointer) => new Toolbar { _pointer = pointer };
		public static explicit operator IntPtr(Toolbar value) => value._pointer
;		public static implicit operator Gtk.Container(Toolbar value) => (Gtk.Container)value._pointer
;		public static explicit operator Toolbar(Gtk.Container value) => (Toolbar)(IntPtr)value
;		public static implicit operator Gtk.Widget(Toolbar value) => (Gtk.Widget)value._pointer
;		public static explicit operator Toolbar(Gtk.Widget value) => (Toolbar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Toolbar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Toolbar(GObject.InitiallyUnowned value) => (Toolbar)(IntPtr)value
;		public static implicit operator GObject.Object(Toolbar value) => (GObject.Object)value._pointer
;		public static explicit operator Toolbar(GObject.Object value) => (Toolbar)(IntPtr)value
;	}
	public ref struct ToolbarPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToolbarPrivate(IntPtr pointer) => new ToolbarPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToolbarPrivate value) => value._pointer
;	}
	public ref struct ToolbarClass
	{
		private IntPtr _pointer;
		public static explicit operator ToolbarClass(IntPtr pointer) => new ToolbarClass { _pointer = pointer };
		public static explicit operator IntPtr(ToolbarClass value) => value._pointer
;	}
	public enum ToolbarSpaceStyle
	{
		empty = 0,
		line = 1,
	}
	public ref struct ToplevelAccessible
	{
		private IntPtr _pointer;
		public static explicit operator ToplevelAccessible(IntPtr pointer) => new ToplevelAccessible { _pointer = pointer };
		public static explicit operator IntPtr(ToplevelAccessible value) => value._pointer
;		public static implicit operator Atk.Object(ToplevelAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator ToplevelAccessible(Atk.Object value) => (ToplevelAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(ToplevelAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator ToplevelAccessible(GObject.Object value) => (ToplevelAccessible)(IntPtr)value
;	}
	public ref struct ToplevelAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator ToplevelAccessiblePrivate(IntPtr pointer) => new ToplevelAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(ToplevelAccessiblePrivate value) => value._pointer
;	}
	public ref struct ToplevelAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator ToplevelAccessibleClass(IntPtr pointer) => new ToplevelAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(ToplevelAccessibleClass value) => value._pointer
;	}
	public ref struct TreeViewColumn
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewColumn(IntPtr pointer) => new TreeViewColumn { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewColumn value) => value._pointer
;		public static implicit operator GObject.InitiallyUnowned(TreeViewColumn value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator TreeViewColumn(GObject.InitiallyUnowned value) => (TreeViewColumn)(IntPtr)value
;		public static implicit operator GObject.Object(TreeViewColumn value) => (GObject.Object)value._pointer
;		public static explicit operator TreeViewColumn(GObject.Object value) => (TreeViewColumn)(IntPtr)value
;	}
	public ref struct TreeView
	{
		private IntPtr _pointer;
		public static explicit operator TreeView(IntPtr pointer) => new TreeView { _pointer = pointer };
		public static explicit operator IntPtr(TreeView value) => value._pointer
;		public static implicit operator Gtk.Container(TreeView value) => (Gtk.Container)value._pointer
;		public static explicit operator TreeView(Gtk.Container value) => (TreeView)(IntPtr)value
;		public static implicit operator Gtk.Widget(TreeView value) => (Gtk.Widget)value._pointer
;		public static explicit operator TreeView(Gtk.Widget value) => (TreeView)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(TreeView value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator TreeView(GObject.InitiallyUnowned value) => (TreeView)(IntPtr)value
;		public static implicit operator GObject.Object(TreeView value) => (GObject.Object)value._pointer
;		public static explicit operator TreeView(GObject.Object value) => (TreeView)(IntPtr)value
;	}
	public ref struct TreeDragDestIface
	{
		private IntPtr _pointer;
		public static explicit operator TreeDragDestIface(IntPtr pointer) => new TreeDragDestIface { _pointer = pointer };
		public static explicit operator IntPtr(TreeDragDestIface value) => value._pointer
;	}
	public ref struct TreeDragSourceIface
	{
		private IntPtr _pointer;
		public static explicit operator TreeDragSourceIface(IntPtr pointer) => new TreeDragSourceIface { _pointer = pointer };
		public static explicit operator IntPtr(TreeDragSourceIface value) => value._pointer
;	}
	[Flags]
	public enum TreeModelFlags
	{
		iters_persist = 1,
		list_only = 2,
	}
	public ref struct TreeModelFilter
	{
		private IntPtr _pointer;
		public static explicit operator TreeModelFilter(IntPtr pointer) => new TreeModelFilter { _pointer = pointer };
		public static explicit operator IntPtr(TreeModelFilter value) => value._pointer
;		public static implicit operator GObject.Object(TreeModelFilter value) => (GObject.Object)value._pointer
;		public static explicit operator TreeModelFilter(GObject.Object value) => (TreeModelFilter)(IntPtr)value
;	}
	public ref struct TreeModelFilterPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TreeModelFilterPrivate(IntPtr pointer) => new TreeModelFilterPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TreeModelFilterPrivate value) => value._pointer
;	}
	public ref struct TreeModelFilterClass
	{
		private IntPtr _pointer;
		public static explicit operator TreeModelFilterClass(IntPtr pointer) => new TreeModelFilterClass { _pointer = pointer };
		public static explicit operator IntPtr(TreeModelFilterClass value) => value._pointer
;	}
	public ref struct TreeModelIface
	{
		private IntPtr _pointer;
		public static explicit operator TreeModelIface(IntPtr pointer) => new TreeModelIface { _pointer = pointer };
		public static explicit operator IntPtr(TreeModelIface value) => value._pointer
;	}
	public ref struct TreeModelSort
	{
		private IntPtr _pointer;
		public static explicit operator TreeModelSort(IntPtr pointer) => new TreeModelSort { _pointer = pointer };
		public static explicit operator IntPtr(TreeModelSort value) => value._pointer
;		public static implicit operator GObject.Object(TreeModelSort value) => (GObject.Object)value._pointer
;		public static explicit operator TreeModelSort(GObject.Object value) => (TreeModelSort)(IntPtr)value
;	}
	public ref struct TreeModelSortPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TreeModelSortPrivate(IntPtr pointer) => new TreeModelSortPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TreeModelSortPrivate value) => value._pointer
;	}
	public ref struct TreeModelSortClass
	{
		private IntPtr _pointer;
		public static explicit operator TreeModelSortClass(IntPtr pointer) => new TreeModelSortClass { _pointer = pointer };
		public static explicit operator IntPtr(TreeModelSortClass value) => value._pointer
;	}
	public ref struct TreeRowReference
	{
		private IntPtr _pointer;
		public static explicit operator TreeRowReference(IntPtr pointer) => new TreeRowReference { _pointer = pointer };
		public static explicit operator IntPtr(TreeRowReference value) => value._pointer
;	}
	public ref struct TreeSelection
	{
		private IntPtr _pointer;
		public static explicit operator TreeSelection(IntPtr pointer) => new TreeSelection { _pointer = pointer };
		public static explicit operator IntPtr(TreeSelection value) => value._pointer
;		public static implicit operator GObject.Object(TreeSelection value) => (GObject.Object)value._pointer
;		public static explicit operator TreeSelection(GObject.Object value) => (TreeSelection)(IntPtr)value
;	}
	public ref struct TreeSelectionPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TreeSelectionPrivate(IntPtr pointer) => new TreeSelectionPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TreeSelectionPrivate value) => value._pointer
;	}
	public ref struct TreeSelectionClass
	{
		private IntPtr _pointer;
		public static explicit operator TreeSelectionClass(IntPtr pointer) => new TreeSelectionClass { _pointer = pointer };
		public static explicit operator IntPtr(TreeSelectionClass value) => value._pointer
;	}
	public ref struct TreeSortableIface
	{
		private IntPtr _pointer;
		public static explicit operator TreeSortableIface(IntPtr pointer) => new TreeSortableIface { _pointer = pointer };
		public static explicit operator IntPtr(TreeSortableIface value) => value._pointer
;	}
	public ref struct TreeStore
	{
		private IntPtr _pointer;
		public static explicit operator TreeStore(IntPtr pointer) => new TreeStore { _pointer = pointer };
		public static explicit operator IntPtr(TreeStore value) => value._pointer
;		public static implicit operator GObject.Object(TreeStore value) => (GObject.Object)value._pointer
;		public static explicit operator TreeStore(GObject.Object value) => (TreeStore)(IntPtr)value
;	}
	public ref struct TreeStorePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TreeStorePrivate(IntPtr pointer) => new TreeStorePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TreeStorePrivate value) => value._pointer
;	}
	public ref struct TreeStoreClass
	{
		private IntPtr _pointer;
		public static explicit operator TreeStoreClass(IntPtr pointer) => new TreeStoreClass { _pointer = pointer };
		public static explicit operator IntPtr(TreeStoreClass value) => value._pointer
;	}
	public enum TreeViewDropPosition
	{
		before = 0,
		after = 1,
		into_or_before = 2,
		into_or_after = 3,
	}
	public enum TreeViewGridLines
	{
		none = 0,
		horizontal = 1,
		vertical = 2,
		both = 3,
	}
	public ref struct TreeViewPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewPrivate(IntPtr pointer) => new TreeViewPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewPrivate value) => value._pointer
;	}
	public ref struct TreeViewAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewAccessiblePrivate(IntPtr pointer) => new TreeViewAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewAccessiblePrivate value) => value._pointer
;	}
	public ref struct TreeViewAccessible
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewAccessible(IntPtr pointer) => new TreeViewAccessible { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(TreeViewAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator TreeViewAccessible(Gtk.ContainerAccessible value) => (TreeViewAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(TreeViewAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator TreeViewAccessible(Gtk.WidgetAccessible value) => (TreeViewAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(TreeViewAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator TreeViewAccessible(Gtk.Accessible value) => (TreeViewAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(TreeViewAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator TreeViewAccessible(Atk.Object value) => (TreeViewAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(TreeViewAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator TreeViewAccessible(GObject.Object value) => (TreeViewAccessible)(IntPtr)value
;	}
	public ref struct TreeViewAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewAccessibleClass(IntPtr pointer) => new TreeViewAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewAccessibleClass value) => value._pointer
;	}
	public ref struct TreeViewClass
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewClass(IntPtr pointer) => new TreeViewClass { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewClass value) => value._pointer
;	}
	public enum TreeViewColumnSizing
	{
		grow_only = 0,
		autosize = 1,
		@fixed = 2,
	}
	public ref struct TreeViewColumnPrivate
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewColumnPrivate(IntPtr pointer) => new TreeViewColumnPrivate { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewColumnPrivate value) => value._pointer
;	}
	public ref struct TreeViewColumnClass
	{
		private IntPtr _pointer;
		public static explicit operator TreeViewColumnClass(IntPtr pointer) => new TreeViewColumnClass { _pointer = pointer };
		public static explicit operator IntPtr(TreeViewColumnClass value) => value._pointer
;	}
	public ref struct UIManager
	{
		private IntPtr _pointer;
		public static explicit operator UIManager(IntPtr pointer) => new UIManager { _pointer = pointer };
		public static explicit operator IntPtr(UIManager value) => value._pointer
;		public static implicit operator GObject.Object(UIManager value) => (GObject.Object)value._pointer
;		public static explicit operator UIManager(GObject.Object value) => (UIManager)(IntPtr)value
;	}
	[Flags]
	public enum UIManagerItemType
	{
		auto = 0,
		menubar = 1,
		menu = 2,
		toolbar = 4,
		placeholder = 8,
		popup = 16,
		menuitem = 32,
		toolitem = 64,
		separator = 128,
		accelerator = 256,
		popup_with_accels = 512,
	}
	public ref struct UIManagerPrivate
	{
		private IntPtr _pointer;
		public static explicit operator UIManagerPrivate(IntPtr pointer) => new UIManagerPrivate { _pointer = pointer };
		public static explicit operator IntPtr(UIManagerPrivate value) => value._pointer
;	}
	public ref struct UIManagerClass
	{
		private IntPtr _pointer;
		public static explicit operator UIManagerClass(IntPtr pointer) => new UIManagerClass { _pointer = pointer };
		public static explicit operator IntPtr(UIManagerClass value) => value._pointer
;	}
	public ref struct VBox
	{
		private IntPtr _pointer;
		public static explicit operator VBox(IntPtr pointer) => new VBox { _pointer = pointer };
		public static explicit operator IntPtr(VBox value) => value._pointer
;		public static implicit operator Gtk.Box(VBox value) => (Gtk.Box)value._pointer
;		public static explicit operator VBox(Gtk.Box value) => (VBox)(IntPtr)value
;		public static implicit operator Gtk.Container(VBox value) => (Gtk.Container)value._pointer
;		public static explicit operator VBox(Gtk.Container value) => (VBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(VBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator VBox(Gtk.Widget value) => (VBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(VBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator VBox(GObject.InitiallyUnowned value) => (VBox)(IntPtr)value
;		public static implicit operator GObject.Object(VBox value) => (GObject.Object)value._pointer
;		public static explicit operator VBox(GObject.Object value) => (VBox)(IntPtr)value
;	}
	public ref struct VBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator VBoxClass(IntPtr pointer) => new VBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(VBoxClass value) => value._pointer
;	}
	public ref struct VButtonBox
	{
		private IntPtr _pointer;
		public static explicit operator VButtonBox(IntPtr pointer) => new VButtonBox { _pointer = pointer };
		public static explicit operator IntPtr(VButtonBox value) => value._pointer
;		public static implicit operator Gtk.ButtonBox(VButtonBox value) => (Gtk.ButtonBox)value._pointer
;		public static explicit operator VButtonBox(Gtk.ButtonBox value) => (VButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Box(VButtonBox value) => (Gtk.Box)value._pointer
;		public static explicit operator VButtonBox(Gtk.Box value) => (VButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Container(VButtonBox value) => (Gtk.Container)value._pointer
;		public static explicit operator VButtonBox(Gtk.Container value) => (VButtonBox)(IntPtr)value
;		public static implicit operator Gtk.Widget(VButtonBox value) => (Gtk.Widget)value._pointer
;		public static explicit operator VButtonBox(Gtk.Widget value) => (VButtonBox)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(VButtonBox value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator VButtonBox(GObject.InitiallyUnowned value) => (VButtonBox)(IntPtr)value
;		public static implicit operator GObject.Object(VButtonBox value) => (GObject.Object)value._pointer
;		public static explicit operator VButtonBox(GObject.Object value) => (VButtonBox)(IntPtr)value
;	}
	public ref struct VButtonBoxClass
	{
		private IntPtr _pointer;
		public static explicit operator VButtonBoxClass(IntPtr pointer) => new VButtonBoxClass { _pointer = pointer };
		public static explicit operator IntPtr(VButtonBoxClass value) => value._pointer
;	}
	public ref struct VPaned
	{
		private IntPtr _pointer;
		public static explicit operator VPaned(IntPtr pointer) => new VPaned { _pointer = pointer };
		public static explicit operator IntPtr(VPaned value) => value._pointer
;		public static implicit operator Gtk.Paned(VPaned value) => (Gtk.Paned)value._pointer
;		public static explicit operator VPaned(Gtk.Paned value) => (VPaned)(IntPtr)value
;		public static implicit operator Gtk.Container(VPaned value) => (Gtk.Container)value._pointer
;		public static explicit operator VPaned(Gtk.Container value) => (VPaned)(IntPtr)value
;		public static implicit operator Gtk.Widget(VPaned value) => (Gtk.Widget)value._pointer
;		public static explicit operator VPaned(Gtk.Widget value) => (VPaned)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(VPaned value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator VPaned(GObject.InitiallyUnowned value) => (VPaned)(IntPtr)value
;		public static implicit operator GObject.Object(VPaned value) => (GObject.Object)value._pointer
;		public static explicit operator VPaned(GObject.Object value) => (VPaned)(IntPtr)value
;	}
	public ref struct VPanedClass
	{
		private IntPtr _pointer;
		public static explicit operator VPanedClass(IntPtr pointer) => new VPanedClass { _pointer = pointer };
		public static explicit operator IntPtr(VPanedClass value) => value._pointer
;	}
	public ref struct VScale
	{
		private IntPtr _pointer;
		public static explicit operator VScale(IntPtr pointer) => new VScale { _pointer = pointer };
		public static explicit operator IntPtr(VScale value) => value._pointer
;		public static implicit operator Gtk.Scale(VScale value) => (Gtk.Scale)value._pointer
;		public static explicit operator VScale(Gtk.Scale value) => (VScale)(IntPtr)value
;		public static implicit operator Gtk.Range(VScale value) => (Gtk.Range)value._pointer
;		public static explicit operator VScale(Gtk.Range value) => (VScale)(IntPtr)value
;		public static implicit operator Gtk.Widget(VScale value) => (Gtk.Widget)value._pointer
;		public static explicit operator VScale(Gtk.Widget value) => (VScale)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(VScale value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator VScale(GObject.InitiallyUnowned value) => (VScale)(IntPtr)value
;		public static implicit operator GObject.Object(VScale value) => (GObject.Object)value._pointer
;		public static explicit operator VScale(GObject.Object value) => (VScale)(IntPtr)value
;	}
	public ref struct VScaleClass
	{
		private IntPtr _pointer;
		public static explicit operator VScaleClass(IntPtr pointer) => new VScaleClass { _pointer = pointer };
		public static explicit operator IntPtr(VScaleClass value) => value._pointer
;	}
	public ref struct VScrollbar
	{
		private IntPtr _pointer;
		public static explicit operator VScrollbar(IntPtr pointer) => new VScrollbar { _pointer = pointer };
		public static explicit operator IntPtr(VScrollbar value) => value._pointer
;		public static implicit operator Gtk.Scrollbar(VScrollbar value) => (Gtk.Scrollbar)value._pointer
;		public static explicit operator VScrollbar(Gtk.Scrollbar value) => (VScrollbar)(IntPtr)value
;		public static implicit operator Gtk.Range(VScrollbar value) => (Gtk.Range)value._pointer
;		public static explicit operator VScrollbar(Gtk.Range value) => (VScrollbar)(IntPtr)value
;		public static implicit operator Gtk.Widget(VScrollbar value) => (Gtk.Widget)value._pointer
;		public static explicit operator VScrollbar(Gtk.Widget value) => (VScrollbar)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(VScrollbar value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator VScrollbar(GObject.InitiallyUnowned value) => (VScrollbar)(IntPtr)value
;		public static implicit operator GObject.Object(VScrollbar value) => (GObject.Object)value._pointer
;		public static explicit operator VScrollbar(GObject.Object value) => (VScrollbar)(IntPtr)value
;	}
	public ref struct VScrollbarClass
	{
		private IntPtr _pointer;
		public static explicit operator VScrollbarClass(IntPtr pointer) => new VScrollbarClass { _pointer = pointer };
		public static explicit operator IntPtr(VScrollbarClass value) => value._pointer
;	}
	public ref struct VSeparator
	{
		private IntPtr _pointer;
		public static explicit operator VSeparator(IntPtr pointer) => new VSeparator { _pointer = pointer };
		public static explicit operator IntPtr(VSeparator value) => value._pointer
;		public static implicit operator Gtk.Separator(VSeparator value) => (Gtk.Separator)value._pointer
;		public static explicit operator VSeparator(Gtk.Separator value) => (VSeparator)(IntPtr)value
;		public static implicit operator Gtk.Widget(VSeparator value) => (Gtk.Widget)value._pointer
;		public static explicit operator VSeparator(Gtk.Widget value) => (VSeparator)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(VSeparator value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator VSeparator(GObject.InitiallyUnowned value) => (VSeparator)(IntPtr)value
;		public static implicit operator GObject.Object(VSeparator value) => (GObject.Object)value._pointer
;		public static explicit operator VSeparator(GObject.Object value) => (VSeparator)(IntPtr)value
;	}
	public ref struct VSeparatorClass
	{
		private IntPtr _pointer;
		public static explicit operator VSeparatorClass(IntPtr pointer) => new VSeparatorClass { _pointer = pointer };
		public static explicit operator IntPtr(VSeparatorClass value) => value._pointer
;	}
	public ref struct Viewport
	{
		private IntPtr _pointer;
		public static explicit operator Viewport(IntPtr pointer) => new Viewport { _pointer = pointer };
		public static explicit operator IntPtr(Viewport value) => value._pointer
;		public static implicit operator Gtk.Bin(Viewport value) => (Gtk.Bin)value._pointer
;		public static explicit operator Viewport(Gtk.Bin value) => (Viewport)(IntPtr)value
;		public static implicit operator Gtk.Container(Viewport value) => (Gtk.Container)value._pointer
;		public static explicit operator Viewport(Gtk.Container value) => (Viewport)(IntPtr)value
;		public static implicit operator Gtk.Widget(Viewport value) => (Gtk.Widget)value._pointer
;		public static explicit operator Viewport(Gtk.Widget value) => (Viewport)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(Viewport value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator Viewport(GObject.InitiallyUnowned value) => (Viewport)(IntPtr)value
;		public static implicit operator GObject.Object(Viewport value) => (GObject.Object)value._pointer
;		public static explicit operator Viewport(GObject.Object value) => (Viewport)(IntPtr)value
;	}
	public ref struct ViewportPrivate
	{
		private IntPtr _pointer;
		public static explicit operator ViewportPrivate(IntPtr pointer) => new ViewportPrivate { _pointer = pointer };
		public static explicit operator IntPtr(ViewportPrivate value) => value._pointer
;	}
	public ref struct ViewportClass
	{
		private IntPtr _pointer;
		public static explicit operator ViewportClass(IntPtr pointer) => new ViewportClass { _pointer = pointer };
		public static explicit operator IntPtr(ViewportClass value) => value._pointer
;	}
	public ref struct VolumeButton
	{
		private IntPtr _pointer;
		public static explicit operator VolumeButton(IntPtr pointer) => new VolumeButton { _pointer = pointer };
		public static explicit operator IntPtr(VolumeButton value) => value._pointer
;		public static implicit operator Gtk.ScaleButton(VolumeButton value) => (Gtk.ScaleButton)value._pointer
;		public static explicit operator VolumeButton(Gtk.ScaleButton value) => (VolumeButton)(IntPtr)value
;		public static implicit operator Gtk.Button(VolumeButton value) => (Gtk.Button)value._pointer
;		public static explicit operator VolumeButton(Gtk.Button value) => (VolumeButton)(IntPtr)value
;		public static implicit operator Gtk.Bin(VolumeButton value) => (Gtk.Bin)value._pointer
;		public static explicit operator VolumeButton(Gtk.Bin value) => (VolumeButton)(IntPtr)value
;		public static implicit operator Gtk.Container(VolumeButton value) => (Gtk.Container)value._pointer
;		public static explicit operator VolumeButton(Gtk.Container value) => (VolumeButton)(IntPtr)value
;		public static implicit operator Gtk.Widget(VolumeButton value) => (Gtk.Widget)value._pointer
;		public static explicit operator VolumeButton(Gtk.Widget value) => (VolumeButton)(IntPtr)value
;		public static implicit operator GObject.InitiallyUnowned(VolumeButton value) => (GObject.InitiallyUnowned)value._pointer
;		public static explicit operator VolumeButton(GObject.InitiallyUnowned value) => (VolumeButton)(IntPtr)value
;		public static implicit operator GObject.Object(VolumeButton value) => (GObject.Object)value._pointer
;		public static explicit operator VolumeButton(GObject.Object value) => (VolumeButton)(IntPtr)value
;	}
	public ref struct VolumeButtonClass
	{
		private IntPtr _pointer;
		public static explicit operator VolumeButtonClass(IntPtr pointer) => new VolumeButtonClass { _pointer = pointer };
		public static explicit operator IntPtr(VolumeButtonClass value) => value._pointer
;	}
	public ref struct WidgetPrivate
	{
		private IntPtr _pointer;
		public static explicit operator WidgetPrivate(IntPtr pointer) => new WidgetPrivate { _pointer = pointer };
		public static explicit operator IntPtr(WidgetPrivate value) => value._pointer
;	}
	public ref struct WidgetAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator WidgetAccessiblePrivate(IntPtr pointer) => new WidgetAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(WidgetAccessiblePrivate value) => value._pointer
;	}
	public enum WidgetHelpType
	{
		tooltip = 0,
		whats_this = 1,
	}
	public ref struct WidgetClassPrivate
	{
		private IntPtr _pointer;
		public static explicit operator WidgetClassPrivate(IntPtr pointer) => new WidgetClassPrivate { _pointer = pointer };
		public static explicit operator IntPtr(WidgetClassPrivate value) => value._pointer
;	}
	public enum WindowType
	{
		toplevel = 0,
		popup = 1,
	}
	public ref struct WindowGroup
	{
		private IntPtr _pointer;
		public static explicit operator WindowGroup(IntPtr pointer) => new WindowGroup { _pointer = pointer };
		public static explicit operator IntPtr(WindowGroup value) => value._pointer
;		public static implicit operator GObject.Object(WindowGroup value) => (GObject.Object)value._pointer
;		public static explicit operator WindowGroup(GObject.Object value) => (WindowGroup)(IntPtr)value
;	}
	public enum WindowPosition
	{
		none = 0,
		center = 1,
		mouse = 2,
		center_always = 3,
		center_on_parent = 4,
	}
	public ref struct WindowPrivate
	{
		private IntPtr _pointer;
		public static explicit operator WindowPrivate(IntPtr pointer) => new WindowPrivate { _pointer = pointer };
		public static explicit operator IntPtr(WindowPrivate value) => value._pointer
;	}
	public ref struct WindowAccessiblePrivate
	{
		private IntPtr _pointer;
		public static explicit operator WindowAccessiblePrivate(IntPtr pointer) => new WindowAccessiblePrivate { _pointer = pointer };
		public static explicit operator IntPtr(WindowAccessiblePrivate value) => value._pointer
;	}
	public ref struct WindowAccessible
	{
		private IntPtr _pointer;
		public static explicit operator WindowAccessible(IntPtr pointer) => new WindowAccessible { _pointer = pointer };
		public static explicit operator IntPtr(WindowAccessible value) => value._pointer
;		public static implicit operator Gtk.ContainerAccessible(WindowAccessible value) => (Gtk.ContainerAccessible)value._pointer
;		public static explicit operator WindowAccessible(Gtk.ContainerAccessible value) => (WindowAccessible)(IntPtr)value
;		public static implicit operator Gtk.WidgetAccessible(WindowAccessible value) => (Gtk.WidgetAccessible)value._pointer
;		public static explicit operator WindowAccessible(Gtk.WidgetAccessible value) => (WindowAccessible)(IntPtr)value
;		public static implicit operator Gtk.Accessible(WindowAccessible value) => (Gtk.Accessible)value._pointer
;		public static explicit operator WindowAccessible(Gtk.Accessible value) => (WindowAccessible)(IntPtr)value
;		public static implicit operator Atk.Object(WindowAccessible value) => (Atk.Object)value._pointer
;		public static explicit operator WindowAccessible(Atk.Object value) => (WindowAccessible)(IntPtr)value
;		public static implicit operator GObject.Object(WindowAccessible value) => (GObject.Object)value._pointer
;		public static explicit operator WindowAccessible(GObject.Object value) => (WindowAccessible)(IntPtr)value
;	}
	public ref struct WindowAccessibleClass
	{
		private IntPtr _pointer;
		public static explicit operator WindowAccessibleClass(IntPtr pointer) => new WindowAccessibleClass { _pointer = pointer };
		public static explicit operator IntPtr(WindowAccessibleClass value) => value._pointer
;	}
	public ref struct WindowGeometryInfo
	{
		private IntPtr _pointer;
		public static explicit operator WindowGeometryInfo(IntPtr pointer) => new WindowGeometryInfo { _pointer = pointer };
		public static explicit operator IntPtr(WindowGeometryInfo value) => value._pointer
;	}
	public ref struct WindowGroupPrivate
	{
		private IntPtr _pointer;
		public static explicit operator WindowGroupPrivate(IntPtr pointer) => new WindowGroupPrivate { _pointer = pointer };
		public static explicit operator IntPtr(WindowGroupPrivate value) => value._pointer
;	}
	public ref struct WindowGroupClass
	{
		private IntPtr _pointer;
		public static explicit operator WindowGroupClass(IntPtr pointer) => new WindowGroupClass { _pointer = pointer };
		public static explicit operator IntPtr(WindowGroupClass value) => value._pointer
;	}
	public static class GtkInterop {
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accel_groups_activate(GObject.Object @object, uint accel_key, Gdk.ModifierType accel_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_accel_groups_from_object(GObject.Object @object);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.ModifierType gtk_accelerator_get_default_mod_mask();
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_accelerator_get_label(uint accelerator_key, Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_accelerator_get_label_with_keycode(Gdk.Display display, uint accelerator_key, uint keycode, Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_accelerator_name(uint accelerator_key, Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_accelerator_name_with_keycode(Gdk.Display display, uint accelerator_key, uint keycode, Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accelerator_parse(string accelerator, System.IntPtr accelerator_key, out Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accelerator_parse_with_keycode(string accelerator, System.IntPtr accelerator_key, System.IntPtr accelerator_codes, out Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accelerator_set_default_mod_mask(Gdk.ModifierType default_mod_mask);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accelerator_valid(uint keyval, Gdk.ModifierType modifiers);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_alternative_dialog_button_order(Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_bindings_activate(GObject.Object @object, uint keyval, Gdk.ModifierType modifiers);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_bindings_activate_event(GObject.Object @object, Gdk.EventKey @event);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cairo_should_draw_window(cairo.Context cr, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cairo_transform_to_window(cairo.Context cr, Gtk.Widget widget, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_check_version(uint required_major, uint required_minor, uint required_micro);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_device_grab_add(Gtk.Widget widget, Gdk.Device device, int block_others);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_device_grab_remove(Gtk.Widget widget, Gdk.Device device);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_disable_setlocale();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_distribute_natural_allocation(int extra_space, uint n_requested_sizes, Gtk.RequestedSize sizes);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_cancel(Gdk.DragContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_finish(Gdk.DragContext context, int success, int del, uint time_);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_drag_get_source_widget(Gdk.DragContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_set_icon_default(Gdk.DragContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_set_icon_gicon(Gdk.DragContext context, Gio.Icon icon, int hot_x, int hot_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_set_icon_name(Gdk.DragContext context, string icon_name, int hot_x, int hot_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_set_icon_pixbuf(Gdk.DragContext context, GdkPixbuf.Pixbuf pixbuf, int hot_x, int hot_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_set_icon_stock(Gdk.DragContext context, string stock_id, int hot_x, int hot_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_set_icon_surface(Gdk.DragContext context, cairo.Surface surface);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_set_icon_widget(Gdk.DragContext context, Gtk.Widget widget, int hot_x, int hot_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_draw_insertion_cursor(Gtk.Widget widget, cairo.Context cr, Gdk.Rectangle location, int is_primary, Gtk.TextDirection direction, int draw_arrow);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_events_pending();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_false();
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_get_binary_age();
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_get_current_event();
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Device gtk_get_current_event_device();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_get_current_event_state(out Gdk.ModifierType state);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_get_current_event_time();
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_get_debug_flags();
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Language gtk_get_default_language();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_get_event_widget(System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_get_interface_age();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextDirection gtk_get_locale_direction();
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_get_major_version();
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_get_micro_version();
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_get_minor_version();
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.OptionGroup gtk_get_option_group(int open_default_display);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_grab_get_current();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_init(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_init_check(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_init_with_args(System.IntPtr argc, System.IntPtr argv, string parameter_string, System.IntPtr entries, string translation_domain, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_key_snooper_install(System.IntPtr snooper, System.IntPtr func_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_key_snooper_remove(uint snooper_handler_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_main();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_main_do_event(System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_main_iteration();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_main_iteration_do(int blocking);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_main_level();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_main_quit();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_arrow(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, Gtk.ArrowType arrow_type, int fill, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_box(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_box_gap(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height, Gtk.PositionType gap_side, int gap_x, int gap_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_check(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_diamond(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_expander(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.Widget widget, string detail, int x, int y, Gtk.ExpanderStyle expander_style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_extension(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height, Gtk.PositionType gap_side);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_flat_box(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_focus(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_handle(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_hline(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.Widget widget, string detail, int x1, int x2, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_layout(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, int use_text, Gtk.Widget widget, string detail, int x, int y, Pango.Layout layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_option(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_resize_grip(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.Widget widget, string detail, Gdk.WindowEdge edge, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_shadow(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_shadow_gap(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height, Gtk.PositionType gap_side, int gap_x, int gap_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_slider(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_spinner(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.Widget widget, string detail, uint step, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_tab(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.ShadowType shadow_type, Gtk.Widget widget, string detail, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paint_vline(Gtk.Style style, cairo.Context cr, Gtk.StateType state_type, Gtk.Widget widget, string detail, int y1_, int y2_, int x);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_parse_args(System.IntPtr argc, System.IntPtr argv);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_print_run_page_setup_dialog(Gtk.Window parent, Gtk.PageSetup page_setup, Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_run_page_setup_dialog_async(Gtk.Window parent, Gtk.PageSetup page_setup, Gtk.PrintSettings settings, System.IntPtr done_cb, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_propagate_event(Gtk.Widget widget, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_rc_add_default_file(System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_rc_find_module_in_path(string module_file);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_rc_find_pixmap_in_path(Gtk.Settings settings, GLib.Scanner scanner, string pixmap_file);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_rc_get_default_files();
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_rc_get_im_module_file();
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_rc_get_im_module_path();
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_rc_get_module_dir();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Style gtk_rc_get_style(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Style gtk_rc_get_style_by_paths(Gtk.Settings settings, string widget_path, string class_path, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_rc_get_theme_dir();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_rc_parse(string filename);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_rc_parse_state(GLib.Scanner scanner, out Gtk.StateType state);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_rc_parse_string(string rc_string);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_rc_reparse_all();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_rc_reparse_all_for_settings(Gtk.Settings settings, int force_load);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_rc_reset_styles(Gtk.Settings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.Scanner gtk_rc_scanner_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_rc_set_default_files(System.IntPtr filenames);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_activity(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_arrow(Gtk.StyleContext context, cairo.Context cr, double angle, double x, double y, double size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_background(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_check(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_expander(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_extension(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height, Gtk.PositionType gap_side);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_focus(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_frame(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_frame_gap(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height, Gtk.PositionType gap_side, double xy0_gap, double xy1_gap);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_handle(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_icon(Gtk.StyleContext context, cairo.Context cr, GdkPixbuf.Pixbuf pixbuf, double x, double y);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_render_icon_pixbuf(Gtk.StyleContext context, Gtk.IconSource source, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_icon_surface(Gtk.StyleContext context, cairo.Context cr, cairo.Surface surface, double x, double y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_insertion_cursor(Gtk.StyleContext context, cairo.Context cr, double x, double y, Pango.Layout layout, int index, Pango.Direction direction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_layout(Gtk.StyleContext context, cairo.Context cr, double x, double y, Pango.Layout layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_line(Gtk.StyleContext context, cairo.Context cr, double x0, double y0, double x1, double y1);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_option(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_render_slider(Gtk.StyleContext context, cairo.Context cr, double x, double y, double width, double height, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_rgb_to_hsv(double r, double g, double b, System.IntPtr h, System.IntPtr s, System.IntPtr v);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_selection_remove_all(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_set_debug_flags(uint flags);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_show_uri(Gdk.Screen screen, string uri, uint timestamp, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_show_uri_on_window(Gtk.Window parent, string uri, uint timestamp, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stock_add(System.IntPtr items, uint n_items);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stock_add_static(System.IntPtr items, uint n_items);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_stock_list_ids();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stock_set_translate_func(string domain, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_table_free(System.IntPtr targets, int n_targets);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_target_table_new_from_list(Gtk.TargetList list, System.IntPtr n_targets);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_targets_include_image(System.IntPtr targets, int n_targets, int writable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_targets_include_rich_text(System.IntPtr targets, int n_targets, Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_targets_include_text(System.IntPtr targets, int n_targets);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_targets_include_uri(System.IntPtr targets, int n_targets);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_test_create_simple_window(string window_title, string dialog_text);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_test_find_label(Gtk.Widget widget, string label_pattern);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_test_find_sibling(Gtk.Widget base_widget, ulong widget_type);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_test_find_widget(Gtk.Widget widget, string label_pattern, ulong widget_type);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_test_list_all_types(System.IntPtr n_types);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_test_register_all_types();
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_test_slider_get_value(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_test_slider_set_perc(Gtk.Widget widget, double percentage);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_test_spin_button_click(Gtk.SpinButton spinner, uint button, int upwards);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_test_text_get(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_test_text_set(Gtk.Widget widget, string @string);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_test_widget_click(Gtk.Widget widget, uint button, Gdk.ModifierType modifiers);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_test_widget_send_key(Gtk.Widget widget, uint keyval, Gdk.ModifierType modifiers);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_test_widget_wait_for_draw(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_get_row_drag_data(Gtk.SelectionData selection_data, out Gtk.TreeModel tree_model, out Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_set_row_drag_data(Gtk.SelectionData selection_data, Gtk.TreeModel tree_model, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_true();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_buildable_add_child(Gtk.Buildable buildable, Gtk.Builder builder, GObject.Object child, string type);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.Object gtk_buildable_construct_child(Gtk.Buildable buildable, Gtk.Builder builder, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_buildable_custom_finished(Gtk.Buildable buildable, Gtk.Builder builder, GObject.Object child, string tagname, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_buildable_custom_tag_end(Gtk.Buildable buildable, Gtk.Builder builder, GObject.Object child, string tagname, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.Object gtk_buildable_get_internal_child(Gtk.Buildable buildable, Gtk.Builder builder, string childname);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_buildable_get_name(Gtk.Buildable buildable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_buildable_parser_finished(Gtk.Buildable buildable, Gtk.Builder builder);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_buildable_set_buildable_property(Gtk.Buildable buildable, Gtk.Builder builder, string name, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_buildable_set_name(Gtk.Buildable buildable, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextDirection gtk_widget_get_default_direction();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Style gtk_widget_get_default_style();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_pop_composite_child();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_push_composite_child();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_default_direction(Gtk.TextDirection dir);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_activate(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_add_accelerator(Gtk.Widget widget, string accel_signal, Gtk.AccelGroup accel_group, uint accel_key, Gdk.ModifierType accel_mods, Gtk.AccelFlags accel_flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_add_device_events(Gtk.Widget widget, Gdk.Device device, Gdk.EventMask events);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_add_events(Gtk.Widget widget, int events);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_add_mnemonic_label(Gtk.Widget widget, Gtk.Widget label);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_widget_add_tick_callback(Gtk.Widget widget, System.IntPtr callback, System.IntPtr user_data, System.IntPtr notify);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_can_activate_accel(Gtk.Widget widget, uint signal_id);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_child_focus(Gtk.Widget widget, Gtk.DirectionType direction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_child_notify(Gtk.Widget widget, string child_property);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_path(Gtk.Widget widget, System.IntPtr path_length, string path, string path_reversed);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_compute_expand(Gtk.Widget widget, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Context gtk_widget_create_pango_context(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Layout gtk_widget_create_pango_layout(Gtk.Widget widget, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_destroy(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_destroyed(Gtk.Widget widget, ref Gtk.Widget widget_pointer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_device_is_shadowed(Gtk.Widget widget, Gdk.Device device);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.DragContext gtk_drag_begin(Gtk.Widget widget, Gtk.TargetList targets, Gdk.DragAction actions, int button, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.DragContext gtk_drag_begin_with_coordinates(Gtk.Widget widget, Gtk.TargetList targets, Gdk.DragAction actions, int button, System.IntPtr @event, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_drag_check_threshold(Gtk.Widget widget, int start_x, int start_y, int current_x, int current_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_add_image_targets(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_add_text_targets(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_add_uri_targets(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetList gtk_drag_dest_get_target_list(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_drag_dest_get_track_motion(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_set(Gtk.Widget widget, Gtk.DestDefaults flags, System.IntPtr targets, int n_targets, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_set_proxy(Gtk.Widget widget, Gdk.Window proxy_window, Gdk.DragProtocol protocol, int use_coordinates);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_set_target_list(Gtk.Widget widget, Gtk.TargetList target_list);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_set_track_motion(Gtk.Widget widget, int track_motion);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_dest_unset(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_highlight(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_add_image_targets(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_add_text_targets(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_add_uri_targets(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetList gtk_drag_source_get_target_list(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_set(Gtk.Widget widget, Gdk.ModifierType start_button_mask, System.IntPtr targets, int n_targets, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_set_icon_gicon(Gtk.Widget widget, Gio.Icon icon);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_set_icon_name(Gtk.Widget widget, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_set_icon_pixbuf(Gtk.Widget widget, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_set_icon_stock(Gtk.Widget widget, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_set_target_list(Gtk.Widget widget, Gtk.TargetList target_list);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_source_unset(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_drag_unhighlight(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_draw(Gtk.Widget widget, cairo.Context cr);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_ensure_style(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_error_bell(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_event(Gtk.Widget widget, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_freeze_child_notify(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Atk.Object gtk_widget_get_accessible(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.ActionGroup gtk_widget_get_action_group(Gtk.Widget widget, string prefix);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_allocated_baseline(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_allocated_height(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_allocated_width(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_widget_get_ancestor(Gtk.Widget widget, ulong widget_type);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_app_paintable(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_can_default(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_can_focus(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_child_visible(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_get_composite_name(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_device_enabled(Gtk.Widget widget, Gdk.Device device);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.EventMask gtk_widget_get_device_events(Gtk.Widget widget, Gdk.Device device);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextDirection gtk_widget_get_direction(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Display gtk_widget_get_display(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_double_buffered(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_events(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_focus_on_click(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontMap gtk_widget_get_font_map(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.FontOptions gtk_widget_get_font_options(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.FrameClock gtk_widget_get_frame_clock(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Align gtk_widget_get_halign(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_has_tooltip(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_has_window(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_hexpand(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_hexpand_set(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_mapped(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_margin_bottom(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_margin_end(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_margin_left(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_margin_right(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_margin_start(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_margin_top(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.ModifierType gtk_widget_get_modifier_mask(Gtk.Widget widget, Gdk.ModifierIntent intent);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RcStyle gtk_widget_get_modifier_style(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_get_name(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_no_show_all(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_widget_get_opacity(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Context gtk_widget_get_pango_context(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_widget_get_parent(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_widget_get_parent_window(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_widget_get_path(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_get_pointer(Gtk.Widget widget, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_get_preferred_height(Gtk.Widget widget, System.IntPtr minimum_height, System.IntPtr natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_get_preferred_height_and_baseline_for_width(Gtk.Widget widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height, System.IntPtr minimum_baseline, System.IntPtr natural_baseline);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_get_preferred_height_for_width(Gtk.Widget widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_get_preferred_width(Gtk.Widget widget, System.IntPtr minimum_width, System.IntPtr natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_get_preferred_width_for_height(Gtk.Widget widget, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_realized(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_receives_default(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SizeRequestMode gtk_widget_get_request_mode(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_widget_get_root_window(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_scale_factor(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Screen gtk_widget_get_screen(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_sensitive(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Settings gtk_widget_get_settings(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_get_size_request(Gtk.Widget widget, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StateType gtk_widget_get_state(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StateFlags gtk_widget_get_state_flags(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Style gtk_widget_get_style(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StyleContext gtk_widget_get_style_context(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_support_multidevice(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.Object gtk_widget_get_template_child(Gtk.Widget widget, ulong widget_type, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_get_tooltip_markup(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_get_tooltip_text(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Window gtk_widget_get_tooltip_window(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_widget_get_toplevel(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Align gtk_widget_get_valign(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Align gtk_widget_get_valign_with_baseline(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_vexpand(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_vexpand_set(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_get_visible(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Visual gtk_widget_get_visual(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_widget_get_window(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grab_add(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_grab_default(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_grab_focus(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grab_remove(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_has_default(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_has_focus(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_has_grab(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_has_rc_style(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_has_screen(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_has_visible_focus(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_hide(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_hide_on_delete(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_in_destruction(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_init_template(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_input_shape_combine_region(Gtk.Widget widget, cairo.Region region);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_insert_action_group(Gtk.Widget widget, string name, Gio.ActionGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_is_ancestor(Gtk.Widget widget, Gtk.Widget ancestor);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_is_composited(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_is_drawable(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_is_focus(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_is_sensitive(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_is_toplevel(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_is_visible(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_keynav_failed(Gtk.Widget widget, Gtk.DirectionType direction);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_widget_list_accel_closures(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_widget_list_action_prefixes(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_widget_list_mnemonic_labels(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_map(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_mnemonic_activate(Gtk.Widget widget, int group_cycling);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_modify_base(Gtk.Widget widget, Gtk.StateType state, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_modify_bg(Gtk.Widget widget, Gtk.StateType state, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_modify_cursor(Gtk.Widget widget, Gdk.Color primary, Gdk.Color secondary);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_modify_fg(Gtk.Widget widget, Gtk.StateType state, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_modify_font(Gtk.Widget widget, Pango.FontDescription font_desc);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_modify_style(Gtk.Widget widget, Gtk.RcStyle style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_modify_text(Gtk.Widget widget, Gtk.StateType state, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_override_background_color(Gtk.Widget widget, Gtk.StateFlags state, Gdk.RGBA color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_override_color(Gtk.Widget widget, Gtk.StateFlags state, Gdk.RGBA color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_override_cursor(Gtk.Widget widget, Gdk.RGBA cursor, Gdk.RGBA secondary_cursor);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_override_font(Gtk.Widget widget, Pango.FontDescription font_desc);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_override_symbolic_color(Gtk.Widget widget, string name, Gdk.RGBA color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path(Gtk.Widget widget, System.IntPtr path_length, string path, string path_reversed);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_queue_allocate(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_queue_compute_expand(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_queue_draw(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_queue_draw_area(Gtk.Widget widget, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_queue_draw_region(Gtk.Widget widget, cairo.Region region);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_queue_resize(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_queue_resize_no_redraw(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_realize(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Region gtk_widget_region_intersect(Gtk.Widget widget, cairo.Region region);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_register_window(Gtk.Widget widget, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_remove_accelerator(Gtk.Widget widget, Gtk.AccelGroup accel_group, uint accel_key, Gdk.ModifierType accel_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_remove_mnemonic_label(Gtk.Widget widget, Gtk.Widget label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_remove_tick_callback(Gtk.Widget widget, uint id);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_widget_render_icon(Gtk.Widget widget, string stock_id, int size, string detail);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_widget_render_icon_pixbuf(Gtk.Widget widget, string stock_id, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_reparent(Gtk.Widget widget, Gtk.Widget new_parent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_reset_rc_styles(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_reset_style(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_send_expose(Gtk.Widget widget, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_send_focus_change(Gtk.Widget widget, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_accel_path(Gtk.Widget widget, string accel_path, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_allocation(Gtk.Widget widget, Gdk.Rectangle allocation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_app_paintable(Gtk.Widget widget, int app_paintable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_can_default(Gtk.Widget widget, int can_default);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_can_focus(Gtk.Widget widget, int can_focus);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_child_visible(Gtk.Widget widget, int is_visible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_clip(Gtk.Widget widget, Gdk.Rectangle clip);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_composite_name(Gtk.Widget widget, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_device_enabled(Gtk.Widget widget, Gdk.Device device, int enabled);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_device_events(Gtk.Widget widget, Gdk.Device device, Gdk.EventMask events);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_direction(Gtk.Widget widget, Gtk.TextDirection dir);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_double_buffered(Gtk.Widget widget, int double_buffered);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_events(Gtk.Widget widget, int events);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_focus_on_click(Gtk.Widget widget, int focus_on_click);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_font_map(Gtk.Widget widget, Pango.FontMap font_map);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_font_options(Gtk.Widget widget, cairo.FontOptions options);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_halign(Gtk.Widget widget, Gtk.Align align);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_has_tooltip(Gtk.Widget widget, int has_tooltip);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_has_window(Gtk.Widget widget, int has_window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_hexpand(Gtk.Widget widget, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_hexpand_set(Gtk.Widget widget, int set);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_mapped(Gtk.Widget widget, int mapped);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_margin_bottom(Gtk.Widget widget, int margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_margin_end(Gtk.Widget widget, int margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_margin_left(Gtk.Widget widget, int margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_margin_right(Gtk.Widget widget, int margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_margin_start(Gtk.Widget widget, int margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_margin_top(Gtk.Widget widget, int margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_name(Gtk.Widget widget, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_no_show_all(Gtk.Widget widget, int no_show_all);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_opacity(Gtk.Widget widget, double opacity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_parent(Gtk.Widget widget, Gtk.Widget parent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_parent_window(Gtk.Widget widget, Gdk.Window parent_window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_realized(Gtk.Widget widget, int realized);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_receives_default(Gtk.Widget widget, int receives_default);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_redraw_on_allocate(Gtk.Widget widget, int redraw_on_allocate);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_sensitive(Gtk.Widget widget, int sensitive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_size_request(Gtk.Widget widget, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_state(Gtk.Widget widget, Gtk.StateType state);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_state_flags(Gtk.Widget widget, Gtk.StateFlags flags, int clear);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_style(Gtk.Widget widget, Gtk.Style style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_support_multidevice(Gtk.Widget widget, int support_multidevice);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_tooltip_markup(Gtk.Widget widget, string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_tooltip_text(Gtk.Widget widget, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_tooltip_window(Gtk.Widget widget, Gtk.Window custom_window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_valign(Gtk.Widget widget, Gtk.Align align);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_vexpand(Gtk.Widget widget, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_vexpand_set(Gtk.Widget widget, int set);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_visible(Gtk.Widget widget, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_visual(Gtk.Widget widget, Gdk.Visual visual);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_set_window(Gtk.Widget widget, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_shape_combine_region(Gtk.Widget widget, cairo.Region region);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_show(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_show_all(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_show_now(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_size_allocate(Gtk.Widget widget, Gdk.Rectangle allocation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_size_allocate_with_baseline(Gtk.Widget widget, Gdk.Rectangle allocation, int baseline);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_style_attach(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_style_get_property(Gtk.Widget widget, string property_name, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_thaw_child_notify(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_translate_coordinates(Gtk.Widget src_widget, Gtk.Widget dest_widget, int src_x, int src_y, System.IntPtr dest_x, System.IntPtr dest_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_trigger_tooltip_query(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_unmap(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_unparent(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_unrealize(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_unregister_window(Gtk.Widget widget, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_unset_state_flags(Gtk.Widget widget, Gtk.StateFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_about_dialog_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_add_credit_section(Gtk.AboutDialog about, string section_name, System.IntPtr people);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_about_dialog_get_artists(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_about_dialog_get_authors(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_comments(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_copyright(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_about_dialog_get_documenters(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_license(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.License gtk_about_dialog_get_license_type(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_about_dialog_get_logo(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_logo_icon_name(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_program_name(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_translator_credits(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_version(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_website(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_about_dialog_get_website_label(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_about_dialog_get_wrap_license(Gtk.AboutDialog about);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_artists(Gtk.AboutDialog about, System.IntPtr artists);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_authors(Gtk.AboutDialog about, System.IntPtr authors);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_comments(Gtk.AboutDialog about, string comments);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_copyright(Gtk.AboutDialog about, string copyright);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_documenters(Gtk.AboutDialog about, System.IntPtr documenters);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_license(Gtk.AboutDialog about, string license);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_license_type(Gtk.AboutDialog about, Gtk.License license_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_logo(Gtk.AboutDialog about, GdkPixbuf.Pixbuf logo);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_logo_icon_name(Gtk.AboutDialog about, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_program_name(Gtk.AboutDialog about, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_translator_credits(Gtk.AboutDialog about, string translator_credits);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_version(Gtk.AboutDialog about, string version);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_website(Gtk.AboutDialog about, string website);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_website_label(Gtk.AboutDialog about, string website_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_about_dialog_set_wrap_license(Gtk.AboutDialog about, int wrap_license);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_dialog_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_dialog_add_action_widget(Gtk.Dialog dialog, Gtk.Widget child, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_dialog_add_button(Gtk.Dialog dialog, string button_text, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_dialog_get_action_area(Gtk.Dialog dialog);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Box gtk_dialog_get_content_area(Gtk.Dialog dialog);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_dialog_get_header_bar(Gtk.Dialog dialog);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_dialog_get_response_for_widget(Gtk.Dialog dialog, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_dialog_get_widget_for_response(Gtk.Dialog dialog, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_dialog_response(Gtk.Dialog dialog, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_dialog_run(Gtk.Dialog dialog);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_dialog_set_alternative_button_order_from_array(Gtk.Dialog dialog, int n_params, System.IntPtr new_order);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_dialog_set_default_response(Gtk.Dialog dialog, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_dialog_set_response_sensitive(Gtk.Dialog dialog, int response_id, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AccelGroup gtk_accel_group_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AccelGroup gtk_accel_group_from_accel_closure(GObject.Closure closure);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accel_group_activate(Gtk.AccelGroup accel_group, uint accel_quark, GObject.Object acceleratable, uint accel_key, Gdk.ModifierType accel_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_group_connect(Gtk.AccelGroup accel_group, uint accel_key, Gdk.ModifierType accel_mods, Gtk.AccelFlags accel_flags, GObject.Closure closure);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_group_connect_by_path(Gtk.AccelGroup accel_group, string accel_path, GObject.Closure closure);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accel_group_disconnect(Gtk.AccelGroup accel_group, GObject.Closure closure);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accel_group_disconnect_key(Gtk.AccelGroup accel_group, uint accel_key, Gdk.ModifierType accel_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AccelKey gtk_accel_group_find(Gtk.AccelGroup accel_group, System.IntPtr find_func, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accel_group_get_is_locked(Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.ModifierType gtk_accel_group_get_modifier_mask(Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_group_lock(Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_accel_group_query(Gtk.AccelGroup accel_group, uint accel_key, Gdk.ModifierType accel_mods, System.IntPtr n_entries);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_group_unlock(Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_accel_label_new(string @string);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_label_get_accel(Gtk.AccelLabel accel_label, System.IntPtr accelerator_key, out Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_accel_label_get_accel_widget(Gtk.AccelLabel accel_label);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_accel_label_get_accel_width(Gtk.AccelLabel accel_label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accel_label_refetch(Gtk.AccelLabel accel_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_label_set_accel(Gtk.AccelLabel accel_label, uint accelerator_key, Gdk.ModifierType accelerator_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_label_set_accel_closure(Gtk.AccelLabel accel_label, GObject.Closure accel_closure);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_label_set_accel_widget(Gtk.AccelLabel accel_label, Gtk.Widget accel_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_label_new(string str);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_label_new_with_mnemonic(string str);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_label_get_angle(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.AttrList gtk_label_get_attributes(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_label_get_current_uri(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.EllipsizeMode gtk_label_get_ellipsize(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Justification gtk_label_get_justify(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_label_get_label(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Layout gtk_label_get_layout(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_get_layout_offsets(Gtk.Label label, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_line_wrap(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.WrapMode gtk_label_get_line_wrap_mode(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_lines(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_max_width_chars(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_label_get_mnemonic_keyval(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_label_get_mnemonic_widget(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_selectable(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_selection_bounds(Gtk.Label label, System.IntPtr start, System.IntPtr end);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_single_line_mode(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_label_get_text(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_track_visited_links(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_use_markup(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_use_underline(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_label_get_width_chars(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern float gtk_label_get_xalign(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern float gtk_label_get_yalign(Gtk.Label label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_select_region(Gtk.Label label, int start_offset, int end_offset);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_angle(Gtk.Label label, double angle);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_attributes(Gtk.Label label, Pango.AttrList attrs);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_ellipsize(Gtk.Label label, Pango.EllipsizeMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_justify(Gtk.Label label, Gtk.Justification jtype);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_label(Gtk.Label label, string str);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_line_wrap(Gtk.Label label, int wrap);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_line_wrap_mode(Gtk.Label label, Pango.WrapMode wrap_mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_lines(Gtk.Label label, int lines);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_markup(Gtk.Label label, string str);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_markup_with_mnemonic(Gtk.Label label, string str);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_max_width_chars(Gtk.Label label, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_mnemonic_widget(Gtk.Label label, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_pattern(Gtk.Label label, string pattern);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_selectable(Gtk.Label label, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_single_line_mode(Gtk.Label label, int single_line_mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_text(Gtk.Label label, string str);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_text_with_mnemonic(Gtk.Label label, string str);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_track_visited_links(Gtk.Label label, int track_links);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_use_markup(Gtk.Label label, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_use_underline(Gtk.Label label, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_width_chars(Gtk.Label label, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_xalign(Gtk.Label label, float xalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_label_set_yalign(Gtk.Label label, float yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_add_entry(string accel_path, uint accel_key, Gdk.ModifierType accel_mods);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_add_filter(string filter_pattern);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_accel_map_change_entry(string accel_path, uint accel_key, Gdk.ModifierType accel_mods, int replace);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_foreach(System.IntPtr data, System.IntPtr foreach_func);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_foreach_unfiltered(System.IntPtr data, System.IntPtr foreach_func);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AccelMap gtk_accel_map_get();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_load(System.IntPtr file_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_load_fd(int fd);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_load_scanner(GLib.Scanner scanner);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_lock_path(string accel_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_save(System.IntPtr file_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_save_fd(int fd);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accel_map_unlock_path(string accel_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accessible_connect_widget_destroyed(Gtk.Accessible accessible);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_accessible_get_widget(Gtk.Accessible accessible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_accessible_set_widget(Gtk.Accessible accessible, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Action gtk_action_new(string name, string label, string tooltip, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_activate(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_block_activate(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_connect_accelerator(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_action_create_icon(Gtk.Action action, int icon_size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_action_create_menu(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_action_create_menu_item(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_action_create_tool_item(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_disconnect_accelerator(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.Closure gtk_action_get_accel_closure(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_get_accel_path(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_get_always_show_image(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Icon gtk_action_get_gicon(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_get_icon_name(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_get_is_important(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_get_label(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_get_name(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_action_get_proxies(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_get_sensitive(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_get_short_label(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_get_stock_id(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_get_tooltip(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_get_visible(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_get_visible_horizontal(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_get_visible_vertical(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_is_sensitive(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_is_visible(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_accel_group(Gtk.Action action, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_accel_path(Gtk.Action action, string accel_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_always_show_image(Gtk.Action action, int always_show);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_gicon(Gtk.Action action, Gio.Icon icon);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_icon_name(Gtk.Action action, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_is_important(Gtk.Action action, int is_important);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_label(Gtk.Action action, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_sensitive(Gtk.Action action, int sensitive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_short_label(Gtk.Action action, string short_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_stock_id(Gtk.Action action, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_tooltip(Gtk.Action action, string tooltip);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_visible(Gtk.Action action, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_visible_horizontal(Gtk.Action action, int visible_horizontal);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_set_visible_vertical(Gtk.Action action, int visible_vertical);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_unblock_activate(Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ActionGroup gtk_action_group_new(string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_action(Gtk.ActionGroup action_group, Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_action_with_accel(Gtk.ActionGroup action_group, Gtk.Action action, string accelerator);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_actions(Gtk.ActionGroup action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_actions_full(Gtk.ActionGroup action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_radio_actions(Gtk.ActionGroup action_group, System.IntPtr entries, uint n_entries, int value, System.IntPtr on_change, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_radio_actions_full(Gtk.ActionGroup action_group, System.IntPtr entries, uint n_entries, int value, System.IntPtr on_change, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_toggle_actions(Gtk.ActionGroup action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_add_toggle_actions_full(Gtk.ActionGroup action_group, System.IntPtr entries, uint n_entries, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AccelGroup gtk_action_group_get_accel_group(Gtk.ActionGroup action_group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Action gtk_action_group_get_action(Gtk.ActionGroup action_group, string action_name);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_group_get_name(Gtk.ActionGroup action_group);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_group_get_sensitive(Gtk.ActionGroup action_group);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_action_group_get_visible(Gtk.ActionGroup action_group);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_action_group_list_actions(Gtk.ActionGroup action_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_remove_action(Gtk.ActionGroup action_group, Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_set_accel_group(Gtk.ActionGroup action_group, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_set_sensitive(Gtk.ActionGroup action_group, int sensitive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_set_translate_func(Gtk.ActionGroup action_group, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_set_translation_domain(Gtk.ActionGroup action_group, string domain);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_group_set_visible(Gtk.ActionGroup action_group, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_action_group_translate_string(Gtk.ActionGroup action_group, string @string);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_action_bar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_action_bar_get_center_widget(Gtk.ActionBar action_bar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_bar_pack_end(Gtk.ActionBar action_bar, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_bar_pack_start(Gtk.ActionBar action_bar, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_action_bar_set_center_widget(Gtk.ActionBar action_bar, Gtk.Widget center_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_bin_get_child(Gtk.Bin bin);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_actionable_get_action_name(Gtk.Actionable actionable);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.Variant gtk_actionable_get_action_target_value(Gtk.Actionable actionable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_actionable_set_action_name(Gtk.Actionable actionable, string action_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_actionable_set_action_target_value(Gtk.Actionable actionable, GLib.Variant target_value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_actionable_set_detailed_action_name(Gtk.Actionable actionable, string detailed_action_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_activatable_do_set_related_action(Gtk.Activatable activatable, Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Action gtk_activatable_get_related_action(Gtk.Activatable activatable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_activatable_get_use_action_appearance(Gtk.Activatable activatable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_activatable_set_related_action(Gtk.Activatable activatable, Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_activatable_set_use_action_appearance(Gtk.Activatable activatable, int use_appearance);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_activatable_sync_action_properties(Gtk.Activatable activatable, Gtk.Action action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_adjustment_new(double value, double lower, double upper, double step_increment, double page_increment, double page_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_changed(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_clamp_page(Gtk.Adjustment adjustment, double lower, double upper);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_configure(Gtk.Adjustment adjustment, double value, double lower, double upper, double step_increment, double page_increment, double page_size);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_adjustment_get_lower(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_adjustment_get_minimum_increment(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_adjustment_get_page_increment(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_adjustment_get_page_size(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_adjustment_get_step_increment(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_adjustment_get_upper(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_adjustment_get_value(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_set_lower(Gtk.Adjustment adjustment, double lower);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_set_page_increment(Gtk.Adjustment adjustment, double page_increment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_set_page_size(Gtk.Adjustment adjustment, double page_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_set_step_increment(Gtk.Adjustment adjustment, double step_increment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_set_upper(Gtk.Adjustment adjustment, double upper);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_set_value(Gtk.Adjustment adjustment, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_adjustment_value_changed(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_alignment_new(float xalign, float yalign, float xscale, float yscale);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_alignment_get_padding(Gtk.Alignment alignment, System.IntPtr padding_top, System.IntPtr padding_bottom, System.IntPtr padding_left, System.IntPtr padding_right);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_alignment_set(Gtk.Alignment alignment, float xalign, float yalign, float xscale, float yscale);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_alignment_set_padding(Gtk.Alignment alignment, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.AppInfo gtk_app_chooser_get_app_info(Gtk.AppChooser self);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_app_chooser_get_content_type(Gtk.AppChooser self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_refresh(Gtk.AppChooser self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_editable_editing_done(Gtk.CellEditable cell_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_editable_remove_widget(Gtk.CellEditable cell_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_editable_start_editing(Gtk.CellEditable cell_editable, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_layout_add_attribute(Gtk.CellLayout cell_layout, Gtk.CellRenderer cell, string attribute, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_layout_clear(Gtk.CellLayout cell_layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_layout_clear_attributes(Gtk.CellLayout cell_layout, Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellArea gtk_cell_layout_get_area(Gtk.CellLayout cell_layout);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_cell_layout_get_cells(Gtk.CellLayout cell_layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_layout_pack_end(Gtk.CellLayout cell_layout, Gtk.CellRenderer cell, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_layout_pack_start(Gtk.CellLayout cell_layout, Gtk.CellRenderer cell, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_layout_reorder(Gtk.CellLayout cell_layout, Gtk.CellRenderer cell, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_layout_set_cell_data_func(Gtk.CellLayout cell_layout, Gtk.CellRenderer cell, System.IntPtr func, System.IntPtr func_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_app_chooser_button_new(string content_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_button_append_custom_item(Gtk.AppChooserButton self, string name, string label, Gio.Icon icon);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_button_append_separator(Gtk.AppChooserButton self);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_app_chooser_button_get_heading(Gtk.AppChooserButton self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_app_chooser_button_get_show_default_item(Gtk.AppChooserButton self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_app_chooser_button_get_show_dialog_item(Gtk.AppChooserButton self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_button_set_active_custom_item(Gtk.AppChooserButton self, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_button_set_heading(Gtk.AppChooserButton self, string heading);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_button_set_show_default_item(Gtk.AppChooserButton self, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_button_set_show_dialog_item(Gtk.AppChooserButton self, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_new_with_area(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_new_with_area_and_entry(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_new_with_entry();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_new_with_model(Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_new_with_model_and_entry(Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_active(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_combo_box_get_active_id(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_add_tearoffs(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SensitivityType gtk_combo_box_get_button_sensitivity(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_column_span_column(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_entry_text_column(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_focus_on_click(Gtk.ComboBox combo);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_has_entry(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_id_column(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_combo_box_get_model(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern Atk.Object gtk_combo_box_get_popup_accessible(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_popup_fixed_width(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_combo_box_get_row_separator_func(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_row_span_column(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_combo_box_get_title(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_get_wrap_width(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_popdown(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_popup(Gtk.ComboBox combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_popup_for_device(Gtk.ComboBox combo_box, Gdk.Device device);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_active(Gtk.ComboBox combo_box, int index_);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_combo_box_set_active_id(Gtk.ComboBox combo_box, string active_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_active_iter(Gtk.ComboBox combo_box, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_add_tearoffs(Gtk.ComboBox combo_box, int add_tearoffs);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_button_sensitivity(Gtk.ComboBox combo_box, Gtk.SensitivityType sensitivity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_column_span_column(Gtk.ComboBox combo_box, int column_span);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_entry_text_column(Gtk.ComboBox combo_box, int text_column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_focus_on_click(Gtk.ComboBox combo, int focus_on_click);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_id_column(Gtk.ComboBox combo_box, int id_column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_model(Gtk.ComboBox combo_box, Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_popup_fixed_width(Gtk.ComboBox combo_box, int @fixed);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_row_separator_func(Gtk.ComboBox combo_box, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_row_span_column(Gtk.ComboBox combo_box, int row_span);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_title(Gtk.ComboBox combo_box, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_set_wrap_width(Gtk.ComboBox combo_box, int width);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_window_new(Gtk.WindowType type);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_window_get_default_icon_list();
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_window_get_default_icon_name();
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_window_list_toplevels();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_auto_startup_notification(int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_default_icon(GdkPixbuf.Pixbuf icon);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_set_default_icon_from_file(System.IntPtr filename, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_default_icon_list(System.IntPtr list);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_default_icon_name(string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_interactive_debugging(int enable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_activate_default(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_activate_focus(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_activate_key(Gtk.Window window, Gdk.EventKey @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_add_accel_group(Gtk.Window window, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_add_mnemonic(Gtk.Window window, uint keyval, Gtk.Widget target);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_begin_move_drag(Gtk.Window window, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_begin_resize_drag(Gtk.Window window, Gdk.WindowEdge edge, int button, int root_x, int root_y, uint timestamp);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_close(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_deiconify(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_fullscreen(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_fullscreen_on_monitor(Gtk.Window window, Gdk.Screen screen, int monitor);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_accept_focus(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Application gtk_window_get_application(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_window_get_attached_to(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_decorated(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_get_default_size(Gtk.Window window, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_window_get_default_widget(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_deletable(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_destroy_with_parent(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_window_get_focus(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_focus_on_map(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_focus_visible(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Gravity gtk_window_get_gravity(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WindowGroup gtk_window_get_group(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_has_resize_grip(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_hide_titlebar_when_maximized(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_window_get_icon(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_window_get_icon_list(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_window_get_icon_name(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.ModifierType gtk_window_get_mnemonic_modifier(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_mnemonics_visible(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_modal(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_window_get_opacity(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_get_position(Gtk.Window window, System.IntPtr root_x, System.IntPtr root_y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_resizable(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_window_get_role(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Screen gtk_window_get_screen(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_get_size(Gtk.Window window, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_skip_pager_hint(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_skip_taskbar_hint(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_window_get_title(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_window_get_titlebar(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Window gtk_window_get_transient_for(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.WindowTypeHint gtk_window_get_type_hint(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_get_urgency_hint(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WindowType gtk_window_get_window_type(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_has_group(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_has_toplevel_focus(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_iconify(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_is_active(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_is_maximized(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_maximize(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_mnemonic_activate(Gtk.Window window, uint keyval, Gdk.ModifierType modifier);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_move(Gtk.Window window, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_parse_geometry(Gtk.Window window, string geometry);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_present(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_present_with_time(Gtk.Window window, uint timestamp);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_propagate_key_event(Gtk.Window window, Gdk.EventKey @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_remove_accel_group(Gtk.Window window, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_remove_mnemonic(Gtk.Window window, uint keyval, Gtk.Widget target);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_reshow_with_initial_size(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_resize(Gtk.Window window, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_resize_grip_is_visible(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_resize_to_geometry(Gtk.Window window, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_accept_focus(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_application(Gtk.Window window, Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_attached_to(Gtk.Window window, Gtk.Widget attach_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_decorated(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_default(Gtk.Window window, Gtk.Widget default_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_default_geometry(Gtk.Window window, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_default_size(Gtk.Window window, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_deletable(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_destroy_with_parent(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_focus(Gtk.Window window, Gtk.Widget focus);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_focus_on_map(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_focus_visible(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_geometry_hints(Gtk.Window window, Gtk.Widget geometry_widget, Gdk.Geometry geometry, Gdk.WindowHints geom_mask);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_gravity(Gtk.Window window, Gdk.Gravity gravity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_has_resize_grip(Gtk.Window window, int value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_has_user_ref_count(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_hide_titlebar_when_maximized(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_icon(Gtk.Window window, GdkPixbuf.Pixbuf icon);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_window_set_icon_from_file(Gtk.Window window, System.IntPtr filename, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_icon_list(Gtk.Window window, System.IntPtr list);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_icon_name(Gtk.Window window, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_keep_above(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_keep_below(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_mnemonic_modifier(Gtk.Window window, Gdk.ModifierType modifier);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_mnemonics_visible(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_modal(Gtk.Window window, int modal);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_opacity(Gtk.Window window, double opacity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_position(Gtk.Window window, Gtk.WindowPosition position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_resizable(Gtk.Window window, int resizable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_role(Gtk.Window window, string role);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_screen(Gtk.Window window, Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_skip_pager_hint(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_skip_taskbar_hint(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_startup_id(Gtk.Window window, string startup_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_title(Gtk.Window window, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_titlebar(Gtk.Window window, Gtk.Widget titlebar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_transient_for(Gtk.Window window, Gtk.Window parent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_type_hint(Gtk.Window window, Gdk.WindowTypeHint hint);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_urgency_hint(Gtk.Window window, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_set_wmclass(Gtk.Window window, string wmclass_name, string wmclass_class);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_stick(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_unfullscreen(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_unmaximize(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_unstick(Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_app_chooser_dialog_new(Gtk.Window parent, Gtk.DialogFlags flags, Gio.File file);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_app_chooser_dialog_new_for_content_type(Gtk.Window parent, Gtk.DialogFlags flags, string content_type);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_app_chooser_dialog_get_heading(Gtk.AppChooserDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_app_chooser_dialog_get_widget(Gtk.AppChooserDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_dialog_set_heading(Gtk.AppChooserDialog self, string heading);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Orientation gtk_orientable_get_orientation(Gtk.Orientable orientable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_orientable_set_orientation(Gtk.Orientable orientable, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_app_chooser_widget_new(string content_type);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_app_chooser_widget_get_default_text(Gtk.AppChooserWidget self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_app_chooser_widget_get_show_all(Gtk.AppChooserWidget self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_app_chooser_widget_get_show_default(Gtk.AppChooserWidget self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_app_chooser_widget_get_show_fallback(Gtk.AppChooserWidget self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_app_chooser_widget_get_show_other(Gtk.AppChooserWidget self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_app_chooser_widget_get_show_recommended(Gtk.AppChooserWidget self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_widget_set_default_text(Gtk.AppChooserWidget self, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_widget_set_show_all(Gtk.AppChooserWidget self, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_widget_set_show_default(Gtk.AppChooserWidget self, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_widget_set_show_fallback(Gtk.AppChooserWidget self, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_widget_set_show_other(Gtk.AppChooserWidget self, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_app_chooser_widget_set_show_recommended(Gtk.AppChooserWidget self, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_box_new(Gtk.Orientation orientation, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.BaselinePosition gtk_box_get_baseline_position(Gtk.Box box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_box_get_center_widget(Gtk.Box box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_box_get_homogeneous(Gtk.Box box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_box_get_spacing(Gtk.Box box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_pack_end(Gtk.Box box, Gtk.Widget child, int expand, int fill, uint padding);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_pack_start(Gtk.Box box, Gtk.Widget child, int expand, int fill, uint padding);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_query_child_packing(Gtk.Box box, Gtk.Widget child, System.IntPtr expand, System.IntPtr fill, System.IntPtr padding, out Gtk.PackType pack_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_reorder_child(Gtk.Box box, Gtk.Widget child, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_set_baseline_position(Gtk.Box box, Gtk.BaselinePosition position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_set_center_widget(Gtk.Box box, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_set_child_packing(Gtk.Box box, Gtk.Widget child, int expand, int fill, uint padding, Gtk.PackType pack_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_set_homogeneous(Gtk.Box box, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_box_set_spacing(Gtk.Box box, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_new_from_model(Gio.MenuModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_menu_get_for_attach_widget(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_attach(Gtk.Menu menu, Gtk.Widget child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_attach_to_widget(Gtk.Menu menu, Gtk.Widget attach_widget, System.IntPtr detacher);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_detach(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AccelGroup gtk_menu_get_accel_group(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_menu_get_accel_path(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_get_active(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_get_attach_widget(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_get_monitor(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_get_reserve_toggle_size(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_get_tearoff_state(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_menu_get_title(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_place_on_monitor(Gtk.Menu menu, Gdk.Monitor monitor);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_popdown(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_popup(Gtk.Menu menu, Gtk.Widget parent_menu_shell, Gtk.Widget parent_menu_item, System.IntPtr func, System.IntPtr data, uint button, uint activate_time);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_popup_at_pointer(Gtk.Menu menu, System.IntPtr trigger_event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_popup_at_rect(Gtk.Menu menu, Gdk.Window rect_window, Gdk.Rectangle rect, Gdk.Gravity rect_anchor, Gdk.Gravity menu_anchor, System.IntPtr trigger_event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_popup_at_widget(Gtk.Menu menu, Gtk.Widget widget, Gdk.Gravity widget_anchor, Gdk.Gravity menu_anchor, System.IntPtr trigger_event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_popup_for_device(Gtk.Menu menu, Gdk.Device device, Gtk.Widget parent_menu_shell, Gtk.Widget parent_menu_item, System.IntPtr func, System.IntPtr data, System.IntPtr destroy, uint button, uint activate_time);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_reorder_child(Gtk.Menu menu, Gtk.Widget child, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_reposition(Gtk.Menu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_accel_group(Gtk.Menu menu, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_accel_path(Gtk.Menu menu, string accel_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_active(Gtk.Menu menu, uint index);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_monitor(Gtk.Menu menu, int monitor_num);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_reserve_toggle_size(Gtk.Menu menu, int reserve_toggle_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_screen(Gtk.Menu menu, Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_tearoff_state(Gtk.Menu menu, int torn_off);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_set_title(Gtk.Menu menu, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Application gtk_application_new(string application_id, Gio.ApplicationFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_add_accelerator(Gtk.Application application, string accelerator, string action_name, GLib.Variant parameter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_add_window(Gtk.Application application, Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_application_get_accels_for_action(Gtk.Application application, string detailed_action_name);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_application_get_actions_for_accel(Gtk.Application application, string accel);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Window gtk_application_get_active_window(Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.MenuModel gtk_application_get_app_menu(Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Menu gtk_application_get_menu_by_id(Gtk.Application application, string id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.MenuModel gtk_application_get_menubar(Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Window gtk_application_get_window_by_id(Gtk.Application application, uint id);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_application_get_windows(Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_application_inhibit(Gtk.Application application, Gtk.Window window, Gtk.ApplicationInhibitFlags flags, string reason);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_application_is_inhibited(Gtk.Application application, Gtk.ApplicationInhibitFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_application_list_action_descriptions(Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_application_prefers_app_menu(Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_remove_accelerator(Gtk.Application application, string action_name, GLib.Variant parameter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_remove_window(Gtk.Application application, Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_set_accels_for_action(Gtk.Application application, string detailed_action_name, System.IntPtr accels);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_set_app_menu(Gtk.Application application, Gio.MenuModel app_menu);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_set_menubar(Gtk.Application application, Gio.MenuModel menubar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_uninhibit(Gtk.Application application, uint cookie);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_application_window_new(Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ShortcutsWindow gtk_application_window_get_help_overlay(Gtk.ApplicationWindow window);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_application_window_get_id(Gtk.ApplicationWindow window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_application_window_get_show_menubar(Gtk.ApplicationWindow window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_window_set_help_overlay(Gtk.ApplicationWindow window, Gtk.ShortcutsWindow help_overlay);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_application_window_set_show_menubar(Gtk.ApplicationWindow window, int show_menubar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_arrow_new(Gtk.ArrowType arrow_type, Gtk.ShadowType shadow_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_arrow_set(Gtk.Arrow arrow, Gtk.ArrowType arrow_type, Gtk.ShadowType shadow_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_misc_get_alignment(Gtk.Misc misc, System.IntPtr xalign, System.IntPtr yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_misc_get_padding(Gtk.Misc misc, System.IntPtr xpad, System.IntPtr ypad);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_misc_set_alignment(Gtk.Misc misc, float xalign, float yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_misc_set_padding(Gtk.Misc misc, int xpad, int ypad);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_aspect_frame_new(string label, float xalign, float yalign, float ratio, int obey_child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_aspect_frame_set(Gtk.AspectFrame aspect_frame, float xalign, float yalign, float ratio, int obey_child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_frame_new(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_frame_get_label(Gtk.Frame frame);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_frame_get_label_align(Gtk.Frame frame, System.IntPtr xalign, System.IntPtr yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_frame_get_label_widget(Gtk.Frame frame);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ShadowType gtk_frame_get_shadow_type(Gtk.Frame frame);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_frame_set_label(Gtk.Frame frame, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_frame_set_label_align(Gtk.Frame frame, float xalign, float yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_frame_set_label_widget(Gtk.Frame frame, Gtk.Widget label_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_frame_set_shadow_type(Gtk.Frame frame, Gtk.ShadowType type);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_assistant_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_add_action_widget(Gtk.Assistant assistant, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_assistant_append_page(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_commit(Gtk.Assistant assistant);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_assistant_get_current_page(Gtk.Assistant assistant);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_assistant_get_n_pages(Gtk.Assistant assistant);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_assistant_get_nth_page(Gtk.Assistant assistant, int page_num);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_assistant_get_page_complete(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_assistant_get_page_has_padding(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_assistant_get_page_header_image(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_assistant_get_page_side_image(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_assistant_get_page_title(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AssistantPageType gtk_assistant_get_page_type(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_assistant_insert_page(Gtk.Assistant assistant, Gtk.Widget page, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_next_page(Gtk.Assistant assistant);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_assistant_prepend_page(Gtk.Assistant assistant, Gtk.Widget page);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_previous_page(Gtk.Assistant assistant);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_remove_action_widget(Gtk.Assistant assistant, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_remove_page(Gtk.Assistant assistant, int page_num);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_current_page(Gtk.Assistant assistant, int page_num);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_forward_page_func(Gtk.Assistant assistant, System.IntPtr page_func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_page_complete(Gtk.Assistant assistant, Gtk.Widget page, int complete);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_page_has_padding(Gtk.Assistant assistant, Gtk.Widget page, int has_padding);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_page_header_image(Gtk.Assistant assistant, Gtk.Widget page, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_page_side_image(Gtk.Assistant assistant, Gtk.Widget page, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_page_title(Gtk.Assistant assistant, Gtk.Widget page, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_set_page_type(Gtk.Assistant assistant, Gtk.Widget page, Gtk.AssistantPageType type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_assistant_update_buttons_state(Gtk.Assistant assistant);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_add(Gtk.Container container, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_check_resize(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_child_get_property(Gtk.Container container, Gtk.Widget child, string property_name, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_child_notify(Gtk.Container container, Gtk.Widget child, string child_property);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_child_notify_by_pspec(Gtk.Container container, Gtk.Widget child, GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_child_set_property(Gtk.Container container, Gtk.Widget child, string property_name, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_container_child_type(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_forall(Gtk.Container container, System.IntPtr callback, System.IntPtr callback_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_foreach(Gtk.Container container, System.IntPtr callback, System.IntPtr callback_data);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_container_get_border_width(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_container_get_children(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_container_get_focus_chain(Gtk.Container container, System.IntPtr focusable_widgets);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_container_get_focus_child(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_container_get_focus_hadjustment(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_container_get_focus_vadjustment(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_container_get_path_for_child(Gtk.Container container, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ResizeMode gtk_container_get_resize_mode(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_propagate_draw(Gtk.Container container, Gtk.Widget child, cairo.Context cr);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_remove(Gtk.Container container, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_resize_children(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_set_border_width(Gtk.Container container, uint border_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_set_focus_chain(Gtk.Container container, System.IntPtr focusable_widgets);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_set_focus_child(Gtk.Container container, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_set_focus_hadjustment(Gtk.Container container, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_set_focus_vadjustment(Gtk.Container container, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_set_reallocate_redraws(Gtk.Container container, int needs_redraws);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_set_resize_mode(Gtk.Container container, Gtk.ResizeMode resize_mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_unset_focus_chain(Gtk.Container container);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.ParamSpec gtk_container_class_find_child_property(Gtk.ContainerClass cclass, string property_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_class_handle_border_width(Gtk.ContainerClass klass);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_class_install_child_properties(Gtk.ContainerClass cclass, uint n_pspecs, System.IntPtr pspecs);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_class_install_child_property(Gtk.ContainerClass cclass, uint property_id, GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_container_class_list_child_properties(Gtk.ContainerClass cclass, System.IntPtr n_properties);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_binding_set_activate(Gtk.BindingSet binding_set, uint keyval, Gdk.ModifierType modifiers, GObject.Object @object);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_binding_set_add_path(Gtk.BindingSet binding_set, Gtk.PathType path_type, string path_pattern, Gtk.PathPriorityType priority);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.BindingSet gtk_binding_set_by_class(System.IntPtr object_class);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.BindingSet gtk_binding_set_find(string set_name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.BindingSet gtk_binding_set_new(string set_name);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.TokenType gtk_binding_entry_add_signal_from_string(Gtk.BindingSet binding_set, string signal_desc);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_binding_entry_add_signall(Gtk.BindingSet binding_set, uint keyval, Gdk.ModifierType modifiers, string signal_name, System.IntPtr binding_args);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_binding_entry_remove(Gtk.BindingSet binding_set, uint keyval, Gdk.ModifierType modifiers);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_binding_entry_skip(Gtk.BindingSet binding_set, uint keyval, Gdk.ModifierType modifiers);
		[DllImport("libgtk-3.so.0")]
		public static extern Atk.Object gtk_renderer_cell_accessible_new(Gtk.CellRenderer renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Border gtk_border_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Border gtk_border_copy(Gtk.Border border_);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_border_free(Gtk.Border border_);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Builder gtk_builder_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Builder gtk_builder_new_from_file(string filename);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Builder gtk_builder_new_from_resource(string resource_path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Builder gtk_builder_new_from_string(string @string, long length);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_builder_add_callback_symbol(Gtk.Builder builder, string callback_name, System.IntPtr callback_symbol);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_add_from_file(Gtk.Builder builder, string filename, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_add_from_resource(Gtk.Builder builder, string resource_path, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_add_from_string(Gtk.Builder builder, string buffer, ulong length, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_add_objects_from_file(Gtk.Builder builder, string filename, System.IntPtr object_ids, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_add_objects_from_resource(Gtk.Builder builder, string resource_path, System.IntPtr object_ids, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_add_objects_from_string(Gtk.Builder builder, string buffer, ulong length, System.IntPtr object_ids, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_builder_connect_signals(Gtk.Builder builder, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_builder_connect_signals_full(Gtk.Builder builder, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_builder_expose_object(Gtk.Builder builder, string name, GObject.Object @object);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_extend_with_template(Gtk.Builder builder, Gtk.Widget widget, ulong template_type, string buffer, ulong length, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Application gtk_builder_get_application(Gtk.Builder builder);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.Object gtk_builder_get_object(Gtk.Builder builder, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_builder_get_objects(Gtk.Builder builder);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_builder_get_translation_domain(Gtk.Builder builder);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_builder_get_type_from_name(Gtk.Builder builder, string type_name);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_builder_lookup_callback_symbol(Gtk.Builder builder, string callback_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_builder_set_application(Gtk.Builder builder, Gtk.Application application);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_builder_set_translation_domain(Gtk.Builder builder, string domain);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_builder_error_quark();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_button_new_from_icon_name(string icon_name, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_button_new_from_stock(string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_button_new_with_label(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_button_new_with_mnemonic(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_clicked(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_enter(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_get_alignment(Gtk.Button button, System.IntPtr xalign, System.IntPtr yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_button_get_always_show_image(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_button_get_event_window(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_button_get_focus_on_click(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_button_get_image(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PositionType gtk_button_get_image_position(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_button_get_label(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ReliefStyle gtk_button_get_relief(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_button_get_use_stock(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_button_get_use_underline(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_leave(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_pressed(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_released(Gtk.Button button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_alignment(Gtk.Button button, float xalign, float yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_always_show_image(Gtk.Button button, int always_show);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_focus_on_click(Gtk.Button button, int focus_on_click);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_image(Gtk.Button button, Gtk.Widget image);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_image_position(Gtk.Button button, Gtk.PositionType position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_label(Gtk.Button button, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_relief(Gtk.Button button, Gtk.ReliefStyle relief);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_use_stock(Gtk.Button button, int use_stock);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_set_use_underline(Gtk.Button button, int use_underline);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_button_box_new(Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_button_box_get_child_non_homogeneous(Gtk.ButtonBox widget, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_button_box_get_child_secondary(Gtk.ButtonBox widget, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ButtonBoxStyle gtk_button_box_get_layout(Gtk.ButtonBox widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_box_set_child_non_homogeneous(Gtk.ButtonBox widget, Gtk.Widget child, int non_homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_box_set_child_secondary(Gtk.ButtonBox widget, Gtk.Widget child, int is_secondary);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_button_box_set_layout(Gtk.ButtonBox widget, Gtk.ButtonBoxStyle layout_style);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_calendar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_clear_marks(Gtk.Calendar calendar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_get_date(Gtk.Calendar calendar, System.IntPtr year, System.IntPtr month, System.IntPtr day);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_calendar_get_day_is_marked(Gtk.Calendar calendar, uint day);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_calendar_get_detail_height_rows(Gtk.Calendar calendar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_calendar_get_detail_width_chars(Gtk.Calendar calendar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CalendarDisplayOptions gtk_calendar_get_display_options(Gtk.Calendar calendar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_mark_day(Gtk.Calendar calendar, uint day);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_select_day(Gtk.Calendar calendar, uint day);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_select_month(Gtk.Calendar calendar, uint month, uint year);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_set_detail_func(Gtk.Calendar calendar, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_set_detail_height_rows(Gtk.Calendar calendar, int rows);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_set_detail_width_chars(Gtk.Calendar calendar, int chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_set_display_options(Gtk.Calendar calendar, Gtk.CalendarDisplayOptions flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_calendar_unmark_day(Gtk.Calendar calendar, uint day);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_bind_template_callback_full(Gtk.WidgetClass widget_class, string callback_name, System.IntPtr callback_symbol);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_bind_template_child_full(Gtk.WidgetClass widget_class, string name, int internal_child, long struct_offset);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.ParamSpec gtk_widget_class_find_style_property(Gtk.WidgetClass klass, string property_name);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_class_get_css_name(Gtk.WidgetClass widget_class);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_install_style_property(Gtk.WidgetClass klass, GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_install_style_property_parser(Gtk.WidgetClass klass, GObject.ParamSpec pspec, System.IntPtr parser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_widget_class_list_style_properties(Gtk.WidgetClass klass, System.IntPtr n_properties);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_set_accessible_role(Gtk.WidgetClass widget_class, Atk.Role role);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_set_accessible_type(Gtk.WidgetClass widget_class, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_set_connect_func(Gtk.WidgetClass widget_class, System.IntPtr connect_func, System.IntPtr connect_data, System.IntPtr connect_data_destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_set_css_name(Gtk.WidgetClass widget_class, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_set_template(Gtk.WidgetClass widget_class, GLib.Bytes template_bytes);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_class_set_template_from_resource(Gtk.WidgetClass widget_class, string resource_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_accessible_parent_activate(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_accessible_parent_edit(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_accessible_parent_expand_collapse(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_accessible_parent_get_cell_area(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell, Gdk.Rectangle cell_rect);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_accessible_parent_get_cell_extents(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell, System.IntPtr x, System.IntPtr y, System.IntPtr width, System.IntPtr height, Atk.CoordType coord_type);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_accessible_parent_get_child_index(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRendererState gtk_cell_accessible_parent_get_renderer_state(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_accessible_parent_grab_focus(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_accessible_parent_update_relationset(Gtk.CellAccessibleParent parent, Gtk.CellAccessible cell, Atk.RelationSet relationset);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_renderer_activate(Gtk.CellRenderer cell, System.IntPtr @event, Gtk.Widget widget, string path, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gtk.CellRendererState flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_alignment(Gtk.CellRenderer cell, System.IntPtr xalign, System.IntPtr yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_fixed_size(Gtk.CellRenderer cell, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_padding(Gtk.CellRenderer cell, System.IntPtr xpad, System.IntPtr ypad);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_preferred_height(Gtk.CellRenderer cell, Gtk.Widget widget, System.IntPtr minimum_size, System.IntPtr natural_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_preferred_height_for_width(Gtk.CellRenderer cell, Gtk.Widget widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_preferred_width(Gtk.CellRenderer cell, Gtk.Widget widget, System.IntPtr minimum_size, System.IntPtr natural_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_preferred_width_for_height(Gtk.CellRenderer cell, Gtk.Widget widget, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SizeRequestMode gtk_cell_renderer_get_request_mode(Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_renderer_get_sensitive(Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_get_size(Gtk.CellRenderer cell, Gtk.Widget widget, Gdk.Rectangle cell_area, System.IntPtr x_offset, System.IntPtr y_offset, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StateFlags gtk_cell_renderer_get_state(Gtk.CellRenderer cell, Gtk.Widget widget, Gtk.CellRendererState cell_state);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_renderer_get_visible(Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_renderer_is_activatable(Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_render(Gtk.CellRenderer cell, cairo.Context cr, Gtk.Widget widget, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gtk.CellRendererState flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_set_alignment(Gtk.CellRenderer cell, float xalign, float yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_set_fixed_size(Gtk.CellRenderer cell, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_set_padding(Gtk.CellRenderer cell, int xpad, int ypad);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_set_sensitive(Gtk.CellRenderer cell, int sensitive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_set_visible(Gtk.CellRenderer cell, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellEditable gtk_cell_renderer_start_editing(Gtk.CellRenderer cell, System.IntPtr @event, Gtk.Widget widget, string path, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gtk.CellRendererState flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_stop_editing(Gtk.CellRenderer cell, int canceled);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_activate(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, Gdk.Rectangle cell_area, Gtk.CellRendererState flags, int edit_only);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_activate_cell(Gtk.CellArea area, Gtk.Widget widget, Gtk.CellRenderer renderer, System.IntPtr @event, Gdk.Rectangle cell_area, Gtk.CellRendererState flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_add(Gtk.CellArea area, Gtk.CellRenderer renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_add_focus_sibling(Gtk.CellArea area, Gtk.CellRenderer renderer, Gtk.CellRenderer sibling);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_apply_attributes(Gtk.CellArea area, Gtk.TreeModel tree_model, Gtk.TreeIter iter, int is_expander, int is_expanded);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_attribute_connect(Gtk.CellArea area, Gtk.CellRenderer renderer, string attribute, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_attribute_disconnect(Gtk.CellArea area, Gtk.CellRenderer renderer, string attribute);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_attribute_get_column(Gtk.CellArea area, Gtk.CellRenderer renderer, string attribute);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_cell_get_property(Gtk.CellArea area, Gtk.CellRenderer renderer, string property_name, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_cell_set_property(Gtk.CellArea area, Gtk.CellRenderer renderer, string property_name, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellAreaContext gtk_cell_area_copy_context(Gtk.CellArea area, Gtk.CellAreaContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellAreaContext gtk_cell_area_create_context(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_event(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, System.IntPtr @event, Gdk.Rectangle cell_area, Gtk.CellRendererState flags);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_focus(Gtk.CellArea area, Gtk.DirectionType direction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_foreach(Gtk.CellArea area, System.IntPtr callback, System.IntPtr callback_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_foreach_alloc(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, Gdk.Rectangle cell_area, Gdk.Rectangle background_area, System.IntPtr callback, System.IntPtr callback_data);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_cell_area_get_current_path_string(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellEditable gtk_cell_area_get_edit_widget(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_area_get_edited_cell(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_area_get_focus_cell(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_area_get_focus_from_sibling(Gtk.CellArea area, Gtk.CellRenderer renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_cell_area_get_focus_siblings(Gtk.CellArea area, Gtk.CellRenderer renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_get_preferred_height(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, System.IntPtr minimum_height, System.IntPtr natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_get_preferred_height_for_width(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_get_preferred_width(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, System.IntPtr minimum_width, System.IntPtr natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_get_preferred_width_for_height(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SizeRequestMode gtk_cell_area_get_request_mode(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_has_renderer(Gtk.CellArea area, Gtk.CellRenderer renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_is_activatable(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_is_focus_sibling(Gtk.CellArea area, Gtk.CellRenderer renderer, Gtk.CellRenderer sibling);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_remove(Gtk.CellArea area, Gtk.CellRenderer renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_remove_focus_sibling(Gtk.CellArea area, Gtk.CellRenderer renderer, Gtk.CellRenderer sibling);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_render(Gtk.CellArea area, Gtk.CellAreaContext context, Gtk.Widget widget, cairo.Context cr, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gtk.CellRendererState flags, int paint_focus);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_request_renderer(Gtk.CellArea area, Gtk.CellRenderer renderer, Gtk.Orientation orientation, Gtk.Widget widget, int for_size, System.IntPtr minimum_size, System.IntPtr natural_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_set_focus_cell(Gtk.CellArea area, Gtk.CellRenderer renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_stop_editing(Gtk.CellArea area, int canceled);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_allocate(Gtk.CellAreaContext context, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_get_allocation(Gtk.CellAreaContext context, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellArea gtk_cell_area_context_get_area(Gtk.CellAreaContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_get_preferred_height(Gtk.CellAreaContext context, System.IntPtr minimum_height, System.IntPtr natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_get_preferred_height_for_width(Gtk.CellAreaContext context, int width, System.IntPtr minimum_height, System.IntPtr natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_get_preferred_width(Gtk.CellAreaContext context, System.IntPtr minimum_width, System.IntPtr natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_get_preferred_width_for_height(Gtk.CellAreaContext context, int height, System.IntPtr minimum_width, System.IntPtr natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_push_preferred_height(Gtk.CellAreaContext context, int minimum_height, int natural_height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_push_preferred_width(Gtk.CellAreaContext context, int minimum_width, int natural_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_context_reset(Gtk.CellAreaContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_tree_model_filter_new(Gtk.TreeModel child_model, Gtk.TreePath root);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_foreach(Gtk.TreeModel model, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_tree_model_get_column_type(Gtk.TreeModel tree_model, int index_);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModelFlags gtk_tree_model_get_flags(Gtk.TreeModel tree_model);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_model_get_n_columns(Gtk.TreeModel tree_model);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_model_get_path(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_tree_model_get_string_from_iter(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_model_iter_has_child(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_model_iter_n_children(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_model_iter_next(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_model_iter_previous(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_ref_node(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_row_changed(Gtk.TreeModel tree_model, Gtk.TreePath path, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_row_deleted(Gtk.TreeModel tree_model, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_row_has_child_toggled(Gtk.TreeModel tree_model, Gtk.TreePath path, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_row_inserted(Gtk.TreeModel tree_model, Gtk.TreePath path, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_rows_reordered(Gtk.TreeModel tree_model, Gtk.TreePath path, Gtk.TreeIter iter, System.IntPtr new_order);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_rows_reordered_with_length(Gtk.TreeModel tree_model, Gtk.TreePath path, Gtk.TreeIter iter, System.IntPtr new_order, int length);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_tree_model_sort_new_with_model(Gtk.TreeModel child_model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_unref_node(Gtk.TreeModel tree_model, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeIter gtk_tree_iter_copy(Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_iter_free(Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellArea gtk_cell_area_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_area_box_get_spacing(Gtk.CellAreaBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_box_pack_end(Gtk.CellAreaBox box, Gtk.CellRenderer renderer, int expand, int align, int @fixed);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_box_pack_start(Gtk.CellAreaBox box, Gtk.CellRenderer renderer, int expand, int align, int @fixed);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_box_set_spacing(Gtk.CellAreaBox box, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.ParamSpec gtk_cell_area_class_find_cell_property(Gtk.CellAreaClass aclass, string property_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_area_class_install_cell_property(Gtk.CellAreaClass aclass, uint property_id, GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_cell_area_class_list_cell_properties(Gtk.CellAreaClass aclass, System.IntPtr n_properties);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Requisition gtk_requisition_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Requisition gtk_requisition_copy(Gtk.Requisition requisition);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_requisition_free(Gtk.Requisition requisition);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_text_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_text_set_fixed_height_from_font(Gtk.CellRendererText renderer, int number_of_rows);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_accel_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_class_set_accessible_type(Gtk.CellRendererClass renderer_class, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_combo_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_pixbuf_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_progress_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_spin_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_size_from_name(string name);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_icon_size_get_name(int size);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_size_lookup(int size, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_size_lookup_for_settings(Gtk.Settings settings, int size, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_size_register(string name, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_size_register_alias(string alias, int target);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_spinner_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CellRenderer gtk_cell_renderer_toggle_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_renderer_toggle_get_activatable(Gtk.CellRendererToggle toggle);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_renderer_toggle_get_active(Gtk.CellRendererToggle toggle);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_renderer_toggle_get_radio(Gtk.CellRendererToggle toggle);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_toggle_set_activatable(Gtk.CellRendererToggle toggle, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_toggle_set_active(Gtk.CellRendererToggle toggle, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_renderer_toggle_set_radio(Gtk.CellRendererToggle toggle, int radio);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_path_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_path_new_first();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_path_new_from_indicesv(System.IntPtr indices, ulong length);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_path_new_from_string(string path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_path_append_index(Gtk.TreePath path, int index_);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_path_compare(Gtk.TreePath a, Gtk.TreePath b);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_path_copy(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_path_down(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_path_free(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_path_get_depth(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_path_get_indices(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_path_get_indices_with_depth(Gtk.TreePath path, System.IntPtr depth);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_path_is_ancestor(Gtk.TreePath path, Gtk.TreePath descendant);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_path_is_descendant(Gtk.TreePath path, Gtk.TreePath ancestor);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_path_next(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_path_prepend_index(Gtk.TreePath path, int index_);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_path_prev(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_tree_path_to_string(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_path_up(Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_cell_view_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_cell_view_new_with_context(Gtk.CellArea area, Gtk.CellAreaContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_cell_view_new_with_markup(string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_cell_view_new_with_pixbuf(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_cell_view_new_with_text(string text);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_cell_view_get_displayed_row(Gtk.CellView cell_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_view_get_draw_sensitive(Gtk.CellView cell_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_cell_view_get_fit_model(Gtk.CellView cell_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_cell_view_get_model(Gtk.CellView cell_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_view_set_background_color(Gtk.CellView cell_view, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_view_set_background_rgba(Gtk.CellView cell_view, Gdk.RGBA rgba);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_view_set_displayed_row(Gtk.CellView cell_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_view_set_draw_sensitive(Gtk.CellView cell_view, int draw_sensitive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_view_set_fit_model(Gtk.CellView cell_view, int fit_model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_cell_view_set_model(Gtk.CellView cell_view, Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_toggle_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_toggle_button_new_with_label(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_toggle_button_new_with_mnemonic(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toggle_button_get_active(Gtk.ToggleButton toggle_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toggle_button_get_inconsistent(Gtk.ToggleButton toggle_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toggle_button_get_mode(Gtk.ToggleButton toggle_button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_button_set_active(Gtk.ToggleButton toggle_button, int is_active);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_button_set_inconsistent(Gtk.ToggleButton toggle_button, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_button_set_mode(Gtk.ToggleButton toggle_button, int draw_indicator);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_button_toggled(Gtk.ToggleButton toggle_button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_check_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_check_button_new_with_label(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_check_button_new_with_mnemonic(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_check_menu_item_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_check_menu_item_new_with_label(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_check_menu_item_new_with_mnemonic(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_check_menu_item_get_active(Gtk.CheckMenuItem check_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_check_menu_item_get_draw_as_radio(Gtk.CheckMenuItem check_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_check_menu_item_get_inconsistent(Gtk.CheckMenuItem check_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_check_menu_item_set_active(Gtk.CheckMenuItem check_menu_item, int is_active);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_check_menu_item_set_draw_as_radio(Gtk.CheckMenuItem check_menu_item, int draw_as_radio);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_check_menu_item_set_inconsistent(Gtk.CheckMenuItem check_menu_item, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_check_menu_item_toggled(Gtk.CheckMenuItem check_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_item_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_item_new_with_label(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_item_new_with_mnemonic(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_activate(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_deselect(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_menu_item_get_accel_path(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_menu_item_get_label(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_item_get_reserve_indicator(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_item_get_right_justified(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_item_get_submenu(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_item_get_use_underline(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_select(Gtk.MenuItem menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_set_accel_path(Gtk.MenuItem menu_item, string accel_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_set_label(Gtk.MenuItem menu_item, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_set_reserve_indicator(Gtk.MenuItem menu_item, int reserve);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_set_right_justified(Gtk.MenuItem menu_item, int right_justified);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_set_submenu(Gtk.MenuItem menu_item, Gtk.Menu submenu);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_set_use_underline(Gtk.MenuItem menu_item, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_toggle_size_allocate(Gtk.MenuItem menu_item, int allocation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_item_toggle_size_request(Gtk.MenuItem menu_item, System.IntPtr requisition);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Clipboard gtk_clipboard_get_default(Gdk.Display display);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_clear(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Display gtk_clipboard_get_display(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern GObject.Object gtk_clipboard_get_owner(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_request_image(Gtk.Clipboard clipboard, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_request_rich_text(Gtk.Clipboard clipboard, Gtk.TextBuffer buffer, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_request_targets(Gtk.Clipboard clipboard, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_request_text(Gtk.Clipboard clipboard, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_request_uris(Gtk.Clipboard clipboard, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_set_can_store(Gtk.Clipboard clipboard, System.IntPtr targets, int n_targets);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_set_image(Gtk.Clipboard clipboard, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_set_text(Gtk.Clipboard clipboard, string text, int len);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_clipboard_set_with_data(Gtk.Clipboard clipboard, System.IntPtr targets, uint n_targets, System.IntPtr get_func, System.IntPtr clear_func, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_clipboard_set_with_owner(Gtk.Clipboard clipboard, System.IntPtr targets, uint n_targets, System.IntPtr get_func, System.IntPtr clear_func, GObject.Object owner);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_clipboard_store(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_clipboard_wait_for_image(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_clipboard_wait_for_targets(Gtk.Clipboard clipboard, System.IntPtr targets, System.IntPtr n_targets);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_clipboard_wait_for_text(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_clipboard_wait_for_uris(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_clipboard_wait_is_image_available(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_clipboard_wait_is_rich_text_available(Gtk.Clipboard clipboard, Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_clipboard_wait_is_text_available(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_clipboard_wait_is_uris_available(Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextBuffer gtk_text_buffer_new(Gtk.TextTagTable table);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_add_mark(Gtk.TextBuffer buffer, Gtk.TextMark mark, Gtk.TextIter where);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_add_selection_clipboard(Gtk.TextBuffer buffer, Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_apply_tag(Gtk.TextBuffer buffer, Gtk.TextTag tag, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_apply_tag_by_name(Gtk.TextBuffer buffer, string name, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_backspace(Gtk.TextBuffer buffer, Gtk.TextIter iter, int interactive, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_begin_user_action(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_copy_clipboard(Gtk.TextBuffer buffer, Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextChildAnchor gtk_text_buffer_create_child_anchor(Gtk.TextBuffer buffer, Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextMark gtk_text_buffer_create_mark(Gtk.TextBuffer buffer, string mark_name, Gtk.TextIter where, int left_gravity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_cut_clipboard(Gtk.TextBuffer buffer, Gtk.Clipboard clipboard, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_delete(Gtk.TextBuffer buffer, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_delete_interactive(Gtk.TextBuffer buffer, Gtk.TextIter start_iter, Gtk.TextIter end_iter, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_delete_mark(Gtk.TextBuffer buffer, Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_delete_mark_by_name(Gtk.TextBuffer buffer, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_delete_selection(Gtk.TextBuffer buffer, int interactive, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_end_user_action(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_get_char_count(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetList gtk_text_buffer_get_copy_target_list(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_text_buffer_get_deserialize_formats(Gtk.TextBuffer buffer, System.IntPtr n_formats);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_get_has_selection(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextMark gtk_text_buffer_get_insert(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_get_line_count(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextMark gtk_text_buffer_get_mark(Gtk.TextBuffer buffer, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_get_modified(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetList gtk_text_buffer_get_paste_target_list(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextMark gtk_text_buffer_get_selection_bound(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_text_buffer_get_serialize_formats(Gtk.TextBuffer buffer, System.IntPtr n_formats);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_text_buffer_get_slice(Gtk.TextBuffer buffer, Gtk.TextIter start, Gtk.TextIter end, int include_hidden_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextTagTable gtk_text_buffer_get_tag_table(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_text_buffer_get_text(Gtk.TextBuffer buffer, Gtk.TextIter start, Gtk.TextIter end, int include_hidden_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_insert(Gtk.TextBuffer buffer, Gtk.TextIter iter, string text, int len);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_insert_at_cursor(Gtk.TextBuffer buffer, string text, int len);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_insert_child_anchor(Gtk.TextBuffer buffer, Gtk.TextIter iter, Gtk.TextChildAnchor anchor);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_insert_interactive(Gtk.TextBuffer buffer, Gtk.TextIter iter, string text, int len, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_insert_interactive_at_cursor(Gtk.TextBuffer buffer, string text, int len, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_insert_markup(Gtk.TextBuffer buffer, Gtk.TextIter iter, string markup, int len);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_insert_pixbuf(Gtk.TextBuffer buffer, Gtk.TextIter iter, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_insert_range(Gtk.TextBuffer buffer, Gtk.TextIter iter, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_buffer_insert_range_interactive(Gtk.TextBuffer buffer, Gtk.TextIter iter, Gtk.TextIter start, Gtk.TextIter end, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_move_mark(Gtk.TextBuffer buffer, Gtk.TextMark mark, Gtk.TextIter where);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_move_mark_by_name(Gtk.TextBuffer buffer, string name, Gtk.TextIter where);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_paste_clipboard(Gtk.TextBuffer buffer, Gtk.Clipboard clipboard, Gtk.TextIter override_location, int default_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_place_cursor(Gtk.TextBuffer buffer, Gtk.TextIter where);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_remove_all_tags(Gtk.TextBuffer buffer, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_remove_selection_clipboard(Gtk.TextBuffer buffer, Gtk.Clipboard clipboard);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_remove_tag(Gtk.TextBuffer buffer, Gtk.TextTag tag, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_remove_tag_by_name(Gtk.TextBuffer buffer, string name, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_select_range(Gtk.TextBuffer buffer, Gtk.TextIter ins, Gtk.TextIter bound);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_set_modified(Gtk.TextBuffer buffer, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_buffer_set_text(Gtk.TextBuffer buffer, string text, int len);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetEntry gtk_target_entry_new(string target, uint flags, uint info);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetEntry gtk_target_entry_copy(Gtk.TargetEntry data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_entry_free(Gtk.TargetEntry data);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SelectionData gtk_selection_data_copy(Gtk.SelectionData data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_selection_data_free(Gtk.SelectionData data);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_selection_data_get_data(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_selection_data_get_data_with_length(Gtk.SelectionData selection_data, System.IntPtr length);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Display gtk_selection_data_get_display(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_get_format(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_get_length(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_selection_data_get_pixbuf(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_get_targets(Gtk.SelectionData selection_data, System.IntPtr targets, System.IntPtr n_atoms);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_selection_data_get_text(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_selection_data_get_uris(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_set_pixbuf(Gtk.SelectionData selection_data, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_set_text(Gtk.SelectionData selection_data, string str, int len);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_set_uris(Gtk.SelectionData selection_data, System.IntPtr uris);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_targets_include_image(Gtk.SelectionData selection_data, int writable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_targets_include_rich_text(Gtk.SelectionData selection_data, Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_targets_include_text(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_selection_data_targets_include_uri(Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_chooser_add_palette(Gtk.ColorChooser chooser, Gtk.Orientation orientation, int colors_per_line, int n_colors, System.IntPtr colors);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_color_chooser_get_use_alpha(Gtk.ColorChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_chooser_set_rgba(Gtk.ColorChooser chooser, Gdk.RGBA color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_chooser_set_use_alpha(Gtk.ColorChooser chooser, int use_alpha);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_button_new_with_color(Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_button_new_with_rgba(Gdk.RGBA rgba);
		[DllImport("libgtk-3.so.0")]
		public static extern ushort gtk_color_button_get_alpha(Gtk.ColorButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_color_button_get_title(Gtk.ColorButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_color_button_get_use_alpha(Gtk.ColorButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_button_set_alpha(Gtk.ColorButton button, ushort alpha);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_button_set_color(Gtk.ColorButton button, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_button_set_rgba(Gtk.ColorButton button, Gdk.RGBA rgba);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_button_set_title(Gtk.ColorButton button, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_button_set_use_alpha(Gtk.ColorButton button, int use_alpha);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_chooser_dialog_new(string title, Gtk.Window parent);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_chooser_widget_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_selection_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_color_selection_palette_from_string(string str, System.IntPtr colors, System.IntPtr n_colors);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_color_selection_palette_to_string(System.IntPtr colors, int n_colors);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_color_selection_set_change_palette_with_screen_hook(System.IntPtr func);
		[DllImport("libgtk-3.so.0")]
		public static extern ushort gtk_color_selection_get_current_alpha(Gtk.ColorSelection colorsel);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_color_selection_get_has_opacity_control(Gtk.ColorSelection colorsel);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_color_selection_get_has_palette(Gtk.ColorSelection colorsel);
		[DllImport("libgtk-3.so.0")]
		public static extern ushort gtk_color_selection_get_previous_alpha(Gtk.ColorSelection colorsel);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_color_selection_is_adjusting(Gtk.ColorSelection colorsel);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_current_alpha(Gtk.ColorSelection colorsel, ushort alpha);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_current_color(Gtk.ColorSelection colorsel, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_current_rgba(Gtk.ColorSelection colorsel, Gdk.RGBA rgba);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_has_opacity_control(Gtk.ColorSelection colorsel, int has_opacity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_has_palette(Gtk.ColorSelection colorsel, int has_palette);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_previous_alpha(Gtk.ColorSelection colorsel, ushort alpha);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_previous_color(Gtk.ColorSelection colorsel, Gdk.Color color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_color_selection_set_previous_rgba(Gtk.ColorSelection colorsel, Gdk.RGBA rgba);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_selection_dialog_new(string title);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_color_selection_dialog_get_color_selection(Gtk.ColorSelectionDialog colorsel);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_text_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_combo_box_text_new_with_entry();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_append(Gtk.ComboBoxText combo_box, string id, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_append_text(Gtk.ComboBoxText combo_box, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_combo_box_text_get_active_text(Gtk.ComboBoxText combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_insert(Gtk.ComboBoxText combo_box, int position, string id, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_insert_text(Gtk.ComboBoxText combo_box, int position, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_prepend(Gtk.ComboBoxText combo_box, string id, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_prepend_text(Gtk.ComboBoxText combo_box, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_remove(Gtk.ComboBoxText combo_box, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_combo_box_text_remove_all(Gtk.ComboBoxText combo_box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_widget_path_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_append_for_widget(Gtk.WidgetPath path, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_append_type(Gtk.WidgetPath path, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_append_with_siblings(Gtk.WidgetPath path, Gtk.WidgetPath siblings, uint sibling_index);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_widget_path_copy(Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_free(Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_widget_path_get_object_type(Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_has_parent(Gtk.WidgetPath path, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_is_type(Gtk.WidgetPath path, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_add_class(Gtk.WidgetPath path, int pos, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_add_region(Gtk.WidgetPath path, int pos, string name, Gtk.RegionFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_clear_classes(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_clear_regions(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_path_iter_get_name(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_path_iter_get_object_name(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_widget_path_iter_get_object_type(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_widget_path_iter_get_sibling_index(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_widget_path_iter_get_siblings(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StateFlags gtk_widget_path_iter_get_state(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_iter_has_class(Gtk.WidgetPath path, int pos, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_iter_has_name(Gtk.WidgetPath path, int pos, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_iter_has_qclass(Gtk.WidgetPath path, int pos, uint qname);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_iter_has_qname(Gtk.WidgetPath path, int pos, uint qname);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_iter_has_qregion(Gtk.WidgetPath path, int pos, uint qname, out Gtk.RegionFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_iter_has_region(Gtk.WidgetPath path, int pos, string name, out Gtk.RegionFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_widget_path_iter_list_classes(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_widget_path_iter_list_regions(Gtk.WidgetPath path, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_remove_class(Gtk.WidgetPath path, int pos, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_remove_region(Gtk.WidgetPath path, int pos, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_set_name(Gtk.WidgetPath path, int pos, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_set_object_name(Gtk.WidgetPath path, int pos, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_set_object_type(Gtk.WidgetPath path, int pos, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_iter_set_state(Gtk.WidgetPath path, int pos, Gtk.StateFlags state);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_widget_path_length(Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_prepend_type(Gtk.WidgetPath path, ulong type);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_widget_path_ref(Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_widget_path_to_string(Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_widget_path_unref(Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ContainerCellAccessible gtk_container_cell_accessible_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_cell_accessible_add_child(Gtk.ContainerCellAccessible container, Gtk.CellAccessible child);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_container_cell_accessible_get_children(Gtk.ContainerCellAccessible container);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_container_cell_accessible_remove_child(Gtk.ContainerCellAccessible container, Gtk.CellAccessible child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconFactory gtk_style_provider_get_icon_factory(Gtk.StyleProvider provider, Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StyleProperties gtk_style_provider_get_style(Gtk.StyleProvider provider, Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CssProvider gtk_css_provider_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CssProvider gtk_css_provider_get_default();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CssProvider gtk_css_provider_get_named(string name, string variant);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_css_provider_load_from_data(Gtk.CssProvider css_provider, System.IntPtr data, long length, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_css_provider_load_from_file(Gtk.CssProvider css_provider, Gio.File file, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_css_provider_load_from_path(Gtk.CssProvider css_provider, string path, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_css_provider_load_from_resource(Gtk.CssProvider css_provider, string resource_path);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_css_provider_to_string(Gtk.CssProvider provider);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_css_section_get_end_line(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_css_section_get_end_position(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.File gtk_css_section_get_file(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CssSection gtk_css_section_get_parent(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CssSectionType gtk_css_section_get_section_type(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_css_section_get_start_line(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_css_section_get_start_position(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CssSection gtk_css_section_ref(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_css_section_unref(Gtk.CssSection section);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_css_provider_error_quark();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_drawing_area_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_copy_clipboard(Gtk.Editable editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_cut_clipboard(Gtk.Editable editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_delete_selection(Gtk.Editable editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_delete_text(Gtk.Editable editable, int start_pos, int end_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_editable_get_chars(Gtk.Editable editable, int start_pos, int end_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_editable_get_editable(Gtk.Editable editable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_editable_get_position(Gtk.Editable editable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_editable_get_selection_bounds(Gtk.Editable editable, System.IntPtr start_pos, System.IntPtr end_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_insert_text(Gtk.Editable editable, string new_text, int new_text_length, System.IntPtr position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_paste_clipboard(Gtk.Editable editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_select_region(Gtk.Editable editable, int start_pos, int end_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_set_editable(Gtk.Editable editable, int is_editable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_editable_set_position(Gtk.Editable editable, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.EntryBuffer gtk_entry_buffer_new(string initial_chars, int n_initial_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_entry_buffer_delete_text(Gtk.EntryBuffer buffer, uint position, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_buffer_emit_deleted_text(Gtk.EntryBuffer buffer, uint position, uint n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_buffer_emit_inserted_text(Gtk.EntryBuffer buffer, uint position, string chars, uint n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_entry_buffer_get_bytes(Gtk.EntryBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_entry_buffer_get_length(Gtk.EntryBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_buffer_get_max_length(Gtk.EntryBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_buffer_get_text(Gtk.EntryBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_entry_buffer_insert_text(Gtk.EntryBuffer buffer, uint position, string chars, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_buffer_set_max_length(Gtk.EntryBuffer buffer, int max_length);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_buffer_set_text(Gtk.EntryBuffer buffer, string chars, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_entry_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_entry_new_with_buffer(Gtk.EntryBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_activates_default(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern float gtk_entry_get_alignment(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.AttrList gtk_entry_get_attributes(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.EntryBuffer gtk_entry_get_buffer(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.EntryCompletion gtk_entry_get_completion(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_current_icon_drag_source(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_entry_get_cursor_hadjustment(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_has_frame(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_icon_activatable(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_icon_at_pos(Gtk.Entry entry, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Icon gtk_entry_get_icon_gicon(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_get_icon_name(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_entry_get_icon_pixbuf(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_icon_sensitive(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_get_icon_stock(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ImageType gtk_entry_get_icon_storage_type(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_get_icon_tooltip_markup(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_get_icon_tooltip_text(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Border gtk_entry_get_inner_border(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.InputHints gtk_entry_get_input_hints(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.InputPurpose gtk_entry_get_input_purpose(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_entry_get_invisible_char(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Layout gtk_entry_get_layout(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_get_layout_offsets(Gtk.Entry entry, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_max_length(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_max_width_chars(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_overwrite_mode(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_get_placeholder_text(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_entry_get_progress_fraction(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_entry_get_progress_pulse_step(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.TabArray gtk_entry_get_tabs(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_get_text(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern ushort gtk_entry_get_text_length(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_visibility(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_get_width_chars(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_grab_focus_without_selecting(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_im_context_filter_keypress(Gtk.Entry entry, Gdk.EventKey @event);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_layout_index_to_text_index(Gtk.Entry entry, int layout_index);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_progress_pulse(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_reset_im_context(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_activates_default(Gtk.Entry entry, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_alignment(Gtk.Entry entry, float xalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_attributes(Gtk.Entry entry, Pango.AttrList attrs);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_buffer(Gtk.Entry entry, Gtk.EntryBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_completion(Gtk.Entry entry, Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_cursor_hadjustment(Gtk.Entry entry, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_has_frame(Gtk.Entry entry, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_activatable(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, int activatable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_drag_source(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, Gtk.TargetList target_list, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_from_gicon(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, Gio.Icon icon);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_from_icon_name(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_from_pixbuf(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_from_stock(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_sensitive(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, int sensitive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_tooltip_markup(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, string tooltip);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_icon_tooltip_text(Gtk.Entry entry, Gtk.EntryIconPosition icon_pos, string tooltip);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_inner_border(Gtk.Entry entry, Gtk.Border border);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_input_hints(Gtk.Entry entry, Gtk.InputHints hints);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_input_purpose(Gtk.Entry entry, Gtk.InputPurpose purpose);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_invisible_char(Gtk.Entry entry, uint ch);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_max_length(Gtk.Entry entry, int max);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_max_width_chars(Gtk.Entry entry, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_overwrite_mode(Gtk.Entry entry, int overwrite);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_placeholder_text(Gtk.Entry entry, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_progress_fraction(Gtk.Entry entry, double fraction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_progress_pulse_step(Gtk.Entry entry, double fraction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_tabs(Gtk.Entry entry, Pango.TabArray tabs);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_text(Gtk.Entry entry, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_visibility(Gtk.Entry entry, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_set_width_chars(Gtk.Entry entry, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_text_index_to_layout_index(Gtk.Entry entry, int text_index);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_unset_invisible_char(Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.EntryCompletion gtk_entry_completion_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.EntryCompletion gtk_entry_completion_new_with_area(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_complete(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_completion_compute_prefix(Gtk.EntryCompletion completion, string key);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_delete_action(Gtk.EntryCompletion completion, int index_);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_entry_completion_get_completion_prefix(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_entry_completion_get_entry(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_completion_get_inline_completion(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_completion_get_inline_selection(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_completion_get_minimum_key_length(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_entry_completion_get_model(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_completion_get_popup_completion(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_completion_get_popup_set_width(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_completion_get_popup_single_match(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_entry_completion_get_text_column(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_insert_action_markup(Gtk.EntryCompletion completion, int index_, string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_insert_action_text(Gtk.EntryCompletion completion, int index_, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_insert_prefix(Gtk.EntryCompletion completion);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_inline_completion(Gtk.EntryCompletion completion, int inline_completion);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_inline_selection(Gtk.EntryCompletion completion, int inline_selection);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_match_func(Gtk.EntryCompletion completion, System.IntPtr func, System.IntPtr func_data, System.IntPtr func_notify);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_minimum_key_length(Gtk.EntryCompletion completion, int length);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_model(Gtk.EntryCompletion completion, Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_popup_completion(Gtk.EntryCompletion completion, int popup_completion);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_popup_set_width(Gtk.EntryCompletion completion, int popup_set_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_popup_single_match(Gtk.EntryCompletion completion, int popup_single_match);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_entry_completion_set_text_column(Gtk.EntryCompletion completion, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetList gtk_target_list_new(System.IntPtr targets, uint ntargets);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_list_add_image_targets(Gtk.TargetList list, uint info, int writable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_list_add_rich_text_targets(Gtk.TargetList list, uint info, int deserializable, Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_list_add_table(Gtk.TargetList list, System.IntPtr targets, uint ntargets);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_list_add_text_targets(Gtk.TargetList list, uint info);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_list_add_uri_targets(Gtk.TargetList list, uint info);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetList gtk_target_list_ref(Gtk.TargetList list);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_target_list_unref(Gtk.TargetList list);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_event_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_event_box_get_above_child(Gtk.EventBox event_box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_event_box_get_visible_window(Gtk.EventBox event_box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_event_box_set_above_child(Gtk.EventBox event_box, int above_child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_event_box_set_visible_window(Gtk.EventBox event_box, int visible_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PropagationPhase gtk_event_controller_get_propagation_phase(Gtk.EventController controller);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_event_controller_get_widget(Gtk.EventController controller);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_event_controller_handle_event(Gtk.EventController controller, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_event_controller_reset(Gtk.EventController controller);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_event_controller_set_propagation_phase(Gtk.EventController controller, Gtk.PropagationPhase phase);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_expander_new(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_expander_new_with_mnemonic(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_expander_get_expanded(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_expander_get_label(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_expander_get_label_fill(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_expander_get_label_widget(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_expander_get_resize_toplevel(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_expander_get_spacing(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_expander_get_use_markup(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_expander_get_use_underline(Gtk.Expander expander);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_expanded(Gtk.Expander expander, int expanded);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_label(Gtk.Expander expander, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_label_fill(Gtk.Expander expander, int label_fill);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_label_widget(Gtk.Expander expander, Gtk.Widget label_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_resize_toplevel(Gtk.Expander expander, int resize_toplevel);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_spacing(Gtk.Expander expander, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_use_markup(Gtk.Expander expander, int use_markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_expander_set_use_underline(Gtk.Expander expander, int use_underline);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_add_choice(Gtk.FileChooser chooser, string id, string label, string options, string option_labels);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_add_filter(Gtk.FileChooser chooser, Gtk.FileFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_add_shortcut_folder(Gtk.FileChooser chooser, System.IntPtr folder, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_add_shortcut_folder_uri(Gtk.FileChooser chooser, string uri, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FileChooserAction gtk_file_chooser_get_action(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_get_choice(Gtk.FileChooser chooser, string id);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_get_create_folders(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_get_current_folder(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.File gtk_file_chooser_get_current_folder_file(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_get_current_folder_uri(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_get_current_name(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_get_do_overwrite_confirmation(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_file_chooser_get_extra_widget(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.File gtk_file_chooser_get_file(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_get_filename(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_get_filenames(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_get_files(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FileFilter gtk_file_chooser_get_filter(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_get_local_only(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.File gtk_file_chooser_get_preview_file(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_get_preview_filename(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_get_preview_uri(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_file_chooser_get_preview_widget(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_get_preview_widget_active(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_get_select_multiple(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_get_show_hidden(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_get_uri(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_get_uris(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_get_use_preview_label(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_list_filters(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_list_shortcut_folder_uris(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_file_chooser_list_shortcut_folders(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_remove_choice(Gtk.FileChooser chooser, string id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_remove_filter(Gtk.FileChooser chooser, Gtk.FileFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_remove_shortcut_folder(Gtk.FileChooser chooser, System.IntPtr folder, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_remove_shortcut_folder_uri(Gtk.FileChooser chooser, string uri, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_select_all(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_select_file(Gtk.FileChooser chooser, Gio.File file, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_select_filename(Gtk.FileChooser chooser, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_select_uri(Gtk.FileChooser chooser, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_action(Gtk.FileChooser chooser, Gtk.FileChooserAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_choice(Gtk.FileChooser chooser, string id, string option);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_create_folders(Gtk.FileChooser chooser, int create_folders);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_set_current_folder(Gtk.FileChooser chooser, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_set_current_folder_file(Gtk.FileChooser chooser, Gio.File file, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_set_current_folder_uri(Gtk.FileChooser chooser, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_current_name(Gtk.FileChooser chooser, System.IntPtr name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_do_overwrite_confirmation(Gtk.FileChooser chooser, int do_overwrite_confirmation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_extra_widget(Gtk.FileChooser chooser, Gtk.Widget extra_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_set_file(Gtk.FileChooser chooser, Gio.File file, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_set_filename(Gtk.FileChooser chooser, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_filter(Gtk.FileChooser chooser, Gtk.FileFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_local_only(Gtk.FileChooser chooser, int local_only);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_preview_widget(Gtk.FileChooser chooser, Gtk.Widget preview_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_preview_widget_active(Gtk.FileChooser chooser, int active);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_select_multiple(Gtk.FileChooser chooser, int select_multiple);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_show_hidden(Gtk.FileChooser chooser, int show_hidden);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_set_uri(Gtk.FileChooser chooser, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_set_use_preview_label(Gtk.FileChooser chooser, int use_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_unselect_all(Gtk.FileChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_unselect_file(Gtk.FileChooser chooser, Gio.File file);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_unselect_filename(Gtk.FileChooser chooser, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_unselect_uri(Gtk.FileChooser chooser, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FileFilter gtk_file_filter_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FileFilter gtk_file_filter_new_from_gvariant(GLib.Variant variant);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_filter_add_custom(Gtk.FileFilter filter, Gtk.FileFilterFlags needed, System.IntPtr func, System.IntPtr data, System.IntPtr notify);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_filter_add_mime_type(Gtk.FileFilter filter, string mime_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_filter_add_pattern(Gtk.FileFilter filter, string pattern);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_filter_add_pixbuf_formats(Gtk.FileFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_filter_filter(Gtk.FileFilter filter, Gtk.FileFilterInfo filter_info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_filter_get_name(Gtk.FileFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FileFilterFlags gtk_file_filter_get_needed(Gtk.FileFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_filter_set_name(Gtk.FileFilter filter, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.Variant gtk_file_filter_to_gvariant(Gtk.FileFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_file_chooser_button_new(string title, Gtk.FileChooserAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_file_chooser_button_new_with_dialog(Gtk.Dialog dialog);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_button_get_focus_on_click(Gtk.FileChooserButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_button_get_title(Gtk.FileChooserButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_file_chooser_button_get_width_chars(Gtk.FileChooserButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_button_set_focus_on_click(Gtk.FileChooserButton button, int focus_on_click);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_button_set_title(Gtk.FileChooserButton button, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_button_set_width_chars(Gtk.FileChooserButton button, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_file_chooser_error_quark();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FileChooserNative gtk_file_chooser_native_new(string title, Gtk.Window parent, Gtk.FileChooserAction action, string accept_label, string cancel_label);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_native_get_accept_label(Gtk.FileChooserNative self);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_file_chooser_native_get_cancel_label(Gtk.FileChooserNative self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_native_set_accept_label(Gtk.FileChooserNative self, string accept_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_file_chooser_native_set_cancel_label(Gtk.FileChooserNative self, string cancel_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_native_dialog_destroy(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_native_dialog_get_modal(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_native_dialog_get_title(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Window gtk_native_dialog_get_transient_for(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_native_dialog_get_visible(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_native_dialog_hide(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_native_dialog_run(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_native_dialog_set_modal(Gtk.NativeDialog self, int modal);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_native_dialog_set_title(Gtk.NativeDialog self, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_native_dialog_set_transient_for(Gtk.NativeDialog self, Gtk.Window parent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_native_dialog_show(Gtk.NativeDialog self);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_file_chooser_widget_new(Gtk.FileChooserAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_fixed_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_fixed_move(Gtk.Fixed @fixed, Gtk.Widget widget, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_fixed_put(Gtk.Fixed @fixed, Gtk.Widget widget, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_flow_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_bind_model(Gtk.FlowBox box, Gio.ListModel model, System.IntPtr create_widget_func, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_flow_box_get_activate_on_single_click(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FlowBoxChild gtk_flow_box_get_child_at_index(Gtk.FlowBox box, int idx);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.FlowBoxChild gtk_flow_box_get_child_at_pos(Gtk.FlowBox box, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_flow_box_get_column_spacing(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_flow_box_get_homogeneous(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_flow_box_get_max_children_per_line(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_flow_box_get_min_children_per_line(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_flow_box_get_row_spacing(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_flow_box_get_selected_children(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SelectionMode gtk_flow_box_get_selection_mode(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_insert(Gtk.FlowBox box, Gtk.Widget widget, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_invalidate_filter(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_invalidate_sort(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_select_all(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_select_child(Gtk.FlowBox box, Gtk.FlowBoxChild child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_selected_foreach(Gtk.FlowBox box, System.IntPtr func, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_activate_on_single_click(Gtk.FlowBox box, int single);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_column_spacing(Gtk.FlowBox box, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_filter_func(Gtk.FlowBox box, System.IntPtr filter_func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_hadjustment(Gtk.FlowBox box, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_homogeneous(Gtk.FlowBox box, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_max_children_per_line(Gtk.FlowBox box, uint n_children);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_min_children_per_line(Gtk.FlowBox box, uint n_children);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_row_spacing(Gtk.FlowBox box, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_selection_mode(Gtk.FlowBox box, Gtk.SelectionMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_sort_func(Gtk.FlowBox box, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_set_vadjustment(Gtk.FlowBox box, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_unselect_all(Gtk.FlowBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_unselect_child(Gtk.FlowBox box, Gtk.FlowBoxChild child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_flow_box_child_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_flow_box_child_changed(Gtk.FlowBoxChild child);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_flow_box_child_get_index(Gtk.FlowBoxChild child);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_flow_box_child_is_selected(Gtk.FlowBoxChild child);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_chooser_get_font(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontDescription gtk_font_chooser_get_font_desc(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontFace gtk_font_chooser_get_font_face(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontFamily gtk_font_chooser_get_font_family(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontMap gtk_font_chooser_get_font_map(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_chooser_get_font_size(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_chooser_get_preview_text(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_chooser_get_show_preview_entry(Gtk.FontChooser fontchooser);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_chooser_set_filter_func(Gtk.FontChooser fontchooser, System.IntPtr filter, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_chooser_set_font(Gtk.FontChooser fontchooser, string fontname);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_chooser_set_font_desc(Gtk.FontChooser fontchooser, Pango.FontDescription font_desc);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_chooser_set_font_map(Gtk.FontChooser fontchooser, Pango.FontMap fontmap);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_chooser_set_preview_text(Gtk.FontChooser fontchooser, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_chooser_set_show_preview_entry(Gtk.FontChooser fontchooser, int show_preview_entry);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_button_new_with_font(string fontname);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_button_get_font_name(Gtk.FontButton font_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_button_get_show_size(Gtk.FontButton font_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_button_get_show_style(Gtk.FontButton font_button);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_button_get_title(Gtk.FontButton font_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_button_get_use_font(Gtk.FontButton font_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_button_get_use_size(Gtk.FontButton font_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_button_set_font_name(Gtk.FontButton font_button, string fontname);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_button_set_show_size(Gtk.FontButton font_button, int show_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_button_set_show_style(Gtk.FontButton font_button, int show_style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_button_set_title(Gtk.FontButton font_button, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_button_set_use_font(Gtk.FontButton font_button, int use_font);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_button_set_use_size(Gtk.FontButton font_button, int use_size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_chooser_dialog_new(string title, Gtk.Window parent);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_chooser_widget_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontFace gtk_font_selection_get_face(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_get_face_list(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontFamily gtk_font_selection_get_family(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_get_family_list(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_selection_get_font_name(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_get_preview_entry(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_selection_get_preview_text(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_selection_get_size(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_get_size_entry(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_get_size_list(Gtk.FontSelection fontsel);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_selection_set_font_name(Gtk.FontSelection fontsel, string fontname);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_selection_set_preview_text(Gtk.FontSelection fontsel, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_dialog_new(string title);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_dialog_get_cancel_button(Gtk.FontSelectionDialog fsd);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_selection_dialog_get_font_name(Gtk.FontSelectionDialog fsd);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_dialog_get_font_selection(Gtk.FontSelectionDialog fsd);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_font_selection_dialog_get_ok_button(Gtk.FontSelectionDialog fsd);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_font_selection_dialog_get_preview_text(Gtk.FontSelectionDialog fsd);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_font_selection_dialog_set_font_name(Gtk.FontSelectionDialog fsd, string fontname);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_font_selection_dialog_set_preview_text(Gtk.FontSelectionDialog fsd, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_gl_area_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_attach_buffers(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gl_area_get_auto_render(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.GLContext gtk_gl_area_get_context(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.Error gtk_gl_area_get_error(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gl_area_get_has_alpha(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gl_area_get_has_depth_buffer(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gl_area_get_has_stencil_buffer(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_get_required_version(Gtk.GLArea area, System.IntPtr major, System.IntPtr minor);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gl_area_get_use_es(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_make_current(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_queue_render(Gtk.GLArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_set_auto_render(Gtk.GLArea area, int auto_render);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_set_error(Gtk.GLArea area, GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_set_has_alpha(Gtk.GLArea area, int has_alpha);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_set_has_depth_buffer(Gtk.GLArea area, int has_depth_buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_set_has_stencil_buffer(Gtk.GLArea area, int has_stencil_buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_set_required_version(Gtk.GLArea area, int major, int minor);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gl_area_set_use_es(Gtk.GLArea area, int use_es);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_get_bounding_box_center(Gtk.Gesture gesture, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Device gtk_gesture_get_device(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_gesture_get_group(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_gesture_get_last_event(Gtk.Gesture gesture, Gdk.EventSequence sequence);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.EventSequence gtk_gesture_get_last_updated_sequence(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_get_point(Gtk.Gesture gesture, Gdk.EventSequence sequence, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.EventSequenceState gtk_gesture_get_sequence_state(Gtk.Gesture gesture, Gdk.EventSequence sequence);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_gesture_get_sequences(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_gesture_get_window(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_group(Gtk.Gesture group_gesture, Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_handles_sequence(Gtk.Gesture gesture, Gdk.EventSequence sequence);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_is_active(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_is_grouped_with(Gtk.Gesture gesture, Gtk.Gesture other);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_is_recognized(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_set_sequence_state(Gtk.Gesture gesture, Gdk.EventSequence sequence, Gtk.EventSequenceState state);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_set_state(Gtk.Gesture gesture, Gtk.EventSequenceState state);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_set_window(Gtk.Gesture gesture, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_ungroup(Gtk.Gesture gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gesture gtk_gesture_drag_new(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_drag_get_offset(Gtk.GestureDrag gesture, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_drag_get_start_point(Gtk.GestureDrag gesture, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_gesture_single_get_button(Gtk.GestureSingle gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_gesture_single_get_current_button(Gtk.GestureSingle gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.EventSequence gtk_gesture_single_get_current_sequence(Gtk.GestureSingle gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_single_get_exclusive(Gtk.GestureSingle gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_single_get_touch_only(Gtk.GestureSingle gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_single_set_button(Gtk.GestureSingle gesture, uint button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_single_set_exclusive(Gtk.GestureSingle gesture, int exclusive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_single_set_touch_only(Gtk.GestureSingle gesture, int touch_only);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gesture gtk_gesture_long_press_new(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gesture gtk_gesture_multi_press_new(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_multi_press_set_area(Gtk.GestureMultiPress gesture, Gdk.Rectangle rect);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gesture gtk_gesture_pan_new(Gtk.Widget widget, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Orientation gtk_gesture_pan_get_orientation(Gtk.GesturePan gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gesture_pan_set_orientation(Gtk.GesturePan gesture, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gesture gtk_gesture_rotate_new(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_gesture_rotate_get_angle_delta(Gtk.GestureRotate gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gesture gtk_gesture_swipe_new(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gesture_swipe_get_velocity(Gtk.GestureSwipe gesture, System.IntPtr velocity_x, System.IntPtr velocity_y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gesture gtk_gesture_zoom_new(Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_gesture_zoom_get_scale_delta(Gtk.GestureZoom gesture);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gradient gtk_gradient_new_linear(double x0, double y0, double x1, double y1);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gradient gtk_gradient_new_radial(double x0, double y0, double radius0, double x1, double y1, double radius1);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gradient_add_color_stop(Gtk.Gradient gradient, double offset, Gtk.SymbolicColor color);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Gradient gtk_gradient_ref(Gtk.Gradient gradient);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_gradient_resolve(Gtk.Gradient gradient, Gtk.StyleProperties props, out cairo.Pattern resolved_gradient);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Pattern gtk_gradient_resolve_for_context(Gtk.Gradient gradient, Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_gradient_to_string(Gtk.Gradient gradient);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_gradient_unref(Gtk.Gradient gradient);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_symbolic_color_new_alpha(Gtk.SymbolicColor color, double factor);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_symbolic_color_new_literal(Gdk.RGBA color);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_symbolic_color_new_mix(Gtk.SymbolicColor color1, Gtk.SymbolicColor color2, double factor);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_symbolic_color_new_name(string name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_symbolic_color_new_shade(Gtk.SymbolicColor color, double factor);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_symbolic_color_new_win32(string theme_class, int id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_symbolic_color_ref(Gtk.SymbolicColor color);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_symbolic_color_to_string(Gtk.SymbolicColor color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_symbolic_color_unref(Gtk.SymbolicColor color);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StyleProperties gtk_style_properties_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_style_properties_lookup_property(string property_name, System.IntPtr parse_func, out GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_properties_register_property(System.IntPtr parse_func, GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_properties_clear(Gtk.StyleProperties props);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SymbolicColor gtk_style_properties_lookup_color(Gtk.StyleProperties props, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_properties_map_color(Gtk.StyleProperties props, string name, Gtk.SymbolicColor color);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_properties_merge(Gtk.StyleProperties props, Gtk.StyleProperties props_to_merge, int replace);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_properties_set_property(Gtk.StyleProperties props, string property, Gtk.StateFlags state, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_properties_unset_property(Gtk.StyleProperties props, string property, Gtk.StateFlags state);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StyleContext gtk_style_context_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_add_provider_for_screen(Gdk.Screen screen, Gtk.StyleProvider provider, uint priority);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_remove_provider_for_screen(Gdk.Screen screen, Gtk.StyleProvider provider);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_reset_widgets(Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_add_class(Gtk.StyleContext context, string class_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_add_provider(Gtk.StyleContext context, Gtk.StyleProvider provider, uint priority);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_add_region(Gtk.StyleContext context, string region_name, Gtk.RegionFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_cancel_animations(Gtk.StyleContext context, System.IntPtr region_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextDirection gtk_style_context_get_direction(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontDescription gtk_style_context_get_font(Gtk.StyleContext context, Gtk.StateFlags state);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.FrameClock gtk_style_context_get_frame_clock(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.JunctionSides gtk_style_context_get_junction_sides(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StyleContext gtk_style_context_get_parent(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_style_context_get_path(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_style_context_get_scale(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Screen gtk_style_context_get_screen(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CssSection gtk_style_context_get_section(Gtk.StyleContext context, string property);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StateFlags gtk_style_context_get_state(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_get_style_property(Gtk.StyleContext context, string property_name, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_style_context_has_class(Gtk.StyleContext context, string class_name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_style_context_has_region(Gtk.StyleContext context, string region_name, out Gtk.RegionFlags flags_return);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_invalidate(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_style_context_list_classes(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_style_context_list_regions(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_style_context_lookup_icon_set(Gtk.StyleContext context, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_notify_state_change(Gtk.StyleContext context, Gdk.Window window, System.IntPtr region_id, Gtk.StateType state, int state_value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_pop_animatable_region(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_push_animatable_region(Gtk.StyleContext context, System.IntPtr region_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_remove_class(Gtk.StyleContext context, string class_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_remove_provider(Gtk.StyleContext context, Gtk.StyleProvider provider);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_remove_region(Gtk.StyleContext context, string region_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_restore(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_save(Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_scroll_animations(Gtk.StyleContext context, Gdk.Window window, int dx, int dy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_background(Gtk.StyleContext context, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_direction(Gtk.StyleContext context, Gtk.TextDirection direction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_frame_clock(Gtk.StyleContext context, Gdk.FrameClock frame_clock);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_junction_sides(Gtk.StyleContext context, Gtk.JunctionSides sides);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_parent(Gtk.StyleContext context, Gtk.StyleContext parent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_path(Gtk.StyleContext context, Gtk.WidgetPath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_scale(Gtk.StyleContext context, int scale);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_screen(Gtk.StyleContext context, Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_context_set_state(Gtk.StyleContext context, Gtk.StateFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_style_context_state_is_running(Gtk.StyleContext context, Gtk.StateType state, System.IntPtr progress);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_style_context_to_string(Gtk.StyleContext context, Gtk.StyleContextPrintFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_grid_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_attach(Gtk.Grid grid, Gtk.Widget child, int left, int top, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_attach_next_to(Gtk.Grid grid, Gtk.Widget child, Gtk.Widget sibling, Gtk.PositionType side, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_grid_get_baseline_row(Gtk.Grid grid);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_grid_get_child_at(Gtk.Grid grid, int left, int top);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_grid_get_column_homogeneous(Gtk.Grid grid);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_grid_get_column_spacing(Gtk.Grid grid);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.BaselinePosition gtk_grid_get_row_baseline_position(Gtk.Grid grid, int row);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_grid_get_row_homogeneous(Gtk.Grid grid);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_grid_get_row_spacing(Gtk.Grid grid);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_insert_column(Gtk.Grid grid, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_insert_next_to(Gtk.Grid grid, Gtk.Widget sibling, Gtk.PositionType side);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_insert_row(Gtk.Grid grid, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_remove_column(Gtk.Grid grid, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_remove_row(Gtk.Grid grid, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_set_baseline_row(Gtk.Grid grid, int row);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_set_column_homogeneous(Gtk.Grid grid, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_set_column_spacing(Gtk.Grid grid, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_set_row_baseline_position(Gtk.Grid grid, int row, Gtk.BaselinePosition pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_set_row_homogeneous(Gtk.Grid grid, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_grid_set_row_spacing(Gtk.Grid grid, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hbox_new(int homogeneous, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hbutton_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_paned_new(Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paned_add1(Gtk.Paned paned, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paned_add2(Gtk.Paned paned, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_paned_get_child1(Gtk.Paned paned);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_paned_get_child2(Gtk.Paned paned);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_paned_get_handle_window(Gtk.Paned paned);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_paned_get_position(Gtk.Paned paned);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_paned_get_wide_handle(Gtk.Paned paned);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paned_pack1(Gtk.Paned paned, Gtk.Widget child, int resize, int shrink);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paned_pack2(Gtk.Paned paned, Gtk.Widget child, int resize, int shrink);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paned_set_position(Gtk.Paned paned, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paned_set_wide_handle(Gtk.Paned paned, int wide);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hpaned_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hsv_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_hsv_to_rgb(double h, double s, double v, System.IntPtr r, System.IntPtr g, System.IntPtr b);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_hsv_get_color(Gtk.HSV hsv, System.IntPtr h, System.IntPtr s, System.IntPtr v);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_hsv_get_metrics(Gtk.HSV hsv, System.IntPtr size, System.IntPtr ring_width);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_hsv_is_adjusting(Gtk.HSV hsv);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_hsv_set_color(Gtk.HSV hsv, double h, double s, double v);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_hsv_set_metrics(Gtk.HSV hsv, int size, int ring_width);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scale_new(Gtk.Orientation orientation, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scale_new_with_range(Gtk.Orientation orientation, double min, double max, double step);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_add_mark(Gtk.Scale scale, double value, Gtk.PositionType position, string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_clear_marks(Gtk.Scale scale);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scale_get_digits(Gtk.Scale scale);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scale_get_draw_value(Gtk.Scale scale);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scale_get_has_origin(Gtk.Scale scale);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Layout gtk_scale_get_layout(Gtk.Scale scale);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_get_layout_offsets(Gtk.Scale scale, System.IntPtr x, System.IntPtr y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PositionType gtk_scale_get_value_pos(Gtk.Scale scale);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_set_digits(Gtk.Scale scale, int digits);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_set_draw_value(Gtk.Scale scale, int draw_value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_set_has_origin(Gtk.Scale scale, int has_origin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_set_value_pos(Gtk.Scale scale, Gtk.PositionType pos);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hscale_new(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hscale_new_with_range(double min, double max, double step);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scrollbar_new(Gtk.Orientation orientation, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hscrollbar_new(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_separator_new(Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_hseparator_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_handle_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_handle_box_get_child_detached(Gtk.HandleBox handle_box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PositionType gtk_handle_box_get_handle_position(Gtk.HandleBox handle_box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ShadowType gtk_handle_box_get_shadow_type(Gtk.HandleBox handle_box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PositionType gtk_handle_box_get_snap_edge(Gtk.HandleBox handle_box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_handle_box_set_handle_position(Gtk.HandleBox handle_box, Gtk.PositionType position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_handle_box_set_shadow_type(Gtk.HandleBox handle_box, Gtk.ShadowType type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_handle_box_set_snap_edge(Gtk.HandleBox handle_box, Gtk.PositionType edge);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_header_bar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_header_bar_get_custom_title(Gtk.HeaderBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_header_bar_get_decoration_layout(Gtk.HeaderBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_header_bar_get_has_subtitle(Gtk.HeaderBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_header_bar_get_show_close_button(Gtk.HeaderBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_header_bar_get_subtitle(Gtk.HeaderBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_header_bar_get_title(Gtk.HeaderBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_pack_end(Gtk.HeaderBar bar, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_pack_start(Gtk.HeaderBar bar, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_set_custom_title(Gtk.HeaderBar bar, Gtk.Widget title_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_set_decoration_layout(Gtk.HeaderBar bar, string layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_set_has_subtitle(Gtk.HeaderBar bar, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_set_show_close_button(Gtk.HeaderBar bar, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_set_subtitle(Gtk.HeaderBar bar, string subtitle);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_header_bar_set_title(Gtk.HeaderBar bar, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_im_context_delete_surrounding(Gtk.IMContext context, int offset, int n_chars);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_im_context_filter_keypress(Gtk.IMContext context, Gdk.EventKey @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_focus_in(Gtk.IMContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_focus_out(Gtk.IMContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_get_preedit_string(Gtk.IMContext context, string str, out Pango.AttrList attrs, System.IntPtr cursor_pos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_im_context_get_surrounding(Gtk.IMContext context, string text, System.IntPtr cursor_index);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_reset(Gtk.IMContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_set_client_window(Gtk.IMContext context, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_set_cursor_location(Gtk.IMContext context, Gdk.Rectangle area);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_set_surrounding(Gtk.IMContext context, string text, int len, int cursor_index);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_set_use_preedit(Gtk.IMContext context, int use_preedit);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IMContext gtk_im_context_simple_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_simple_add_compose_file(Gtk.IMContextSimple context_simple, string compose_file);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_context_simple_add_table(Gtk.IMContextSimple context_simple, System.IntPtr data, int max_seq_len, int n_seqs);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IMContext gtk_im_multicontext_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_multicontext_append_menuitems(Gtk.IMMulticontext context, Gtk.MenuShell menushell);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_im_multicontext_get_context_id(Gtk.IMMulticontext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_im_multicontext_set_context_id(Gtk.IMMulticontext context, string context_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_activate_item(Gtk.MenuShell menu_shell, Gtk.Widget menu_item, int force_deactivate);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_append(Gtk.MenuShell menu_shell, Gtk.MenuItem child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_bind_model(Gtk.MenuShell menu_shell, Gio.MenuModel model, string action_namespace, int with_separators);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_cancel(Gtk.MenuShell menu_shell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_deactivate(Gtk.MenuShell menu_shell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_deselect(Gtk.MenuShell menu_shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_shell_get_parent_shell(Gtk.MenuShell menu_shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_shell_get_selected_item(Gtk.MenuShell menu_shell);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_shell_get_take_focus(Gtk.MenuShell menu_shell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_insert(Gtk.MenuShell menu_shell, Gtk.Widget child, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_prepend(Gtk.MenuShell menu_shell, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_select_first(Gtk.MenuShell menu_shell, int search_sensitive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_select_item(Gtk.MenuShell menu_shell, Gtk.Widget menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_shell_set_take_focus(Gtk.MenuShell menu_shell, int take_focus);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconFactory gtk_icon_factory_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_icon_factory_lookup_default(string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_factory_add(Gtk.IconFactory factory, string stock_id, Gtk.IconSet icon_set);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_factory_add_default(Gtk.IconFactory factory);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_icon_factory_lookup(Gtk.IconFactory factory, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_factory_remove_default(Gtk.IconFactory factory);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_icon_set_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_icon_set_new_from_pixbuf(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_set_add_source(Gtk.IconSet icon_set, Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_icon_set_copy(Gtk.IconSet icon_set);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_set_get_sizes(Gtk.IconSet icon_set, System.IntPtr sizes, System.IntPtr n_sizes);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_icon_set_ref(Gtk.IconSet icon_set);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_set_render_icon(Gtk.IconSet icon_set, Gtk.Style style, Gtk.TextDirection direction, Gtk.StateType state, int size, Gtk.Widget widget, string detail);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_set_render_icon_pixbuf(Gtk.IconSet icon_set, Gtk.StyleContext context, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Surface gtk_icon_set_render_icon_surface(Gtk.IconSet icon_set, Gtk.StyleContext context, int size, int scale, Gdk.Window for_window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_set_unref(Gtk.IconSet icon_set);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_info_new_for_pixbuf(Gtk.IconTheme icon_theme, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_info_copy(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_info_free(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_info_get_attach_points(Gtk.IconInfo icon_info, System.IntPtr points, System.IntPtr n_points);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_info_get_base_scale(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_info_get_base_size(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_get_builtin_pixbuf(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_icon_info_get_display_name(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_icon_info_get_filename(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_info_is_symbolic(Gtk.IconInfo icon_info);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_load_icon(Gtk.IconInfo icon_info, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_info_load_icon_async(Gtk.IconInfo icon_info, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_load_icon_finish(Gtk.IconInfo icon_info, Gio.AsyncResult res, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Surface gtk_icon_info_load_surface(Gtk.IconInfo icon_info, Gdk.Window for_window, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_load_symbolic(Gtk.IconInfo icon_info, Gdk.RGBA fg, Gdk.RGBA success_color, Gdk.RGBA warning_color, Gdk.RGBA error_color, System.IntPtr was_symbolic, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_info_load_symbolic_async(Gtk.IconInfo icon_info, Gdk.RGBA fg, Gdk.RGBA success_color, Gdk.RGBA warning_color, Gdk.RGBA error_color, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_load_symbolic_finish(Gtk.IconInfo icon_info, Gio.AsyncResult res, System.IntPtr was_symbolic, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_load_symbolic_for_context(Gtk.IconInfo icon_info, Gtk.StyleContext context, System.IntPtr was_symbolic, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_info_load_symbolic_for_context_async(Gtk.IconInfo icon_info, Gtk.StyleContext context, Gio.Cancellable cancellable, System.IntPtr callback, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_load_symbolic_for_context_finish(Gtk.IconInfo icon_info, Gio.AsyncResult res, System.IntPtr was_symbolic, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_info_load_symbolic_for_style(Gtk.IconInfo icon_info, Gtk.Style style, Gtk.StateType state, System.IntPtr was_symbolic, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_info_set_raw_coordinates(Gtk.IconInfo icon_info, int raw_coordinates);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconTheme gtk_icon_theme_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_add_builtin_icon(string icon_name, int size, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconTheme gtk_icon_theme_get_default();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconTheme gtk_icon_theme_get_for_screen(Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_add_resource_path(Gtk.IconTheme icon_theme, string path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_append_search_path(Gtk.IconTheme icon_theme, System.IntPtr path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_theme_choose_icon(Gtk.IconTheme icon_theme, System.IntPtr icon_names, int size, Gtk.IconLookupFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_theme_choose_icon_for_scale(Gtk.IconTheme icon_theme, System.IntPtr icon_names, int size, int scale, Gtk.IconLookupFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_icon_theme_get_example_icon_name(Gtk.IconTheme icon_theme);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_icon_theme_get_icon_sizes(Gtk.IconTheme icon_theme, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_get_search_path(Gtk.IconTheme icon_theme, System.IntPtr path, System.IntPtr n_elements);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_theme_has_icon(Gtk.IconTheme icon_theme, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_icon_theme_list_contexts(Gtk.IconTheme icon_theme);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_icon_theme_list_icons(Gtk.IconTheme icon_theme, string context);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_theme_load_icon(Gtk.IconTheme icon_theme, string icon_name, int size, Gtk.IconLookupFlags flags, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_theme_load_icon_for_scale(Gtk.IconTheme icon_theme, string icon_name, int size, int scale, Gtk.IconLookupFlags flags, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Surface gtk_icon_theme_load_surface(Gtk.IconTheme icon_theme, string icon_name, int size, int scale, Gdk.Window for_window, Gtk.IconLookupFlags flags, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_theme_lookup_by_gicon(Gtk.IconTheme icon_theme, Gio.Icon icon, int size, Gtk.IconLookupFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_theme_lookup_by_gicon_for_scale(Gtk.IconTheme icon_theme, Gio.Icon icon, int size, int scale, Gtk.IconLookupFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_theme_lookup_icon(Gtk.IconTheme icon_theme, string icon_name, int size, Gtk.IconLookupFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconInfo gtk_icon_theme_lookup_icon_for_scale(Gtk.IconTheme icon_theme, string icon_name, int size, int scale, Gtk.IconLookupFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_prepend_search_path(Gtk.IconTheme icon_theme, System.IntPtr path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_theme_rescan_if_needed(Gtk.IconTheme icon_theme);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_set_custom_theme(Gtk.IconTheme icon_theme, string theme_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_set_screen(Gtk.IconTheme icon_theme, Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_theme_set_search_path(Gtk.IconTheme icon_theme, System.IntPtr path, int n_elements);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Style gtk_style_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_apply_default_background(Gtk.Style style, cairo.Context cr, Gdk.Window window, Gtk.StateType state_type, int x, int y, int width, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Style gtk_style_attach(Gtk.Style style, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Style gtk_style_copy(Gtk.Style style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_detach(Gtk.Style style);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_style_has_context(Gtk.Style style);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSet gtk_style_lookup_icon_set(Gtk.Style style, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_style_render_icon(Gtk.Style style, Gtk.IconSource source, Gtk.TextDirection direction, Gtk.StateType state, int size, Gtk.Widget widget, string detail);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_style_set_background(Gtk.Style style, Gdk.Window window, Gtk.StateType state_type);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSource gtk_icon_source_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSource gtk_icon_source_copy(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_free(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextDirection gtk_icon_source_get_direction(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_source_get_direction_wildcarded(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_icon_source_get_filename(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_icon_source_get_icon_name(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_icon_source_get_pixbuf(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_source_get_size(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_source_get_size_wildcarded(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StateType gtk_icon_source_get_state(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_source_get_state_wildcarded(Gtk.IconSource source);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_direction(Gtk.IconSource source, Gtk.TextDirection direction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_direction_wildcarded(Gtk.IconSource source, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_filename(Gtk.IconSource source, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_icon_name(Gtk.IconSource source, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_pixbuf(Gtk.IconSource source, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_size(Gtk.IconSource source, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_size_wildcarded(Gtk.IconSource source, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_state(Gtk.IconSource source, Gtk.StateType state);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_source_set_state_wildcarded(Gtk.IconSource source, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Settings gtk_settings_get_default();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Settings gtk_settings_get_for_screen(Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_settings_install_property(GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_settings_install_property_parser(GObject.ParamSpec pspec, System.IntPtr parser);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_settings_reset_property(Gtk.Settings settings, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_settings_set_double_property(Gtk.Settings settings, string name, double v_double, string origin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_settings_set_long_property(Gtk.Settings settings, string name, long v_long, string origin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_settings_set_property_value(Gtk.Settings settings, string name, Gtk.SettingsValue svalue);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_settings_set_string_property(Gtk.Settings settings, string name, string v_string, string origin);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_icon_theme_error_quark();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_scrollable_get_hadjustment(Gtk.Scrollable scrollable);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ScrollablePolicy gtk_scrollable_get_hscroll_policy(Gtk.Scrollable scrollable);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_scrollable_get_vadjustment(Gtk.Scrollable scrollable);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ScrollablePolicy gtk_scrollable_get_vscroll_policy(Gtk.Scrollable scrollable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrollable_set_hadjustment(Gtk.Scrollable scrollable, Gtk.Adjustment hadjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrollable_set_hscroll_policy(Gtk.Scrollable scrollable, Gtk.ScrollablePolicy policy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrollable_set_vadjustment(Gtk.Scrollable scrollable, Gtk.Adjustment vadjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrollable_set_vscroll_policy(Gtk.Scrollable scrollable, Gtk.ScrollablePolicy policy);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_icon_view_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_icon_view_new_with_area(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_icon_view_new_with_model(Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_convert_widget_to_bin_window_coords(Gtk.IconView icon_view, int wx, int wy, System.IntPtr bx, System.IntPtr by);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Surface gtk_icon_view_create_drag_icon(Gtk.IconView icon_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_enable_model_drag_dest(Gtk.IconView icon_view, System.IntPtr targets, int n_targets, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_enable_model_drag_source(Gtk.IconView icon_view, Gdk.ModifierType start_button_mask, System.IntPtr targets, int n_targets, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_activate_on_single_click(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_column_spacing(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_columns(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_cursor(Gtk.IconView icon_view, out Gtk.TreePath path, out Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_dest_item_at_pos(Gtk.IconView icon_view, int drag_x, int drag_y, out Gtk.TreePath path, out Gtk.IconViewDropPosition pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_get_drag_dest_item(Gtk.IconView icon_view, out Gtk.TreePath path, out Gtk.IconViewDropPosition pos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_item_at_pos(Gtk.IconView icon_view, int x, int y, out Gtk.TreePath path, out Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_item_column(Gtk.IconView icon_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Orientation gtk_icon_view_get_item_orientation(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_item_padding(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_item_row(Gtk.IconView icon_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_item_width(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_margin(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_markup_column(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_icon_view_get_model(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_icon_view_get_path_at_pos(Gtk.IconView icon_view, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_pixbuf_column(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_reorderable(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_row_spacing(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_icon_view_get_selected_items(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SelectionMode gtk_icon_view_get_selection_mode(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_spacing(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_text_column(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_tooltip_column(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_get_visible_range(Gtk.IconView icon_view, out Gtk.TreePath start_path, out Gtk.TreePath end_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_item_activated(Gtk.IconView icon_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_icon_view_path_is_selected(Gtk.IconView icon_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_scroll_to_path(Gtk.IconView icon_view, Gtk.TreePath path, int use_align, float row_align, float col_align);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_select_all(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_select_path(Gtk.IconView icon_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_selected_foreach(Gtk.IconView icon_view, System.IntPtr func, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_activate_on_single_click(Gtk.IconView icon_view, int single);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_column_spacing(Gtk.IconView icon_view, int column_spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_columns(Gtk.IconView icon_view, int columns);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_cursor(Gtk.IconView icon_view, Gtk.TreePath path, Gtk.CellRenderer cell, int start_editing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_drag_dest_item(Gtk.IconView icon_view, Gtk.TreePath path, Gtk.IconViewDropPosition pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_item_orientation(Gtk.IconView icon_view, Gtk.Orientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_item_padding(Gtk.IconView icon_view, int item_padding);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_item_width(Gtk.IconView icon_view, int item_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_margin(Gtk.IconView icon_view, int margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_markup_column(Gtk.IconView icon_view, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_model(Gtk.IconView icon_view, Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_pixbuf_column(Gtk.IconView icon_view, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_reorderable(Gtk.IconView icon_view, int reorderable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_row_spacing(Gtk.IconView icon_view, int row_spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_selection_mode(Gtk.IconView icon_view, Gtk.SelectionMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_spacing(Gtk.IconView icon_view, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_text_column(Gtk.IconView icon_view, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_tooltip_cell(Gtk.IconView icon_view, Gtk.Tooltip tooltip, Gtk.TreePath path, Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_tooltip_column(Gtk.IconView icon_view, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_set_tooltip_item(Gtk.IconView icon_view, Gtk.Tooltip tooltip, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_unselect_all(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_unselect_path(Gtk.IconView icon_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_unset_model_drag_dest(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_icon_view_unset_model_drag_source(Gtk.IconView icon_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_trigger_tooltip_query(Gdk.Display display);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_custom(Gtk.Tooltip tooltip, Gtk.Widget custom_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_icon(Gtk.Tooltip tooltip, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_icon_from_gicon(Gtk.Tooltip tooltip, Gio.Icon gicon, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_icon_from_icon_name(Gtk.Tooltip tooltip, string icon_name, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_icon_from_stock(Gtk.Tooltip tooltip, string stock_id, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_markup(Gtk.Tooltip tooltip, string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_text(Gtk.Tooltip tooltip, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tooltip_set_tip_area(Gtk.Tooltip tooltip, Gdk.Rectangle rect);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_animation(GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_file(System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_gicon(Gio.Icon icon, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_icon_name(string icon_name, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_icon_set(Gtk.IconSet icon_set, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_pixbuf(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_resource(string resource_path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_stock(string stock_id, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_new_from_surface(cairo.Surface surface);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_clear(Gtk.Image image);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.PixbufAnimation gtk_image_get_animation(Gtk.Image image);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_get_gicon(Gtk.Image image, out Gio.Icon gicon, System.IntPtr size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_get_icon_name(Gtk.Image image, string icon_name, System.IntPtr size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_get_icon_set(Gtk.Image image, out Gtk.IconSet icon_set, System.IntPtr size);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_image_get_pixbuf(Gtk.Image image);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_image_get_pixel_size(Gtk.Image image);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_get_stock(Gtk.Image image, string stock_id, System.IntPtr size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ImageType gtk_image_get_storage_type(Gtk.Image image);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_animation(Gtk.Image image, GdkPixbuf.PixbufAnimation animation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_file(Gtk.Image image, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_gicon(Gtk.Image image, Gio.Icon icon, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_icon_name(Gtk.Image image, string icon_name, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_icon_set(Gtk.Image image, Gtk.IconSet icon_set, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_pixbuf(Gtk.Image image, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_resource(Gtk.Image image, string resource_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_stock(Gtk.Image image, string stock_id, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_from_surface(Gtk.Image image, cairo.Surface surface);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_set_pixel_size(Gtk.Image image, int pixel_size);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_menu_item_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_menu_item_new_from_stock(string stock_id, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_menu_item_new_with_label(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_menu_item_new_with_mnemonic(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_image_menu_item_get_always_show_image(Gtk.ImageMenuItem image_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_image_menu_item_get_image(Gtk.ImageMenuItem image_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_image_menu_item_get_use_stock(Gtk.ImageMenuItem image_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_menu_item_set_accel_group(Gtk.ImageMenuItem image_menu_item, Gtk.AccelGroup accel_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_menu_item_set_always_show_image(Gtk.ImageMenuItem image_menu_item, int always_show);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_menu_item_set_image(Gtk.ImageMenuItem image_menu_item, Gtk.Widget image);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_image_menu_item_set_use_stock(Gtk.ImageMenuItem image_menu_item, int use_stock);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_info_bar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_info_bar_add_action_widget(Gtk.InfoBar info_bar, Gtk.Widget child, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Button gtk_info_bar_add_button(Gtk.InfoBar info_bar, string button_text, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_info_bar_get_action_area(Gtk.InfoBar info_bar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_info_bar_get_content_area(Gtk.InfoBar info_bar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.MessageType gtk_info_bar_get_message_type(Gtk.InfoBar info_bar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_info_bar_get_show_close_button(Gtk.InfoBar info_bar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_info_bar_response(Gtk.InfoBar info_bar, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_info_bar_set_default_response(Gtk.InfoBar info_bar, int response_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_info_bar_set_message_type(Gtk.InfoBar info_bar, Gtk.MessageType message_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_info_bar_set_response_sensitive(Gtk.InfoBar info_bar, int response_id, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_info_bar_set_show_close_button(Gtk.InfoBar info_bar, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_invisible_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_invisible_new_for_screen(Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Screen gtk_invisible_get_screen(Gtk.Invisible invisible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_invisible_set_screen(Gtk.Invisible invisible, Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_layout_new(Gtk.Adjustment hadjustment, Gtk.Adjustment vadjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_layout_get_bin_window(Gtk.Layout layout);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_layout_get_hadjustment(Gtk.Layout layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_layout_get_size(Gtk.Layout layout, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_layout_get_vadjustment(Gtk.Layout layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_layout_move(Gtk.Layout layout, Gtk.Widget child_widget, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_layout_put(Gtk.Layout layout, Gtk.Widget child_widget, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_layout_set_hadjustment(Gtk.Layout layout, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_layout_set_size(Gtk.Layout layout, uint width, uint height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_layout_set_vadjustment(Gtk.Layout layout, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_level_bar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_level_bar_new_for_interval(double min_value, double max_value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_level_bar_add_offset_value(Gtk.LevelBar self, string name, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_level_bar_get_inverted(Gtk.LevelBar self);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_level_bar_get_max_value(Gtk.LevelBar self);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_level_bar_get_min_value(Gtk.LevelBar self);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.LevelBarMode gtk_level_bar_get_mode(Gtk.LevelBar self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_level_bar_get_offset_value(Gtk.LevelBar self, string name, System.IntPtr value);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_level_bar_get_value(Gtk.LevelBar self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_level_bar_remove_offset_value(Gtk.LevelBar self, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_level_bar_set_inverted(Gtk.LevelBar self, int inverted);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_level_bar_set_max_value(Gtk.LevelBar self, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_level_bar_set_min_value(Gtk.LevelBar self, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_level_bar_set_mode(Gtk.LevelBar self, Gtk.LevelBarMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_level_bar_set_value(Gtk.LevelBar self, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_link_button_new(string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_link_button_new_with_label(string uri, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_link_button_get_uri(Gtk.LinkButton link_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_link_button_get_visited(Gtk.LinkButton link_button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_link_button_set_uri(Gtk.LinkButton link_button, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_link_button_set_visited(Gtk.LinkButton link_button, int visited);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_list_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_bind_model(Gtk.ListBox box, Gio.ListModel model, System.IntPtr create_widget_func, System.IntPtr user_data, System.IntPtr user_data_free_func);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_drag_highlight_row(Gtk.ListBox box, Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_drag_unhighlight_row(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_list_box_get_activate_on_single_click(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_list_box_get_adjustment(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ListBoxRow gtk_list_box_get_row_at_index(Gtk.ListBox box, int index_);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ListBoxRow gtk_list_box_get_row_at_y(Gtk.ListBox box, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ListBoxRow gtk_list_box_get_selected_row(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_list_box_get_selected_rows(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SelectionMode gtk_list_box_get_selection_mode(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_insert(Gtk.ListBox box, Gtk.Widget child, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_invalidate_filter(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_invalidate_headers(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_invalidate_sort(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_prepend(Gtk.ListBox box, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_select_all(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_select_row(Gtk.ListBox box, Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_selected_foreach(Gtk.ListBox box, System.IntPtr func, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_set_activate_on_single_click(Gtk.ListBox box, int single);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_set_adjustment(Gtk.ListBox box, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_set_filter_func(Gtk.ListBox box, System.IntPtr filter_func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_set_header_func(Gtk.ListBox box, System.IntPtr update_header, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_set_placeholder(Gtk.ListBox box, Gtk.Widget placeholder);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_set_selection_mode(Gtk.ListBox box, Gtk.SelectionMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_set_sort_func(Gtk.ListBox box, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_unselect_all(Gtk.ListBox box);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_unselect_row(Gtk.ListBox box, Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_list_box_row_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_row_changed(Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_list_box_row_get_activatable(Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_list_box_row_get_header(Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_list_box_row_get_index(Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_list_box_row_get_selectable(Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_list_box_row_is_selected(Gtk.ListBoxRow row);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_row_set_activatable(Gtk.ListBoxRow row, int activatable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_row_set_header(Gtk.ListBoxRow row, Gtk.Widget header);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_box_row_set_selectable(Gtk.ListBoxRow row, int selectable);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_drag_dest_drag_data_received(Gtk.TreeDragDest drag_dest, Gtk.TreePath dest, Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_drag_dest_row_drop_possible(Gtk.TreeDragDest drag_dest, Gtk.TreePath dest_path, Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_drag_source_drag_data_delete(Gtk.TreeDragSource drag_source, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_drag_source_drag_data_get(Gtk.TreeDragSource drag_source, Gtk.TreePath path, Gtk.SelectionData selection_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_drag_source_row_draggable(Gtk.TreeDragSource drag_source, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_sortable_get_sort_column_id(Gtk.TreeSortable sortable, System.IntPtr sort_column_id, out Gtk.SortType order);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_sortable_has_default_sort_func(Gtk.TreeSortable sortable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_sortable_set_default_sort_func(Gtk.TreeSortable sortable, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_sortable_set_sort_column_id(Gtk.TreeSortable sortable, int sort_column_id, Gtk.SortType order);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_sortable_set_sort_func(Gtk.TreeSortable sortable, int sort_column_id, System.IntPtr sort_func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_sortable_sort_column_changed(Gtk.TreeSortable sortable);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ListStore gtk_list_store_newv(int n_columns, System.IntPtr types);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_clear(Gtk.ListStore list_store);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_list_store_iter_is_valid(Gtk.ListStore list_store, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_move_after(Gtk.ListStore store, Gtk.TreeIter iter, Gtk.TreeIter position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_move_before(Gtk.ListStore store, Gtk.TreeIter iter, Gtk.TreeIter position);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_list_store_remove(Gtk.ListStore list_store, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_reorder(Gtk.ListStore store, System.IntPtr new_order);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_set_column_types(Gtk.ListStore list_store, int n_columns, System.IntPtr types);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_set_value(Gtk.ListStore list_store, Gtk.TreeIter iter, int column, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_set_valuesv(Gtk.ListStore list_store, Gtk.TreeIter iter, System.IntPtr columns, System.IntPtr values, int n_values);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_list_store_swap(Gtk.ListStore store, Gtk.TreeIter a, Gtk.TreeIter b);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_lock_button_new(Gio.Permission permission);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Permission gtk_lock_button_get_permission(Gtk.LockButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_lock_button_set_permission(Gtk.LockButton button, Gio.Permission permission);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_bar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_bar_new_from_model(Gio.MenuModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PackDirection gtk_menu_bar_get_child_pack_direction(Gtk.MenuBar menubar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PackDirection gtk_menu_bar_get_pack_direction(Gtk.MenuBar menubar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_bar_set_child_pack_direction(Gtk.MenuBar menubar, Gtk.PackDirection child_pack_dir);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_bar_set_pack_direction(Gtk.MenuBar menubar, Gtk.PackDirection pack_dir);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_button_get_align_widget(Gtk.MenuButton menu_button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ArrowType gtk_menu_button_get_direction(Gtk.MenuButton menu_button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.MenuModel gtk_menu_button_get_menu_model(Gtk.MenuButton menu_button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Popover gtk_menu_button_get_popover(Gtk.MenuButton menu_button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Menu gtk_menu_button_get_popup(Gtk.MenuButton menu_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_menu_button_get_use_popover(Gtk.MenuButton menu_button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_button_set_align_widget(Gtk.MenuButton menu_button, Gtk.Widget align_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_button_set_direction(Gtk.MenuButton menu_button, Gtk.ArrowType direction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_button_set_menu_model(Gtk.MenuButton menu_button, Gio.MenuModel menu_model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_button_set_popover(Gtk.MenuButton menu_button, Gtk.Widget popover);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_button_set_popup(Gtk.MenuButton menu_button, Gtk.Widget menu);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_button_set_use_popover(Gtk.MenuButton menu_button, int use_popover);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_popover_new(Gtk.Widget relative_to);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_popover_new_from_model(Gtk.Widget relative_to, Gio.MenuModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_bind_model(Gtk.Popover popover, Gio.MenuModel model, string action_namespace);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PopoverConstraint gtk_popover_get_constrain_to(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_popover_get_default_widget(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_popover_get_modal(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PositionType gtk_popover_get_position(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_popover_get_relative_to(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_popover_get_transitions_enabled(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_popdown(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_popup(Gtk.Popover popover);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_set_constrain_to(Gtk.Popover popover, Gtk.PopoverConstraint constraint);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_set_default_widget(Gtk.Popover popover, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_set_modal(Gtk.Popover popover, int modal);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_set_pointing_to(Gtk.Popover popover, Gdk.Rectangle rect);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_set_position(Gtk.Popover popover, Gtk.PositionType position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_set_relative_to(Gtk.Popover popover, Gtk.Widget relative_to);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_set_transitions_enabled(Gtk.Popover popover, int transitions_enabled);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_tool_item_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.EllipsizeMode gtk_tool_item_get_ellipsize_mode(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_get_expand(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_get_homogeneous(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_get_icon_size(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_get_is_important(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Orientation gtk_tool_item_get_orientation(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_item_get_proxy_menu_item(Gtk.ToolItem tool_item, string menu_item_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ReliefStyle gtk_tool_item_get_relief_style(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern float gtk_tool_item_get_text_alignment(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Orientation gtk_tool_item_get_text_orientation(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SizeGroup gtk_tool_item_get_text_size_group(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolbarStyle gtk_tool_item_get_toolbar_style(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_get_use_drag_window(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_get_visible_horizontal(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_get_visible_vertical(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_rebuild_menu(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_item_retrieve_proxy_menu_item(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_expand(Gtk.ToolItem tool_item, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_homogeneous(Gtk.ToolItem tool_item, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_is_important(Gtk.ToolItem tool_item, int is_important);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_proxy_menu_item(Gtk.ToolItem tool_item, string menu_item_id, Gtk.Widget menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_tooltip_markup(Gtk.ToolItem tool_item, string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_tooltip_text(Gtk.ToolItem tool_item, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_use_drag_window(Gtk.ToolItem tool_item, int use_drag_window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_visible_horizontal(Gtk.ToolItem tool_item, int visible_horizontal);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_set_visible_vertical(Gtk.ToolItem tool_item, int visible_vertical);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_toolbar_reconfigured(Gtk.ToolItem tool_item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_menu_tool_button_new(Gtk.Widget icon_widget, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_menu_tool_button_new_from_stock(string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_menu_tool_button_get_menu(Gtk.MenuToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_tool_button_set_arrow_tooltip_markup(Gtk.MenuToolButton button, string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_tool_button_set_arrow_tooltip_text(Gtk.MenuToolButton button, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_menu_tool_button_set_menu(Gtk.MenuToolButton button, Gtk.Widget menu);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_tool_button_new(Gtk.Widget icon_widget, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_tool_button_new_from_stock(string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_tool_button_get_icon_name(Gtk.ToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_button_get_icon_widget(Gtk.ToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_tool_button_get_label(Gtk.ToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_button_get_label_widget(Gtk.ToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_tool_button_get_stock_id(Gtk.ToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_button_get_use_underline(Gtk.ToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_button_set_icon_name(Gtk.ToolButton button, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_button_set_icon_widget(Gtk.ToolButton button, Gtk.Widget icon_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_button_set_label(Gtk.ToolButton button, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_button_set_label_widget(Gtk.ToolButton button, Gtk.Widget label_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_button_set_stock_id(Gtk.ToolButton button, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_button_set_use_underline(Gtk.ToolButton button, int use_underline);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_message_dialog_get_image(Gtk.MessageDialog dialog);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_message_dialog_get_message_area(Gtk.MessageDialog message_dialog);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_message_dialog_set_image(Gtk.MessageDialog dialog, Gtk.Widget image);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_message_dialog_set_markup(Gtk.MessageDialog message_dialog, string str);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_model_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.MountOperation gtk_mount_operation_new(Gtk.Window parent);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Window gtk_mount_operation_get_parent(Gtk.MountOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Screen gtk_mount_operation_get_screen(Gtk.MountOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_mount_operation_is_showing(Gtk.MountOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_mount_operation_set_parent(Gtk.MountOperation op, Gtk.Window parent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_mount_operation_set_screen(Gtk.MountOperation op, Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_notebook_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_append_page(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget tab_label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_append_page_menu(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget tab_label, Gtk.Widget menu_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_detach_tab(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_notebook_get_action_widget(Gtk.Notebook notebook, Gtk.PackType pack_type);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_get_current_page(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_notebook_get_group_name(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_notebook_get_menu_label(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_notebook_get_menu_label_text(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_get_n_pages(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_notebook_get_nth_page(Gtk.Notebook notebook, int page_num);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_get_scrollable(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_get_show_border(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_get_show_tabs(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_get_tab_detachable(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern ushort gtk_notebook_get_tab_hborder(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_notebook_get_tab_label(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_notebook_get_tab_label_text(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PositionType gtk_notebook_get_tab_pos(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_get_tab_reorderable(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern ushort gtk_notebook_get_tab_vborder(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_insert_page(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget tab_label, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_insert_page_menu(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget tab_label, Gtk.Widget menu_label, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_next_page(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_page_num(Gtk.Notebook notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_popup_disable(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_popup_enable(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_prepend_page(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget tab_label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_notebook_prepend_page_menu(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget tab_label, Gtk.Widget menu_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_prev_page(Gtk.Notebook notebook);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_remove_page(Gtk.Notebook notebook, int page_num);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_reorder_child(Gtk.Notebook notebook, Gtk.Widget child, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_action_widget(Gtk.Notebook notebook, Gtk.Widget widget, Gtk.PackType pack_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_current_page(Gtk.Notebook notebook, int page_num);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_group_name(Gtk.Notebook notebook, string group_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_menu_label(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget menu_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_menu_label_text(Gtk.Notebook notebook, Gtk.Widget child, string menu_text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_scrollable(Gtk.Notebook notebook, int scrollable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_show_border(Gtk.Notebook notebook, int show_border);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_show_tabs(Gtk.Notebook notebook, int show_tabs);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_tab_detachable(Gtk.Notebook notebook, Gtk.Widget child, int detachable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_tab_label(Gtk.Notebook notebook, Gtk.Widget child, Gtk.Widget tab_label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_tab_label_text(Gtk.Notebook notebook, Gtk.Widget child, string tab_text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_tab_pos(Gtk.Notebook notebook, Gtk.PositionType pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_set_tab_reorderable(Gtk.Notebook notebook, Gtk.Widget child, int reorderable);
		[DllImport("libgtk-3.so.0")]
		public static extern Atk.Object gtk_notebook_page_accessible_new(Gtk.NotebookAccessible notebook, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_notebook_page_accessible_invalidate(Gtk.NotebookPageAccessible page);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Icon gtk_numerable_icon_new(Gio.Icon base_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Icon gtk_numerable_icon_new_with_style_context(Gio.Icon base_icon, Gtk.StyleContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Icon gtk_numerable_icon_get_background_gicon(Gtk.NumerableIcon self);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_numerable_icon_get_background_icon_name(Gtk.NumerableIcon self);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_numerable_icon_get_count(Gtk.NumerableIcon self);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_numerable_icon_get_label(Gtk.NumerableIcon self);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StyleContext gtk_numerable_icon_get_style_context(Gtk.NumerableIcon self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_numerable_icon_set_background_gicon(Gtk.NumerableIcon self, Gio.Icon icon);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_numerable_icon_set_background_icon_name(Gtk.NumerableIcon self, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_numerable_icon_set_count(Gtk.NumerableIcon self, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_numerable_icon_set_label(Gtk.NumerableIcon self, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_numerable_icon_set_style_context(Gtk.NumerableIcon self, Gtk.StyleContext style);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_offscreen_window_new();
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_offscreen_window_get_pixbuf(Gtk.OffscreenWindow offscreen);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Surface gtk_offscreen_window_get_surface(Gtk.OffscreenWindow offscreen);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_overlay_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_overlay_add_overlay(Gtk.Overlay overlay, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_overlay_get_overlay_pass_through(Gtk.Overlay overlay, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_overlay_reorder_overlay(Gtk.Overlay overlay, Gtk.Widget child, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_overlay_set_overlay_pass_through(Gtk.Overlay overlay, Gtk.Widget widget, int pass_through);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PadController gtk_pad_controller_new(Gtk.Window window, Gio.ActionGroup group, Gdk.Device pad);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_pad_controller_set_action(Gtk.PadController controller, Gtk.PadActionType type, int index, int mode, string label, string action_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_pad_controller_set_action_entries(Gtk.PadController controller, System.IntPtr entries, int n_entries);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_page_setup_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_page_setup_new_from_file(System.IntPtr file_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_page_setup_new_from_gvariant(GLib.Variant variant);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_page_setup_new_from_key_file(GLib.KeyFile key_file, string group_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_page_setup_copy(Gtk.PageSetup other);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_bottom_margin(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_left_margin(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageOrientation gtk_page_setup_get_orientation(Gtk.PageSetup setup);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_page_height(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_page_width(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_paper_height(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_page_setup_get_paper_size(Gtk.PageSetup setup);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_paper_width(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_right_margin(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_page_setup_get_top_margin(Gtk.PageSetup setup, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_page_setup_load_file(Gtk.PageSetup setup, System.IntPtr file_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_page_setup_load_key_file(Gtk.PageSetup setup, GLib.KeyFile key_file, string group_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_set_bottom_margin(Gtk.PageSetup setup, double margin, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_set_left_margin(Gtk.PageSetup setup, double margin, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_set_orientation(Gtk.PageSetup setup, Gtk.PageOrientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_set_paper_size(Gtk.PageSetup setup, Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_set_paper_size_and_default_margins(Gtk.PageSetup setup, Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_set_right_margin(Gtk.PageSetup setup, double margin, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_set_top_margin(Gtk.PageSetup setup, double margin, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_page_setup_to_file(Gtk.PageSetup setup, System.IntPtr file_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.Variant gtk_page_setup_to_gvariant(Gtk.PageSetup setup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_page_setup_to_key_file(Gtk.PageSetup setup, GLib.KeyFile key_file, string group_name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_paper_size_new(string name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_paper_size_new_custom(string name, string display_name, double width, double height, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_paper_size_new_from_gvariant(GLib.Variant variant);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_paper_size_new_from_ipp(string ipp_name, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_paper_size_new_from_key_file(GLib.KeyFile key_file, string group_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_paper_size_new_from_ppd(string ppd_name, string ppd_display_name, double width, double height);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_paper_size_copy(Gtk.PaperSize other);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paper_size_free(Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_paper_size_get_default_bottom_margin(Gtk.PaperSize size, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_paper_size_get_default_left_margin(Gtk.PaperSize size, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_paper_size_get_default_right_margin(Gtk.PaperSize size, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_paper_size_get_default_top_margin(Gtk.PaperSize size, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_paper_size_get_display_name(Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_paper_size_get_height(Gtk.PaperSize size, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_paper_size_get_name(Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_paper_size_get_ppd_name(Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_paper_size_get_width(Gtk.PaperSize size, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_paper_size_is_custom(Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_paper_size_is_equal(Gtk.PaperSize size1, Gtk.PaperSize size2);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_paper_size_is_ipp(Gtk.PaperSize size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paper_size_set_size(Gtk.PaperSize size, double width, double height, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.Variant gtk_paper_size_to_gvariant(Gtk.PaperSize paper_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_paper_size_to_key_file(Gtk.PaperSize size, GLib.KeyFile key_file, string group_name);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_paper_size_get_default();
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_paper_size_get_paper_sizes(int include_custom);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_places_sidebar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_add_shortcut(Gtk.PlacesSidebar sidebar, Gio.File location);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_local_only(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.File gtk_places_sidebar_get_location(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.File gtk_places_sidebar_get_nth_bookmark(Gtk.PlacesSidebar sidebar, int n);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PlacesOpenFlags gtk_places_sidebar_get_open_flags(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_show_connect_to_server(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_show_desktop(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_show_enter_location(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_show_other_locations(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_show_recent(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_show_starred_location(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_places_sidebar_get_show_trash(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_places_sidebar_list_shortcuts(Gtk.PlacesSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_remove_shortcut(Gtk.PlacesSidebar sidebar, Gio.File location);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_drop_targets_visible(Gtk.PlacesSidebar sidebar, int visible, Gdk.DragContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_local_only(Gtk.PlacesSidebar sidebar, int local_only);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_location(Gtk.PlacesSidebar sidebar, Gio.File location);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_open_flags(Gtk.PlacesSidebar sidebar, Gtk.PlacesOpenFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_show_connect_to_server(Gtk.PlacesSidebar sidebar, int show_connect_to_server);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_show_desktop(Gtk.PlacesSidebar sidebar, int show_desktop);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_show_enter_location(Gtk.PlacesSidebar sidebar, int show_enter_location);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_show_other_locations(Gtk.PlacesSidebar sidebar, int show_other_locations);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_show_recent(Gtk.PlacesSidebar sidebar, int show_recent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_show_starred_location(Gtk.PlacesSidebar sidebar, int show_starred_location);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_places_sidebar_set_show_trash(Gtk.PlacesSidebar sidebar, int show_trash);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scrolled_window_new(Gtk.Adjustment hadjustment, Gtk.Adjustment vadjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_add_with_viewport(Gtk.ScrolledWindow scrolled_window, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_capture_button_press(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_scrolled_window_get_hadjustment(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scrolled_window_get_hscrollbar(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_kinetic_scrolling(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_max_content_height(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_max_content_width(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_min_content_height(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_min_content_width(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_overlay_scrolling(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.CornerType gtk_scrolled_window_get_placement(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_get_policy(Gtk.ScrolledWindow scrolled_window, out Gtk.PolicyType hscrollbar_policy, out Gtk.PolicyType vscrollbar_policy);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_propagate_natural_height(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_scrolled_window_get_propagate_natural_width(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ShadowType gtk_scrolled_window_get_shadow_type(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_scrolled_window_get_vadjustment(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scrolled_window_get_vscrollbar(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_capture_button_press(Gtk.ScrolledWindow scrolled_window, int capture_button_press);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_hadjustment(Gtk.ScrolledWindow scrolled_window, Gtk.Adjustment hadjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_kinetic_scrolling(Gtk.ScrolledWindow scrolled_window, int kinetic_scrolling);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_max_content_height(Gtk.ScrolledWindow scrolled_window, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_max_content_width(Gtk.ScrolledWindow scrolled_window, int width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_min_content_height(Gtk.ScrolledWindow scrolled_window, int height);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_min_content_width(Gtk.ScrolledWindow scrolled_window, int width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_overlay_scrolling(Gtk.ScrolledWindow scrolled_window, int overlay_scrolling);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_placement(Gtk.ScrolledWindow scrolled_window, Gtk.CornerType window_placement);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_policy(Gtk.ScrolledWindow scrolled_window, Gtk.PolicyType hscrollbar_policy, Gtk.PolicyType vscrollbar_policy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_propagate_natural_height(Gtk.ScrolledWindow scrolled_window, int propagate);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_propagate_natural_width(Gtk.ScrolledWindow scrolled_window, int propagate);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_shadow_type(Gtk.ScrolledWindow scrolled_window, Gtk.ShadowType type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_set_vadjustment(Gtk.ScrolledWindow scrolled_window, Gtk.Adjustment vadjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scrolled_window_unset_placement(Gtk.ScrolledWindow scrolled_window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_plug_new(ulong socket_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_plug_new_for_display(Gdk.Display display, ulong socket_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_plug_construct(Gtk.Plug plug, ulong socket_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_plug_construct_for_display(Gtk.Plug plug, Gdk.Display display, ulong socket_id);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_plug_get_embedded(Gtk.Plug plug);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_plug_get_id(Gtk.Plug plug);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_plug_get_socket_window(Gtk.Plug plug);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_popover_menu_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_popover_menu_open_submenu(Gtk.PopoverMenu popover, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Context gtk_print_context_create_pango_context(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Layout gtk_print_context_create_pango_layout(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Context gtk_print_context_get_cairo_context(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_context_get_dpi_x(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_context_get_dpi_y(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_context_get_hard_margins(Gtk.PrintContext context, System.IntPtr top, System.IntPtr bottom, System.IntPtr left, System.IntPtr right);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_context_get_height(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_print_context_get_page_setup(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontMap gtk_print_context_get_pango_fontmap(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_context_get_width(Gtk.PrintContext context);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_context_set_cairo_context(Gtk.PrintContext context, cairo.Context cr, double dpi_x, double dpi_y);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_print_error_quark();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_preview_end_preview(Gtk.PrintOperationPreview preview);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_operation_preview_is_selected(Gtk.PrintOperationPreview preview, int page_nr);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_preview_render_page(Gtk.PrintOperationPreview preview, int page_nr);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintOperation gtk_print_operation_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_cancel(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_draw_page_finish(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSetup gtk_print_operation_get_default_page_setup(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_operation_get_embed_page_setup(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_get_error(Gtk.PrintOperation op, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_operation_get_has_selection(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_operation_get_n_pages_to_print(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintSettings gtk_print_operation_get_print_settings(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintStatus gtk_print_operation_get_status(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_operation_get_status_string(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_operation_get_support_selection(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_operation_is_finished(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintOperationResult gtk_print_operation_run(Gtk.PrintOperation op, Gtk.PrintOperationAction action, Gtk.Window parent, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_allow_async(Gtk.PrintOperation op, int allow_async);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_current_page(Gtk.PrintOperation op, int current_page);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_custom_tab_label(Gtk.PrintOperation op, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_default_page_setup(Gtk.PrintOperation op, Gtk.PageSetup default_page_setup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_defer_drawing(Gtk.PrintOperation op);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_embed_page_setup(Gtk.PrintOperation op, int embed);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_export_filename(Gtk.PrintOperation op, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_has_selection(Gtk.PrintOperation op, int has_selection);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_job_name(Gtk.PrintOperation op, string job_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_n_pages(Gtk.PrintOperation op, int n_pages);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_print_settings(Gtk.PrintOperation op, Gtk.PrintSettings print_settings);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_show_progress(Gtk.PrintOperation op, int show_progress);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_support_selection(Gtk.PrintOperation op, int support_selection);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_track_print_status(Gtk.PrintOperation op, int track_status);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_unit(Gtk.PrintOperation op, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_operation_set_use_full_page(Gtk.PrintOperation op, int full_page);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintSettings gtk_print_settings_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintSettings gtk_print_settings_new_from_file(System.IntPtr file_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintSettings gtk_print_settings_new_from_gvariant(GLib.Variant variant);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintSettings gtk_print_settings_new_from_key_file(GLib.KeyFile key_file, string group_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintSettings gtk_print_settings_copy(Gtk.PrintSettings other);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_foreach(Gtk.PrintSettings settings, System.IntPtr func, System.IntPtr user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_settings_get(Gtk.PrintSettings settings, string key);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_bool(Gtk.PrintSettings settings, string key);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_collate(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_settings_get_default_source(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_settings_get_dither(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_settings_get_double(Gtk.PrintSettings settings, string key);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_settings_get_double_with_default(Gtk.PrintSettings settings, string key, double def);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintDuplex gtk_print_settings_get_duplex(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_settings_get_finishings(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_int(Gtk.PrintSettings settings, string key);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_int_with_default(Gtk.PrintSettings settings, string key, int def);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_settings_get_length(Gtk.PrintSettings settings, string key, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_settings_get_media_type(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_n_copies(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_number_up(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.NumberUpLayout gtk_print_settings_get_number_up_layout(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageOrientation gtk_print_settings_get_orientation(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_settings_get_output_bin(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_print_settings_get_page_ranges(Gtk.PrintSettings settings, System.IntPtr num_ranges);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PageSet gtk_print_settings_get_page_set(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_settings_get_paper_height(Gtk.PrintSettings settings, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PaperSize gtk_print_settings_get_paper_size(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_settings_get_paper_width(Gtk.PrintSettings settings, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintPages gtk_print_settings_get_print_pages(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_print_settings_get_printer(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_settings_get_printer_lpi(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.PrintQuality gtk_print_settings_get_quality(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_resolution(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_resolution_x(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_resolution_y(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_reverse(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_print_settings_get_scale(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_get_use_color(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_has_key(Gtk.PrintSettings settings, string key);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_load_file(Gtk.PrintSettings settings, System.IntPtr file_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_load_key_file(Gtk.PrintSettings settings, GLib.KeyFile key_file, string group_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set(Gtk.PrintSettings settings, string key, string value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_bool(Gtk.PrintSettings settings, string key, int value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_collate(Gtk.PrintSettings settings, int collate);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_default_source(Gtk.PrintSettings settings, string default_source);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_dither(Gtk.PrintSettings settings, string dither);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_double(Gtk.PrintSettings settings, string key, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_duplex(Gtk.PrintSettings settings, Gtk.PrintDuplex duplex);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_finishings(Gtk.PrintSettings settings, string finishings);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_int(Gtk.PrintSettings settings, string key, int value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_length(Gtk.PrintSettings settings, string key, double value, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_media_type(Gtk.PrintSettings settings, string media_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_n_copies(Gtk.PrintSettings settings, int num_copies);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_number_up(Gtk.PrintSettings settings, int number_up);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_number_up_layout(Gtk.PrintSettings settings, Gtk.NumberUpLayout number_up_layout);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_orientation(Gtk.PrintSettings settings, Gtk.PageOrientation orientation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_output_bin(Gtk.PrintSettings settings, string output_bin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_page_ranges(Gtk.PrintSettings settings, System.IntPtr page_ranges, int num_ranges);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_page_set(Gtk.PrintSettings settings, Gtk.PageSet page_set);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_paper_height(Gtk.PrintSettings settings, double height, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_paper_size(Gtk.PrintSettings settings, Gtk.PaperSize paper_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_paper_width(Gtk.PrintSettings settings, double width, Gtk.Unit unit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_print_pages(Gtk.PrintSettings settings, Gtk.PrintPages pages);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_printer(Gtk.PrintSettings settings, string printer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_printer_lpi(Gtk.PrintSettings settings, double lpi);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_quality(Gtk.PrintSettings settings, Gtk.PrintQuality quality);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_resolution(Gtk.PrintSettings settings, int resolution);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_resolution_xy(Gtk.PrintSettings settings, int resolution_x, int resolution_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_reverse(Gtk.PrintSettings settings, int reverse);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_scale(Gtk.PrintSettings settings, double scale);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_set_use_color(Gtk.PrintSettings settings, int use_color);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_print_settings_to_file(Gtk.PrintSettings settings, System.IntPtr file_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern GLib.Variant gtk_print_settings_to_gvariant(Gtk.PrintSettings settings);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_to_key_file(Gtk.PrintSettings settings, GLib.KeyFile key_file, string group_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_print_settings_unset(Gtk.PrintSettings settings, string key);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_progress_bar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.EllipsizeMode gtk_progress_bar_get_ellipsize(Gtk.ProgressBar pbar);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_progress_bar_get_fraction(Gtk.ProgressBar pbar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_progress_bar_get_inverted(Gtk.ProgressBar pbar);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_progress_bar_get_pulse_step(Gtk.ProgressBar pbar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_progress_bar_get_show_text(Gtk.ProgressBar pbar);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_progress_bar_get_text(Gtk.ProgressBar pbar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_progress_bar_pulse(Gtk.ProgressBar pbar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_progress_bar_set_ellipsize(Gtk.ProgressBar pbar, Pango.EllipsizeMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_progress_bar_set_fraction(Gtk.ProgressBar pbar, double fraction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_progress_bar_set_inverted(Gtk.ProgressBar pbar, int inverted);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_progress_bar_set_pulse_step(Gtk.ProgressBar pbar, double fraction);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_progress_bar_set_show_text(Gtk.ProgressBar pbar, int show_text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_progress_bar_set_text(Gtk.ProgressBar pbar, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RadioAction gtk_radio_action_new(string name, string label, string tooltip, string stock_id, int value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_radio_action_get_current_value(Gtk.RadioAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_radio_action_get_group(Gtk.RadioAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_action_join_group(Gtk.RadioAction action, Gtk.RadioAction group_source);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_action_set_current_value(Gtk.RadioAction action, int current_value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_action_set_group(Gtk.RadioAction action, System.IntPtr group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToggleAction gtk_toggle_action_new(string name, string label, string tooltip, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toggle_action_get_active(Gtk.ToggleAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toggle_action_get_draw_as_radio(Gtk.ToggleAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_action_set_active(Gtk.ToggleAction action, int is_active);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_action_set_draw_as_radio(Gtk.ToggleAction action, int draw_as_radio);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_action_toggled(Gtk.ToggleAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_button_new(System.IntPtr group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_button_new_from_widget(Gtk.RadioButton radio_group_member);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_button_new_with_label(System.IntPtr group, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_button_new_with_label_from_widget(Gtk.RadioButton radio_group_member, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_button_new_with_mnemonic(System.IntPtr group, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_button_new_with_mnemonic_from_widget(Gtk.RadioButton radio_group_member, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_radio_button_get_group(Gtk.RadioButton radio_button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_button_join_group(Gtk.RadioButton radio_button, Gtk.RadioButton group_source);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_button_set_group(Gtk.RadioButton radio_button, System.IntPtr group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_menu_item_new(System.IntPtr group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_menu_item_new_from_widget(Gtk.RadioMenuItem group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_menu_item_new_with_label(System.IntPtr group, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_menu_item_new_with_label_from_widget(Gtk.RadioMenuItem group, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_menu_item_new_with_mnemonic(System.IntPtr group, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_radio_menu_item_new_with_mnemonic_from_widget(Gtk.RadioMenuItem group, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_radio_menu_item_get_group(Gtk.RadioMenuItem radio_menu_item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_menu_item_join_group(Gtk.RadioMenuItem radio_menu_item, Gtk.RadioMenuItem group_source);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_menu_item_set_group(Gtk.RadioMenuItem radio_menu_item, System.IntPtr group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_radio_tool_button_new(System.IntPtr group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_radio_tool_button_new_from_stock(System.IntPtr group, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_radio_tool_button_new_from_widget(Gtk.RadioToolButton group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_radio_tool_button_new_with_stock_from_widget(Gtk.RadioToolButton group, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_radio_tool_button_get_group(Gtk.RadioToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_radio_tool_button_set_group(Gtk.RadioToolButton button, System.IntPtr group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_toggle_tool_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_toggle_tool_button_new_from_stock(string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toggle_tool_button_get_active(Gtk.ToggleToolButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toggle_tool_button_set_active(Gtk.ToggleToolButton button, int is_active);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_range_get_adjustment(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_range_get_fill_level(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_range_get_flippable(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_range_get_inverted(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SensitivityType gtk_range_get_lower_stepper_sensitivity(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_range_get_min_slider_size(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_range_get_restrict_to_fill_level(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_range_get_round_digits(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_range_get_show_fill_level(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_get_slider_range(Gtk.Range range, System.IntPtr slider_start, System.IntPtr slider_end);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_range_get_slider_size_fixed(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SensitivityType gtk_range_get_upper_stepper_sensitivity(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_range_get_value(Gtk.Range range);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_adjustment(Gtk.Range range, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_fill_level(Gtk.Range range, double fill_level);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_flippable(Gtk.Range range, int flippable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_increments(Gtk.Range range, double step, double page);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_inverted(Gtk.Range range, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_lower_stepper_sensitivity(Gtk.Range range, Gtk.SensitivityType sensitivity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_min_slider_size(Gtk.Range range, int min_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_range(Gtk.Range range, double min, double max);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_restrict_to_fill_level(Gtk.Range range, int restrict_to_fill_level);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_round_digits(Gtk.Range range, int round_digits);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_show_fill_level(Gtk.Range range, int show_fill_level);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_slider_size_fixed(Gtk.Range range, int size_fixed);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_upper_stepper_sensitivity(Gtk.Range range, Gtk.SensitivityType sensitivity);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_range_set_value(Gtk.Range range, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_rc_property_parse_border(GObject.ParamSpec pspec, GLib.String gstring, GObject.Value property_value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_rc_property_parse_color(GObject.ParamSpec pspec, GLib.String gstring, GObject.Value property_value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_rc_property_parse_enum(GObject.ParamSpec pspec, GLib.String gstring, GObject.Value property_value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_rc_property_parse_flags(GObject.ParamSpec pspec, GLib.String gstring, GObject.Value property_value);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_rc_property_parse_requisition(GObject.ParamSpec pspec, GLib.String gstring, GObject.Value property_value);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RcStyle gtk_rc_style_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RcStyle gtk_rc_style_copy(Gtk.RcStyle orig);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_add_filter(Gtk.RecentChooser chooser, Gtk.RecentFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentInfo gtk_recent_chooser_get_current_item(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_chooser_get_current_uri(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentFilter gtk_recent_chooser_get_filter(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_recent_chooser_get_items(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_get_limit(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_get_local_only(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_get_select_multiple(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_get_show_icons(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_get_show_not_found(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_get_show_private(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_get_show_tips(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentSortType gtk_recent_chooser_get_sort_type(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_recent_chooser_get_uris(Gtk.RecentChooser chooser, System.IntPtr length);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_recent_chooser_list_filters(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_remove_filter(Gtk.RecentChooser chooser, Gtk.RecentFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_select_all(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_select_uri(Gtk.RecentChooser chooser, string uri, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_set_current_uri(Gtk.RecentChooser chooser, string uri, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_filter(Gtk.RecentChooser chooser, Gtk.RecentFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_limit(Gtk.RecentChooser chooser, int limit);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_local_only(Gtk.RecentChooser chooser, int local_only);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_select_multiple(Gtk.RecentChooser chooser, int select_multiple);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_show_icons(Gtk.RecentChooser chooser, int show_icons);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_show_not_found(Gtk.RecentChooser chooser, int show_not_found);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_show_private(Gtk.RecentChooser chooser, int show_private);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_show_tips(Gtk.RecentChooser chooser, int show_tips);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_sort_func(Gtk.RecentChooser chooser, System.IntPtr sort_func, System.IntPtr sort_data, System.IntPtr data_destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_set_sort_type(Gtk.RecentChooser chooser, Gtk.RecentSortType sort_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_unselect_all(Gtk.RecentChooser chooser);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_unselect_uri(Gtk.RecentChooser chooser, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentManager gtk_recent_manager_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentManager gtk_recent_manager_get_default();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_manager_add_full(Gtk.RecentManager manager, string uri, Gtk.RecentData recent_data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_manager_add_item(Gtk.RecentManager manager, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_recent_manager_get_items(Gtk.RecentManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_manager_has_item(Gtk.RecentManager manager, string uri);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentInfo gtk_recent_manager_lookup_item(Gtk.RecentManager manager, string uri, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_manager_move_item(Gtk.RecentManager manager, string uri, string new_uri, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_manager_purge_items(Gtk.RecentManager manager, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_manager_remove_item(Gtk.RecentManager manager, string uri, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Action gtk_recent_action_new(string name, string label, string tooltip, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Action gtk_recent_action_new_for_manager(string name, string label, string tooltip, string stock_id, Gtk.RecentManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_action_get_show_numbers(Gtk.RecentAction action);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_action_set_show_numbers(Gtk.RecentAction action, int show_numbers);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentFilter gtk_recent_filter_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_add_age(Gtk.RecentFilter filter, int days);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_add_application(Gtk.RecentFilter filter, string application);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_add_custom(Gtk.RecentFilter filter, Gtk.RecentFilterFlags needed, System.IntPtr func, System.IntPtr data, System.IntPtr data_destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_add_group(Gtk.RecentFilter filter, string group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_add_mime_type(Gtk.RecentFilter filter, string mime_type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_add_pattern(Gtk.RecentFilter filter, string pattern);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_add_pixbuf_formats(Gtk.RecentFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_filter_filter(Gtk.RecentFilter filter, Gtk.RecentFilterInfo filter_info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_filter_get_name(Gtk.RecentFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentFilterFlags gtk_recent_filter_get_needed(Gtk.RecentFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_filter_set_name(Gtk.RecentFilter filter, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.AppInfo gtk_recent_info_create_app_info(Gtk.RecentInfo info, string app_name, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_exists(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern long gtk_recent_info_get_added(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_get_age(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_get_application_info(Gtk.RecentInfo info, string app_name, string app_exec, System.IntPtr count, System.IntPtr time_);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_recent_info_get_applications(Gtk.RecentInfo info, System.IntPtr length);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_info_get_description(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_info_get_display_name(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Icon gtk_recent_info_get_gicon(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_recent_info_get_groups(Gtk.RecentInfo info, System.IntPtr length);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_recent_info_get_icon(Gtk.RecentInfo info, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_info_get_mime_type(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern long gtk_recent_info_get_modified(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_get_private_hint(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_info_get_short_name(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_info_get_uri(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_info_get_uri_display(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern long gtk_recent_info_get_visited(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_has_application(Gtk.RecentInfo info, string app_name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_has_group(Gtk.RecentInfo info, string group_name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_is_local(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_recent_info_last_application(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_info_match(Gtk.RecentInfo info_a, Gtk.RecentInfo info_b);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RecentInfo gtk_recent_info_ref(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_info_unref(Gtk.RecentInfo info);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_recent_chooser_error_quark();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_recent_chooser_menu_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_recent_chooser_menu_new_for_manager(Gtk.RecentManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_recent_chooser_menu_get_show_numbers(Gtk.RecentChooserMenu menu);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_recent_chooser_menu_set_show_numbers(Gtk.RecentChooserMenu menu, int show_numbers);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_recent_chooser_widget_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_recent_chooser_widget_new_for_manager(Gtk.RecentManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_recent_manager_error_quark();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_revealer_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_revealer_get_child_revealed(Gtk.Revealer revealer);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_revealer_get_reveal_child(Gtk.Revealer revealer);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_revealer_get_transition_duration(Gtk.Revealer revealer);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.RevealerTransitionType gtk_revealer_get_transition_type(Gtk.Revealer revealer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_revealer_set_reveal_child(Gtk.Revealer revealer, int reveal_child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_revealer_set_transition_duration(Gtk.Revealer revealer, uint duration);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_revealer_set_transition_type(Gtk.Revealer revealer, Gtk.RevealerTransitionType transition);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scale_button_new(int size, double min, double max, double step, System.IntPtr icons);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_scale_button_get_adjustment(Gtk.ScaleButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Button gtk_scale_button_get_minus_button(Gtk.ScaleButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Button gtk_scale_button_get_plus_button(Gtk.ScaleButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_scale_button_get_popup(Gtk.ScaleButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_scale_button_get_value(Gtk.ScaleButton button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_button_set_adjustment(Gtk.ScaleButton button, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_button_set_icons(Gtk.ScaleButton button, System.IntPtr icons);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_scale_button_set_value(Gtk.ScaleButton button, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_search_bar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_search_bar_connect_entry(Gtk.SearchBar bar, Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_search_bar_get_search_mode(Gtk.SearchBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_search_bar_get_show_close_button(Gtk.SearchBar bar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_search_bar_handle_event(Gtk.SearchBar bar, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_search_bar_set_search_mode(Gtk.SearchBar bar, int search_mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_search_bar_set_show_close_button(Gtk.SearchBar bar, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_search_entry_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_search_entry_handle_event(Gtk.SearchEntry entry, System.IntPtr @event);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_separator_menu_item_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_separator_tool_item_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_separator_tool_item_get_draw(Gtk.SeparatorToolItem item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_separator_tool_item_set_draw(Gtk.SeparatorToolItem item, int draw);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_shortcut_label_new(string accelerator);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_shortcut_label_get_accelerator(Gtk.ShortcutLabel self);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_shortcut_label_get_disabled_text(Gtk.ShortcutLabel self);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_shortcut_label_set_accelerator(Gtk.ShortcutLabel self, string accelerator);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_shortcut_label_set_disabled_text(Gtk.ShortcutLabel self, string disabled_text);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SizeGroup gtk_size_group_new(Gtk.SizeGroupMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_size_group_add_widget(Gtk.SizeGroup size_group, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_size_group_get_ignore_hidden(Gtk.SizeGroup size_group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SizeGroupMode gtk_size_group_get_mode(Gtk.SizeGroup size_group);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_size_group_get_widgets(Gtk.SizeGroup size_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_size_group_remove_widget(Gtk.SizeGroup size_group, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_size_group_set_ignore_hidden(Gtk.SizeGroup size_group, int ignore_hidden);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_size_group_set_mode(Gtk.SizeGroup size_group, Gtk.SizeGroupMode mode);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_socket_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_socket_add_id(Gtk.Socket socket_, ulong window);
		[DllImport("libgtk-3.so.0")]
		public static extern ulong gtk_socket_get_id(Gtk.Socket socket_);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_socket_get_plug_window(Gtk.Socket socket_);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_spin_button_new(Gtk.Adjustment adjustment, double climb_rate, uint digits);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_spin_button_new_with_range(double min, double max, double step);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_configure(Gtk.SpinButton spin_button, Gtk.Adjustment adjustment, double climb_rate, uint digits);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_spin_button_get_adjustment(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_spin_button_get_digits(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_get_increments(Gtk.SpinButton spin_button, System.IntPtr step, System.IntPtr page);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_spin_button_get_numeric(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_get_range(Gtk.SpinButton spin_button, System.IntPtr min, System.IntPtr max);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_spin_button_get_snap_to_ticks(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SpinButtonUpdatePolicy gtk_spin_button_get_update_policy(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern double gtk_spin_button_get_value(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_spin_button_get_value_as_int(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_spin_button_get_wrap(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_adjustment(Gtk.SpinButton spin_button, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_digits(Gtk.SpinButton spin_button, uint digits);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_increments(Gtk.SpinButton spin_button, double step, double page);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_numeric(Gtk.SpinButton spin_button, int numeric);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_range(Gtk.SpinButton spin_button, double min, double max);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_snap_to_ticks(Gtk.SpinButton spin_button, int snap_to_ticks);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_update_policy(Gtk.SpinButton spin_button, Gtk.SpinButtonUpdatePolicy policy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_value(Gtk.SpinButton spin_button, double value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_set_wrap(Gtk.SpinButton spin_button, int wrap);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_spin(Gtk.SpinButton spin_button, Gtk.SpinType direction, double increment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spin_button_update(Gtk.SpinButton spin_button);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_spinner_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spinner_start(Gtk.Spinner spinner);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_spinner_stop(Gtk.Spinner spinner);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_stack_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_add_named(Gtk.Stack stack, Gtk.Widget child, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_add_titled(Gtk.Stack stack, Gtk.Widget child, string name, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_stack_get_child_by_name(Gtk.Stack stack, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_stack_get_hhomogeneous(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_stack_get_homogeneous(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_stack_get_interpolate_size(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_stack_get_transition_duration(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_stack_get_transition_running(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StackTransitionType gtk_stack_get_transition_type(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_stack_get_vhomogeneous(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_stack_get_visible_child(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_stack_get_visible_child_name(Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_hhomogeneous(Gtk.Stack stack, int hhomogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_homogeneous(Gtk.Stack stack, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_interpolate_size(Gtk.Stack stack, int interpolate_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_transition_duration(Gtk.Stack stack, uint duration);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_transition_type(Gtk.Stack stack, Gtk.StackTransitionType transition);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_vhomogeneous(Gtk.Stack stack, int vhomogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_visible_child(Gtk.Stack stack, Gtk.Widget child);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_visible_child_full(Gtk.Stack stack, string name, Gtk.StackTransitionType transition);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_set_visible_child_name(Gtk.Stack stack, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_stack_sidebar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Stack gtk_stack_sidebar_get_stack(Gtk.StackSidebar sidebar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_sidebar_set_stack(Gtk.StackSidebar sidebar, Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_stack_switcher_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Stack gtk_stack_switcher_get_stack(Gtk.StackSwitcher switcher);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stack_switcher_set_stack(Gtk.StackSwitcher switcher, Gtk.Stack stack);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StatusIcon gtk_status_icon_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StatusIcon gtk_status_icon_new_from_file(System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StatusIcon gtk_status_icon_new_from_gicon(Gio.Icon icon);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StatusIcon gtk_status_icon_new_from_icon_name(string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StatusIcon gtk_status_icon_new_from_pixbuf(GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StatusIcon gtk_status_icon_new_from_stock(string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_position_menu(Gtk.Menu menu, System.IntPtr x, System.IntPtr y, System.IntPtr push_in, Gtk.StatusIcon user_data);
		[DllImport("libgtk-3.so.0")]
		public static extern Gio.Icon gtk_status_icon_get_gicon(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_status_icon_get_has_tooltip(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_status_icon_get_icon_name(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_status_icon_get_pixbuf(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Screen gtk_status_icon_get_screen(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_status_icon_get_size(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_status_icon_get_stock(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ImageType gtk_status_icon_get_storage_type(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_status_icon_get_title(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_status_icon_get_tooltip_markup(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_status_icon_get_tooltip_text(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_status_icon_get_visible(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_status_icon_get_x11_window_id(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_status_icon_is_embedded(Gtk.StatusIcon status_icon);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_from_file(Gtk.StatusIcon status_icon, System.IntPtr filename);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_from_gicon(Gtk.StatusIcon status_icon, Gio.Icon icon);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_from_icon_name(Gtk.StatusIcon status_icon, string icon_name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_from_pixbuf(Gtk.StatusIcon status_icon, GdkPixbuf.Pixbuf pixbuf);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_from_stock(Gtk.StatusIcon status_icon, string stock_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_has_tooltip(Gtk.StatusIcon status_icon, int has_tooltip);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_name(Gtk.StatusIcon status_icon, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_screen(Gtk.StatusIcon status_icon, Gdk.Screen screen);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_title(Gtk.StatusIcon status_icon, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_tooltip_markup(Gtk.StatusIcon status_icon, string markup);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_tooltip_text(Gtk.StatusIcon status_icon, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_status_icon_set_visible(Gtk.StatusIcon status_icon, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_statusbar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_statusbar_get_context_id(Gtk.Statusbar statusbar, string context_description);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Box gtk_statusbar_get_message_area(Gtk.Statusbar statusbar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_statusbar_pop(Gtk.Statusbar statusbar, uint context_id);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_statusbar_push(Gtk.Statusbar statusbar, uint context_id, string text);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_statusbar_remove(Gtk.Statusbar statusbar, uint context_id, uint message_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_statusbar_remove_all(Gtk.Statusbar statusbar, uint context_id);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StockItem gtk_stock_item_copy(Gtk.StockItem item);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_stock_item_free(Gtk.StockItem item);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_switch_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_switch_get_active(Gtk.Switch sw);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_switch_get_state(Gtk.Switch sw);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_switch_set_active(Gtk.Switch sw, int is_active);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_switch_set_state(Gtk.Switch sw, int state);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_table_new(uint rows, uint columns, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_attach(Gtk.Table table, Gtk.Widget child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach, Gtk.AttachOptions xoptions, Gtk.AttachOptions yoptions, uint xpadding, uint ypadding);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_attach_defaults(Gtk.Table table, Gtk.Widget widget, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_table_get_col_spacing(Gtk.Table table, uint column);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_table_get_default_col_spacing(Gtk.Table table);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_table_get_default_row_spacing(Gtk.Table table);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_table_get_homogeneous(Gtk.Table table);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_table_get_row_spacing(Gtk.Table table, uint row);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_get_size(Gtk.Table table, System.IntPtr rows, System.IntPtr columns);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_resize(Gtk.Table table, uint rows, uint columns);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_set_col_spacing(Gtk.Table table, uint column, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_set_col_spacings(Gtk.Table table, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_set_homogeneous(Gtk.Table table, int homogeneous);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_set_row_spacing(Gtk.Table table, uint row, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_table_set_row_spacings(Gtk.Table table, uint spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tearoff_menu_item_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextAttributes gtk_text_attributes_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextAttributes gtk_text_attributes_copy(Gtk.TextAttributes src);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_attributes_copy_values(Gtk.TextAttributes src, Gtk.TextAttributes dest);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextAttributes gtk_text_attributes_ref(Gtk.TextAttributes values);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_attributes_unref(Gtk.TextAttributes values);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextTagTable gtk_text_tag_table_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_tag_table_add(Gtk.TextTagTable table, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_tag_table_foreach(Gtk.TextTagTable table, System.IntPtr func, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_tag_table_get_size(Gtk.TextTagTable table);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextTag gtk_text_tag_table_lookup(Gtk.TextTagTable table, string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_tag_table_remove(Gtk.TextTagTable table, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextMark gtk_text_mark_new(string name, int left_gravity);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextBuffer gtk_text_mark_get_buffer(Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_mark_get_deleted(Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_mark_get_left_gravity(Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_text_mark_get_name(Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_mark_get_visible(Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_mark_set_visible(Gtk.TextMark mark, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_assign(Gtk.TextIter iter, Gtk.TextIter other);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_char(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_chars(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_cursor_position(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_cursor_positions(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_find_char(Gtk.TextIter iter, System.IntPtr pred, System.IntPtr user_data, Gtk.TextIter limit);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_lines(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_sentence_start(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_sentence_starts(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_to_tag_toggle(Gtk.TextIter iter, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_visible_cursor_position(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_visible_cursor_positions(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_visible_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_visible_lines(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_visible_word_start(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_visible_word_starts(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_word_start(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_backward_word_starts(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_begins_tag(Gtk.TextIter iter, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_can_insert(Gtk.TextIter iter, int default_editability);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_compare(Gtk.TextIter lhs, Gtk.TextIter rhs);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextIter gtk_text_iter_copy(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_editable(Gtk.TextIter iter, int default_setting);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_ends_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_ends_sentence(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_ends_tag(Gtk.TextIter iter, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_ends_word(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_equal(Gtk.TextIter lhs, Gtk.TextIter rhs);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_char(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_chars(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_cursor_position(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_cursor_positions(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_find_char(Gtk.TextIter iter, System.IntPtr pred, System.IntPtr user_data, Gtk.TextIter limit);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_lines(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_sentence_end(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_sentence_ends(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_forward_to_end(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_to_line_end(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_to_tag_toggle(Gtk.TextIter iter, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_visible_cursor_position(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_visible_cursor_positions(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_visible_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_visible_lines(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_visible_word_end(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_visible_word_ends(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_word_end(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_forward_word_ends(Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_free(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextBuffer gtk_text_iter_get_buffer(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_bytes_in_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_text_iter_get_char(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_chars_in_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextChildAnchor gtk_text_iter_get_child_anchor(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.Language gtk_text_iter_get_language(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_line_index(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_line_offset(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_text_iter_get_marks(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_offset(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern GdkPixbuf.Pixbuf gtk_text_iter_get_pixbuf(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_text_iter_get_slice(Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_text_iter_get_tags(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_text_iter_get_text(Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_text_iter_get_toggled_tags(Gtk.TextIter iter, int toggled_on);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_visible_line_index(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_get_visible_line_offset(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_text_iter_get_visible_slice(Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_text_iter_get_visible_text(Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_has_tag(Gtk.TextIter iter, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_in_range(Gtk.TextIter iter, Gtk.TextIter start, Gtk.TextIter end);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_inside_sentence(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_inside_word(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_is_cursor_position(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_is_end(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_is_start(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_order(Gtk.TextIter first, Gtk.TextIter second);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_set_line(Gtk.TextIter iter, int line_number);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_set_line_index(Gtk.TextIter iter, int byte_on_line);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_set_line_offset(Gtk.TextIter iter, int char_on_line);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_set_offset(Gtk.TextIter iter, int char_offset);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_set_visible_line_index(Gtk.TextIter iter, int byte_on_line);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_iter_set_visible_line_offset(Gtk.TextIter iter, int char_on_line);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_starts_line(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_starts_sentence(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_starts_tag(Gtk.TextIter iter, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_starts_word(Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_iter_toggles_tag(Gtk.TextIter iter, Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextTag gtk_text_tag_new(string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_tag_changed(Gtk.TextTag tag, int size_changed);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_tag_event(Gtk.TextTag tag, GObject.Object event_object, System.IntPtr @event, Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_tag_get_priority(Gtk.TextTag tag);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_tag_set_priority(Gtk.TextTag tag, int priority);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextChildAnchor gtk_text_child_anchor_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_child_anchor_get_deleted(Gtk.TextChildAnchor anchor);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_text_child_anchor_get_widgets(Gtk.TextChildAnchor anchor);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_text_view_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_text_view_new_with_buffer(Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_add_child_at_anchor(Gtk.TextView text_view, Gtk.Widget child, Gtk.TextChildAnchor anchor);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_add_child_in_window(Gtk.TextView text_view, Gtk.Widget child, Gtk.TextWindowType which_window, int xpos, int ypos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_backward_display_line(Gtk.TextView text_view, Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_backward_display_line_start(Gtk.TextView text_view, Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_buffer_to_window_coords(Gtk.TextView text_view, Gtk.TextWindowType win, int buffer_x, int buffer_y, System.IntPtr window_x, System.IntPtr window_y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_forward_display_line(Gtk.TextView text_view, Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_forward_display_line_end(Gtk.TextView text_view, Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_accepts_tab(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_border_window_size(Gtk.TextView text_view, Gtk.TextWindowType type);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_bottom_margin(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextBuffer gtk_text_view_get_buffer(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_cursor_visible(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextAttributes gtk_text_view_get_default_attributes(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_editable(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_text_view_get_hadjustment(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_indent(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.InputHints gtk_text_view_get_input_hints(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.InputPurpose gtk_text_view_get_input_purpose(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Justification gtk_text_view_get_justification(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_left_margin(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_get_line_yrange(Gtk.TextView text_view, Gtk.TextIter iter, System.IntPtr y, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_monospace(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_overwrite(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_pixels_above_lines(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_pixels_below_lines(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_pixels_inside_wrap(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_right_margin(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.TabArray gtk_text_view_get_tabs(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_get_top_margin(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_text_view_get_vadjustment(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_text_view_get_window(Gtk.TextView text_view, Gtk.TextWindowType win);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextWindowType gtk_text_view_get_window_type(Gtk.TextView text_view, Gdk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WrapMode gtk_text_view_get_wrap_mode(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_im_context_filter_keypress(Gtk.TextView text_view, Gdk.EventKey @event);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_move_child(Gtk.TextView text_view, Gtk.Widget child, int xpos, int ypos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_move_mark_onscreen(Gtk.TextView text_view, Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_move_visually(Gtk.TextView text_view, Gtk.TextIter iter, int count);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_place_cursor_onscreen(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_reset_cursor_blink(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_reset_im_context(Gtk.TextView text_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_scroll_mark_onscreen(Gtk.TextView text_view, Gtk.TextMark mark);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_scroll_to_iter(Gtk.TextView text_view, Gtk.TextIter iter, double within_margin, int use_align, double xalign, double yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_scroll_to_mark(Gtk.TextView text_view, Gtk.TextMark mark, double within_margin, int use_align, double xalign, double yalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_accepts_tab(Gtk.TextView text_view, int accepts_tab);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_border_window_size(Gtk.TextView text_view, Gtk.TextWindowType type, int size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_bottom_margin(Gtk.TextView text_view, int bottom_margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_buffer(Gtk.TextView text_view, Gtk.TextBuffer buffer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_cursor_visible(Gtk.TextView text_view, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_editable(Gtk.TextView text_view, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_indent(Gtk.TextView text_view, int indent);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_input_hints(Gtk.TextView text_view, Gtk.InputHints hints);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_input_purpose(Gtk.TextView text_view, Gtk.InputPurpose purpose);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_justification(Gtk.TextView text_view, Gtk.Justification justification);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_left_margin(Gtk.TextView text_view, int left_margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_monospace(Gtk.TextView text_view, int monospace);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_overwrite(Gtk.TextView text_view, int overwrite);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_pixels_above_lines(Gtk.TextView text_view, int pixels_above_lines);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_pixels_below_lines(Gtk.TextView text_view, int pixels_below_lines);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_pixels_inside_wrap(Gtk.TextView text_view, int pixels_inside_wrap);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_right_margin(Gtk.TextView text_view, int right_margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_tabs(Gtk.TextView text_view, Pango.TabArray tabs);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_top_margin(Gtk.TextView text_view, int top_margin);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_set_wrap_mode(Gtk.TextView text_view, Gtk.WrapMode wrap_mode);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_text_view_starts_display_line(Gtk.TextView text_view, Gtk.TextIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_text_view_window_to_buffer_coords(Gtk.TextView text_view, Gtk.TextWindowType win, int window_x, int window_y, System.IntPtr buffer_x, System.IntPtr buffer_y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ThemingEngine gtk_theming_engine_load(string name);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_theming_engine_register_property(string name_space, System.IntPtr parse_func, GObject.ParamSpec pspec);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TextDirection gtk_theming_engine_get_direction(Gtk.ThemingEngine engine);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.FontDescription gtk_theming_engine_get_font(Gtk.ThemingEngine engine, Gtk.StateFlags state);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.JunctionSides gtk_theming_engine_get_junction_sides(Gtk.ThemingEngine engine);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WidgetPath gtk_theming_engine_get_path(Gtk.ThemingEngine engine);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Screen gtk_theming_engine_get_screen(Gtk.ThemingEngine engine);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.StateFlags gtk_theming_engine_get_state(Gtk.ThemingEngine engine);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_theming_engine_has_class(Gtk.ThemingEngine engine, string style_class);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_theming_engine_has_region(Gtk.ThemingEngine engine, string style_region, out Gtk.RegionFlags flags);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_theming_engine_state_is_running(Gtk.ThemingEngine engine, Gtk.StateType state, System.IntPtr progress);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.EllipsizeMode gtk_tool_shell_get_ellipsize_mode(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_shell_get_icon_size(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Orientation gtk_tool_shell_get_orientation(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ReliefStyle gtk_tool_shell_get_relief_style(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolbarStyle gtk_tool_shell_get_style(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern float gtk_tool_shell_get_text_alignment(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Orientation gtk_tool_shell_get_text_orientation(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SizeGroup gtk_tool_shell_get_text_size_group(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_shell_rebuild_menu(Gtk.ToolShell shell);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_item_group_new(string label);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_group_get_collapsed(Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_tool_item_group_get_drop_item(Gtk.ToolItemGroup group, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern Pango.EllipsizeMode gtk_tool_item_group_get_ellipsize(Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ReliefStyle gtk_tool_item_group_get_header_relief(Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_item_group_get_item_position(Gtk.ToolItemGroup group, Gtk.ToolItem item);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_tool_item_group_get_label(Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_item_group_get_label_widget(Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_tool_item_group_get_n_items(Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_tool_item_group_get_nth_item(Gtk.ToolItemGroup group, uint index);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_group_insert(Gtk.ToolItemGroup group, Gtk.ToolItem item, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_group_set_collapsed(Gtk.ToolItemGroup group, int collapsed);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_group_set_ellipsize(Gtk.ToolItemGroup group, Pango.EllipsizeMode ellipsize);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_group_set_header_relief(Gtk.ToolItemGroup group, Gtk.ReliefStyle style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_group_set_item_position(Gtk.ToolItemGroup group, Gtk.ToolItem item, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_group_set_label(Gtk.ToolItemGroup group, string label);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_item_group_set_label_widget(Gtk.ToolItemGroup group, Gtk.Widget label_widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_palette_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetEntry gtk_tool_palette_get_drag_target_group();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TargetEntry gtk_tool_palette_get_drag_target_item();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_add_drag_dest(Gtk.ToolPalette palette, Gtk.Widget widget, Gtk.DestDefaults flags, Gtk.ToolPaletteDragTargets targets, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tool_palette_get_drag_item(Gtk.ToolPalette palette, Gtk.SelectionData selection);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItemGroup gtk_tool_palette_get_drop_group(Gtk.ToolPalette palette, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_tool_palette_get_drop_item(Gtk.ToolPalette palette, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_palette_get_exclusive(Gtk.ToolPalette palette, Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_palette_get_expand(Gtk.ToolPalette palette, Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_palette_get_group_position(Gtk.ToolPalette palette, Gtk.ToolItemGroup group);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_tool_palette_get_hadjustment(Gtk.ToolPalette palette);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tool_palette_get_icon_size(Gtk.ToolPalette palette);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolbarStyle gtk_tool_palette_get_style(Gtk.ToolPalette palette);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_tool_palette_get_vadjustment(Gtk.ToolPalette palette);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_set_drag_source(Gtk.ToolPalette palette, Gtk.ToolPaletteDragTargets targets);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_set_exclusive(Gtk.ToolPalette palette, Gtk.ToolItemGroup group, int exclusive);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_set_expand(Gtk.ToolPalette palette, Gtk.ToolItemGroup group, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_set_group_position(Gtk.ToolPalette palette, Gtk.ToolItemGroup group, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_set_icon_size(Gtk.ToolPalette palette, int icon_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_set_style(Gtk.ToolPalette palette, Gtk.ToolbarStyle style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_unset_icon_size(Gtk.ToolPalette palette);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tool_palette_unset_style(Gtk.ToolPalette palette);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_toolbar_new();
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toolbar_get_drop_index(Gtk.Toolbar toolbar, int x, int y);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.IconSize gtk_toolbar_get_icon_size(Gtk.Toolbar toolbar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toolbar_get_item_index(Gtk.Toolbar toolbar, Gtk.ToolItem item);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toolbar_get_n_items(Gtk.Toolbar toolbar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolItem gtk_toolbar_get_nth_item(Gtk.Toolbar toolbar, int n);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ReliefStyle gtk_toolbar_get_relief_style(Gtk.Toolbar toolbar);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_toolbar_get_show_arrow(Gtk.Toolbar toolbar);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ToolbarStyle gtk_toolbar_get_style(Gtk.Toolbar toolbar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toolbar_insert(Gtk.Toolbar toolbar, Gtk.ToolItem item, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toolbar_set_drop_highlight_item(Gtk.Toolbar toolbar, Gtk.ToolItem tool_item, int index_);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toolbar_set_icon_size(Gtk.Toolbar toolbar, Gtk.IconSize icon_size);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toolbar_set_show_arrow(Gtk.Toolbar toolbar, int show_arrow);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toolbar_set_style(Gtk.Toolbar toolbar, Gtk.ToolbarStyle style);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toolbar_unset_icon_size(Gtk.Toolbar toolbar);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_toolbar_unset_style(Gtk.Toolbar toolbar);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_toplevel_accessible_get_children(Gtk.ToplevelAccessible accessible);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeViewColumn gtk_tree_view_column_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeViewColumn gtk_tree_view_column_new_with_area(Gtk.CellArea area);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_add_attribute(Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell_renderer, string attribute, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_cell_get_position(Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell_renderer, System.IntPtr x_offset, System.IntPtr width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_cell_get_size(Gtk.TreeViewColumn tree_column, Gdk.Rectangle cell_area, System.IntPtr x_offset, System.IntPtr y_offset, System.IntPtr width, System.IntPtr height);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_cell_is_visible(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_cell_set_cell_data(Gtk.TreeViewColumn tree_column, Gtk.TreeModel tree_model, Gtk.TreeIter iter, int is_expander, int is_expanded);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_clear(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_clear_attributes(Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell_renderer);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_clicked(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_focus_cell(Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern float gtk_tree_view_column_get_alignment(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tree_view_column_get_button(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_clickable(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_expand(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_fixed_width(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_max_width(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_min_width(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_reorderable(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_resizable(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeViewColumnSizing gtk_tree_view_column_get_sizing(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_sort_column_id(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_sort_indicator(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SortType gtk_tree_view_column_get_sort_order(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_spacing(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_tree_view_column_get_title(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tree_view_column_get_tree_view(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_visible(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tree_view_column_get_widget(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_width(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_column_get_x_offset(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_pack_end(Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_pack_start(Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_queue_resize(Gtk.TreeViewColumn tree_column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_alignment(Gtk.TreeViewColumn tree_column, float xalign);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_cell_data_func(Gtk.TreeViewColumn tree_column, Gtk.CellRenderer cell_renderer, System.IntPtr func, System.IntPtr func_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_clickable(Gtk.TreeViewColumn tree_column, int clickable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_expand(Gtk.TreeViewColumn tree_column, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_fixed_width(Gtk.TreeViewColumn tree_column, int fixed_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_max_width(Gtk.TreeViewColumn tree_column, int max_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_min_width(Gtk.TreeViewColumn tree_column, int min_width);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_reorderable(Gtk.TreeViewColumn tree_column, int reorderable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_resizable(Gtk.TreeViewColumn tree_column, int resizable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_sizing(Gtk.TreeViewColumn tree_column, Gtk.TreeViewColumnSizing type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_sort_column_id(Gtk.TreeViewColumn tree_column, int sort_column_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_sort_indicator(Gtk.TreeViewColumn tree_column, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_sort_order(Gtk.TreeViewColumn tree_column, Gtk.SortType order);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_spacing(Gtk.TreeViewColumn tree_column, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_title(Gtk.TreeViewColumn tree_column, string title);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_visible(Gtk.TreeViewColumn tree_column, int visible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_column_set_widget(Gtk.TreeViewColumn tree_column, Gtk.Widget widget);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tree_view_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_tree_view_new_with_model(Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_append_column(Gtk.TreeView tree_view, Gtk.TreeViewColumn column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_collapse_all(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_collapse_row(Gtk.TreeView tree_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_columns_autosize(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_convert_bin_window_to_tree_coords(Gtk.TreeView tree_view, int bx, int by, System.IntPtr tx, System.IntPtr ty);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_convert_bin_window_to_widget_coords(Gtk.TreeView tree_view, int bx, int by, System.IntPtr wx, System.IntPtr wy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_convert_tree_to_bin_window_coords(Gtk.TreeView tree_view, int tx, int ty, System.IntPtr bx, System.IntPtr by);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_convert_tree_to_widget_coords(Gtk.TreeView tree_view, int tx, int ty, System.IntPtr wx, System.IntPtr wy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_convert_widget_to_bin_window_coords(Gtk.TreeView tree_view, int wx, int wy, System.IntPtr bx, System.IntPtr by);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_convert_widget_to_tree_coords(Gtk.TreeView tree_view, int wx, int wy, System.IntPtr tx, System.IntPtr ty);
		[DllImport("libgtk-3.so.0")]
		public static extern cairo.Surface gtk_tree_view_create_row_drag_icon(Gtk.TreeView tree_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_enable_model_drag_dest(Gtk.TreeView tree_view, System.IntPtr targets, int n_targets, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_enable_model_drag_source(Gtk.TreeView tree_view, Gdk.ModifierType start_button_mask, System.IntPtr targets, int n_targets, Gdk.DragAction actions);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_expand_all(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_expand_row(Gtk.TreeView tree_view, Gtk.TreePath path, int open_all);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_expand_to_path(Gtk.TreeView tree_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_activate_on_single_click(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_tree_view_get_bin_window(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeViewColumn gtk_tree_view_get_column(Gtk.TreeView tree_view, int n);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_view_get_columns(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_get_cursor(Gtk.TreeView tree_view, out Gtk.TreePath path, out Gtk.TreeViewColumn focus_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_dest_row_at_pos(Gtk.TreeView tree_view, int drag_x, int drag_y, out Gtk.TreePath path, out Gtk.TreeViewDropPosition pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_get_drag_dest_row(Gtk.TreeView tree_view, out Gtk.TreePath path, out Gtk.TreeViewDropPosition pos);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_enable_search(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_enable_tree_lines(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeViewColumn gtk_tree_view_get_expander_column(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_fixed_height_mode(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeViewGridLines gtk_tree_view_get_grid_lines(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_tree_view_get_hadjustment(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_headers_clickable(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_headers_visible(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_hover_expand(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_hover_selection(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_level_indentation(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_tree_view_get_model(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_tree_view_get_n_columns(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_path_at_pos(Gtk.TreeView tree_view, int x, int y, out Gtk.TreePath path, out Gtk.TreeViewColumn column, System.IntPtr cell_x, System.IntPtr cell_y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_reorderable(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_view_get_row_separator_func(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_rubber_banding(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_rules_hint(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_search_column(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Entry gtk_tree_view_get_search_entry(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_view_get_search_equal_func(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_view_get_search_position_func(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeSelection gtk_tree_view_get_selection(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_show_expanders(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_tooltip_column(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_tree_view_get_vadjustment(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_get_visible_range(Gtk.TreeView tree_view, out Gtk.TreePath start_path, out Gtk.TreePath end_path);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_insert_column(Gtk.TreeView tree_view, Gtk.TreeViewColumn column, int position);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_insert_column_with_data_func(Gtk.TreeView tree_view, int position, string title, Gtk.CellRenderer cell, System.IntPtr func, System.IntPtr data, System.IntPtr dnotify);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_is_blank_at_pos(Gtk.TreeView tree_view, int x, int y, out Gtk.TreePath path, out Gtk.TreeViewColumn column, System.IntPtr cell_x, System.IntPtr cell_y);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_is_rubber_banding_active(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_map_expanded_rows(Gtk.TreeView tree_view, System.IntPtr func, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_move_column_after(Gtk.TreeView tree_view, Gtk.TreeViewColumn column, Gtk.TreeViewColumn base_column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_remove_column(Gtk.TreeView tree_view, Gtk.TreeViewColumn column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_row_activated(Gtk.TreeView tree_view, Gtk.TreePath path, Gtk.TreeViewColumn column);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_view_row_expanded(Gtk.TreeView tree_view, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_scroll_to_cell(Gtk.TreeView tree_view, Gtk.TreePath path, Gtk.TreeViewColumn column, int use_align, float row_align, float col_align);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_scroll_to_point(Gtk.TreeView tree_view, int tree_x, int tree_y);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_activate_on_single_click(Gtk.TreeView tree_view, int single);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_column_drag_function(Gtk.TreeView tree_view, System.IntPtr func, System.IntPtr user_data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_cursor(Gtk.TreeView tree_view, Gtk.TreePath path, Gtk.TreeViewColumn focus_column, int start_editing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_cursor_on_cell(Gtk.TreeView tree_view, Gtk.TreePath path, Gtk.TreeViewColumn focus_column, Gtk.CellRenderer focus_cell, int start_editing);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_destroy_count_func(Gtk.TreeView tree_view, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_drag_dest_row(Gtk.TreeView tree_view, Gtk.TreePath path, Gtk.TreeViewDropPosition pos);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_enable_search(Gtk.TreeView tree_view, int enable_search);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_enable_tree_lines(Gtk.TreeView tree_view, int enabled);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_expander_column(Gtk.TreeView tree_view, Gtk.TreeViewColumn column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_fixed_height_mode(Gtk.TreeView tree_view, int enable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_grid_lines(Gtk.TreeView tree_view, Gtk.TreeViewGridLines grid_lines);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_hadjustment(Gtk.TreeView tree_view, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_headers_clickable(Gtk.TreeView tree_view, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_headers_visible(Gtk.TreeView tree_view, int headers_visible);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_hover_expand(Gtk.TreeView tree_view, int expand);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_hover_selection(Gtk.TreeView tree_view, int hover);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_level_indentation(Gtk.TreeView tree_view, int indentation);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_model(Gtk.TreeView tree_view, Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_reorderable(Gtk.TreeView tree_view, int reorderable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_row_separator_func(Gtk.TreeView tree_view, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_rubber_banding(Gtk.TreeView tree_view, int enable);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_rules_hint(Gtk.TreeView tree_view, int setting);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_search_column(Gtk.TreeView tree_view, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_search_entry(Gtk.TreeView tree_view, Gtk.Entry entry);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_search_equal_func(Gtk.TreeView tree_view, System.IntPtr search_equal_func, System.IntPtr search_user_data, System.IntPtr search_destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_search_position_func(Gtk.TreeView tree_view, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_show_expanders(Gtk.TreeView tree_view, int enabled);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_tooltip_cell(Gtk.TreeView tree_view, Gtk.Tooltip tooltip, Gtk.TreePath path, Gtk.TreeViewColumn column, Gtk.CellRenderer cell);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_tooltip_column(Gtk.TreeView tree_view, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_tooltip_row(Gtk.TreeView tree_view, Gtk.Tooltip tooltip, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_set_vadjustment(Gtk.TreeView tree_view, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_unset_rows_drag_dest(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_view_unset_rows_drag_source(Gtk.TreeView tree_view);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_filter_clear_cache(Gtk.TreeModelFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_model_filter_convert_child_path_to_path(Gtk.TreeModelFilter filter, Gtk.TreePath child_path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_model_filter_convert_path_to_child_path(Gtk.TreeModelFilter filter, Gtk.TreePath filter_path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_tree_model_filter_get_model(Gtk.TreeModelFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_filter_refilter(Gtk.TreeModelFilter filter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_filter_set_modify_func(Gtk.TreeModelFilter filter, int n_columns, System.IntPtr types, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_filter_set_visible_column(Gtk.TreeModelFilter filter, int column);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_filter_set_visible_func(Gtk.TreeModelFilter filter, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_sort_clear_cache(Gtk.TreeModelSort tree_model_sort);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_model_sort_convert_child_path_to_path(Gtk.TreeModelSort tree_model_sort, Gtk.TreePath child_path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_model_sort_convert_path_to_child_path(Gtk.TreeModelSort tree_model_sort, Gtk.TreePath sorted_path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_tree_model_sort_get_model(Gtk.TreeModelSort tree_model);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_model_sort_iter_is_valid(Gtk.TreeModelSort tree_model_sort, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_model_sort_reset_default_sort_func(Gtk.TreeModelSort tree_model_sort);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeRowReference gtk_tree_row_reference_new(Gtk.TreeModel model, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeRowReference gtk_tree_row_reference_new_proxy(GObject.Object proxy, Gtk.TreeModel model, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeRowReference gtk_tree_row_reference_copy(Gtk.TreeRowReference reference);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_row_reference_free(Gtk.TreeRowReference reference);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeModel gtk_tree_row_reference_get_model(Gtk.TreeRowReference reference);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreePath gtk_tree_row_reference_get_path(Gtk.TreeRowReference reference);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_row_reference_valid(Gtk.TreeRowReference reference);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_row_reference_deleted(GObject.Object proxy, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_row_reference_inserted(GObject.Object proxy, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_row_reference_reordered(GObject.Object proxy, Gtk.TreePath path, Gtk.TreeIter iter, System.IntPtr new_order);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_selection_count_selected_rows(Gtk.TreeSelection selection);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.SelectionMode gtk_tree_selection_get_mode(Gtk.TreeSelection selection);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_selection_get_select_function(Gtk.TreeSelection selection);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_selection_get_selected_rows(Gtk.TreeSelection selection, out Gtk.TreeModel model);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeView gtk_tree_selection_get_tree_view(Gtk.TreeSelection selection);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_tree_selection_get_user_data(Gtk.TreeSelection selection);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_selection_iter_is_selected(Gtk.TreeSelection selection, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_selection_path_is_selected(Gtk.TreeSelection selection, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_select_all(Gtk.TreeSelection selection);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_select_iter(Gtk.TreeSelection selection, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_select_path(Gtk.TreeSelection selection, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_select_range(Gtk.TreeSelection selection, Gtk.TreePath start_path, Gtk.TreePath end_path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_selected_foreach(Gtk.TreeSelection selection, System.IntPtr func, System.IntPtr data);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_set_mode(Gtk.TreeSelection selection, Gtk.SelectionMode type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_set_select_function(Gtk.TreeSelection selection, System.IntPtr func, System.IntPtr data, System.IntPtr destroy);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_unselect_all(Gtk.TreeSelection selection);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_unselect_iter(Gtk.TreeSelection selection, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_unselect_path(Gtk.TreeSelection selection, Gtk.TreePath path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_selection_unselect_range(Gtk.TreeSelection selection, Gtk.TreePath start_path, Gtk.TreePath end_path);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.TreeStore gtk_tree_store_newv(int n_columns, System.IntPtr types);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_clear(Gtk.TreeStore tree_store);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_store_is_ancestor(Gtk.TreeStore tree_store, Gtk.TreeIter iter, Gtk.TreeIter descendant);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_store_iter_depth(Gtk.TreeStore tree_store, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_store_iter_is_valid(Gtk.TreeStore tree_store, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_move_after(Gtk.TreeStore tree_store, Gtk.TreeIter iter, Gtk.TreeIter position);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_move_before(Gtk.TreeStore tree_store, Gtk.TreeIter iter, Gtk.TreeIter position);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_tree_store_remove(Gtk.TreeStore tree_store, Gtk.TreeIter iter);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_reorder(Gtk.TreeStore tree_store, Gtk.TreeIter parent, System.IntPtr new_order);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_set_column_types(Gtk.TreeStore tree_store, int n_columns, System.IntPtr types);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_set_value(Gtk.TreeStore tree_store, Gtk.TreeIter iter, int column, GObject.Value value);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_set_valuesv(Gtk.TreeStore tree_store, Gtk.TreeIter iter, System.IntPtr columns, System.IntPtr values, int n_values);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_tree_store_swap(Gtk.TreeStore tree_store, Gtk.TreeIter a, Gtk.TreeIter b);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.UIManager gtk_ui_manager_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_ui_manager_add_ui(Gtk.UIManager manager, uint merge_id, string path, string name, string action, Gtk.UIManagerItemType type, int top);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_ui_manager_add_ui_from_file(Gtk.UIManager manager, System.IntPtr filename, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_ui_manager_add_ui_from_resource(Gtk.UIManager manager, string resource_path, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_ui_manager_add_ui_from_string(Gtk.UIManager manager, string buffer, long length, out GLib.Error error);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_ui_manager_ensure_update(Gtk.UIManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.AccelGroup gtk_ui_manager_get_accel_group(Gtk.UIManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Action gtk_ui_manager_get_action(Gtk.UIManager manager, string path);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_ui_manager_get_action_groups(Gtk.UIManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern int gtk_ui_manager_get_add_tearoffs(Gtk.UIManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_ui_manager_get_toplevels(Gtk.UIManager manager, Gtk.UIManagerItemType types);
		[DllImport("libgtk-3.so.0")]
		public static extern string gtk_ui_manager_get_ui(Gtk.UIManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_ui_manager_get_widget(Gtk.UIManager manager, string path);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_ui_manager_insert_action_group(Gtk.UIManager manager, Gtk.ActionGroup action_group, int pos);
		[DllImport("libgtk-3.so.0")]
		public static extern uint gtk_ui_manager_new_merge_id(Gtk.UIManager manager);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_ui_manager_remove_action_group(Gtk.UIManager manager, Gtk.ActionGroup action_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_ui_manager_remove_ui(Gtk.UIManager manager, uint merge_id);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_ui_manager_set_add_tearoffs(Gtk.UIManager manager, int add_tearoffs);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_vbox_new(int homogeneous, int spacing);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_vbutton_box_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_vpaned_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_vscale_new(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_vscale_new_with_range(double min, double max, double step);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_vscrollbar_new(Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_vseparator_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_viewport_new(Gtk.Adjustment hadjustment, Gtk.Adjustment vadjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_viewport_get_bin_window(Gtk.Viewport viewport);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_viewport_get_hadjustment(Gtk.Viewport viewport);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.ShadowType gtk_viewport_get_shadow_type(Gtk.Viewport viewport);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Adjustment gtk_viewport_get_vadjustment(Gtk.Viewport viewport);
		[DllImport("libgtk-3.so.0")]
		public static extern Gdk.Window gtk_viewport_get_view_window(Gtk.Viewport viewport);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_viewport_set_hadjustment(Gtk.Viewport viewport, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_viewport_set_shadow_type(Gtk.Viewport viewport, Gtk.ShadowType type);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_viewport_set_vadjustment(Gtk.Viewport viewport, Gtk.Adjustment adjustment);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_volume_button_new();
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.WindowGroup gtk_window_group_new();
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_group_add_window(Gtk.WindowGroup window_group, Gtk.Window window);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_window_group_get_current_device_grab(Gtk.WindowGroup window_group, Gdk.Device device);
		[DllImport("libgtk-3.so.0")]
		public static extern Gtk.Widget gtk_window_group_get_current_grab(Gtk.WindowGroup window_group);
		[DllImport("libgtk-3.so.0")]
		public static extern System.IntPtr gtk_window_group_list_windows(Gtk.WindowGroup window_group);
		[DllImport("libgtk-3.so.0")]
		public static extern void gtk_window_group_remove_window(Gtk.WindowGroup window_group, Gtk.Window window);
	}
}
