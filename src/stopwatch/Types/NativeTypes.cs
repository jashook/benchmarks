namespace ev30
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    internal struct LargeInteger
    {
        [FieldOffset(0)]
        public uint Low;

        [FieldOffset(4)]
        public uint High;

        [FieldOffset(0)]
        public ulong QuadPart;
    }

    internal static class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern bool QueryPerformanceCounter(out LargeInteger ticks);
    }
}