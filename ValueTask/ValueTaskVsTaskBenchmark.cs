using BenchmarkDotNet.Attributes;

namespace ValueTask
{
    public class ValueTaskVsTaskBenchmark
    {
        private static readonly Random Random = new();

        [Benchmark]
        public async Task<int> TaskMethod()
        {
            return await PerformOperationWithTask();
        }

        [Benchmark]
        public async ValueTask<int> ValueTaskMethod()
        {
            return await PerformOperationWithValueTask();
        }

        private Task<int> PerformOperationWithTask()
        {
            // Simulate that 90% of the time the result is synchronous
            if (Random.Next(0, 10) < 9)
            {
                return Task.FromResult(42);
            }
            else
            {
                return SimulateAsyncOperation();
            }
        }

        private ValueTask<int> PerformOperationWithValueTask()
        {
            // Simulate that 90% of the time the result is synchronous
            if (Random.Next(0, 10) < 9)
            {
                return new ValueTask<int>(42);
            }
            else
            {
                return new ValueTask<int>(SimulateAsyncOperation());
            }
        }

        private async Task<int> SimulateAsyncOperation()
        {
            await Task.Yield(); // Simulate some asynchronous work
            return 42;
        }
    
}
}
