using DesignPatternsGOF.Creational.AbstractFactory.Product.Interfaces;

namespace DesignPatternsGOF.Creational.AbstractFactory.Product.Products
{
    public class TrainingTuesdayFriday : ITraining
    {
        public TrainingTuesdayFriday()
        {
            GetTraining();
        }

        public void GetTraining()
        {
            Console.WriteLine("Tuesday and Friday training...");
        }
    }
}
