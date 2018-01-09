namespace ChessComposition.Rules
{
    public class CannotMoveOffBoard : IRule
    {
        public bool IsLegalMove(int x, int y, int dx, int dy)
        {
            return dx < 8 && dy < 8;
        }
    }
}