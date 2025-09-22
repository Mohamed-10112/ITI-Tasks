using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
    public static class Extensions
    {
        public static int WordCount(this string str)
        { 
            var words = str.Split(' ');
            return words.Length;
        }
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
        public static int CalculateAge(this DateTime bDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bDate.Year;
            return age;
        }
        public static string ReverseString(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //var product = createProduct();
            //Console.WriteLine($"Product Name: {product.name}");
            //Console.WriteLine($"Product Price: {product.price}");



            // 2
            //string text = "Hello, world!";
            //int count = text.WordCount();
            //Console.WriteLine($"Number of words: {count}");



            // 3
            //int num1 = 8;
            //int num2 = 5;
            //Console.WriteLine(num1.IsEven());
            //Console.WriteLine(num2.IsEven());



            // 4
            //DateTime birthDate = new DateTime(2003, 11, 10);
            //int age = birthDate.CalculateAge();
            //Console.WriteLine($"Age: {age}");



            // 5
            string text = "hello";
            string reversed = text.ReverseString();
            Console.WriteLine(reversed);
        }
        public static Product createProduct()
        {
            return new Product("Keyboard", 500);
        }
    }
}
