using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.OutputModels;
using YourDay.BLL.Models.TaskModels.InputModels;

namespace YourDay.BLL.IServices
{
    public interface ISpecializationService
    {
        public Task<SpecializationOnlyNameOutputModel> AddSpecialization(SpecializationInputModel specialization);

        public Task<SpecializationTaskInputModel> GetSpecializationById(int id);


        public Task<IEnumerable<SpecializationIdNameOutputModel>> GetAllSpecialization();
    }
}