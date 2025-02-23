using Microsoft.EntityFrameworkCore;

namespace Api_Todo.Models.DB
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Tasks {  get; set; }

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }
    }
}
