using System;

namespace Shapes.Library
{
    public class ShapeFactory
    {
        public static Shape[] CreateShapes(params string[] shapeTypes)
        {
            Shape[] shapes = new Shape[shapeTypes.Length];
            for (int i = 0; i < shapeTypes.Length; i++)
            {
                switch (shapeTypes[i].ToLower())
                {
                    case "circle":
                        shapes[i] = new Circle();
                        break;
                    case "rectangle":
                        shapes[i] = new Rectangle();
                        break;
                    case "triangle":
                        shapes[i] = new Triangle();
                        break;
                    default:
                        throw new ArgumentException("Invalid shape type");
                }
            }
            return shapes;
        }
