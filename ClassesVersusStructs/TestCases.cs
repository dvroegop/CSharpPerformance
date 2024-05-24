using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace ClassesVersusStructs;

public class TestCases
{
    private const int N = 100_000;

    [Benchmark]
    [MethodImpl(MethodImplOptions.NoOptimization)]
    public void UseClasses()
    {
        for (var i = 0; i < N; i++)
        {
            var myClass = new MyClass();
            myClass.MyProperty = i;
        }
    }

    [Benchmark]
    [MethodImpl(MethodImplOptions.NoOptimization)]
    public void UseStructs()
    {
        for (var i = 0; i < N; i++)
        {
            var myStruct = new MyStruct();
            myStruct.MyProperty = i;
        }
    }
}

public class MyClass
{
    public int MyProperty { get; set; }
}

public struct MyStruct
{
    public int MyProperty { get; set; }
}