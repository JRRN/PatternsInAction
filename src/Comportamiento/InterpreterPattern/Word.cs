using System;

namespace InterpreterPattern
{
    public class Word : Expresion
    {
        protected string _palabraClave;

        public Word(string palabraClave)
        {
            _palabraClave = palabraClave;
        }

        public override bool Evalua(string descripcion)
        {
            return descripcion.IndexOf(_palabraClave) != -1;
        }
        public new static Expresion Parsea()
        {
            Expresion resultado = new Word(_pieza);
            SiguienteExpression();
            return resultado;
        }
    }
}