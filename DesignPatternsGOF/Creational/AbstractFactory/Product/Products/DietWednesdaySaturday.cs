using DesignPatternsGOF.Creational.AbstractFactory.Product.Interfaces;

namespace DesignPatternsGOF.Creational.AbstractFactory.Product.Products
{
    public class DietWednesdaySaturday : IDiet
    {
        public DietWednesdaySaturday()
        {
            GetFood();    
        }

        public void GetFood()
        {
            Console.WriteLine("Widnesday and Saturday diet...");
        }
    }
}
