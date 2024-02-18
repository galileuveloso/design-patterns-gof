namespace DesignPatternsGOF.Behavioral.TemplateMethod.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public IList<Actions> Actions { get; set; }
    }
}
