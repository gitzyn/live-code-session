using Microsoft.AspNetCore.Mvc;
using TaskTracker.Application.Interfaces;
namespace TaskTracker.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;
    public TasksController(ITaskService taskService) => _taskService = taskService;

    [HttpGet]
    public Task<IActionResult> GetAll() => throw new NotImplementedException();

    [HttpPost]
    public Task<IActionResult> Create([FromBody] CreateTaskRequest request) => throw new NotImplementedException();

    [HttpPut("{id}/complete")]
    public Task<IActionResult> Complete(int id) => throw new NotImplementedException();

    public record CreateTaskRequest(string Title, string? Description);
}
