﻿using YourDay.DAL.Enums;

namespace YourDay.DAL.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public List<OrderDto>? Oders { get; set; }

        public Roles? Role { get; set; }

        public List<Specializations>? Specializations { get; set; }

        public string UserName { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public bool IsDeleted { get; set; }

        //public List<OrderDto>? ClientOrders { get; set; }

        //public List<OrderDto>? ManagerOrders { get; set; }

        public List<TaskDto>? WorkerTasks { get; set; }
    }
}
