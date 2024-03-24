using AutoMapper;
using YourDay.BLL.Clients;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.BLL.Models.UserModels.InputModels;
using YourDay.BLL.Models.UserModels.OutputModels;
using YourDay.BLL.Service;
using YourDay.DAL.Dtos;

namespace YourDay.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationInputModel, UserDto>();
                                //.ForMember(d => d.Salt, opt => opt.MapFrom(s => UserService.GetSaltHash(s.Password)[0]));
                                ////.ForMember(d => d.Hash, opt => opt.MapFrom(s => UserService.GetSaltHash(s.Password)[1]));

            CreateMap<UserDto, UserOutputModel>();

            CreateMap<UserDto, UserMailOutputModel>();

            CreateMap<UserDto, UserAuthorizationOutputModel>();

            CreateMap<OrderForManagerInputModel, OrderDto>();

            CreateMap<OrderDto, OrderOutputModel>();

            CreateMap<OrderDto, OrderNameDateOutputModel>()
                .ForMember(d => d.Date, opt => opt.MapFrom(s => OrderService.GetDateStringForOrder(s.Date)));

            CreateMap<TaskDto, TaskOutputModel>();
        }
    }
}