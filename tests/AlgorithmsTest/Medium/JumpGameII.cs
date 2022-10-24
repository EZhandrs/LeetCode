using Xunit;

namespace AlgorithmsTest.Medium
{
    public class JumpGameII
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, 2)]
        [InlineData(new int[] { 2, 3, 0, 1, 4 }, 2)]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 2, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 1, 2, 1, 1, 1 }, 3)]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 0 }, 2)]
        public void Execute(int[] nums, int expected)
        {
            var actual = Algorithms.Medium.JumpGameII.Jump(nums);
            Assert.Equal(expected, actual);
        }
    }
}