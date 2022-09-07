using MindBox.Geometry;
using System;
using Xunit;

namespace MindBox.Test
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_Success()
        {
            //arrange
            Triangle circle = new Triangle(3, 6, 7);
            Triangle circle1 = new Triangle(6, 12, 6);
            double expected = Math.Sqrt(8 * (8 - 3) * (8 - 6) * (8 - 7));
            double expected1 = Math.Sqrt(12 * (12 - 6) * (12 - 12) * (12 - 6));

            //act
            double result = circle.GetSquare();
            double result1 = circle1.GetSquare();

            //assert
            Assert.Equal(expected, result);
            Assert.Equal(expected1, result1);
        }

        [Fact]
        public void Triangle_FailOnWrongValue()
        {
            //arrange
            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Triangle(12,0,2).GetSquare());
            Assert.Throws<ArgumentException>(() => new Triangle(5,-2,5).GetSquare());
        }

        [Fact]
        public void Triangle_FailOnWrongTriangle()
        {
            //arrange
            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Triangle(24, 4, 2).GetSquare());
            Assert.Throws<ArgumentException>(() => new Triangle(7, 1, 5).GetSquare());
        }

        [Fact]
        public void Triangl_IsRectangularSuccess()
        {
            //arrange
            //act
            //assert
            Assert.True(new Triangle(3, 4, 5).IsRectangular());
            Assert.False(new Triangle(3, 2, 5).IsRectangular());
        }
    }
}
