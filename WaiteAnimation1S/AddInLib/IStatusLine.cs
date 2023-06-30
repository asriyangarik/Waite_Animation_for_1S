using System;
using System.Runtime.InteropServices;

namespace WaiteAnimation1S.AddInLib
{
	[Guid("18B016DF-599D-472d-A350-5BD8557EB814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IStatusLine
	{
		void SetStatusLine(string bstrStatusLine);
		void ResetStatusLine();
	}
}