using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YourDay.DAL
{
    public class Options
    {
        public static string connectionString
        {
            get
            {
                return "Server=.;Database=Cats; User=SA; Trusted_Connection=True; TrustServerCertificate=true";
            }
        }
    }
}