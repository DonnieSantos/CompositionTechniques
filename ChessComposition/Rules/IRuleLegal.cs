namespace ChessComposition.Rules
{
    public interface IRuleLegal
    {
        bool IsLegalMove(int x, int y, int dx, int dy);
    }
}