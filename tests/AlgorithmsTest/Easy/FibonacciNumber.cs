using Xunit;

namespace AlgorithmsTest.Easy
{
    public class FibonacciNumber
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(10, 55)]
        public void Execute(int n, int expected)
        {
            var actual = Algorithms.Easy.FibonacciNumber.Fib(n);
            Assert.Equal(expected, actual);
        }
    }
}