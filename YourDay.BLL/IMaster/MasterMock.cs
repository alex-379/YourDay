using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
                    Name = "Букет роз",
                    WorkerName ="Мария",
                    Date = DateTime.Now,
                    Status = "В работе"
                },
                new TaskOutputModel()
                {
                    Id = 2,
                    Name = "Букет тюльпанов",
                    WorkerName ="Александр",
                    Date = DateTime.Now,
                    Status = "Завершено"
                },
                new TaskOutputModel()
                {
                    Id = 3,
                   Name = "Живые цветы (фотозона)",
                    WorkerName ="Александр",
                    Date = DateTime.Now,
                    Status = "В работе"
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
                Name = model.Name,
                WorkerName = model.WorkerName,
                Date = DateTime.Now,
                Status = model.Status,

            };
        }
    }
}
