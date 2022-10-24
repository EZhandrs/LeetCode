using System;

namespace Algorithms.Easy
{
    public static class MaximumUnitsOnATruck
    {
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            Array.Sort(boxTypes, (x, y) => y[1] - x[1]);

            var units = 0;

            for (int i = 0; i < boxTypes.Length; i++)
            {
                var boxesCount = Math.Min(boxTypes[i][0], truckSize);

                units += boxesCount * boxTypes[i][1];
                truckSize -= boxesCount;

                if (truckSize == 0) break;
            }

            return units;
        }
    }
}