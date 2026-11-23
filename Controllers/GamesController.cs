using Microsoft.AspNetCore.Mvc;
using Game.Models;
using listAndDetails.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace listAndDetails.Controllers;

[Authorize(Roles = "RegistryAdmin")]
public class GamesController : Controller
{
    private readonly GameDbContext _context;
    private readonly UserManager<AppUser> _userManager;

    public GamesController(GameDbContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [AllowAnonymous]
    public IActionResult Index()
    {
        var games = _context.Games.ToList();
        return View(games);
    }

    [AllowAnonymous]
    public async Task<IActionResult> Details(int id)
    {
        var game = await _context.Games.Include(g => g.Reviews).FirstOrDefaultAsync(g => g.Id == id);
        if (game == null)
        {
            return NotFound();
        }
        return View(game);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Game.Models.Game game)
    {
        if (ModelState.IsValid)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(game);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var game = await _context.Games.FindAsync(id);
        if (game == null)
        {
            return NotFound();
        }
        return View(game);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Generation,Region,Developer,Director,Platform,Description")] Game.Models.Game game)
    {
        if (id != game.Id)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(game);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(game.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(game);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var game = await _context.Games
            .FirstOrDefaultAsync(m => m.Id == id);
        if (game == null)
        {
            return NotFound();
        }

        return View(game);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var game = await _context.Games.FindAsync(id);
        if (game != null)
        {
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    private bool GameExists(int id)
    {
        return _context.Games.Any(e => e.Id == id);
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> CreateReview(int? GameId)
    {
        ViewData["Games"] = new SelectList(_context.Games, "Id", "Title", GameId);

        var reviewerName = string.Empty;
        if (User.Identity?.IsAuthenticated == true)
        {
            var user = await _userManager.GetUserAsync(User);
            reviewerName = string.IsNullOrWhiteSpace(user?.DisplayName)
                ? user?.UserName ?? string.Empty
                : user.DisplayName;
        }

        return View(new ReviewFormViewModel
        {
            GameId = GameId ?? 0,
            ReviewerName = reviewerName
        });
    }

    [AllowAnonymous]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateReview(ReviewFormViewModel model)
    {
        if (ModelState.IsValid)
        {
            var review = new Review
            {
                GameId = model.GameId,
                ReviewerName = model.ReviewerName,
                Rating = model.Rating,
                Comment = model.Comment
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new { id = model.GameId });
        }

        ViewData["Games"] = new SelectList(_context.Games, "Id", "Title", model.GameId);
        return View(model);
    }
}