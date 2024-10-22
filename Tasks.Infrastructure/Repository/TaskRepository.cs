using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Tasks.Common.Data;
using Tasks.Common.Models;
using Tasks.Common.Repository;
using Tasks.Common.ViewModels;
namespace Tasks.Infrastructure.Repository
{
    internal class TaskRepository : ITaskRepository
    {
        private readonly MyDbContext _context;

        public TaskRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<TaskModel> CreateTask(TaskModel taskModel)
        {
            _context.Tasks.Add(taskModel);
            await _context.SaveChangesAsync();

            return taskModel;
        }

        public async Task<bool> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
            {
                return false;
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<TaskModel?> UpdateTask(int id, TaskModel taskDto)
        {
            var existingTask = await _context.Tasks.FindAsync(id);

            if (existingTask == null)
            {
                return null;
            }

            existingTask.Text = taskDto.Text;
            existingTask.Level = taskDto.Level;
            existingTask.ExternalInternal = taskDto.ExternalInternal;
            existingTask.Timing = taskDto.Timing;
            
            await _context.SaveChangesAsync();

            return existingTask;
        }

        public async Task<List<TaskModel>> GetTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<int> GetLastItem()
        {
            return await _context.Tasks.CountAsync();
        }

        public async Task<List<Gettask>> GetTasksidtext()
        {
            return await _context.Tasks.Select((t) => new Gettask { Id = t.Id, Text = t.Text }).ToListAsync();
                            
        }

    }
}
