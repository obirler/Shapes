using System;

/// <summary>
/// Represents a Rectangle shape. Inherits from the Shape class.
/// </summary>
namespace Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        /// <summary>
        /// Initializes a new instance of the Rectangle class with the specified length and width.
        /// </summary>
        /// <param name="length">The length of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// </summary>
        /// <returns>The area of the rectangle.</returns>
        public override double CalculateArea()
        {
            return this.length * this.width;
        }
        /// <summary>
        /// Calculates the perimeter of the rectangle.
        /// </summary>
        /// <returns>The perimeter of the rectangle.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * (this.length + this.width);
        }
    }
}
