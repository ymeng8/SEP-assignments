using System;
namespace OOP.Service
{
    public interface IDepartmentService
    {
        void AddDeptHead(string inst);
        void SetBudget(decimal budget);
        void AddCourse(string name);
        string[] GetCourses();
    }
}

