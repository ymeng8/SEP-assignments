using System;
using OOP.DataModel;

namespace OOP.Service
{
    public class CourseService : ICourseService
    {
        static Course Course { get; set; }
        public CourseService(Course c)
        {
            Course = c;
        }

        public string[] Enrollment()
        {
            return Course.Students.ToArray();
        }
    }
}

