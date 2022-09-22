using System;
using System.Collections.Generic;
using CuidadoPorcino.App.Dominio;
using System.Linq;

namespace CuidadoPorcino.App.Persistencia
{
    public class RepositorioControlSignos : INRepositorioControlSignos
    {
        private readonly AppContext _appContext; // crer objeto de la AppContex
        public RepositorioControlSignos(AppContext appContext) // crear el constructor
        {
            _appContext = appContext; // el parametro se igula con el objeto
        }
        ControlSignos INRepositorioControlSignos.AddControlSignos(ControlSignos controlSignos) // metodo adicionar cerdo, retorna tipo cerdo
        {
            var controlSignosAdicionado = _appContext.ControlSignos.Add(controlSignos);// crear variabale "cerdoAdicionado " de tipo var
            //_appContext.Cerdos.Add(cerdo); se crea con tutor mercelo y funciona
            _appContext.SaveChanges(); // guardar cambios
            return controlSignosAdicionado.Entity;
            // return null; creado con tutor marcelo funciona
        }

        void INRepositorioControlSignos.DeleteControlSignos(int idControlSignos) // metodo eliminar cerdo, no retorna
        {
            var controlSignosEncontrado = _appContext.ControlSignos.FirstOrDefault(p => p.IdControlSigno == idControlSignos); //buscar persona con el comando FirstOrDefault()
            if (controlSignosEncontrado == null)
            {
                return;
            }
            _appContext.ControlSignos.Remove(controlSignosEncontrado);
            _appContext.SaveChanges(); // guardar cambios

        }

        IEnumerable<ControlSignos> INRepositorioControlSignos.GetAllControlSignos()//metodo para listar todos las personas
        {
            return _appContext.ControlSignos;
        }

        ControlSignos INRepositorioControlSignos.GetControlSignos(int idControlSignos)// metodo para listar una persona
        {
            return _appContext.ControlSignos.FirstOrDefault(p => p.IdControlSigno == idControlSignos);
        }

        ControlSignos INRepositorioControlSignos.UpdateControlSignos(ControlSignos controlSignos) // metodo para mdificar una persona
        {
            var controlSignosEncontrado = _appContext.ControlSignos.FirstOrDefault(p => p.IdControlSigno == controlSignos.IdControlSigno);
            if (controlSignosEncontrado != null)
            {
                controlSignosEncontrado.IdControlSigno = controlSignos.IdControlSigno;
                controlSignosEncontrado.Temperatura = controlSignos.Temperatura;
                controlSignosEncontrado.Peso = controlSignos.Peso;
                controlSignosEncontrado.FrecuenciaRespiratoria = controlSignos.FrecuenciaRespiratoria;
                controlSignosEncontrado.FrecuenciaCardiaca = controlSignos.FrecuenciaCardiaca;
                controlSignosEncontrado.EstadoDeAnimo = controlSignos.EstadoDeAnimo;
                controlSignosEncontrado.DescripcionRecomendacion = controlSignos.DescripcionRecomendacion;
                controlSignosEncontrado.FormulaMedicamentos = controlSignos.FormulaMedicamentos;
                controlSignosEncontrado.FechaVisita = controlSignos.FechaVisita;
                controlSignosEncontrado.historiaClinica = controlSignos.historiaClinica;

                _appContext.SaveChanges();
            }
            return controlSignosEncontrado;
        }
    }
}