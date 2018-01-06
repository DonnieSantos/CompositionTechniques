namespace ChessComposition.Rules
{
    public interface IRuleIllegal
    {
        bool IsIllegalMove(int x, int y, int dx, int dy);
    }
}