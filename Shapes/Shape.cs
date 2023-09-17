using System;

namespace Shapes
{
    public abstract class Shape : IAreaCalculable, IPerimeterCalculable
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }
        public virtual double CalculateArea()
        {
            // Calculate the area of the shape
            // TODO: Implement the logic here
            // Replace the line below with the actual implementation
            return 0;
        }
        public virtual double CalculatePerimeter()
        {
            // Calculate the perimeter of the shape
            // TODO: Implement the logic here
            // Replace the line below with the actual implementation
            return 0;
        }
    }
}
