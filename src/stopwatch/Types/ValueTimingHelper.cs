namespace ev30
{
    using System;
    using System.Diagnostics;
    public struct ValueTimingHelper : IDisposable
    {
        private ValueStopWatch stopwatch;
        private Action<ulong> callback;
        public ValueTimingHelper(Action<ulong> callback)
        {
            this.stopwatch = ValueStopWatch.StartNew();
            this.callback = callback;
        }

        public void Dispose()
        {
            this.stopwatch.Stop();
            callback(this.stopwatch.ElapsedTicks);
        }
    }
}