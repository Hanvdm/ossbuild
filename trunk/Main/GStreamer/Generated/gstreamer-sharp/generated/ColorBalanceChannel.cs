// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Interfaces {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ColorBalanceChannel : Gst.GLib.Object {

		public ColorBalanceChannel(IntPtr raw) : base(raw) {}

		protected ColorBalanceChannel() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new Gst.GLib.Value [0]);
		}

		[DllImport ("gstreamersharpglue-0.10.dll")]
		extern static uint gst__interfacessharp_gst__interfaces_colorbalancechannel_get_max_value_offset ();

		static uint max_value_offset = gst__interfacessharp_gst__interfaces_colorbalancechannel_get_max_value_offset ();
		public int MaxValue {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + max_value_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport ("gstreamersharpglue-0.10.dll")]
		extern static uint gst__interfacessharp_gst__interfaces_colorbalancechannel_get_label_offset ();

		static uint label_offset = gst__interfacessharp_gst__interfaces_colorbalancechannel_get_label_offset ();
		public string Label {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + label_offset);
					return Gst.GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
		}

		[DllImport ("gstreamersharpglue-0.10.dll")]
		extern static uint gst__interfacessharp_gst__interfaces_colorbalancechannel_get_min_value_offset ();

		static uint min_value_offset = gst__interfacessharp_gst__interfaces_colorbalancechannel_get_min_value_offset ();
		public int MinValue {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + min_value_offset);
					return (*raw_ptr);
				}
			}
		}

		[Gst.GLib.Signal("value-changed")]
		public event Gst.Interfaces.ValueChangedHandler ValueChanged {
			add {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "value-changed", typeof (Gst.Interfaces.ValueChangedArgs));
				sig.AddDelegate (value);
			}
			remove {
				Gst.GLib.Signal sig = Gst.GLib.Signal.Lookup (this, "value-changed", typeof (Gst.Interfaces.ValueChangedArgs));
				sig.RemoveDelegate (value);
			}
		}

		static ValueChangedNativeDelegate ValueChanged_cb_delegate;
		static ValueChangedNativeDelegate ValueChangedVMCallback {
			get {
				if (ValueChanged_cb_delegate == null)
					ValueChanged_cb_delegate = new ValueChangedNativeDelegate (ValueChanged_cb);
				return ValueChanged_cb_delegate;
			}
		}

		static void OverrideValueChanged (Gst.GLib.GType gtype)
		{
			OverrideValueChanged (gtype, ValueChangedVMCallback);
		}

		static void OverrideValueChanged (Gst.GLib.GType gtype, ValueChangedNativeDelegate callback)
		{
			GstColorBalanceChannelClass class_iface = GetClassStruct (gtype, false);
			class_iface.ValueChanged = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ValueChangedNativeDelegate (IntPtr inst, int value);

		static void ValueChanged_cb (IntPtr inst, int value)
		{
			try {
				ColorBalanceChannel __obj = Gst.GLib.Object.GetObject (inst, false) as ColorBalanceChannel;
				__obj.OnValueChanged (value);
			} catch (Exception e) {
				Gst.GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[Gst.GLib.DefaultSignalHandler(Type=typeof(Gst.Interfaces.ColorBalanceChannel), ConnectionMethod="OverrideValueChanged")]
		protected virtual void OnValueChanged (int value)
		{
			InternalValueChanged (value);
		}

		private void InternalValueChanged (int value)
		{
			ValueChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ValueChanged;
			if (unmanaged == null) return;

			unmanaged (this.Handle, value);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GstColorBalanceChannelClass {
			public ValueChangedNativeDelegate ValueChanged;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			public IntPtr[] GstReserved;
		}

		static uint class_offset = ((Gst.GLib.GType) typeof (Gst.GLib.Object)).GetClassSize ();
		static Hashtable class_structs;

		static GstColorBalanceChannelClass GetClassStruct (Gst.GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Hashtable ();

			if (use_cache && class_structs.Contains (gtype))
				return (GstColorBalanceChannelClass) class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GstColorBalanceChannelClass class_struct = (GstColorBalanceChannelClass) Marshal.PtrToStructure (class_ptr, typeof (GstColorBalanceChannelClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (Gst.GLib.GType gtype, GstColorBalanceChannelClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgstinterfaces-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_color_balance_channel_get_type();

		public static new Gst.GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_color_balance_channel_get_type();
				Gst.GLib.GType ret = new Gst.GLib.GType(raw_ret);
				return ret;
			}
		}


		static ColorBalanceChannel ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}
#endregion
#region Customized extensions
#line 1 "ColorBalanceChannel.custom"
public ColorBalanceChannel (string label, int min, int max) : this () {
  unsafe {
    int* raw_ptr = (int*) ( ( (byte*) Handle) + max_value_offset);
    *raw_ptr = max;
  }
  unsafe {
    IntPtr* raw_ptr = (IntPtr*) ( ( (byte*) Handle) + label_offset);
    *raw_ptr = Gst.GLib.Marshaller.StringToPtrGStrdup (label);
  }
  unsafe {
    int* raw_ptr = (int*) ( ( (byte*) Handle) + min_value_offset);
    *raw_ptr = min;
  }
}

#endregion
	}
}
