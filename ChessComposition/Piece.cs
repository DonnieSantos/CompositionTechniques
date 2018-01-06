using ChessComposition.Rules;
using System.Collections.Generic;

namespace ChessComposition
{
    public class Piece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<IRuleLegal> LegalRules { get; set; }
        public List<IRuleIllegal> IllegalRules { get; set; }

        public Piece(int x, int y, List<IRuleLegal> legalRules, List<IRuleIllegal> illegalRules)
        {
            X = x;
            Y = y;
            LegalRules = legalRules;
            IllegalRules = illegalRules;
        }

        public bool Move(int dx, int dy)
        {
            // No Illegal Rules can be true.

            foreach (IRuleIllegal rule in IllegalRules)
            {
                if (rule.IsIllegalMove(X, Y, dx, dy))
                {
                    return false;
                }
            }

            // At least one legal rule must be true.

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