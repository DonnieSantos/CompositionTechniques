using System.Collections.Generic;

namespace ShapeComposition.Models
{
    public class ShapeModel
    {
        public enum ShapeAspect { Width, Height, Radius }

        public Dictionary<ShapeAspect, double> ShapeData;

        public ShapeModel()
        {
            ShapeData = new Dictionary<ShapeAspect, double>();
        }
    }
}