using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Labolatorium_2.Models;
namespace Labolatorium_2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Birth()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(Birth model)
        {
            if (model.IsValid())
            {
                int wiek = model.oblicz_wiek();
                return View("Result",model);

            }
            else
            {
                return View("Error");
            }
            
            
        }
    }
}
