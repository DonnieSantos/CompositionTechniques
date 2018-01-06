namespace ChessComposition.Rules
{
    public class CannotMoveOffBoard : IRuleIllegal
    {
        public bool IsIllegalMove(int x, int y, int dx, int dy)
        {
            return dx >= 8 || dy >= 8;
        }
    }
}