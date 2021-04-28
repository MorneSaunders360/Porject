using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Portal.Models;

namespace Portal.Controllers.Api
{
  
    public class AccountController : BaseController
    {
        private SignInManager<IdentityUser> _signManager;
        private UserManager<IdentityUser> _userManager;
        private IConfiguration _config;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signManager, IConfiguration config)
        {
            _userManager = userManager;
            _signManager = signManager;
            _config = config;
        }
        [AllowAnonymous]
        [HttpPost("LoginApi/")]
        public async Task<IActionResult> LoginApi([FromBody] LoginViewModel model)
        {
            IActionResult response = Unauthorized();
            var result = await _signManager.PasswordSignInAsync(model.Username,
                 model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                var tokenString = GenerateJSONWebToken(model);
                response = Ok(new { token = tokenString });
            }
            return response;
        }
        private string GenerateJSONWebToken(LoginViewModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddYears(1),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
