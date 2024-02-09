using DesignPatternsGOF.Creational.AbstractFactory.Product.Interfaces;

namespace DesignPatternsGOF.Creational.AbstractFactory.Product.Products
{
    public class DietMondayThursday : IDiet
    {
        public DietMondayThursday()
        {
            GetFood();
        }

        public void GetFood()
        {
            Console.WriteLine("Monday and Thursday diet...");
        }
    }
}
