using InputXYForm.Models;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;
using System.Reflection;

namespace InputXYForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public ActionResult Index(string inputX, string inputY)
        {
            var model = new DataModel();
            model.x = Convert.ToDecimal(inputX);
            model.y = Convert.ToDecimal(inputY);
                decimal result = 100M;
                result = Create(model.x, model.y);
                ViewBag.Result = result;
                return View();

        }

        [HttpPost]
        public decimal Create(decimal inputX, decimal inputY)
        {
            var result = inputX + inputY;
                return result;
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