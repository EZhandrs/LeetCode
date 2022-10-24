using Xunit;

namespace AlgorithmsTest.Easy
{
    public class TwoSum
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new int[] { 5, 11 })]
        public void Execute(int[] nums, int target, int[] expected)
        {
            var actual = Algorithms.Easy.TwoSum.Indexes(nums, target);
            Equal(expected, actual);
        }

        private static void Equal(int[] expected, int[] actual)
        {
            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}