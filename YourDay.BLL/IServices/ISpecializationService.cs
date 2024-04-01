using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;

namespace YourDay.BLL.IServices
{
    public interface ISpecializationService
    {
        public SpecializationOnlyNameOutputModel AddSpecialization(SpecializationInputModel specialization);

        public SpecializationTaskInputModel GetSpecializationById(int id);

        public IEnumerable<SpecializationIdNameOutputModel> GetAllSpecialization();
    }
}