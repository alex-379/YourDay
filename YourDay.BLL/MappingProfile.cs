using AutoMapper;
using YourDay.BLL.Enums;
using YourDay.BLL.Models.CompanyModels.OutputModels;
using YourDay.BLL.Models.HistoryModels.OutputModels;
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

            CreateMap<UserRegistrationForManagerInputModel, UserDto>();

            CreateMap<UserDto, UserOutputModel>();

            CreateMap<UserDto, UserMailOutputModel>();

            CreateMap<UserDto, UserSpecializationOutputModel>();

            CreateMap<UserDto, UserAuthorizationOutputModel>();

            CreateMap<UserDto, ManagerNameAndPhoneOutputModel>()
                .ForMember(outputModel => outputModel.Name, name => name.MapFrom(userDto => userDto.UserName));

            CreateMap<OrderForManagerInputModel, OrderDto>();

            CreateMap<OrderDto, OrderOutputModel>();

            CreateMap<OrderDto, OrderNameDateOutputModel>()
                .ForMember<string>(outputModel => outputModel.Date, date => date.MapFrom(orderDto => orderDto.Date != null ? orderDto.Date.Value.ToString("yyyy-MM-dd") : null));

            CreateMap<OrderInputModel, OrderDto>();

            CreateMap<ApplicationInputModel, HistoryDto>();

            CreateMap<OrderDto, ApplicationOutputModel>();

            CreateMap<HistoryDto, HistoryOutputModel>();

            CreateMap<TaskInputModel, TaskDto>();

            CreateMap<TaskDto, TaskInputModel>();

            CreateMap<TaskUpdateInputModelAllInfo, TaskDto>();

            CreateMap<TaskOutputModelAllInfo, TaskDto>();

            CreateMap<TaskDto, TaskOutputModelAllInfo>();

            CreateMap<TaskDto, TaskOutputModelWithOrderWithSpecialization>();

            CreateMap<TaskDto, TaskOutputModelWithSpecialization>();

            CreateMap<SpecializationInputModel, SpecializationDto>();

            CreateMap<SpecializationTaskInputModel, SpecializationDto>();

            CreateMap<SpecializationDto, SpecializationTaskInputModel>();

            CreateMap<SpecializationDto, SpecializationOutputModel>();

            CreateMap<SpecializationOutputModel, SpecializationDto>();

            CreateMap<TaskDto, CompanyStatisticOutputModel>()
                .ForMember(outputModel => outputModel.ManagerName, taskdto => taskdto.MapFrom(task => task.Order.Manager.UserName))
                .ForMember(outputModel => outputModel.ManagerId, taskdto => taskdto.MapFrom(task => task.Order.Manager.Id))
                .ForMember(outputModel => outputModel.TaskId, taskdto => taskdto.MapFrom(task => task.Id))
                .ForMember(outputModel => outputModel.TaskTitle, taskDto => taskDto.MapFrom(task => task.Title))
                .ForMember(outputModel => outputModel.OrderId, taskDto => taskDto.MapFrom(task => task.Order.Id))
                .ForMember(outputModel => outputModel.OrderTitle, taskDto => taskDto.MapFrom(task => task.Order.OrderName))
                .ForMember(outputModel => outputModel.ClientId, taskDto => taskDto.MapFrom(task => task.Order.Client.Id))
                .ForMember(outputModel => outputModel.ClientId, taskDto => taskDto.MapFrom(task => task.Order.Client.UserName));

            CreateMap<SpecializationDto, SpecializationOutputModel>();
        }
    }
}