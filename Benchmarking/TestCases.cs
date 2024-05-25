using BenchmarkDotNet.Attributes;

namespace Benchmarking
{
    public class TestCases
    {
        [Benchmark]
        public void AFastMethod()
        {
            System.Threading.Thread.Sleep(100);   
        }

        [Benchmark]
        public void ASlowMethod()
        {
            System.Threading.Thread.Sleep(1000);
        }
    }
}
