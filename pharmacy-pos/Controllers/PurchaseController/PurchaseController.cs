using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacy_pos.servicelayer.Services.Purchase;

namespace pharmacy_pos.api.Controllers.PurchaseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _service;

        public PurchaseController(IPurchaseService service)
        {
            _service = service;
        }

    }
}
