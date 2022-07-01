using System;
namespace OOP
{
    public class ReverseArray
    {
        public int Length { get; set; }

        public ReverseArray(int length)
        {
            Length = length;
        }

        public int[] GenerateNumbers()
        {
            int[] numbers = new int[Length];
            Random random = new Random();

            for (int i = 0; i < Length; i++)
            {
                numbers[i] = random.Next(int.MinValue, int.MaxValue);
            }

            return numbers;
        }

        public void Reverse(ref int[] numbers)
        {
            int temp;

            for (int i = 0, j = Length - 1; i <= j; i++, j--)
            {
                temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }

        public void PrintNumbers(int[] numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));
        }

        public void Run()
        {
            int[] numbers = GenerateNumbers();
            Console.Write("Original array: ");
            PrintNumbers(numbers);
            Reverse(ref numbers);
            Console.Write("Reversed array: ");
            PrintNumbers(numbers);
        }
    }
}

