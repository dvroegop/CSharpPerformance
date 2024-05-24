using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace CompilerTricks;

public class TestCases
{
    private const int N = 10;
    [Benchmark]
    public void RunUnoptimized()
    {
        for (var i = 0; i < N; i++) FactorialNormal(i);
    }

    [Benchmark]
    public void RunOptimized()
    {
        for (var i = 0; i < N; i++) FactorialAggressive(i);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    
    private static int FactorialAggressive(int n)
    {
        if (n <= 1)
            return 1;
        return n * FactorialAggressive(n - 1);
    }

    [MethodImpl(MethodImplOptions.NoOptimization)]
    private static int FactorialNormal(int n)
    {
        if (n <= 1)
            return 1;
        return n * FactorialNormal(n - 1);
    }
}