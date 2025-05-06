using Xunit;

namespace AlgorithmsTest.Easy
{
    public class BuildArrayFromPermutation
    {
        [Theory]
        [InlineData(new int[] { 0, 2, 1, 5, 3, 4 }, new int[] { 0, 1, 2, 4, 5, 3 })]
        [InlineData(new int[] { 5, 0, 1, 2, 3, 4 }, new int[] { 4, 5, 0, 1, 2, 3 })]
        [InlineData(new int[] { 5, 0, 1, 2, 3, 4, 6 }, new int[] { 4, 5, 0, 1, 2, 3, 6 })]
        [InlineData(new int[] { 6, 0, 1, 2, 3, 4, 5 }, new int[] { 5, 6, 0, 1, 2, 3, 4 })]
        public void Execute(int[] digits, int[] expected)
        {
            var actual = Algorithms.Easy.BuildArrayFromPermutation.Build(digits);
            Assert.Equal(expected, actual);
        }
    }
}