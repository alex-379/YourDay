using AutoMapper;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
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
            CreateMap<UserRegistrationInputModel, UserDto>();

            CreateMap<UserDto, UserOutputModel>();

            CreateMap<OrderForManagerInputModel, OrderDto>();

            CreateMap<OrderDto, OrderOutputModel>();

            CreateMap<OrderDto, OrderInputModel>();

            CreateMap<OrderInputModel, OrderDto>();

            CreateMap<OrderDto, OrderNameDateOutputModel>()
                .ForMember(d => d.Date, opt => opt.MapFrom(s => $"{s.Date.ToShortDateString()}"));

            CreateMap<TaskDto, TaskOutputModel>();

            CreateMap<UserDto, UserSpecializationOutputModel>();

            CreateMap<UserDto, WorkerRegistrationInputModel>();

            CreateMap<SpecializationDto, SpecializationOutputModel>();

            CreateMap<SpecializationIntputModel, SpecializationDto>();

            CreateMap<TaskInputModel, TaskDto>();

            CreateMap<UserDto, UserRegistrationInputModel>();

            CreateMap<UserDto, UserInputModel>();

            CreateMap<UserInputModel, UserDto>();

            CreateMap<TaskInputModel, TaskDto>();

        }
    }
}
