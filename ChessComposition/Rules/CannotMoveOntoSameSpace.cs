namespace ChessComposition.Rules
{
    public class CannotMoveOntoSameSpace : IRule
    {
        public bool IsLegalMove(int x, int y, int dx, int dy)
        {
            return x != dx || y != dy;
        }
    }
}