using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            //// query 1
            //var newNumbers = numbers.Distinct().OrderBy(x => x);
            //foreach (var number in newNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //// query 2
            //var query2 = newNumbers.Select(x => new { Number = x, Multiply = x * x });
            //Console.WriteLine("---------");
            //foreach (var number in query2)
            //{
            //    Console.WriteLine(number);
            //}



            // 2
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            //// query 1
            //var newNames = names.Where(x => x.Length == 3);
            //foreach (var name in newNames)
            //{
            //    Console.WriteLine(name);
            //}
            //// query 2
            //var query2 = names.Where (x => x.ToLower().Contains('a'));
            //Console.WriteLine("---------");
            //foreach (var name in query2) 
            //{ 
            //    Console.WriteLine(name);
            //}
            //// query 3
            //var query3 = names.Take(2);
            //Console.WriteLine("---------");
            //foreach (var name in query3)
            //{
            //    Console.WriteLine(name);
            //}



            // 3
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 22, Name = "EF" },
                        new Subject { Code = 33, Name = "UML" }
                    }
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 22, Name = "EF" },
                        new Subject { Code = 34, Name = "XML" },
                        new Subject { Code = 25, Name = "JS" }
                    }
                },
                new Student
                {
                    ID = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 22, Name = "EF" },
                        new Subject { Code = 25, Name = "JS" }
                    }
                },
                new Student
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Ali",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 33, Name = "UML" }
                    }
                }
            };
            // query 1
            var query1 = students
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    NoOfSubjects = x.Subjects.Length
                });
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }
            // query 2
            var query2 = students
                .OrderByDescending(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName
                });
            Console.WriteLine("---------");
            foreach (var item in query2)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            // query 3
            var query3 = students
            .SelectMany(x => x.Subjects, (x, subj) => new
            {
                StudentName = x.FirstName + " " + x.LastName,
                SubjectName = subj.Name
            });
            Console.WriteLine("---------");
            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
            // bonus
            var bonus = students
            .GroupBy(x => x.FirstName + " " + x.LastName)
            .Select(y => new
            {
                StudentName = y.Key,
                Subjects = y.SelectMany(x => x.Subjects).Select(subj => subj.Name)
            });
            Console.WriteLine("---------");
            foreach (var group in bonus)
            {
                Console.WriteLine(group.StudentName);
                foreach (var subj in group.Subjects)
                {
                    Console.WriteLine("   " + subj);
                }
            }
        }
    }
}
