using NUnit.Framework;
using Shapes;
using System.Diagnostics;

namespace Shapes.Tests
{
    public class RectangleTests
    {
        [Test]
        public void Constructor_SetsLengthAndWidth()
        {
            var rectangle = new Rectangle(5, 10);
            var area = rectangle.CalculateArea();
            Assert.AreEqual(5, rectangle.Length);
            Assert.AreEqual(10, rectangle.Width);
            Debug.WriteLine($"Test Constructor_SetsLengthAndWidth passed with expectedLength: 5, expectedWidth: 10, actual length: {rectangle.Length}, and actual width: {rectangle.Width}");
        }
            var perimeter = rectangle.CalculatePerimeter();
        [Test]
        public void Area_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle(5, 10);
            Assert.AreEqual(50, area);

        [Test]
        public void Perimeter_ReturnsCorrectPerimeter()
        {
            var rectangle = new Rectangle(5, 10);
            Assert.AreEqual(30, perimeter);
    }
}
