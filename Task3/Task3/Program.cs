using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Calc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public float Sum(float a, float b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
        public float Sub(float a, float b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
        public float Mul(float a, float b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            if (a != 0) return a / b;
            else return 0;
        }
        public float Div(float a, float b)
        {
            if (a != 0) return a / b;
            else return 0;
        }
    }

    class Question
    {
        public string Header, Body;
        public int Mark;
        public Question(string header, string body, int mark)
        {
            Header = header; 
            Body = body; 
            Mark = mark;
        }
        public void Show()
        {
            Console.WriteLine($"{Header} ({Mark} Marks)");
            Console.WriteLine(Body);
        }
    }

    class MCQQuestion
    {
        public Question question;
        public string[] Choices;
        public int CorrectAnswer;
        public MCQQuestion(Question q, string[] choices, int correct)
        {
            question = q;
            Choices = choices;
            CorrectAnswer = correct;
        }
        public void Show()
        {
            question.Show();
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}- {Choices[i]}");
            }
        }
        public bool Check(int ans)
        {
            return ans == CorrectAnswer;
        }
    }

    class MCQ
    {
        public MCQQuestion[] Items;
        public MCQ(int size)
        {
            Items = new MCQQuestion[size];
        }
        public void ShowAll()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
                Items[i].Show();
            }
        }
        //Bonus
        public int CalcResult()
        {
            int score = 0;
            for (int i = 0; i < Items.Length; i++)
            {
                Console.Write($"Answer for Q{i + 1}: ");
                int ans = int.Parse(Console.ReadLine());
                if (Items[i].Check(ans))
                    score += Items[i].question.Mark;
            }
            return score;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Calc calc = new Calc();
            //Console.WriteLine("Sum: " + calc.Sum(5, 3));
            //Console.WriteLine("Sum: " + calc.Sum(5.4f, 3.6f));
            //Console.WriteLine("Sub: " + calc.Sub(5, 3));
            //Console.WriteLine("Mul: " + calc.Mul(5, 3));
            //Console.WriteLine("Div: " + calc.Div(10, 2));



            //2
            Console.Write("How many questions? ");
            int numOfQuestions = int.Parse(Console.ReadLine());
            MCQ exam = new MCQ(numOfQuestions);
            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.WriteLine($"\nEnter data for Q{i + 1}:");
                Console.Write("Header: ");
                string h = Console.ReadLine();
                Console.Write("Body: ");
                string b = Console.ReadLine();
                Console.Write("Mark: ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Number of choices: ");
                int c = int.Parse(Console.ReadLine());
                string[] choices = new string[c];
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Choice {j + 1}: ");
                    choices[j] = Console.ReadLine();
                }
                //Bonus
                Console.Write("Correct answer number: ");
                int correct = int.Parse(Console.ReadLine());

                Question q = new Question(h, b, m);
                exam.Items[i] = new MCQQuestion(q, choices, correct);
            }
            exam.ShowAll();
            int total = exam.CalcResult();
            Console.WriteLine($"\nYour total marks = {total}");
        }
    }
}
