using Microsoft.AspNetCore.Mvc;
using MinuteMeals.UI.Mvc.Core;
using MinuteMeals.UI.Mvc.Models;
using System.Diagnostics;

namespace MinuteMeals.UI.Mvc.Controllers
{
    public class HomeController(RecipetManagerDbContext database) : Controller
    {
        public IActionResult Index()
        {
            IList<Recipe> recipes = database.Recipes.ToList();
            return View(recipes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
