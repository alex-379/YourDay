using Microsoft.EntityFrameworkCore;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class SpecializationRepository: ISpecializationRepository
    {
        private readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public async Task<SpecializationDto> AddSpecialization(SpecializationDto specialization)
        {
            context.Specializations.Add(specialization);
            await context.SaveChangesAsync();

            return specialization;
        }

        public async Task<SpecializationDto> GetSpecializationById(int id)
        {
            SpecializationDto specialization = await context.Specializations.AsQueryable().Where(s => s.Id == id).SingleAsync();

            return specialization;
        }
    }
}