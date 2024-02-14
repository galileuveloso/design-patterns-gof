using DesignPatternsGOF.Structural.Decorator.Interfaces;

namespace DesignPatternsGOF.Structural.Decorator.Decorators
{
    public class AcessoryDecorator(IPet pet) : PetDecorator(pet)
    {
        public override string GetName()
        {
            return base.GetName() + "\n [+] Acessory";
        }

        public override double GetValue()
        {
            return base.GetValue() + 30.00;
        }
    }
}
