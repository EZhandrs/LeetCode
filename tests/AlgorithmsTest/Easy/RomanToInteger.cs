using Xunit;

namespace AlgorithmsTest.Easy
{
    public class RomanToInteger
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("LV", 55)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCV", 1995)]
        [InlineData("MCMXCIV", 1994)]
        public void Execute(string s, int expected)
        {
            var actual = Algorithms.Easy.RomanToInteger.RomanToInt(s);
            Assert.Equal(expected, actual);
        }
    }
}