namespace DesignPatternsGOF.Behavioral.TemplateMethod.Models
{
    public class Actions
    {
        public Actions() { }

        public Actions(string abbreviations, int count, double value)
        {
            Abbreviations = abbreviations;
            Count = count;
            Value = value;
        }

        public string Abbreviations { get; set; }
        public int Count { get; set; }
        public double Value { get; set; }
    }
}
