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
            //buscarCerdos(1);
        }
        
       

        private static void AddCerdo()//crear metodo para adicionar cerdo
        {
            var cerdo = new Cerdo()
            {
                //IdCerdos = 1, por defecto crea la llave primaria 
                Nombre = "Cerdo tres",
                Color = "Flores",
                Especie = "bonita",
                Raza = "mejorada dos",
                
            };

            _repoCerdo.AddCerdo(cerdo);

        }
        private static void buscarCerdos(int IdCerdos)
        {
            var cerdo = _repoCerdo.GetCerdo(IdCerdos);
            Console.WriteLine(cerdo);

        }
    }
    
}
