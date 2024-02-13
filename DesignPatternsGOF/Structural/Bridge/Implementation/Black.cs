using DesignPatternsGOF.Structural.Bridge.Implementation.Interfaces;

namespace DesignPatternsGOF.Structural.Bridge.Implementation
{
    public class Black : IColor
    {
        public string Count(string type)
        {
            var count = new Random().Next(100, 500);

            return $"Has {count} black {type}";
        }
    }
}
