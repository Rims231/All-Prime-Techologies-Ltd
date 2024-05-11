using All_Prime_Techologies_Ltd.Dtos;
using BCrypt.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace All_Prime_Techologies_Ltd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        [HttpPost("register")]

        public ActionResult<User>Register(UserDto request)
        {
            string passwordHash
                = BCrypt.Net.BCrypt.HashPassword(request.Password);

            user.UserName1 = request.UserName1;
            user.PasswordHash = passwordHash;
            return Ok(user);
        }
        [HttpPost("login")]

        public ActionResult<User> Login(UserDto request)
        {
            if(user.UserName1 != request.UserName1)
            {
                return BadRequest("User not found");

            }
            if(!BCrypt.Net.BCrypt.Verify(request.Password,user.PasswordHash))
            {
                return BadRequest("wrong password");
            }

            string token = CreateToken(user);
            return Ok(token);
            
           }
        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
              {
                  new Claim(ClaimTypes.Name, user.UserName1),
              };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSetting:Token").Value!));

            var cred= new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred);
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
    }
}
