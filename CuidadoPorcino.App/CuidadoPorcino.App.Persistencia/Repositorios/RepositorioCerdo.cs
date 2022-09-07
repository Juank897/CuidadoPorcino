using System;
using System.Collections.Generic;
using CuidadoPorcino.App.Dominio;
using System.Linq;

namespace CuidadoPorcino.App.Persistencia
{
    public class RepositorioCerdo : INRepositorioCerdo
    {
        private readonly AppContext _appContext; // crer objeto de la AppContex
        public RepositorioCerdo(AppContext appContext) // crear el constructor
        {
            _appContext = appContext; // el parametro se igula con el objeto
        }
        Cerdo INRepositorioCerdo.AddCerdo(Cerdo cerdo) // metodo adicionar cerdo, retorna tipo cerdo
        {
            //Console.WriteLine("El valor es " + cerdo.Color );

            var cerdoAdicionado = _appContext.Cerdos.Add(cerdo);// crear variabale "cerdoAdicionado " de tipo var
            //_appContext.Cerdos.Add(cerdo); creo con tutor mercelo y funciona
            _appContext.SaveChanges(); // guardar cambios
            return cerdoAdicionado.Entity;
            // return null; creado con tutor marcelo funciona
        }

        void INRepositorioCerdo.DeleteCerdo(int idCerdos)
        {
            var cerdoEncontrado = _appContext.Cerdos.FirstOrDefault(p => p.IdCerdos == idCerdos); //buscar el cerdo con el comando FirstOrDefault()
            if (cerdoEncontrado == null)
            {
                return;
            }
            _appContext.Cerdos.Remove(cerdoEncontrado);
        }

        IEnumerable<Cerdo> INRepositorioCerdo.GetAllCerdos()
        {
            return _appContext.Cerdos;
        }

        Cerdo INRepositorioCerdo.GetCerdo(int idCerdos)
        {
            return _appContext.Cerdos.FirstOrDefault(p => p.IdCerdos == idCerdos);
        }

        Cerdo INRepositorioCerdo.UpdateCerdo(Cerdo cerdo)
        {
            var cerdoEncontrado = _appContext.Cerdos.FirstOrDefault(p => p.IdCerdos == cerdo.IdCerdos);
            if (cerdoEncontrado != null)
            {
                cerdoEncontrado.IdCerdos = cerdo.IdCerdos;
                cerdoEncontrado.Nombre = cerdo.Nombre;
                cerdoEncontrado.Color = cerdo.Color;
                cerdoEncontrado.Raza = cerdo.Raza;
                // todos los atributos
                _appContext.SaveChanges();
            }
            return cerdoEncontrado;
        }
    }
}