namespace ev30
{
    using System;
    using System.Diagnostics;
    public ref struct RefValueStopWatch
    {
        private ValueStopWatch stopwatch = new();
        private Action<ulong> callback;
        public RefValueStopWatch(Action<ulong> callback)
        {
            this.stopwatch.Start();
            this.callback = callback;
        }

        public void Dispose()
        {
            this.stopwatch.Stop();
            callback(this.stopwatch.ElapsedTicks);
        }
    }
}