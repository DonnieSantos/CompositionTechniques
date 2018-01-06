using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeComposition;
using ShapeComposition.AreaComputers;
using ShapeComposition.Models;
using Property = ShapeComposition.Models.ShapeModel.ShapeProperty;

namespace CompositionTechniques
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
            // This is where we compose the Shape objects.
            // Notice the code reuse: different objects are sharing the same code.
            // They are not inheriting it, they are obtaining it through provided objects.
            // An object's behavior is determined by its inner objects, not inherited methods.
            // Polymorphism by being able to throw any IRule we want in the collection.

            // The Shape class itself has no reference to any of the concrete objects.
            // We get polymoprhism, code reuse, and dynamic run-time behavior determination.
            // All this is accomplished without any of the coupling of inheritance.

            // Note: I am composing the objects very manually here intentionally.
            // This is so that you can see very clearly where each component is coming from.
            // Normally, in a more sophisticated environment, a Factory or DI Framework would
            // provide your concretions for you, but for a simple example like this, it's ok
            // to do a little manual composition. Just be aware that in practice, the actual
            // composition code isn't as sprawling and bloated as doing it manually.

            _model = new ShapeModel();
            _model.Values.Add(Property.Width, 10);
            _model.Values.Add(Property.Height, 10);
            _model.Values.Add(Property.Radius, 10);

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
            Assert.AreEqual(50.0, _anyShape.GetArea());

            _anyShape.AreaComputer = _squareAreaComputer;
            Assert.AreEqual(100.0, _anyShape.GetArea());
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
    }
}