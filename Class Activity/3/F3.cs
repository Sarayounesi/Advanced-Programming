using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please Enter First Name of First Student :");
            var fn = Console.ReadLine();
            Console.WriteLine($"Please Enter Last Name of {fn}:");
            var ln = Console.ReadLine();
            Console.WriteLine($"Please Enter Student ID of {fn} {ln}:");
            var id = int.Parse(Console.ReadLine());
            var s1 = new Student(fn, ln, id);

            Console.WriteLine($"\nPlease Enter First Name of Second Student :");
            fn = Console.ReadLine();
            Console.WriteLine($"Please Enter Last Name of {fn}:");
            ln = Console.ReadLine();
            Console.WriteLine($"Please Enter Student ID of {fn} {ln}:");
            id = int.Parse(Console.ReadLine());
            var s2 = new Student(fn, ln, id);

            Console.WriteLine($"\nPlease Enter First Name of Third Student :");
            fn = Console.ReadLine();
            Console.WriteLine($"Please Enter Last Name of {fn}:");
            ln = Console.ReadLine();
            Console.WriteLine($"Please Enter Student ID of {fn} {ln}:");
            id = int.Parse(Console.ReadLine());
            var s3 = new Student(fn, ln, id);

            Console.WriteLine("\n");

            studentInfo(s1, s2, s3);

            var s4 = s1.Clone();
            s1.changeInfo('Q', 3);
            studentInfo(s1, s4);

            var s5 = s2.badClone();
            s2.changeInfo('Q', 4);
            studentInfo(s2, s5);

            Console.ReadLine();
        }

        public static void studentInfo(params Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.stdInfo());
            }
        }
    }

    class Student
    {
        private string[] name = new string[2];
        private int id;

        public Student(string FirstName, string LastName, int StudentID)
        {
            name[0] = FirstName;
            name[1] = LastName;
            id = StudentID;
        }

        public Student Clone()
        {
            var newStudent = new Student(this.name[0], this.name[1], this.id);
            return newStudent;
        }

        public Student badClone()
        {
            var newStudent = this;
            return newStudent;
        }

        public string stdInfo()
        {
            return name[0] + ' ' + name[1] + " (Student ID : " + id.ToString() + ")";
        }

        public Student changeInfo(char NewCharacter, int AddToID)
        {
            this.name[0] = NewCharacter + this.name[0].Substring(1);
            this.id += +AddToID;
            return this;
        }
    }
}
