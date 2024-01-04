using System;

namespace ShapeAreas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Give a side length for a square and I will give the area of the square.");
            Console.Write("Side: ");
            double squareSide = double.Parse(Console.ReadLine());
            AreaOfSquare(squareSide);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Give a width and height for a rectangle and I will give the area of the rectangle.");
            Console.Write("Width: ");
            double rWidth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double rHeight = double.Parse(Console.ReadLine());
            AreaOfRectangle(rWidth, rHeight);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Give a base and height for a triangle and I will give the area of the triangle.");
            Console.Write("Base: ");
            double hBase = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            AreaOfTriangle(hBase, height);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Give a radius for a circle and I will give the area of the circle.");
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
            Console.WriteLine("-------------------------------------------------------------------------------");

        }

        public static void AreaOfCircle(double radius)
        {
            Console.Write("Area of circle is: ");
            Console.WriteLine(Math.PI * radius * radius); 
        }

        public static void AreaOfRectangle(double width, double height)
        {
            Console.Write("Area of rectangle is: ");
            Console.WriteLine(width * height);
        }

        public static void AreaOfSquare(double side)
        {
            Console.Write("Area of square is: ");
            Console.WriteLine(side * side);
        }
        public static void AreaOfTriangle(double hBase, double height)
        {
            Console.Write("Area of triangle is: ");
            Console.WriteLine((hBase * height) / 2);
        }
    }
}