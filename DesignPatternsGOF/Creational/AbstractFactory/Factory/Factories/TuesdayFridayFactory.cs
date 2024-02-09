using DesignPatternsGOF.Creational.AbstractFactory.Factory.Interfaces;
using DesignPatternsGOF.Creational.AbstractFactory.Product.Products;

namespace DesignPatternsGOF.Creational.AbstractFactory.Factory.Factories
{
    public class TuesdayFridayFactory : IFactory
    {
        public TuesdayFridayFactory()
        {
            GetRoutine();
        }

        public void GetRoutine()
        {
            Console.WriteLine("Tuesday Friday Factory created.");

            _ = new DietTuesdayFriday();
            _ = new TrainingTuesdayFriday();
        }
    }
}
