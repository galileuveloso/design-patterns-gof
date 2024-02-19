namespace DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Skills
{
    public class Zoology : ISkill
    {
        public void Interpret
        (
            Context context
        )
        {
            context.Content += "[+] - Expert zoologist \n";
        }
    }
}
