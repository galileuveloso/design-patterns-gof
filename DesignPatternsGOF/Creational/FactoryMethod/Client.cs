using DesignPatternsGOF.Creational.FactoryMethod.Enums;

namespace DesignPatternsGOF.Creational.FactoryMethod
{
    public class Client
    {
        public void Execute()
        {
            var client = new Product();

            while (true)
            {
                Console.WriteLine("Select the service type: \n");
                Console.WriteLine("1 - Traditional");
                Console.WriteLine("2 - Premium");
                Console.WriteLine("3 - Master");
                Console.WriteLine("4 - Roof");
                Console.WriteLine("0 - Exit");

                Console.Write("Service: ");

                var serviceType = (ServiceType)Convert.ToInt32(Console.ReadLine());

                if (serviceType.Equals(ServiceType.None))
                    return;

                var product = client.FactoryProduct(serviceType);

                if (product is null)
                    Console.WriteLine("Not Found.\n");
            };
        }
    }
}
