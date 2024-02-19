namespace DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Weaknesses
{
    public class Force : IWeaknesses
    {
        public void Interpret
        (
            Context context
        )
        {
            context.Content += "[-] - Force \n";
        }
    }
}
