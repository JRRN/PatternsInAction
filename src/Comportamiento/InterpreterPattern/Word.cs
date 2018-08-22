using System;

namespace InterpreterPattern
{
    public class Word : Expresion
    {
        protected string _word;

        public Word(string word)
        {
            _word = word;
        }

        public override bool Evalua(string descripcion)
        {
            return descripcion.IndexOf(_word, StringComparison.Ordinal) != -1;
        }

        public new static Expresion Parse()
        {
            Expresion result;
            result = new Word("pieza");
            NextBook();
            return result;
        }

    }
}