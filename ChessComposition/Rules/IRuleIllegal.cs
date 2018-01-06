namespace ChessComposition.Rules
{
    // A rule that cannot be true for the move to be legal.

    public interface IRuleIllegal
    {
        bool IsIllegalMove(int x, int y, int dx, int dy);
    }
}