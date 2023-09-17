using Shapes;

using Shapes.Circle; // Importing the Circle class
using Shapes.Square; // Importing the Square class

// See https://aka.ms/new-console-template for more information
Shape rectangle = new Rectangle(5, 10);
Shape circle = new Circle(5);
Circle circleInstance = new Circle(5); // Creating an instance of the Circle class
Shape square = new Square(5); // Creating an instance of the Square class
Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
Console.WriteLine("Perimeter of rectangle: " + rectangle.CalculatePerimeter());
Console.WriteLine("Area of circle: " + circleInstance.CalculateArea());
Console.WriteLine("Perimeter of circle: " + circleInstance.CalculatePerimeter());
Console.WriteLine("Area of square: " + square.CalculateArea()); // Printing the area of the square
Console.WriteLine("Perimeter of square: " + square.CalculatePerimeter()); // Printing the perimeter of the square