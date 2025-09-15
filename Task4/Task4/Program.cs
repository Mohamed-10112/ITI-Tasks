using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Person
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Id = IdGenerator.GenerateId();
            Name = name;
            Age = age;
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"\nHi, I am {Name}, {Age} years old.");
        }
    }

    public class Instructor : Person
    {
        public Instructor(string name, int age) : base(name, age) { }
        public void TeachCourse(Course course)
        {
            course.AssignInstructor(this);
        }
        public override void Introduce()
        {
            Console.WriteLine($"\nHello, I am {Name}, I am a teacher.");
        }
    }

    public class Student : Person
    {
        public List<Course> Courses { get; private set; }
        public List<Grade> Grades { get; } = new List<Grade>();
        public Student(string name, int age) : base(name, age)
        {
            Courses = new List<Course>();
        }
        public void RegisterCourse(Course course)
        {
            Courses.Add(course);
            switch (course.Level)
            {
                case CourseLevel.Beginner:
                    Console.WriteLine($"   {course.CourseName}, Good luck starting out!");
                    break;
                case CourseLevel.Intermediate:
                    Console.WriteLine($"   {course.CourseName}, Keep going, you're improving!");
                    break;
                case CourseLevel.Advanced:
                    Console.WriteLine($"   {course.CourseName}, This will be challenging!");
                    break;
            }
        }
        public override void Introduce()
        {
            Console.WriteLine($"\nHello, I am {Name}, I am a learner.");
        }
    }

    public class Course
    {
        public string CourseName { get; set; }
        public CourseLevel Level { get; set; }
        public Instructor Instructor { get; private set; }

        public Course(string courseName, CourseLevel level)
        {
            CourseName = courseName;
            Level = level;
        }

        public void AssignInstructor(Instructor instructor)
        {
            Instructor = instructor;
        }
    }

    public class Employee
    {
        public string EmpName { get; set; }
        public List<Course> Courses { get; set; }

        public Employee(string name)
        {
            EmpName = name;
            Courses = new List<Course>();
        }

        public void RegisterCourse(Course course)
        {
            Courses.Add(course);
        }
    }

    public class Department
    {
        public string DeptName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string deptName)
        {
            DeptName = deptName;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public Company(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department dept)
        {
            Departments.Add(dept);
        }
    }

    public class Engine
    {
        public string Type { get; set; }

        public Engine(string type)
        {
            Type = type;
        }
    }

    public class Car
    {
        public string Model { get; set; }
        private Engine engine;

        public Car(string model, string engineType)
        {
            Model = model;
            engine = new Engine(engineType);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{Model} with {engine.Type} engine.");
        }
    }

    public interface IDrawable
    {
        void Draw();
    }

    public abstract class Shape : IDrawable
    {
        public abstract double Area();
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Draw()
        {
            Console.WriteLine("   ***   ");
            Console.WriteLine(" *     * ");
            Console.WriteLine("   ***   ");
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override void Draw()
        {
            Console.WriteLine("*********");
            Console.WriteLine("*       *");
            Console.WriteLine("*********");
        }
    }

    public static class IdGenerator
    {
        private static int Id = 0;
        public static int GenerateId() => ++Id;
    }

    public class Grade
    {
        public int Value { get; set; }
        public Grade(int value) { Value = value; }
        public static Grade operator +(Grade g1, Grade g2)
        {
            return new Grade(g1.Value + g2.Value);
        }
        public static bool operator ==(Grade g1, Grade g2)
        { 
            return g1.Value == g2.Value;
        }
        public static bool operator !=(Grade g1, Grade g2)
        { 
            return g1.Value != g2.Value;
        }
        public override bool Equals(object obj) => obj is Grade g && g.Value == Value;
        public override int GetHashCode() => Value.GetHashCode();
    }

    public enum CourseLevel { Beginner, Intermediate, Advanced }


    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Sheikhon");
            Department dept1 = new Department("D1");
            Department dept2 = new Department("D2");

            company.AddDepartment(dept1);
            company.AddDepartment(dept2);

            Employee emp1 = new Employee("Mohamed");
            Employee emp2 = new Employee("Nasser");
            Employee emp3 = new Employee("Ahmed");
            Employee emp4 = new Employee("Mostafa");
            Employee emp5 = new Employee("Salma");
            Employee emp6 = new Employee("Rahaf");

            dept1.AddEmployee(emp1);
            dept2.AddEmployee(emp2);
            dept2.AddEmployee(emp3);
            dept1.AddEmployee(emp4);
            dept2.AddEmployee(emp5);
            dept2.AddEmployee(emp6);

            Instructor instructor1 = new Instructor("Dr.Salah", 50);
            Instructor instructor2 = new Instructor("Dr.Reham", 45);
            instructor1.Introduce();
            instructor2.Introduce();

            Course course1 = new Course("C# Basics", CourseLevel.Beginner);
            Course course2 = new Course("Advanced C#", CourseLevel.Advanced);

            instructor1.TeachCourse(course1);
            instructor2.TeachCourse(course2);

            Student student1 = new Student("Eslam", 20);
            Student student2 = new Student("Rahma", 19);
            Student student3 = new Student("Hany", 21);

            student1.Introduce();
            student1.RegisterCourse(course1);
            student1.RegisterCourse(course2);
            student2.Introduce();
            student2.RegisterCourse(course1);
            student2.RegisterCourse(course2);
            student3.Introduce();
            student3.RegisterCourse(course1);

            student1.Grades.Add(new Grade(70));
            student1.Grades.Add(new Grade(95));
            student2.Grades.Add(new Grade(85));
            student2.Grades.Add(new Grade(79));
            student3.Grades.Add(new Grade(99));


            List<Student> allStudents = new List<Student>();
            allStudents.Add(student1);
            allStudents.Add(student2);
            allStudents.Add(student3);

            Console.WriteLine("\nReport:");
            Console.WriteLine("\nStudents:");
            foreach (var student in allStudents)
            {
                Console.Write($"{student.Name} enrolled in: ");
                foreach (var c in student.Courses)
                    Console.Write($"{c.CourseName}, ");

                Grade total = new Grade(0);
                foreach (var g in student.Grades)
                    total += g;

                Console.WriteLine($"Total Grade: {total.Value}");
            }

            Console.WriteLine("\nInstructors:");
            foreach (var instructor in new List<Instructor> { instructor1, instructor2 })
            {
                Console.Write($"{instructor.Name} teaches: ");
                List<string> courses = new List<string>();
                if (course1.Instructor == instructor) courses.Add(course1.CourseName);
                if (course2.Instructor == instructor) courses.Add(course2.CourseName);

                Console.WriteLine(string.Join(", ", courses));
            }

            Console.WriteLine("\nEmployees:");
            foreach (var dept in company.Departments)
            {
                Console.WriteLine($"Department: {dept.DeptName}");

                if (dept.Employees.Count == 0)
                {
                    Console.WriteLine("  No employees in this department.");
                }
                else
                {
                    foreach (var emp in dept.Employees)
                    {
                        Console.WriteLine($"  Employee: {emp.EmpName}");
                    }
                }
            }


            Console.WriteLine("\nDepartments:");
            foreach (var dept in company.Departments)
            {
                Console.WriteLine($"{dept.DeptName} has {dept.Employees.Count} employees");
            }

            List<Shape> shapes = new List<Shape> { new Circle(4), new Rectangle(2, 4) };
            Console.WriteLine("\nShapes:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.Area()}");
                shape.Draw();
            }
        }
    }
}
