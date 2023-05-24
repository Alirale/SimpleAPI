using Domain.Models;
using Domain.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]/v{version:ApiVersion}")]
    [Authorize]
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("TestAPI")]
        public async Task<Response<TokenModel>> Get()
        {
            var result = Response<TokenModel>.Success(new TokenModel() { Audience = "Test" });
            _logger.LogInformation("api done");
            return result;
        }
    }
}