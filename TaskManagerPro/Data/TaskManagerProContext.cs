using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaskManagerPro.Data
{
    public class TaskManagerProContext : IdentityDbContext<User>
    {
        public TaskManagerProContext(DbContextOptions<TaskManagerProContext> options)
            : base(options)
        {
        }

        // Dodaj DbSet za zadatke
        public DbSet<TaskItem> Tasks { get; set; }

    }
}
