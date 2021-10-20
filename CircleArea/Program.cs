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

            circle1.GetArea(circle1.Radius);
            circle1.GetPerimeter(circle1.Radius);
            circle1.GetVolume(circle1.Radius);

            // Circle 2
            Circle circle2 = new Circle();
            circle2.Radius = 6;

            circle2.GetArea(circle2.Radius);
            circle2.GetPerimeter(circle2.Radius);
            circle2.GetVolume(circle2.Radius);
        }
    }

    public class Circle
    {
        public float Pi = 3.141f;
        public int Radius;

        public void GetArea(int radius) // Calculates and prints area of a circle
        {
            float area = radius * radius * Pi;
            Console.WriteLine($"Arean för en cirkel med radien {radius} är: {area}\n");
        }

        public void GetPerimeter(int radius) // Calculates and prints perimeter of a circle
        {
            float perimeter = 2 * Pi * radius;
            Console.WriteLine($"Omkretsen för en cirkel med radien {radius} är: {perimeter}\n");
        }

        public void GetVolume(int radius) // Calculates and prints volume of a sphere
        {
            float volume = (4 * Pi * (radius * 3)) / 3;
            Console.WriteLine($"Volymen för en sfär med radien {radius} är: {volume}\n");
        }
    }
}
