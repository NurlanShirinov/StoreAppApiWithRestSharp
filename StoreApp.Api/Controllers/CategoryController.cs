using Microsoft.AspNetCore.Mvc;
using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Service.Services.Abstract;

namespace StoreApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _categoryService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("CreateAsync")]
        public async Task<IActionResult> Create(UpdateCategoryRequestModel category)
        {
            var result = await _categoryService.CreateAsync(category);
            return Ok(result);
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> Update(UpdateCategoryRequestModel category, int id)
        {
            var result = await _categoryService.UpdateAsync(category, id);
            return Ok(result);
        }

        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _categoryService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
