using System;

namespace ProxyPattern
{
    public class Datos : IBook
    {
        public void Renderiza() { }
        public void CargaDescripcion() => Console.WriteLine("Editorial Descripcion");
    }
}