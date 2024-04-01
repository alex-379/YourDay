using AutoMapper;
using System.Threading.Tasks;
using YourDay.BLL.IServices;
using YourDay.BLL.Models.CompanyModels.OutputModels;
using YourDay.BLL.Models.ManagerModels.OutputModel;
using YourDay.BLL.Models.OrderModels.InputModels;
using YourDay.BLL.Models.OrderModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;
using YourDay.BLL.Models.TaskModels.OutputModels;
using YourDay.DAL;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
using YourDay.DAL.IRepositories;
using YourDay.DAL.Repositories;

namespace YourDay.BLL.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IUserRepository _userRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly Mapper _mapper;

        public ManagerService()
        {
            _userRepository = new UserRepository();
            _orderRepository = new OrderRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public async Task<IEnumerable<ManagerNameAndPhoneOutputModel>> GetAllManagers()
        {
            var usersDtoManager = await _userRepository.GetAllUsersByRole(Role.Manager);
            var managers = _mapper.Map<IEnumerable<ManagerNameAndPhoneOutputModel>>(usersDtoManager);

            return managers;
        }

        public async Task<OrderOutputModel> AddManagerIdToOrder(int managerId, int orderId)
        {
            UserDto manager = await _userRepository.GetUserById(managerId);
            OrderDto order = await _orderRepository.GetOrderById(orderId);
            order.Manager = manager;
            OrderDto orderDtoInput = await _orderRepository.UpdateOrder(order);
            OrderOutputModel orderOutput = _mapper.Map<OrderOutputModel>(orderDtoInput);

            return orderOutput;
        }

        public async Task<OrderOutputModel> AddTaskManager(TaskInputModel task, int orderId)
        {
            OrderDto order = await _orderRepository.GetOrderById(orderId);
            TaskDto taskDtoInput = _mapper.Map<TaskDto>(task);

            if (order.Tasks == null)
            {
                order.Tasks = new List<TaskDto>() { taskDtoInput };
            }
            else
            {
                List<TaskDto> Tasks = order.Tasks.ToList();
                Tasks.Add(taskDtoInput);
                order.Tasks = Tasks;
            }

            OrderDto orderDtoInput = await _orderRepository.UpdateOrder(order);
            OrderOutputModel orderOutput = _mapper.Map<OrderOutputModel>(orderDtoInput);

            return orderOutput;
        }

        public async Task<TaskOutputModelAllInfo> AddWorkerForTask(int taskId, int workerId)
        {
            TaskDto taskDto = await _taskRepository.GetTaskByIdWithAll(taskId);
            UserDto userDtoInput = await _userRepository.GetUserById(workerId);

            if (taskDto.Workers == null)
            {
                taskDto.Workers = new List<UserDto>() { userDtoInput };
            }
            else
            {
                List<UserDto> Workers = taskDto.Workers.ToList();
                Workers.Add(userDtoInput);
                taskDto.Workers = Workers;
            }

            TaskDto taskDtoOutput = await _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }

        public async Task<ApplicationOutputModel> AddApplication(ApplicationInputModel application, string userMail)
        {
            HistoryDto historyDtoInput = _mapper.Map<HistoryDto>(application);
            historyDtoInput.DateTime = DateTime.Now;
            OrderDto orderDtoInput = new OrderDto();
            orderDtoInput.Histories = new List<HistoryDto>()
            {
            historyDtoInput
            };
            orderDtoInput.Client = await _userRepository.GetUserByMail(userMail);
            OrderDto orderDtoOutput = await _orderRepository.AddOrder(orderDtoInput);
            ApplicationOutputModel applicationOutput = _mapper.Map<ApplicationOutputModel>(orderDtoOutput);

            return applicationOutput;
        }

        public async Task<IEnumerable<CompanyStatisticOutputModel>> GetAllTaskOfOrderOfTheirManager()
        {
            var tasks = await _taskRepository.GetAllTaskOfOrderOfTheirManager();
            var statistics = _mapper.Map<List<CompanyStatisticOutputModel>>(tasks);
            return statistics;
        }
    }
}