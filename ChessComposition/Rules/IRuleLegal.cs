namespace ChessComposition.Rules
{
    // A rule that one particular move MAY be legal.
    // (If it is not proven to be illegal by some other Illegal Rule)

    public interface IRuleLegal
    {
        bool IsLegalMove(int x, int y, int dx, int dy);
    }
}