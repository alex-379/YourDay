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




            Console.WriteLine();
        }
    }
}
