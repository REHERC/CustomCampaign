#pragma warning disable RCS1110
using System;
using System.Runtime.InteropServices;
using System.Text;

public static class NativeMethods
{
    [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
    internal static extern Int32 StrFormatByteSize(long fileSize, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder buffer, int bufferSize);
}
