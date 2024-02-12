namespace DesignPatternsGOF.Structural.Flyweight
{
    public class Client
    {
        private readonly List<string> colorSize =
        [
            "blue:small",
            "gray:avarage",
            "red:big",
            "blue:small",
            "gray:avarage",
            "red:big",
            "blue:small",
            "gray:avarage",
            "red:big"
        ];

        public void Execute()
        {
            var factory = new Factory();

            foreach (var item in colorSize)
            {
                var split = item.Split(":");

                var color = split[0];
                var size = split[1];

                var spaceship = factory.Get(color);

                spaceship.Show(color, size);
            }
        }
    }
}
