using System;
using OOP.DataModel;
using OOP.Service;

namespace OOP.Presentation
{
    public class ManageStudent
    {
        static Student Student { get; set; }

        public ManageStudent(Student s)
        {
            Student = s;
        }

        StudentService ss = new StudentService(Student);

        public void EnrollCourse()
        {
            Console.Write("Enter course name: ");
            string c = Console.ReadLine();
            ss.AddCourse(c);
        }

        public void AddGrade()
        {
            Console.Write("Enter course id and grade, separated by space: ");
            string[] input = Console.ReadLine().Split(" ");
            int cID = Convert.ToInt32(input[0]);
            string grade = input[1];
            ss.AddGrade(cID, grade);
        }

        public void GetGPA()
        {
            Console.WriteLine($"{Student.Name}'s current GPA is {ss.GetGPA()}.");
        }

        public void GetAge()
        {
            Console.WriteLine($"{Student.Name} is {ss.GetAge()} year old.");
        }

        public void GetSalary()
        {
            Console.WriteLine($"{Student.Name}'s salary is ${ss.GetSalary()}.");
        }

        public void AddAddr()
        {
            Console.Write("Enter address: ");
            string addr = Console.ReadLine();
            ss.AddAddr(addr);
        }

        public void GetAddr()
        {
            string[] addrs = ss.GetAddr();
            foreach (string a in addrs)
            {
                Console.WriteLine(a);
            }
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to enroll course");
            Console.WriteLine("Press 2 to add grade");
            Console.WriteLine("Press 3 to get GPA");
            Console.WriteLine("Press 4 to get age");
            Console.WriteLine("Press 5 to get salary");
            Console.WriteLine("Press 6 to add address");
            Console.WriteLine("Press 7 to get addresses");
            Console.WriteLine("Press 9 to exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 9)
            {
                switch (choice)
                {
                    case 1:
                        EnrollCourse();
                        break;
                    case 2:
                        AddGrade();
                        break;
                    case 3:
                        GetGPA();
                        break;
                    case 4:
                        GetAge();
                        break;
                    case 5:
                        GetSalary();
                        break;
                    case 6:
                        AddAddr();
                        break;
                    case 7:
                        GetAddr();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine();
                Console.Write("Enter choice to continue: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

