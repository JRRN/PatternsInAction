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
            _grosorPapel = GetGrosorByTipoLibro((int)tipoLibro);
            _tapa = GetTapaByTipoLibro((int)tipoLibro);
        }

        public void VerOpcionesLibro() 
            => Console.WriteLine(
            $"Libro con tapa {_tapa} y grosor de papel {_grosorPapel} " +
            $"para el tipo de libro selecionado {_tipoLibro}");

        private int GetGrosorByTipoLibro(int tipoLibro)
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

        private string GetTapaByTipoLibro(int tipoLibro)
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