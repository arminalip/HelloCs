using System;
namespace ClassProperties
{
    class Vehicle
    {
    }

    class WheeledVehicles : Vehicle
    {
        private string color;
        private decimal price;

        public string Color { get; set; }
        public decimal Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine("Color is changing. \nColor is changed.");
        }
    }

    class FourWheeledVehicles : WheeledVehicles
    {
        private string brangName;
        private string capacity;

        public string BrandName { get; set; }
        public int  Capacity { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Car has started");
        }

        public void RunAtFullSpeed()
        {
            Console.WriteLine("Car is running on full speed");
        }

    }
}
