using System;

namespace Shapes
{
    public abstract class Shape : IAreaCalculable, IPerimeterCalculable
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }
        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }
        public virtual double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
