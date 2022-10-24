using Xunit;

namespace AlgorithmsTest.Easy
{
    public class ValidParentheses
    {
        [Theory]
        [InlineData("()[]{}", true)]
        [InlineData("(){}", true)]
        [InlineData("[]{}", true)]
        [InlineData("[]", true)]
        [InlineData("{[]}", true)]
        [InlineData("[[]]", true)]
        [InlineData("([)]", false)]
        [InlineData("]", false)]
        [InlineData("()[]{", false)]
        [InlineData("()[{}", false)]
        [InlineData("({}", false)]
        [InlineData("(}", false)]
        public void Execute(string s, bool expected)
        {
            var actual = Algorithms.Easy.ValidParentheses.IsValid(s);
            Assert.Equal(expected, actual);
        }
    }
}