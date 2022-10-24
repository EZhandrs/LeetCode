using Xunit;

namespace AlgorithmsTest.Medium
{
    public class UTF_8Validation
    {
        [Theory]
        [InlineData(new int[] { 0 }, true)]
        [InlineData(new int[] { 1 }, true)]
        [InlineData(new int[] { 1, 1 }, true)]
        [InlineData(new int[] { 255 }, false)]
        [InlineData(new int[] { 0, 255 }, false)]
        [InlineData(new int[] { 197, 130, 1 }, true)]
        [InlineData(new int[] { 235, 140, 4 }, false)]
        [InlineData(new int[] { 240, 162, 138, 147 }, true)]
        public void Execute(int[] data, bool expected)
        {
            var actual = Algorithms.Medium.UTF_8Validation.ValidUtf8(data);
            Assert.Equal(expected, actual);
        }
    }
}