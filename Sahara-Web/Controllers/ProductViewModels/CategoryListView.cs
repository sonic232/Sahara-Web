using SaharaWeb.DataSource.Models;
using System.Collections.Generic;
using System.Linq;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class CategoryListView
    {
        public IEnumerable<CategoryItem> Categories { get; }
        public CategoryListView(IEnumerable<Category> categories)
        {
            Categories = CreateCategoryList(categories);
        }
        private IEnumerable<CategoryItem> CreateCategoryList(IEnumerable<Category> categories)
        {
            return categories.Select(p => new CategoryItem(p));
        }
    }
}
