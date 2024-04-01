using YourDay.DAL.Dtos;
using YourDay.DAL.IRepositories;

namespace YourDay.DAL.Repositories
{
    public class SpecializationRepository: ISpecializationRepository
    {
        readonly Context context = SingletoneStorage.GetStorage().Сontext;

        public SpecializationDto AddSpecialization(SpecializationDto specialization)
        {
            context.Specializations.Add(specialization);
            context.SaveChanges();

            return specialization;
        }

        public SpecializationDto GetSpecializationById(int id)
        {
            SpecializationDto specialization = context.Specializations.Where(s => s.Id == id).Single();

            return specialization;
        }

        public IEnumerable<SpecializationDto> GetAllSpecialization()
        {
            IEnumerable<SpecializationDto> specialization = context.Specializations;

            return specialization;
        }
    }
}