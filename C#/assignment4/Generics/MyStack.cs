using System;
namespace Generics
{
    public class MyStack<T>
    {
        List<T> stack = new List<T>();
        public MyStack()
        {
        }

        public int Count()
        {
            return stack.Count;
        }

        public T Pop()
        {
            T item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }

        public void Push(T item)
        {
            stack.Add(item);
        }

        public void Print()
        {
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}

