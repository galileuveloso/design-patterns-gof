namespace DesignPatternsGOF.Structural.Aapter
{
    public class Business
    {
        public string GetBillsToPay(string month)
        {
            var data = Database.GetDataToPay(month);

            Console.WriteLine("Processing data...");

            return data;
        }

        public string GetBillsToReceive(string month)
        {
            var data = Database.GetDataToReceive(month);

            Console.WriteLine("Processing data...");

            return data;
        }
    }

    public class Database
    {
        public static string GetDataToPay
        (
            string month
        )
        {
            return new Dictionary<string, string>
            {
                { "January", "$1200.00 -> Prudente's Store - 19.089.591/0001-43" },
                { "February", "$1800.00 -> Silva's store - 14.895.945/0001-23" },
                { "March", "$1450.00 -> Veloso's store - 98.381.955/0001-30" },
                { "April", "$900.00 -> Frez's store - 97.255.765/0001-04" },
                { "May", "$1100.00 -> Bastos's store - 92.795.092/0001-61" }
            }[month];
        }

        public static string GetDataToReceive
        (
            string month
        )
        {
            return new Dictionary<string, string>
            {
                { "January", "$1000.00 -> Carl Johnsons - 762.697.390-98" },
                { "February", "$1840.00 -> Michael De Santa - 369.510.400-79" },
                { "March", "$1600.00 -> Franklin Clinton - 789.150.220-09" },
                { "April", "$1900.00 -> Trevor Philips - 603.743.720-39" },
                { "May", "$1400.00 -> Lamar Davis - 452.641.170-12" }
            }[month];
        }
    }
}
