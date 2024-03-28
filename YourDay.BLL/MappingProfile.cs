using AutoMapper;
using YourDay.BLL.Services;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.OutputModels;
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

            CreateMap<UserDto, ManagerNameAndPhoneOutputModel>()
                .ForMember(outputModel => outputModel.Name, name => name.MapFrom(userDto => userDto.UserName))
                .ForMember(outputModel => outputModel.Phone, phone => phone.MapFrom(userDto => userDto.Phone));

            CreateMap<OrderForManagerInputModel, OrderDto>();

            CreateMap<OrderDto, OrderOutputModel>();

            CreateMap<OrderDto, OrderNameDateOutputModel>()
                .ForMember(d => d.Date, opt => opt.MapFrom(s => OrderService.GetDateStringForOrder(s.Date)));

            CreateMap<TaskInputModel, TaskDto>();

            CreateMap<TaskUpdateInputModelAllInfo, TaskDto>();

            CreateMap<TaskDto, TaskOutputModelWithOrderWithSpecialization>();

            CreateMap<TaskDto, TaskOutputModelAllInfo>();

            CreateMap<TaskDto, TaskOutputModelWithSpecialization>();

            CreateMap<TaskDto, TaskOutputModel>();

            CreateMap<SpecializationInputModel, SpecializationDto>();

            CreateMap<SpecializationDto, SpecializationOutputModel>();

            CreateMap<CompanyStatisticOutputModel, TaskDto>()
                .ForMember(taskDto => taskDto.Description, taskTitle => taskTitle.MapFrom(outputModel => outputModel.TitleTask))
                .ForMember(taskDto => taskDto.Workers, nameManager => nameManager.MapFrom(outputModel => outputModel.NameManager))
                .ForMember(taskDto => taskDto.Order, orderTitle => orderTitle.MapFrom(outputModel => outputModel.TitleOrder));
        }
    }
}