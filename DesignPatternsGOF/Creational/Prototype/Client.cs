namespace DesignPatternsGOF.Creational.Prototype
{
    public class Client
    {
        public void Execute()
        {
            var manager = new Manager();

            manager["24m"] = new Studio("24m", "State", 100000.00M);

            manager["26m"] = new Studio("26m", "Private", 110000.00M);

            manager["28m"] = new Studio("28m", "Heritage", 120000.00M);

            _ = manager["24m"].Clone();
            _ = manager["26m"].Clone();
            _ = manager["28m"].Clone();
        }
    }
}
