using DesignPatternsGOF.Creational.AbstractFactory.Factory.Factories;
using DesignPatternsGOF.Creational.AbstractFactory.Factory.Interfaces;
using DesignPatternsGOF.Creational.FactoryMethod;

namespace DesignPatternsGOF.Creational.AbstractFactory
{
    public class Client
    {
        public void Execute()
        {
            while (true)
            {
                Console.WriteLine("Select the routine:");
                Console.WriteLine("1 - Monday and Thursday");
                Console.WriteLine("2 - Tuesday and Friday");
                Console.WriteLine("3 - Wednesday and Saturday");
                Console.WriteLine("0 - Exit");

                Console.WriteLine("Routine: ");

                var routine = Console.ReadLine();

                if (String.IsNullOrEmpty(routine) || routine.Equals("0"))
                    return;

                IFactory? factory = Factory(routine);

                if (factory is null)
                    Console.WriteLine("Not Found.\n");
            }
        }

        private static IFactory? Factory
        (
            string routine
        )
        {
            return routine switch
            {
                "1" => new MondayThursdayFactory(),
                "2" => new TuesdayFridayFactory(),
                "3" => new WednesdaySaturdayFactory(),
                _ => null,
            };
        }
    }
}
