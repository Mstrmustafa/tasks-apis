using Microsoft.EntityFrameworkCore;
using Tasks.Common.Models;

namespace Tasks.Common.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}