using SaharaWeb.DataSource.Models;
using System.Collections.Generic;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class CategoryView : ProductListView
    {
        public string CategoryName { get; }
        public string CategoryDescription { get; }
        public CategoryView (Category categoryData, IEnumerable<Category> categories) : base(categoryData.Products, categories)
        {
            CategoryName = categoryData.Name;
            CategoryDescription = categoryData.Description;
        }
    }
}
