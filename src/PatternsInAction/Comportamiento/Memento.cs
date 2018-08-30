using MementoPattern;

namespace PatternsInAction.Comportamiento
{
    class Memento
    {
        public  static void Show()
        {
            OpcionBook op1 = new OpcionBook("Tapa dura");
            OpcionBook op2 = new OpcionBook("Tapa Blanda");
            OpcionBook op3 = new OpcionBook("Tapa Encuadernado");

            op1.AgregaOpcionIncompatible(op3);
            op2.AgregaOpcionIncompatible(op3);

            CompraOpciones compraOpciones = new CompraOpciones();
            compraOpciones.AgregaOpciones(op1);
            compraOpciones.AgregaOpciones(op2);
            compraOpciones.Visualiza();

            var memento = compraOpciones.AgregaOpciones(op3);
            compraOpciones.Visualiza();
            compraOpciones.Anula(memento);
            compraOpciones.Visualiza();
        }
    }
}