using System.Collections.Generic;
using ChessComposition;
using ChessComposition.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompositionTechniques
{
    [TestClass]
    public class PieceTests
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private Piece _rook;
        private Piece _bishop;
        private Piece _queen;

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestInitialize]
        public void Init()
        {
            // This is where we compose the Piece objects.
            // Notice the code reuse: different objects are sharing the same code.
            // They are not inheriting it, they are obtaining it through provided objects.
            // An object's behavior is determined by its inner objects, not inherited methods.
            // Polymorphism by being able to throw any IRule we want in the collection.

            // The Piece class itself has no reference to any of the concrete objects.
            // We get polymoprhism, code reuse, and dynamic run-time behavior determination.
            // All this is accomplished without any of the coupling of inheritance.

            // Note: I'm intentionally adding each rule manually with "Add".
            // It would be better to use a Fluent Interface, but I chose not to
            // so the code would be more accessible for beginners.

            _rook = new Piece(0, 0, new List<IRuleLegal>(), new List<IRuleIllegal>());
            _rook.LegalRules.Add(new CanMoveOrthogonal());
            _rook.IllegalRules.Add(new CannotMoveOffBoard());
            _rook.IllegalRules.Add(new CannotMoveOntoSameSpace());

            _bishop = new Piece(0, 0, new List<IRuleLegal>(), new List<IRuleIllegal>());
            _bishop.LegalRules.Add(new CanMoveDiagonal());
            _bishop.IllegalRules.Add(new CannotMoveOffBoard());
            _bishop.IllegalRules.Add(new CannotMoveOntoSameSpace());

            _queen = new Piece(0, 0, new List<IRuleLegal>(), new List<IRuleIllegal>());
            _queen.LegalRules.Add(new CanMoveOrthogonal());
            _queen.LegalRules.Add(new CanMoveDiagonal());
            _queen.IllegalRules.Add(new CannotMoveOffBoard());
            _queen.IllegalRules.Add(new CannotMoveOntoSameSpace());
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void RookCanMoveHorizontal()
        {
            Assert.IsTrue(_rook.Move(4, 0));
        }

        [TestMethod]
        public void RookCanMoveVertical()
        {
            Assert.IsTrue(_rook.Move(0, 4));
        }

        [TestMethod]
        public void RookCannotMoveDiagonal()
        {
            Assert.IsFalse(_rook.Move(4, 4));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void BishopCannotMoveHorizontal()
        {
            Assert.IsFalse(_bishop.Move(4, 0));
        }

        [TestMethod]
        public void BishopCannotMoveVertical()
        {
            Assert.IsFalse(_bishop.Move(0, 4));
        }

        [TestMethod]
        public void BishopCanMoveDiagonal()
        {
            Assert.IsTrue(_bishop.Move(4, 4));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void QueenCanMoveHorizontal()
        {
            Assert.IsTrue(_queen.Move(4, 0));
        }

        [TestMethod]
        public void QueenCanMoveVertical()
        {
            Assert.IsTrue(_queen.Move(0, 4));
        }

        [TestMethod]
        public void QueenCanMoveDiagonal()
        {
            Assert.IsTrue(_queen.Move(4, 4));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void AllPiecesCannotMoveToSelf()
        {
            Assert.IsFalse(_rook.Move(0, 0));
            Assert.IsFalse(_bishop.Move(0, 0));
            Assert.IsFalse(_queen.Move(0, 0));
        }

        [TestMethod]
        public void AllPiecesCannotMoveOffBoard()
        {
            Assert.IsFalse(_rook.Move(10, 0));
            Assert.IsFalse(_rook.Move(0, 10));
            Assert.IsFalse(_bishop.Move(10, 0));
            Assert.IsFalse(_bishop.Move(0, 10));
            Assert.IsFalse(_queen.Move(10, 0));
            Assert.IsFalse(_queen.Move(0, 10));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
    }
}