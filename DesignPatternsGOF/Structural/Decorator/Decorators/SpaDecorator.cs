using DesignPatternsGOF.Structural.Decorator.Interfaces;

namespace DesignPatternsGOF.Structural.Decorator.Decorators
{
    public class SpaDecorator(IPet pet) : PetDecorator(pet)
    {
        public override string GetName()
        {
            return base.GetName() + "\n [+] Spa";
        }

        public override double GetValue()
        {
            return base.GetValue() + 200.00;
        }
    }
}
