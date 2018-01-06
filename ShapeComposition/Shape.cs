using ShapeComposition.AreaComputers;
using ShapeComposition.Models;

namespace ShapeComposition
{
    public class Shape
    {
        // A Shape has properties (values), and it has a behavior to compute area.
        // The model will provide propertie values such as width, height, or radius.
        // The area computer will provide the logic to calculate the geometric area.
        // The Shape class itself has no idea what kind of Shape it's going to be.
        // Thus, it's extremely small, generic, and easy to understand conceptuatlly.

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