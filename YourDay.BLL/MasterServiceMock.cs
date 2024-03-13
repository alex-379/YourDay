using YourDay.BLL.IServices;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;

namespace YourDay.BLL
{
    public class MasterServiceMock : IMasterService
    {
        private List<TaskOutputModel> _task;

        public MasterServiceMock()
        {
            _task = new List<TaskOutputModel>()
            {
                new TaskOutputModel()
                {
                    Id = 1,
                    Title = "Букет роз",
                    OrderId = 1,
                    Date="12/02/2024",
                    TimeStart="12:00",
                    TimeEnd="13:00",
                    SpecializationId = 1,
                    StatusId = 1,
                },
                new TaskOutputModel()
                {
                   Id = 2,
                    Title = "Букет тюльпанов",
                    OrderId = 2,
                    Date="03/02/2024",
                    TimeStart="16:00",
                    TimeEnd="17:00",
                    SpecializationId = 1,
                    StatusId = 2,
                },
                new TaskOutputModel()
                {
                    Id = 3,
                    Title = "Живые цветы(фотозона)",
                    OrderId = 3,
                    Date="01/02/2024",
                    TimeStart="10:00",
                    TimeEnd="13:00",
                    SpecializationId = 1,
                    StatusId = 3,
                }
            };
        }

        public List<TaskOutputModel> GetAllTask()
        {
            return _task;
        }

        public TaskOutputModel UpdateStatusTask(TaskInputModel model)
        {
            return new TaskOutputModel()
            {
                Id = 1,
                Title = model.Title,
                OrderId = model.OrderId,
                Date = model.Date,
                TimeStart = model.TimeStart,
                TimeEnd = model.TimeEnd,
                SpecializationId = model.SpecializationId,
                StatusId = model.StatusId,

            };
        }
    }
}
