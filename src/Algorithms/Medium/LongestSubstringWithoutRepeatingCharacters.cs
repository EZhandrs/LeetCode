using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2)
                return s.Length;

            int maxLength = 0;
            int start = 0;
            var hashMap = new Dictionary<char, int>();

            for (int end = 0; end < s.Length; end++)
            {
                if (hashMap.ContainsKey(s[end]))
                {
                    start = Math.Max(start, hashMap[s[end]] + 1);
                }
                hashMap[s[end]] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }
    }
}
