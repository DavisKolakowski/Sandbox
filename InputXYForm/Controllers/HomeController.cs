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
            var result = Create(Convert.ToDouble(model.x), Convert.ToInt32(model.y));
                ViewBag.Addition = $"{inputX} + {inputY} = {result.Addition}";
                ViewBag.Subtraction = $"{inputX} - {inputY} = {result.Subtraction}";
                ViewBag.Multiplication = $"{inputX} * {inputY} = {result.Multiplication}";
                ViewBag.Division = $"{inputX} / {inputY} = {result.Division}";
                return View();
        }
        [HttpPost]
        public ResultsModel Create(double inputX, int inputY)
        {
            var model = new ResultsModel()
            {
                Addition = inputX + inputY,
                Subtraction = inputX - inputY,
                Multiplication = inputX * inputY,
                Division = inputX / inputY
            };
            return model;
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