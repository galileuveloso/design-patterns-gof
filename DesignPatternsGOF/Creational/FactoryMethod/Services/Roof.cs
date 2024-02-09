using DesignPatternsGOF.Creational.FactoryMethod.Interfaces;

namespace DesignPatternsGOF.Creational.FactoryMethod.Services
{
    public class Roof : IService
    {
        public Roof()
        {
            Console.WriteLine("Product Roof created.\n"); 
        }

        public void Charge()
        {
            //logic
        }
    }
}
