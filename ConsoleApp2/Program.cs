using Microsoft.EntityFrameworkCore;
using System.Data;
using YourDay.DAL;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new();


            var users =  context.Users
                    .AsQueryable()
                    .Include(c => c.Specializations)
                    .Where(u => u.Role == YourDay.DAL.Enums.Role.Worker)
                    .Where(u => u.IsDeleted == false).ToList();
            Console.WriteLine();
        }
    }
}
