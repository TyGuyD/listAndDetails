using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Game.Models;

namespace listAndDetails.Controllers;

public class GamesScaffoldController : Controller
{
    private readonly GameDbContext _context;

    public GamesScaffoldController(GameDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Games.ToListAsync());
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Games == null)
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

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Generation,Region,Developer,Platform,Description")] Game.Models.Game game)
    {
        if (ModelState.IsValid)
        {
            _context.Add(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(game);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.Games == null)
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
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Generation,Region,Developer,Platform,Description")] Game.Models.Game game)
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
        if (id == null || _context.Games == null)
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
        if (_context.Games == null)
        {
            return Problem("Entity set 'GameDbContext.Games' is null.");
        }
        var game = await _context.Games.FindAsync(id);
        if (game != null)
        {
            _context.Games.Remove(game);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GameExists(int id)
    {
        return _context.Games.Any(e => e.Id == id);
    }
}
