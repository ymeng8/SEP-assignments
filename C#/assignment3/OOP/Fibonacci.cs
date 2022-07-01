using System;
namespace OOP
{
    public class Fibonacci
    {
        public Fibonacci()
        {
        }

        public int PrintFibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return PrintFibonacci(n - 1) + PrintFibonacci(n - 2);
            }
        }

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(PrintFibonacci(i) + " ");
            }
        }
    }
}

