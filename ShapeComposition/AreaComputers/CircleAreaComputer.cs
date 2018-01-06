using System;
using ShapeComposition.Models;
using ShapeAspect = ShapeComposition.Models.ShapeModel.ShapeAspect;

namespace ShapeComposition.AreaComputers
{
    public class CircleAreaComputer : IComputeArea
    {
        public double ComputeArea(ShapeModel model)
        {
            return Math.PI * Math.Pow(model.ShapeData[ShapeAspect.Radius], 2);
        }
    }
}