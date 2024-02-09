using DesignPatternsGOF.Creational.Builder.Builders;

namespace DesignPatternsGOF.Creational.Builder
{
    public class Director
    {
        public void BuildStudio(StudioBuilder builder)
        {
            builder.SetFloor();
            builder.SetFinancing();
            builder.SetValue();
        }
    }
}
