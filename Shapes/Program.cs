using Shapes;

using Shapes.Circle; // Importing the Circle class

// See https://aka.ms/new-console-template for more information
Shape rectangle = new Rectangle(5, 10);
Shape circle = new Circle(5);
Circle circle = new Circle(5); // Creating an instance of the Circle class
Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
Console.WriteLine("Perimeter of rectangle: " + rectangle.CalculatePerimeter());
Console.WriteLine("Area of circle: " + circle.CalculateArea());
Console.WriteLine("Perimeter of circle: " + circle.CalculatePerimeter());