using System;
using System.Runtime.InteropServices;

namespace WaiteAnimation1S.AddInLib
{
	[Guid("B790740A-83FC-4f6c-A491-A215A5DBD60A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ILanguageExtender
	{
		void RegisterExtensionAs(ref string bstrExtensionName);
		void GetNProps(ref int plProps);
		void FindProp(string bstrPropName, ref int plPropNum);
		void GetPropName(int lPropNum, int lPropAlias, ref string pbstrPropName);
		void GetPropVal(int lPropNum, ref object pvarPropVal);
		void SetPropVal(int lPropNum, ref object varPropVal);
		void IsPropReadable(int lPropNum, ref bool pboolPropRead);
		void IsPropWritable(int lPropNum, ref bool pboolPropWrite);
		void GetNMethods(ref int plMethods);
		void FindMethod(string bstrMethodName, ref int plMethodNum);
		void GetMethodName(int lMethodNum, int lMethodAlias, ref string pbstrMethodName);
		void GetNParams(int lMethodNum, ref int plParams);
		void GetParamDefValue(int lMethodNum, int lParamNum, ref object pvarParamDefValue);
		void HasRetVal(int lMethodNum, ref bool pboolRetValue);
		void CallAsProc(int lMethodNum, [MarshalAs(UnmanagedType.SafeArray)] ref System.Array paParams);
		void CallAsFunc(int lMethodNum, ref object pvarRetValue, [MarshalAs(UnmanagedType.SafeArray)] ref System.Array paParam);
	}
}