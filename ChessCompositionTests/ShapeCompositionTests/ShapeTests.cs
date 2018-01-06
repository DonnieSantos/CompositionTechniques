using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeComposition;
using ShapeComposition.AreaComputers;
using ShapeComposition.Models;

namespace ChessCompositionTests
{
    [TestClass]
    public class ShapeTests
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private Shape _anyShape;
        private ShapeModel _model;
        private CircleAreaComputer _circleAreaComputer;
        private TriangleAreaComputer _triangleAreaComputer;
        private SquareAreaComputer _squareAreaComputer;

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestInitialize]
        public void Init()
        {
            _model = new ShapeModel();
            _model.ShapeData.Add(ShapeModel.ShapeAspect.Width, 10);
            _model.ShapeData.Add(ShapeModel.ShapeAspect.Height, 10);
            _model.ShapeData.Add(ShapeModel.ShapeAspect.Radius, 10);

            _circleAreaComputer = new CircleAreaComputer();
            _triangleAreaComputer = new TriangleAreaComputer();
            _squareAreaComputer = new SquareAreaComputer();

            _anyShape = new Shape(_model, null);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TestDynamicShapeBehavior()
        {
            _anyShape.AreaComputer = _circleAreaComputer;
            Assert.AreEqual(314, (int) _anyShape.GetArea());

            _anyShape.AreaComputer = _triangleAreaComputer;
            Assert.AreEqual(50, (int)_anyShape.GetArea());

            _anyShape.AreaComputer = _squareAreaComputer;
            Assert.AreEqual(100, (int)_anyShape.GetArea());
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
    }
}