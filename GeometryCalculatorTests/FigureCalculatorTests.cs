using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeometryCalculator;
using GeometryCalcullator;
using System.Text;
using System.IO;

namespace GeometryCalculatorTests
{
    [TestClass]
    public class FigureCalculatorTests
    {
        [TestMethod]
        public void CorrectCalcilateTriangleSquare()
        {
            double expectedSquare = 9.562;

            Triangle triangle = new Triangle(9,4,6);
            FigureCalculator calculator = new FigureCalculator();

            double figureSquare = Math.Round(calculator.CalculateSquare(triangle), 3);

            Assert.AreEqual(expectedSquare, figureSquare);            
        }

        [TestMethod]
        public void CorrectCalcilateCircleSquare()
        {
            double expectedSquare = 660.52;

            Circle circle = new Circle(14.5);
            FigureCalculator calculator = new FigureCalculator();

            double figureSquare = Math.Round(calculator.CalculateSquare(circle), 3);

            Assert.AreEqual(expectedSquare, figureSquare);
        }

        [TestMethod]
        public void CorrectGetFigureInfo()
        {
            double side_A = 4;
            double side_B = 9;
            double side_C = 7;

            Triangle triangle = new Triangle(side_A, side_B, side_C);
            FigureCalculator calculator = new FigureCalculator();

            using (StringWriter writingString = new StringWriter())
            {
               Console.SetOut(writingString);

                calculator.GetFigureInfo(triangle);
                string expectedOutString = $"Треугольник со сторонами: {side_A}, {side_B}, {side_C}" + Environment.NewLine +
                    $"Площадь: {calculator.CalculateSquare(triangle): 0.00}" + Environment.NewLine + 
                    "Треугольник - не прямоугольный" + Environment.NewLine;

                Assert.AreEqual(expectedOutString, writingString.ToString());
            }
        }
    }
}
