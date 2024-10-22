using Tasks.Common.Models;
using Tasks.Common.ViewModels;
namespace Tasks.Common.Repository
{
    public interface ITaskRepository
    {
        Task<TaskModel> CreateTask(TaskModel task);
        Task<bool> DeleteTask(int id);
        Task<List<TaskModel>> GetTasks();
        Task<TaskModel?> UpdateTask(int id, TaskModel task);
        Task<int> GetLastItem();

        Task<List<Gettask>> GetTasksidtext();
    }
}
