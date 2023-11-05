using Labolatorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Labolatorium_1.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About(string author)
        {
            //string author = Request.Query["author"];
            ViewBag.author = author;
            return View();
        }

        public IActionResult Calculator([FromQuery(Name = "operator")] string op, double? x,double? y)
        {
            ViewBag.result="";


            /*if (x == null || y == null)
            {
                return View("Error");
            }

            if (op == "add")
            {
                ViewBag.result = x + y;
            }
            if (op == "sub")
            {
                ViewBag.result = x - y;
            }
            if (op == "mul")
            {
                ViewBag.result = x * y;
            }
            if (op == "div")
            {
                ViewBag.result = x / y;
            }*/

            switch (op)
            {
                case "add":
                    ViewBag.result = x + y;
                    break;

                case "sub":
                    ViewBag.result = x - y;
                    break;

                case "mul":
                    ViewBag.result = x * y;
                    break;

                case "div":
                    if(y == 0)
                    {
                        ViewBag.result = "Nie można dzielić przez 0!";
                    }
                    else
                    {
                        ViewBag.result = x / y;
                    }
                    
                    break;

                default:
                    ViewBag.result = "Podano zły operator";
                    break;
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}