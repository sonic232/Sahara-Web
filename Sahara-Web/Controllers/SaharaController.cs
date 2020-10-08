using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaharaWeb.Controllers.ProductViewModels;
using SaharaWeb.Services;

namespace SaharaWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaharaController : ControllerBase
    {
        private ISaharaService SaharaService;
        public SaharaController(ISaharaService saharaService)
        {
            SaharaService = saharaService;
        }

        [HttpGet("[action]")]
        public ProductListView GetProductListView()
        {
            return SaharaService.ShowAllProducts();
        }

        [HttpGet("[action]")]
        public CategoryView GetCategoryView(int categoryId)
        {
            return SaharaService.GetCategoryView(categoryId);
        }

        [HttpGet("[action]")]
        public ProductView GetProductView(int productId)
        {
            return SaharaService.GetProductView(productId);
        }
    }
}
