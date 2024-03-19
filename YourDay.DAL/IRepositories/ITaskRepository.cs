using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface ITaskRepository
    {
        public void UpdateTaskStatus(TaskStatusDto taskStatus);
    }
}
