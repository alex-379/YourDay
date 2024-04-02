using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class SpecializationRepository: ISpecializationRepository
    {
        public async Task<SpecializationDto> AddSpecialization(SpecializationDto specialization)
        {
            using (Context context = new Context())
            {
                context.Specializations.Add(specialization);
                await context.SaveChangesAsync();

                return specialization;
            }
        }
       
        public async Task<SpecializationDto> GetSpecializationById(int id)
        {
            using (Context context = new Context())
            {
                SpecializationDto specialization = await context.Specializations.AsQueryable().Where(s => s.Id == id).SingleAsync();

                return specialization;
            }
        }

        public async Task<IEnumerable<SpecializationDto>> GetAllSpecialization()
        {
            using (Context context = new Context())
            {
                var specialization = await context.Specializations.AsQueryable().ToListAsync();

                return specialization;
            }

        }
    }
}