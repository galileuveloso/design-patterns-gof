namespace DesignPatternsGOF.Behavioral.Interpreter
{
    public class Context(string personage)
    {
        public string Personage { get; set; } = personage;
        public string Content { get; set; } = string.Empty;
    }
}
