using System;
namespace OOP.Service
{
    public interface IInstructorService : IPersonService
    {
        void AddDept(int deptID);
        void DeptHead();
        void Join(int date);
    }
}

