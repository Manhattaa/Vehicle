using System;

namespace Vehicles
{
    // definera en abstract Vehicle Class
    public abstract class Vehicle
    {
        // medlemsvariabler
        private string model;
        private int manufacturingYear;
        private int totalKilometers;

        // property for total km
        public int TotalKilometers
        {
            get { return totalKilometers; }
            set { totalKilometers = value; }
        }

        // Property för modell
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // property för manufacturingyear
        public int ManufacturingYear
        {
            get { return manufacturingYear; }
            set { manufacturingYear = value; }
        }

        // Konstruktor
        public Vehicle(string model, int manufacturingYear)
        {
            this.model = model;
            this.manufacturingYear = manufacturingYear;
            totalKilometers = 0; // totala km = 0
        }
        //abstrakt metod för att printa information
        public abstract void PrintInfo();
    }

    //subklass "Car"
    public class Car : Vehicle
    {
        
        public Car(string model, int manufacturingYear) : base(model, manufacturingYear)
        { 
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Motorcykel Modell: " + Model);
            Console.WriteLine("Brukningsår " + ManufacturingYear);
            Console.WriteLine("Miltal: " + TotalKilometers);
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(string model, int manufacturingYear) : base(model, manufacturingYear)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Motorcykel Modell: " + Model);
            Console.WriteLine("Bruknings år: " + ManufacturingYear);
            Console.WriteLine("Miltal: " + TotalKilometers);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // skapa en vehicle object
            Vehicle car = new Car("Car 123", 1972);
            Vehicle motorcycle = new Motorcycle("Motorcycle 123", 1972);


            // bestäm totala km
            car.TotalKilometers = 5000;
            motorcycle.TotalKilometers = 3000;

            // hämta och printa
            car.PrintInfo();
            Console.WriteLine();
            motorcycle.PrintInfo();
        }
    }
}
