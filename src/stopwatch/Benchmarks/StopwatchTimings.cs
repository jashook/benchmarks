namespace ev30
{
    using System.Diagnostics;
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class StopwatchTimings
    {
        public StopwatchTimings()
        {
            
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingBaseline()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                Thread.Yield();
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingWithStopwatch()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                Thread.Yield();
                stopwatch.Stop();
                long ticks = stopwatch.ElapsedTicks;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingWithStopwatchAndWithTryFinally()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                try
                {
                    Thread.Yield();
                }
                finally
                {
                    stopwatch.Stop();
                    long ticks = stopwatch.ElapsedTicks;
                }
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingWithStopwatchAndUsing()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                using TimingHelper _ = new(static (elapsedTicks) => {
                    long ticks = elapsedTicks; 
                });

                Thread.Yield();
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatch()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                ValueStopWatch stopwatch = new();

                stopwatch.Start();
                Thread.Yield();
                stopwatch.Stop();

                ulong ticks = stopwatch.ElapsedTicks;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatchAndWithTryFinally()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                ValueStopWatch stopwatch = new();
                try
                {
                    stopwatch.Start();
                    Thread.Yield();
                }
                finally
                {
                    stopwatch.Stop();
                    ulong ticks = stopwatch.ElapsedTicks;
                }
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatchAndUsing()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                using ValueTimingHelper _ = new(static (elapsedTicks) => {
                    ulong ticks = elapsedTicks; 
                });

                Thread.Yield();
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure Thread.Yield. This should take between 1 and
        /// 35ns
        /// </summary>
        public void HighPrecisionTimingWithRefValueStopwatchAndUsing()
        {
            int spinCount = 4000000; // 4,000,000

            for (int index = 0; index < spinCount; ++index)
            {
                using RefValueStopWatch _ = new(static (elapsedTicks) => {
                    ulong ticks = elapsedTicks; 
                });

                Thread.Yield();
            }
        }
    }
}