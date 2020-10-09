using SaharaWeb.DataSource.Models;
using SaharaWeb.DataSource.Contexts;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SaharaWeb.DataAccess
{
    public class SaharaAccess : ISaharaAccess
    {
        private SaharaDbContext SaharaDb;

        public SaharaAccess(SaharaDbContext saharaDb)
        {
            SaharaDb = saharaDb;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>A generic enumerable of all products within the database. In a larger system, this would have paging information to only get a subset of data</returns>
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await SaharaDb.Products.Include(p => p.Category).ToListAsync();
        }

        /// <summary>
        /// Get all products of a specific category
        /// </summary>
        /// <param name="categoryId">The ID of the category to get the products of</param>
        /// <returns>A generic enumerable of all products listed under a specific category. In a larger system, this would have paging information to only get a subset of data.</returns>
        public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            return await SaharaDb.Products.Where(p => p.CategoryId == categoryId).Include(p => p.Category).ToListAsync();
        }

        /// <summary>
        /// Get a specific product
        /// </summary>
        /// <param name="productId">The ID of the product.</param>
        /// <returns>The product whose ID matches what was provided, or a null object indicating the provided object was not found.</returns>
        public async Task<Product> GetProduct(int productId)
        {
            return await SaharaDb.Products.Include(p => p.Category).SingleOrDefaultAsync(p => p.Id == productId);
        }

        /// <summary>
        /// Get a list of all categories in the system.
        /// </summary>
        /// <returns>A generic enumerable list </returns>
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await SaharaDb.Categories.ToListAsync();
        }
        /// <summary>
        /// Get a single category and all of its included products based on its ID
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>A single category with all its included products</returns>
        public async Task<Category> GetCategory(int categoryId)
        {
            return await SaharaDb.Categories.Include(c => c.Products).SingleOrDefaultAsync(c => c.Id == categoryId);
        }
    }
}
