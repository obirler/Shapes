using NUnit.Framework;
using Shapes;

namespace Shapes.Tests
{
    public class SquareTests
    {
        [Test]
        public void Constructor_SetsSideLength()
        {
            var square = new Square(5);

            Assert.AreEqual(5, square.SideLength);
        }

        [Test]
        public void Area_ReturnsCorrectValue()
        {
            var square = new Square(5);

            var result = square.Area();

            Assert.AreEqual(25, result);
        }

        [Test]
        public void Perimeter_ReturnsCorrectValue()
        {
            var square = new Square(5);

            var result = square.Perimeter();

            Assert.AreEqual(20, result);
        }
    }
}
