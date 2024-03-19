namespace YourDay.DAL
{
    public class Options
    {
        public static string connectionString
        {
            get
            {
                return Environment.GetEnvironmentVariable("YourDayDB"); ;
            }
        }
    }
}