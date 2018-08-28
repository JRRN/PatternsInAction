using System;

namespace InterpreterPattern
{
    public class Word : Expresion
    {
        protected string palabraClave;

        public Word(string palabraClave)
        {
            this.palabraClave = palabraClave;
        }

        public override bool Evalua(string descripcion) => descripcion.IndexOf(palabraClave) != -1;
        public new static Expresion Parsea()
        {
            Expresion resultado = new Word(_pieza);
            SiguienteExpression();
            return resultado;
        }
    }
}