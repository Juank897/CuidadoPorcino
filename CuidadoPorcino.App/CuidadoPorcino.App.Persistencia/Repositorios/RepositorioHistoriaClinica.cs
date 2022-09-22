using System;
using System.Collections.Generic;
using CuidadoPorcino.App.Dominio;
using System.Linq;

namespace CuidadoPorcino.App.Persistencia
{
    public class RepositorioHistoriaClinica : INRepositorioHistoriaClinica
    {
        private readonly AppContext _appContext; // crer objeto de la AppContex
        public RepositorioHistoriaClinica(AppContext appContext) // crear el constructor
        {
            _appContext = appContext; // el parametro se igula con el objeto
        }
        HistoriaClinica INRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica historiaClinica) // metodo adicionar cerdo, retorna tipo cerdo
        {
            var historiaClinicaAdicionado = _appContext.HistoriaClinicas.Add(historiaClinica);// crear variabale "cerdoAdicionado " de tipo var
            //_appContext.Cerdos.Add(cerdo); se crea con tutor mercelo y funciona
            _appContext.SaveChanges(); // guardar cambios
            return historiaClinicaAdicionado.Entity;
            // return null; creado con tutor marcelo funciona
        }

        void INRepositorioHistoriaClinica.DeleteHistoriaClinica(int idHistoriaClinica) // metodo eliminar cerdo, no retorna
        {
            var historiaClinicaEncontrado = _appContext.HistoriaClinicas.FirstOrDefault(p => p.IdHistoriaClinica == idHistoriaClinica); //buscar persona con el comando FirstOrDefault()
            if (historiaClinicaEncontrado == null)
            {
                return;
            }
            _appContext.HistoriaClinicas.Remove(historiaClinicaEncontrado);
            _appContext.SaveChanges(); // guardar cambios

        }

        IEnumerable<HistoriaClinica> INRepositorioHistoriaClinica.GetAllHistoriaClinica()//metodo para listar todos las personas
        {
            return _appContext.HistoriaClinicas;
        }

        HistoriaClinica INRepositorioHistoriaClinica.GetHistoriaClinica(int idHistoriaClinica)// metodo para listar una persona
        {
            return _appContext.HistoriaClinicas.FirstOrDefault(p => p.IdHistoriaClinica == idHistoriaClinica);
        }

        HistoriaClinica INRepositorioHistoriaClinica.UpdateHistoriaClinica(HistoriaClinica historiaClinica) // metodo para mdificar una persona
        {
            var historiaClinicaEncontrado = _appContext.HistoriaClinicas.FirstOrDefault(p => p.IdHistoriaClinica == historiaClinica.IdHistoriaClinica);
            if (historiaClinicaEncontrado != null)
            {
                historiaClinicaEncontrado.IdHistoriaClinica = historiaClinica.IdHistoriaClinica;
                historiaClinicaEncontrado.FechaApertura = historiaClinica.FechaApertura;
                historiaClinicaEncontrado.cerdo = historiaClinica.cerdo;

                
                
                _appContext.SaveChanges();
            }
            return historiaClinicaEncontrado;
        }
    }
}