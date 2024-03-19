using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    internal interface IMasterRepository
    {
        public List<TaskDto> GetAllTasks();
    }
}
