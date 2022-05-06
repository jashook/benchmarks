namespace ev30
{
    using System;
    using System.Runtime.CompilerServices;
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

    public struct ValueStopWatch
    {
        [DllImport("kernel32.dll", SetLastError=true)]
        private static extern bool QueryPerformanceCounter(out LargeInteger ticks);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ValueStopWatch StartNew()
        {
            ValueStopWatch stopWatch = new ValueStopWatch();
            stopWatch.Start();
            return stopWatch;
        }

        private bool stopped = false;
        private ulong elapsedTicks = 0;

        public ulong ElapsedTicks
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (this.stopped)
                {
                    return this.elapsedTicks;
                }
                else
                {
                    ulong currentTicks = this.GetTicks();
                    return currentTicks - this.StartTicks;
                }
            }

            private set { }
        }
        
        private ulong EndTicks;
        private ulong StartTicks;

        public ValueStopWatch()
        {
            this.StartTicks = 0;
            this.EndTicks = 0;
            this.ElapsedTicks = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Start()
        {
            this.StartTicks = this.GetTicks();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Stop()
        {
            this.EndTicks = this.GetTicks();
            this.stopped = true;

            this.elapsedTicks = this.EndTicks - this.StartTicks;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ulong GetTicks()
        {
            LargeInteger ticks = new();
            if (!QueryPerformanceCounter(out ticks))
            {
                throw new Exception("Failed to get ticks");
            }

            return ticks.QuadPart;
        }
    }
}