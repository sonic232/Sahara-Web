using SaharaWeb.DataSource.Models;
using System.Collections.Generic;
using System.Linq;

namespace SaharaWeb.Controllers.ProductViewModels
{
    /// <summary>
    /// All views should have this Category Dropdown, and a link back to the 'All Items' page
    /// </summary>
    public abstract class View
    {
        public View(IEnumerable<Category> categoryDataList)
        {
            Categories = categoryDataList.Select(c=> new CategoryItem(c));
        }
        public IEnumerable<CategoryItem> Categories { get; }
    }
}
