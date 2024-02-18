using DesignPatternsGOF.Behavioral.TemplateMethod.Models;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatternsGOF.Behavioral.TemplateMethod
{
    public class XmlConvert(string xml) : ProcessesData(xml)
    {
        public override void ProcessXlm()
        {
            XmlSerializer serializer = new(personMany.GetType());

            var stringReader = new StringReader(xml);

            using var reader = XmlReader.Create(stringReader);

            personMany = (List<Person>)serializer.Deserialize(reader);

            Show();
        }
    }
}
