using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Pieces;

class Piece
{
    private PieceType Type { get; set; }
    public string PieceType { get; private set; }
    public PlayerColor Color { get; private set; }

    public bool hasMoved = false;

    public Piece(PieceType type, PlayerColor color)
    {
        Type = type;
        Color = color;
        PieceType = HelperMethods.GetPieceTypeString(Type);
    }
}
