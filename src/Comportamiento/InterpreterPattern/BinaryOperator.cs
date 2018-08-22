namespace InterpreterPattern
{
    public abstract class BinaryOperator : Expresion
    {
        protected Expresion _leftOperator, _rightOperator;
        protected BinaryOperator(Expresion leftOperator, Expresion rightOperator)
        {
            _leftOperator = leftOperator;
            _rightOperator = rightOperator;
        }
    }
}