namespace DesignPatternsGOF.Behavioral.Interpreter.Interfaces
{
    public interface IExpression
    {
        void Interpret
        (
            Context context
        );
    }
}
