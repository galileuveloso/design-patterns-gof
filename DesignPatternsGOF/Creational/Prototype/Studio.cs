namespace DesignPatternsGOF.Creational.Prototype
{
    public class Studio(string type, string financing, decimal value) : StudioModel
    {
        private readonly string _type = type;
        private readonly string _financing = financing;
        private readonly decimal _value = value;

        public override StudioModel Clone()
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Studio: " + _type);
            Console.WriteLine("Financing: " + _financing);
            Console.WriteLine("Value: " + _value.ToString("C"));
            return (StudioModel)MemberwiseClone();
        }
    }
}
