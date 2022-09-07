using System;
using System.Linq;

namespace MindBox.Geometry
{
    public class Triangle : IShape
    {
        private double[] _sides;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The lengths of the sides must be greater than 0");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("The lengths of the sides have incorrect values");
            }

            _sides = new[] { a, b, c };
        }

        public double GetSquare()
        {
            var p = _sides.Sum() / 2;
            return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
        }

        public bool IsRectangular()
        {
            Array.Sort(_sides);
            return Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2);
        }
    }
}
