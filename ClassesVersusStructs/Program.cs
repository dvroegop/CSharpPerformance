

using BenchmarkDotNet.Running;
using ClassesVersusStructs;

var summary = BenchmarkRunner.Run<TestCases>();

/*
 * | Method     | Mean     | Error   | StdDev   | Median   |
   |----------- |---------:|--------:|---------:|---------:|
   | UseClasses | 474.5 us | 9.34 us | 15.86 us | 465.5 us |
   | UseStructs | 209.3 us | 1.72 us |  1.61 us | 209.0 us |

*/