using System;

namespace Shapes
{
    public class Square : Shape
    {
        private double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * SideLength;
        }
    }
}
