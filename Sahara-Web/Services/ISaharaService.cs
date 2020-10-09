using SaharaWeb.Controllers.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaharaWeb.Services
{
    public interface ISaharaService
    {
        Task<CategoryView> GetCategoryView(int categoryId);
        Task<ProductView> GetProductView(int productId);
        Task<ProductListView> ShowAllProducts();
        Task<CategoryListView> GetCategoryList();
    }
}
