namespace Algorithms.Medium
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            long palindrome = 0;

            while (x != 0)
            {
                palindrome = palindrome * 10 + x % 10;
                x /= 10;
            }

            if (palindrome < int.MinValue || palindrome > int.MaxValue) return 0;

            return (int)palindrome;
        }
    }
}