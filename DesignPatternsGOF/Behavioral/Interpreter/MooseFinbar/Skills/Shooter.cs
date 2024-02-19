namespace DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Skills
{
    public class Shooter : ISkill
    {
        public void Interpret
        (
            Context context
        )
        {
            context.Content += "[+] - Weapons handling \n";
        }
    }
}
