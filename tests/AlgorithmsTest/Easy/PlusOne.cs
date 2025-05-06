using Xunit;

namespace AlgorithmsTest.Easy
{
    public class PlusOne
    {
        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 2 })]
        [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 3 })]
        [InlineData(new int[] { 1, 9, 9 }, new int[] { 2, 0, 0 })]
        [InlineData(new int[] { 1, 9 }, new int[] { 2, 0 })]
        [InlineData(new int[] { 9, 8 }, new int[] { 9, 9 })]
        [InlineData(new int[] { 9, 9 }, new int[] { 1, 0, 0 })]

        public void Execute(int[] digits, int[] expected)
        {
            var actual = Algorithms.Easy.PlusOne.Plus(digits);
            Assert.Equal(expected, actual);
        }
    }
}