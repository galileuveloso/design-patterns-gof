using DesignPatternsGOF.Structural.Decorator.Interfaces;

namespace DesignPatternsGOF.Structural.Decorator.Decorators
{
    public abstract class PetDecorator : IPet
    {
        protected IPet _pet;

        protected PetDecorator(IPet pet)
        {
            _pet = pet;
        }

        public virtual string GetName()
        {
            return _pet.GetName();
        }

        public virtual double GetValue()
        {
            return _pet.GetValue();
        }
    }
}
