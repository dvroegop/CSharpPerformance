
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<TestCases>();

/*
 * 
| Method  | Mean      | Error     | StdDev    |
|-------- |----------:|----------:|----------:|
| HashSet | 13.065 ms | 0.1557 ms | 0.1456 ms |
| List    |  3.757 ms | 0.0160 ms | 0.0142 ms |

 
    */