namespace DesignPatternsGOF.Behavioral.TemplateMethod.Models
{
    public abstract class ProcessesData(string xml = "", string json = "")
    {
        protected IList<Person> personMany;
        protected string xml = xml;
        protected string json = json;

        public virtual void ProcessXlm() { }

        public virtual void ProcessJson() { }

        protected void Show()
        {
            foreach (var pessoa in personMany)
            {
                Console.WriteLine(new String('#', 40));
                Console.WriteLine("Client: " + pessoa.Name);

                double value = 0;

                foreach (var action in pessoa.Actions)
                {
                    Console.WriteLine(new String('-', 30));

                    value += action.Value;

                    Console.WriteLine(action.Abbreviations);
                    Console.WriteLine("Value: " + action.Value.ToString("C"));
                    Console.WriteLine("Count: " + action.Count);
                    Console.WriteLine("Total: " + value.ToString("C"));
                }
            }
        }
    }
}
