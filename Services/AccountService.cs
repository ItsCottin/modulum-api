using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using modulum_api.Model.Response;
using modulum_api.Model.Request;
using modulum_api.Model;
using System.Security.Cryptography;
using Microsoft.Extensions.Options;

namespace modulum_api.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AccountService(UserManager<IdentityUser> userManager) 
        {
            _userManager = userManager;
        }

        public async Task<BaseResponse> isEmailConfirmed(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return new BaseResponse { Status = false, Mensagens = [ "E-mail informado não existe" ] };
            }
            return new BaseResponse { Status = user.EmailConfirmed, Mensagens = [ "E-mail informado " + (user.EmailConfirmed ? "está confirmado" : "não está confirmado, Por favor confirme seu e-mail na caixa de entrada.") ] };
        }

    }
}
