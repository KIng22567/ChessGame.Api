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
            var board = new string[][]
            {
                ["r", "n", "b", "q", "k", "b", "n", "r"],
                ["p", "p", "p", "p", "p", "p", "p", "p"],
                ["", "", "", "", "", "", "", ""],
                ["", "", "", "", "", "", "", ""],
                ["", "", "", "", "", "", "", ""],
                ["", "", "", "", "", "", "", ""],
                ["P", "P", "P", "P", "P", "P", "P", "P"],
                ["R", "N", "B", "Q", "K", "B", "N", "R"],
            };

            return Ok(board);
        }
    }
}
