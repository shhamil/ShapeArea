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
        public static double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
