using System;

namespace Shapes
{
    public class ShapeFactory
    {
        public static Shape CreateShape(params object[] parameters)
        {
            // Check if parameters are provided
            if (parameters.Length == 0)
            {
                throw new ArgumentException("At least one parameter is required to create a shape.");
            }

            // Get the shape type from the first parameter
            string shapeType = parameters[0].ToString();

            // Create the appropriate shape object based on the shape type
            switch (shapeType.ToLower())
            {
                case "circle":
                    // Check if the required parameters for creating a circle are provided
                    if (parameters.Length < 2)
                    {
                        throw new ArgumentException("Insufficient parameters to create a circle.");
                    }

                    // Get the radius from the second parameter
                    double radius = Convert.ToDouble(parameters[1]);

                    // Create and return the circle object
                    return new Circle(radius);

                case "rectangle":
                    // Check if the required parameters for creating a rectangle are provided
                    if (parameters.Length < 3)
                    {
                        throw new ArgumentException("Insufficient parameters to create a rectangle.");
                    }

                    // Get the length and width from the second and third parameters
                    double length = Convert.ToDouble(parameters[1]);
                    double width = Convert.ToDouble(parameters[2]);

                    // Create and return the rectangle object
                    return new Rectangle(length, width);

                // Add cases for other shape types here

                default:
                    throw new ArgumentException("Invalid shape type.");
            }
        }
    }
}
