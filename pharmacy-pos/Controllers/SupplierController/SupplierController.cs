using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacy_pos.servicelayer.Services.Supplier;

namespace pharmacy_pos.api.Controllers.SupplierController
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _service;

        public SupplierController(ISupplierService service)
        {
            _service = service;
        }
    }
}
