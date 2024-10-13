using tasks_apis.Dtos;
using tasks_apis.Models;

namespace tasks_apis.Interfaces
{
    public interface TaskInterfaces
    {
        Task<TaskModel> CreateTaskAsync(CreateTaskDTO task);
        Task<bool> DeleteTaskAsync(int id);
        Task<IEnumerable<TaskModel>> GetTasksAsync();
        Task<TaskModel> UpdateTaskAsync(int id, CreateTaskDTO task);
    }
}
