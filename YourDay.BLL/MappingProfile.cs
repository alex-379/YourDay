using AutoMapper;
using YourDay.BLL.IServices;
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
using YourDay.BLL.Services;
using YourDay.DAL.Dtos;

namespace YourDay.BLL
{
    public class MappingProfile : Profile
    {
        private IOrderService _orderService;
        public MappingProfile()
        {
            _orderService = new OrderService();

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
                .ForMember(d => d.Date, opt => opt.MapFrom(s => _orderService.GetDateStringForOrder(s.Date)));

            CreateMap<OrderInputModel, OrderDto>();

            CreateMap<ApplicationInputModel, HistoryDto>();

            CreateMap<OrderDto, ApplicationOutputModel>();

            CreateMap<HistoryDto, HistoryOutputModel>();

            CreateMap<TaskInputModel, TaskDto>();

            CreateMap<TaskUpdateInputModelAllInfo, TaskDto>();

            CreateMap<TaskDto, TaskOutputModelWithOrderWithSpecialization>();

            CreateMap<TaskDto, TaskOutputModelAllInfo>();

            CreateMap<TaskDto, TaskOutputModelWithSpecialization>();

            CreateMap<TaskDto, TaskOutputModel>();

            CreateMap<TaskDto, CompanyStatisticOutputModel>()
                .ForMember(outputModel => outputModel.NameManager, taskdto => taskdto.MapFrom(task => task.Order.Manager.UserName))
                .ForMember(outputModel => outputModel.IdManager, taskdto => taskdto.MapFrom(task => task.Order.Manager.Id))
                .ForMember(outputModel => outputModel.IdTask, taskdto => taskdto.MapFrom(task => task.Id))
                .ForMember(outputModel => outputModel.TitleTask, taskDto => taskDto.MapFrom(task => task.Title))
                .ForMember(outputModel => outputModel.IdOrder, taskDto => taskDto.MapFrom(order => order.Order.Id))
                .ForMember(outputModel => outputModel.TitleOrder, taskDto => taskDto.MapFrom(order => order.Order.OrderName));

            CreateMap<SpecializationInputModel, SpecializationDto>();

            CreateMap<SpecializationDto, SpecializationOnlyNameOutputModel>();
        }
    }
}