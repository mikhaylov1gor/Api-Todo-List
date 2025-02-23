using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Api_Todo.Models.DB
{
    public class Todo
    {
        public Guid id { get; set; }

        [MinLength(1)]
        public string? text { get; set; }
        public bool isCompleted {  get; set; }
    }
}
