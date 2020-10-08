using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaharaWeb.DataSource.Models;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class ProductView : View
    {
        public int ProductId { get; }
        public int CategoryId { get; }
        public string Name { get; }
        public string CategoryName { get; }
        public string Description { get; }
        public decimal Price { get; }

        public ProductView(Product productData, IEnumerable<Category> categories) : base (categories)
        {
            ProductId = productData.Id;
            CategoryId = productData.CategoryId;
            Name = productData.Name;
            CategoryName = productData.Category.Name;
            Description = productData.Description;
            Price = productData.Price;
        }
    }
}
