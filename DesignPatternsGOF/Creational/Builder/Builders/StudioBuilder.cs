using DesignPatternsGOF.Creational.Builder.Studios;

namespace DesignPatternsGOF.Creational.Builder.Builders
{
    public abstract class StudioBuilder
    {
        protected Studio Studio;

        public Studio GetStudio() => Studio;

        public abstract void SetFloor();
        public abstract void SetFinancing();
        public abstract void SetValue();
    }
}
