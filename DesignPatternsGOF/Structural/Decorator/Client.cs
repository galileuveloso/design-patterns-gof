using DesignPatternsGOF.Structural.Decorator.Decorators;
using DesignPatternsGOF.Structural.Decorator.Interfaces;
using DesignPatternsGOF.Structural.Decorator.Services;

namespace DesignPatternsGOF.Structural.Decorator
{
    public class Client
    {
        public void Execute()
        {
            IPet bath = new Bath("Bath", 45.00);

            IPet acessory = new AcessoryDecorator(bath);

            IPet spa = new SpaDecorator(acessory);

            Console.WriteLine("Resume:");

            Console.WriteLine(spa.GetName());
            Console.WriteLine(spa.GetValue());
        }
    }
}
