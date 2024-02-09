using DesignPatternsGOF.Creational.AbstractFactory.Product.Interfaces;

namespace DesignPatternsGOF.Creational.AbstractFactory.Product.Products
{
    public class DietTuesdayFriday : IDiet
    {
        public DietTuesdayFriday()
        {
            GetFood();    
        }

        public void GetFood()
        {
            Console.WriteLine("Tuesday and Friday diet...");
        }
    }
}
