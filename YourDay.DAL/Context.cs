using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;

namespace YourDay.DAL
{
    public class Context : DbContext
    {
        private SingletoneStorage _context;

        public DbSet<UserDto> User { get; set; }

        public DbSet<HistoryDto> History { get; set; }

        public DbSet<TaskDto> TaskD { get; set; }

        public DbSet<OrderDto> Order { get; set; }


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