using DesignPatternsGOF.Structural.Decorator.Interfaces;

namespace DesignPatternsGOF.Structural.Decorator.Services
{
    public class Bath(string name, double value) : IPet
    {
        public string GetName()
        {
            return name;
        }

        public double GetValue()
        {
            return value;
        }
    }
}
