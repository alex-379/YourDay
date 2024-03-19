using YourDay.DAL.Enums;

namespace YourDay.BLL.Models.TaskModels.OutputModels
{
    public class UpdateTaskStatusOutputModel
    {
        public Status Status { get; set; }
        public int TaskId { get; set; }

    }
}