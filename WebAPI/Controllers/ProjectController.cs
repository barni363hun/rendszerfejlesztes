using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly DataContext _context;
        public ProjectController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Project>>> AddProject(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return Ok(await _context.Projects.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>>GetAllProjects(){
        return Ok(await _context.Projects.ToListAsync());
                }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return BadRequest("project not found");
            }
            return Ok(project);
        }

    }
}
