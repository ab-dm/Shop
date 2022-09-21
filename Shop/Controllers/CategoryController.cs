using Microsoft.AspNetCore.Mvc;

using Shop.Data;
using Shop.Models;

using System.Collections;
using System.Collections.Generic;

namespace Shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;

            return View(objList);
        }

        // GET - Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
