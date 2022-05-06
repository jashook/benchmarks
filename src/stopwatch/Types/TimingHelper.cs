namespace ev30
{
    using System;
    using System.Diagnostics;
    public struct TimingHelper : IDisposable
    {
        private Stopwatch stopwatch;
        private Action<long> callback;
        public TimingHelper(Action<long> callback)
        {
            this.stopwatch = Stopwatch.StartNew();
            this.callback = callback;
        }

        public void Dispose()
        {
            this.stopwatch.Stop();
            callback(this.stopwatch.ElapsedTicks);
        }
    }
}