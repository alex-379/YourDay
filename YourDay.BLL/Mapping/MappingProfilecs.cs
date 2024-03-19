using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Mapping
{
    public class MappingProfilecs : Profile
    {
        public MappingProfilecs() 
        {
            CreateMap<OrderDto, OrderOutputModel>();

            CreateMap<TaskDto, TaskOutputModel>();
        }
    }
}
