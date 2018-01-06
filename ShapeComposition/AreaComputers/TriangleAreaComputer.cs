using ShapeComposition.Models;
using Property = ShapeComposition.Models.ShapeModel.ShapeProperty;

namespace ShapeComposition.AreaComputers
{
    public class TriangleAreaComputer : IComputeArea
    {
        public double ComputeArea(ShapeModel model)
        {
            return model.Values[Property.Height] * model.Values[Property.Width] * 0.5;
        }
    }
}