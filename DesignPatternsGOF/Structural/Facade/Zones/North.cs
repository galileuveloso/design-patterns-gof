namespace DesignPatternsGOF.Structural.Facade.Zones
{
    public class North
    {
        public IList<object> ExecuteSales
        (
            DateTime date
        )
        {
            Console.WriteLine("[!] - Executing process zone North.");
            return new List<object>();
        }
    }
}
