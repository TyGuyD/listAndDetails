using Microsoft.AspNetCore.Mvc;
using listAndDetails.Models; // For GameData
using Game.Models; // For the Game class

namespace listAndDetails.Controllers;

public class GamesController : Controller
{
    public IActionResult Index()
    {
        var games = GameData.All;
        return View(games);
    }

    public IActionResult Details(int id)
    {
        var game = GameData.All.FirstOrDefault(g => g.Id == id);
        if (game == null)
        {
            return NotFound();
        }
        return View(game);
    }

    // GET: /Games/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Games/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Game.Models.Game game) // Fully qualify the Game class
    {
        if (ModelState.IsValid)
        {
            game.Id = GameData.All.Max(g => g.Id) + 1; // Assign a new unique Id
            GameData.All.Add(game); // Add the new game to the list
            return RedirectToAction(nameof(Index)); // Redirect to the Index page
        }
        return View(game); // If invalid, redisplay the form
    }
}