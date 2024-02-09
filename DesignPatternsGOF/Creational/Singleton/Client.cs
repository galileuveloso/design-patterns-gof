namespace DesignPatternsGOF.Creational.Singleton
{
    public class Client
    {
        public void Execute()
        {
            var instance = Context.Instance;
            instance.Query("Select 1 from dual");

            var instance2 = Context.Instance;
            instance.Query("Select 2 from dual");

            bool same = instance.Equals(instance2);

            Console.WriteLine("Some isntace: " + same);
        }
    }
}
