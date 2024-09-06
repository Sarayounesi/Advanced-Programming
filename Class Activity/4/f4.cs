using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, family, schoolName, courseName;
            int age;

            Console.WriteLine("Enter Student information: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Family: ");
            family = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("School Name: ");
            schoolName = Console.ReadLine();
            Person student = new Student(name, family, age, schoolName);

            Console.WriteLine("\n");

            Console.WriteLine("Enter Teacher information: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Family: ");
            family = Console.ReadLine();
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Course Name: ");
            courseName = Console.ReadLine();
            Person teacher = new Teacher(name, family, age, courseName);

            Console.WriteLine("\n");


            Console.WriteLine("Student information:");
            Console.WriteLine(student.Information());

            Console.WriteLine("\n");

            Console.WriteLine("Teacher information:");
            Console.WriteLine(teacher.Information());

            Console.WriteLine("\n");

            Check(student);
            Check(teacher);

        }
        public static void Check(object o)
        {
            if(o is Student)
                Console.WriteLine("Student");
            else if(o is Teacher)
                Console.WriteLine("Teacher");
        }
    }
    public class Person
    {
        protected string name;
        protected string family;
        protected int age;

        public Person(string name, string family, int age)
        {
            this.name = name;
            this.family = family;
            this.age = age;

        }
        public string Information()
        {
            return $"Name: {this.name}\nFamily: {this.family}\nAge: {this.age}";
        }

    }
    public class Student : Person
    {
        private string schoolName;
        public Student(string name, string family, int age, string schoolName) : base(name, family, age)
        {
            this.schoolName = schoolName;
        }

    }
    public class Teacher : Person
    {
        private string courseName;
        public Teacher(string name , string family , int age , string courseName):base(name,family,age)
        {
            this.courseName = courseName;
        }
    }

    
}
