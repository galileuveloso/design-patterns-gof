using DesignPatternsGOF.Structural.Bridge.Abstraction;
using DesignPatternsGOF.Structural.Bridge.Abstraction.Interfaces;
using DesignPatternsGOF.Structural.Bridge.Implementation;

namespace DesignPatternsGOF.Structural.Bridge
{
    public class Client
    {
        public void Execute()
        {
            IMaterial material;
            var random = new Random();

            while (true)
            {
                material = random.Next(2).Equals(1) ? new Pencil() : new Brush();

                material
                    .ColorImplementation = random.Next(3) switch
                    {
                        0 => new Blue(),
                        1 => new Red(),
                        2 => new Black(),
                        _ => throw new NotImplementedException()
                    };

                Console.WriteLine(material.Query());

                Console.WriteLine("Press any to continue or <Esc> to exit.");

                if (Console.ReadKey().Key.Equals(ConsoleKey.Escape))
                    break;
            }
        }
    }
}
