using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
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

        //private string BuildToken(UserModel user)
        private string BuildToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              expires: DateTime.Now.AddHours(4),
              signingCredentials: creds);
            
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

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
