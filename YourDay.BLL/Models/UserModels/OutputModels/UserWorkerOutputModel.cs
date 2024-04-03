using System.ComponentModel.DataAnnotations;
using YourDay.BLL.Models.SpecializationModels.OutputModels;
using YourDay.DAL.Dtos;
using YourDay.DAL.Enums;
namespace YourDay.BLL.Models.UserModels.OutputModels
{
    public class UserWorkerOutputModel
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string Mail { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }


        public bool? IsDeleted { get; set; }

        public Role Role { get; set; }

        //public IEnumerable<SpecializationOutputModel>? Specializations { get; set; }

        //public IEnumerable<OrderDto>? Orders { get; set; }

        //public IEnumerable<TaskDto>? WorkerTasks { get; set; }

        //public UserProfilesPictureDto Picture { get; set; }
    }
}