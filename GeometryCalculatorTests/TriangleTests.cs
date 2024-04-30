using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeometryCalculator;


namespace GeometryCalculatorTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleSidesValidator_ZeroSide()
        {
            double side_A = 0;
            double side_B = 1;
            double side_C = 2;
            
            Assert.ThrowsException<ArgumentException>(() => new Triangle(side_A, side_B, side_C));
        }

        [TestMethod]
        public void TriangleSidesValidator_NegativeSide()
        {
            double side_A = -1;
            double side_B = 4;
            double side_C = 7;

            Assert.ThrowsException<ArgumentException>(() => new Triangle(side_A, side_B, side_C));
        }

        [TestMethod]
        public void TrianglePossibility()
        {
            double side_A = 1;
            double side_B = 2;
            double side_C = 7;

            Assert.ThrowsException<ArgumentException>(() => new Triangle(side_A, side_B, side_C));
        }

        [TestMethod]
        public void TriangleCorrectSquare()
        {
            double side_A = 6;
            double side_B = 9;
            double side_C = 4;

            double expectedTriangreSquare = 9.562;

            Triangle triangle = new Triangle(side_A, side_B, side_C);

            double triangreSquare = Math.Round(triangle.GetSquare(), 3);

            Assert.AreEqual(expectedTriangreSquare, triangreSquare);
             
        }

        [TestMethod]
        public void TriangleIsRightAngled()
        {
            double side_A = 5;
            double side_B = 3;
            double side_C = 4;

            bool expected = true;

            Triangle triangle = new Triangle(side_A, side_B, side_C);

            bool rightAngledTriangle = triangle.IsRightAngled();

            Assert.AreEqual(expected, rightAngledTriangle);
        }

    }
}
