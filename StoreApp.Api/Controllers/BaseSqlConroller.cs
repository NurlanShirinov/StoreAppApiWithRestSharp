using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApp.Service.Services.Abstract;

namespace StoreApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseSqlConroller : ControllerBase
    {
        private readonly IBaseSqlService _sqlService;
        public BaseSqlConroller(IBaseSqlService sqlService)
        {
            _sqlService = sqlService;
        }
    }
}
