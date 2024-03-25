using AutoMapper;
using YourDay.BLL.Clients;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.DAL.Dtos;

namespace YourDay.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationInputModel, UserDto>();

            CreateMap<UserDto, UserOutputModel>();

            CreateMap<UserDto, UserMailOutputModel>();

            CreateMap<UserDto, UserAuthorizationOutputModel>();





            CreateMap<OrderForManagerInputModel, OrderDto>();

            CreateMap<OrderDto, OrderOutputModel>();

            CreateMap<OrderDto, OrderNameDateOutputModel>()
                .ForMember(d => d.Date, opt => opt.MapFrom(s => OrderService.GetDateStringForOrder(s.Date)));



            CreateMap<TaskInputModel, TaskDto>();

            CreateMap<TaskDto, TaskOutputModel>();

            CreateMap<TaskDto, TaskInOrderOutputModel>();

            CreateMap<TaskOutputModel, TaskInputModel>();




        }
    }
}