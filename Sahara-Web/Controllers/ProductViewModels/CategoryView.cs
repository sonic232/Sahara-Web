using SaharaWeb.DataSource.Models;
using System.Collections.Generic;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class CategoryView : ProductListView
    {
        public string CategoryName { get; }
        public string CategoryDescription { get; }
        public CategoryView (Category categoryData) : base(categoryData.Products)
        {
            CategoryName = categoryData.Name;
            CategoryDescription = categoryData.Description;
        }
    }
}
