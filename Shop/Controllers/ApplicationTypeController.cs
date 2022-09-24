using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models;
using System.Collections.Generic;

namespace Shop.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationType;

            return View(objList);
        }

        // GET - Create
        public IActionResult Create()
        {
            return View();
        }

        // POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            // adding to database
            _db.ApplicationType.Add(obj);
            // required method
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
