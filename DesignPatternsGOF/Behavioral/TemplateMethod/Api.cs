using DesignPatternsGOF.Behavioral.TemplateMethod.Models;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace DesignPatternsGOF.Behavioral.TemplateMethod
{
    public class Api
    {
        public static string GetXml()
        {
            IList<Person> personMany = GetPersonMany();

            XmlSerializer xlm = new(personMany.GetType());

            using var writer = new StringWriter();
            xlm.Serialize(writer, personMany);
            return writer.ToString();
        }

        public static string GetJson()
        {
            IList<Person> personMany = GetPersonMany();

            return Newtonsoft.Json.JsonConvert.SerializeObject(personMany, Formatting.Indented);
        }

        private static IList<Person> GetPersonMany()
            => new List<Person>
            {
                new() {
                        Name = "Galileu",
                        Cpf = "836.377.420-04",
                        Actions = new List<Actions>
                        {
                            new("AAAA3", 50, 15.44),
                            new("BBBB4", 80, 22.34)
                        }
                },
                new() {
                        Name = "John",
                        Cpf = "084.220.850-03",
                        Actions = new List<Actions>
                        {
                            new("GGGG6", 50, 15.44),
                            new("RRRR3", 80, 22.34)
                        }
                }
            };
    }
}
