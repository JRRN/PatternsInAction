using System;
using SingletonPattern;

namespace PatternsInAction.Construccion
{
    public class Singleton
    {
        public static void Show()
        {
            EditorialSingleton laEditorial = EditorialSingleton.Instance();
            laEditorial.nombreEditorial = "JRRN Publicaciones";
            laEditorial.ubicacion = "Barcelona";
            laEditorial.fechaEditorial = new DateTime(2018,05,11);

            EditorialSingleton _laEditorial = EditorialSingleton.Instance();
            _laEditorial.Visualiza();
        }
    }
}