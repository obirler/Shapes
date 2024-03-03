using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double base_width, double height)
        {
        }

        private double _base_width;

        private double _height;

        /// <summary>
        /// Calculates the area of the triangle.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public override double CalculateArea()
        {
            return this._base_width * this._height/2.0;
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle.
        /// </summary>
        /// <returns>The perimeter of the rectangle.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * (this._base_width + this._height);
        }
    }
}
