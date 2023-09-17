using Shapes;

using Shapes.Circle; // Importing the Circle class

// See https://aka.ms/new-console-template for more information
Rectangle rectangle = new Rectangle(5, 10);
Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());

Circle circle = new Circle(5); // Creating an instance of the Circle class
Console.WriteLine("Area of circle: " + circle.CalculateArea()); // Calculating and printing the area of the circle
