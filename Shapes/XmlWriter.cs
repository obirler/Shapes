using System;
using System.Xml;

namespace Shapes
{
    public class XmlWriter
    {
        public void WriteShapeToXml(Shape shape)
        {
            // Create a new XML document
            XmlDocument xmlDoc = new XmlDocument();

            // Create the root element
            XmlElement rootElement = xmlDoc.CreateElement("Shape");
            xmlDoc.AppendChild(rootElement);

            // Create the shape type element
            XmlElement shapeTypeElement = xmlDoc.CreateElement("Type");
            shapeTypeElement.InnerText = shape.GetType().Name;
            rootElement.AppendChild(shapeTypeElement);

            // Create the shape properties element
            XmlElement shapePropertiesElement = xmlDoc.CreateElement("Properties");
            rootElement.AppendChild(shapePropertiesElement);

            // Write the shape properties to the XML file
            if (shape is Circle circle)
            {
                XmlElement radiusElement = xmlDoc.CreateElement("Radius");
                radiusElement.InnerText = circle.Radius.ToString();
                shapePropertiesElement.AppendChild(radiusElement);
            }
            else if (shape is Rectangle rectangle)
            {
                XmlElement lengthElement = xmlDoc.CreateElement("Length");
                lengthElement.InnerText = rectangle.Length.ToString();
                shapePropertiesElement.AppendChild(lengthElement);

                XmlElement widthElement = xmlDoc.CreateElement("Width");
                widthElement.InnerText = rectangle.Width.ToString();
                shapePropertiesElement.AppendChild(widthElement);
            }
            // Add cases for other shape types here

            // Save the XML document to a file
            xmlDoc.Save("shapes.xml");
        }
    }
}
