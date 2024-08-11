using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeAreaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.CalculateArea());
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea());
        }

        [TestMethod]
        public void TriangleIsRightAngledTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void CalculateAreaUsingInterfaceTest()
        {
            IShape shape = new Circle(5);
            Assert.AreEqual(Math.PI * 25, ShapeAreaCalculator.CalculateArea(shape));

            shape = new Triangle(3, 4, 5);
            Assert.AreEqual(6, ShapeAreaCalculator.CalculateArea(shape));
        }
    }
}
