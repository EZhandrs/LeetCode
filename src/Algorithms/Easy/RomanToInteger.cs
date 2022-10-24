using System.Collections.Generic;

namespace Algorithms.Easy
{
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var map = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            var last = 0;
            var current = 0;
            var value = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                current = map[s[i]];

                if (current < last)
                {
                    value -= current;
                }
                else
                {
                    value += current;
                }

                last = current;
            }

            return value;
        }
    }
}
