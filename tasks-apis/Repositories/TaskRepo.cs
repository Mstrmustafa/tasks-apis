using AutoMapper;
using tasks_apis.Dtos;
using tasks_apis.Interfaces;
using tasks_apis.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tasks_apis.Repositories
{
    public class TaskRepo : TaskInterfaces
    {
        private readonly IMapper _mapper;

        private static List<TaskModel> tasks = new List<TaskModel>();

        public TaskRepo(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<TaskModel> CreateTaskAsync(CreateTaskDTO taskDto)
        {
            var taskModel = _mapper.Map<TaskModel>(taskDto);
            taskModel.Id = tasks.Count > 0 ? tasks[^1].Id + 1 : 1;

            tasks.Add(taskModel);

            return await Task.FromResult(taskModel);
        }

        public Task<bool> DeleteTaskAsync(int id)
        {
            var task = tasks.Find(t => t.Id == id);

            if (task == null)
            {
                return Task.FromResult(false);
            }

            tasks.Remove(task);

            return Task.FromResult(true);
        }

        public Task<TaskModel> UpdateTaskAsync(int id, CreateTaskDTO taskDto)
        {
            var existingTask = tasks.Find(t => t.Id == id);

            if (existingTask == null)
            {
                return Task.FromResult<TaskModel>(null);
            }

            _mapper.Map(taskDto, existingTask);

            return Task.FromResult(existingTask);
        }

        public async Task<IEnumerable<TaskModel>> GetTasksAsync()
        {
            return await Task.FromResult(tasks);
        }
    }
}
