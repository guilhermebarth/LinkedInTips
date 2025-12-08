using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TipsAndTricks.ControllersAndMinimalAPI
{
    // This is not following Clean Architecture
    [ApiController]
    [Route("api/[controller]")]
    public class RegularController : ControllerBase
    {
        private readonly IProductService _service;

        public RegularController(IProductService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _service.GetByIdAsync(id);

            if (product is null)
                return NotFound();

            return Ok(product);
        }
    }
}
