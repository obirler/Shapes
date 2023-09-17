using System;
using Newtonsoft.Json;

namespace Shapes.Library
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Circle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Circle>(json);
        }
    }
}
