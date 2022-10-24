using System;

namespace Algorithms.Easy
{
    public static class PlusOne
    {
        public static int[] Plus(int[] digits)
        {
            var nineIndex = digits.Length;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                    nineIndex = i;
                else
                    break;
            }

            if (nineIndex == 0)
            {
                var ret = new int[digits.Length + 1];
                ret[0] = 1;
                return ret;
            }

            digits[nineIndex - 1]++;

            if (digits.Length != nineIndex)
                Array.Fill(digits, 0, nineIndex, digits.Length - nineIndex);

            return digits;
        }
    }
}