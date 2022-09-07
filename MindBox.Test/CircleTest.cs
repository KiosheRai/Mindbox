using MindBox.Geometry;
using System;
using Xunit;

namespace MindBox.Test
{
    public class CircleTest
    {
        [Fact]
        public void Circle_Success()
        {
            //arrange
            Circle circle = new Circle(3);
            Circle circle1 = new Circle(6);
            double expected = Math.PI * 9;
            double expected1 = Math.PI * 36;

            //act
            double result = circle.GetSquare();
            double result1 = circle1.GetSquare();

            //assert
            Assert.Equal(expected, result);
            Assert.Equal(expected1, result1);
        }

        [Fact]
        public void Circle_FailOnWrongValue()
        {
            //arrange
            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Circle(-2));
            Assert.Throws<ArgumentException>(() => new Circle(-22));
        }

        [Fact]
        public void Circle_FailOnZeroValue()
        {
            //arrange
            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }

}
