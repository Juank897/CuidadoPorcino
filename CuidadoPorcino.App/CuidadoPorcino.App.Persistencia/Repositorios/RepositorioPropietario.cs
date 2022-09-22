using System;
using System.Collections.Generic;
using CuidadoPorcino.App.Dominio;
using System.Linq;

namespace CuidadoPorcino.App.Persistencia
{
    public class RepositorioPropietario : INRepositorioPropietario
    {
        private readonly AppContext _appContext; // crer objeto de la AppContex
        public RepositorioPropietario(AppContext appContext) // crear el constructor
        {
            _appContext = appContext; // el parametro se igula con el objeto
        }
        Propietario INRepositorioPropietario.AddPropietario(Propietario propietario) // metodo adicionar cerdo, retorna tipo cerdo
        {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);// crear variabale "cerdoAdicionado " de tipo var
            //_appContext.Cerdos.Add(cerdo); se crea con tutor mercelo y funciona
            AsignarPersona(1, propietario);
            _appContext.SaveChanges(); // guardar cambios
            return propietarioAdicionado.Entity;
            // return null; creado con tutor marcelo funciona
        }

        void INRepositorioPropietario.DeletePropietario(int idPropietario) // metodo eliminar cerdo, no retorna
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.IdPropietario== idPropietario); //buscar persona con el comando FirstOrDefault()
            if (propietarioEncontrado == null)
            {
                return;
            }
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges(); // guardar cambios

        }

        IEnumerable<Propietario> INRepositorioPropietario.GetAllPropietarios()//metodo para listar todos las personas
        {
            return _appContext.Propietarios;
        }

        Propietario INRepositorioPropietario.GetPropietario(int idPropietario)// metodo para listar una persona
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.IdPropietario == idPropietario);
        }

        Propietario INRepositorioPropietario.UpdatePropietario(Propietario propietario) // metodo para mdificar una persona
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.IdPropietario == propietario.IdPropietario);
            if (propietarioEncontrado != null)
            {
                propietarioEncontrado.IdPropietario = propietario.IdPropietario;
                propietarioEncontrado.Email = propietario.Email;
                propietarioEncontrado.persona= propietario.persona;
                
                
                _appContext.SaveChanges();
            }
            return propietarioEncontrado;
        }

        public Persona AsignarPersona(int idPersona, Propietario propietario)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(j=>j.IdPersona==j.idPersona);
            if(personaEncontrada!=null)
            {
                propietario.persona = personaEncontrada;
                _appContext.SaveChanges();
                return personaEncontrada;
            }
            return null;
        }
    }
}