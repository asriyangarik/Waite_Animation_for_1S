using System;
using System.Runtime.InteropServices;

namespace WaiteAnimation1S.AddInLib
{
	[Guid("BC536C35-F277-4004-AD50-0E678D756D4F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IErrorLog
	{
		void AddError(string pszPropName, ExcepInfo pExepInfo);
	}
	//----------------------------------------------------------
	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode, Pack=8)]
	public struct ExcepInfo
	{
		public short wCode;
		public short wReserved;
		[MarshalAs(UnmanagedType.BStr)] public string bstrSource;
        [MarshalAs(UnmanagedType.BStr)] public string bstrDescription;
		[MarshalAs(UnmanagedType.BStr)] public string bstrHelpFile;
		public int dwHelpContext;
		public System.IntPtr pvReserved;
		public System.IntPtr pfnDereffered;
		public int scode;
	}
}