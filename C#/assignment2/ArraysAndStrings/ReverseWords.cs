using System;
using System.Text;

namespace ArraysAndStrings
{
    public class ReverseWords
    {
        public void Run(string s)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder(s.Length);
            int i = words.Length - 1, j = 0;

            while (i >= 0)
            {
                sb.Append(words[i]);
                i--;

                while (j < s.Length && !separators.Contains(s[j]))
                {
                    j++;
                }
                while (j < s.Length && separators.Contains(s[j]))
                {
                    sb.Append(s[j]);
                    j++;
                }
            }

            Console.WriteLine(sb);
        }
    }
}

