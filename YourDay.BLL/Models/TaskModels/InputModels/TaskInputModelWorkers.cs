using YourDay.DAL.Dtos;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModelWorkers
    {
        public IEnumerable<UserDto>? Workers { get; set; }
    }
}