namespace InterpreterPattern
{
    public class OperatorY : BinaryOperator
    {
        public OperatorY(Expresion leftOperator, Expresion rightOperator)
            : base(leftOperator, rightOperator) { }

        public override bool Evalua(string descripcion)
        {
            return _leftOperator.Evalua(descripcion) && _rightOperator.Evalua(descripcion);
        }

        public new static Expresion Parse()
        {
            Expresion leftResult = Expresion.Parse();
            while (libro != null && libro == "y")
            {
                NextBook();
                Expresion rightResult = Expresion.Parse();
                leftResult = new OperatorY(leftResult, rightResult);
            }
            return leftResult;
        }

    }
}