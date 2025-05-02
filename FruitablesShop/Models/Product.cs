using FruitablesShop.Models.Base;

namespace FruitablesShop.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
