using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Enter a character: ");
            //char c = Console.ReadKey().KeyChar;
            //Console.WriteLine("\nASCII code is: {0}",(int)c);



            //2
            //Console.Write("Enter an ASCII code: ");
            //int code = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nCharacter is: {0}", (char)code);



            //3
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}



            //4
            //Console.Write("Enter 1st number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter 2nd number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nSum: " + (num1 + num2));
            //Console.WriteLine("Subtraction: " + (num1 - num2));
            //Console.WriteLine("Multiplication: " + (num1 * num2));



            //5
            //Console.Write("Enter student degree: ");
            //int degree = int.Parse(Console.ReadLine());
            //switch (degree / 10)
            //{
            //    case 10: 
            //    case 9:   
            //        Console.WriteLine("Grade: A");
            //        break;
            //    case 8:
            //        Console.WriteLine("Grade: B");
            //        break;
            //    case 7:   
            //        Console.WriteLine("Grade: C");
            //        break;
            //    case 6: 
            //        Console.WriteLine("Grade: D");
            //        break;
            //    default:
            //        Console.WriteLine("Grade: F");
            //        break;
            //}



            //6
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nMultiplication Table is:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        }
    }
}
