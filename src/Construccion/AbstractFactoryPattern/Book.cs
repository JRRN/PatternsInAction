﻿namespace AbstractFactoryPattern
{
    public abstract class Book
    {
        protected string _titulo;
        protected string _autor;
        protected int _añoPublicacion;
        protected FormatType _formatType;

        protected Book(string titulo, string autor, int añoPublicacion, FormatType formatType)
        {
            _titulo = titulo;
            _autor = autor;
            _añoPublicacion = añoPublicacion;
            _formatType = formatType;
        }

        public abstract void MostrarCaracteristicas();
    }
}