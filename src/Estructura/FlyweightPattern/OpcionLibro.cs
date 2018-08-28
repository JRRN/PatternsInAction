using System;

namespace FlyweightPattern
{
    public class OpcionLibro
    {
        protected string _tapa;
        protected int _grosorPapel;
        protected TipoLibroEnum _tipoLibro;

        public OpcionLibro(TipoLibroEnum tipoLibro)
        {
            _tipoLibro = tipoLibro;
            _grosorPapel = getGrosorByTipoLibro((int)tipoLibro);
            _tapa = getTapaByTipoLibro((int)tipoLibro);
        }

        public void VerOpcionesLibro()
        {
            Console.WriteLine(
                $"Libro con {_tapa} y grosor de papel {_grosorPapel} para el tipo de libro selecionado {_tipoLibro}");
        }

        private int getGrosorByTipoLibro(int tipoLibro)
        {
            switch (tipoLibro)
            {
                case 0:
                    return 80;
                case 1:
                    return 100;
            }

            return 90; //default
        }

        private string getTapaByTipoLibro(int tipoLibro)
        {
            switch (tipoLibro)
            {
                case 0:
                    return "blanda";
                case 1:
                    return "dura";
            }

            return "blanda"; //default
        }
    }
}