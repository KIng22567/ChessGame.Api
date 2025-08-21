using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Pieces;

class Rook : Piece
{
    public Rook(PlayerColor color)
        : base(Utils.PieceType.ROOK, color) { }
}
