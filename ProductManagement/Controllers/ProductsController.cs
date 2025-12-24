using Microsoft.AspNetCore.Mvc;
using ProductManagement.Interfaces;

namespace ProductManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("most-expensive")]
        public IActionResult GetMostExpensive()
        {
            var product = _productService.GetMostExpensiveProduct();
            return Ok(product);
        }

        [HttpGet("average-price")]
        public IActionResult GetAveragePrice()
        {
            return Ok(_productService.GetAveragePrice());
        }
    }

}
