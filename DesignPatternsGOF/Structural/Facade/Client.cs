using DesignPatternsGOF.Structural.Facade.Zones;

namespace DesignPatternsGOF.Structural.Facade
{
    public class Client
    {
        public void Execute()
        {
            var north = new North();
            var south = new South();
            var cloud = new CloudComputing();

            var northSales = north.ExecuteSales(DateTime.Now);
            var southSales = south.ExecuteSales(DateTime.Now);

            cloud.GenerateSalesReport(northSales, southSales);
        }
    }
}
