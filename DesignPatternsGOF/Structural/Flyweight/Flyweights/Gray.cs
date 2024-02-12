using DesignPatternsGOF.Structural.Flyweight.Models;

namespace DesignPatternsGOF.Structural.Flyweight.Flyweights
{
    public class Gray : Spaceship
    {
        public Gray()
        {
            _state = "flying";
            _action = "shooting laser";
        }

        public override void Show
        (
            string color,
            string size
        )
        {
            Color = color;
            Size = size;

            Console.WriteLine($"Nave {Size} and color {Color} {_state} {_action}");
        }
    }
}
