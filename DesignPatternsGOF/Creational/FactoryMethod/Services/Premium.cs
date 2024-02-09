using DesignPatternsGOF.Creational.FactoryMethod.Interfaces;

namespace DesignPatternsGOF.Creational.FactoryMethod.Services
{
    public class Premium : IService
    {
        public Premium()
        {
            Console.WriteLine("Product Premium created.\n");
        }

        public void Charge()
        {
            //logic
        }
    }
}
