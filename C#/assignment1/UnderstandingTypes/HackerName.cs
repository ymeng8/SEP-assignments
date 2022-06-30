using System;
namespace UnderstandingTypes
{
    public class HackerName
    {
        public void GenerateName()
        {
            string color, sign;
            int address;
            try
            {
                Console.WriteLine("Enter your favorite color:");
                color = Console.ReadLine();
                Console.WriteLine("Enter your astrology sign:");
                sign = Console.ReadLine();
                Console.WriteLine("Enter your street address number:");
                address = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your hacker name is {color + sign + address}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid inputs.");
            }
        }
    }
}
