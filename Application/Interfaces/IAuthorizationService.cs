using Domain.Models;

namespace Application.Interfaces
{
    public interface IAuthorizationService
    {
        public Task<string> ValidateLogin(UserLoginModel loginModel);
    }
}