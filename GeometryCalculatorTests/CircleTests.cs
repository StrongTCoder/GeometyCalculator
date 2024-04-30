using GeometryCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryCalculatorTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            double radius = 0;

            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }

        [TestMethod]
        public void CircleRadiusIsNegative()
        {
            double radius = -5;

            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }

        [TestMethod]
        public void CircleCorrectSquare()
        {
            double radius = 5;
            double expectedSquare = 78.5;

            Circle circle = new Circle(radius);
            double circleSquare = Math.Round(circle.GetSquare(), 1);

            Assert.AreEqual(expectedSquare, circleSquare);
        }
    }
}
