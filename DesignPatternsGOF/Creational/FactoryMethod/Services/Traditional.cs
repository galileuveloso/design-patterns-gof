using DesignPatternsGOF.Creational.FactoryMethod.Interfaces;

namespace DesignPatternsGOF.Creational.FactoryMethod.Services
{
    public class Traditional : IService
    {
        public Traditional()
        {
            Console.WriteLine("Product Traditional created. \n");
        }

        public void Charge()
        {
            //logic
        }
    }
}
