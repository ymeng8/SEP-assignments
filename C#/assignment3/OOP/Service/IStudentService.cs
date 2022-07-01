using System;
using OOP.DataModel;
namespace OOP.Service
{
    public interface IStudentService : IPersonService
    {
        void AddCourse(string courseName);
        double GetGPA();
        void AddGrade(int courseID, string grade);
    }
}

