using Newtonsoft.Json;
using NUnit.Framework;
using Shapes;

namespace Shapes.Tests
{
    public class JsonTests
    {
        [Test]
        public void SerializeCircle_ReturnsExpectedJson()
        {
            // Arrange
            Circle circle = new Circle(5.0);
            string expectedJson = "{\"Radius\":5.0}";

            // Act
            string actualJson = JsonConvert.SerializeObject(circle);

            // Assert
            Assert.AreEqual(expectedJson, actualJson);
        }

        [Test]
        public void DeserializeCircle_ReturnsExpectedCircle()
        {
            // Arrange
            string json = "{\"Radius\":5.0}";
            Circle expectedCircle = new Circle(5.0);

            // Act
            Circle actualCircle = JsonConvert.DeserializeObject<Circle>(json);

            // Assert
            Assert.AreEqual(expectedCircle.Radius, actualCircle.Radius);
        }
    }
}
