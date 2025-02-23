using Api_Todo.Models.DB;
using Api_Todo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Todo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TaskController : Controller
    {
        private ITaskService _taskService;

        public TaskController(ITaskService _service)
        {
            _taskService = _service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Todo>>> getList()
        {
            var todos = await _taskService.GetList();
            return Ok(todos);
        }

        [HttpPost]
        public async Task<ActionResult> createTask (string text)
        {
            var response = await _taskService.CreateTask(text);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> editTask(Guid id, string newText)
        {
            var response = await _taskService.EditTask(id, newText);
            return Ok(response);
        }

        [HttpPut("{id}/toggle")]
        public async Task<ActionResult> toggleTask(Guid id)
        {
            var response = await _taskService.ToggleTask(id);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteTask(Guid id)
        {
            var response = await _taskService.DeleteTask(id);
            return Ok(response);
        }
    }
}
