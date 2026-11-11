using Microsoft.EntityFrameworkCore;
using TaskBackend.Models;

namespace TaskBackend.Data;

public class TaskContext: DbContext
{
    public TaskContext(DbContextOptions<TaskContext> options)
    : base(options)
    {
        
    } 

    public DbSet<TaskItem> TaskItems {get; set; } = null!;
}

