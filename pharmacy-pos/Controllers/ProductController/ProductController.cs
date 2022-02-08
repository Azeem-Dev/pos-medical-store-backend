using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacy_pos.datalayer.Repository.Product.Dtos;
using pharmacy_pos.datalayer.Repository.Product.Dtos.AddProduct;
using pharmacy_pos.servicelayer.Services.Product;

namespace pharmacy_pos.api.Controllers.ProductController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAllProducts")]
        public async Task<List<ProductBaseDto>> GetAllProducts()
        {
            return await _productService.GetAllProducts();
        }
        [HttpPost("AddProduct")]
        public async Task<bool> AddProduct(AddProductDto product)
        {
            return await _productService.AddProduct(product);
        }
    }
}
