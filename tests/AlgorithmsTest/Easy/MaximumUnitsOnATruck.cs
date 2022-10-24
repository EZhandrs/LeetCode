using Xunit;

namespace AlgorithmsTest.Easy
{
    public class MaximumUnitsOnATruck
    {
        [Fact]
        public void Execute1()
        {
            //Arrange
            var boxTypes = new int[3][] { new int[] { 1, 3 }, new int[] { 2, 2 }, new int[] { 3, 1 } };
            var truckSize = 4;
            var expected = 8;

            //Act
            var actual = Algorithms.Easy.MaximumUnitsOnATruck.MaximumUnits(boxTypes, truckSize);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Execute2()
        {
            //Arrange
            var boxTypes = new int[4][] {
                new int[] { 5, 10 },
                new int[] { 2, 5 },
                new int[] { 4, 7 },
                new int[] { 3, 9 }
            };
            var truckSize = 10;
            var expected = 91;

            //Act
            var actual = Algorithms.Easy.MaximumUnitsOnATruck.MaximumUnits(boxTypes, truckSize);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Execute3()
        {
            //Arrange
            var boxTypes = new int[10][] {
               new int[] {2, 1 },
               new int[] {4, 4 },
               new int[] {3, 1 },
               new int[] {4, 1 },
               new int[] {2, 4 },
               new int[] {3, 4 },
               new int[] {1, 3 },
               new int[] {4, 3 },
               new int[] {5, 3 },
               new int[] {5, 3 }
            };
            var truckSize = 13;
            var expected = 48;

            //Act
            var actual = Algorithms.Easy.MaximumUnitsOnATruck.MaximumUnits(boxTypes, truckSize);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
