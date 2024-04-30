using GeometryCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalcullator
{
    public class FigureCalculator
    {
        public double CalculateSquare(Figure figure)
        {
            return figure.GetSquare();
        }

        public void GetFigureInfo(Figure figure)
        {
            figure.GetFigureInfo();
        }

    }
}
