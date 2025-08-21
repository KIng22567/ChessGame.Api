using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Pieces;

class Queen : Piece
{
    public Queen(PlayerColor color)
        : base(Utils.PieceType.QUEEN, color) { }
}
