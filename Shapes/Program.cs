using Shapes;
using Shapes.Triangle; // Importing the Triangle class
using Shapes.Circle; // Importing the Circle class
using Shapes.Circle; // Importing the Circle class

// See https://aka.ms/new-console-template for more information
Shape rectangle = new Rectangle(5, 10);
Shape circle = new Circle(5);
Shape triangle = new Triangle(3, 4, 5); // Creating an instance of the Triangle class
Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
Console.WriteLine("Perimeter of rectangle: " + rectangle.CalculatePerimeter());
Console.WriteLine("Area of circle: " + circle.CalculateArea());
Console.WriteLine("Perimeter of circle: " + circle.CalculatePerimeter());
Console.WriteLine("Area of triangle: " + triangle.CalculateArea());
Console.WriteLine("Perimeter of triangle: " + triangle.CalculatePerimeter());