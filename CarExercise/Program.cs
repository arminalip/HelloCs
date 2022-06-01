using System;

namespace CarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            mer.DisplayInfo();
        }
    }
    #region Cars = Solution for Car exercise
    class Cars
    {
        private decimal price;
        protected int maxSpeed;
        public string color;

        protected decimal Price
        { get { return price;  }
            set { price = value; }
        }

        public virtual void DisplayInfo()
        {
            price = 10000;
            maxSpeed = 300;
            color = "Black";

            Console.WriteLine($"Default values : price is {price}, max speed is {maxSpeed} and the color is {color}");
        }
    }
    class Mercedes : Cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            base.color = "Blue";
            base.maxSpeed = 200;
            base.Price = 15000;

            Console.WriteLine($"Override values : price is {Price}, max speed is {maxSpeed} and the color is {color}");

        }
    }
    #endregion
}
