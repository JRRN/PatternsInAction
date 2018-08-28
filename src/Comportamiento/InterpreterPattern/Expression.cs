using System;

namespace InterpreterPattern
{
    public abstract class Expresion
    {
        public abstract bool Evalua(string descripcion);

        protected static string _fuente;
        protected static int _indice;
        protected static string _pieza;

        protected static void SiguienteExpression()
        {
            while (_indice < _fuente.Length && _fuente[_indice] == ' ')
            {
                _indice++;
                if (_indice == _fuente.Length) { _pieza = null; }
                else if (_fuente[_indice] == '(' || _fuente[_indice] ==')')
                {
                    _pieza = _fuente.Substring(_indice, 1);
                    _indice++;
                }
                else
                {
                    int inicio = _indice;
                    while (_indice < _fuente.Length && _fuente[_indice] !=' ' && _fuente[_indice] != ')')
                    {
                        _indice++;
                    }

                    _pieza = _fuente.Substring(inicio, _indice - inicio);
                }
            }
        }

        public static Expresion Analiza(string fuente)
        {
            _fuente = fuente;
            _indice = 0;
            SiguienteExpression();
            return OperatorX.parsea();
        }

        public static Expresion Parsea()
        {
            Expresion resultado;
            if (_pieza == "(")
            {
                SiguienteExpression();
                resultado = OperatorX.Parsea();
                if (_pieza == null)
                    throw new Exception("Error de sintaxis");
                if (_pieza != ")")
                    throw new Exception("Error de sintaxis");
                SiguienteExpression();
            }
            else
                resultado = Word.Parsea();
            return resultado;
        }
    }
}
