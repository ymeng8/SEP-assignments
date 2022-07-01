using System;
namespace OOP.DataModel
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Head { get; set; }
        public decimal Budget { get; set; }
        public List<string> Courses { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
            Head = "";
            Budget = 0.0m;
            Courses = new List<string>();
        }
    }
}

