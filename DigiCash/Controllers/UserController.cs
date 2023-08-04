using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DigiCash.Models;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(UserManager<IdentityUser> userManager , SignInManager<IdentityUser> signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public async Task<IActionResult> Register([FromForm] User log)
        {
            return Ok();
        }

        public async Task<IActionResult> Login([FromForm] User log)
        {
            return Ok();
        }
    }
}
