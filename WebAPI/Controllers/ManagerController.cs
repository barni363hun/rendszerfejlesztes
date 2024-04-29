using ClassLibrary.DTOs;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ClassLibrary.Constants;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly DataContext _context;
        public ManagerController(DataContext context)
        {
            this._context = context;
        }

        [Authorize(Roles = Roles.Admin)]
        [HttpPost]
        public async Task<ActionResult<Manager>> AddManager(ManagerDTO managerDTO)
        {
            var manager = await _context.Managers.FirstOrDefaultAsync(m => m.email == managerDTO.Email || m.name == managerDTO.Name);
            if (manager != null)
            {
                return NotFound("User with this email or name already exits.");
            }
            else
            {
                Manager newManager = new Manager
                {
                    name = managerDTO.Name,
                    email = managerDTO.Email,
                    password = managerDTO.Password,
                };
                await _context.Managers.AddAsync(newManager);
                await _context.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
