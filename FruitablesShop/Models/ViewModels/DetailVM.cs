namespace FruitablesShop.Models.ViewModels
{
    public class DetailVM
    {
        public Product Product { get; set; }

        public List<Product> RelatedProducts { get; set; }

        public List<Category> Categories { get; set; }
            public List<Product> Products { get; set; }
    }
}
