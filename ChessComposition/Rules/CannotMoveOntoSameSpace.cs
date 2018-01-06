namespace ChessComposition.Rules
{
    public class CannotMoveOntoSameSpace : IRuleIllegal
    {
        public bool IsIllegalMove(int x, int y, int dx, int dy)
        {
            return x == dx && y == dy;
        }
    }
}