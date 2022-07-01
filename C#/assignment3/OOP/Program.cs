using OOP;
using OOP.DataModel;
using OOP.Presentation;

// Reverse an array
ReverseArray ra = new ReverseArray(10);
ra.Run();

// Fibonacci
Fibonacci f = new Fibonacci();
f.Run();

// Student, Instructor, Course, Department
Student s = new Student(1, "amy", 2000);
ManageStudent ms = new ManageStudent(s);
ms.Run();

Instructor inst = new Instructor(1, "cindy", 1980);
ManageInstructor IS = new ManageInstructor(inst);
IS.Run();

Course c = new Course(1, "algebra");
ManageCourse mc = new ManageCourse(c);
mc.Run();

Department d = new Department(1, "math");
ManageDepartment md = new ManageDepartment(d);
md.Run();

// Color, Ball
ColorBall cb = new ColorBall();
cb.Run();



