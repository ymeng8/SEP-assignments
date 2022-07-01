using System;
using OOP.DataModel;

namespace OOP.Service
{
    public class DepartmentService : IDepartmentService
    {
        static Department Dept { get; set; }
        public DepartmentService(Department d)
        {
            Dept = d;
        }

        public void AddDeptHead(string inst)
        {
            Dept.Head = inst;
        }

        public void SetBudget(decimal budget)
        {
            Dept.Budget = budget;
        }

        public void AddCourse(string name)
        {
            Dept.Courses.Add(name);
        }

        public string[] GetCourses()
        {
            return Dept.Courses.ToArray();
        }
    }
}

