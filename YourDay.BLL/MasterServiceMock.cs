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
                    OrderId = 1,
                    Title = "Букет роз",
                    TimeStart= DateTime.ParseExact("2024-01-12 12:00", "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    TimeEnd =DateTime.ParseExact("2024-01-12 13:00", "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    Descriptions ="букет из 10 красных роз, в прозрачной упаковке",
                    SpecializationId = 1,
                    StatusId =1,
                },
                new TaskOutputModel()
                {
                    Id = 2,
                    OrderId = 1,
                    Title = "Букет тюльпанов",
                    TimeStart=DateTime.ParseExact("2024-01-07 10:00", "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    TimeEnd=DateTime.ParseExact("2024-01-07 12:00", "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    Descriptions="букет из 10 фиолетовых тюльпанов,в корзинке",
                    SpecializationId = 1,
                    StatusId =2,
                },
                new TaskOutputModel()
                {
                    Id = 2,
                    OrderId = 2,
                    Title = "Живые цветы(фотозона)",
                    TimeStart= DateTime.ParseExact("2024-01-20 13:00", "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    TimeEnd= DateTime.ParseExact("2024-01-20 16:00", "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    Descriptions="Цветы:хризантема, роза,кипарис ",
                    SpecializationId = 1,
                    StatusId =3,
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
               Title = model.Title,
               OrderId= model.OrderId,
              TimeStart=model.TimeStart,
              TimeEnd=model.TimeEnd,
              Descriptions=model.Descriptions,
              SpecializationId = model.SpecializationId,
              StatusId = model.StatusId,
            };
        }
        public TaskOutputModel GetTaskById(int id)
        {
            return _task[id - 1];
        }
    }
}
