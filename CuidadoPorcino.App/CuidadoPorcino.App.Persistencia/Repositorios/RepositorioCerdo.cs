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
            var cerdoAdicionado = _appContext.Cerdos.Add(cerdo);// crear variabale "cerdoAdicionado " de tipo var
            //_appContext.Cerdos.Add(cerdo); se crea con tutor mercelo y funciona
            _appContext.SaveChanges(); // guardar cambios
            return cerdoAdicionado.Entity;
            // return null; creado con tutor marcelo funciona
        }

        void INRepositorioCerdo.DeleteCerdo(int idCerdos) // metodo eliminar cerdo, no retorna
        {
            var cerdoEncontrado = _appContext.Cerdos.FirstOrDefault(p => p.IdCerdos == idCerdos); //buscar el cerdo con el comando FirstOrDefault()
            if (cerdoEncontrado == null)
            {
                return;
            }
            _appContext.Cerdos.Remove(cerdoEncontrado);
            _appContext.SaveChanges(); // guardar cambios

        }

        IEnumerable<Cerdo> INRepositorioCerdo.GetAllCerdos()//metodo para listar todos los cerdos
        {
            return _appContext.Cerdos;
        }

        Cerdo INRepositorioCerdo.GetCerdo(int idCerdos)// metodo para listar un cerdo
        {
            return _appContext.Cerdos.FirstOrDefault(p => p.IdCerdos == idCerdos);
        }

        Cerdo INRepositorioCerdo.UpdateCerdo(Cerdo cerdo) // metodo para mdificar un cerdo
        {
            var cerdoEncontrado = _appContext.Cerdos.FirstOrDefault(p => p.IdCerdos == cerdo.IdCerdos);
            if (cerdoEncontrado != null)
            {
                // se escriben todos los atributos
                cerdoEncontrado.IdCerdos = cerdo.IdCerdos;
                cerdoEncontrado.Nombre = cerdo.Nombre;
                cerdoEncontrado.Color = cerdo.Color;
                cerdoEncontrado.Especie = cerdo.Especie;
                cerdoEncontrado.Raza = cerdo.Raza;
                cerdoEncontrado.propietario = cerdo.propietario;
                
                _appContext.SaveChanges();
            }
            return cerdoEncontrado;
            
        }
        
    }
}