using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class AreaCalculator
    {
        /// <summary>
        /// Вычисление площади фигуры, без знания типа фигуры
        /// </summary>
        /// <code>
        /// int result = Add(2, 3);
        /// Console.WriteLine(result); // Выведет 5
        /// </code>
        public static double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
