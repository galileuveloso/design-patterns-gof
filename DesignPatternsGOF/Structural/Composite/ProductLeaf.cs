using DesignPatternsGOF.Structural.Composite.Models;

namespace DesignPatternsGOF.Structural.Composite
{
    public class ProductLeaf(string name, double value) : Component
    {
        private readonly string _name = name;
        private readonly double _value = value;

        public override void Add(params Component[] components)
        {
            Console.WriteLine("This is a leaf and you cant do it.");
        }

        public override Component? GetChild(int index)
        {
            Console.WriteLine("This is a leaf and you cant do it.");
            return null;
        }

        public override double Operation()
        {
            Console.WriteLine($"Procuct: {_name}\n Value: {_value:C}");
            Console.WriteLine(new String('-', 40));
            return _value;
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("This is a leaf and you cant do it.");
        }
    }
}
