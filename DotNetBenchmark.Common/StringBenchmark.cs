using BenchmarkDotNet.Attributes;
using System.Text;

namespace DotNetBenchmark.Common
{
    [MemoryDiagnoser]
    public class StringBenchmark
    {
        private readonly int _numberOfItems = 100000;

        [Benchmark]
        public string ConcatStringsUsingStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < _numberOfItems; i++)
            {
                sb.Append("Hello World!" + i);
            }
            return sb.ToString();
        }

        [Benchmark]
        public string ConcatStringsUsingGenericList()
        {
            var list = new List<string>();
            for (int i = 0; i < _numberOfItems; i++)
            {
                list.Add("Hello World!" + i);
            }
            return list.ToString();
        }
    }
}