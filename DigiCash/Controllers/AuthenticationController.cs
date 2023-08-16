using DigiCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DigiCash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly JwtModel _jwtModel;
        public AuthenticationController(IOptions<JwtModel> jwtModel)
        {
            _jwtModel = jwtModel.Value;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            var user2 = authenticateUser(user);
            if (user2 == null) return NotFound("Kullanici bulunamadi.");

            var token = createToken(user);
            return Ok(token);
        }

        private User? authenticateUser(User user) {
            throw new NotImplementedException();
        }

        private string createToken(User user)
        {
            if (_jwtModel.Key == null) throw new Exception("JWT Key değeri null olamaz.");

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtModel.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claimList = new[]
            {
                new Claim(ClaimTypes.NameIdentifier , user.tc!),
                new Claim(ClaimTypes.NameIdentifier , user.firstName),
                new Claim(ClaimTypes.NameIdentifier , user.lastName)
            };
            var token = new JwtSecurityToken(_jwtModel.Issuer, _jwtModel.Audience, claimList, expires: DateTime.Now.AddMonths(3) , signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
