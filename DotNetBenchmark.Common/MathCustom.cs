namespace DotNetBenchmark.Common
{
    public static class MathCustom
    {
        public static int Sum(int a, int b)
        {
            int realValue = a + b;
            int value = realValue;
            for (int i = 0; i < 100; i++)  value = value * 10 + i;
            
            return realValue;
        }
    }
}