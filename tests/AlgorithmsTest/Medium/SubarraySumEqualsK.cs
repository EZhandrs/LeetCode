using Xunit;

namespace AlgorithmsTest.Medium
{
    public class SubarraySumEqualsK
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, 2, 2)]
        [InlineData(new int[] { 1, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0, 55)]
        [InlineData(new int[] { 1 }, 0, 0)]
        public void Execute(int[] nums, int k, int expected)
        {
            var actual = Algorithms.Medium.SubarraySumEqualsK.SubarraySum(nums, k);
            Assert.Equal(expected, actual);
        }
    }
}