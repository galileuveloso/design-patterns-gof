namespace DesignPatternsGOF.Structural.Flyweight.Models
{
    public abstract class Spaceship
    {
        protected string _state;
        protected string _action;

        public string Color { get; set; }
        public string Size { get; set; }

        public abstract void Show
        (
            string color,
            string size
        );
    }
}
