using AutoMapper;
using System.Text;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationInputModel, UserDto>()
                           .ForMember(u => u.Password, opt => opt.MapFrom(u => Encoding.ASCII.GetBytes(u.Password)));

            CreateMap<UserDto, UserOutputModel>();

            CreateMap<OrderForManagerInputModel, OrderDto>();

            CreateMap<OrderDto, OrderOutputModel>();

            CreateMap<OrderDto, OrderNameDateOutputModel>()
                .ForMember(d => d.Date, opt => opt.MapFrom(s => $"{s.Date.ToShortDateString()}"));

            CreateMap<TaskDto, TaskOutputModel>();
        }
    }
}