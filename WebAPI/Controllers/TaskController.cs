using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Model;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {

        private readonly DataContext _context;
        public TaskController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClassLibrary.Model.Task>>> GetAllTasks()
        {
            return Ok(await _context.Tasks.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<ClassLibrary.Model.Task>>> AddTask(ClassLibrary.Model.Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return Ok(await _context.Projects.ToListAsync());
        }
    }
}
