using SaharaWeb.DataSource.Models;
using System.Collections.Generic;
using System.Linq;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class ProductListView
    {
        public IEnumerable<ProductItem> Products { get; }
        public ProductListView(IEnumerable<Product> products)
        {
            Products = CreateProductList(products);
        }
        private IEnumerable<ProductItem> CreateProductList(IEnumerable<Product> products)
        {
            return products.Select(p => new ProductItem(p));
        }
    }
}
