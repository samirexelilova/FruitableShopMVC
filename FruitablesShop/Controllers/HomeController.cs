using FruitablesShop.Models;
using FruitablesShop.Models.DAL;
using FruitablesShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FruitablesShop.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomeVM homeVM = new HomeVM()
            {
                Slides=_context.Slides.ToList(),
                Products=_context.Products.Take(8).ToList()
            };
            return View(homeVM);
        }
    }
}
