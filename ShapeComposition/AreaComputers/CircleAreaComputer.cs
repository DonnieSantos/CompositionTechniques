using System;
using ShapeComposition.Models;
using Property = ShapeComposition.Models.ShapeModel.ShapeProperty;

namespace ShapeComposition.AreaComputers
{
    public class CircleAreaComputer : IComputeArea
    {
        public double ComputeArea(ShapeModel model)
        {
            return Math.PI * Math.Pow(model.Values[Property.Radius], 2);
        }
    }
}