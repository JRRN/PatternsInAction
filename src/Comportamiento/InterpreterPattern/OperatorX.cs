namespace InterpreterPattern
{
    public class OperatorX : BinaryOperator
    {
        public OperatorX(Expresion leftOperator, Expresion rightOperator)
            : base(leftOperator, rightOperator) { }

        public override bool Evalua(string descripcion)
        {
            return _leftOperator.Evalua(descripcion) || _rightOperator.Evalua(descripcion);
        }

        public new static Expresion Parse()
        {
            Expresion leftResult = OperatorY.Parse();
            while (libro != null && libro == "o")
            {
                NextBook();
                Expresion rightResult = OperatorY.Parse();
                leftResult = new OperatorX(leftResult, rightResult);
            }
            return leftResult;
        }
    }
}