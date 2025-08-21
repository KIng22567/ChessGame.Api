using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Pieces;

class Pawn : Piece
{
    public Pawn(PlayerColor color)
        : base(Utils.PieceType.PAWN, color) { }
}
