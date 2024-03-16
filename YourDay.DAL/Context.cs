using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;

namespace YourDay.DAL
{
    public class Context : DbContext
    {
        private SingletoneStorage _context;

        public DbSet<UserDto> Users { get; set; }

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