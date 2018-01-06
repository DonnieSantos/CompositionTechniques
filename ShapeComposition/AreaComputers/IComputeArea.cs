using ShapeComposition.Models;

namespace ShapeComposition.AreaComputers
{
    public interface IComputeArea
    {
        double ComputeArea(ShapeModel model);
    }
}