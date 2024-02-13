using DesignPatternsGOF.Structural.Bridge.Implementation.Interfaces;

namespace DesignPatternsGOF.Structural.Bridge.Abstraction.Interfaces
{
    public interface IMaterial
    {
        public IColor ColorImplementation { get; set; }
        public string Query();
    }
}
