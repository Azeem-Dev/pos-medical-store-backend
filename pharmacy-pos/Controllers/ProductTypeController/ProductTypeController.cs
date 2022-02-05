using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.servicelayer.Services.ProductType;

namespace pharmacy_pos.api.Controllers.ProductTypeController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService _repo;

        public ProductTypeController(IProductTypeService repo)
        {
            _repo = repo;
        }
        [HttpPost("AddProductType")]
        public async Task<AddProductTypeRes> AddProductType(AddProductTypeReq req)
        {
            return await _repo.AddProductType(req);
        }
    }
}
