using Tasks.Common.Models;
using Tasks.Common.ViewModels;

namespace Tasks.Infrastructure.Service
{
    public interface ITaskService
    {
        Task<TaskModel> CreateTask(CreateTaskDto task);
        Task<bool> DeleteTask(int id);
        Task<List<TaskModel>> GetTasks();
        Task<TaskModel?> UpdateTask(int id, CreateTaskDto task);
        Task<List<Gettask>> GetTasksidtext();


    }
}
