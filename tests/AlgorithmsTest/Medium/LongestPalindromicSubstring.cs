using Xunit;

namespace AlgorithmsTest.Medium
{
    public class LongestPalindromicSubstring
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("aa", "aa")]
        [InlineData("ab", "a")]
        [InlineData("aaa", "aaa")]
        [InlineData("asaa", "asa")]
        public void Execute(string s, string expected)
        {
            var actual = Algorithms.Medium.LongestPalindromicSubstring.LongestPalindrome(s);
            Assert.Equal(expected, actual);
        }
    }
}