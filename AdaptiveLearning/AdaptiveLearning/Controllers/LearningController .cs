using AdaptiveLearning.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace AdaptiveLearning.Controllers
{
    /// <summary>
    /// Separate controller for API calls
    /// </summary>
    public class LearningController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public LearningController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get request from dateTime picker and update view
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet("learning/{date}")]
        public IActionResult GetFilteredLearning(string date)
        {
            var temp = DataHelper.Instance.FetchData(true).Where((x) => {
                if (x.SubmitDateTime.Split('T').FirstOrDefault() == date)
                {
                    return true;
                }
                return false;
            });
            return View("Index",new Dictionary<string, object> { { "learning" , temp }, { "date" , date } });
        }
    }
}