using System;
namespace OOP.DataModel
{
    public class Instructor : Person
    {
        public int Dept { get; set; }
        public bool HeadOfDept { get; set; }
        public int JoinDate { get; set; }

        public Instructor(int id, string name, int dob) : base(id, name, dob)
        {
        }
    }
}

