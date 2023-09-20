using Shapes;
using System.Xml;
using System.Collections.Generic; // Importing necessary namespace for List

// See https://aka.ms/new-console-template for more information
List<Shape> shapes = new List<Shape>(); // Creating a List of type Shape
Shape rectangle = new Rectangle(5, 10);
Shape circle = new Shapes.Circle(5);
Shapes.Circle circleInstance = new Shapes.Circle(5); // Creating an instance of the Circle class
Shape square = new Shapes.Square(5); // Creating an instance of the Square class
shapes.Add(rectangle); // Adding rectangle to the list
shapes.Add(circle); // Adding circle to the list
shapes.Add(square); // Adding square to the list
shapes.Add(new Rectangle(5, 10)); // Adding rectangle to the list
shapes.Add(new Circle(5)); // Adding circle to the list
shapes.Add(new Square(5)); // Adding square to the list
// Adding more shapes to the list
shapes.Add(new Rectangle(6, 12));
shapes.Add(new Circle(6));
shapes.Add(new Square(6));
shapes.Add(new Rectangle(7, 14));
shapes.Add(new Circle(7));
shapes.Add(new Square(7));
shapes.Add(new Rectangle(8, 16));

foreach (Shape shape in shapes) // Iterating over the list of shapes
{
    Console.WriteLine("Area of shape: " + shape.CalculateArea()); // Printing the area of the shape
}