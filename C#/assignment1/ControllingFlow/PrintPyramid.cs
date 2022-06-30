using System;
namespace ControllingFlow
{
    public class PrintPyramid
    {
        public void Print()
        {
            for (int i = 0; i < 5; i++)
            {
                string spaces = new String(' ', 4 - i);
                string stars = new string('*', i * 2 + 1);
                Console.WriteLine($"{spaces + stars + spaces}");
            }
        }
    }
}

