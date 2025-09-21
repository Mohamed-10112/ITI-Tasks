using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Range<T> where T : IComparable<T>
    {
        T min;
        T max;
        public Range(T min, T max)
        {
            this.min = min;
            this.max = max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }
        public dynamic Length()
        {
            return (dynamic)max - (dynamic)min;
        }
    }
    public class FixedSizeList<T>
    {
        private T[] _items;
        private int count;     
        private int capacity;   
        public FixedSizeList(int capacity)
        {
            this.capacity = capacity;
            this._items = new T[capacity];
            this.count = 0;
        }
        public void Add(T item)
        {
            if (count >= capacity)
                throw new InvalidOperationException("List is full");

            _items[count] = item;
            count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index");

            return _items[index];
        }
    }
    internal class Program
    {
        static void OptimizedBubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        flag = true;
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
                if (!flag)
                {
                    return;
                }
            }
        }

        static void ReverseArrayList(ArrayList arr)
        {
            int start = 0;
            int end = arr.Count - 1;
            while (start < end)
            {
                object temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        static List<int> GetEvenNumbers(List<int> list)
        {
            List<int> evenList = new List<int>();
            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
            }
            return evenList;
        }

        static int FirstNonRepeatedChar(string str)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (freq[str[i]] == 1)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            // 1
            // we can optimize bubble sort by implementing early stopping
            //int[] arr = { 5, 4, 1, 2, 3, 6 };
            //OptimizedBubbleSort(arr);
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}



            // 2
            //Range<int> range = new Range<int>(50, 100);
            //Console.WriteLine(range.IsInRange(30));
            //Console.WriteLine(range.IsInRange(75));
            //Console.WriteLine("Length: " + range.Length());



            // 3
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            //ReverseArrayList(list);
            //foreach (var i in list)
            //{
            //    Console.Write(i + " ");
            //}



            // 4
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> evenList = GetEvenNumbers(list);
            //foreach (int i in evenList)
            //{
            //    Console.Write(i + " ");
            //}



            // 5
            //FixedSizeList<int> list = new FixedSizeList<int>(3);
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            ////list.Add(40); //exception
            //Console.WriteLine(list.Get(1));
            ////Console.WriteLine(list.Get(3)); //exception



            // 6
            string str = "mmaialinnk"; // l -> 5
            int index = FirstNonRepeatedChar(str);
            Console.WriteLine(index);
        }


    }
}
