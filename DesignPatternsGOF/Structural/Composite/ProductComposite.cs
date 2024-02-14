using DesignPatternsGOF.Structural.Composite.Models;

namespace DesignPatternsGOF.Structural.Composite
{
    public class ProductComposite : Component
    {
        private readonly List<Component> _components = [];

        public override void Add(params Component[] components)
        {
            _components.AddRange(components);
        }

        public override Component? GetChild(int index)
        {
            if (_components.Count.Equals(0))
            {
                Console.WriteLine("No products registered.");
                return null;
            }

            return _components[index];
        }

        public override double Operation()
        {
            double value = 0;

            for (int i = 0; i < _components.Count; i++)
            {
                var component = _components[i];
                value += component.Operation();
            }

            return value;
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }
    }
}
