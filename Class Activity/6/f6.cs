using System;
using System.Collections.Generic;

namespace class6
{
    class LimitedCollection<T> where T : IComparable<T>
    {
        T MAX_NUM;
        T MIN_NUM;
        List<T> collection = new List<T>();
        public int INDEX { get { return collection.Count; } }
        public LimitedCollection(T MIN_NUM, T MAX_NUM)
        {
            this.MAX_NUM = MAX_NUM;
            this.MIN_NUM = MIN_NUM;
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
                if (item.CompareTo(MIN_NUM) < 0)
                {
                    MIN_NUM = item;
                }
            }
            collection.Remove(MIN_NUM);
            return MIN_NUM;
        }
        public void itemsAccepted()
        {
            foreach (T item in this.collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
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
            int i;
            for (i = 0; i < input.Length; i++)
            {
                Console.Write($"Item{i + 1}: ");
                str.Insert(input[i]);
            }
            str.itemsAccepted();
            try
            {
                str.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"The number of members: {str.INDEX}");


            int intMIN_NUM, intMAX_NUM;
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
                    Console.WriteLine("It must be an integer number");
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
            int[] num;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your integer num to add:");
                    num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    break;
                }
                catch
                {
                    Console.WriteLine("They must be integer num.");
                }
            }
            int w;
            for (w = 0; w < num.Length; w++)
            {
                int q;
                q = w + 1;
                Console.Write($"I{ q}: ");
                intiger.Insert(num[w]);
            }
            intiger.itemsAccepted();
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