using YourDay.BLL.IMaster.Models;
using YourDay.BLL.Models.OutputModels;

namespace YourDay.BLL.IMaster
{
    public class MasterMock : IMasters
    {
        private List<TaskOutputModel> _task;

        public MasterMock()
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
                    Status ="В работе",
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
                    Status ="Завершен",
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
                    Status ="В работе",
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
                Status= model.Status,

            };
        }
        public TaskOutputModel GetTaskById(int id)
        {
            return _task[id - 1];
        }
    }
}
