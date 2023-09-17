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

            bool testResult = 5 == square.SideLength;
            Assert.AreEqual(5, square.SideLength);
            Debug.WriteLine($"Test Constructor_SetsSideLength passed with expected SideLength: 5 and actual SideLength: {square.SideLength}");
            Debug.WriteLine($"Test Constructor_SetsSideLength passed: {testResult}");
        }

        [Test]
        public void Area_ReturnsCorrectValue()
        {
            var square = new Square(5);

            var result = square.Area();

            bool testResult = 25 == result;
            Assert.AreEqual(25, result);
            Debug.WriteLine($"Test Area_ReturnsCorrectValue passed with expected Area: 25 and actual Area: {result}");
            Debug.WriteLine($"Test Area_ReturnsCorrectValue passed: {testResult}");
        }

        [Test]
        public void Perimeter_ReturnsCorrectValue()
        {
            var square = new Square(5);

            var result = square.Perimeter();

            bool testResult = 20 == result;
            Assert.AreEqual(20, result);
            Debug.WriteLine($"Test Perimeter_ReturnsCorrectValue passed with expected Perimeter: 20 and actual Perimeter: {result}");
            Debug.WriteLine($"Test Perimeter_ReturnsCorrectValue passed: {testResult}");
        }
    }
}
