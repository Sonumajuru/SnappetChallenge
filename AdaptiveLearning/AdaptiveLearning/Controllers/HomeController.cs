using AdaptiveLearning.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AdaptiveLearning.Helpers;

namespace AdaptiveLearning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get view
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(new Dictionary<string, object> { { "learning", DataHelper.Instance.FetchData() } });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Learning { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}