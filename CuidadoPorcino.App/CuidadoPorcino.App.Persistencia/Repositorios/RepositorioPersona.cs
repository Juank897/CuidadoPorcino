using System;
using System.Collections.Generic;
using CuidadoPorcino.App.Dominio;
using System.Linq;

namespace CuidadoPorcino.App.Persistencia
{
    public class RepositorioPersona : INRepositorioPersona
    {
        private readonly AppContext _appContext; // crer objeto de la AppContex
        public RepositorioPersona(AppContext appContext) // crear el constructor
        {
            _appContext = appContext; // el parametro se igula con el objeto
        }
        Persona INRepositorioPersona.AddPersona(Persona persona) // metodo adicionar cerdo, retorna tipo cerdo
        {
            var personaAdicionado = _appContext.Personas.Add(persona);// crear variabale "cerdoAdicionado " de tipo var
            //_appContext.Cerdos.Add(cerdo); se crea con tutor mercelo y funciona
            _appContext.SaveChanges(); // guardar cambios
            return personaAdicionado.Entity;
            // return null; creado con tutor marcelo funciona
        }

        void INRepositorioPersona.DeletePersona(int idPersona) // metodo eliminar cerdo, no retorna
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(p => p.IdPersona == idPersona); //buscar persona con el comando FirstOrDefault()
            if (personaEncontrado == null)
            {
                return;
            }
            _appContext.Personas.Remove(personaEncontrado);
            _appContext.SaveChanges(); // guardar cambios

        }

        IEnumerable<Persona> INRepositorioPersona.GetAllPersonas()//metodo para listar todos las personas
        {
            return _appContext.Personas;
        }

        Persona INRepositorioPersona.GetPersona(int idPersona)// metodo para listar una persona
        {
            return _appContext.Personas.FirstOrDefault(p => p.IdPersona == idPersona);
        }

        Persona INRepositorioPersona.UpdatePersona(Persona persona) // metodo para mdificar una persona
        {
            var personaEncontrado = _appContext.Personas.FirstOrDefault(p => p.IdPersona == persona.IdPersona);
            if (personaEncontrado != null)
            {
                personaEncontrado.IdPersona = persona.IdPersona;
                personaEncontrado.Nombres = persona.Nombres;
                personaEncontrado.Apellidos = persona.Apellidos;
                personaEncontrado.Direccion = persona.Direccion;
                personaEncontrado.Telefono = persona.Telefono;
                
                _appContext.SaveChanges();
            }
            return personaEncontrado;
        }
    }
}