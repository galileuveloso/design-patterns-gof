using DesignPatternsGOF.Structural.Aapter.Interfaces;

namespace DesignPatternsGOF.Structural.Aapter
{
    public class Adapter(Business legacy) : IAdapter
    {
        private readonly Business _legacy = legacy;

        public string GetBillsToPay
        (
            string month
        )
        {
            return _legacy.GetBillsToPay(month);
        }

        public string GetBillsToReceive
        (
            string month
        )
        {
            return _legacy.GetBillsToReceive(month);
        }
    }
}
