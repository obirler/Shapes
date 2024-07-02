using System;

namespace Shapes
{
    public abstract class Shape : IAreaCalculable, IPerimeterCalculable
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }

        // Calculate the area of the shape
        // TODO: Implement the logic here
        // Replace the line below with the actual implementation
        public abstract double CalculateArea();

        // Calculate the perimeter of the shape
        // TODO: Implement the logic here
        // Replace the line below with the actual implementation
        public virtual double CalculatePerimeter();
    }
}
