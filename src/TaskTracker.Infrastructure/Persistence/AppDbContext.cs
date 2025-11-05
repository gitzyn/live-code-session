using Microsoft.EntityFrameworkCore;
using TaskTracker.Domain.Entities;
namespace TaskTracker.Infrastructure.Persistence;
public class AppDbContext : DbContext
{
    public DbSet<TaskItem> Tasks => Set<TaskItem>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
