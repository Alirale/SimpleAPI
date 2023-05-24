using Application.Interfaces;
using Domain.Models;
using Domain.Response;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]/v{version:ApiVersion}")]
    public class AuthorizationController : Controller
    {
        private readonly IAuthorizationService _authorizationService;

        public AuthorizationController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        [HttpPost]
        public async Task<Response<string>> ValidateAsync([FromBody] UserLoginModel loginModel)
        {
            var token = await _authorizationService.ValidateLogin(loginModel);
            return string.IsNullOrEmpty(token)
                ? Response<string>.Failure("username And password does not match.please try again")
                : Response<string>.Success(token);
        }
    }
}