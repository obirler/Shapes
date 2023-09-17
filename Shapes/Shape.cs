using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
