using TaskManagerPro.Data;

namespace TaskManagerPro.Services
{
    public interface ITaskService
    {
        Task AddTaskAsync(TaskItem task);
    }
}
