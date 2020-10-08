using SaharaWeb.DataSource.Models;

namespace SaharaWeb.Controllers.ProductViewModels
{
    public class CategoryItem
    {
        public int Id { get; }
        public string Name { get; }

        public CategoryItem(Category categoryData)
        {
            Id = categoryData.Id;
            Name = categoryData.Name;
        }
    }
}
