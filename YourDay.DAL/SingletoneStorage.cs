using Microsoft.Extensions.Options;

namespace YourDay.DAL
{
    public class SingletoneStorage
    {
        private static SingletoneStorage _object = null;

        public Context context { get; private set; }

        private SingletoneStorage()
        {
            context = new Context();
        }

        public static SingletoneStorage GetStorage()
        {
            if (_object is null)
            {
                _object = new SingletoneStorage();
            }
            return _object;
        }
    }
}
