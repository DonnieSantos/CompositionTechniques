namespace ChessComposition.Rules
{
    public class CanMoveOrthogonal : IRule
    {
        public bool IsLegalMove(int x, int y, int dx, int dy)
        {
            bool legalVertical = x == dx && y != dy;
            bool legalHorizontal = x != dx && y == dy;
            return legalVertical || legalHorizontal;
        }
    }
}