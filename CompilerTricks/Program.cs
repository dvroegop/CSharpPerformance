

using BenchmarkDotNet.Running;
using CompilerTricks;

var summary = BenchmarkRunner.Run<TestCases>();

/*
 * 
 * | Method         | Mean     | Error    | StdDev   |
   |--------------- |---------:|---------:|---------:|
   | RunUnoptimized | 53.66 ns | 0.263 ns | 0.246 ns |
   | RunOptimized   | 36.68 ns | 0.182 ns | 0.170 ns |
*/