using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public class Circle: Figure
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус круга должен быть больше 0!");

            Radius = radius;
        }

        public double Radius { get; }

        public override void GetFigureInfo()
        {
            Console.WriteLine($"Круг с радиусом: {Radius}");

            Console.WriteLine($"Площадь круга - {GetSquare(): 0.00}");
        }

        public override double GetSquare()
        {
            double square = Math.PI * Math.Pow(Radius, 2);
            return square;
        }
    }
}
