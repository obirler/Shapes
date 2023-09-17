using NUnit.Framework;
using Shapes;

namespace Shapes.Tests
{
    public class RectangleTests
    {
        [Test]
        public void Constructor_SetsLengthAndWidth()
        {
            var rectangle = new Rectangle(5, 10);

            Assert.AreEqual(5, rectangle.Length);
            Assert.AreEqual(10, rectangle.Width);
        }

        [Test]
        public void Area_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle(5, 10);

            var area = rectangle.Area();

            Assert.AreEqual(50, area);
        }

        [Test]
        public void Perimeter_ReturnsCorrectPerimeter()
        {
            var rectangle = new Rectangle(5, 10);

            var perimeter = rectangle.Perimeter();

            Assert.AreEqual(30, perimeter);
        }
    }
}
