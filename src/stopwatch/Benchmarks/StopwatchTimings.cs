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
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingBaseline()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                value += 2;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithStopwatch()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                value += 2;
                stopwatch.Stop();
                long ticks = stopwatch.ElapsedTicks;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithStopwatchAndWithTryFinally()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                try
                {
                    value += 2;
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
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithStopwatchAndUsing()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                using TimingHelper _ = new(static (elapsedTicks) => {
                    long ticks = elapsedTicks; 
                });

                value += 2;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatch()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                ValueStopWatch stopwatch = new();

                stopwatch.Start();
                value += 2;
                stopwatch.Stop();

                ulong ticks = stopwatch.ElapsedTicks;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatchAndWithTryFinally()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                ValueStopWatch stopwatch = new();
                try
                {
                    stopwatch.Start();
                    value += 2;
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
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatchAndUsing()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                using ValueTimingHelper _ = new(static (elapsedTicks) => {
                    ulong ticks = elapsedTicks; 
                });

                value += 2;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithRefValueStopwatchAndUsing()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                using RefValueStopWatch _ = new(static (elapsedTicks) => {
                    ulong ticks = elapsedTicks; 
                });

                value += 2;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatchMinInit()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                ValueStopWatch stopwatch;

                stopwatch.StartTicks = ValueStopWatch.GetTicks();
                value += 2;
                stopwatch.EndTicks = ValueStopWatch.GetTicks();

                ulong ticks = stopwatch.EndTicks - stopwatch.StartTicks;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingWithValueStopwatchAndWithTryFinallyMinInit()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;

            for (int index = 0; index < spinCount; ++index)
            {
                ValueStopWatch stopwatch;
                stopwatch.StartTicks = ValueStopWatch.GetTicks();
                try
                {
                    value += 2;
                }
                finally
                {
                    stopwatch.EndTicks = ValueStopWatch.GetTicks();
                    ulong ticks = stopwatch.EndTicks - stopwatch.StartTicks;
                }
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingUsingSingleStopwatch()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int index = 0; index < spinCount; ++index)
            {
                long start = stopwatch.ElapsedTicks;
                value += 2;
                long end = stopwatch.ElapsedTicks;

                long elapsedTicks = end - start;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingUsingSingleStopwatchAndTryFinally()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int index = 0; index < spinCount; ++index)
            {
                long start = 0;
                long end = 0;
                try
                {
                    start = stopwatch.ElapsedTicks;
                    value += 2;
                }
                finally
                {
                    end = stopwatch.ElapsedTicks;
                    long elapsedTicks = end - start;
                }
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingUsingSingleValueStopwatch()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;
            ValueStopWatch stopwatch = new();
            stopwatch.Start();

            for (int index = 0; index < spinCount; ++index)
            {
                ulong start = stopwatch.ElapsedTicks;
                value += 2;
                ulong end = stopwatch.ElapsedTicks;
                ulong elapsedTicks = end - start;
            }
        }

        [Benchmark]
        /// <summary>
        /// Measure value += 2.
        /// </summary>
        public void HighPrecisionTimingUsingSingleValueStopwatchAndTryFinally()
        {
            int spinCount = 4000000; // 4,000,000
            long value = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int index = 0; index < spinCount; ++index)
            {
                long start = 0;
                long end = 0;
                try
                {
                    start = stopwatch.ElapsedTicks;
                    value += 2;
                }
                finally
                {
                    end = stopwatch.ElapsedTicks;
                    long elapsedTicks = end - start;
                }
            }
        }
    }
}