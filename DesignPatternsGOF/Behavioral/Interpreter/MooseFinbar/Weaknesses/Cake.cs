namespace DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Weaknesses
{
    public class Cake : IWeaknesses
    {
        public void Interpret
        (
            Context context
        )
        {
            context.Content += "[-] - Deadly cake allergy \n";
        }
    }
}
