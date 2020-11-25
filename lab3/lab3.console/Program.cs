using System;
using Nau.Lib;

namespace Nau.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Trianle(3, new int[] { 0, 3, 0 }, new int[] { 0, 0, 4 });

            double perimeter = triangle.CalculatePerimeter();
            Console.WriteLine("Perimeter: " + perimeter);

            double area = triangle.CalculateArea();
            Console.WriteLine("Area: " + area);
            PrintCoordinates(triangle);
        }

        private static void PrintCoordinates(Trianle triangle)
        {
            Console.Write("Coordinates " +
                "A={x: " + triangle.GetXCoordinate('A') + "; y: " + triangle.GetYCoordinate('A') + "} " +
                "B={x: " + triangle.GetXCoordinate('B') + "; y: " + triangle.GetYCoordinate('B') + "} " +
                "C={x: " + triangle.GetXCoordinate('C') + "; y: " + triangle.GetYCoordinate('C') + "} "
                );
        }
    }
}
