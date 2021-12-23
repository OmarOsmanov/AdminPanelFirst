using jkhkhkuhuh.Data;
using jkhkhkuhuh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BlogCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.BlogCategories.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogCategory model)
        {
            _context.BlogCategories.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
