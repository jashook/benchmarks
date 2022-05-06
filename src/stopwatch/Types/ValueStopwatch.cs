namespace ev30
{
    using System;
    using System.Runtime.CompilerServices;

    public struct ValueStopWatch
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ValueStopWatch StartNew()
        {
            ValueStopWatch stopWatch = new ValueStopWatch();
            stopWatch.Start();
            return stopWatch;
        }

        public ulong ElapsedTicks
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (this.EndTicks != 0)
                {
                    return this.EndTicks - this.StartTicks;
                }
                else
                {
                    ulong currentTicks = ValueStopWatch.GetTicks();
                    return currentTicks - this.StartTicks;
                }
            }

            private set { }
        }
        
        public ulong EndTicks;
        public ulong StartTicks;

        public ValueStopWatch()
        {
            this.StartTicks = 0;
            this.EndTicks = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Start()
        {
            this.StartTicks = ValueStopWatch.GetTicks();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Stop()
        {
            this.EndTicks = ValueStopWatch.GetTicks();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong GetTicks()
        {
            return (ulong)Environment.TickCount64;
        }
    }
}