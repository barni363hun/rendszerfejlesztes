using ClassLibrary.DTOs;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers
{
    [ApiController]
    public class IdentityController : ControllerBase
    {

        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        public IdentityController(DataContext context, IConfiguration configuration)
        {
            this._context = context;
            _configuration = configuration;
        }

        [HttpPost("token")]
        public IActionResult GenerateToken(ManagerLoginDTO loginDTO)
        {

            var manager = _context.Managers.FirstOrDefault(m => m.email == loginDTO.Email);
            if (manager == null)
            {
                return NotFound("User with this email not found.");
            }
            else
            {
                if (manager.password == loginDTO.Password)
                {
                    
                    // Define claims
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, manager.email),
                        //new Claim(ClaimTypes.Role, manager.)
                    };

                    // Create ClaimsIdentity
                    var claimsIdentity = new ClaimsIdentity(claims, "Token");

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Token").Value ?? throw new Exception("Token kulcs nincs megadva")));

                    // Create token descriptor
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = claimsIdentity,
                        Expires = DateTime.UtcNow.AddHours(24), // Token expiration time
                        SigningCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature)
                    };

                    // Create token
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var token = tokenHandler.CreateToken(tokenDescriptor);

                    // Write token as string
                    var tokenString = tokenHandler.WriteToken(token);

                    return Ok(new { Token = tokenString });
                }
                else
                {
                    return Unauthorized("Wrong password.");
                }
            }

        }

        //[Authorize]
        //[HttpPost("tokendata")]
        //public IActionResult TokenData()
        //{

        //}
    }
}
