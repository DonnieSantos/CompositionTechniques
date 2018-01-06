using ShapeAspect = ShapeComposition.Models.ShapeModel.ShapeAspect;

namespace ShapeComposition.AreaComputers
{
    public class SquareAreaComputer : IComputeArea
    {
        public double ComputeArea(Models.ShapeModel model)
        {
            return model.ShapeData[ShapeAspect.Height] * model.ShapeData[ShapeAspect.Width];
        }
    }
}