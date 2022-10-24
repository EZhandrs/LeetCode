using Xunit;

namespace AlgorithmsTest.Easy
{
    public class SearchInsertPosition
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new int[] { 1, 2, 3, 5, 6 }, 7, 5)]
        [InlineData(new int[] { 1 }, 7, 1)]
        [InlineData(new int[] { 10 }, 7, 0)]
        [InlineData(new int[] { 7 }, 7, 0)]
        [InlineData(new int[] { 1, 3 }, 0, 0)]
        [InlineData(new int[] { 1, 3 }, 4, 2)]
        public void Execute(int[] nums, int target, int expected)
        {
            var actual = Algorithms.Easy.SearchInsertPosition.SearchInsert(nums, target);
            Assert.Equal(expected, actual);
        }
    }
}