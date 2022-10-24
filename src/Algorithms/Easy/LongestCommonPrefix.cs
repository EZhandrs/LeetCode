namespace Algorithms.Easy
{
    public static class LongestCommonPrefix
    {
        public static string GetPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            var minLength = strs[0].Length;
            var minIndex = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < minLength)
                {
                    minIndex = i;
                    minLength = strs[i].Length;
                }
            }

            for (int c = 0; c < minLength; c++)
            {
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[0][c] != strs[i][c])
                        return strs[0].Substring(0, c);
                }
            }

            return strs[minIndex];
        }
    }
}