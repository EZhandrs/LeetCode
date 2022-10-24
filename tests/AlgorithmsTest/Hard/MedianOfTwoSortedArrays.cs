using Xunit;

namespace AlgorithmsTest.Hard
{
    public class MedianOfTwoSortedArrays
    {
        [Theory]
        [InlineData(new int[] { 0 }, new int[] { 1 }, 0.5)]
        [InlineData(new int[] { 1 }, new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 3 }, new int[] { }, 2)]
        [InlineData(new int[] { }, new int[] { 1, 3 }, 2)]
        [InlineData(new int[] { }, new int[] { }, 0)]
        [InlineData(new int[] { 1, 3 }, new int[] { 3 }, 3)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 1, 2, 4, 5 }, new int[] { 3 }, 3)]
        [InlineData(new int[] { 1, 2, 4, 5 }, new int[] { 1, 2, 3 }, 2)] // 1 1 2 2 3 4 5 
        [InlineData(new int[] { 1, 2, 4, 5 }, new int[] { 5, 6, 7 }, 5)] // 1 2 4 5 5 6 7
        public void Execute(int[] l1, int[] l2, double expected)
        {
            var actual = Algorithms.Hard.MedianOfTwoSortedArrays.FindMedianSortedArrays(l1, l2);

            Assert.Equal(expected, actual);
        }
    }
}
