
using BenchmarkDotNet.Running;
using Benchmarking;

var summary= BenchmarkRunner.Run<TestCases>();

/*
 * 
 * 
 * | Method      | Mean       | Error   | StdDev  |
   |------------ |-----------:|--------:|--------:|
   | AFastMethod |   107.7 ms | 0.81 ms | 0.75 ms |
   | ASlowMethod | 1,008.1 ms | 4.49 ms | 4.20 ms |

*/