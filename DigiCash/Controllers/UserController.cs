using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DigiCash.Models;
using DigiCash.Services;

namespace DigiCash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserServices _userServices;

        public UserController(UserManager<IdentityUser> userManager , SignInManager<IdentityUser> signInManager , UserServices userServices)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userServices = userServices;
        }
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                var createUserResult = await _userServices.CreateUser(user.tc, user.firstName, user.lastName, user.password);

                if (createUserResult)
                {
                    return Ok(new { message = "Kullanici basariyla olusturuldu." });
                }
                else
                {
                    return BadRequest(new { message = "Kullanciyi olustururken bir hata meydana geldi." });
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromBody] User user)
        {
            var signInResult = await _signInManager.PasswordSignInAsync(user.tc, user.password, isPersistent: false, lockoutOnFailure: false);

            if (signInResult.Succeeded)
            {
                return Ok(new { message = "Basariyla giris yapildi." });
            }
            else
            {
                return Unauthorized(new { message = "Yanlis bilgiler girildi." });
            }
        }

        [HttpPost("signout")]
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();

            return Ok(new { message = "Cikis yapildi." });
        }

       /* [HttpDelete("delete")]
        public async Task<IActionResult> DeleteOneUser()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound(new { message = "Kullanici bulunamadi" });
            }

            var deleteResult = await _userServices.DeleteOneUser(currentUser);
            if (deleteResult.Succeeded)
            {
                return Ok(new { message = "Kullanici silme islemi basarili." });
            }
            else
            {
                return BadRequest(new { message = "Bir hata meydana geldi." });
            }
        }*/
    }
}
