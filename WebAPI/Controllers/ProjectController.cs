using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            var projects = await _context.Projects.Include(p => p.Type).ToListAsync();
            var jsonProjects = JsonSerializer.Serialize(projects, options);
            return Content(jsonProjects, "application/json");
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
