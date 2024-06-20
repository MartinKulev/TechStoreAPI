using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using TechStoreAPI.Services;
using System.Text.Json;

namespace TechStoreAPI.Controllers
{
    public class TechController : Controller
    {
        private IProductService productService;

        public TechController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("Tech/GetProduct/{productID}")]
        public async Task <IActionResult> GetProduct(int productID)
        {
            JsonDocument jsonDocument = await productService.GetProductJsonByIDAsync(productID);
            return Ok(jsonDocument);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            JsonDocument jsonDocument = await productService.GetAllProductsJsonAsync();
            return Ok(jsonDocument);
        }
    }
}
