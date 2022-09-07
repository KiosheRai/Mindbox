using System;

namespace MindBox.Geometry
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius must be greater than 0");
            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
