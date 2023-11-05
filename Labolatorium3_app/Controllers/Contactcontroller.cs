using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3_app.Controllers
{
    public class Contactcontroller : Controller
    {
        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        static int id = 1;


        private readonly IContactService _contactService;

        public Contactcontroller(IContactService contactService)
        {
           _contactService = contactService;
        }


        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
        
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Contact model) 
        { 
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
            
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) 
        {
            return View(_contactService.FindById(id));
        }
    }
}
