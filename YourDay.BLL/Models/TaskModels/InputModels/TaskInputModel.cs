using YourDay.DAL.Enums;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.InputModels;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskInputModel
    {
        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public List<UserInputModel>? Workers { get; set; }

        public OrderInputModel? Order { get; set; }

        public SpecializationTaskInputModel? Specialization { get; set; }

        public Status? Status { get; set; }
    }
}
