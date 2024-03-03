using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }

        public virtual double CalculateArea()
        {
            throw new NotImplementedException("CalculateArea method must be implemented in the derived class");
        }

        public virtual double CalculatePerimeter()
        {
            throw new NotImplementedException("CalculatePerimeter method must be implemented in the derived class");
        }
    }
}
