using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return this.length * this.width;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (this.length + this.width);
        }
    }
}
