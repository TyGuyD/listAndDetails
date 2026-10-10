using Microsoft.AspNetCore.Mvc;
using listAndDetails.Models;

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
}