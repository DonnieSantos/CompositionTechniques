using ShapeComposition.AreaComputers;
using ShapeComposition.Models;

namespace ShapeComposition
{
    public class Shape
    {
        public ShapeModel Model { get; set; }
        public IComputeArea AreaComputer { get; set; }

        public Shape(ShapeModel model, IComputeArea areaComputer)
        {
            Model = model;
            AreaComputer = areaComputer;
        }

        public double GetArea()
        {
            return AreaComputer.ComputeArea(Model);
        }
    }
}