using SaharaWeb.DataSource.Models;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class ProductItem
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public ProductItem(Product productData)
        {
            Id = productData.Id;
            Name = productData.Name;
            Price = productData.Price;
        }
    }
}
