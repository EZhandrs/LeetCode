using System.Collections.Generic;

namespace Algorithms.Easy
{
    public static class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var rows = new List<IList<int>>(numRows)
            {
                new int[] {1}
            };

            for (int i = 1; i < numRows; i++)
            {
                var row = new List<int>(i + 1)
                {
                    1
                };

                for (int j = 1; j < i; j++)
                {
                    row.Add(rows[i-1][j - 1] + rows[i-1][j]);
                }

                row.Add(1);

                rows.Add(row);
            }

            return rows;
        }
    }
}