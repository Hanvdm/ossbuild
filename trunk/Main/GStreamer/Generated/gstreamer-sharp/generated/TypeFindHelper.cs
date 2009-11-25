// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TypeFindHelper {

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper(IntPtr src, ulong size);

		public static Gst.Caps TypeFind(Gst.Pad src, ulong size) {
			IntPtr raw_ret = gst_type_find_helper(src == null ? IntPtr.Zero : src.Handle, size);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_for_buffer(IntPtr obj, IntPtr buf, out int prob);

		public static Gst.Caps TypeFind(Gst.Object obj, Gst.Buffer buf, out Gst.TypeFindProbability prob) {
			int native_prob;
			IntPtr raw_ret = gst_type_find_helper_for_buffer(obj == null ? IntPtr.Zero : obj.Handle, buf == null ? IntPtr.Zero : buf.Handle, out native_prob);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_for_extension(IntPtr obj, IntPtr extension);

		public static Gst.Caps TypeFind(Gst.Object obj, string extension) {
			IntPtr native_extension = Gst.GLib.Marshaller.StringToPtrGStrdup (extension);
			IntPtr raw_ret = gst_type_find_helper_for_extension(obj == null ? IntPtr.Zero : obj.Handle, native_extension);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			Gst.GLib.Marshaller.Free (native_extension);
			return ret;
		}

		[DllImport("libgstbase-0.10.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_get_range(IntPtr obj, Gst.BaseSharp.TypeFindHelperGetRangeFunctionNative func, ulong size, out int prob);

		public static Gst.Caps TypeFind(Gst.Object obj, Gst.Base.TypeFindHelperGetRangeFunction func, ulong size, out Gst.TypeFindProbability prob) {
			Gst.BaseSharp.TypeFindHelperGetRangeFunctionWrapper func_wrapper = new Gst.BaseSharp.TypeFindHelperGetRangeFunctionWrapper (func);
			int native_prob;
			IntPtr raw_ret = gst_type_find_helper_get_range(obj == null ? IntPtr.Zero : obj.Handle, func_wrapper.NativeDelegate, size, out native_prob);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) Gst.GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

#endregion
	}
}
