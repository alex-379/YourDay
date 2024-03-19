using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Repositories;
using YourDay.BLL.Mapping;

namespace YourDay.BLL.Clients
{
    public class TaskClient
    {
        private TaskRepository _taskRepository;
        private Mapper _mapper;

        public TaskClient()
        {
            _taskRepository = new TaskRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new TaskMappingProfile());
            });
            _mapper = new Mapper(config);
        }

        public List<TaskOutputModel> GetTaskByOrderId(int Id)
        {
            List<TaskDto> clientDtos = _taskRepository.GetTaskByOrderId(Id);

            var result = _mapper.Map<List<TaskOutputModel>>(clientDtos);

            return result;
        }
    }
}
