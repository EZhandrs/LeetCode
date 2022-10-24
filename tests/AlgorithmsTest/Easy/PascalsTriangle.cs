using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest.Easy
{
    public class PascalsTriangle
    {
        [Fact]
        public void Execute1()
        {
            const int numRows = 1;

            var expected = new int[numRows][] {
                new int[] { 1 },
            };

            var actual = Algorithms.Easy.PascalsTriangle.Generate(numRows);
            Equal(expected, actual);
        }

        [Fact]
        public void Execute2()
        {
            const int numRows = 2;

            var expected = new int[numRows][] {
                new int[] { 1 },
                new int[] { 1, 1 },
            };

            var actual = Algorithms.Easy.PascalsTriangle.Generate(numRows);
            Equal(expected, actual);
        }

        [Fact]
        public void Execute3()
        {
            const int numRows = 3;

            var expected = new int[numRows][] {
                new int[] { 1 },
                new int[] { 1, 1 },
                new int[] { 1, 2, 1 },
            };

            var actual = Algorithms.Easy.PascalsTriangle.Generate(numRows);
            Equal(expected, actual);
        }

        [Fact]
        public void Execute4()
        {
            const int numRows = 4;

            var expected = new int[numRows][] {
                new int[] { 1 },
                new int[] { 1, 1 },
                new int[] { 1, 2, 1 },
                new int[] { 1, 3, 3, 1 },
            };

            var actual = Algorithms.Easy.PascalsTriangle.Generate(numRows);
            Equal(expected, actual);
        }

        [Fact]
        public void Execute5()
        {
            const int numRows = 5;

            var expected = new int[numRows][] {
                new int[] { 1 },
                new int[] { 1, 1 },
                new int[] { 1, 2, 1 },
                new int[] { 1, 3, 3, 1 },
                new int[] { 1, 4, 6, 4, 1 }
            };

            var actual = Algorithms.Easy.PascalsTriangle.Generate(numRows);
            Equal(expected, actual);
        }

        private static void Equal(int[][] expected, IList<IList<int>> actual)
        {
            Assert.Equal(expected.Length, actual.Count);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i].Length, actual[i].Count);

                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.Equal(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}