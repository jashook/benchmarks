namespace ev30
{
    using System;
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class NullCoalescingOpTimings
    {
        
        public NullCoalescingOpTimings()
        {
        }

        [Benchmark]
        public void Baseline()
        {
            List<int> values = null;

            if (values == null)
            {
                values = new List<int>() { 10, 11, 12 };
            }
        }

        [Benchmark]
        public void NullCoaleceOp()
        {
            List<int> values = null;

            values ??= new List<int>() { 10, 11, 12 };
        }
    }
}