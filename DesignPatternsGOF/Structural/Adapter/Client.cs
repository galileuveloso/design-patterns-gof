using DesignPatternsGOF.Structural.Aapter;

namespace DesignPatternsGOF.Structural.Adapter
{
    public class Client
    {
        public void Execute()
        {
            CloudComputing cloud = new();

            cloud.Process("January");
        }
    }
}
