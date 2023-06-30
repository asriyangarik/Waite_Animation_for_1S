using System;
using System.Runtime.InteropServices;

namespace WaiteAnimation1S.AddInLib
{
	[Guid("965FE5B0-6770-41cf-934F-C7301F77911F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IInitDone
	{
		void Init([MarshalAs(UnmanagedType.IDispatch)] object pConnection);
		void Done();
		void GetInfo(ref object pInfo);
	}
}