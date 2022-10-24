using Xunit;

namespace AlgorithmsTest.Easy
{
    public class Text
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("FSAFASDF", "FSAFASDF")]
        [InlineData(" ", " ")]
        [InlineData("  ", " 2")]
        [InlineData("‡‡‡‡‡‡‡‚Ô‚Ô", "‡7‚Ô‚Ô")]
        [InlineData("stttttbvxbc", "st5bvxbc")]
        [InlineData("FFFFFFFFFFFFAAAAADDDDDDDDDDAAAAAAAA", "F12A5D10A8")]
        public void Compress(string text, string expected)
        {
            var actual = Algorithms.Easy.Text.Compress(text);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("FSAFASDF", "FSAFASDF")]
        [InlineData(" ", " ")]
        [InlineData("  ", " 2")]
        [InlineData("‡‡‡‡‡‡‡‚Ô‚Ô", "‡7‚Ô‚Ô")]
        [InlineData("stttttbvxbc", "st5bvxbc")]
        [InlineData("FFFFFFFFFFFFAAAAADDDDDDDDDDAAAAAAAA", "F12A5D10A8")]
        public void CompressForeach(string text, string expected)
        {
            var actual = Algorithms.Easy.Text.CompressForeach(text);
            Assert.Equal(expected, actual);
        }
    }
}
