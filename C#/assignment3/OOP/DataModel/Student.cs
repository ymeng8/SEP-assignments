using System;
namespace OOP.DataModel
{
    public class Student : Person
    {
        public List<string> Courses { get; set; }
        public Dictionary<int, string> Grades { get; set; }
        public double GPA { get; set; }

        public Student(int id, string name, int dob) : base(id, name, dob)
        {
            Courses = new List<string>();
            Grades = new Dictionary<int, string>();
            GPA = 0.0;
        }
    }
}

