using YourDay.BLL.Enums;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.UserModels.InputModels;

namespace YourDay.BLL.Models.TaskModels.InputModels
{
    public class TaskUpdateInputModelAllInfo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public StatusUI? Status { get; set; }

        public IEnumerable<UserInputModel>? Workers { get; set; }

        public OrderInputModel? Order { get; set; }

        public SpecializationInputModel? Specialization { get; set; }
    }
}