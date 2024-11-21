using ex3.Models;
using Microsoft.EntityFrameworkCore;

namespace ex3.Repository
{
    public class TasksDBcontext : DbContext
    {
        public TasksDBcontext(DbContextOptions<TasksDBcontext> options) : base(options)
        {

        }
     
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
