using YourDay.DAL.Dtos;

namespace YourDay.DAL.IRepositories
{
    public interface ISpecializationRepository
    {
        public Task<SpecializationDto> AddSpecialization(SpecializationDto specialization);

        public Task<SpecializationDto> GetSpecializationById(int id);

        public Task<IEnumerable<SpecializationDto>> GetAllSpecialization();
    }
}