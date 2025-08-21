namespace ChessGame.Api.Models.Utils;

enum PieceType
{
    PAWN,
    ROOK,
    QUEEN,
    KING,
    KNIGHT,
    BISHOP,
}

enum PlayerColor
{
    BLACK,
    WHITE,
}

static class HelperMethods
{
    public static string GetPieceTypeString(this PieceType type)
    {
        return type.ToString();
    }
}
