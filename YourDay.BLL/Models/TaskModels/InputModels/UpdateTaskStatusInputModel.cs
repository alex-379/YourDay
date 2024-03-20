using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class UpdateTaskStatusInputModel
    {
        public Status Status { get; set; }
        public int TaskId { get; set; }

    }
}