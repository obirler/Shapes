using NUnit.Framework;
using Shapes;
using System.Diagnostics;

namespace Shapes.Tests
{
    public class SquareTests
    {
        [Test]
        public void Constructor_SetsSideLength()
        {
            var square = new Square(5);

            Assert.AreEqual(5, square.SideLength);
            Debug.WriteLine($"Test Constructor_SetsSideLength passed with expected SideLength: 5 and actual SideLength: {square.SideLength}");
        }

        [Test]
        public void Area_ReturnsCorrectValue()
        {
            var square = new Square(5);

            var result = square.Area();

            Assert.AreEqual(25, result);
            Debug.WriteLine($"Test Area_ReturnsCorrectValue passed with expected Area: 25 and actual Area: {result}");
        }

        [Test]
        public void Perimeter_ReturnsCorrectValue()
        {
            var square = new Square(5);

            var result = square.Perimeter();

            Assert.AreEqual(20, result);
            Debug.WriteLine($"Test Perimeter_ReturnsCorrectValue passed with expected Perimeter: 20 and actual Perimeter: {result}");
        }
    }
}
