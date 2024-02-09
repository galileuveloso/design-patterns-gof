using DesignPatternsGOF.Creational.AbstractFactory.Product.Interfaces;

namespace DesignPatternsGOF.Creational.AbstractFactory.Product.Products
{
    public class TrainingWednesdaySaturday : ITraining
    {
        public TrainingWednesdaySaturday()
        {
            GetTraining();        
        }

        public void GetTraining()
        {
            Console.WriteLine("Wednesday and Satyrday training...");
        }
    }
}
