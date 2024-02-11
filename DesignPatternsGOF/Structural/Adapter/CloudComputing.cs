using DesignPatternsGOF.Structural.Aapter.Interfaces;

namespace DesignPatternsGOF.Structural.Aapter
{
    public class CloudComputing
    {
        private readonly IAdapter _adapter = new Adapter(new Business());

        public void Process(string month)
        {
            Console.WriteLine("Processing request..");

            var toPay = _adapter.GetBillsToPay(month);

            Console.WriteLine("To pay: \n" + toPay);

            var toRecive = _adapter.GetBillsToReceive(month);

            Console.WriteLine("To receive: \n" + toRecive);

            Console.WriteLine("Request finaly.");
        }
    }
}
