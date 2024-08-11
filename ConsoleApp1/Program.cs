using ShapeArea;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape [] shapes = new Shape[2] { new Circle(5), new Triangle(3, 4, 5) };
            foreach (var shape in shapes)
            {
                Console.WriteLine(AreaCalculator.CalculateArea(shape));
            }

        }
    }



}
