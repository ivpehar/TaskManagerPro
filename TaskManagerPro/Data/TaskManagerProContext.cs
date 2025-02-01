using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagerPro.Data;

namespace TaskManagerPro.Data
{
    public class TaskManagerProContext(DbContextOptions<TaskManagerProContext> options) : IdentityDbContext<User>(options)
    {
    }
}
