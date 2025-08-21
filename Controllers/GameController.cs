using ChessGame.Api.Models.Board;
using Microsoft.AspNetCore.Mvc;

namespace ChessGame.Api.Controllers
{
    [ApiController]
    [Route("game")]
    public class GameController : ControllerBase
    {
        // Get: /game/new
        [HttpGet("new")]
        public IActionResult NewGame()
        {
            var board = new Board();

            return Ok(board.Pieces);
        }
    }
}
