using SaharaWeb.Controllers.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaharaWeb.Services
{
    public interface ISaharaService
    {
        CategoryView GetCategoryView(int categoryId);
        ProductView GetProductView(int productId);
        ProductListView ShowAllProducts();
    }
}
