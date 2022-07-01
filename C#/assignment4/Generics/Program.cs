using Generics;

// Custom stack class
MyStack<string> myStack = new MyStack<string>();
for (int i = 1; i <= 5; i++)
{
    myStack.Push(i.ToString());
}
myStack.Print();
string popped = myStack.Pop();
Console.WriteLine($"After popping {popped}, the count is {myStack.Count()}");

// Custom list class
MyList<int> myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Print(); // should be 1, 2, 3
myList.Remove(2);
Console.WriteLine(myList.Contains(3)); // should be false
myList.Clear();
myList.InsertAt(5, 0);
myList.InsertAt(6, 1);
myList.DeleteAt(0);
myList.Print(); // should be 6
Console.WriteLine(myList.Find(0)); // should be 6

// GnericRepository class
GenericRepository gr = new GenericRepository();
Entity e1 = new Entity(1);
Entity e2 = new Entity(2);
Entity e3 = new Entity(3);
gr.Add(e1);
gr.Add(e2);
gr.Add(e3);
foreach (Entity e in gr.GetAll())
{
    Console.Write(e.Id + " "); // 1 2 3
}
Console.WriteLine();
Console.WriteLine(gr.GetById(2).Id); // 2
gr.Remove(e1);
foreach (Entity e in gr.GetAll())
{
    Console.Write(e.Id + " "); // 2 3
}
Console.WriteLine();
gr.Save();