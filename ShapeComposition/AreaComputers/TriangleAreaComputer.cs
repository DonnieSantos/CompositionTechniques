using ShapeComposition.Models;
using ShapeAspect = ShapeComposition.Models.ShapeModel.ShapeAspect;

namespace ShapeComposition.AreaComputers
{
    public class TriangleAreaComputer : IComputeArea
    {
        public double ComputeArea(ShapeModel model)
        {
            return model.ShapeData[ShapeAspect.Height] * model.ShapeData[ShapeAspect.Width] * 0.5;
        }
    }
}