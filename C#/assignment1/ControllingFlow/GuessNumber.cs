using System;
namespace ControllingFlow
{
    public class GuessNumber
    {
        public void Guess()
        {
            int correctNumber = new Random().Next(3) + 1;
            int guess = 0;
            while (guess != correctNumber)
            {
                Console.WriteLine("Guess a number:");
                guess = int.Parse(Console.ReadLine());

                if (guess < 1 || guess > 3)
                {
                    Console.WriteLine("Out of range");
                }
                else if (guess < correctNumber)
                {
                    Console.WriteLine("Guessed low");
                }
                else if (guess > correctNumber)
                {
                    Console.WriteLine("Guessed high");
                }
                else
                {
                    Console.WriteLine("Correct");
                }
            }
        }
    }
}

