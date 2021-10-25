// Elin Ericstam SUT21
using System;

namespace CircleArea
{
    public class Circle
    {
        public float _pi = 3.141f;
        public int _radius;

        public Circle(int Radius) // Constructor
        {
            this._radius = Radius;
        }

        public float GetArea() // Calculates and prints area of a circle
        {
            float area = _radius * _radius * _pi;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Arean för cirkeln är: {area}");
            Console.ForegroundColor = ConsoleColor.Gray;

            return area;
        }

        public void GetPerimeter() // Calculates and prints perimeter of a circle
        {
            float perimeter = 2 * _pi * _radius;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Omkretsen cirkeln är: {perimeter}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public float GetVolume() // Calculates and prints volume of a sphere
        {
            float volume = (4 * _pi * (_radius * _radius * _radius)) / 3;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Volymen sfären är: {volume}");
            Console.ForegroundColor = ConsoleColor.Gray;

            return volume;
        }
    }

    public class Triangle
    {
        public int _height;
        public int _base;

        public Triangle(int Height, int Base) // Constructor
        {
            this._height = Height;
            this._base = Base;
        }

        public double GetArea() // Calculates and prints area of a triangle
        {
            double area = (_height * _base) / 2;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Arean för triangeln är: {area}");
            Console.ForegroundColor = ConsoleColor.Gray;

            return area;
        }

        public double GetPerimeter() // Calculates and prints perimeter of a triangle
        {
            double perimeter = ((_height * 2) + (_base * 2)) / 2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Omkretsen för triangeln är: {perimeter}");
            Console.ForegroundColor = ConsoleColor.Gray;

            return perimeter;
        }

        public double GetVolume() // Calculates and prints volume of a pyramid
        {
            double volume = (_height * _base) / 3;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Volymen för pyramiden är: {volume}");
            Console.ForegroundColor = ConsoleColor.Gray;

            return volume;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Circle 1
            Circle c1 = new Circle(5); 

            Console.WriteLine("\nCirkel 1: ");
            c1.GetArea(); c1.GetPerimeter(); c1.GetVolume();

            // Circle 2
            Circle c2 = new Circle(6);

            Console.WriteLine("\nCirkel 2: ");
            c2.GetArea(); c2.GetPerimeter(); c2.GetVolume();

            //Triangle 1
            Triangle t1 = new Triangle(5, 3);

            Console.WriteLine("\nTriangel 1: ");
            t1.GetArea(); t1.GetPerimeter(); t1.GetVolume();
        }
    }
}
