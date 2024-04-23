using ClassLibrary.DTOs;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace WebAPI.Controllers
{
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly SymmetricSecurityKey _securityKey;

        private readonly DataContext _context;
        public IdentityController(DataContext context)
        {
            var passphrase = "nagyontitkuskulcs";
            _securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(passphrase));
            this._context = context;
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
                        new Claim(ClaimTypes.NameIdentifier, manager.email), // Example claim
                        // Add more claims as needed
                    };

                    // Create ClaimsIdentity
                    var claimsIdentity = new ClaimsIdentity(claims, "Token");

                    // Create token descriptor
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = claimsIdentity,
                        Expires = DateTime.UtcNow.AddHours(24), // Token expiration time
                        SigningCredentials = new SigningCredentials(_securityKey,SecurityAlgorithms.Sha256)
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
    }
}
