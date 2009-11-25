// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoRectangle {

		public int X;
		public int Y;
		public int W;
		public int H;

		public static Gst.Video.VideoRectangle Zero = new Gst.Video.VideoRectangle ();

		public static Gst.Video.VideoRectangle New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoRectangle.Zero;
			return (Gst.Video.VideoRectangle) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoRectangle));
		}

		private static Gst.GLib.GType GType {
			get { return Gst.GLib.GType.Pointer; }
		}
#endregion
	}
}
