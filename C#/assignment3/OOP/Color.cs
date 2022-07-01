using System;
namespace OOP
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public Color(int r, int g, int b, int a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }

        public Color(int r, int g, int b)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
        }

        public double Grayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}

