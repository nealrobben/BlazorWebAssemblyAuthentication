using BlazorWebAssemblyAuthentication.Server.Models;
using BlazorWebAssemblyAuthentication.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebAssemblyAuthentication.Server.Controllers
{
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserLoginController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginModel loginModel)
        {
            //var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
            return null;
        }
    }
}
