namespace Algorithms.Easy
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            if (x < 10)
                return true;

            var actual = x;
            var palindrome = 0;

            while (x > 0)
            {
                palindrome = palindrome * 10 + x % 10;
                x /= 10;
            }

            return actual == palindrome;
        }
    }
}