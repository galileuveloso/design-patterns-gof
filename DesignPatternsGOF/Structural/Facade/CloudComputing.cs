namespace DesignPatternsGOF.Structural.Facade
{
    public class CloudComputing
    {
        public void GenerateSalesReport
        (
            IList<object> north,
            IList<object> south
        )
        {
            Console.WriteLine("Reporting...");
        }
    }
}
