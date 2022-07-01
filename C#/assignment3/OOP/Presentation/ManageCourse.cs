using System;
using OOP.DataModel;
using OOP.Service;

namespace OOP.Presentation
{
    public class ManageCourse
    {
        static Course Course { get; set; }
        public ManageCourse(Course c)
        {
            Course = c;
        }
        CourseService cs = new CourseService(Course);

        public void GetEnrolled()
        {
            string[] EnrolledStudents = cs.Enrollment();
            Console.WriteLine($"Students enrolled in {Course.Name}: {String.Join(", ", EnrolledStudents)}");
        }

        public void Run()
        {
            GetEnrolled();
        }
    }
}

