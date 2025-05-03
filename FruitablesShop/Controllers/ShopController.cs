using FruitablesShop.Models;
using FruitablesShop.Models.DAL;
using FruitablesShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FruitablesShop.Controllers
{
    public class ShopController : Controller
    {
        public readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DetailVM detailVM = new DetailVM()
            {
                Categories = _context.Categories.Include(c => c.Products).ToList(),
                Products = _context.Products.ToList()
            };
      
            return View(detailVM);
        }

        public IActionResult Detail(int? id)
        {
            if (id is null || id < 0) return BadRequest();


            Product? product= _context.Products.Include(p=>p.Category).FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            DetailVM detailVM = new DetailVM()
            {
                Product = product,
                RelatedProducts = _context.Products
                .Include(p => p.Category)
                .Where(p => p.CategoryId == product.CategoryId && p.Id != product.Id)
                .ToList(),

                 Categories = _context.Categories.Include(c=>c.Products).ToList(),
                 Products=_context.Products.ToList()
            };
                return View(detailVM);
        }
    }
}
