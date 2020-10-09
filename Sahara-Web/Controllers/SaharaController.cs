using System.Threading.Tasks;
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
        public async Task<IActionResult> GetProductListView()
        {
            return Ok(await SaharaService.ShowAllProducts());
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCategoryView(int id)
        {
            return Ok(await SaharaService.GetCategoryView(id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductView(int id)
        {
            return Ok(await SaharaService.GetProductView(id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCategoryList()
        {
            return Ok(await SaharaService.GetCategoryList());
        }
    }
}
