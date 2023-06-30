using System;
using System.Runtime.InteropServices;

namespace WaiteAnimation1S.AddInLib
{
	[Guid("06041030-913C-44cc-B4E9-8094E18FB95D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAsyncEvent
	{
		void SetEventBufferDepth(int lDepth);
		void GetEventBufferDepth(ref int plDepth);
		void ExternalEvent(string bstrSource, string bstrMessage, string bstrData);
		void CleanBuffer();
	}
}
