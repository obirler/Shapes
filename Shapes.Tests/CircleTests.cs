using NUnit.Framework;
using Shapes;
using System.Diagnostics;

namespace Shapes.Tests
{
    public class CircleTests
    {
        [Test]
        public void Constructor_SetsRadius()
        {
            // Arrange
            double expectedRadius = 5.0;

            // Act
            Circle circle = new Circle(expectedRadius);

            // Assert
            Assert.AreEqual(expectedRadius, circle.Radius);
            Debug.WriteLine($"Test Constructor_SetsRadius passed with expectedRadius: {expectedRadius} and actual radius: {circle.Radius}");
        }

        [Test]
        public void Area_ReturnsCorrectValue()
        {
            // Arrange
            double radius = 5.0;
            Circle circle = new Circle(radius);
            double expectedArea = System.Math.PI * radius * radius;

            // Act
            double actualArea = circle.Area();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
            Debug.WriteLine($"Test Area_ReturnsCorrectValue passed with expectedArea: {expectedArea} and actual area: {actualArea}");
        }

        [Test]
        public void Perimeter_ReturnsCorrectValue()
        {
            // Arrange
            double radius = 5.0;
            Circle circle = new Circle(radius);
            double expectedPerimeter = 2 * System.Math.PI * radius;

            // Act
            double actualPerimeter = circle.Perimeter();

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
            Debug.WriteLine($"Test Perimeter_ReturnsCorrectValue passed with expectedPerimeter: {expectedPerimeter} and actual perimeter: {actualPerimeter}");
        }
    }
}
