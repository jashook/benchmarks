using BenchmarkDotNet.Running;
using ev30;

var summary = BenchmarkRunner.Run<X509Timings>();