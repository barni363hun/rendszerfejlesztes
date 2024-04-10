using ClassLibrary.DTOs;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly DataContext _context;
        public ManagerController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Manager>> LoginManager(ManagerLoginDTO loginDTO)
        {
            var manager = await _context.Managers.FirstOrDefaultAsync(m => m.email == loginDTO.Email);
            if (manager == null)
            {
                return NotFound("User with this email not found.");
            }
            else
            {
                if (manager.password == loginDTO.Password)
                {
                    return Ok(manager);
                }
                else
                {
                    return Unauthorized("Wrong password.");
                }
            }
        }
    }
}
