using DesignPatternsGOF.Creational.Builder.Studios;

namespace DesignPatternsGOF.Creational.Builder.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder()
        {
            Studio = new Studio26m();
        }

        public override void SetFinancing()
        {
            Studio.SetFinancing("Private");
        }

        public override void SetFloor()
        {
            Studio.SetFloor("Porcelain");
        }

        public override void SetValue()
        {
            Studio.SetValue(110000.00M);
        }
    }
}
