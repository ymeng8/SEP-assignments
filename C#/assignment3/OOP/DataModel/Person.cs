using System;
namespace OOP.DataModel
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DOB { get; set; }
        public List<string> Addr { get; set; }

        public Person(int id, string name, int dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
            Addr = new List<string>();
        }
    }
}

