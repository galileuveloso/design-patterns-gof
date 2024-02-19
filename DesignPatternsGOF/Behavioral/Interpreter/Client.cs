using DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Skills;
using DesignPatternsGOF.Behavioral.Interpreter.MooseFinbar.Weaknesses;

namespace DesignPatternsGOF.Behavioral.Interpreter
{
    public class Client
    {
        public void Execute()
        {
            List<ISkill> skills =
            [
                new Shooter(),
                new Zoology()
            ];

            List<IWeaknesses> weaknesses =
            [
                new Cake(),
                new Force(),
                new Speed()
            ];

            var mooseFinbar = new Context("Moose Finbar");

            var characteristics = new Characteristics(skills, weaknesses);

            characteristics.Interpret(mooseFinbar);
        }
    }
}
