using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IWorkerRepository
    {
        public List<UserDto> GetAllWorkers(Role Worker);

        public List<UserDto> GetWorkerById(int id);

        public List<TaskDto> GetTaskByWorkerId(int id);
    }
}