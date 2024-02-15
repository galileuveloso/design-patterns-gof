namespace DesignPatternsGOF.Structural.Facade.Zones
{
    public class South
    {
        public IList<object> ExecuteSales
        (
            DateTime date
        )
        {
            Console.WriteLine("[!] - Executing process zone South.");
            return new List<object>();
        }
    }
}
