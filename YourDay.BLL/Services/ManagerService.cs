using AutoMapper;
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
            _orderRepository.UpdateOrder(order);
        }

        public async Task<OrderOutputModel> AddTaskManager(TaskDto task, int orderId)
        {
            context.Tasks.Add(task);
            task.Order = orderRepository.GetOrderById(orderId);
            context.SaveChanges();
        }

        public async Task<TaskOutputModelWithOrderWithSpecialization> AddTaskManager(TaskInputModel task, int orderId)
        {
            var a = _taskRepository.AddTaskManager(_mapper.Map<TaskDto>(task), orderId);
        }

        public TaskOutputModelAllInfo AddWorkerForTask(int taskId, int workerId)
        {
            TaskDto taskDto = _taskRepository.GetTaskByIdWithAll(taskId);
            UserDto userDtoInput = _userRepository.GetUserById(workerId);

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

            TaskDto taskDtoOutput = _taskRepository.UpdateTask(taskDto);
            TaskOutputModelAllInfo taskOutput = _mapper.Map<TaskOutputModelAllInfo>(taskDtoOutput);

            return taskOutput;
        }

        public void AddApplication(ApplicationInputModel application, string userMail)
        {
            HistoryDto historyDtoInput = _mapper.Map<HistoryDto>(application);
            historyDtoInput.DateTime = DateTime.Now;
            OrderDto orderDtoInput = new OrderDto();
            orderDtoInput.Histories = new List<HistoryDto>()
            {
            historyDtoInput
            };
            orderDtoInput.Client = _userRepository.GetUserByMail(userMail);
            _orderRepository.AddOrder(orderDtoInput);
        }

        public List<CompanyStatisticOutputModel> GetAllTaskOfOrderOfTheirManager()
        {
            List<TaskDto> tasks = _statisticsRepository.GetAllTaskOfOrderOfTheirManager();
            List<CompanyStatisticOutputModel> result = _mapper.Map<List<CompanyStatisticOutputModel>>(tasks);
            return result;
        }

    }
}