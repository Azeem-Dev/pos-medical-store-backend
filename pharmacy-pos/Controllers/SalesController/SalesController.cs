using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacy_pos.servicelayer.Services.Sale;

namespace pharmacy_pos.api.Controllers.SalesController
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _service;

        public SalesController(ISaleService service)
        {
            _service = service;
        }
    }
}
