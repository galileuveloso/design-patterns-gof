using DesignPatternsGOF.Creational.AbstractFactory.Product.Interfaces;

namespace DesignPatternsGOF.Creational.AbstractFactory.Product.Products
{
    public class TrainingMondayThursday : ITraining
    {
        public TrainingMondayThursday()
        {
            GetTraining();
        }

        public void GetTraining()
        {
            Console.WriteLine("Monday and Thursday training...");
        }
    }
}
