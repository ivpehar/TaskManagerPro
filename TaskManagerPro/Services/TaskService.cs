using TaskManagerPro.Data;

namespace TaskManagerPro.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskManagerProContext _context;

        public TaskService(TaskManagerProContext context)
        {
            _context = context;
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }
    }
}
