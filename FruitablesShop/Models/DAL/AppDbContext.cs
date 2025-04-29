using Microsoft.EntityFrameworkCore;

namespace FruitablesShop.Models.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public  DbSet<Slide> Slides { get; set; }
    }
}
