using SaharaWeb.DataSource.Models;
using System.Collections.Generic;

namespace SaharaWeb.DataAccess
{
    public interface ISaharaAccess
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(int categoryId);
        Product GetProduct(int productId);
        IEnumerable<Category> GetCategories();
        Category GetCategory(int categoryId);
    }
}
