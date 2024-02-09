using DesignPatternsGOF.Creational.FactoryMethod.Interfaces;

namespace DesignPatternsGOF.Creational.FactoryMethod.Services
{
    public class Traditional : IService
    {
        public Traditional()
        {
            Console.WriteLine("Product Traditional created.");
        }

        public void Charge()
        {
            //logic
        }
    }
}
