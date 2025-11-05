using Microsoft.EntityFrameworkCore;
using TaskTracker.Application.Interfaces;
using TaskTracker.Application.Services;
using TaskTracker.Infrastructure.Persistence;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("TaskDb"));
builder.Services.AddScoped<ITaskService, TaskService>();
builder.WebHost.UseUrls("http://localhost:5000");
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Task Tracker API v1");
    c.RoutePrefix = "swagger";
});
app.MapControllers();
app.Run();
