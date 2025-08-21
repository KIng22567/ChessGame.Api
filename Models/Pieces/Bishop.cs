using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Pieces;

class Bishop : Piece
{
    public Bishop(PlayerColor color)
        : base(Utils.PieceType.BISHOP, color) { }
}
