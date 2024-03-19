namespace YourDay.DAL
{
    public class Options
    {
        public static string connectionString
        {
            get
            {
                return "Data Source=.;Initial Catalog=YourDay; User ID ='test'; Password='test'; TrustServerCertificate=true";
            }
        }
    }
}