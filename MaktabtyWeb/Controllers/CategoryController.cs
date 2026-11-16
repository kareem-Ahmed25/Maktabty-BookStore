using MaktabtyWeb.Data;
using MaktabtyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaktabtyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories =_context.Categories.ToList();  
            return View("Index", categories);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePOST(Category category )
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
