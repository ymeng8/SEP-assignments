using System;
using OOP.DataModel;
using OOP.Service;

namespace OOP.Presentation
{
    public class ManageInstructor
    {
        static Instructor Inst { get; set; }

        public ManageInstructor(Instructor i)
        {
            Inst = i;
        }

        InstructorService IS = new InstructorService(Inst);

        public void AddDept()
        {
            Console.WriteLine("Enter department id: ");
            IS.AddDept(Convert.ToInt32(Console.ReadLine()));
        }

        public void DeptHead()
        {
            IS.DeptHead();
        }

        public void GetAge()
        {
            Console.WriteLine($"{Inst.Name} is {IS.GetAge()} year old.");
        }

        public void GetSalary()
        {
            Console.WriteLine($"{Inst.Name}'s salary is ${IS.GetSalary()}.");
        }

        public void AddAddr()
        {
            Console.WriteLine("Enter address: ");
            IS.AddAddr(Console.ReadLine());
        }

        public void GetAddr()
        {
            string[] addrs = IS.GetAddr();
            foreach (string a in addrs)
            {
                Console.WriteLine(a);
            }
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add department");
            Console.WriteLine("Press 2 to become department head");
            Console.WriteLine("Press 3 to get age");
            Console.WriteLine("Press 4 to get salary");
            Console.WriteLine("Press 5 to add address");
            Console.WriteLine("Press 6 to get addresses");
            Console.WriteLine("Press 9 to exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 9)
            {
                switch (choice)
                {
                    case 1:
                        AddDept();
                        break;
                    case 2:
                        DeptHead();
                        break;
                    case 3:
                        GetAge();
                        break;
                    case 4:
                        GetSalary();
                        break;
                    case 5:
                        AddAddr();
                        break;
                    case 6:
                        GetAddr();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Enter choice to continue");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

