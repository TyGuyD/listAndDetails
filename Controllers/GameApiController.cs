using Game.Models;
using listAndDetails.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace listAndDetails.Controllers;

[ApiController]
[Route("api/games")]
[Authorize(Roles = "RegistryAdmin")]
public class GamesApiController : ControllerBase
{
    private readonly GameDbContext _context;

    public GamesApiController(GameDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<GameDto>>> GetGames()
    {
        var games = await _context.Games
            .Include(game => game.Reviews)
            .ToListAsync();

        return Ok(games.Select(ToDto));
    }

    [HttpGet("{id:int}")]
    [AllowAnonymous]
    public async Task<ActionResult<GameDto>> GetGame(int id)
    {
        var game = await _context.Games
            .Include(game => game.Reviews)
            .FirstOrDefaultAsync(game => game.Id == id);

        if (game == null)
        {
            return NotFound();
        }

        return Ok(ToDto(game));
    }

    [HttpPost]
    public async Task<ActionResult<GameDto>> CreateGame(CreateGameDto input)
    {
        var game = new Game.Models.Game
        {
            Title = input.Title,
            ReleaseDate = input.ReleaseDate,
            Generation = input.Generation,
            Region = input.Region,
            Developer = input.Developer,
            Director = input.Director,
            Platform = input.Platform,
            Description = input.Description
        };

        _context.Games.Add(game);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetGame), new { id = game.Id }, ToDto(game));
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteGame(int id)
    {
        var game = await _context.Games.FindAsync(id);

        if (game == null)
        {
            return NotFound();
        }

        _context.Games.Remove(game);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private static GameDto ToDto(Game.Models.Game game)
    {
        return new GameDto
        {
            Id = game.Id,
            Title = game.Title,
            ReleaseDate = game.ReleaseDate,
            Generation = game.Generation,
            Region = game.Region,
            Developer = game.Developer,
            Director = game.Director,
            Platform = game.Platform,
            Description = game.Description,
            Reviews = game.Reviews.Select(review => new ReviewDto
            {
                Id = review.Id,
                GameId = review.GameId,
                ReviewerName = review.ReviewerName,
                Rating = review.Rating,
                Comment = review.Comment
            }).ToList()
        };
    }
}