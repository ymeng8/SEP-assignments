using System;
namespace ControllingFlow
{
    public class Greeting
    {
        public DateTime Dt { get; set; }

        public void Greet()
        {
            int hour = Dt.Hour;

            Console.Write($"Current time is {Dt.ToShortTimeString()}. ");

            if (0 <= hour && hour <= 5)
            {
                Console.WriteLine("Good Night");
                return;
            }
            if (6 <= hour && hour <= 12)
            {
                Console.WriteLine("Good Morning");
                return;
            }
            if (13 <= hour && hour <= 18)
            {
                Console.WriteLine("Good Afternoon");
                return;
            }
            if (19 <= hour && hour <= 22)
            {
                Console.WriteLine("Good Evening");
                return;
            }
            if (23 <= hour && hour < 24)
            {
                Console.WriteLine("Good Night");
                return;
            }
        }
    }
}

