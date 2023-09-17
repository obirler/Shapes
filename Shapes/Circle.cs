using System;

/// <summary>
/// Represents a Circle shape. Inherits from the Shape class.
/// </summary>
namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        /// <summary>
        /// Initializes a new instance of the Circle class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
        /// <summary>
        /// Calculates the perimeter of the circle.
        /// </summary>
        /// <returns>The perimeter of the circle.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
