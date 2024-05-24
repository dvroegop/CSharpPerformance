
using BenchmarkDotNet.Running;
using UnsafeCode;


var summary = BenchmarkRunner.Run<SafeAndUnsafeComparison>();

/*
 
   
   | Method     | Mean      | Error    | StdDev   | Median    |
   |----------- |----------:|---------:|---------:|----------:|
   | TestSafe   | 210.68 us | 0.920 us | 0.861 us | 210.55 us |
   | TestUnsafe |  73.71 us | 2.794 us | 7.312 us |  71.00 us |
   | TestSpan   | 261.70 us | 5.054 us | 5.820 us | 262.01 us |
 */