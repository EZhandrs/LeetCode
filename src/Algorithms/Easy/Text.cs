using System.Text;

namespace Algorithms.Easy
{
    public static class Text
    {
        public static string Compress(string text)
        {
            var result = new StringBuilder(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                var count = 1;
                while (i < text.Length - 1 && text[i] == text[i + 1])
                {
                    count++;
                    i++;
                }
                result.Append(text[i]);
                if (count > 1)
                {
                    result.Append(count);
                }
            }

            return result.ToString();
        }

        public static string CompressForeach(string text)
        {
            if (text == "") return "";

            var result = new StringBuilder(text.Length);
            var last = text[0];
            var count = 0;

            result.Append(last);
            foreach (var symbol in text)
            {
                if (symbol == last)
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                        result.Append(count);
                    result.Append(symbol);
                    count = 1;
                    last = symbol;
                }
            }

            if (count > 1)
                result.Append(count);

            return result.ToString();
        }
    }
}