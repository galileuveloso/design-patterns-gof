namespace DesignPatternsGOF.Creational.Singleton
{
    public class Context
    {
        private Context()
        {
            Console.WriteLine("Instance created.");
        }

        private static Context? _instance;

        public static Context Instance
        {
            get
            {
                _instance ??= new Context();
                return _instance;
            }
        }

        public void Query(string sql)
        {
            Console.WriteLine("Query: " + sql);
        }
    }
}
