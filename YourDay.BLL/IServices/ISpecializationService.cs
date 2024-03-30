using YourDay.BLL.Models.SpecializationModels.InputModels;
using YourDay.BLL.Models.SpecializationModels.OutputModels;

namespace YourDay.BLL.IServices
{
    public interface ISpecializationService
    {
        public SpecializationOnlyNameOutputModel AddSpecialization(SpecializationInputModel specialization);
    }
}