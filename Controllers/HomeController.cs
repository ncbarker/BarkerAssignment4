using BarkerAssignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add($"#{r.RestRank}: {r.RestName} Best Dish: {r.FavDish} Address: {r.RestAddress} Phone: {r.RestPhone} Website: {r.RestWeb}");
            }
            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult Recommendation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Recommendation(UserRecommendation appResponse)
        {
            TempStorage.AddRecommendation(appResponse);
            return View("Confirmation", appResponse);
        }

        public IActionResult RestList()
        {
            return View(TempStorage.Recommendations);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
