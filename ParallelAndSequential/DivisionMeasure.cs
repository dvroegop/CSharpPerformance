using BenchmarkDotNet.Attributes;

namespace ParallelAndSequential;

public class DivisionMeasure
{
    private const int NumberOfLoopCount = 1_000_000;
    private const int TestNumber = 500_009; // A prime number...
    [Benchmark]
    public void TestModulo()
    {
        var numberOfMatches = 0;
        for (var i = 3; i < NumberOfLoopCount; i++)
            if (TestNumber % i == 0)
                numberOfMatches++;
    }

    [Benchmark]
    public void TestMultiplicationAndDivisionInParallel()
    {
        var numberOfMatches = 0;
        var localNumberOfLoopCount = NumberOfLoopCount;
        var localTestNumber = TestNumber;

        var lockObj = new object();

        Parallel.For(3, localNumberOfLoopCount, i =>
        {
            var div = localTestNumber / i;
            if (localTestNumber == i * div)
                lock (lockObj)
                {
                    numberOfMatches++;
                }
        });
    }
}