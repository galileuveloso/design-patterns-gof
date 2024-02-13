using DesignPatternsGOF.Structural.Bridge.Abstraction.Interfaces;
using DesignPatternsGOF.Structural.Bridge.Implementation.Interfaces;

namespace DesignPatternsGOF.Structural.Bridge.Abstraction
{
    public class Brush : IMaterial
    {
        public IColor ColorImplementation { get; set; }

        public string Query()
        {
            return ColorImplementation.Count("brush");
        }
    }
}
