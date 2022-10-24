using Xunit;

namespace AlgorithmsTest.Easy
{
    public class PalindromeNumber
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(131, true)]
        [InlineData(12321, true)]
        [InlineData(-121, false)]
        [InlineData(-1212121, false)]
        [InlineData(123, false)]
        [InlineData(1234, false)]
        [InlineData(1232, false)]
        [InlineData(12322, false)]
        public void Execute(int x, bool expected)
        {
            var actual = Algorithms.Easy.PalindromeNumber.IsPalindrome(x);
            Assert.Equal(expected, actual);
        }
    }
}