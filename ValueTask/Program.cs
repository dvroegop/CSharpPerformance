

using BenchmarkDotNet.Running;
using ValueTask;

var summary = BenchmarkRunner.Run<ValueTaskVsTaskBenchmark>();

/*
 * | Method          | Mean      | Error    | StdDev   |
   |---------------- |----------:|---------:|---------:|
   | TaskMethod      | 132.85 ns | 2.329 ns | 2.178 ns |
   | ValueTaskMethod |  96.47 ns | 1.953 ns | 4.407 ns |

*/