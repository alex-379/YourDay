using YourDay.DAL.Dtos;

namespace YourDay.DAL
{
    public class ProgramTest
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            var t = new UserDto() { UserName="Анна", Mail="asd@gmail.com", Phone="+9212975643", Password="1234", IsDeleted=false };
            //context.CatTypes.Add(t);


            //t.Name = "SuperSiamsky";
            context.SaveChanges();



            //var type = context.CatTypes.Where(a => a.Id == 1).Single();
            //context.Cats.Add(new CatDto() { Name = "Ivan", CostPerHour = 10, Type = type });
            //context.SaveChanges();
            //Console.WriteLine();



            //var type = context.CatTypes.Include(ct => ct.Cats).Where(a => a.Cats[0].Id == 3).Single();

            Console.WriteLine();
        }
    }
}
