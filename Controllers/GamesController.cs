using Microsoft.AspNetCore.Mvc;
using Game.Models;

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
}