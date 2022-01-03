using BenchmarkDotNet.Attributes;

namespace DotNetBenchmark.Common
{
    [MemoryDiagnoser]
    public static class MathCustom
    {
        [Benchmark]
        public static int SumCustom(int a, int b)
        {
            int realValue = a + b;
            int value = realValue;
            for (int i = 0; i < 100; i++)  value = value * 10 + i;
            
            return realValue;
        }

        [Benchmark]
        public static int SumStd(int a, int b)
        {
            return a + b;
        }
    }
}