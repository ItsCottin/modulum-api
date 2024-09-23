using Microsoft.AspNetCore.Identity;
using modulum_api.Model.Request;
using modulum_api.Model.Response;
using System.IdentityModel.Tokens.Jwt;

namespace modulum_api.Services
{
    public interface IAccountService
    {
        Task<BaseResponse> isEmailConfirmed(string email);
    }
}
