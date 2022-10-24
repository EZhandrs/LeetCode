using System.Collections.Generic;

namespace Algorithms.Medium
{
    public static class UTF_8Validation
    {
        public static bool ValidUtf8(int[] data)
        {
            var expectedMin = 0b10_000000;
            var expectedMax = 0b10_111111;

            var expectedCount = 0;

            var mapMin = new Dictionary<int, byte>()
            {
                { 1, 0b110_00000 },
                { 2, 0b1110_0000 },
                { 3, 0b11110_000 },
            };

            var mapMax = new Dictionary<int, byte>()
            {
                { 1, 0b110_11111 },
                { 2, 0b1110_1111 },
                { 3, 0b11110_111 },
            };

            for (var i = 0; i < data.Length; i++)
            {
                if (expectedCount == 0)
                {
                    if (data[i] < 0b10000000)
                    {
                        continue;
                    }
                    else
                    {
                        for (int b = 1; b <= mapMin.Count; b++)
                        {
                            if (data[i] >= mapMin[b] && data[i] <= mapMax[b])
                            {
                                expectedCount = b;
                                break;
                            }
                        }

                        if (expectedCount == 0)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (data[i] >= expectedMin && data[i] <= expectedMax)
                    {
                        expectedCount--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return expectedCount == 0;
        }
    }
}