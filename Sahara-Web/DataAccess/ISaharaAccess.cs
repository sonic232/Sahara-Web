using SaharaWeb.DataSource.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaharaWeb.DataAccess
{
    public interface ISaharaAccess
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
        Task<Product> GetProduct(int productId);
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetCategory(int categoryId);
    }
}
