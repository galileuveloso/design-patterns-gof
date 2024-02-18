namespace DesignPatternsGOF.Behavioral.TemplateMethod
{
    public class Client
    {
        public void Execute()
        {
            Console.WriteLine("__________XML__________");

            var convertXml = new XmlConvert(Api.GetXml());

            convertXml.ProcessXlm();

            Console.WriteLine("__________JSON_________");

            var convertJson = new JsonConvert(Api.GetJson());

            convertJson.ProcessJson();
        }
    }
}
