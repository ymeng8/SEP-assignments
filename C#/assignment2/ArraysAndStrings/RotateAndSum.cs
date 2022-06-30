using System;
namespace ArraysAndStrings
{
    public class RotateAndSum
    {
        public void Run()
        {
            Console.WriteLine("Enter an array of integers, separated by space: ");
            string[] input = Console.ReadLine().Split(" ");
            Console.WriteLine("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[input.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            int[] sum = new int[arr.Length];

            for (int i = 0; i < k; i++)
            {
                int temp = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = temp;

                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

