using Microsoft.AspNetCore.Mvc;
using Game.Models;
using Microsoft.EntityFrameworkCore;

namespace listAndDetails.Controllers;

public class GamesController : Controller
{
    private readonly GameDbContext _context;

    public GamesController(GameDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var games = _context.Games.ToList();
        return View(games);
    }

    public IActionResult Details(int id)
    {
        var game = _context.Games.FirstOrDefault(g => g.Id == id);
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
}