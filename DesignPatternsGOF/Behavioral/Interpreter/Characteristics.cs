using DesignPatternsGOF.Behavioral.Interpreter.Interfaces;
using DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Skills;
using DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Weaknesses;

namespace DesignPatternsGOF.Behavioral.Interpreter
{
    public class Characteristics(List<ISkill> skills, List<IWeaknesses> weaknesses) : IExpression
    {
        private readonly List<ISkill> _skills = skills;
        private readonly List<IWeaknesses> _weaknesses = weaknesses;

        public void Interpret
        (
            Context context
        )
        {
            Console.WriteLine(context.Personage);

            context.Content += "Showing characteristics...\n";
            context.Content += "Skills:\n";

            foreach (ISkill skill in _skills)
            {
                skill.Interpret(context);
            }

            context.Content += "Weaknesses:\n";

            foreach (IWeaknesses weakness in _weaknesses)
            {
                weakness.Interpret(context);
            }

            Console.WriteLine(context.Content);
        }
    }
}
