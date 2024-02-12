using DesignPatternsGOF.Structural.Flyweight.Flyweights;
using DesignPatternsGOF.Structural.Flyweight.Models;

namespace DesignPatternsGOF.Structural.Flyweight
{
    public class Factory
    {
        private readonly Dictionary<string, Spaceship> list = [];

        public Spaceship Get(string color)
        {
            if (list.TryGetValue(color, out Spaceship? value))
                return value;

            value = color switch
            {
                "blue" => new Blue(),
                "gray" => new Gray(),
                "red" => new Red(),
                _ => throw new NotImplementedException()
            };

            list.Add(color, value);

            return value;
        }
    }
}
