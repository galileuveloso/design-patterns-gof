namespace DesignPatternsGOF.Creational.Builder.Studios
{
    public abstract class Studio
    {
        public string Floor { get; protected set; }
        public string Financing { get; protected set; }
        public decimal Value { get; protected set; }

        public abstract void SetFloor(string floor);
        public abstract void SetFinancing(string financing);
        public abstract void SetValue(decimal value);
    }
}
