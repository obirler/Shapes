using NUnit.Framework;
using Shapes.Library;

namespace Shapes.Tests
{
    public class ShapeFactoryTests
    {
        [Test]
        public void CreateShapes_ParameterArray_CreatesShapes()
        {
            // Arrange
            ShapeFactory shapeFactory = new ShapeFactory();

            // Act
            Shape[] shapes = shapeFactory.CreateShapes(
                new ShapeParameters { Type = ShapeType.Circle, Radius = 5 },
                new ShapeParameters { Type = ShapeType.Rectangle, Width = 10, Height = 20 },
                new ShapeParameters { Type = ShapeType.Triangle, Base = 8, Height = 6 }
            );

            // Assert
            Assert.AreEqual(3, shapes.Length);
            Assert.IsInstanceOf<Circle>(shapes[0]);
            Assert.IsInstanceOf<Rectangle>(shapes[1]);
            Assert.IsInstanceOf<Triangle>(shapes[2]);
        }

        [Test]
        public void CreateShape_ParameterArray_CallsCreateShapes()
        {
            // Arrange
            ShapeFactory shapeFactory = new ShapeFactory();

            // Act
            Shape[] shapes = shapeFactory.CreateShape(
                new ShapeParameters { Type = ShapeType.Circle, Radius = 5 },
                new ShapeParameters { Type = ShapeType.Rectangle, Width = 10, Height = 20 },
                new ShapeParameters { Type = ShapeType.Triangle, Base = 8, Height = 6 }
            );

            // Assert
            Assert.AreEqual(3, shapes.Length);
            Assert.IsInstanceOf<Circle>(shapes[0]);
            Assert.IsInstanceOf<Rectangle>(shapes[1]);
            Assert.IsInstanceOf<Triangle>(shapes[2]);
        }
    }
}
