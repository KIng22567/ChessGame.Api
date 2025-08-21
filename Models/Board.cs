using ChessGame.Api.Models.Pieces;
using ChessGame.Api.Models.Utils;

namespace ChessGame.Api.Models.Board;

class Board
{
    public Piece[][] Pieces { get; private set; }

    public Board()
    {
        Pieces = new Piece[8][];
        for (int i = 0; i < 8; i++)
        {
            Pieces[i] = new Piece[8];
        }

        Init();
    }

    private void Init()
    {
        foreach (var color in new[] { PlayerColor.BLACK, PlayerColor.WHITE })
        {
            var pieceRows = color == PlayerColor.BLACK ? (0, 1) : (7, 6);

            //Pawns
            for (int p = 0; p < 8; p++)
            {
                Pieces[pieceRows.Item2][p] = new Pawn(color);
            }

            //other pieces
            Pieces[pieceRows.Item1][0] = new Rook(color);
            Pieces[pieceRows.Item1][7] = new Rook(color);

            Pieces[pieceRows.Item1][1] = new Knight(color);
            Pieces[pieceRows.Item1][6] = new Knight(color);

            Pieces[pieceRows.Item1][2] = new Bishop(color);
            Pieces[pieceRows.Item1][5] = new Bishop(color);

            Pieces[pieceRows.Item1][3] = new Queen(color);
            Pieces[pieceRows.Item1][4] = new King(color);
        }
    }

    public override string ToString()
    {
        return "this is the board";
    }
}
