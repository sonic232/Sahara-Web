using SaharaWeb.DataSource.Models;
using System.Collections.Generic;
using System.Linq;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class ProductListView : View
    {
        public IEnumerable<ProductItem> Products { get; }
        public ProductListView(IEnumerable<Product> products, IEnumerable<Category> categories) : base(categories)
        {
            Products = CreateProductList(products);
        }
        private IEnumerable<ProductItem> CreateProductList(IEnumerable<Product> products)
        {
            return products.Select(p => new ProductItem(p));
        }
    }
}
