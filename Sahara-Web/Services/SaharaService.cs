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
        public CategoryView GetCategoryView(int categoryId)
        {
            CategoryView view;
            Category category = SaharaAccess.GetCategory(categoryId);
            IEnumerable<Category> categories = SaharaAccess.GetCategories();

            view = new CategoryView(category, categories);

            return view;
        }

        public ProductView GetProductView(int productId)
        {
            ProductView view;
            Product product = SaharaAccess.GetProduct(productId);
            IEnumerable<Category> categories = SaharaAccess.GetCategories();

            view = new ProductView(product, categories);

            return view;
        }

        public ProductListView ShowAllProducts()
        {
            ProductListView view;
            IEnumerable<Product> products = SaharaAccess.GetAllProducts();
            IEnumerable<Category> categories = SaharaAccess.GetCategories();

            view = new ProductListView(products, categories);

            return view;
        }
    }
}
