using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface ISpecializationRepository
    {
        public Task<SpecializationDto> AddSpecialization(SpecializationDto specialization);

        public SpecializationDto GetSpecializationById(int id);

        public IEnumerable<SpecializationDto> GetAllSpecialization();


        public Task<SpecializationDto> GetSpecializationById(int id);
    }
}