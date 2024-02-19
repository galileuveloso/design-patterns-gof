namespace DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Weaknesses
{
    public class Speed : IWeaknesses
    {
        public void Interpret
        (
            Context context
        )
        {
            context.Content += "[-] - Speed \n";
        }
    }
}
