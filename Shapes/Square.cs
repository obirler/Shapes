using System;

/// <summary>
/// Represents a Square shape. Inherits from the Shape class.
/// </summary>
namespace Shapes
{
    public class Square : Shape
    {
        private double SideLength { get; set; }

        /// <summary>
        /// Initializes a new instance of the Square class with the specified side length.
        /// </summary>
        /// <param name="sideLength">The length of the side of the square.</param>
        public Square(double sideLength)
        {
            SideLength = sideLength;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        /// <summary>
        /// Calculates the area of the square.
        /// </summary>
        /// <returns>The area of the square.</returns>
        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }

        /// <summary>
        /// Calculates the perimeter of the square.
        /// </summary>
        /// <returns>The perimeter of the square.</returns>
        public override double CalculatePerimeter()
        {
            return 4 * SideLength;
        }
    }
}
