using ChessComposition.Rules;
using System.Collections.Generic;

namespace ChessComposition
{
    // Instead of having classes for every type of piece, you only have one class.
    // A Piece is only different from other pieces based on the rules it abides by.
    // Therefore, giving a piece all of its rules when you create it is all you need to do.

    public class Piece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<IRuleLegal> LegalRules { get; set; }
        public List<IRuleIllegal> IllegalRules { get; set; }

        // Using the constructor or public properties to facilitate concrete types.
        // This is not really the best way to do it, but it's the simplest to start with.
        // Factories or Dependency Injection Frameworks are strongly recommended.

        public Piece(int x, int y, List<IRuleLegal> legalRules, List<IRuleIllegal> illegalRules)
        {
            X = x;
            Y = y;
            LegalRules = legalRules;
            IllegalRules = illegalRules;
        }

        public bool Move(int dx, int dy)
        {
            // No Illegal Rules can be true...

            foreach (IRuleIllegal rule in IllegalRules)
            {
                if (rule.IsIllegalMove(X, Y, dx, dy))
                {
                    return false;
                }
            }

            // ..and at least one Legal Rule must be true.

            foreach (IRuleLegal rule in LegalRules)
            {
                if (rule.IsLegalMove(X, Y, dx, dy))
                {
                    X = dx;
                    Y = dy;
                    return true;
                }
            }

            return false;
        }
    }
}