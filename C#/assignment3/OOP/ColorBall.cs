using System;
namespace OOP
{
    public class ColorBall
    {

        public void Run()
        {
            List<Color> colors = new List<Color>();
            for (int i = 0; i < 5; i++)
            {
                Color c = new Color(i, i + 1, i + 2);
                colors.Add(c);
            }

            List<Ball> balls = new List<Ball>();
            for (int i = 0; i < 5; i++)
            {
                Ball b = new Ball(i + 1, colors[i]);
                balls.Add(b);
            }

            for (int i = 0; i < 3; i++)
            {
                balls[0].Throw();
                balls[2].Throw();
            }


            for (int i = 0; i < 5; i++)
            {
                balls[i].Pop();
            }

            for (int i = 0; i < 3; i++)
            {
                balls[0].Throw();
                balls[2].Throw();
            }


            for (int i = 0; i < 5; i++)
            {
                Console.Write(balls[i].Count + " ");
            }
        }
    }
}

