using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public class Triangle:Figure
    {
        public Triangle(double side_A, double side_B, double side_C)
        {
            if (side_A <= 0 || side_B <= 0 || side_C <= 0)
            {
                throw new ArgumentException("Значения сторон треугольника должны быть больше 0!");
            }
            if (!isTrianglePossible(side_A, side_B, side_C))
            {
                throw new ArgumentException("Треугольник с такими сторонами не возможен!");
            }

            Side_A = side_A;
            Side_B = side_B;
            Side_C = side_C;
        }

        public double Side_A { get; }
        public double Side_B { get; }
        public double Side_C { get; }

        public override void GetFigureInfo()
        {
            Console.WriteLine($"Треугольник со сторонами: {Side_A}, {Side_B}, {Side_C}");
            Console.WriteLine($"Площадь: {GetSquare(): 0.00}");

            if (IsRightAngled())
                Console.WriteLine("Треугольник - прямоугольный");
            else
                Console.WriteLine("Треугольник - не прямоугольный");
        }

        private bool isTrianglePossible(double side_A, double side_B, double side_C)
        {
            return ((side_A + side_B) > side_C) && ((side_A + side_C) > side_B) && ((side_B + side_C) > side_A);
        }

        public override double GetSquare()
        {
            double triangleSemiperimeter = (Side_A + Side_B + Side_C) / 2d;
            double triangleSquare = Math.Sqrt(triangleSemiperimeter * (triangleSemiperimeter - Side_A) * (triangleSemiperimeter - Side_B) * (triangleSemiperimeter - Side_C));
            return triangleSquare;
        }


        public bool IsRightAngled()
        {

            double[] triangleSides = new double[3] { Side_A, Side_B, Side_C };
            Array.Sort(triangleSides);

            double triangleСatheterPowSum = Math.Pow(triangleSides[0], 2) + Math.Pow(triangleSides[1], 2);
            double triangleHypotenusePow = Math.Pow(triangleSides[2], 2);

            return triangleHypotenusePow == triangleСatheterPowSum;
        }
    }
}
