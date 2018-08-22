using System;

namespace InterpreterPattern
{
    public abstract class Expresion
    {
        public abstract bool Evalua(string descripcion);

        protected static string origen;
        protected static int position;
        protected static string libro;

        protected static void NextBook()
        {
            while (position < origen.Length && origen[position] == ' ')
            {
                position++;
                if (position == origen.Length)
                {
                    libro = null;
                }
                else if (origen[position] == '(' || origen[position] == ')')
                {
                    libro = origen.Substring(position, 1);
                    position++;
                }
                else
                {
                    int initPosition = position;
                    while (position < origen.Length && origen[position] != ' ' && origen[position] != ')') {
                        position++;
                        libro = origen.Substring(initPosition, position - initPosition);
                    }
                }
            }
        }
        public static Expresion Analiza(string origen)
        {
            Expresion.origen = origen;
            position = 0;
            NextBook();
            return OperatorX.Parse();
        }

        public static Expresion Parse()
        {
            Expresion result;
            if (libro == "(")
            {
                NextBook();
                result = OperatorX.Parse();
                if (libro == null)
                    throw new Exception("Error de sintaxis");
                if (libro != ")")
                    throw new Exception("Error de sintaxis");
                NextBook();
            }
            else
            {
                result = OperatorY.Parse();
            }
            return result;
        }
    }
}
