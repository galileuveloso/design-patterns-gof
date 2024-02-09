using DesignPatternsGOF.Creational.Builder.Studios;

namespace DesignPatternsGOF.Creational.Builder.Builders
{
    public class Studio28mBuilder : StudioBuilder
    {
        public Studio28mBuilder()
        {
            Studio = new Studio28m();
        }

        public override void SetFinancing()
        {
            Studio.SetFinancing("Heritage");
        }

        public override void SetFloor()
        {
            Studio.SetFloor("Granite");
        }

        public override void SetValue()
        {
            Studio.SetValue(120000.00M);
        }
    }
}
