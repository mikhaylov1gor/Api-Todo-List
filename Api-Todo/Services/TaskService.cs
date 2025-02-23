using Api_Todo.Models.DB;
using Api_Todo.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Api_Todo.Services
{
    public interface ITaskService
    {
        Task<List<Todo>> GetList();
        Task<Todo> CreateTask(string text);
        Task<ActionResult<ResponseModel>> EditTask(Guid id, string newText);
        Task<ActionResult<ResponseModel>> ToggleTask(Guid id);
        Task<ActionResult<ResponseModel>> DeleteTask(Guid id);
    }
    public class TaskService : ITaskService
    {
        private readonly TodoDbContext _context;

        public TaskService(TodoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Todo>> GetList()
        {
            var tasks = await _context.Tasks.ToListAsync();

            return tasks;
        }

        public async Task<Todo> CreateTask(string text)
        {
            Todo newTodo = new Todo { isCompleted = false, text = text };

            await _context.Tasks.AddAsync(newTodo);
            await _context.SaveChangesAsync();

            return newTodo;
        }

        public async Task<ActionResult<ResponseModel>> EditTask(Guid id, string newText)
        {
            var todo = await _context.Tasks.FindAsync(id);
            if (todo == null)
            {
                return new ResponseModel { status = "404", message = "Not Found" };
            }
            else
            {
                todo.text = newText;
                await _context.SaveChangesAsync();
                return new ResponseModel { status = "200", message = "Ok" };
            }
        }

        public async Task<ActionResult<ResponseModel>> ToggleTask(Guid id)
        {
            var todo = await _context.Tasks.FindAsync(id);
            if (todo == null)
            {
                return new ResponseModel { status = "404", message = "Task by id not found" };
            }
            else
            {
                todo.isCompleted = !todo.isCompleted;
                await _context.SaveChangesAsync();
                return new ResponseModel { status = "200", message = "Ok" };
            }
        }

        public async Task<ActionResult<ResponseModel>> DeleteTask(Guid id)
        {
            var todo = await _context.Tasks.FindAsync(id);
            if (todo == null)
            {
                return new ResponseModel { status = "404", message = "Task by id not found" };
            }

            _context.Tasks.Remove(todo);
            await _context.SaveChangesAsync();

            return new ResponseModel { status = "200", message = "Ok" };
        }
    }
}
