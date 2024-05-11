using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Model;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using ClassLibrary.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Net.Http.Json;
using Newtonsoft.Json;


namespace WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {

        private readonly DataContext _context;
        private readonly IHubContext<TaskHub> _hubContext;
        public TaskController(DataContext context, IHubContext<TaskHub> hubContext)
        {
            this._context = context;
            _hubContext = hubContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClassLibrary.Model.Task>>> GetAllTasks()
        {
            return Ok(await _context.Tasks.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<ClassLibrary.Model.Task>> AddTask(TaskDTO task)
        {
            Project? project = await _context.Projects.FindAsync(task.ProjectId);
            if (project == null)
            {
                return BadRequest("project not found");
            }
            Manager? manager = await _context.Managers.FindAsync(task.ManagerId);
            if (manager == null)
            {
                return BadRequest("manager not found");
            }
            ClassLibrary.Model.Task newTask = new ClassLibrary.Model.Task
            {
                deadline = task.Deadline,
                name = task.Name,
                description = task.Description,
                managerId = task.ManagerId,
                projectId = task.ProjectId,
                manager = manager,
                project = project

            };
            await _context.Tasks.AddAsync(newTask);
            await _context.SaveChangesAsync();


            newTask.manager = null;
            newTask.project = null;
            string taskString = JsonConvert.SerializeObject(newTask);
            await _hubContext.Clients.All.SendAsync("NewTask", taskString);

            return Ok();
        }
    }
}
