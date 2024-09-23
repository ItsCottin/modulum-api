using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using modulum_api.Model.Request;
using modulum_api.Model.Response;
using modulum_api.Model;
using System.Text;
using modulum_api.Services;
using Microsoft.AspNetCore.Authorization;

namespace modulum_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly IAccountService _accountService;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration, IEmailService emailService, IAccountService accountService) 
        {
            _userManager = userManager;
            _configuration = configuration;
            _emailService = emailService;
            _accountService = accountService;
            _signInManager = signInManager;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] UsuarioRequest model)
        {
            IdentityUser newUser = new IdentityUser { Email = model.email, UserName = model.userName };

            //var result = await _userManager.CreateAsync(newUser, model.password!);
            var result = await _userManager.CreateAsync(newUser, model.password!);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToArray();
                return Ok(new CadastroUsuarioResponse { Status = false, Mensagem = errors[0] });
            }

            var confirmEmailToken = await _userManager.GenerateEmailConfirmationTokenAsync(newUser); //newUser
            var encodeEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);
            var validEmailToken = WebEncoders.Base64UrlEncode(encodeEmailToken);
            string url = $"{_configuration["FrontendUrl"]}/confirm-email/{newUser.Id}/{validEmailToken}"; //newUser

            var requestDto = new EmailRequest
            {
                To = newUser.Email, //newUser
                Subject = "Confirme seu E-mail",
                Message = $@"Olá, <br /> <br />
Recebemos sua solicitação de registro para o nosso sistema Modulum. <br /> <br />
Para confirmar sua inscrição clique no link a seguir: <a href=""{url}"">confirme seu cadastro</a> <br /> <br />
Se você não solicitou esse registro, pode ignorar este e-mail com segurança. Outra pessoa pode ter digitado seu endereço de e-mail por engano."
            };
            var retunText = await _emailService.SendEmail(requestDto);
            return Ok(new CadastroUsuarioResponse { Status = true, Mensagem = "Por favor confirme seu e-mail na caixa de entrada.", url = url });
        }

        [HttpGet("confirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
            {
                return BadRequest( new BaseResponse { Status = true, Mensagens = ["Por favor confirme seu e-mail na caixa de entrada."] });
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var decodedToken = WebEncoders.Base64UrlDecode(token);
                string normalToken = Encoding.UTF8.GetString(decodedToken);
                var result = await _userManager.ConfirmEmailAsync(user, normalToken);
                if (result.Succeeded)
                {
                    return Ok(new BaseResponse { Status = true, Mensagens = [ "E-mail confirmado com sucesso" ] });
                }
                return BadRequest(new BaseResponse { Status = false, Mensagens = ["Houve um erro, mais não é sua culpa"] });
            }
            return BadRequest(new BaseResponse { Status = false, Mensagens = ["Houve um erro, mais não é sua culpa"] });
        }

        [HttpGet("isConfirmedEmail")]
        public async Task<BaseResponse> isConfirmedAccount(string email) 
        { 
            return await _accountService.isEmailConfirmed(email);
        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody] object empty)
        {
            if (empty is not null)
            {
                await _signInManager.SignOutAsync();
            }
            return Ok();
        }
    }
}
