using System;

namespace ConsoleApp14
{
    // definera
    public class Vehicle
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
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // skapa en vehicle object
            Vehicle myVehicle = new Vehicle("Model ABC", 2024);

            // bestäm totala km
            myVehicle.TotalKilometers = 5000;

            // hämta och printa
            Console.WriteLine("Model: " + myVehicle.Model);
            Console.WriteLine("Manufacturing Year: " + myVehicle.ManufacturingYear);
            Console.WriteLine("Total Kilometers: " + myVehicle.TotalKilometers);
        }
    }
}
