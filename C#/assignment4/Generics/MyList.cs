using System;
namespace Generics
{
    public class MyList<T>
    {
        List<T> list = new List<T>();
        public MyList()
        {
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Remove(int index)
        {
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void InsertAt(T item, int index)
        {
            list.Insert(index, item);
        }

        public void DeleteAt(int index)
        {
            list.RemoveAt(index);
        }

        public T Find(int index)
        {
            return list[index];
        }

        public void Print()
        {
            Console.WriteLine(String.Join(", ", list));
        }
    }
}

