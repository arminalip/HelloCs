using System;

namespace ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle.cs related exercise
            //FourWheeledVehicles car = new FourWheeledVehicles();
            //car.ChangeColor();

            //car.StartVehicle();

            //car.RunAtFullSpeed();


            //Polymorphism
            /*
            Shape[] shapes = new Shape[4];
            shapes[0] = new Shape();
            shapes[1] = new Circle();
            shapes[2] = new Line();
            shapes[3] = new Triangle();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }*/
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a simple shape.");
        }
    }

    class Circle : Shape
    {
        public new void Draw()
        {
            Console.WriteLine("I am a simple Circle.");
        }
    }

    class Line : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am a simple Line.");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am a simple Traingle.");
        }
    }

}
