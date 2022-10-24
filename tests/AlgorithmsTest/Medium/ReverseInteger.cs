using Xunit;

namespace AlgorithmsTest.Medium
{
    public class ReverseInteger
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(-1, -1)]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(-120, -21)]
        [InlineData(2147483647, 0)]
        [InlineData(-2147483648, 0)]
        public void Execute(int x, int expected)
        {
            var actual = Algorithms.Medium.ReverseInteger.Reverse(x);
            Assert.Equal(expected, actual);
        }
    }
}