using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Pieces;

class Knight : Piece
{
    public Knight(PlayerColor color)
        : base(Utils.PieceType.KNIGHT, color) { }
}
