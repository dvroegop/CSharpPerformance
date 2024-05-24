using BenchmarkDotNet.Running;
using ForeachVersusFor;

var summary = BenchmarkRunner.Run<TestCases>();

/*
 *
 * | Method      | Mean       | Error    | StdDev  |
   |------------ |-----------:|---------:|--------:|
   | ForLoop     |   714.0 ns |  8.95 ns | 8.37 ns |
   | ForeachLoop | 1,182.5 ns | 10.54 ns | 9.86 ns |

*/