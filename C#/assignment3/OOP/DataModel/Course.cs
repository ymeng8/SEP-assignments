using System;
namespace OOP.DataModel
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Students { get; set; }

        public Course(int id, string name)
        {
            Id = id;
            Name = name;
            Students = new List<string>();
        }
    }
}

