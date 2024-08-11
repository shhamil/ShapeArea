using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Каждая из сторон треугольника, должна быть больше 0!");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Треугольника с такими сторона не существует!");

            A = a;
            B = b;
            C = c;
        }

        public override double CalculateArea()
        {
            double half_perimetr = (A + B + C) / 2;
            return Math.Sqrt(half_perimetr * (half_perimetr - A) * (half_perimetr - B) * (half_perimetr - C));
        }

    }
}
