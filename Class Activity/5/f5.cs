using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{

    public enum CarType
    {
        Hatchback,
        Sedan,
        SUV,
        Coupe
    }
    public interface IDrive
    {
        string UseFor();
    }
    public class Vehicle
    {
        string name;
        int wheelsNumber;

        public Vehicle(string name, int number)
        {
            this.name = name;
            this.wheelsNumber = number;
        }
    }
    public class Car : Vehicle, IDrive
    {
        
        CarType type;

        public Car(string name, int number, CarType type) : base(name, number)
        {
            this.type = type;
        }

        public string UseFor()
        {
            string use = "personal vehicle and uses family trip";

            return use;
        }

    }
    public class Truck:Vehicle ,IDrive
    {
        bool haveTrailer;
        public Truck(string name, int number , bool haveTrailer):base(name,number)
        {
            this.haveTrailer = haveTrailer;
        }

        public string UseFor()
        {
            string use = "it uses for Cargo transportation";
            return use;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Car Name: ");
            string carName = Console.ReadLine();
            Console.Write("Enter Car WheelNumber: ");
            int carWheelNumber = int.Parse(Console.ReadLine());
            var rnd = new Random();
            CarType carType = (CarType)rnd.Next(4);

            Car mycar = new Car(carName, carWheelNumber, carType);



            Console.Write("\nEnter Truck Name: ");
            string truckName = Console.ReadLine();
            Console.Write("Enter Truck WheelNumber: ");
            int truckWheelNumber = int.Parse(Console.ReadLine());
            Console.Write("Have Trailer?(0/1): "); 
            string haveTrailerInput = Console.ReadLine();
            bool haveTrailer;
            if (haveTrailerInput == "1")
                haveTrailer = true;
            else
                haveTrailer = false;

            Truck mytruck = new Truck(truckName,truckWheelNumber,haveTrailer);



            IDrive[] drives = new IDrive[2];
            drives[0] = mycar;
            drives[1] = mytruck;

            Console.WriteLine("\n");
            Console.WriteLine(drives[0].UseFor());
            Console.WriteLine(drives[1].UseFor());
            
            Console.ReadKey();
        }
    }


}