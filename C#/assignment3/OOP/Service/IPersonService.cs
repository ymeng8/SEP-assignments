using System;
namespace OOP.Service
{
    public interface IPersonService
    {
        int GetAge();
        decimal GetSalary();
        void AddAddr(string addr);
        string[] GetAddr();
    }
}

