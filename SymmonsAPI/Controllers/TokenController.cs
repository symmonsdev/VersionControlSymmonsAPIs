using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SymmonsAPI.Models;

namespace SymmonsAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class TokenController : ControllerBase

    public class TokenController : Controller
    {
        private IConfiguration _config;

        public TokenController(IConfiguration config)
        {
            _config = config;
        }
        //private UserManager<ApplicationUser> _userManager;

        public IActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                var tokenString = BuildToken();
                TokenModel token = new TokenModel();
                token.Value = tokenString;
                return View(token);
            }
            else
            {
                return Redirect("identity/account/login");
            }
        }

        [AllowAnonymous]
        //[HttpPost]
        //public IActionResult CreateToken([FromBody] LoginModel login)
        //{
        //    IActionResult response = Unauthorized();
        //    var user = Authenticate(login);

        //    if (user != null)
        //    {
        //        var tokenString = BuildToken(user);
        //        response = Ok(new { token = tokenString });
        //    }

        //    return response;
        //}

        private string BuildToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            
            ClaimsPrincipal currentUser = this.User;
            var userId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            var userName = User.Identity.Name;

            //create a identity and add claims to the user which we want to log in
            var claims = new[]
            {
               new Claim(ClaimTypes.Name, userId),
               new Claim(ClaimTypes.Name, userName)
            };

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims: claims,
              expires: DateTime.Now.AddMonths(7),
              signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        //expires: DateTime.Now.AddHours(4).AddMonths(7),
        private UserModel Authenticate(LoginModel login)
        {
            UserModel user = null;
            //this.User.Identity.
            if (login.Username == "mario" && login.Password == "secret")
            {
                user = new UserModel { Name = "Mario Rossi", Email = "mario.rossi@domain.com" };
            }
            return user;
        }

        public class LoginModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private class UserModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime Birthdate { get; set; }
        }
        
    }
}
