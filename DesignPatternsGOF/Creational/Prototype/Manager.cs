namespace DesignPatternsGOF.Creational.Prototype
{
    public class Manager
    {
        private readonly Dictionary<string, StudioModel> studioMany = [];

        public StudioModel this[string key]
        {
            get { return studioMany[key]; }
            set { studioMany[key] = value; }
        }
    }
}
