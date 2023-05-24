using System.Security.Claims;
using System.Text;
using Application.Common;
using Application.Interfaces;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace Application.Services
{
    public class AuthorizationService: IAuthorizationService
    {
        private readonly IConfiguration _configuration;

        public AuthorizationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> ValidateLogin(UserLoginModel loginModel)
        {
            var hashedPassword = SecurityHelper.CreateSHA512(loginModel.Password);
            var Person = true;//validation Logic 
            if (!Person) return null;
            var token = GenerateToken(loginModel);
            return token;
        }

        public string GenerateToken(UserLoginModel loginModel)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.UserName ?? throw new InvalidOperationException()),
            };
            var key = _configuration["JWtConfig:Key"];
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWtConfig:issuer"],
                audience: _configuration["JWtConfig:audience"],
                claims: claims,
                signingCredentials: credentials
            );
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}