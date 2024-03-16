using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public bool IsDeleted { get; set; }

        public Role? Role { get; set; }

        public IEnumerable<Specialization>? Specializations { get; set; }

        public IEnumerable<OrderDto>? Orders { get; set; }

        public IEnumerable<TaskDto>? WorkerTasks { get; set; }
    }
}
