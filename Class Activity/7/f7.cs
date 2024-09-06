using System;
using System.Collections;
using System.Collections.Generic;

namespace f_7
{
    class LimitedCollection<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        T MAX_NUM;
        T MIN_NUM;
        List<T> collection = new List<T>();
        public int INDEX
        {
            get
            { return collection.Count; }
        }
        public LimitedCollection(T MIN_NUM, T MAX_NUM)
        {
            this.MAX_NUM = MAX_NUM;
            this.MIN_NUM = MIN_NUM;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<T> Reverse
        {
            get
            {
                for (int i = collection.Count - 1; i >= 0; i--)
                {
                    yield return collection[i];
                }
            }
        }
        public void Insert(T item)
        {
            if (item.CompareTo(MIN_NUM) >= 0 && item.CompareTo(MAX_NUM) <= 0)
            {
                collection.Add(item);
                Console.WriteLine("Added Succesfuly :" + item);
            }
            else
            {
                Console.WriteLine("Error: out of limit value inserted. value is: " + item);
            }
        }
        public T Remove()
        {
            if (this.INDEX == 0)
            {
                throw new Exception("Not found !");
            }
            T MIN_NUM = collection[0];
            foreach (T item in this.collection)
            {
                if (item.CompareTo(MIN_NUM) < 0) { MIN_NUM = item; }
            }
            collection.Remove(MIN_NUM);
            return MIN_NUM;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***welcome to the program lets start***");
            Console.WriteLine("1>Enter MIN_NUM: ");
            string strMIN_NUM = Console.ReadLine();
            Console.WriteLine("2>Enter MAX_NUM: ");
            string strMAX_NUM = Console.ReadLine();
            LimitedCollection<string> str = new LimitedCollection<string>(strMIN_NUM, strMAX_NUM);
            Console.WriteLine("Enter your strings to add to another one:");
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"Item{i + 1}: ");
                str.Insert(input[i]);
            }
            Console.WriteLine("\nItems:");
            foreach (var item in str)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reverse:");
            foreach (var item in str.Reverse)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            try
            {
                str.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"The number of members: {str.INDEX}");

            int intMIN_NUM;
            int intMAX_NUM;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the MIN_NUM: ");
                    intMIN_NUM = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("It must an integer number");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the MAX_NUM: ");
                    intMAX_NUM = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("It must be an integer number");
                }
            }
            LimitedCollection<int> intiger = new LimitedCollection<int>(intMIN_NUM, intMAX_NUM);
            int[] numbers;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your integer numbers to add:");
                    numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    break;
                }
                catch
                {
                    Console.WriteLine("They must be integer numbers.");
                }
            }
            for (int w = 0; w < numbers.Length; w++)
            {
                int q;
                q = w + 1;
                Console.Write($"Item{q}: ");
                intiger.Insert(numbers[w]);
            }
            Console.WriteLine("\nItems:");
            foreach (var item in intiger)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reverse the inputs:");
            foreach (var item in intiger.Reverse)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            try
            {
                intiger.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"The number of members: {intiger.INDEX}");
        }
    }
}