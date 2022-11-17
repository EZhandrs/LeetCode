namespace Algorithms.Medium
{
    public static class LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                var length = s.Length - i;

                for (int j = 0; j <= i; j++)
                {
                    var isPalindrome = true;

                    for (int k = 0; k < length / 2; k++)
                    {
                        if (s[j + k] != s[j + length - k - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome)
                    {
                        return s.Substring(j, length);
                    }
                }
            }

            return s[0].ToString();
        }
    }
}