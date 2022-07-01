using System;
using OOP.DataModel;
using OOP.Service;

namespace OOP.Presentation
{
    public class ManageDepartment
    {
        static Department Dept { get; set; }
        public ManageDepartment(Department d)
        {
            Dept = d;
        }

        DepartmentService ds = new DepartmentService(Dept);

        public void AddDeptHead()
        {
            Console.WriteLine("Enter instructor name: ");
            ds.AddDeptHead(Console.ReadLine());
        }

        public void SetBudget()
        {
            Console.WriteLine("Enter budget: ");
            decimal budget = Convert.ToDecimal(Console.ReadLine());
            ds.SetBudget(budget);
        }

        public void AddCourse()
        {
            Console.WriteLine("Enter course name: ");
            ds.AddCourse(Console.ReadLine());
        }

        public void GetCourses()
        {
            string[] courses = ds.GetCourses();
            Console.WriteLine($"{Dept.Name} is offering {String.Join(", ", courses)}");
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to add department head");
            Console.WriteLine("Press 2 to set budget for school year");
            Console.WriteLine("Press 3 to add course offering");
            Console.WriteLine("Press 4 to get list of courses offered");
            Console.WriteLine("Press 9 to exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 9)
            {
                switch (choice)
                {
                    case 1:
                        AddDeptHead();
                        break;
                    case 2:
                        SetBudget();
                        break;
                    case 3:
                        AddCourse();
                        break;
                    case 4:
                        GetCourses();
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

