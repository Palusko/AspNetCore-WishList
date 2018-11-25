using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }       

        public IActionResult Index()
        {
            return View(_context.Items.ToList());
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            var itemToDelete = _context.Items.SingleOrDefault(i => i.Id == id);
            _context.Items.Remove(itemToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
