using NUnit.Framework;
using ShapeArea;
using System;

namespace TestShapeArea
{
    public class Tests
    {
        [Test]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(5);
            Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25));
        }

        [Test]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(6));
        }

        [Test]
        public void CalculateAreaUsingAbstractClassTest()
        {
            Shape shape = new Circle(5);
            Assert.That(AreaCalculator.CalculateArea(shape), Is.EqualTo(Math.PI * 25));

            shape = new Triangle(3, 4, 5);
            Assert.That(AreaCalculator.CalculateArea(shape), Is.EqualTo(6));
        }
    }
}