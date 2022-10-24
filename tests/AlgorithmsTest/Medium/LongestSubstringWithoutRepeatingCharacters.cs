using Xunit;

namespace AlgorithmsTest.Medium
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("abcaqwerb", 7)]
        [InlineData("abcaqwerbtyui", 11)]
        [InlineData("abcaqwerbtyuii", 11)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        [InlineData("  ", 1)]
        [InlineData("dvdf", 3)]
        [InlineData("au", 2)]
        [InlineData("auazxc", 5)]
        [InlineData("abcuazxc", 6)]
        public void Execute(string s, int expected)
        {
            var actual = Algorithms.Medium.LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
            Assert.Equal(expected, actual);
        }
    }
}