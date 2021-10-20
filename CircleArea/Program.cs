// Elin Ericstam SUT21
using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle 1
            Circle circle1 = new Circle(); 
            circle1.Radius = 5;

            Console.WriteLine("\nCirkel 1: ");
            circle1.GetArea();
            circle1.GetPerimeter();
            circle1.GetVolume();

            // Circle 2
            Circle circle2 = new Circle();
            circle2.Radius = 6;

            Console.WriteLine("\nCirkel 2: ");
            circle2.GetArea();
            circle2.GetPerimeter();
            circle2.GetVolume();

            //Triangle 1
            Triangle triangle1 = new Triangle();
            triangle1.Height = 5;
            triangle1.Base = 3;

            Console.WriteLine("\nTriangel 1: ");
            triangle1.GetArea();
            triangle1.GetPerimeter();
            triangle1.GetVolume();
        }
    }

    public class Circle
    {
        public float Pi = 3.141f;
        public int Radius;

        public void GetArea() // Calculates and prints area of a circle
        {
            float area = Radius * Radius * Pi;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Arean för en cirkel med radien {Radius} är: {area}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void GetPerimeter() // Calculates and prints perimeter of a circle
        {
            float perimeter = 2 * Pi * Radius;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Omkretsen för en cirkel med radien {Radius} är: {perimeter}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void GetVolume() // Calculates and prints volume of a sphere
        {
            float volume = (4 * Pi * (Radius * 3)) / 3;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Volymen för en sfär med radien {Radius} är: {volume}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class Triangle
    {
        public int Height;
        public int Base;

        public void GetArea() // Calculates and prints area of a triangle
        {
            double area = (Height * Base) / 2;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Area för en triangel med basen {Base} och höjden {Height} är: {area}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void GetPerimeter() // Calculates and prints perimeter of a triangle
        {
            double perimeter = ((Height * 2) + (Base * 2)) / 2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Omkretsen för en triangel med basen {Base} och höjden {Height} är: {perimeter}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void GetVolume() // Calculates and prints volume of a pyramid
        {
            double volume = (((Height * Base) / 2) * Height) / 3;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Volymen för pyramiden är: {volume}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
