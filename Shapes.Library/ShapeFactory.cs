using System;

namespace Shapes.Library
{
    public class ShapeFactory
    {
        public static Shape CreateShape(string shapeType)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "triangle":
                    return new Triangle();
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}
