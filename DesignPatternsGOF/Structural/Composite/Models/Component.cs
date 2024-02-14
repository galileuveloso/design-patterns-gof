namespace DesignPatternsGOF.Structural.Composite.Models
{
    public abstract class Component
    {
        public abstract double Operation();
        public abstract void Add(params Component[] components);
        public abstract void Remove(Component component);
        public abstract Component? GetChild(int index);
    }
}
