using System;
using OOP.DataModel;

namespace OOP.Service
{
    public class StudentService : IStudentService
    {
        static Student Student { get; set; }

        public StudentService(Student s)
        {
            Student = s;
        }

        public void AddAddr(string addr)
        {
            Student.Addr.Add(addr);
        }

        public void AddCourse(string courseName)
        {
            Student.Courses.Add(courseName);
        }

        public void AddGrade(int courseID, string grade)
        {
            Student.Grades.Add(courseID, grade);
        }

        public string[] GetAddr()
        {
            return Student.Addr.ToArray();
        }

        public int GetAge()
        {
            return DateTime.Now.Month - Student.DOB;
        }

        public double GetGPA()
        {
            double sum = 0.0;
            foreach (string g in Student.Grades.Values)
            {
                switch (g)
                {
                    case "A":
                        sum += 4.0;
                        break;
                    case "B":
                        sum += 3.0;
                        break;
                    case "C":
                        sum += 2.0;
                        break;
                    case "D":
                        sum += 1.0;
                        break;
                    default:
                        break;
                }
            }
            return sum / Student.Grades.Count;
        }

        public decimal GetSalary()
        {
            return 0;
        }
    }
}

