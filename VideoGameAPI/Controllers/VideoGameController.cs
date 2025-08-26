using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameAPI.Data;

namespace VideoGameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly VideoGameDbContext _context;

        public VideoGameController(VideoGameDbContext context)
        {
            _context = context;
        }

        // GET: api/VideoGame
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VideoGame>>> GetVideoGames()
        {
            var games = await _context.VideoGames.ToListAsync();
            return Ok(games);
        }

        // GET: api/VideoGame/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGameById(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game == null)
                return NotFound();

            return Ok(game);
        }

        // POST: api/VideoGame
        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddVideoGame(VideoGame newGame)
        {
            if (newGame == null)
                return BadRequest();

            _context.VideoGames.Add(newGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetVideoGameById), new { id = newGame.Id }, newGame);
        }

        // PUT: api/VideoGame/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVideoGame(int id, VideoGame updatedGame)
        {
            if (id != updatedGame.Id)
                return BadRequest("ID mismatch");

            var existingGame = await _context.VideoGames.FindAsync(id);
            if (existingGame == null)
                return NotFound();

            existingGame.Title = updatedGame.Title;
            existingGame.Platform = updatedGame.Platform;
            existingGame.Developer = updatedGame.Developer;
            existingGame.Publisher = updatedGame.Publisher;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/VideoGame/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game == null)
                return NotFound();

            _context.VideoGames.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
