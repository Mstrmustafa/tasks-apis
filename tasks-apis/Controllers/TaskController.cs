using Microsoft.AspNetCore.Mvc;
using Tasks.Common.ViewModels;
using Tasks.Infrastructure.Service;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpPost("create-task")]
    public async Task<ActionResult> CreateTask([FromBody] CreateTaskDto createTaskViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var response = await _taskService.CreateTask(createTaskViewModel);
        return Created("", response);
    }

    [HttpGet("get-all-tasks")]
    public async Task<ActionResult> GetAllTasks()
    {
        var response = await _taskService.GetTasks();
        return Ok(response);
    }

    [HttpPut("edit-task/{id}")]
    public async Task<ActionResult> UpdateTask(int id, [FromBody] CreateTaskDto createTaskViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var response = await _taskService.UpdateTask(id, createTaskViewModel);

        if (response == null)
        {
            return NotFound(new { Message = "Task not found" });
        }

        return Ok(response);
    }

    [HttpDelete("delete-task/{id}")]
    public async Task<ActionResult> DeleteTask(int id)
    {
        var response = await _taskService.DeleteTask(id);

        if (!response)
        {
            return NotFound(new { Message = "Task not found" });
        }

        return Ok(new { Message = "Task deleted successfully" });
    }

    [HttpGet("get-all-tasks-id-text")]
    public async Task<ActionResult> GetTasksIdText()
    {
        var response = await _taskService.GetTasksidtext();
        
        return Ok(response);
    }
}
