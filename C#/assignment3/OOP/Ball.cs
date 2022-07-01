using System;
namespace OOP
{
    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        public int Count { get; set; }

        public Ball(int s, Color c)
        {
            Size = s;
            Color = c;
            Count = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                Count++;
            }
        }

        public int GetCount()
        {
            return Count;
        }
    }
}

