using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Win32;
using modulum_api.Model;
using modulum_api.Model.Request;
using modulum_api.Model.Response;
using modulum_api.Services;
using System.Reflection;
using System.Text;

namespace modulum_api.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;

        public UserController(SignInManager<IdentityUser> signInManager, IUserService userService, IConfiguration configuration, IEmailService emailService)
        {
            _signInManager = signInManager;
            _userService = userService;
            _configuration = configuration;
            _emailService = emailService;
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userList = await _userService.GetAllUsers();
            return Ok(userList);
        }

        [Authorize(Roles = "admin")]
        [HttpGet("{emailId}")]
        public async Task<IActionResult> Get(string emailId)
        {
            var userList = await _userService.GetUserByEmail(emailId);
            return Ok(userList);
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{emailId}")]
        public async Task<IActionResult> UpdateUser(string emailId, [FromBody] Usuario userModel)
        {
            var result = await _userService.UpdateUser(emailId, userModel);
            if (!result)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("{emailId}")]
        public async Task<IActionResult> Delete(string emailId)
        {
            var result = await _userService.DeleteUserByEmail(emailId);
            if (!result)
            {
                return BadRequest();
            }
            return NoContent();
        }

    }
}
