using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ArraysAndStrings
{
    public class ExtractPalindromes
    {
        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i <= j)
            {
                if (!(s[i] == s[j]))
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        public void Run(string s)
        {
            string pattern = "[^A-Za-z]+";
            string[] words = Regex.Split(s, pattern);
            Array.Sort(words);

            HashSet<string> output = new HashSet<string>();

            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    output.Add(word);
                }
            }

            Console.WriteLine(String.Join(", ", output));
        }

    }
}

