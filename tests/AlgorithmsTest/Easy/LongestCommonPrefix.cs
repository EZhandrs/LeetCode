using Xunit;

namespace AlgorithmsTest.Easy
{
    public class LongestCommonPrefix
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "ab", "a" }, "a")]
        [InlineData(new string[] { "ab", "ab" }, "ab")]
        [InlineData(new string[] { "a", "ab" }, "a")]
        [InlineData(new string[] { "a", "ab", "c" }, "")]
        [InlineData(new string[] { "", "ab", "c" }, "")]
        [InlineData(new string[] { "dog" }, "dog")]
        public void Execute(string[] strs, string expected)
        {
            var actual = Algorithms.Easy.LongestCommonPrefix.GetPrefix(strs);
            Assert.Equal(expected, actual);
        }
    }
}