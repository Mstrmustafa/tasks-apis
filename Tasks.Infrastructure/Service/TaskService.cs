using AutoMapper;
using Tasks.Common.Models;
using Tasks.Common.Repository;
using Tasks.Common.ViewModels;

namespace Tasks.Infrastructure.Service
{
    internal class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<TaskModel> CreateTask(CreateTaskDto taskDto)
        {
            var taskModel = _mapper.Map<TaskModel>(taskDto);
            return await _taskRepository.CreateTask(taskModel);
        }

        public async Task<bool> DeleteTask(int id)
        {
            return await _taskRepository.DeleteTask(id);
        }

        public async Task<TaskModel?> UpdateTask(int id, CreateTaskDto createTaskDto)
        {
            var taskModel = _mapper.Map<TaskModel>(createTaskDto);
            return await _taskRepository.UpdateTask(id, taskModel);
        }

        public async Task<List<TaskModel>> GetTasks()
        {
            return await _taskRepository.GetTasks();
        }

        public async Task<List<Gettask>> GetTasksidtext()
        {
            return await _taskRepository.GetTasksidtext();
        }
    }
}
