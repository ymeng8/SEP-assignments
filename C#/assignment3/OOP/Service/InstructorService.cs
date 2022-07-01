using System;
using OOP.DataModel;

namespace OOP.Service
{
    public class InstructorService : IInstructorService
    {
        static Instructor Inst { get; set; }

        public InstructorService(Instructor i)
        {
            Inst = i;
        }

        public void AddDept(int deptID)
        {
            Inst.Dept = deptID;
        }

        public void DeptHead()
        {
            Inst.HeadOfDept = true;
        }

        public void Join(int date)
        {
            Inst.JoinDate = date;
        }

        public int GetAge()
        {
            return DateTime.Now.Month - Inst.DOB;
        }

        public decimal GetSalary()
        {
            int yoe = DateTime.Now.Year - Inst.JoinDate;
            if (0 < yoe && yoe < 3)
            {
                return 60000m;
            }
            else if (3 < yoe && yoe < 6)
            {
                return 80000m;
            }
            else
            {
                return 10000m;
            }
        }

        public void AddAddr(string addr)
        {
            Inst.Addr.Add(addr);
        }

        public string[] GetAddr()
        {
            return Inst.Addr.ToArray();
        }
    }
}

