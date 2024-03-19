using AutoMapper;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Mapping
{
    public class TaskMappingProfile : Profile
    {
        public TaskMappingProfile()
        {
            CreateMap<TaskDto, TaskOutputModel>();
        }
    }
}
