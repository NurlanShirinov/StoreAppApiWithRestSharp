using Microsoft.AspNetCore.Mvc;
using StoreApp.Core.RequestModels;
using StoreApp.Service.Services.Abstract;

namespace StoreApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _userService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _userService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet("CheckUserWithEmal")]
        public async Task<IActionResult> CheckUserWithEmail(string email)
        {
            var result = await _userService.CheckUserByEmailAsync(email);
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(PostUserRequestModel user)
        {
            var result = await _userService.Post(user);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PutUserRequestModel model, int id)
        {
            var result = await _userService.Put(model, id);
            return Ok(result);
        }
    }
}