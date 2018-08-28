namespace InterpreterPattern
{
    public abstract class BinaryOperator : Expresion
    {
        protected Expresion _leftExpresion, _rightExpresion;

        protected BinaryOperator(Expresion leftExpresion, Expresion rightExpresion)
        {
            _leftExpresion = leftExpresion;
            _rightExpresion = rightExpresion;
        }
    }
}