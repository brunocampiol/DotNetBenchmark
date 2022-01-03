using DotNetBenchmark.Common;
using Xunit;

namespace DotNetBenchmark.Unit.Tests
{
    public class MathCustomTest
    {
        [Fact]
        public void TestSum()
        {
            // Assamble
            int a = 1;
            int b = 2;
            int expectedResult = a + b;

            // Act
            int result = MathCustom.Sum(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}