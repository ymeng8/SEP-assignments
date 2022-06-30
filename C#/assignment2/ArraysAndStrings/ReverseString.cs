using System;
namespace ArraysAndStrings
{
    public class ReverseString
    {
        public void Run()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            // using char array
            char[] arr = input.ToCharArray();
            string output = new string(arr.Reverse().ToArray());
            Console.WriteLine(output);

            // printing backward
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}

