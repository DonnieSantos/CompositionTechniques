using System.Collections.Generic;

namespace ShapeComposition.Models
{
    public class ShapeModel
    {
        // A Shape Model can provide various property values.

        public enum ShapeProperty { Width, Height, Radius }

        public Dictionary<ShapeProperty, double> Values;

        public ShapeModel()
        {
            Values = new Dictionary<ShapeProperty, double>();
        }
    }
}