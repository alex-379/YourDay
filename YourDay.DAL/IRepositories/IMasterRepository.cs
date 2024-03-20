using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;

namespace YourDay.DAL.IRepositories
{
    public interface IMasterRepository
    {
        public List<UserDto> GetAllMasters(Role master);
        public List<UserDto> GetMasterById(int id);
        public List<TaskDto> GetTaskByMasterId(int id);
    }
}
