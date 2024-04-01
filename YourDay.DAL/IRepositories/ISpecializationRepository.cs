using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface ISpecializationRepository
    {
        public SpecializationDto AddSpecialization(SpecializationDto specialization);

        public SpecializationDto GetSpecializationById(int id);

        public IEnumerable<SpecializationDto> GetAllSpecialization();


    }
}