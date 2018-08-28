namespace InterpreterPattern
{
    public class OperatorY : BinaryOperator
    {
        public OperatorY(Expresion leftExpresion, Expresion rightExpresion)
            : base(leftExpresion, rightExpresion) { }

        public override bool Evalua(string descripcion)
        {
            return _leftExpresion.Evalua(descripcion) &&_rightExpresion.Evalua(descripcion);
        }

        public static Expresion Parsea()
        {
            Expresion leftResult = Expresion.Parsea();
            while (_pieza != null && _pieza == "y")
            {
                SiguienteExpression();
                Expresion rightResult = Parsea();
                leftResult = new OperatorY(leftResult, rightResult);
            }
            return leftResult;
        }
    }
}