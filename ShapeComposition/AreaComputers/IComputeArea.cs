using ShapeComposition.Models;

namespace ShapeComposition.AreaComputers
{
    // All you need to compute the area of a shape is its model.
    // (Which contains its properties like width, height or radius)

    public interface IComputeArea
    {
        double ComputeArea(ShapeModel model);
    }
}