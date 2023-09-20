using System;

namespace Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the XML writer
            XmlWriter xmlWriter = new XmlWriter();

            // Pass the XML writer instance to the "WriteShapesToXml" method in the "ShapeFactory" class
            ShapeFactory.WriteShapesToXml(shapes, xmlWriter);
        }
    }
}
