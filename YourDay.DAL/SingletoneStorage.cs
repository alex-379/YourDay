namespace YourDay.DAL
{
    public class SingletoneStorage
    {
        private static SingletoneStorage _object = null;

        public Context Сontext { get; private set; }

        private SingletoneStorage()
        {
            Сontext = new Context();
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