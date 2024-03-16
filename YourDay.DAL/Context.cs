using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;

namespace YourDay.DAL
{
    public class Context : DbContext
    {
        public DbSet<UserDto> Users { get; set; }

        public DbSet<HistoryDto> Histories { get; set; }

        public DbSet<TaskDto> Tasks { get; set; }

        public DbSet<OrderDto> Orders { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Options.connectionString);
        }
    }
}