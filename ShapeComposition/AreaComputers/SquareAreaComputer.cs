using Property = ShapeComposition.Models.ShapeModel.ShapeProperty;

namespace ShapeComposition.AreaComputers
{
    public class SquareAreaComputer : IComputeArea
    {
        public double ComputeArea(Models.ShapeModel model)
        {
            return model.Values[Property.Height] * model.Values[Property.Width];
        }
    }
}