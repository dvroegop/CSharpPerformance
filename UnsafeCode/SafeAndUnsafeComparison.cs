using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace UnsafeCode
{
    public class SafeAndUnsafeComparison
    {
        private const int BlockSize = 100_000;
        private readonly int[] _array = new int[BlockSize];

        [GlobalSetup]
        public void Init()
        {
            for(int i= 0; i < BlockSize; i++)
            {
                _array[i] = i;
            }
        }

        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public void TestSafe()
        {
            var length  = _array.Length;
            long sum = 0;
            for(int i = 0; i < length; i++)
            {
                sum += i;
            }
        }


        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public void TestUnsafe()
        {
            var length = _array.Length;
            long sum = 0;
            unsafe
            {
                fixed (int* p = _array)
                {
                    int* end = p + length;
                    for (int* current = p; current < end; current++)
                    {
                        sum += *current;
                    }
                }
            }
        }

        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public void TestSpan()
        {
            var span = new Span<int>(_array);
            long sum = 0;
            for (int i = 0; i < span.Length; i++)
            {
                sum += span[i];
            }
        }
    }
}
