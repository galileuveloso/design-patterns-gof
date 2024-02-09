using DesignPatternsGOF.Creational.AbstractFactory.Factory.Interfaces;
using DesignPatternsGOF.Creational.AbstractFactory.Product.Products;

namespace DesignPatternsGOF.Creational.AbstractFactory.Factory.Factories
{
    public class WednesdaySaturdayFactory : IFactory
    {
        public WednesdaySaturdayFactory()
        {
            GetRoutine();
        }

        public void GetRoutine()
        {
            Console.WriteLine("Wednesday Saturday Factory created.");

            _ = new DietWednesdaySaturday();
            _ = new TrainingWednesdaySaturday();
        }
    }
}
