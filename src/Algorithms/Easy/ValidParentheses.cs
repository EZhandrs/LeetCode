using System.Collections.Generic;

namespace Algorithms.Easy
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            var brackets = new Dictionary<char, char>
            {
                {'(',  ')' },
                {'[',  ']' },
                {'{',  '}' }
            };

            var bracketsOpened = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var character = s[i];

                if (brackets.ContainsKey(character))
                {
                    bracketsOpened.Push(character);
                }
                else
                {
                    if (bracketsOpened.Count == 0 || brackets[bracketsOpened.Pop()] != character)
                        return false;
                }
            }

            return bracketsOpened.Count == 0;
        }
    }
}