using SaharaWeb.Controllers.ProductViewModels;
using SaharaWeb.DataAccess;
using SaharaWeb.DataSource.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaharaWeb.Services
{
    public class SaharaService : ISaharaService
    {
        private ISaharaAccess SaharaAccess;
        public SaharaService(ISaharaAccess saharaAccess)
        {
            SaharaAccess = saharaAccess;
        }
        /// <summary>
        /// Gets the Category List and individual Category selected and assembles them into a View
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>The needed information</returns>
        public async Task<CategoryView> GetCategoryView(int categoryId)
        {
            CategoryView view;
            Category category = await SaharaAccess.GetCategory(categoryId);

            view = new CategoryView(category);

            return view;
        }

        public async Task<ProductView> GetProductView(int productId)
        {
            ProductView view;
            Product product = await SaharaAccess.GetProduct(productId);

            view = new ProductView(product);

            return view;
        }

        public async Task<ProductListView> ShowAllProducts()
        {
            ProductListView view;
            IEnumerable<Product> products = await SaharaAccess.GetAllProducts();

            view = new ProductListView(products);

            return view;
        }

        public async Task<CategoryListView> GetCategoryList()
        {
            CategoryListView view;
            IEnumerable<Category> categories = await SaharaAccess.GetCategories();

            view = new CategoryListView(categories);

            return view;
        }
    }
}
