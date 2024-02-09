using DesignPatternsGOF.Creational.AbstractFactory.Factory.Interfaces;
using DesignPatternsGOF.Creational.AbstractFactory.Product.Products;

namespace DesignPatternsGOF.Creational.AbstractFactory.Factory.Factories
{
    internal class MondayThursdayFactory : IFactory
    {
        public MondayThursdayFactory()
        {
            GetRoutine();
        }

        public void GetRoutine()
        {
            Console.WriteLine("Monday Thursday Factory created.");

            _ = new DietMondayThursday();
            _ = new TrainingMondayThursday();
        }
    }
}
