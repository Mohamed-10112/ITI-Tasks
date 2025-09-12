using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Time
    {
        public int hours;
        public int minutes;
        public int seconds;

        public void Print()
        {
            Console.WriteLine($"{hours}H:{minutes}M:{seconds}S");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Enter number of students: ");
            //int numOfStudents = int.Parse(Console.ReadLine());
            //string[] studentNames = new string[numOfStudents];
            //for (int i = 0; i < numOfStudents; i++)
            //{
            //    Console.Write($"Enter name for student {i + 1}: ");
            //    studentNames[i] = Console.ReadLine();
            //}
            //Console.WriteLine("\nStudent Names:");
            //foreach (String name in studentNames)
            //{
            //    Console.WriteLine(name);
            //}



            //2
            //Console.Write("Enter number of tracks: ");
            //int numOfTracks = int.Parse(Console.ReadLine());
            //Console.Write("Enter number of students per track: ");
            //int studentsPerTrack = int.Parse(Console.ReadLine());
            //int[,] ages = new int[numOfTracks, studentsPerTrack];
            //for (int i = 0; i < numOfTracks; i++)
            //{
            //    Console.WriteLine($"\nTrack {i + 1}:");
            //    for (int s = 0; s < studentsPerTrack; s++)
            //    {
            //        Console.Write($"Enter age for student {s + 1}: ");
            //        ages[i, s] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\nAge Averages per Track:");
            //for (int i = 0; i < numOfTracks; i++)
            //{
            //    int sum = 0;
            //    Console.Write($"Track {i + 1}: ");
            //    for (int j = 0; j < studentsPerTrack; j++)
            //    {
            //        sum += ages[i, j];
            //    }
            //    double avg = (double)sum / studentsPerTrack;
            //    Console.WriteLine($"Average = {avg}");
            //}



            //3
            Time currentTime = new Time();
            currentTime.hours = 22;
            currentTime.minutes = 33;
            currentTime.seconds = 11;
            currentTime.Print();
        }
    }
}
