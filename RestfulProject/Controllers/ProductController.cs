using Microsoft.AspNetCore.Mvc;
using Restful.Core.Models;
using Restful.Core.Services;

namespace Restful.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }


        /// GET api/products
        [HttpGet]
        [Route("product/all")]
        public async Task<IActionResult> All()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        [Route("product/add")]
        public async Task<IActionResult> Save(Product product)
        {
            return Ok(await _service.AddAsync(product));
        }


        [HttpPut]
        [Route("product/update")]
        public async Task<IActionResult> Update(Product product)
        {
            await _service.UpdateAsync(product);
            return NoContent();
        }

        // DELETE api/products/5
        [HttpDelete]
        [Route("product/delete/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = _service.GetByIdAsync(id);
            if (product == null)
                return BadRequest();
            await _service.RemoveAsync(product);

            return NoContent();
        }
    }
}
