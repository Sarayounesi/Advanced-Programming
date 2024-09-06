using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void MaxNum(int[] ary)
        {
            int max = 0;
            for (int i = 0; i < ary.Length; i++)
            {
                if (max < ary[i])
                    max = ary[i];
            }
            Console.WriteLine(max);
        }
        static void Main(string[] args)
        {
            int n,i;
            n = int.Parse(Console.ReadLine());
            int[] N = new int[n];
            for (i = 0; i < n; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }
            MaxNum(N);
            Console.ReadKey();
        }
    }
}