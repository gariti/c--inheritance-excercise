using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Nissan", "Sentra", 2000, "Silver");
            Car otherCar = new Car();
            Truck myTruck = new Truck("Nissan", "Frontier", 2014, "Silver", 10000);

            myCar.PrintDetails();
            otherCar.PrintDetails();
            myTruck.PrintDetails();
            Console.ReadLine();
        }
    }
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract void PrintDetails();
    }

    class Car : Vehicle
    {
        public Car()
        {
            this.Make = "Default";
            this.Model = "Default";
            this.Year = 2000;
            this.Color = "Default";
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public override void PrintDetails()
        {
            Console.WriteLine(String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year));
        }
    }

    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        public Truck(string make, string model, int year, string color, int towcap)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.TowingCapacity = towcap;
        }

        public override void PrintDetails()
        {
            Console.WriteLine(String.Format("{0} - {1} - {2} - {3} - {4}",
                this.Make,
                this.Model,
                this.Color,
                this.Year,
                this.TowingCapacity));
        }
    }
}
