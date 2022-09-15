// See https://aka.ms/new-console-template for more information

using System;
using CuidadoPorcino.App.Dominio;
using CuidadoPorcino.App.Persistencia;
namespace CuidadoPorcino.App.Consola1
{
    class Program
    {
        private static INRepositorioCerdo _repoCerdo = new RepositorioCerdo(new Persistencia.AppContext());
        static void Main(string[]args)
        {
            Console.WriteLine("Hello, Juan Carlos!");
            AddCerdo();
        }

        private static void AddCerdo()//crear metodo para adicionar cerdo
        {
            var cerdo = new Cerdo()
            {
                //IdCerdos = 1, por defecto crea la llave primaria 
                Nombre = "Pepa",
                Color = "Blanco",
                Especie = "Carne",
                Raza = "Feliz"
            };

            _repoCerdo.AddCerdo(cerdo);

        }
    }
    
}
