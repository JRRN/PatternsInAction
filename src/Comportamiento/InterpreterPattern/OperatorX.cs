namespace InterpreterPattern
{
    public class OperatorX : BinaryOperator
    {
        public OperatorX(Expresion leftExpresion, Expresion rightExpresion)
            : base(leftExpresion, rightExpresion) { }

        public override bool Evalua(string descripcion) => _leftExpresion.Evalua(descripcion) || _rightExpresion.Evalua(descripcion);

        public static Expresion parsea()
        {
            Expresion leftResult = OperatorY.Parsea();
            while (_pieza != null && _pieza == "o")
            {
                SiguienteExpression();
                Expresion rightResult = OperatorY.Parsea();
                leftResult = new OperatorX(leftResult, rightResult);
            }
            return leftResult;
        }
    }
}