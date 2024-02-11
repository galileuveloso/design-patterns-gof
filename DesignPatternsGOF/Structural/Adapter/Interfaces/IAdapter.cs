namespace DesignPatternsGOF.Structural.Aapter.Interfaces
{
    public interface IAdapter
    {
        string GetBillsToPay
        (
            string month
        );

        string GetBillsToReceive
        (
            string month
        );
    }
}
