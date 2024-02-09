using DesignPatternsGOF.Creational.Builder.Studios;

namespace DesignPatternsGOF.Creational.Builder.Builders
{
    public class Studio24mBuilder : StudioBuilder
    {
        public Studio24mBuilder()
        {
            Studio = new Studio24m();
        }

        public override void SetFinancing()
        {
            Studio.SetFinancing("State");
        }

        public override void SetFloor()
        {
            Studio.SetFloor("Ceramics");
        }

        public override void SetValue()
        {
            Studio.SetValue(100000.00M);
        }
    }
}
