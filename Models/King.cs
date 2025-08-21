using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Pieces;

class King : Piece
{
    public King(PlayerColor color)
        : base(Utils.PieceType.KING, color) { }
}
