using DesignPatternsGOF.Behavioral.TemplateMethod.Models;

namespace DesignPatternsGOF.Behavioral.TemplateMethod
{
    public class JsonConvert(string json) : ProcessesData(json)
    {
        public override void ProcessJson()
        {
            personMany = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(json);

            Show();
        }
    }
}
