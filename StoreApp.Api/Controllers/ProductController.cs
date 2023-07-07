using Microsoft.AspNetCore.Mvc;
using StoreApp.Core.RequestModels;
using StoreApp.Service.Services.Abstract;

namespace StoreApp.Api.Controllers
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

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostProductRequestModel product)
        {
            var result = await _productService.CreateAsync(product);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductRequestModel product, int id)
        {
            var result = await _productService.UpdateAsync(product, id);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productService.DeleteAsync(id);
            return Ok(result);
        }


        //Fake Api doesn't allow to see category id on products
        [HttpGet("GetByCategoryid")]
        public async Task<IActionResult> GetByCategoryid(int categoryId)
        {
            var result = await _productService.GetProductsByCategoryId(categoryId);
            return Ok(result);
        }
    }
}