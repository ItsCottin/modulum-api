using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace modulum_api.Configuracao
{
    public class CustomSignInManager : SignInManager<IdentityUser> // Nao foi mentir, essa class foi criada pelo ChatGPT
    {
        public CustomSignInManager(UserManager<IdentityUser> userManager,
        IHttpContextAccessor contextAccessor,
        IUserClaimsPrincipalFactory<IdentityUser> claimsFactory,
        IOptions<IdentityOptions> optionsAccessor,
        ILogger<SignInManager<IdentityUser>> logger,
        IAuthenticationSchemeProvider schemes,
        IUserConfirmation<IdentityUser> confirmation)
        : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
        {
        }

        public override async Task<SignInResult> PasswordSignInAsync(string email, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var user = await UserManager.FindByEmailAsync(email);

            if (user == null)
            {
                return SignInResult.Failed;
            }
            return await base.PasswordSignInAsync(user.UserName, password, isPersistent, lockoutOnFailure);
        }
    }
}
