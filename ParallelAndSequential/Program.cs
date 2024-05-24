using BenchmarkDotNet.Running;
using ParallelAndSequential;

var summary = BenchmarkRunner.Run<DivisionMeasure>();

/*
 
   | Method                                  | Mean       | Error    | StdDev   |
   |---------------------------------------- |-----------:|---------:|---------:|
   | TestModulo                              | 3,209.7 us | 14.48 us | 13.54 us |
   | TestMultiplicationAndDivisionInParallel |   360.9 us |  3.13 us |  2.62 us |

*/