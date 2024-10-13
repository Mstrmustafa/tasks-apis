using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using tasks_apis.Dtos;
using tasks_apis.Models;
using System.Collections.Generic;
using tasks_apis.Repositories;
using tasks_apis.Interfaces;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    //private readonly IMapper _mapper;
    private readonly TaskInterfaces _taskRepo;

    //private static List<TaskModel> tasks = new List<TaskModel>();

    public TaskController(TaskInterfaces taskRepo)
    {
        //_mapper = mapper;
        _taskRepo = taskRepo;
    }

    [HttpPost("create-task")]
    public IActionResult CreateTask([FromBody] CreateTaskDTO taskDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var taskModel =  _taskRepo.CreateTaskAsync(taskDto);

        return Ok(taskModel);
    }

    [HttpGet("get-all-tasks")]
    public async Task<IActionResult> GetAllTasksAsync()
    {
        var task =  await _taskRepo.GetTasksAsync();

        return Ok(task);
    }

    [HttpPut("edit-task/{id}")]
    public  IActionResult EditTask(int id, [FromBody] CreateTaskDTO taskDto)
    {
        var updatedTask =  _taskRepo.UpdateTaskAsync(id, taskDto);

        if (updatedTask == null)
        {
            return NotFound(new { Message = "Task not found" });
        }

        return Ok(updatedTask);
    }

    [HttpDelete("delete-task/{id}")]
    public async Task<IActionResult> DeleteTask(int id)
    {
        var result = await _taskRepo.DeleteTaskAsync(id);

        if (!result)
        {
            return NotFound(new { Message = "Task not found" });
        }

        return Ok(new { Message = "Task deleted successfully" });
    }
}
